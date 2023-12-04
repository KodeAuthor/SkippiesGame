class SkippiesGame
{
    static void Main()
    {
        Console.WriteLine("Skippie's Big Game");
        Console.Write("Choose a door:\n[1]\n[2]\n[3]\nSELECTED DOOR: "); // \n Creates a new line.
        string userValue = Console.ReadLine(); // CS8600 Error, but doesn't cause issues running.
        string userError = "[1] - Type a 1 using your keyboard.\n[2] - Type a 2 using your keyboard.\n[3] - Type a 3 using your keyboard.";
        string userRestart = "\nType S to restart Skippie's Big Game or any other key to begin exiting.";

        if (userValue == "1") // {} Open close brackets not needed for one line of code.
            Console.WriteLine("Door One selected.");
        else if (userValue == "2")
            Console.WriteLine("Door Two selected.");
        else if (userValue == "3")
            Console.WriteLine("Door Three selected.");
        else 
        {
            Console.WriteLine($"\nYou must select a door only!\n{userError}\n{userRestart}");
            string restartSkippie = Console.ReadLine(); //CS8600 Error, but doesn't cause issues running.
            if (restartSkippie == "s")
                Main(); //Restarts the "game".
            else
                Environment.Exit(0); // Begins exit proccess. Look into exiting completly.

        }
    }
}
