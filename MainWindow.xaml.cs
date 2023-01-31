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
//Tyler Simpson
//1-29-2023
//lab1
namespace Lab1
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //change label from "+||-" to just "+"
            lblAddSub.Content = "+";

            //declare variables for strings from user input 
            string value1 = txtNum1.Text;
            string value2 = txtNum2.Text;

            //declare variables for doubles 
            double val1, val2 = 0;

            //Try to parse strings to doubles and return a bool of true or false
            bool numCheck1 = double.TryParse(value1, out val1);
            bool numCheck2 = double.TryParse(value2, out val2);

            //if statement to check if strings have been converted to doubles succesfully
            if (numCheck1 && numCheck2)
            {
                //parse was succesful, now add the two doubles and display the results to user
                double sum = val1 + val2;
                txtNum3.Text = sum.ToString();

            }
            else
            {
                //parse not succesful, display message box alerting user of error
                MessageBox.Show("Please enter valid numbers.");
            }
            

            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

            //change label from "+||-" to just "-"
            lblAddSub.Content = "-";

            //declare variables for strings from user input 
            string value1 = txtNum1.Text;
            string value2 = txtNum2.Text;

            //declare variables for doubles 
            double val1, val2 = 0;

            //Try to parse strings to doubles and return a bool of true or false
            bool numCheck1 = double.TryParse(value1, out val1);
            bool numCheck2 = double.TryParse(value2, out val2);

            //if statement to check if strings have been converted to doubles succesfully
            if (numCheck1 && numCheck2)
            {
                //parse was succesful, now subtract the two doubles and display the results to user
                double difference = val1 - val2;
                txtNum3.Text = difference.ToString();

            }
            else
            {
                //parse not succesful, display message box alerting user of error
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //change label from "X||/" to just "X"
            lblMultiplyDivide.Content = "X";

            //declare variables for strings from user input 
            string value3 = txtNum4.Text;
            string value4 = txtNum5.Text;

            //declare variables for doubles 
            double val3, val4 = 0;

            //Try to parse strings to doubles and return a bool of true or false
            bool numCheck3 = double.TryParse(value3, out val3);
            bool numCheck4 = double.TryParse(value4, out val4);

            //if statement to check if strings have been converted to doubles succesfully
            if (numCheck3 && numCheck4)
            {
                //parse was succesful, now multiply the two doubles and display the results to user
                double product = val3 * val4;
                txtNum6.Text = product.ToString();

            }
            else
            {
                //parse not succesful, display message box alerting user of error
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //change label from "X||/" to just "X"
            lblMultiplyDivide.Content = "/";

            //declare variables for strings from user input 
            string value3 = txtNum4.Text;
            string value4 = txtNum5.Text;

            //declare variables for doubles 
            double val3, val4 = 0;

            //Try to parse strings to doubles and return a bool of true or false
            bool numCheck3 = double.TryParse(value3, out val3);
            bool numCheck4 = double.TryParse(value4, out val4);

            //if statement to check if strings have been converted to doubles succesfully
            if (numCheck3 && numCheck4)
            {
                //parse was succesful, now divide the two doubles and display the results to user
                double quotient = val3 / val4;
                txtNum6.Text = quotient.ToString();

            }
            else
            {
                //parse not succesful, display message box alerting user of error
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnAvg_Click(object sender, RoutedEventArgs e)
        {
            //declare variables for strings from user input
            string numAvg1 = txtNum3.Text;
            string numAvg2 = txtNum6.Text;

            //parse strings to doubles
            double avg1 = double.Parse(numAvg1);
            double avg2 = double.Parse(numAvg2);

            //declare average variable and calculate
            double avg = (avg1 + avg2) / 2;

            //display results to user
            txtNum7.Text = avg.ToString();
        }
    }
}
