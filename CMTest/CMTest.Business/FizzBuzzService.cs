
using System;
using System.Collections.Generic;

namespace CMTest.Business
{
    public class FizzBuzzService
    {
        private FizzBuzzRules _fizzBuzzRules;

        public FizzBuzzService()
        {
            _fizzBuzzRules = new FizzBuzzRules();
            _fizzBuzzRules.AddRule(7, "Tazz");
        }

        public List<string> GetFizzBuzzList(int start, int end)
        {
            var retList = new List<string>();

            if (start > end)
            {
                throw new ArgumentException("Start cannot be greater than End");
            }

            for (var i = start; i <= end; i++)
            {
                retList.Add(_fizzBuzzRules.Resolve(i));
            }

            return retList;
        }
    }
}
