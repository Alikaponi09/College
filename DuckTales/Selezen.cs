using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp.DuckTales
{
    class Selezen : WildDuck
    {
        public Selezen(string name, int age, DuckColor color) : base(name, age, color) { }

        public new void Fly()
        {
            Console.WriteLine($"{Name} {Age} {Color} улетела на юг");
        }

        public override void Krya()
        {
            Console.WriteLine($"{Name} {Age} {Color} гагатает");
        }

    }
}
