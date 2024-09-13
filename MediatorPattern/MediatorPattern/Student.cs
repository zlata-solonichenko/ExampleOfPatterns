namespace MediatorPattern;

abstract class Student
{
    protected Mediator mediator;
 
    public Student(Mediator mediator)
    {
        this.mediator = mediator;
    }
 
    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }
    public abstract void Notify(string message);
}