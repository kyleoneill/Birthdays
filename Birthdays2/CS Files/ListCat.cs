using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays2
{
    class ListCat
    {
        public static List<Person> CreatePersonList()
        {
            string[] tempArray = new string[2];
            string[] fileInfo = FileManipulation.ReadFile();
            List<Person> personList = new List<Person>();
            foreach (string line in fileInfo)
            {
                Person newPerson = new Person();
                tempArray = line.Split(',');
                newPerson.Name = tempArray[0];
                newPerson.Birthday = Convert.ToDateTime(tempArray[1]);
                personList.Add(newPerson);
            }
            return personList;
        }
        public static bool checkIfNameExists(string input)
        {
            List<Person> personList = CreatePersonList();
            bool nameExists = false;
            foreach(Person person in personList)
            {
                if(input == person.Name)
                {
                    nameExists = true;
                }
            }
            return nameExists;
        }
    }
}
