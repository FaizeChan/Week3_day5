using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day5
{
    class Cat
    {

        private int catCount;


        public int CatCount
        {
            get { return this.catCount; }
            set { this.catCount = value; }
        }

        public Cat()
        {

        }

        public void WarCry()
        {
            Console.WriteLine("We are a army of {0} cats!", catCount);
        }

    }
}
