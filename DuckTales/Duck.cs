using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp.DuckTales
{
    abstract class Duck
    {
        private static int s_CountDuct = 0;
        public string Name { get; protected set; }

        private int age;
        public int Age
        {
            get
            {
                return age;
            };
            protected set
            {
                age = value < 0 ? 0 : value;
            };
        }

        public Duck(string name, int age)
        {
            Name = name;
            Age = age;
            s_CountDuct++;
        }

        public abstract void Fly(); 
        public abstract void Krya(); 
    }
}
