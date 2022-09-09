using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class AppleTree : Tree
    {
        public AppleTree(string kind, int age) : base(kind, age) { }

        public override void Grove() => Age += 1;
    }
}
