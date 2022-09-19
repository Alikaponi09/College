using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp.DuckTales
{
    class WildDuck : Duck
    {
        public enum DuckColor 
        {
            Grey,
            Black,
            White
        }

        public DuckColor Color { get; protected set; }
        public WildDuck(string name, int age, DuckColor color) : base(name, age) 
        {
            Color = color;
        }

        public override void Fly() 
        {
            Console.WriteLine($"{Name} {Age} {Color} летит");
        }
        public override void Krya()
        {
            Console.WriteLine($"{Name} {Age} {Color} крякает");
        }
    }
}
