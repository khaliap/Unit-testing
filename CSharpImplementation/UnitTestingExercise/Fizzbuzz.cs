namespace CSharpImplementation.UnitTestingExercise;
public class Fizzbuzz
{
    public int userInput { get; set; }
    public string? UserOutput { get; set; }
 //   internal int userInput = 0;
  //  internal int userOutput = 0;

    static void Main() { }

    public string FizzbuzzOutputLogic()
    {

        if (userInput == 1)
	    {
            UserOutput = "1";
	    }
        else if (userInput == 2)
        {
            UserOutput = "2";
        }
        else if (userInput % 3 == 0 )
        {
            UserOutput = "Fizz";
        }
        else if (userInput % 5 == 0)
        {
            UserOutput = "Buzz";
        }
        else if (userInput % 15 == 0 )
        {
            UserOutput = "FuzzBizz";
        }
        else
        {
            UserOutput = "Please typpe in another number : ) ";
        }

        return UserOutput;

    }


}