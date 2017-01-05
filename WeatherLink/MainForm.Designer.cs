namespace WeatherLink
{
    partial class frmMain
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cbTemperatureUnit = new System.Windows.Forms.ComboBox();
            this.lblTemperatureUnit = new System.Windows.Forms.Label();
            this.lblWindUnit = new System.Windows.Forms.Label();
            this.cbWindUnit = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(210, 28);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(63, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(13, 13);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Enter Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(16, 30);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(187, 20);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.Text = "Bournemouth";
            // 
            // cbTemperatureUnit
            // 
            this.cbTemperatureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemperatureUnit.FormattingEnabled = true;
            this.cbTemperatureUnit.Location = new System.Drawing.Point(16, 76);
            this.cbTemperatureUnit.Name = "cbTemperatureUnit";
            this.cbTemperatureUnit.Size = new System.Drawing.Size(121, 21);
            this.cbTemperatureUnit.TabIndex = 3;
            this.cbTemperatureUnit.SelectedIndexChanged += new System.EventHandler(this.cbTemperatureUnit_SelectedIndexChanged);
            // 
            // lblTemperatureUnit
            // 
            this.lblTemperatureUnit.AutoSize = true;
            this.lblTemperatureUnit.Location = new System.Drawing.Point(13, 60);
            this.lblTemperatureUnit.Name = "lblTemperatureUnit";
            this.lblTemperatureUnit.Size = new System.Drawing.Size(89, 13);
            this.lblTemperatureUnit.TabIndex = 4;
            this.lblTemperatureUnit.Text = "Temperature Unit";
            // 
            // lblWindUnit
            // 
            this.lblWindUnit.AutoSize = true;
            this.lblWindUnit.Location = new System.Drawing.Point(149, 60);
            this.lblWindUnit.Name = "lblWindUnit";
            this.lblWindUnit.Size = new System.Drawing.Size(54, 13);
            this.lblWindUnit.TabIndex = 5;
            this.lblWindUnit.Text = "Wind Unit";
            // 
            // cbWindUnit
            // 
            this.cbWindUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWindUnit.FormattingEnabled = true;
            this.cbWindUnit.Location = new System.Drawing.Point(152, 76);
            this.cbWindUnit.Name = "cbWindUnit";
            this.cbWindUnit.Size = new System.Drawing.Size(121, 21);
            this.cbWindUnit.TabIndex = 6;
            this.cbWindUnit.SelectedIndexChanged += new System.EventHandler(this.cbWindUnit_SelectedIndexChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 127);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(257, 131);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.WordWrap = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 111);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 414);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cbWindUnit);
            this.Controls.Add(this.lblWindUnit);
            this.Controls.Add(this.lblTemperatureUnit);
            this.Controls.Add(this.cbTemperatureUnit);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnGetData);
            this.Name = "frmMain";
            this.Text = "Weather Link";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cbTemperatureUnit;
        private System.Windows.Forms.Label lblTemperatureUnit;
        private System.Windows.Forms.Label lblWindUnit;
        private System.Windows.Forms.ComboBox cbWindUnit;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

