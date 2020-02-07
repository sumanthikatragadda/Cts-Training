 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAssgn
{
    public class Employee
    {
        private int id;
        private string en, ed;

        public int Id { get => id; set => id = value; }
        public string En { get => en; set => en = value; }
        public string Ed { get => ed; set => ed = value; }

        public Employee(int id, string en, string ed)
        {
            this.Id = id;
            this.en = en;
            this.ed = ed;
        }



    }
}
