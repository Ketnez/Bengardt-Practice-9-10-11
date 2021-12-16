using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengardt_Practice_9
{
    struct Learn
    {
        public Learn(string lastname, string street, int homenumber, int home)
        {
            LastName = lastname;
            Street = street;
            HomeNumber = homenumber;
            Home = home;

        }
        public string LastName { get; set; }

        public string Street { get; set; }

        public int HomeNumber { get; set; }

        public int Home { get; set; }
    }
}

