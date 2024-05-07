using System.Xml.Linq;

namespace CustomerFeatures;

internal class Program
{
    static void Main(string[] args)
    {
        CustomerFile customerFile = new CustomerFile("Hello.jpg", 38196);
        customerFile.GetFileDetails();
    }
}
public class Customer
{
    public Customer(string name, string surname, int birthYear)
    {
        Name = name;
        Surname = surname;
        BirthYear = birthYear;
        Age = AgeCalculator();
        Email = GenerateMail();
        Username = GenerateUsername();
        IsActive = ActiveProfile();
        Created = DateTime.UtcNow;
    }
    public string Name;
    public string Surname;
    public int BirthYear;
    public int Age;
    public string Username;
    public string Email;
    public bool IsActive;
    public DateTime Created;

    public string GenerateUsername()
    {
        string username = "";
        username += Name;

        int surnameLength = Math.Min(4, Surname.Length);
        username += Surname.Substring(0, surnameLength);

        return username.ToLower();
    }
    public int AgeCalculator() =>
        DateTime.Now.Year - BirthYear;

    public string GenerateMail() =>
        string.Concat(Name, Surname, Age, "@mail.com").ToLower();

    public bool ActiveProfile() =>
        Age > 16 ? true : false;

    public string GetCustomerDetails()
    {
        return $"{Name} {Surname} {BirthYear} Username: {Username} Email: {Email} Age:{Age} Is Active? {IsActive} Created: {Created}";
    }

}

public class CustomerFile
{
    public CustomerFile(string name, double size)
    {
        Name = name;
        Size = ConvertKilobyteToMegabyte(size);
        FileExtension = DetectFileExtension(name);
        IsImageFile = IsPhotoExtension();

    }
    public string Name;
    public string FileExtension;
    public double Size;
    public bool IsImageFile;

    public string DetectFileExtension(string filename)
    {
        int lastDotIndex = filename.LastIndexOf('.');

        if (lastDotIndex >= 0 && lastDotIndex < filename.Length)
        {
            string extension = filename.Substring(lastDotIndex);
            return extension;
        }
        return "Invalid path";
    }
    public bool IsPhotoExtension()
    {
        string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp", ".svg", ".ico" };
        return allowedExtensions.Contains(FileExtension);
    } 
    public double ConvertKilobyteToMegabyte(double kilobyte)
    {
        return Math.Round(kilobyte / 1024,2);
    }
    public bool CheckSize()
    {
        return Size < 5?true:false;
    }
    public void GetFileDetails()
    {
        Console.WriteLine($"{Name} {Size} {FileExtension} Is image?{IsImageFile}");
    }
}




