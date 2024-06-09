namespace InternMessage;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Participant> participants = new List<Participant>();

        // Create and add 10 Participant objects to the list
        participants.Add(new Participant("John", "Doe", 12));
        participants.Add(new Participant("Jane", "Doe", 14));
        participants.Add(new Participant("Jim", "Beam", 15));
        participants.Add(new Participant("Jack", "Daniels", 25));
        participants.Add(new Participant("Johnny", "Walker", 17));
        participants.Add(new Participant("Jameson", "Irish", 20));
        participants.Add(new Participant("Jose", "Cuervo", 0));
        participants.Add(new Participant("Jinro", "Soju", 2));
        participants.Add(new Participant("Jäger", "Meister", 5));
        participants.Add(new Participant("Captain", "Morgan", 7));


        string successPath = "Pathi daxil edin:";
        string failurePath = "Ikinci pathi daxil edin:";


        //string successMessage = File.ReadAllText(successPath);
        //string failureMessage = File.ReadAllText(failurePath);

        Console.WriteLine("Id daxil edin");
        int wantedId = Convert.ToInt32(Console.ReadLine());

        string message;

        Participant? participant1 = participants.FirstOrDefault(x => x.Id == wantedId);

        string path = participant1.Grade >= 18 ? successPath : failurePath;

        string fileText = File.ReadAllText(path);

        string fullName = participant1.Name + " " + participant1.Surname;
        message = fileText.Replace("Ad Soyad", fullName);
        message = message.Replace("dinamik", participant1.Grade.ToString());


        Console.WriteLine(message);
    }

}
