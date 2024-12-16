namespace RiseOfGauls.Core;

public class Batimentix
{
    protected long Cost;
    protected int Durability;
    protected int MaxDurability;
    protected int Level = 1;
    protected int Population;


    public Batimentix(long cost, int maxDurability, int population)
    {
        if (Cost < 0 || maxDurability < 0 || Level < 0 || Population < 0 )
        {
            throw new GaulsException();
        }
        Cost = cost;
        MaxDurability = maxDurability;
        Durability = maxDurability;
        Level = 1;
        Population = population;
        
    } // TODO


    public int GetLevel()
    {
        return Level;

    } // TODO

    public void SetLevel(int level)
    {
        if (Level < 0)
        {
            throw new GaulsException();
        }
        Level = level;
    } // TODO




    public long GetCost()
    {
        return (long)(Cost * Math.Ceiling(Math.Pow(Level, Level * 0.3)));
    } // TODO
    
    public void SetCost(long baseCost)
    {
        if (Cost < 0)
        {
            throw new GaulsException();
        }
        Cost = baseCost;
    } // TODO



    public int GetDurability()
    {
        return Durability;


    } // TODO

    public void SetDurability(int durability)
    {
        if (Durability < 0)
        {
            throw new GaulsException();
        }
        if (durability > MaxDurability)
        {
            Durability = MaxDurability;
        }
        
        else
        {
            Durability = durability;
        }
        
    } // TODO



    public int GetPopulation()
    {
        return Population;
    } // TODO

    
    
    
    

}
    
    