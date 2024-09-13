namespace MediatorPattern;

class ManagerMediator : Mediator
{
    public Student GroupLeader { get; set; }
    public Student ExcellentStudent { get; set; }
    public Student Truant { get; set; }
    
    public override void Send(string msg, Student student)
    {
        if (GroupLeader == student)
            GroupLeader.Notify(msg);
        else if (ExcellentStudent == student)
            ExcellentStudent.Notify(msg);
        else if (Truant == student)
            Truant.Notify(msg);
    }
}