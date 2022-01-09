
using Adapter;


Welcome();

static void Welcome()
{
    Console.WriteLine("Hello, what is your currency? (type number between 1-2 and press Enter to confirm)\n" +
        "1. Dollar \n" +
        "2. Euro ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Store.StartShoping(new PaymentInDollars());
            break;

        case "2":
            Store.StartShoping(new AdapterToEuro());
            break;

        default:
            Console.WriteLine("Invalid input. Try again\n\n\n");
            Welcome();
            break;
    }
}
