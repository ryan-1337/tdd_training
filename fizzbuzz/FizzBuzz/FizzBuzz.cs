namespace FizzBuzz;

public class FizzBuzz
{
    public string Generate(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}
