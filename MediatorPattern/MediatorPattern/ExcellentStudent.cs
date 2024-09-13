namespace MediatorPattern;

class ExcellentStudent : Student
{
    public ExcellentStudent(Mediator mediator) : base(mediator){}
    
    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение отличнику: " + message);
    }
}