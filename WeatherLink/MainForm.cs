using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherLink
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            AggregateCurrentConditions = new WeatherDataItemCollection();
        }

        public WeatherDataItemCollection AggregateCurrentConditions { get; set; }

        private void AddCurrentConditions(Type weatherAPIType)
        {
            // Create object from type, cast to base
            WeatherLinkBase link = (WeatherLinkBase)Activator.CreateInstance(weatherAPIType);

            WeatherLocation location = link.FindLocation(txtLocation.Text);
            if (location == null)
            {
                return;
            }

            WeatherDataItem currentConditions = link.GetCurrentConditions(location);

            AggregateCurrentConditions.Add(currentConditions);
        }

        private void ClearOutput()
        {
            txtOutput.Text = String.Empty;
        }

        private void DisplayOutput()
        {
            if( AggregateCurrentConditions.Count == 0 )
            {
                ClearOutput();
                return;
            }

            txtOutput.Text = String.Format(
                "Average Temperature: {0:0.00} {1}" + Environment.NewLine +
                "Average Wind Speed: {2:0.00} {3}",
                AggregateCurrentConditions.MeanTemperature(cbTemperatureUnit.Text), cbTemperatureUnit.Text,
                AggregateCurrentConditions.MeanWindSpeed(cbWindUnit.Text), cbWindUnit.Text);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            ClearOutput();
            AggregateCurrentConditions.Clear();

            AddCurrentConditions(typeof(WeatherLinkAccu));
            AddCurrentConditions(typeof(WeatherLinkBBC));

            DisplayOutput();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            cbTemperatureUnit.Items.Add(UnitTypes.TEMPERATURE_CELSIUS);
            cbTemperatureUnit.Items.Add(UnitTypes.TEMPERATURE_FAHRENHEIT);
            cbWindUnit.Items.Add(UnitTypes.SPEED_KPH);
            cbWindUnit.Items.Add(UnitTypes.SPEED_MPH);

            cbTemperatureUnit.SelectedIndex = 0;
            cbWindUnit.SelectedIndex = 1;
        }

        private void cbWindUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOutput();
        }

        private void cbTemperatureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOutput();
        }
    }
}
