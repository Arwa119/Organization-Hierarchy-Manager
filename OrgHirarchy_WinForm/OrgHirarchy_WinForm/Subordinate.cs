using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgHirarchy_WinForm
{
    public class Subordinate
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string ID { get; set; }

        public Subordinate(string name, string role, string id)
        {
            Name = name;
            Role = role;
            ID = id;
        }
    }
}
