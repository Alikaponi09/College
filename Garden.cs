using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    class Garden
    {
        public Tree[] Trees { get; protected set; }

        public Garden(Tree[] trees)
        {
            Trees = trees;
        }

        public void Poliv()
        {
            foreach (var item in Trees)
            {
                Console.WriteLine($"Дерево {item.Kind} полито");
            }
        }

        public void Add(Tree tree) 
        {
            if (tree != null)
            {
                //Trees.Concat(new Tree[1] { tree });
                Tree[] trees = new Tree[Trees.Length + 1];
                Trees.CopyTo(trees, 0);
                trees[Trees.Length] = tree;
                Trees = trees;
            }
        }

        public void Delete(Tree tree) 
        {
            Trees = Trees.Where(p => p != tree).ToArray();
        }
    }
}
