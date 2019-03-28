using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzzLibrary;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    
    public class FizzBuzzerTest
    {
        [Test]
        public void Buzzer_when1_returns1()
        {
            //Arrage
            int input = 1;
            //Act
            string output = FizzBuzer.GetValue(input);
            //Asert
            Assert.AreEqual("1", output);
        }
        [Test]
        public void Buzzer_whenDeafault_returnsinput(
            [Values(1,2,4)]int input)
        {
            //Arrage
           
            //Act
            string output = FizzBuzer.GetValue(input);
            //Asert
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_when3_returnsFizz()
        {
            //Arrage
            int input = 3;
            //Act
            string output = FizzBuzer.GetValue(input);
            //Asert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_when5_returnsBuzz()
        {
            //Arrage
            int input = 5;
            //Act
            string output = FizzBuzer.GetValue(input);
            //Asert
            Assert.AreEqual("Buzz", output);
        }
        //[Test]
        //public void SampleTest()
        //{
        //    Assert.Pass();
        //}
    }

}
