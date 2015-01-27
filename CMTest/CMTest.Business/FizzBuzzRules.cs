using System.Collections.Generic;

namespace CMTest.Business
{
    public class FizzBuzzRules
    {

        private readonly SortedDictionary<int, string> _conversionRules;

        public FizzBuzzRules()
        {
            _conversionRules = BuildConversionRules();
        }

        public string Resolve(int number)
        {
            var resolvedValue = "";

            foreach (var rule in _conversionRules)
            {
                if (number%rule.Key == 0)
                {
                    resolvedValue += rule.Value;
                }
            }

            return string.IsNullOrEmpty(resolvedValue) ? number.ToString() : resolvedValue;
        }


        private SortedDictionary<int, string> BuildConversionRules()
        {
            return new SortedDictionary<int, string> { { 5, "Buzz" }, { 3, "Fizz" }, {17, "Jazz"} };
        }

        public void AddRule(int number, string conversionString)
        {
            if(number!=0)
            {
                _conversionRules.Add(number, conversionString);
            }
        } 

    }
}
