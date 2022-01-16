using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    interface IProto<T>
    {
        T Clone();
    }
    internal class Client : IProto<Client>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Client()
        {
        }

        public Client(int iD, string name, string address)
        {
            ID = iD;
            Name = name;
            Address = address;
        }

        public Client Clone()
        {
            return new Client(this.ID, this.Name, this.Address);
        }
        public override string ToString()
        {
            return $"ID: {ID} \nName: {Name} \n Address: {Address}";
        }
    }
    class Bill : IProto<Bill>
    {
        public Client Client { get; set; }
        public float PricePaid { get; set; }
        public float VAT { get; set; }
        public DateTime DateOfDeal { get; set; }

        public Bill(Client client, float pricePaid, float vAT, DateTime dateOfDeal)
        {
            Client = client;
            PricePaid = pricePaid;
            VAT = vAT;
            DateOfDeal = dateOfDeal;
        }

        public Bill Clone()
        {
            return new Bill(this.Client.Clone(), this.PricePaid, this.VAT, this.DateOfDeal);
        }

        public override string ToString()
        {
            return $"Client: {Client.ToString()} " +
                $"\n PricePaid: {PricePaid} " +
                $"\nVAT: {VAT} \nDate: {DateOfDeal.ToString()}";
        }
    }
}
