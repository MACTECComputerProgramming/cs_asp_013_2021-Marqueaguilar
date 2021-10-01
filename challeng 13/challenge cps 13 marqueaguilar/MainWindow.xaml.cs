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

namespace challenge_cps_13_marqueaguilar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double total_ = 3.50;
            string subName = "six inches";


            if (radioButtontwelve.IsChecked == true)
            {
                total_ = 5.00;
                subName = "12 inch";
            }

            if (RadioButtonwheat.IsChecked == true)
            { subName = subName + " wheat"; }

            if (RadioButtonitilan.IsChecked == true)
            { subName = subName + " itilan"; }

            if (RadioButtonflat.IsChecked == true)
            {
                subName = subName + " flat bread";
                total_ = total_ + 0.25;
            }
            if (RadioButtonham.IsChecked == true)
            { subName = subName + " ham"; }

            if (RadioButtonchicken.IsChecked == true)
            { subName = subName + " chicken"; }

            if (RadioButtonmeatball.IsChecked == true)
            {
                subName = subName + " meatball";
                total_ = total_ + 1.00;
            }

            if (RadioButtonsteak.IsChecked == true)
            {
                subName = subName + " steak";
                total_ = total_ + 1.50;
            }

            if (CheckBoxgp.IsChecked == true)
            {
                subName = subName + " green pepers";
                total_ = total_ + 0.25;
            }

            if (CheckBoxonion.IsChecked == true)
            {
                subName = subName + " onions";
                total_ = total_ + 0.10;
            }

            if (CheckBoxlettus.IsChecked == true)
            {
                subName = subName + " lettus";
                total_ = total_ + 0.10;
            }

            if (CheckBoxall.IsChecked == true)
            {
                subName = subName + " all vegies";
                total_ = total_ + 0.50;
            }

            if (CheckBoxamerican.IsChecked == true)
            {
                subName = subName + " and american cheese.";
                total_ = total_ + 0.25;
            }

            if (CheckBoxswiss.IsChecked == true)
            {
                subName = subName + " and swiss cheese.";
                total_ = total_ + 0.50;
            }

            if (CheckBoxpeperjack.IsChecked == true)
            {
                subName = subName + " and peper jack cheese.";
                total_ = total_ + 0.75;
            }



            {
                if (radioButtontwelve.IsChecked == true)

                    if (RadioButtonmeatball.IsChecked == true)

                        if (CheckBoxamerican.IsChecked == true)

                        {
                            total_ = total_ - 2.00;
                            subName = " the special";

                        }

                total.Content = total_;
                subname.Content = subName;

            }






        }

    }
}

       

        

