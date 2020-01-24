using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public double MSRP { get; set; }
        public double ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }

        public Phone()
        {
            PhoneName = "";
            Manufacturer = "";
            DateReleased = DateTime.MinValue;
        }
    }
}