using Xunit;
using CSharpImplementation.UnitTestingExercise;

namespace CSharpImplementation.UnitTest.Tests;

    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnOneWhenInputisOne()
        
        {
            Fizzbuzz sut = new Fizzbuzz();
            sut.userInput = 1;

            Assert.Equal("1", sut.FizzbuzzOutputLogic());
        }
        [Fact]
        public void ReturnTwoWhenInputisTwo()

        {
            Fizzbuzz sut = new Fizzbuzz();
            sut.userInput = 2;

            Assert.Equal("2", sut.FizzbuzzOutputLogic());
        }
        [Fact]
        public void ReturnFizzWhenInputisInputModThree()

        {
            Fizzbuzz sut = new Fizzbuzz();
            sut.userInput = 9;

            Assert.Equal("Fizz", sut.FizzbuzzOutputLogic());
        }
    [Fact]
    public void ReturnBuzzWhenInputisInputModFive()

    {
        Fizzbuzz sut = new Fizzbuzz();
        sut.userInput = 30;

        Assert.Equal("Buzz", sut.FizzbuzzOutputLogic());
    }
    [Fact]
    public void ReturnBuzzWhenInputisInputModFiveAndThree()

    {
        Fizzbuzz sut = new Fizzbuzz();
        sut.userInput = 30;

        Assert.Equal("Buzz", sut.FizzbuzzOutputLogic());
    }
}
