using System;

namespace classLessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree[] trees = new Tree[3];
            for (int i = 0; i < trees.Length; i++)
            {
                trees[i] = new AppleTree("dfg" + i, i);
            }
            Garden garden = new Garden(trees);
            garden.Add(new AppleTree("aaaaaaaaaaa", 324));
            garden.Delete(trees[0]);
            garden.Poliv();
        }
    }
}