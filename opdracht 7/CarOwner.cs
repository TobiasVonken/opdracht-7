using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_7
{
    public class CarOwner 
    { 

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value;}
        }
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value;}
        }

        

        private ObservableCollection<string> _Cars;

        public ObservableCollection<string> Cars
        {
            get { return _Cars; }
            set { _Cars = value; }
        }

        public CarOwner()
        {
            _Cars = new ObservableCollection<string>();
        }



    }
}
