using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_23_2
{
    class Person
    {
        string name;
        string lastName;
        int serialNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }


        public DateTime dateOfBirth;
        
        public DateTime InputDateOfBirth()
        {
            string input;
            input = Console.ReadLine();            
            dateOfBirth = DateTime.ParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None);
            return dateOfBirth;
        }


        public DateTime dateOfStart;
        public DateTime InputDateOfStartWorked()
        {
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dateOfStart));

            return dateOfStart;
        }


    }
}
