using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Student groupLeader = new GroupLeaderStudent(mediator);
            Student excellentStudent = new ExcellentStudent(mediator);
            Student truant = new TruantStudent(mediator);
            
            mediator.GroupLeader = groupLeader;
            mediator.ExcellentStudent = excellentStudent;
            mediator.Truant = truant;
            groupLeader.Send("Есть списки на отчисление, нужно рассказать группе");
            excellentStudent.Send("Проверить списки, обнаружить, что тебя там нет");
            truant.Send("Убедиться, что ты есть в приказе");

        }
    }
}