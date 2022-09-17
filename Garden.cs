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
                Tree[] trees = new Tree[Trees.Length + 1];
                //Trees.CopyTo(trees, 0);
                //trees[Trees.Length] = tree;
                //Trees = trees;

                for (int i = 0; i < Trees.Length; i++)
                {
                    trees[i] = Trees[i];
                }
                trees[Trees.Length] = tree;
                Trees = trees;
            }
        }

        private bool Proverka(Tree tree)
        {
            foreach (var item in Trees)
            {
                if (tree == item) return true;
            }
            return false;
        }

        public void Delete(Tree tree)
        {
            //Trees = Trees.Where(p => p != tree).ToArray();
            if (Proverka(tree))
            {
                Tree[] trees = new Tree[Trees.Length - 1];
                int j = 0;
                foreach (var item in Trees)
                {
                    if (item == tree) continue;
                    trees[j] = item;
                    j++;
                }
                Trees = trees;
            }
        }

        public void Delete(int index)
        {
            if (index > Trees.Length || index < 0) return;
            Tree[] trees = new Tree[Trees.Length - 1];
            for (int i = 0; i < Trees.Length; i++)
            {
                trees[i] = i < index ? Trees[i] : Trees[i + 1];
            }
            Trees = trees;
            //соглашение по коду
            //убрать тернарный
        }

        public void Print()
        {
            foreach (var item in Trees)
            {
                Console.WriteLine($"{item.Kind} {item.Age} {item.PriceRUB}RUB {item.priceUSD}USD");
            }
        }
    }
}
