// See https://aka.ms/new-console-template for more information
using Interfaces.Abstract;
using Interfaces.Concrete;
using static Interfaces.Concrete.PayMethod;

Console.WriteLine("Hello, World!");
//can't crate object from abstract class
//Vehicle _vehicle = new Vehicle("bb","55",2000);
Vehicle _vehicle = new Honda("Honda", "Civic", 2000);
Honda _vehicle2 = new Honda("Honda","Accord",2010);
//show only members on vehical
Vehicle _vehicle3 = new Caterpiller("Caterpiller", "XYZ",2020);
Caterpiller _vehicle4 = new Caterpiller("Caterpiller", "XYZ", 2018);
//_vehicle3.Load()
_vehicle4.Load();
_vehicle4.Drive();
IMove v5 = new Caterpiller("Caterpiller", "ABC", 2021);
v5.Move();
v5.Turn();

Cashier _cashier1 = new Cashier(new Cash());
_cashier1.Checkout(1224.256M);
Cashier _cashier2 = new Cashier(new MasterCard());
_cashier2.Checkout(1224.256M);