using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktHome.Data.Model
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
               
        }
    }
}
 