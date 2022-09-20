using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class Alenyshka : PearTree
    {
        public Alenyshka(string kind, int age, Generic.RUB rUB) : base(kind, age, rUB) { }

        public override void Grove() => Age += 4;
    }
}
