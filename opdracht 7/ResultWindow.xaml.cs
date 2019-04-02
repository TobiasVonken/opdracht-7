using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace opdracht_7
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public CarOwner NewCarOwnder { get; set; }


        public ResultWindow(string json)
        {

            try
            {
                NewCarOwnder = JsonConvert.DeserializeObject<CarOwner>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            InitializeComponent();
        }
    }
}
