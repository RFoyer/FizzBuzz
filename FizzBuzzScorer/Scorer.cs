using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzScorer
{
    public class Scorer
    {

        private FizzBuzzChecker _fizzBuzzChecker;

        public Scorer()
        {
            _fizzBuzzChecker = new FizzBuzzChecker();
        }

        public string Score(int numberGiven)
        {

            string score = "";

            if (_fizzBuzzChecker.IsFizz(numberGiven))
            {
                score = "Fizz";
            }

            if (_fizzBuzzChecker.IsBuzz(numberGiven))
            {
                score += "Buzz";
            }

            if (_fizzBuzzChecker.IsNotFizzOrBuzz(numberGiven))
            {
                score = numberGiven.ToString();
            }

            if (_fizzBuzzChecker.IsNotValidNumber(numberGiven))
            {
                score = "Number must be greater than zero!";
            }

            return score;

        }
    }
}
