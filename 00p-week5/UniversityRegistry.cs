namespace UniversityResourceSystem;

public class UniversityRegistry
{
    private List<UniversityMember> _members = new List<UniversityMember>();

    public void AddMember(UniversityMember member)
    {
        _members.Add(member);
    }

    public void ExecuteAllDuties()
    {
        foreach (UniversityMember member in _members)
        {
            member.PerformDuties();
        }
        
    }

    public void GetMemberStatistics()
    {
        Console.WriteLine("Summary is....");
        foreach (UniversityMember member in _members)
        {
            member.ShowStatistic();
        }
    }
}