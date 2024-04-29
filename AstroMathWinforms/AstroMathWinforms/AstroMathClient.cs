using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace AstroMathWinforms
{
    public partial class AstroClient : Form
    {
        readonly Process process = new Process();

        public AstroClient()
        {
            process = Process.Start(@"ConsoleServer.exe");
            InitializeComponent();
        }

        #region Server Connection
        const string address = "net.pipe://localhost/netpipeAstro";
        static readonly NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
        static readonly EndpointAddress ep = new EndpointAddress(address);
        readonly IAstroContract astroContract =
        ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        #endregion

        #region Server processing

        private void AstroClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
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
        #endregion

        #region Font Styling
        private void FontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();

            Font = fontDialog.Font;
        }
        #endregion

        #region Language CultureInfo & Btns
        private void UpdateLanguage(string localisation)
        {
            CultureInfo newCulture = new CultureInfo(localisation);
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            Controls.Clear();
            InitializeComponent();
            Theme("light");
        }

        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem item in LanguageToolStripMenuItem.DropDownItems)
            {
                item.Checked = (item == clickedItem);
            }

            if (englishToolStripMenuItem.Checked)
            {
                UpdateLanguage("en-US");
            }
            else if (frenchToolStripMenuItem.Checked)
            {
                UpdateLanguage("fr-FR");
            }
            else if (germanToolStripMenuItem.Checked)
            {
                UpdateLanguage("de-DE");
            }
        }
        private void BtnUK_Click(object sender, EventArgs e)
        {
            UpdateLanguage("en-US");
        }
        private void BtnFrance_Click(object sender, EventArgs e)
        {
            UpdateLanguage("fr-FR");
        }

        private void BtnGerman_Click(object sender, EventArgs e)
        {
            UpdateLanguage("de-DE");
        }
        #endregion

        #region Theming Configuration & Btns
        private void Theme(string theme)
        {
            Color back = default;
            Color fore = default;
            Color lblFore = default;
            Color groupFore = default;
            Color textboxFore = default;
            Color textboxBack = default;
            Color btnFore = default;
            Color btnBack = default;
            Color listFore = default;
            Color listBack = default;

            switch (theme)
            {
                case "light":
                    fore = default;
                    back = default;
                    lblFore = default;
                    groupFore = default;
                    textboxFore = default;
                    textboxBack = default;
                    btnFore = default;
                    btnBack = default;
                    listFore = default;
                    listBack = default;

                    break;
                case "catppuccin":
                    fore = ColorTranslator.FromHtml("#b5bfe2");
                    back = ColorTranslator.FromHtml("#303446");
                    lblFore = ColorTranslator.FromHtml("#b5bfe2");
                    groupFore = ColorTranslator.FromHtml("#c6d0f5");
                    textboxFore = ColorTranslator.FromHtml("#c6d0f5");
                    textboxBack = ColorTranslator.FromHtml("#414559");
                    btnFore = ColorTranslator.FromHtml("#b5bfe2");
                    btnBack = ColorTranslator.FromHtml("#51576d");
                    listFore = ColorTranslator.FromHtml("#c6d0f5");
                    listBack = ColorTranslator.FromHtml("#232634");
                    break;

                case "dark":
                    fore = ColorTranslator.FromHtml("#F0ECE5");
                    back = ColorTranslator.FromHtml("#161A30");
                    lblFore = ColorTranslator.FromHtml("#F0ECE5");
                    groupFore = ColorTranslator.FromHtml("#F0ECE5");
                    textboxFore = ColorTranslator.FromHtml("#F0ECE5");
                    textboxBack = ColorTranslator.FromHtml("#31304D");
                    btnFore = ColorTranslator.FromHtml("#F0ECE5");
                    btnBack = ColorTranslator.FromHtml("#31304D");
                    listFore = ColorTranslator.FromHtml("#F0ECE5");
                    listBack = ColorTranslator.FromHtml("#161A30");
                    break;
            }
            BackColor = back;
            ForeColor = fore;
            listViewData.BackColor = listBack;
            listViewData.ForeColor = listFore;
            menuStrip.ForeColor = fore;
            menuStrip.BackColor = back;
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Label)
                {
                    control.ForeColor = lblFore;
                }
                if (control is System.Windows.Forms.GroupBox)
                {
                    control.ForeColor = groupFore;

                    foreach (Control groupBoxControl in control.Controls)
                    {
                        if (groupBoxControl is System.Windows.Forms.Button button1)
                        {
                            button1.BackColor = btnBack;
                            button1.ForeColor = btnFore;
                        }
                        if (groupBoxControl is System.Windows.Forms.TextBox box)
                        {
                            box.BackColor = textboxBack;
                            box.ForeColor = textboxFore;
                        }
                    }
                }
                if (control is System.Windows.Forms.Button button)
                {
                    button.BackColor = btnBack;
                    button.ForeColor = btnFore;
                }
            }

        }
        private void ThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem item in themeToolStripMenuItem.DropDownItems)
            {
                item.Checked = (item == clickedItem);
            }

            if (lightToolStripMenuItem.Checked)
            {
                Theme("light");
                lightToolStripMenuItem.Checked = false;
            }
            else if (darkToolStripMenuItem.Checked)
            {
                Theme("dark");
                darkToolStripMenuItem.Checked = false;
            }
            else if (catppuccinToolStripMenuItem.Checked)
            {
                Theme("catppuccin");
                catppuccinToolStripMenuItem.Checked = false;
            }
        }
        private void BtnLight_Click(object sender, EventArgs e)
        {
            Theme("light");
        }
        private void BtnDark_Click(object sender, EventArgs e)
        {
            Theme("dark");
        }
        private void BtnCatppuccin_Click(object sender, EventArgs e)
        {
            Theme("catppuccin");
        }
        private void BackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
                listViewData.BackColor = colorDialog.Color;
                Color oppositeColor = Color.FromArgb(colorDialog.Color.ToArgb() ^ 0xffffff);
                ForeColor = oppositeColor;
                listViewData.ForeColor = oppositeColor;
                menuStrip.BackColor = colorDialog.Color;
                menuStrip.ForeColor = oppositeColor;

                foreach (Control control in Controls)
                {
                    if (control is System.Windows.Forms.GroupBox)
                    {
                        control.ForeColor = oppositeColor;

                        foreach (Control groupBoxControl in control.Controls)
                        {
                            if (groupBoxControl is System.Windows.Forms.Button button1)
                            {
                                button1.BackColor = BackColor;
                                button1.ForeColor = oppositeColor;
                            }
                            if (groupBoxControl is System.Windows.Forms.TextBox box)
                            {
                                box.BackColor = BackColor;
                                box.ForeColor = oppositeColor;
                            }
                        }
                    }
                    if (control is System.Windows.Forms.Button button)
                    {
                        button.BackColor = BackColor;
                        button.ForeColor = ForeColor;
                    }
                }
            }
        }
        #endregion
    }
}