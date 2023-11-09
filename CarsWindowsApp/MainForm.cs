using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsWindowsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // add colors to cmb colors
            this.cmbColor.Items.AddRange(new string[] { "red", "yellow", "black", "blue", "green" });

            // add country 
            this.cmbCountryOfOrigin.Items.AddRange(new string[] { "UK", "Italy", "US", "Spain", "Germany" });

            this.btnFinish.Enabled = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string carName = this.txtCarName.Text;

            string carColor = this.cmbColor.Text;

            int? carMileageNl=null;
            int carMileage;
            if(int.TryParse(this.txtMileage.Text, out carMileage)) carMileageNl = carMileage;

            int? carNumberOfDoorsNl=null;
            int carNumberOfDoors;
            if(int.TryParse(this.txtNumberOfDoors.Text, out carNumberOfDoors)) carNumberOfDoorsNl = carNumberOfDoors;

            string carCountryOfOrigin = this.cmbCountryOfOrigin.Text;

            Car car = new Car(carName, carColor, carMileageNl, carNumberOfDoorsNl, carCountryOfOrigin);

            CarData.AddCar(car);
            if (CarData.ShouldEnableFinishAction())
            {
                this.btnFinish.Enabled = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            
            List<string> result= CarData.GetMissingAttributes();
           
            this.dataGridView1.DataSource = result.Select(x => new { value = x }).ToList();
            

        }

        private void lblCarName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
