
using Strategy;



Console.WriteLine("Day: 06:00-15:00, 17:00-23:00");
Console.WriteLine("Rush Hour: 15:00-17:00");
Console.WriteLine("Night: 23:00-06:00\n\n\n");

TrafficLightManager manager = new TrafficLightManager();
manager.Operate(DateTime.Now);
Continue(manager, DateTime.Now);


static void Continue(TrafficLightManager manager, DateTime dateTime)
{

    Console.WriteLine("\n\n\nFast forward options: (type number between 1-4 and press Enter to confirm)\n" +
        "1. +1 Hours\n" +
        "2. +3 Hours\n" +
        "3. +6 Hours\n" +
        "4. +12 Hours\n");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            dateTime = dateTime.AddHours(1);
            manager.DetermineOperationMethod(dateTime);
            manager.Operate(dateTime);
            Continue(manager, dateTime);
            break;

        case "2":
            dateTime = dateTime.AddHours(3);
            manager.DetermineOperationMethod(dateTime); 
            manager.Operate(dateTime);
            Continue(manager, dateTime);
            break;

        case "3":
            dateTime = dateTime.AddHours(6);
            manager.DetermineOperationMethod(dateTime);
            manager.Operate(dateTime);
            Continue(manager, dateTime);
            break;

        case "4":
            dateTime = dateTime.AddHours(12);
            manager.DetermineOperationMethod(dateTime);
            manager.Operate(dateTime);
            Continue(manager, dateTime);
            break;

        default:
            Console.WriteLine("Invalid input. Try again\n\n\n");
            Continue(manager, dateTime);
            break;
    }
}