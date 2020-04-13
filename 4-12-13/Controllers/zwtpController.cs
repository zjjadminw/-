using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4_12_13.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _4_12_13.Controllers
{
    public class zwtpController : Controller
    {
        private readonly DBData _context;
        private  Users users;
        public zwtpController(DBData context)
        {
            _context = context;
        }
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Top()
        {
            return View(users);
        }
        public IActionResult left()
        {
            return View();
        }
        public async Task<IActionResult> right() {
            return View(await _context.Users.ToListAsync());
        }
        public async Task<IActionResult> tab() {
            return View(await _context.Users.ToListAsync());
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add([Bind("Id,Email,Password,NickName,Photo,CreateTime,RolesId")] Users userds)
        {
            if (ModelState.IsValid) {
                _context.Add(userds);
                users = userds;
                int a = await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Main));
            }
            return View(users);
        }
        [HttpPost]
        public async Task<IActionResult> Login([Bind("NickName,Password")]Users users)
        {
            var s = await _context.Users.ToListAsync();
            var sr = (from sed in s
                     where users.NickName == sed.NickName
                                || 
                                users.Password == sed.Password
                     select new
                     { sed.Id, sed.NickName, sed.Password, sed.Photo,
                         sed.RolesId, sed.Email, sed.CreateTime }).ToList();
            if (sr.Count != 0) { 
              
               
               return RedirectToAction(nameof(Main));
          
}
            

            else{ 
                return Content("<script>alert('登录失败');</script>");
            }
               

        }
    }
}