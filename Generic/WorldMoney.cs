using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp.Generic
{
    abstract class WorldMoney
    {
        public string Name { get; set; }

        public WorldMoney(string name) 
        {
            Name = name;
        }
    }
}
