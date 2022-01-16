// See https://aka.ms/new-console-template for more information

using Proxy;

Person p = new Person()
{ 
    Name = "Avi Levi"
};
InteriorOffice interiorOffice = new InteriorOffice();
ServiceMachine sm = new ServiceMachine(interiorOffice, p);

sm.ChangeAddress();
sm.ViewMyInformation();
sm.RenewPassport();

