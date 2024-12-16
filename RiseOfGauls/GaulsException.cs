namespace RiseOfGauls;

public class GaulsException : Exception
{
    public GaulsException() : base("A problem happened in the village:")
    {
    } // TODO

    public GaulsException(string message): base("A problem happened in the village: " + message)
    {
    } // TODO
    
}