using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Checkout
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string paymentMethod { get; set; }
        public string cardnumber { get; set; }
    }
}