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
using WPF.Hospital.Service.Interface;
using WPF.Hospital.ViewModel;

namespace WPF.Hospital
{
    /// <summary>
    /// Interaction logic for AddPatient.xaml
    /// </summary>
    public partial class AddPatient : Window
    {
        private readonly IPatientService _patientService;
        public AddPatient(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
            DataContext = new PatientViewModel { Birthdate = DateTime.Now };
        }

        private void btnAddPatient_Click(object sender, RoutedEventArgs e)
        {
            var result = _patientService.Create(new DTO.Patient()
            {
                FirstName = ((PatientViewModel)DataContext).FirstName,
                LastName = ((PatientViewModel)DataContext).LastName,
                Age = Convert.ToInt32(((PatientViewModel)DataContext).Age),
                BirthDate = ((PatientViewModel)DataContext).Birthdate

            });


            if (!result.Ok)
            {
                MessageBox.Show(result.Message);
                return;
            }
            if (result.Ok)
            {
                MessageBox.Show(result.Message);
                this.Close();
            }

        }
    }
}
