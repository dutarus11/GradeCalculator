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
using System.Windows.Shapes;


namespace GradeCalculator
{
    /// <summary>
    /// Interaction logic for GradeCalculator1.xaml
    /// </summary>
    public partial class GradeCalculator1 : Window
    {
        public double num1;
        
        public double num2;
        public double num3;
        public double num4;
        public double totalNum;

        public GradeCalculator1()
        {
            InitializeComponent();
            
        }

        //calculator logic 
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
            num1 = double.Parse(textInput.Text);
           
            num2 = double.Parse(textInput1.Text);
           
            num3 = double.Parse(textInput2.Text);
            
            num4 = double.Parse(textInput3.Text);
            totalNum = (num1 + num2 + num3 + num4) / 4;

            MessageBox.Show("Overall Semester GPA: " + totalNum.ToString());
                
        }
    
       
    }
}
