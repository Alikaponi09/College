using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class PearTree : Tree
    {
        public PearTree(string kind, int age, decimal priceRUB) : base(kind, age, priceRUB) { }

        public override void Grove() => Age += 2;
    }
}
