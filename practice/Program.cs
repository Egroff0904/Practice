String userInput = Console.ReadLine();

if (userInput == "Computer what time is it?")
{
    DateTime currentTime = DateTime.Now;

    string timeString = currentTime.ToString();

    Console.WriteLine("The Current Time is: " + timeString);
}
 else
    {
            Console.WriteLine($" I am not programmed to answer that.");
    }