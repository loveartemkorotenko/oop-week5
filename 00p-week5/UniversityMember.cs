namespace UniversityResourceSystem;

public class UniversityMember
{
    private string _name;

    private string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Ім'я не може бути пустим");
            Name = _name;
        }
        
    }

    public string MemberId { get; }

    private protected List<string> ActionLog = new List<string>();

    public UniversityMember(string name, string id)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id))
            throw new ArgumentException("Помилка. Проблема з даними.");
        Name = name;
        MemberId = id;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count > 5)
        {
            throw new InvalidOperationException($"Студент {Name}, {MemberId} досягнув денного обмеження в 5 взаємодій");
        }
    }
}