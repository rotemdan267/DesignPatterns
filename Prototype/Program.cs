using Prototype;
using System.Text.Json;

Client client = new Client(1, "abc", "qwe 3, holon");
Bill bill = new Bill(client, 109.99f, 18.69f, DateTime.Now);

//Bill bill2 = bill.Clone();
Bill bill2 = DeepCopy(bill);

Console.WriteLine(bill);
Console.WriteLine(bill2);

client.ID = 3;
client.Name = "cdf";
client.Address = "jhjh 3, hadera";

bill.Client = client;
bill.PricePaid = 20f;
bill.VAT = 3.4f;
bill.DateOfDeal = DateTime.Now.AddDays(17);


Console.WriteLine("------------------------------------------------------------");

Console.WriteLine(bill);
Console.WriteLine(bill2);


static T DeepCopy<T>(T self)
{
    var json = JsonSerializer.Serialize(self);
    T obj = JsonSerializer.Deserialize<T>(json);
    return obj;
}