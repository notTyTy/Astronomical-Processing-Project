namespace AstroMathWinforms
{
    partial class AstroClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catppuccinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.groupExtras = new System.Windows.Forms.GroupBox();
            this.listViewData = new System.Windows.Forms.ListView();
            this.starVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupStarVelocity = new System.Windows.Forms.GroupBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.textBoxObserved = new System.Windows.Forms.TextBox();
            this.lvlRest = new System.Windows.Forms.Label();
            this.lblObserved = new System.Windows.Forms.Label();
            this.groupStarDistance = new System.Windows.Forms.GroupBox();
            this.textBoxParralax = new System.Windows.Forms.TextBox();
            this.lblParralax = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupTemperature = new System.Windows.Forms.GroupBox();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.groupEventHorizon = new System.Windows.Forms.GroupBox();
            this.textBoxExponent = new System.Windows.Forms.TextBox();
            this.lblMassExponent = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.lblMass = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupStarVelocity.SuspendLayout();
            this.groupStarDistance.SuspendLayout();
            this.groupTemperature.SuspendLayout();
            this.groupEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.fontStyleToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.spanishToolStripMenuItem.Text = "Spanish";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.frenchToolStripMenuItem.Text = "French";
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.fontStyleToolStripMenuItem.Text = "Font Style";
            this.fontStyleToolStripMenuItem.Click += new System.EventHandler(this.fontStyleToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.catppuccinToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // catppuccinToolStripMenuItem
            // 
            this.catppuccinToolStripMenuItem.Name = "catppuccinToolStripMenuItem";
            this.catppuccinToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.catppuccinToolStripMenuItem.Text = "Catppuccin";
            this.catppuccinToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // groupExtras
            // 
            this.groupExtras.Location = new System.Drawing.Point(443, 49);
            this.groupExtras.Name = "groupExtras";
            this.groupExtras.Size = new System.Drawing.Size(335, 227);
            this.groupExtras.TabIndex = 10;
            this.groupExtras.TabStop = false;
            this.groupExtras.Text = "Language and Theming";
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.starVelocity,
            this.starDistance,
            this.temperature,
            this.eventHorizon});
            this.listViewData.FullRowSelect = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(0, 301);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(800, 253);
            this.listViewData.TabIndex = 11;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // starVelocity
            // 
            this.starVelocity.Text = "Star Velocity (m/s)";
            this.starVelocity.Width = 170;
            // 
            // starDistance
            // 
            this.starDistance.Text = "Star Distance (pc)";
            this.starDistance.Width = 170;
            // 
            // temperature
            // 
            this.temperature.Text = "Temperature (°C)";
            this.temperature.Width = 170;
            // 
            // eventHorizon
            // 
            this.eventHorizon.Text = "Event Horizon (m)";
            this.eventHorizon.Width = 170;
            // 
            // groupStarVelocity
            // 
            this.groupStarVelocity.Controls.Add(this.textBoxRest);
            this.groupStarVelocity.Controls.Add(this.textBoxObserved);
            this.groupStarVelocity.Controls.Add(this.lvlRest);
            this.groupStarVelocity.Controls.Add(this.lblObserved);
            this.groupStarVelocity.Location = new System.Drawing.Point(12, 49);
            this.groupStarVelocity.Name = "groupStarVelocity";
            this.groupStarVelocity.Size = new System.Drawing.Size(200, 134);
            this.groupStarVelocity.TabIndex = 14;
            this.groupStarVelocity.TabStop = false;
            this.groupStarVelocity.Text = "Star Velocity (m/s)";
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(6, 92);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(170, 22);
            this.textBoxRest.TabIndex = 3;
            // 
            // textBoxObserved
            // 
            this.textBoxObserved.Location = new System.Drawing.Point(6, 42);
            this.textBoxObserved.Name = "textBoxObserved";
            this.textBoxObserved.Size = new System.Drawing.Size(170, 22);
            this.textBoxObserved.TabIndex = 2;
            // 
            // lvlRest
            // 
            this.lvlRest.AutoSize = true;
            this.lvlRest.Location = new System.Drawing.Point(6, 73);
            this.lvlRest.Name = "lvlRest";
            this.lvlRest.Size = new System.Drawing.Size(129, 16);
            this.lvlRest.TabIndex = 1;
            this.lvlRest.Text = "Rest Wavelength (λ)";
            // 
            // lblObserved
            // 
            this.lblObserved.AutoSize = true;
            this.lblObserved.Location = new System.Drawing.Point(6, 25);
            this.lblObserved.Name = "lblObserved";
            this.lblObserved.Size = new System.Drawing.Size(161, 16);
            this.lblObserved.TabIndex = 0;
            this.lblObserved.Text = "Observed Wavelength (λ)";
            // 
            // groupStarDistance
            // 
            this.groupStarDistance.Controls.Add(this.textBoxParralax);
            this.groupStarDistance.Controls.Add(this.lblParralax);
            this.groupStarDistance.Location = new System.Drawing.Point(12, 190);
            this.groupStarDistance.Name = "groupStarDistance";
            this.groupStarDistance.Size = new System.Drawing.Size(200, 86);
            this.groupStarDistance.TabIndex = 15;
            this.groupStarDistance.TabStop = false;
            this.groupStarDistance.Text = "Star Distance (pc)";
            // 
            // textBoxParralax
            // 
            this.textBoxParralax.Location = new System.Drawing.Point(9, 46);
            this.textBoxParralax.Name = "textBoxParralax";
            this.textBoxParralax.Size = new System.Drawing.Size(167, 22);
            this.textBoxParralax.TabIndex = 1;
            // 
            // lblParralax
            // 
            this.lblParralax.AutoSize = true;
            this.lblParralax.Location = new System.Drawing.Point(6, 27);
            this.lblParralax.Name = "lblParralax";
            this.lblParralax.Size = new System.Drawing.Size(178, 16);
            this.lblParralax.TabIndex = 0;
            this.lblParralax.Text = "Parralax Angle (Arcseconds)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(227, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupTemperature
            // 
            this.groupTemperature.Controls.Add(this.textBoxCelsius);
            this.groupTemperature.Controls.Add(this.lblCelsius);
            this.groupTemperature.Location = new System.Drawing.Point(227, 49);
            this.groupTemperature.Name = "groupTemperature";
            this.groupTemperature.Size = new System.Drawing.Size(200, 86);
            this.groupTemperature.TabIndex = 16;
            this.groupTemperature.TabStop = false;
            this.groupTemperature.Text = "Temperature (K)";
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(9, 46);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(167, 22);
            this.textBoxCelsius.TabIndex = 1;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(6, 27);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(75, 16);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius (°C)";
            // 
            // groupEventHorizon
            // 
            this.groupEventHorizon.Controls.Add(this.textBoxExponent);
            this.groupEventHorizon.Controls.Add(this.lblMassExponent);
            this.groupEventHorizon.Controls.Add(this.textBoxMass);
            this.groupEventHorizon.Controls.Add(this.lblMass);
            this.groupEventHorizon.Location = new System.Drawing.Point(227, 147);
            this.groupEventHorizon.Name = "groupEventHorizon";
            this.groupEventHorizon.Size = new System.Drawing.Size(200, 86);
            this.groupEventHorizon.TabIndex = 16;
            this.groupEventHorizon.TabStop = false;
            this.groupEventHorizon.Text = "Event Horizon (m)";
            // 
            // textBoxExponent
            // 
            this.textBoxExponent.Location = new System.Drawing.Point(138, 46);
            this.textBoxExponent.Name = "textBoxExponent";
            this.textBoxExponent.Size = new System.Drawing.Size(56, 22);
            this.textBoxExponent.TabIndex = 3;
            // 
            // lblMassExponent
            // 
            this.lblMassExponent.AutoSize = true;
            this.lblMassExponent.Location = new System.Drawing.Point(103, 49);
            this.lblMassExponent.Name = "lblMassExponent";
            this.lblMassExponent.Size = new System.Drawing.Size(34, 16);
            this.lblMassExponent.TabIndex = 2;
            this.lblMassExponent.Text = "x10^";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(9, 46);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(88, 22);
            this.textBoxMass.TabIndex = 1;
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(6, 27);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(66, 16);
            this.lblMass.TabIndex = 0;
            this.lblMass.Text = "Mass (kg)";
            // 
            // AstroClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupEventHorizon);
            this.Controls.Add(this.groupTemperature);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupStarDistance);
            this.Controls.Add(this.groupStarVelocity);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.groupExtras);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AstroClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astro Math Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AstroClient_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupStarVelocity.ResumeLayout(false);
            this.groupStarVelocity.PerformLayout();
            this.groupStarDistance.ResumeLayout(false);
            this.groupStarDistance.PerformLayout();
            this.groupTemperature.ResumeLayout(false);
            this.groupTemperature.PerformLayout();
            this.groupEventHorizon.ResumeLayout(false);
            this.groupEventHorizon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catppuccinToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.GroupBox groupExtras;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader starVelocity;
        private System.Windows.Forms.ColumnHeader starDistance;
        private System.Windows.Forms.ColumnHeader temperature;
        private System.Windows.Forms.ColumnHeader eventHorizon;
        private System.Windows.Forms.GroupBox groupStarVelocity;
        private System.Windows.Forms.GroupBox groupStarDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.TextBox textBoxObserved;
        private System.Windows.Forms.Label lvlRest;
        private System.Windows.Forms.Label lblObserved;
        private System.Windows.Forms.TextBox textBoxParralax;
        private System.Windows.Forms.Label lblParralax;
        private System.Windows.Forms.GroupBox groupTemperature;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.GroupBox groupEventHorizon;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox textBoxExponent;
        private System.Windows.Forms.Label lblMassExponent;
    }
}

