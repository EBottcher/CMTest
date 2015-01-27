using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMTest.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestIfFizzBuzzWorksAsExpected()
        {
            //Assign
            int s = 1;
            int e = 100;
            var service = new Business.FizzBuzzService();
           
            //Act
            
            var retList = service.GetFizzBuzzList(s, e);

            //Assert
            Assert.IsTrue(retList.Count==100);

        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestIfStartIsGreater()
        {
            //Assign
            int s = 10;
            int e = 1;
            var service = new Business.FizzBuzzService();

            //Act
            
            var retList = service.GetFizzBuzzList(s, e);

            //Assert
            Assert.IsTrue(retList.Count == 100);

        }

        [TestMethod]
        public void TestRulesConversion()
        {
            //Rule 1: Test Fizz

            //Assign
            int number = 3;
            var rules = new Business.FizzBuzzRules();

            //act
            var returnValue = rules.Resolve(number);

            //Assert
            Assert.IsTrue(returnValue.ToUpper()=="FIZZ", "Fizz conversion did not work" );

            //Rule 2: Test Buzz

            //Assign
             number = 5;
            
            //act
            returnValue = rules.Resolve(number);

            //Assert
            Assert.IsTrue(returnValue.ToUpper() == "BUZZ", "Buzz conversion did not work");

            //Rule 3: Test FizzBuzz

            //Assign
            number = 15;

            //act
            returnValue = rules.Resolve(number);

            //Assert
            Assert.IsTrue(returnValue.ToUpper() == "FIZZBUZZ", "FizzBuzz conversion did not work");

            //Rule 4: Test No rules found numbers

            //Assign
            number = 4;

            //act
            returnValue = rules.Resolve(number);

            //Assert
            Assert.IsTrue(returnValue.ToUpper() == 4.ToString(), "Numbers without rules associated conversion did not work");


            //Rule 5: Test Jazz

            //Assign
            number = 17;

            //act
            returnValue = rules.Resolve(number);

            //Assert
            Assert.IsTrue(returnValue.ToUpper() == "JAZZ", "Jazz conversion did not work");
        }


    }
}
