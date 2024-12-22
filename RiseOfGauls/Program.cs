// See https://aka.ms/new-console-template for more information

using RiseOfGauls;
using RiseOfGauls.Core;

Console.WriteLine("Hello, World!");


Event myEvent = new Event("Romain Attack", new (ENUM_EVENT, int)[] { (ENUM_EVENT.MONEY, -10), (ENUM_EVENT.POPULATION, -5) });
Bankix bank = new Bankix(new Random(3));
ChiefHut hut = new ChiefHut();
hut.SetPopulation(50);
bank.SetVillageMoney(100);
string msg = myEvent.Display(new List<Batimentix> { bank, hut }); // hut.GetPopulation() = 45, bank.GetVillageMoney() = 90
Console.Write(msg);


