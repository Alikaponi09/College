using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classLessonApp.Generic;

namespace classLessonApp
{
    class PearTree : Tree<WorldMoney>
    {
        public PearTree(string kind, int age, WorldMoney cost) : base(kind, age, cost) { }

        public override void Grove() => Age += 2;
    }
}
