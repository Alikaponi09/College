using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLessonApp.DuckTales
{
    class DuckFarm
    {
        public Duck[] Ducks { get; protected set; }

        public DuckFarm(Duck[] ducks) 
        {
            Ducks = ducks;
        }

        public void EatDuck() 
        {
            foreach (var item in Ducks)
            {
                Console.WriteLine($"{item.Name} {item.Age} ПОКОРМЛЕНА");

            }
        }

        public void Delete(int index) 
        {
            Duck[] _ducks = new Duck[Ducks.Length - 1]; 
            for (int i = 0; i < _ducks.Length; i++)
            {
                _ducks[i] = i < index ? Ducks[i] : Ducks[i + 1];
            }
            Ducks = _ducks;
        }

        public void Add(Duck duck) 
        {
            Duck[] _ducks = new Duck[Ducks.Length + 1];
            for (int i = 0; i < Ducks.Length; i++)
            {
                _ducks[i] = Ducks[i];
            }
            _ducks[Ducks.Length] = duck;
            Ducks = _ducks;
        }
    }
}
