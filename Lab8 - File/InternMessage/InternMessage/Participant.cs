namespace InternMessage;

internal class Participant
{
    private static int _id = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Grade { get; set; }

    public Participant(string name, string surname, int grade)
    {
        Name = name;
        Surname = surname;
        Grade = grade;
        Id = _id++;
    }
}
