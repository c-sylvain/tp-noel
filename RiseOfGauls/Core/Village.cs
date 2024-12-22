namespace RiseOfGauls.Core;

public class Village
{

    public List<Batimentix> Batimentix { get; set; }
    public Queue<(ENUM_EVENT, int)> Events {get; set;}
    
    public Village(Random random)
    {
        Events = new Queue<(ENUM_EVENT, int)>();
        
        Batimentix = new List<Batimentix>
        {
            new Bankix(random),
            new ChiefHut()
            
        };
        
        
    } // TODO
    
    
    
    
    public ChiefHut ChiefHut
    {
        get
        {
            
            for (int i = 0; i < Batimentix.Count; i++)
            {
                if (Batimentix[i] is ChiefHut chiefHut)
                {
                    return chiefHut;
                }
            }

            throw new GaulsException();
        }
    }

    public int Population
    {
        get
        {
            return ChiefHut.GetPopulation();
        }
        set
        {
            ChiefHut.SetPopulation(value);
        }
        
    }

    public int FreePopulation
    {
        get
        {
            return ChiefHut.GetFreePopulation();

        }
    }

    public int Level {
        get
        {
            return ChiefHut.GetLevel();
        }

        private set
        {
            ChiefHut.SetLevel(value);
        } 
    }
    
    public Bankix Bankix
    {
        get
        {
            int nbbank = 0;
            for (int i = 0; i < Batimentix.Count; i++)
            {
                if (Batimentix[i] is Bankix bank)
                {
                    nbbank++;
                    return bank;
                }
                
            }

            throw new GaulsException("If there is no bank");
        }
        
       
    }

    public int Money
    {
        get
        {
            return Bankix.GetVillageMoney();
        }
        set
        {
            Bankix.SetVillageMoney(value);

        }
    }
}