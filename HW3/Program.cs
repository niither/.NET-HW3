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

        private int[] Zaliky;
        private int[] Kursovi;
        private int[] Ispyty;

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
        public int[] GetZaliky()
        {
            return Zaliky;
        }

        public int[] GetKursovi()
        {
            return Kursovi;
        }

        public int[] GetIspyty()
        {
            return Ispyty;
        }

        public void SetZaliky(int[] Zaliky)
        {
            this.Zaliky = Zaliky;
        }

        public void SetKursovi(int[] Kursovi)
        {
            this.Kursovi = Kursovi;
        }

        public void SetIspyty(int[] Ispyty)
        {
            this.Ispyty = Ispyty;
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
            Console.WriteLine("Zaliky: " + string.Join(" ", Zaliky));
            Console.WriteLine("Kursovy: " + string.Join(" ", Kursovi));
            Console.WriteLine("Ispyty: " + string.Join(" ", Ispyty));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Antonenko", "Anton", "Leonidovych", "01.01.2000", "No Street str., NoCity", "+000123456789");

            st1.SetZaliky(new int[] { 2, 9, 8, 6, 12 });
            st1.SetKursovi(new int[] { 3, 5, 4 });
            st1.SetIspyty(new int[] { 12, 10, 7, 6 });

            st1.ShowInfo();
        }
    }
}