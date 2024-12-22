namespace RiseOfGauls.Core;

public class Village
{

    public List<Batimentix> Batimentix { get; set; }
    public Queue<(ENUM_EVENT, int)> Events {get; set;}
    
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
}