using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appointment.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowAppointmentDetails(Models.AppointmentModel appointment)
        {
            if (appointment.doctorLastName == null)
            {
                appointment.doctorLastName = "Tarik Onur Tiryaki";
            }
            if (ModelState.IsValid)
            {
                return View("ShowAppointmentDetails", appointment);
            }
            else
            {
                return View("Index");
            }
           
        }
    }

}