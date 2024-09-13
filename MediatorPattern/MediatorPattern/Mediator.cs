namespace MediatorPattern;

abstract class Mediator
{
    public abstract void Send(string msg, Student student);
}