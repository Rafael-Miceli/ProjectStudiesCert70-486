using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RafaelStudyMvcApp.Models;

namespace RafaelStudyMvcApp.Controllers
{
    public class TicketController : Controller
    {
        //
        // GET: /Ticket/

        public ActionResult Index()
        {
            var models = _Tickets.OrderBy(t => t.Condo == "Portomare");

            return View(models);
        }

        //
        // GET: /Ticket/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Ticket/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ticket/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ticket/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ticket/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ticket/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Ticket/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        private static List<Tickets> _Tickets = new List<Tickets>
        {
            new Tickets
                {
                    Condo = "Portomare",
                    Description = "Ticket teste 1",
                    Id = 1,
                    OpenedDate = DateTime.Parse("15/05/2013"),
                    Title = "Cameras"
                },
            new Tickets
                {
                    Condo = "Portomare",
                    Description = "Ticket teste 5",
                    Id = 5,
                    OpenedDate = DateTime.Parse("18/05/2013"),
                    Title = "Antena"
                },
            new Tickets
                {
                    Condo = "Portomare",
                    Description = "Ticket teste 6",
                    Id = 6,
                    OpenedDate = DateTime.Parse("17/05/2013"),
                    Title = "<script>alert('ALERTA!');</script>"
                },
            new Tickets
                {
                    Condo = "Portofino",
                    Description = "Ticket teste 2",
                    Id = 2,
                    OpenedDate = DateTime.Parse("25/05/2013"),
                    Title = "Portão"
                },
            new Tickets
                {
                    Condo = "Portoverano",
                    Description = "Ticket teste 3",
                    Id = 3,
                    OpenedDate = DateTime.Parse("12/05/2013"),
                    Title = "Servidores"
                },
            new Tickets
                {
                    Condo = "Portofelice",
                    Description = "Ticket teste 4",
                    Id = 4,
                    OpenedDate = DateTime.Parse("11/05/2013"),
                    Title = "Alarmes"
                },
        };
    }
}
