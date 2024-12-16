namespace RiseOfGauls.Core;

public class Bankix : Batimentix
{
    private Stack<int> _tradeHistory;
    private Random _random;
    private int _villageMoney;

    public Bankix(Random random) : base(15,15,5)
    {
        _random = random;
        Level = 1;
        _villageMoney = 25;

    } // TODO
    
    public int GetVillageMoney()
    {
        return _villageMoney;
    }
    
    public void SetVillageMoney(int money)
    {

        _villageMoney = money;

    }
    
    public int CollectTaxes(int population)
    {
        int taxes = Level * population * _random.Next(1,10);
        return taxes;

    }





    public int Trade(int amount, int risk)
    {
        
        
        
        
        
    }

    
    
    
    

}