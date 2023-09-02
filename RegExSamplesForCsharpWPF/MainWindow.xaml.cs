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
using System.Text.RegularExpressions;


namespace RegExSamplesForCsharpWPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Regex rxTesteri;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_FinDate.Text != string.Empty) {
                rxTesteri = new Regex("^([0-9]{1,2}).([0-9]{1,2}).([0-9]{4,4})$");
                Match rxOsuma = rxTesteri.Match(tb_FinDate.Text);
                if (rxOsuma.Success)
                {
                    tb_Feedback.Text = "You gave a correct Finnish date!";
                }
                else
                {
                    tb_Feedback.Text = "This is not a Correct Finnish date. It would be for example 12.9.2022 or 12.09.2022";

                }
            }
            else
            {
                tb_Feedback.Text = "Finnish date has to be given to use this functionality. ";
                
            }
        }
    }
}
