using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Reporting.WinForms;
namespace rdlc_report_CB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Window> Windows { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Windows = new List<Window> 
            { 
                new Window { Name = "UsersWindow" },
                new Window { Name = "SettingsWindow"  }, 
                new Window { Name = "SettingsWindow" }
            };
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = (ComboBox)e.Source;

            if (comboBox.SelectedItem == null) return;

            var selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            var window = Windows.FirstOrDefault(w => w.Name.Equals(selectedItem.Tag));

            if (window == null) return;
            window.ShowDialog();
        }
    }
}
