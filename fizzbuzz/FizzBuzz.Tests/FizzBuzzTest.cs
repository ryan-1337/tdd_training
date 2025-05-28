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
    public void Should_ReturnFizzWhenGivenMultipleOfThree(int multipleOf3)
    {
        // given a multiple of three
        
        // when the int equal multiple of three
        String response = FizzBuzz.Generate(multipleOf3);

        // then should return "Fizz"
        Assert.Equal("Fizz", response);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Should_ReturnBuzzWhenMultipleOfFive(int multipleOf5)
    {
        // given a multiple of five
        
        // when the int equal multiple of five
        String response = FizzBuzz.Generate(multipleOf5);
        
        // then should return "Buzz"
        Assert.Equal("Buzz", response);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(60)]
    public void Should_ReturnFizzBuzzWhenGivenMultipleOfFifteen(int multipleOf15)
    {
        // given a multiple of fifteen
            
        // when the int equal fifteen
        String response = FizzBuzz.Generate(multipleOf15);
            
        // then should return "FizzBuzz";
        Assert.Equal("FizzBuzz", response);
    }

    [Fact]
    public void Should_ReturnOneAndTwo()
    {
        // given int two
        var oneTwo = 2;

        // when the int equal 2
        String response = FizzBuzz.GenerateLoop(2);

        // then should return "12"
        Assert.Equal("12", response);
    }
    
    [Fact]
    public void Should_ReturnOneAndTwoAndFizz()
    {
        // given int three
        var three = 3;
 
        // when the int equal 3
        String response = FizzBuzz.GenerateLoop(three);
 
        // then should return "12Fizz"
        Assert.Equal("12Fizz", response);
    }   
     
    [Fact]
    public void Should_ReturnOneTwoFizzFour()
    {
        // given int 4
        var four = 4;
      
        // when the int 4
        String response = FizzBuzz.GenerateLoop(four);
      
        // then should return "12Fizz4"
        Assert.Equal("12Fizz4", response);
    }
    
    [Fact]
    public void Should_ReturnOneTwoFizzFourBuzz()
    {
        // given int 5
        var five = 5;
       
        // when the int 4
        String response = FizzBuzz.GenerateLoop(five);
       
        // then should return "12Fizz4"
        Assert.Equal("12Fizz4Buzz", response);
    }   
    
}