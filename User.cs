using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassExample
{
    internal class User:CommonProperty
    {

        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
