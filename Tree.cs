using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp
{
    abstract class Tree
    {
        private decimal _priceRUB;
        public decimal PriceRUB 
        {
            get { return _priceRUB; }
            protected set
            {
                _priceRUB = value > 0 ? value : 0;
            }
        }

        public decimal priceUSD 
        {
            get { return _priceRUB / 60; }
        }

        public static int CountTree{get; private set;}
        //
        //вид
        //нельзя изменить извне
        public string Kind { get; protected set; }
        //
        //возраст
        //должно быть больше 0
        //нельзя изменить извне
        private double _age;
        public double Age
        {
            get { return _age; }
            protected set
            {
                _age = value > 0 ? value : 0;
            }
        }

        public Tree(string kind, int age, decimal priceRUB)
        {
            Kind = kind;
            Age = age;
            PriceRUB = priceRUB;
            CountTree++;
        }

        public abstract void Grove();
    }
}
