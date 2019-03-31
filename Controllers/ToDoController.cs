using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carenjot_core.Areas.Identity.Data;
using Carenjot_core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Task = Carenjot_core.Models.Task;

namespace Carenjot_core.Controllers
{
    public class ToDoController : Controller
    {

        public Carenjot_coreContext Context { get; set; }
        public UserManager<Carenjot_coreUser> UserManager { get; set; }

        public ToDoController(Carenjot_coreContext ctx, UserManager<Carenjot_coreUser> um)
        {
            this.Context = ctx;
            this.UserManager = um;
        }

        public IActionResult Index()
        {
            return View(Context.Task.ToList());
        }

        public async System.Threading.Tasks.Task<IActionResult> Create(Task t)
        {
            if (ModelState.IsValid)
            {
                t.CreationDate = DateTime.Now;

                t.User = await UserManager.GetUserAsync(HttpContext.User);
                Context.Task.Add(t);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}