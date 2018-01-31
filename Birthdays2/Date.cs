using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Birthdays2
{
    class Date
    {
        public static int MaxDaysInMonth(int month)
        {
            int maxDay = 0;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                maxDay = 30;
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                maxDay = 31;
            }
            else if (month == 2)
            {
                maxDay = 28;
            }
            return maxDay;
        }
        public static void DaysUntilBirthday(Person person, TextBox textbox)
        {
            string name = person.Name;
            int bDay = person.Birthday.Day;
            int bMonth = person.Birthday.Month;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int daysUntilBirthday = bDay - currentDay;
            bool birthdayPassed = daysUntilBirthday < 0;
            if (bMonth == currentMonth)
            {
                if (birthdayPassed)
                {
                    textbox.Text += name + "\'s birthday is " + bMonth + "/" + bDay + ", which was " + (daysUntilBirthday * -1) + " days ago.";
                }
                else
                {
                    textbox.Text += name + "\'s birthday is " + bMonth + "/" + bDay + ", which is " + daysUntilBirthday + " days away.";
                }
            }
            else if (bMonth == (currentMonth + 1))
            {
                int daysLeftInMonth = MaxDaysInMonth(currentMonth) - currentDay;
                int daysUntilFutureBirthday = daysLeftInMonth + bDay;
                textbox.Text += name + "\'s birthday is " + bMonth + "/" + bDay + ", which is " + daysUntilFutureBirthday + " days away.";
            }
        }
    }
}
