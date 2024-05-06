using System;

public interface IOutputHandler
{
    void Write(Guid id, string data);
}

public class ConsoleOutputHandler : IOutputHandler
{
    public void Write(Guid id, string data)
    {
        Console.WriteLine($"Console: {id} - {data}");
    }
}

public class FileOutputHandler : IOutputHandler
{
    public void Write(Guid id, string data)
    {
        // Write to a file implementation
        Console.WriteLine($"File: {id} - {data}");
    }
}

public class DatabaseOutputHandler : IOutputHandler
{
    public void Write(Guid id, string data)
    {
        // Write to a database implementation
        Console.WriteLine($"Database: {id} - {data}");
    }
}

public static class UtilityManager {
    public static Guid GenerateID()
    {
        return Guid.NewGuid();
    }
}

//public class Program {
//    public static void Main(string[] args)
//    {
//        IOutputHandler ConsoleHandler = new ConsoleOutputHandler();
//        IOutputHandler FileHandler = new FileOutputHandler();
//        IOutputHandler DatabaseHandler = new DatabaseOutputHandler();

//        ConsoleHandler.Write(UtilityManager.GenerateID(), "Output");
//        FileHandler.Write(UtilityManager.GenerateID(), "Output");
//        DatabaseHandler.Write(UtilityManager.GenerateID(), "Output");

//    }
//}