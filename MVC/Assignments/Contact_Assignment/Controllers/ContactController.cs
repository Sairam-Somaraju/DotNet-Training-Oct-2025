using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Contact_Prj.Models;
using Contact_Prj.Repositorys;
using Contact_Prj.Controllers;

namespace Contact_Prj.Controllers
{
    public class ContactController : Controller
    {       
        IContactRepository repo = new ContactRepository();
        // GET: Contacts
        public async Task<ActionResult> Index()
        {
            var contacts = await repo.GetAllAsync();
            return View(contacts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await repo.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        public async Task<ActionResult> Delete(long id)
        {
            await repo.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}