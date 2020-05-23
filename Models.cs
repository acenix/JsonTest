using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest.Models 
{
    public class Recipents
    {
        public List<Recipent> recipients { get; set; }
    }

    public class Recipent
    {
        public List<string> tags { get; set; }

        public string name { get; set; }

        public int id { get; set; }
    }
}
