namespace RiseOfGauls.Core;

public class Event
{
    public string Message { get; set; }
    public Queue<(ENUM_EVENT, int)> Events {get; set;}




    public Event(string message, (ENUM_EVENT, int)[] array)
    {
        
        Message = message;
        Events = new Queue<(ENUM_EVENT, int)>(array);
    }
    
    

}