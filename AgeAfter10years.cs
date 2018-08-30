﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateAndTime
{
    class AgeAfter10years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Date of Birth");//Enter input in this format MM dd yyyy
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;//Current Date and Time is stored in "now "
            //Subracting the current time from birthday to obtain no of days which is divided by 365.242199
            int age = (int)((now - BirthDay).TotalDays/365.242199);//365.24199 is exact duration of a year
            //Dividing the number of days by the 365 gives us the the current age
            DateTime after10 = now.AddYears(10);//This adds 10 years to current date and time
            int age_10 = (int)((after10 - BirthDay).TotalDays / 365.24199);//Age after 10 years
            Console.WriteLine("Your current age is "+age);
            Console.WriteLine("Your age after 10 years will be " + age_10);
            Console.Read();
        }
    }
}
