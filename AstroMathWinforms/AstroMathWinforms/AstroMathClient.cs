using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
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

        const string address = "net.pipe://localhost/netpipeAstro";
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
                lightToolStripMenuItem.Checked = true;

                // default theming
            }
            else if (darkToolStripMenuItem.Checked)
            {
                darkToolStripMenuItem.Checked = true;
            }
            else if (catppuccinToolStripMenuItem.Checked)
            {
                catppuccinToolStripMenuItem.Checked = true;
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
            // A try catch for parsing textbox values
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
            // A try catch for Server Connectivity
            try
            {
                string starVelocity = astroContract.StarVelocity(observed, rest).ToString("E");
                string starDistance = astroContract.StarDistance(parralax).ToString();
                string temperature = astroContract.TemperatureK(celsius).ToString();
                string eventHorizon = astroContract.EventHorizon(mass).ToString("E");

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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }



        private void updateLanguage(string localisation)
        {
            CultureInfo newCulture = new CultureInfo(localisation);
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            Controls.Clear();
            InitializeComponent();
        }
        private void btnUK_Click(object sender, EventArgs e)
        {
            updateLanguage("en-US");
        }
        private void btnFrance_Click(object sender, EventArgs e)
        {
            updateLanguage("fr-FR");
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            updateLanguage("de-DE");
        }
    }
}