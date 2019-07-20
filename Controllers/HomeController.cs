using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private DBContext context;
        private PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        private PasswordHasher<LoginUser> LoginHasher = new PasswordHasher<LoginUser>();
        public HomeController(DBContext dbc)
        {
            context = dbc;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User u)
        {
            if(ModelState.IsValid)
            {
                u.Password = RegisterHasher.HashPassword(u, u.Password);
                context.Users.Add(u);
                context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", u.UserId);
                return Redirect("/success");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser l)
        {
            if(ModelState.IsValid)
            {
                User logging_in_user = context.Users.FirstOrDefault(u => u.Email == l.LoginEmail);
                if(logging_in_user != null)
                {
                    var result = LoginHasher.VerifyHashedPassword(l, logging_in_user.Password, l.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginPassword", "Invalid Password");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("UserId", logging_in_user.UserId);
                        return Redirect("/success");
                    }
                }
                else
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email");
                }
            }
            return View("Index");
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            List<Party> Partys = context.Partys.Include(p => p.Planner).Include(p => p.AttendingUsers).OrderBy(p => p.Date).ToList();
            for(int i=0; i<Partys.Count; i++)
            {
                if(Partys[i].Date < DateTime.Now)
                {
                    Partys.Remove(Partys[i]);
                }
            }
            User User = context.Users.FirstOrDefault(x => x.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.Partys = Partys;
            ViewBag.UserId = UserId;
            ViewBag.u = User;
            return View();
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            return Redirect("/");
        }
        [HttpGet("party/new")]
        public IActionResult NewParty()
        {
            return View();
        }
        [HttpPost("party")]
        public IActionResult CreateParty(Party p)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            if(ModelState.IsValid)
            {
                p.Display();
                p.PlannerId = (int) UserId;
                context.Partys.Add(p);
                context.SaveChanges();
                return Redirect("/success");
            }
            else
            {
                return View("NewParty", p);
            }
        }
        [HttpGet("details/{PartyId}")]
        public IActionResult Details(int PartyId)
        {
            Party p = context.Partys.
                Include(pa => pa.Planner).
                Include(pa => pa.AttendingUsers).
                ThenInclude(pa => pa.Joiner).
                FirstOrDefault(pa => pa.PartyId == PartyId);
            ViewBag.Joins = p.AttendingUsers;
            return View(p);
        }
        [HttpGet("delete/{PartyId}")]
        public IActionResult Delete(int PartyId)
        {
            Party p = context.Partys.FirstOrDefault(pa => pa.PartyId == PartyId);
            context.Partys.Remove(p);
            context.SaveChanges();
            return Redirect("/success");
        }
        [HttpGet("join/{PartyId}")]
        public IActionResult Join(int PartyId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            Join j = new Join(){
                UserId = (int) UserId,
                PartyId = PartyId
            };
            context.Joins.Add(j);
            context.SaveChanges();
            return Redirect("/success");
        }
        [HttpGet("leave/{PartyId}")]
        public IActionResult Leave(int PartyId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            Join join = context.Joins.Where(j => j.PartyId == PartyId).FirstOrDefault(j => j.UserId == (int) UserId);
            context.Joins.Remove(join);
            context.SaveChanges();
            return Redirect("/success");
        }
        
    }
}
