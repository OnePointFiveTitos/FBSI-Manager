using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class EmailViewModel : InformationObjectViewModel
    {
        private Email email;
        public Array Types { get => Email.types; }
        public EmailTypes EmailType
        {
            get => email.type;
            set
            {
                if (email.type != value)
                {
                    email.type = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Handle
        {
            get => email.handle;
            set
            {
                if (email.handle != value)
                {
                    email.handle = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Domain
        {
            get => email.domain;
            set
            {
                if (email.domain != value)
                {
                    email.domain = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Register
        {
            get => email.register;
            set
            {
                if (email.register != value)
                {
                    email.register = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FullEmail { get => string.Format($"{Handle}@{Domain}.{Register}"); }

        public EmailViewModel(Email email = null)
        {
            this.email = email ?? new Email();
        }//end ctor
    }//end class
}