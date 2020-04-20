/* Dominic Langowski 
    4/16/2020
    Teenage Abbreviation Program*/  
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

namespace TeenageAbbreviations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        string line;
        int positionofFirstComma = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTranslate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("list_of_short_forms.txt");
                while(!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    positionofFirstComma = line.IndexOf(",");
                    ///MessageBox.Show(positionofFirstComma.ToString());
                    string shortform = line.Substring(0, positionofFirstComma);
                    ///MessageBox.Show(longform);
                    string longform = line.Substring(positionofFirstComma + 1);
                    //MessageBox.Show(shortform);
                    

                    if (txtInput.Text == shortform)
                    {
                        lblOutput.Content = longform;
                        break;
                    }
                    else if(txtInput.Text != null)
                    {
                        lblOutput.Content = "Sorry, not in the database";
                        
                    }
                    
                   
                }
                

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

           
        }
    }
}
