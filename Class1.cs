using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davvaleba6
{
/*    
 შექმენით კლასი, რომელშიც პრივატული მთელი ტიპის ცვლადია გამოცხადებული.
მასთან მიმართვისათვის გამოიყენეთ თვისება, რომელშიც set და get მეთოდებია
განსაზღვრული.თვისება პრივატულ ცვლადს დადებით მნიშვნელობებს ანიჭებს.*/
    internal class Class1
    {
        private int cvladi=8;
        public int tviseba
        {
            set
            {
                if(value > 0)  cvladi = value; 
            }
            get
            {
                return cvladi;
            }
        }
    }
}
