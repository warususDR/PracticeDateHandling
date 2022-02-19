using PracticeDateHandling.Models;
using PracticeDateHandling.Tools;
using PracticeDateHandling.Tools.KMA.ProgrammingInCSharp2022.Practice3LoginControlMVVM.Tools;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PracticeDateHandling.ViewModels
{
    class DatePickViewModel : INotifyPropertyChanged
    {
        private User _user = new User();

        private RelayCommand<object> _submitDateCommand;
        private RelayCommand<object> _cancelCommand;

        private string _birthdayMessage;

        public string BirthdayMessage
        {
            get { return _birthdayMessage; }
            set { _birthdayMessage = value;
                OnPropertyChanged("BirthdayMessage");
            }
        }

        public string Age
        {
            get 
            {
                return _user.Age; 
            }
            set { _user.Age = value;
                OnPropertyChanged("Age");
            }
        }

        public DateTime Birthday
        {
            get { return _user.Birthday; }
            set { _user.Birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        public string Zodiac
        {
            get { return _user.Zodiac; }
            set { _user.Zodiac = value;
                OnPropertyChanged("Zodiac");
            }
        }

        public string ZodiacChinese
        {
            get { return _user.ZodiacChinese; }
            set { _user.ZodiacChinese = value;
                OnPropertyChanged("ZodiacChinese");
            }
        }

        public RelayCommand<object> SubmitDateCommand
        {
            get
            {
                return _submitDateCommand ??= new RelayCommand<object>(_ => SubmitDate(), canExecute);
            }
        }

        public RelayCommand<object> CancelCommand
        {
            get
            {
                return _cancelCommand ??= new RelayCommand<object>(_ => Environment.Exit(0), canExecute);
            }
        }
        
        private bool canExecute(object obj)
        {
            return true;
        }
        private void SubmitDate()
        {
            try
            {
                BirthdayMessage = "";
                Age = Utilities.getAge(_user.Birthday).ToString();
                Zodiac = Utilities.Zodiac(_user.Birthday);
                ZodiacChinese = Utilities.ChineseZodiac(_user.Birthday);
                if (_user.Birthday.Day == DateTime.Now.Day && _user.Birthday.Month == DateTime.Now.Month) BirthdayMessage = "Happy Birthday!"; 
            }
            catch
            {
                MessageBox.Show("Date of birth isn't entered correctly. Please enter it in format d.m.y or choose it from calendar");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
