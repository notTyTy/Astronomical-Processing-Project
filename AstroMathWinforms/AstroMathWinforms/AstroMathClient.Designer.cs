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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroClient));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnCatppuccin = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.btnFrance = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnFontStyle = new System.Windows.Forms.Button();
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
            this.menuStrip.SuspendLayout();
            this.groupExtras.SuspendLayout();
            this.groupStarVelocity.SuspendLayout();
            this.groupStarDistance.SuspendLayout();
            this.groupTemperature.SuspendLayout();
            this.groupEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem,
            this.fontStyleToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // LanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.LanguageToolStripMenuItem, "LanguageToolStripMenuItem");
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            // 
            // germanToolStripMenuItem
            // 
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            // 
            // fontStyleToolStripMenuItem
            // 
            resources.ApplyResources(this.fontStyleToolStripMenuItem, "fontStyleToolStripMenuItem");
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Click += new System.EventHandler(this.fontStyleToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.catppuccinToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            // 
            // lightToolStripMenuItem
            // 
            resources.ApplyResources(this.lightToolStripMenuItem, "lightToolStripMenuItem");
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            resources.ApplyResources(this.darkToolStripMenuItem, "darkToolStripMenuItem");
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // catppuccinToolStripMenuItem
            // 
            resources.ApplyResources(this.catppuccinToolStripMenuItem, "catppuccinToolStripMenuItem");
            this.catppuccinToolStripMenuItem.Name = "catppuccinToolStripMenuItem";
            this.catppuccinToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            resources.ApplyResources(this.backgroundColorToolStripMenuItem, "backgroundColorToolStripMenuItem");
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // groupExtras
            // 
            resources.ApplyResources(this.groupExtras, "groupExtras");
            this.groupExtras.Controls.Add(this.btnCatppuccin);
            this.groupExtras.Controls.Add(this.btnDark);
            this.groupExtras.Controls.Add(this.btnLight);
            this.groupExtras.Controls.Add(this.btnGerman);
            this.groupExtras.Controls.Add(this.btnFrance);
            this.groupExtras.Controls.Add(this.btnUK);
            this.groupExtras.Controls.Add(this.btnBackgroundColor);
            this.groupExtras.Controls.Add(this.btnFontStyle);
            this.groupExtras.Name = "groupExtras";
            this.groupExtras.TabStop = false;
            // 
            // btnCatppuccin
            // 
            resources.ApplyResources(this.btnCatppuccin, "btnCatppuccin");
            this.btnCatppuccin.Name = "btnCatppuccin";
            this.btnCatppuccin.UseVisualStyleBackColor = true;
            this.btnCatppuccin.Click += new System.EventHandler(this.btnCatppuccin_Click);
            // 
            // btnDark
            // 
            resources.ApplyResources(this.btnDark, "btnDark");
            this.btnDark.Name = "btnDark";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            resources.ApplyResources(this.btnLight, "btnLight");
            this.btnLight.Name = "btnLight";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnGerman
            // 
            resources.ApplyResources(this.btnGerman, "btnGerman");
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // btnFrance
            // 
            resources.ApplyResources(this.btnFrance, "btnFrance");
            this.btnFrance.Name = "btnFrance";
            this.btnFrance.UseVisualStyleBackColor = true;
            this.btnFrance.Click += new System.EventHandler(this.btnFrance_Click);
            // 
            // btnUK
            // 
            resources.ApplyResources(this.btnUK, "btnUK");
            this.btnUK.Name = "btnUK";
            this.btnUK.UseVisualStyleBackColor = true;
            this.btnUK.Click += new System.EventHandler(this.btnUK_Click);
            // 
            // btnBackgroundColor
            // 
            resources.ApplyResources(this.btnBackgroundColor, "btnBackgroundColor");
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // btnFontStyle
            // 
            resources.ApplyResources(this.btnFontStyle, "btnFontStyle");
            this.btnFontStyle.Name = "btnFontStyle";
            this.btnFontStyle.UseVisualStyleBackColor = true;
            this.btnFontStyle.Click += new System.EventHandler(this.fontStyleToolStripMenuItem_Click);
            // 
            // listViewData
            // 
            resources.ApplyResources(this.listViewData, "listViewData");
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.starVelocity,
            this.starDistance,
            this.temperature,
            this.eventHorizon});
            this.listViewData.FullRowSelect = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Name = "listViewData";
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // starVelocity
            // 
            resources.ApplyResources(this.starVelocity, "starVelocity");
            // 
            // starDistance
            // 
            resources.ApplyResources(this.starDistance, "starDistance");
            // 
            // temperature
            // 
            resources.ApplyResources(this.temperature, "temperature");
            // 
            // eventHorizon
            // 
            resources.ApplyResources(this.eventHorizon, "eventHorizon");
            // 
            // groupStarVelocity
            // 
            resources.ApplyResources(this.groupStarVelocity, "groupStarVelocity");
            this.groupStarVelocity.Controls.Add(this.textBoxRest);
            this.groupStarVelocity.Controls.Add(this.textBoxObserved);
            this.groupStarVelocity.Controls.Add(this.lvlRest);
            this.groupStarVelocity.Controls.Add(this.lblObserved);
            this.groupStarVelocity.Name = "groupStarVelocity";
            this.groupStarVelocity.TabStop = false;
            // 
            // textBoxRest
            // 
            resources.ApplyResources(this.textBoxRest, "textBoxRest");
            this.textBoxRest.Name = "textBoxRest";
            // 
            // textBoxObserved
            // 
            resources.ApplyResources(this.textBoxObserved, "textBoxObserved");
            this.textBoxObserved.Name = "textBoxObserved";
            // 
            // lvlRest
            // 
            resources.ApplyResources(this.lvlRest, "lvlRest");
            this.lvlRest.Name = "lvlRest";
            // 
            // lblObserved
            // 
            resources.ApplyResources(this.lblObserved, "lblObserved");
            this.lblObserved.Name = "lblObserved";
            // 
            // groupStarDistance
            // 
            resources.ApplyResources(this.groupStarDistance, "groupStarDistance");
            this.groupStarDistance.Controls.Add(this.textBoxParralax);
            this.groupStarDistance.Controls.Add(this.lblParralax);
            this.groupStarDistance.Name = "groupStarDistance";
            this.groupStarDistance.TabStop = false;
            // 
            // textBoxParralax
            // 
            resources.ApplyResources(this.textBoxParralax, "textBoxParralax");
            this.textBoxParralax.Name = "textBoxParralax";
            // 
            // lblParralax
            // 
            resources.ApplyResources(this.lblParralax, "lblParralax");
            this.lblParralax.Name = "lblParralax";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupTemperature
            // 
            resources.ApplyResources(this.groupTemperature, "groupTemperature");
            this.groupTemperature.Controls.Add(this.textBoxCelsius);
            this.groupTemperature.Controls.Add(this.lblCelsius);
            this.groupTemperature.Name = "groupTemperature";
            this.groupTemperature.TabStop = false;
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            // 
            // lblCelsius
            // 
            resources.ApplyResources(this.lblCelsius, "lblCelsius");
            this.lblCelsius.Name = "lblCelsius";
            // 
            // groupEventHorizon
            // 
            resources.ApplyResources(this.groupEventHorizon, "groupEventHorizon");
            this.groupEventHorizon.Controls.Add(this.textBoxExponent);
            this.groupEventHorizon.Controls.Add(this.lblMassExponent);
            this.groupEventHorizon.Controls.Add(this.textBoxMass);
            this.groupEventHorizon.Controls.Add(this.lblMass);
            this.groupEventHorizon.Name = "groupEventHorizon";
            this.groupEventHorizon.TabStop = false;
            // 
            // textBoxExponent
            // 
            resources.ApplyResources(this.textBoxExponent, "textBoxExponent");
            this.textBoxExponent.Name = "textBoxExponent";
            // 
            // lblMassExponent
            // 
            resources.ApplyResources(this.lblMassExponent, "lblMassExponent");
            this.lblMassExponent.Name = "lblMassExponent";
            // 
            // textBoxMass
            // 
            resources.ApplyResources(this.textBoxMass, "textBoxMass");
            this.textBoxMass.Name = "textBoxMass";
            // 
            // lblMass
            // 
            resources.ApplyResources(this.lblMass, "lblMass");
            this.lblMass.Name = "lblMass";
            // 
            // AstroClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupEventHorizon);
            this.Controls.Add(this.groupTemperature);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupStarDistance);
            this.Controls.Add(this.groupStarVelocity);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.groupExtras);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "AstroClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AstroClient_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupExtras.ResumeLayout(false);
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

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
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
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnFontStyle;
        private System.Windows.Forms.Button btnUK;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Button btnFrance;
        private System.Windows.Forms.Button btnCatppuccin;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnLight;
    }
}

