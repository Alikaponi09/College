using System;
using classLessonApp.DuckTales;


namespace classLessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tree[] trees = new Tree[3];
            //for (int i = 0; i < trees.Length; i++)
            //{
            //    trees[i] = new AppleTree("dfg" + i, i);
            //}
            //Garden garden = new Garden(trees);
            //garden.Add(new AppleTree("aaaaaaaaaaa", 324));
            //garden.Delete(trees[0]);
            //garden.Print();

            Duck[] ducks = new Duck[3];
            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i] = new Selezen("dfg" + i, i, WildDuck.DuckColor.Grey);
            }
            DuckFarm duckFarm = new DuckFarm(ducks);
            duckFarm.Add(new WildDuck(""+6, 6, WildDuck.DuckColor.White));
            duckFarm.Add(new WildDuck(""+7, 7, WildDuck.DuckColor.Black),1);
            duckFarm.Delete(0);
            duckFarm.Delete(ducks[2]);
            duckFarm.EatDuck();

        }
    }
}