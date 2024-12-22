// See https://aka.ms/new-console-template for more information

using RiseOfGauls;
using RiseOfGauls.Core;
using RiseOfGauls.Features;

Console.WriteLine("Hello, World!");

/*

Event myEvent0 = new Event("Event message", new (ENUM_EVENT, int)[] { (ENUM_EVENT.MONEY, 10), (ENUM_EVENT.POPULATION, -5) });

Console.WriteLine(myEvent0.Message);
foreach (var element in myEvent0.Events)
{
    Console.WriteLine(element.Item1);
    Console.WriteLine(element.Item2);
}


Console.WriteLine("MONEY EVENT");
Event myEvent1 = new Event("Event message", new (ENUM_EVENT, int)[] { (ENUM_EVENT.MONEY, 2), (ENUM_EVENT.POPULATION, -5) });
Bankix bank1 = new Bankix(new Random(3));
myEvent1.MoneyEvent(new List<Batimentix> { bank1 }, 10); // bank.GetVillageMoney() = 35
Console.WriteLine(bank1.GetVillageMoney());


Console.WriteLine("Population EVENT");
Event myEvent2 = new Event("Event message", new (ENUM_EVENT, int)[] { (ENUM_EVENT.POPULATION, -5) });
ChiefHut hut2 = new ChiefHut(); // hut.GetPopulation() = 5
myEvent2.PopulationEvent(new List<Batimentix> { hut2 }, -2); // hut.GetPopulation() = 3
Console.WriteLine(hut2.GetPopulation());


Console.WriteLine("Execute event");
Event myEvent10 = new Event("Gaulish Attack", new (ENUM_EVENT, int)[] { (ENUM_EVENT.MONEY, 10), (ENUM_EVENT.POPULATION, 5) });
Bankix bank10 = new Bankix(new Random(3));
ChiefHut hut10 = new ChiefHut();
myEvent10.ExecuteEvent(new List<Batimentix> { bank10, hut10 });
Console.WriteLine(bank10.GetVillageMoney()); //= 35
Console.WriteLine(hut10.GetPopulation()); //= 10


Console.WriteLine("village");
Village village = new Village(new Random(3));
int money = village.Money; // 25
Console.WriteLine(money);

Console.WriteLine("Librarix");
Librarix library = new Librarix();
Console.WriteLine(library.GetDurability()); // 50
Console.WriteLine(library.GetCost()); // 100
Console.WriteLine(library.GetPopulation()); // 20
//(string, string)?[][] shelves = library.Books; // new (string, string)?[6][9] (all null)
*/





