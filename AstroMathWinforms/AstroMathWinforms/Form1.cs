using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
