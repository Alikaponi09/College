using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    abstract class Tree
    {
        //
        //вид
        //нельзя изменить извне
        public string Kind { get; protected set; }

        //
        //возраст
        //должно быть больше 0
        //нельзя изменить извне
        private double age;
        public double Age
        {
            get { return age; }
            protected set
            {
                age = value > 0 ? value : 0;
            }
        }

        public Tree(string kind, int age)
        {
            Kind = kind;
            Age = age;
        }

        public abstract void Grove();
        
    }
}
