﻿using System;
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
            for (int i = 0; i < Trees.Length; i++)
            {
                if (tree == Trees[i])
                {
                    return true;
                }
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
                for (int i = 0; i < Trees.Length; i++)
                {
                    if (Trees[i] == tree)
                    {
                        continue;
                    }
                    trees[j] = Trees[i];
                    j++;
                }
                Trees = trees;
            }
        }

        public void Delete(int index) 
        {
            if (index < Trees.Length && index >= 0)
            {
                Tree[] trees = new Tree[Trees.Length - 1];
                int j = 0;
                for (int i = 0; i < Trees.Length; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    trees[j] = Trees[i];
                    j++;
                }
                Trees = trees;
            }
        }

        public void Print() 
        {
            foreach (var item in Trees)
            {
                Console.WriteLine($"{item.Kind} {item.Age}");
            }
        }
    }
}
