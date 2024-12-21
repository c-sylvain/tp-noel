namespace RiseOfGauls.Core;

public class Bankix : Batimentix
{
    private Stack<int> _tradeHistory;
    private Random _random;
    private int _villageMoney;

    public Bankix(Random random) : base(15,15,5)
    {
        _tradeHistory = new Stack<int>();
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
        if (amount <= 0 || risk <= 0)
        {
            throw new GaulsException("Amount and risk must be greater than 0");
        }

        if (risk >= 100)
        {
            throw new GaulsException("Risk must be less than 100");
        }
        
        int aleatoire = _random.Next(1, 100);
        int result = amount * _random.Next(1, risk);
        

        if (aleatoire > risk)
        {
            _tradeHistory.Push(result);
            return result;
        }
        
        if (aleatoire < risk && result > 0)
        {
            _tradeHistory.Push(-result);
            return -result;
        }
        else
        {
            _tradeHistory.Push(result);
            return result;
        }
        
        
    }


    public Stack<int> GetTradeHistory()
    {
        return _tradeHistory;
    }




    public int TradeAndRecord(int amount, int risk)
    {
        int result = Trade(amount, risk);
        return result;


    }
    
    
    
    
    

}