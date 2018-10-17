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

namespace FormWpfApp
{
    public class TestForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }

        public TestForm()
        {
            FirstName = "";
            LastName = "";
            Gender = "";
            DateOfBirth = "";
        }

        public TestForm(string firstName, string lastName, string gender, string dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Gender + " " + DateOfBirth;
        }
    }
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TestForm TestForm { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            SendButton.Click += btn_Click;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            var firstName = FirstName.Text;
            var lastName = LastName.Text;
            var gender = Gender.Text;
            var dateOfBirth = DateOfBirth.Text;
            TestForm = new TestForm(firstName, lastName, gender, dateOfBirth);
            Output.Text = TestForm.ToString();
        }
    }
}
