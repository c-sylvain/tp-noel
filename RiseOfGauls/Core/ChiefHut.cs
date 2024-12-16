namespace RiseOfGauls.Core;

public class ChiefHut : Batimentix
{
    protected int FreePopulation;

    public ChiefHut() : base(10, 20, 5)
    {
        FreePopulation = Population;
    }



    public int GetFreePopulation()
    {
        return FreePopulation;
    } // TODO

    public void SetFreePopulation(int freePopulation)
    {
        if (freePopulation > Population)
        {
            throw new GaulsException();
        }
        
        FreePopulation = freePopulation;
    } // TODO 


    public void SetPopulation(int population)
    {
        if (Population < 1)
        {
            throw new GaulsException();
        }

        if (population >= Population)
        {
            FreePopulation += population - Population;
            Population = population;
        }
        if (population < Population)
        {
            FreePopulation += Population - population;
            Population = population;
            
        }
        
        
    } // TODO
    
    
    
    
    
    
    
    
    
    

}