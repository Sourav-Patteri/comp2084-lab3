using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone {PhoneName = "S10 Plus", Manufacturer = "Samsung", PhoneID = 1, DateReleased = new DateTime(2018, 12, 25), MSRP = 1200, ScreenSize = 6.5},
                new Phone {PhoneName = "11 Pro Max", Manufacturer = "Apple", PhoneID = 2, DateReleased = new DateTime(2019, 12, 25), MSRP = 1800, ScreenSize = 6.0},
                new Phone {PhoneName = "S9 Plus", Manufacturer = "Samsung", PhoneID = 3, DateReleased = new DateTime(2017, 12, 25), MSRP = 800, ScreenSize = 5.5}
            };
            return View(phoneList);
        }
    }
}