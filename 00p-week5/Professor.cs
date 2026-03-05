

namespace UniversityResourceSystem;

public class Professor : UniversityMember
{
    public Professor(string name, string course) : base(name, course){}

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        base.PerformDuties();
        ActionLog.Add($" Researched {topic}");
    }
}