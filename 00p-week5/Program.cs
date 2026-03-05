

namespace UniversityResourceSystem;

class Progam
{
    static void Main()
    {
        UniversityRegistry registry = new UniversityRegistry();
        Professor prof = new Professor("Brik", "cs101");
        UndergraduateStudent undergraduateStudent = new UndergraduateStudent("TonnyStark", "001");
        GraduateStudent graduateStudent = new GraduateStudent("HelloBiden", "blablabla");

        registry.AddMember(prof);
        registry.AddMember(undergraduateStudent);
        registry.AddMember(graduateStudent);

        registry.ExecuteAllDuties();
        registry.GetMemberStatistics();
        prof.ConductResearch("Atomic bomb");
        registry.ExecuteAllDuties();
        registry.GetMemberStatistics();
    }
}
