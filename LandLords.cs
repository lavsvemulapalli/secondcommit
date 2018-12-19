using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class LandLords
    {

        public LandLords(string firstName, string lastName, bool trusted)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.trusted = trusted;
        }


        public string id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public bool trusted { get; set; }

    }

    class Apartments
    {
        public String id { get; set; }
        public string address { get; set; }
        public float price { get; set; }
        public float squares { get; set; }
        public String features { get; set; }
        public bool Active { get; set; }

    }
}
