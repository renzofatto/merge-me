using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeMe
{
    class User
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string FullName { get => Name + " " + LastName; } 

    }
}
