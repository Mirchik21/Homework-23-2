namespace homework_23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            try
            {
                Console.WriteLine("Enter Name:");
                person.Name = Console.ReadLine();
                Console.WriteLine("Enter LastName:");
                person.LastName = Console.ReadLine();
                if (int.TryParse(person.LastName, out int id) || int.TryParse(person.Name, out int Id))
                {
                    throw new Exception("You entered a number instead of a string!!!");
                }
                Console.WriteLine("Enter date of birth in format - dd.MM.yyyy (Day.Month.Year):");
                person.InputDateOfBirth();
                Console.WriteLine("Enter date of start worked in format - dd.MM.yyyy (Day.Month.Year):");
                person.InputDateOfStartWorked();
                if (person.dateOfBirth > DateTime.Now || person.dateOfStart > DateTime.Now)
                {
                    throw new Exception("You entered a date that has not yet arrived (future tense)");
                }
                
                Console.WriteLine("Enter serial number:");
                person.SerialNumber = int.Parse(Console.ReadLine());
                if (person.SerialNumber < 0)
                {
                    throw new Exception("You have entered an invalid user number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            DateTime today = DateTime.Today;
            TimeSpan ts = today - person.dateOfStart;
          
            
            Console.WriteLine($"User name: {person.Name} ");
            Console.WriteLine($"User last name: {person.LastName} ");
            Console.WriteLine($"Years of birth {person.dateOfBirth}");
            Console.WriteLine($"Started working from {person.dateOfStart}");
            Console.WriteLine($"Employee serial number { person.SerialNumber}");
            Console.WriteLine($"Work experience totals {ts} days.");

            
        }
    }
}