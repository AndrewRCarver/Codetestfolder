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

namespace WpfBrowserApp1
{
	/// Hello, this is a change
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            string htmlString = textBox2.Text; 

                if (radioButton1.IsChecked == true)
                {
                    MessageBox.Show("Elsevier" + htmlString);
                }
                else
                {
                    radioButton2.IsChecked = true;
                    MessageBox.Show("PLOS" + htmlString);
                }
            
        }

    
    }
}
