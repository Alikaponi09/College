using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classLessonApp.Generic;

namespace classLessonApp
{
    abstract class Tree<WorldMoney>
    {
        public string Kind { get; protected set; }
        public WorldMoney Cost { get; protected set; }

        private double age;
        public double Age
        {
            get { return age; }
            protected set
            {
                age = value > 0 ? value : 0;
            }
        }

        public Tree(string kind, int age, WorldMoney cost)
        {
            Kind = kind;
            Age = age;
            Cost = cost;
        }

        public abstract void Grove();

    }
}
