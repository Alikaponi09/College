using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class AppleTree : Tree<Generic.USD>
    {
        public AppleTree(string kind, int age, Generic.USD uSD) : base(kind, age, uSD) { }

        public override void Grove() => Age += 1;
    }
}
