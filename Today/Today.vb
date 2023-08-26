Module Today

    Sub Main()
        Console.Write("Today is ... ")
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.WriteLine(DateTime.Now.DayOfWeek.ToString)
        Console.Read()
        Console.ResetColor()
    End Sub

End Module
