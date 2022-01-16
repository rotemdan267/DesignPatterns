
using Builder;

Console.WriteLine("Hello! We are pleased to offer our customers 2 options " +
    "to enjoy your vacation to paris:\n" +
    "1. Your Dreamy Vacation  - 2000$\n" +
    "2. Low-cost vacation - 800$");
//Builder();
FluentBuilder();

static void Builder()
{
    Vacation vacation;
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            DreamyVaction dreamyVaction = new DreamyVaction();
            dreamyVaction.ConstructVacation();
            vacation = dreamyVaction.GetVacation();
            Console.WriteLine(vacation);
            break;

        case "2":
            LowCostVacation lowCost = new LowCostVacation();
            lowCost.ConstructVacation();
            vacation = lowCost.GetVacation();
            Console.WriteLine(vacation);
            break;

        default:
            Console.WriteLine("Wrong input");

            break;
    }
}

static void FluentBuilder()
{
    Vacation vacation;
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            VacationFluentBuilder vfb = new VacationFluentBuilder();
            vacation = vfb.WithFlightUpgrade()
                          .WithHotelUpgrade()
                          .WithTransportationUpgrade()
                          .Build();
            Console.WriteLine(vacation);
            break;

        case "2":
            vfb = new VacationFluentBuilder();
            vacation = vfb.Build();
            Console.WriteLine(vacation);
            break;

        default:
            Console.WriteLine("Wrong input");

            break;
    }
}