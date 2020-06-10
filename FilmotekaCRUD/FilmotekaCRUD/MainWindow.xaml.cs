using System;
using System.Collections.Generic;
using System.Data;
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

namespace FilmotekaCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet dataSet = new DataSet();

        public MainWindow()
        {
            InitializeComponent();

            string sampleXmlFile = "filmoteka.xml";
              dataSet.ReadXml(sampleXmlFile);
              DataView dataView = new DataView(dataSet.Tables[0]);
              dataGrid.ItemsSource = dataView;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dataSet.AcceptChanges();
            dataSet.WriteXml("filmoteka.xml");
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.SelectedIndex; 
            dataSet.Tables[0].Rows.RemoveAt(i);
            dataSet.WriteXml("filmoteka.xml");
        }
    }
}
