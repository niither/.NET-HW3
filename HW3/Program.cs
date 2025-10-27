using System.Net;

namespace HW3
{
    class Student
    {
        private string? LastName;
        private string? FirstName;
        private string? FatherName;
        private string? Birthday;
        private string? Address;
        private string? PhoneNumber;

        private List<int> Zaliky = new List<int>();
        private List<int> Kursovi = new List<int>();
        private List<int> Ispyty = new List<int>();

        public Student() : this(null, null, null, null, null, null) { }

        public Student(string LastName, string FirstName, string FatherName)
            : this(LastName, FirstName, FatherName, null, null, null) { }

        public Student(string? LastName, string? FirstName, string? FatherName,
                       string? Birthday, string? Address, string? PhoneNumber)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.FatherName = FatherName;
            this.Birthday = Birthday;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }

        public string? GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string? LastName)
        {
            this.LastName = LastName;
        }

        public string? GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string? FirstName)
        {
            this.FirstName = FirstName;
        }

        public string? GetFatherName()
        {
            return FatherName;
        }

        public void SetFatherName(string? FatherName)
        {
            this.FatherName = FatherName;
        }

        public string? GetBirthday()
        {
            return Birthday;
        }

        public void SetBirthday(string? Birthday)
        {
            this.Birthday = Birthday;
        }

        public string? GetAddress()
        {
            return Address;
        }

        public void SetAddress(string? Address)
        {
            this.Address = Address;
        }

        public string? GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(string? PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public List<int> GetZaliky()
        {
            return new List<int>(Zaliky);
        }

        public List<int> GetKursovi()
        {
            return new List<int>(Kursovi);
        }

        public List<int> GetIspyty()
        {
            return new List<int>(Ispyty);
        }

        public void AddToZaliky(int mark)
        {
            this.Zaliky.Add(mark);
        }

        public void AddToKursovi(int mark)
        {
            this.Kursovi.Add(mark);
        }

        public void AddToIspyty(int mark)
        {
            this.Ispyty.Add(mark);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student info");
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Name: " + FirstName);
            Console.WriteLine("Father name: " + FatherName);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Adress: " + Address);
            Console.WriteLine("Phone num: " + PhoneNumber);
            Console.WriteLine("Zaliky: " + string.Join(", ", Zaliky));
            Console.WriteLine("Kursovy: " + string.Join(", ", Kursovi));
            Console.WriteLine("Ispyty: " + string.Join(", ", Ispyty));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Antonenko", "Anton", "Leonidovych", "01.01.2000", "No Street str., NoCity", "+000123456789");

            st1.AddToZaliky(90);
            st1.AddToZaliky(85);
            st1.AddToKursovi(88);
            st1.AddToKursovi(92);
            st1.AddToIspyty(95);

            st1.ShowInfo();

            Console.ReadLine();
        }
    }
}