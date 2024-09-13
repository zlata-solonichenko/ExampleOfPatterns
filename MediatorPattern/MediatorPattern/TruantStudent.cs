namespace MediatorPattern;

class TruantStudent : Student
{
    public TruantStudent(Mediator mediator) : base(mediator){}
    
    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение прогульщику: " + message);
    }
}