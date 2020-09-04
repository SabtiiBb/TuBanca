using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuBancaEnLinea.Models
{
    public class LoginVM
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}