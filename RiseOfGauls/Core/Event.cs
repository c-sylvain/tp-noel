namespace RiseOfGauls.Core;

public class Event
{
  /*  
    public enum ENUM_EVENT
    {
        MONEY,
        POPULATION,
        DURABILITY
    }
    */
    
    public string Message { get; set; }
    public Queue<(ENUM_EVENT, int)> Events {get; set;} = new Queue<(ENUM_EVENT, int)>();
    




    public Event(string message, (ENUM_EVENT, int)[] array)
    {
        Message = message;
        foreach ((ENUM_EVENT, int) element in array)
        {
            Events.Enqueue(element);
        }
    }



    public void MoneyEvent(List<Batimentix> batiments, int value)
    {
        int nombrebank = 0;

        for (int i = 0; i < batiments.Count; i++)
        {
            if (batiments[i] is Bankix banque)
            {
                int depart = banque.GetVillageMoney();
                banque.SetVillageMoney( depart + value);
                nombrebank++;
                
            }

        }
        if (nombrebank == 0)
        {
            throw new GaulsException();
        }
    }



    public void PopulationEvent(List<Batimentix> batiments, int value)
    {
        int nbchief = 0;
        for (int i = 0; i < batiments.Count; i++)
        {
            if (batiments[i] is ChiefHut chiefhut)
            {
                int depart = chiefhut.GetPopulation();
                chiefhut.SetPopulation(depart + value);
                nbchief++;
                
            }
        }
        if (nbchief == 0)
        {
            throw new GaulsException();
        }
        
    }




    public void DurabilityEvent(List<Batimentix> batiments, int value)
    {

        for (int i = 0; i < batiments.Count; i++)
        {
            // application de la penalité
            Batimentix batimentix = batiments[i];
            int dudep = batimentix.GetDurability();
            batimentix.SetDurability(dudep + value);
            
            //condition
            if (batimentix.GetDurability() <= 0)
            {
                batiments.RemoveAt(i);
            }
        }
    }





    public void ExecuteEvent(List<Batimentix> batiments)
    {
        foreach (var currentEvent in Events)
        {
            switch (currentEvent.Item1)
            {
                case ENUM_EVENT.MONEY:
                    MoneyEvent(batiments, currentEvent.Item2);
                    break;
                    
                case ENUM_EVENT.POPULATION:
                    PopulationEvent(batiments, currentEvent.Item2);
                    break;
                    
                case ENUM_EVENT.DURABILITY:
                    DurabilityEvent(batiments, currentEvent.Item2);
                    break;

                default:
                    continue;
            }
        }
        
    }


    
    
    
    
    
    

}