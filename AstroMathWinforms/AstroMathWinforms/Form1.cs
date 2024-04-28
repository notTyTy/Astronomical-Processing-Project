using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AstroMathWinforms
{
    public partial class AstroClient : Form
    {
        Process process = new Process();

        public AstroClient()
        {
            process = Process.Start(@"ConsoleServer.exe");
            InitializeComponent();
            lightToolStripMenuItem.Checked = true;




        }

        static string address = "net.pipe://localhost/netpipeAstro";
        static NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
        static EndpointAddress ep = new EndpointAddress(address);
        IAstroContract astroContract =
        ChannelFactory<IAstroContract>.CreateChannel(binding, ep);


        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();

            Font = fontDialog.Font;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            BackColor = colorDialog.Color;
        }

        private void ThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // todo add theming options to the form

            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem item in themeToolStripMenuItem.DropDownItems)
            {
                item.Checked = (item == clickedItem);
            }


            if (lightToolStripMenuItem.Checked)
            {
                BackColor = default;


                // default theming
            }
            else if (darkToolStripMenuItem.Checked)
            {

            }
            else if (catppuccinToolStripMenuItem.Checked)
            {

            }

        }
        private void AstroClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double observed;
            double rest;
            double parralax;
            double celsius;
            double mass;

            try
            {
                observed = double.Parse(textBoxObserved.Text);
                rest = double.Parse(textBoxRest.Text);
                parralax = double.Parse(textBoxParralax.Text);
                celsius = double.Parse(textBoxCelsius.Text);
                mass = double.Parse(textBoxMass.Text) * Math.Pow(10, double.Parse(textBoxExponent.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string starVelocity = astroContract.StarVelocity(observed, rest).ToString();
            string starDistance = astroContract.StarDistance(parralax).ToString();
            string temperature = astroContract.TemperatureK(celsius).ToString();
            string eventHorizon = astroContract.EventHorizon(mass).ToString();

            ListViewItem listViewItem = new ListViewItem(starVelocity);
            listViewItem.SubItems.Add(starDistance);
            listViewItem.SubItems.Add(temperature);
            listViewItem.SubItems.Add(eventHorizon);

            listViewData.Items.Add(listViewItem);

            List<System.Windows.Forms.TextBox> textBoxList = new List<System.Windows.Forms.TextBox>
            {
                textBoxObserved,
                textBoxRest,
                textBoxParralax,
                textBoxCelsius,
                textBoxMass,
                textBoxExponent
            };

            foreach (var textbox in textBoxList)
            {
                textbox.Clear();
            }
        }
    }
}