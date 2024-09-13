namespace MediatorPattern;

class GroupLeaderStudent : Student
{
    public GroupLeaderStudent(Mediator mediator) : base(mediator){}
    
    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение старосте группы: " + message);
    }
}