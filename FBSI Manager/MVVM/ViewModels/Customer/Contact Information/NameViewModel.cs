using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace FBSI_Manager
{
    //the reason teh nameviewmodel inherits from a regular observable object instead of an information object is because
    //the info object declares a nameviewmodel object used a an associated named
    public class NameViewModel : ObservableObject
    {
        private Name name;
        public Array Types { get => Name.types; }
        public bool IsMain
        {
            get => name.isMain;
            set
            {
                if (name.isMain != value)
                {
                    name.isMain = value;
                    OnPropertyChanged();
                }
            }
        }
        public GenerationTypes Title
        {
            get => name.type;
            set
            {
                if (name.type != value)
                {
                    name.type = value;
                    OnPropertyChanged();
                }
            }
        }
        public string First
        {
            get => name.first;
            set
            {
                if (name.first != value)
                {
                    name.first = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Middle
        {
            get => name.middle;
            set
            {
                if (name.middle != value)
                {
                    name.middle = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Last
        {
            get => name.last;
            set
            {
                if (name.last != value)
                {
                    name.last = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FullName { get => string.Format($"{First} {Middle} {Last}{Title.ToString()}"); }

        public NameViewModel(Name name = null)
        {
            this.name = name ?? new Name();
        }//end ctor
    }//end class
}