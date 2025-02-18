using datepicker.DataContext;
using datepicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace datepicker.Controllers
{
    public class AppointmentController : Controller
    {

        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Name = "Harshit";

            return View();
        }
        [HttpPost]
        public IActionResult Create( Appointment model)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Add(model);
                _context.SaveChanges(); // Save to DB


                TempData["Success"] = "Data Added Succesfully";
                return  RedirectToAction("Create");
            }
                return View(model);
        }


        public ActionResult List()
        {
            var appointments = _context.Appointments.ToList();
            return View(appointments);
        }





    }
}
