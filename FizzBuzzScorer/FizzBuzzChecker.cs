using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzScorer
{
    internal class FizzBuzzChecker
    {

        internal bool IsFizz(int numberGiven)
        {
            return numberGiven % 3 == 0;
        }
        
        internal bool IsBuzz(int numberGiven)
        {
            return numberGiven % 5 == 0;
        }

        internal bool IsNotFizzOrBuzz(int numberGiven)
        {
            return (numberGiven % 3 != 0) && (numberGiven % 5 != 0);
        }

        internal bool IsNotValidNumber(int numberGiven)
        {
            return numberGiven <= 0;
        }
    }
}
