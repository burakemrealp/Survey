using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        bool start, @continue;

        start = true;
        int gender, likeCoffee, totalMember, male, female, myes, fyes, survey;

        myes = 0;
        fyes = 0;
        male = 0;
        female = 0;
        totalMember = 0;
        Console.WriteLine("Welcome to our Survey");
        while (start)
        {
            totalMember = totalMember + 1;
            Console.WriteLine("What is your gender? (male:1, female: 2)");
            gender = (int) inputValue();
            if (gender == 1)
            {
                male = male + 1;
                Console.WriteLine("Do you like Coffee? (yes: 1, no: 2)");
                likeCoffee = (int) inputValue();
                if (likeCoffee == 1)
                {
                    myes = myes + 1;
                }
            }
            else
            {
                female = female + 1;
                Console.WriteLine("Do you like Coffee? (yes: 1, no: 2)");
                likeCoffee = (int) inputValue();
                if (likeCoffee == 1)
                {
                    fyes = fyes + 1;
                }
            }
            Console.WriteLine("Do you want to continue to survey? (yes: 1, no:2)");
            survey = (int) inputValue();
            if (survey == 1)
            {
                start = true;
            }
            else
            {
                Console.WriteLine("Total Member that taken the survey: " + totalMember + ", Male: " + male + ", Female: " + female);
                Console.WriteLine("Total number of coffee lovers: " + (myes + fyes) + ", Male: " + myes + ", Female: " + fyes);
                start = false;
            }
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
