namespace FizzBuzz
{
    public class FizzBuzz
    {

       public FizzBuzz() {}

       public string Check(int value)
       {
            if(value % 3 == 0 && value % 5 == 0 )
                return "Fizz Buzz";
            if(value % 3 == 0)
                return "Fizz";
            if(value % 5 == 0)
                return "Buzz";
            return "" + value;
       }
    }
}