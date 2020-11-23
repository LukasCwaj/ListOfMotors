using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorList
{
    class Motor
    {
        public string name { get; set; }
        public string engine;
        int id;
        static int nextId = 0;
        public Motor(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            nextId++;
            id = nextId;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
    }
}
