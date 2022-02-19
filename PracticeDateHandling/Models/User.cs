using System;

namespace PracticeDateHandling.Models
{
    class User 
    {
        private string _age;
        private DateTime _birthday;
        private string _zodiac;
        private string _zodiacChinese;


        public string Age
        {
            get { return _age; }
            set 
            { 
                _age = value;
            }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set 
            {
                _birthday = value;
            }
        }
        public string Zodiac
        {
            get { return _zodiac; }
            set 
            {
                _zodiac = value;
            }
        }

        public string ZodiacChinese
        {
            get { return _zodiacChinese; }
            set 
            { 
                _zodiacChinese = value;
            }
        }

       

    }
}
