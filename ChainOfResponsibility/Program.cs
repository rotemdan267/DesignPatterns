

using ChainOfResponsibility;

Car car = new Car();
car.IsInOrder = false;

FirstCheck firstCheck = new FirstCheck();
SecondCheck secondCheck = new SecondCheck();
ElectricalCheck electricalCheck = new ElectricalCheck();
OverallExpertCheck overallExpertCheck = new OverallExpertCheck();


firstCheck.SetNext(secondCheck);
secondCheck.SetNext(electricalCheck);
electricalCheck.SetNext(overallExpertCheck);


for (int i = 0; i < 300; i++)
{
    firstCheck.FixCar(car);
    car.IsInOrder = false;
}