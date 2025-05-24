namespace FizzBuzz.Tests;

public class FizzBuzzTest
{
    private readonly FizzBuzz FizzBuzz = new FizzBuzz();
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    public void Should_ReturnNumberInStringWhenGivenRandomNumber(int number)
    {
        // given a random number
             
        // when the int equal random number
        String response = FizzBuzz.Generate(number);
             
        // then should return "X"
        Assert.Equal(number.ToString(), response);
    }

    [Theory] 
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Should_ReturnFizzWhenGivenMultipleOfThree(int number)
    {
        // given a multiple of three
        
        // when the int equal multiple of three
        String response = FizzBuzz.Generate(number);

        // then should return "Fizz"
        Assert.Equal("Fizz", response);
    }
}
