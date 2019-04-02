using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace opdracht_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :  Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private CarOwner _newCarOwner;
        public CarOwner NewCarOwner
        {
            get
            {
                return _newCarOwner;
            }
            set
            {
                _newCarOwner = value;
                NotifyPropertyChanged();

            }
        }
        public ObservableCollection<CarOwner> carOwners { get; set; }

        private string _CarBrand;

        public string CarBrand
        {
            get { return _CarBrand; }
            set { _CarBrand = value; }
        }
            


        public MainWindow()
        {
            NewCarOwner = new CarOwner();
            carOwners = new ObservableCollection<CarOwner>();
            InitializeComponent();
        }
        
        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {
            NewCarOwner.Cars.Add(CarBrand);
            CarBrand = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(NewCarOwner);

            ResultWindow window = new ResultWindow(json);
            window.Show();
        }

    }
}
