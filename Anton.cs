using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class Anton : AppleTree
    {
        public Anton(string kind, int age) : base(kind, age) { }

        public new void Grove() => Age *= 1.5;
    }
}
