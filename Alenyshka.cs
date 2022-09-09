using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class Alenyshka : PearTree
    {
        public Alenyshka(string kind, int age) : base(kind, age) { }

        public override void Grove() => Age += 4;
    }
}
