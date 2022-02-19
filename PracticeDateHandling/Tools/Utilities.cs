﻿using System;
using System.Collections.Generic;

namespace PracticeDateHandling.Tools
{
    class Utilities
    {
        public static int getAge(DateTime date)
        {
            var currentTime = DateTime.Now;
            if (date > currentTime) throw new Exception();
            var age = currentTime.Year - date.Year;
            if (date.Date > currentTime.AddYears(-age)) age--;
            if (age > 135) throw new Exception();
            return age;
        }

        public static string Zodiac(DateTime date)
        {
            List<string> arrZodiak = new() { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
            int day = date.Day;
            int month = date.Month;
            string zodiacSign = "";
            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                zodiacSign = arrZodiak[0];
            else
            if ((month == 4 && day >= 21) || (month == 5 && day <= 20))
                zodiacSign = arrZodiak[1];
            else
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                zodiacSign = arrZodiak[2];
            else
			if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
				zodiacSign = arrZodiak[3]; 
			else
			if ((month == 7 && day >= 23) || (month == 8 && day <= 23))
				zodiacSign = arrZodiak[4];
			else
			if ((month == 8 && day >= 24) || (month == 9 && day <= 23))
				zodiacSign = arrZodiak[5];
			else
			if ((month == 9 && day >= 24) || (month == 10 && day <= 22))
				zodiacSign = arrZodiak[6];
			else
			if ((month == 10 && day >= 23) || (month == 11 && day <= 22))
				zodiacSign = arrZodiak[7];
			else
			if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
				zodiacSign = arrZodiak[8];
			else
			if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
				zodiacSign = arrZodiak[9];
            else
			if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
				zodiacSign = arrZodiak[10];
			else
			if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
				zodiacSign = arrZodiak[11];

			return zodiacSign;
		}

		public static string ChineseZodiac(DateTime date)
        {
            List<string> arrZodiak = new List<string>() { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Ram" };
			int year = date.Year;
			return arrZodiak[year % 12];
		}
    }
}
