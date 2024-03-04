    {
        CountDown();
    }

    static void CountDown()
    {
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine($"Breathe in... {i}");
            Thread.Sleep(1000); // Sleep for 1 second
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1); // Move cursor back one line
            Console.Write(new string(' ', $"Breathe in... {i}".Length)); // Clear the line
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); // Move cursor back to the beginning
        }
    }