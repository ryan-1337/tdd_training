namespace FizzBuzz;

public class FizzBuzz
{
    public string Generate(int number)
    {
        if (number % 15 == 0)
        {
            return "FizzBuzz";
        }
        
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        
        return number.ToString();
    }

    public string GenerateLoop(int number)
    {
        var response = "";
        for (var i = 1; i <= number; i++)
        {
            response += Generate(i);
        }

        return response;
    }
}
