
namespace Transmission
{
    partial class Form1
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
            this.textBoxDifferential = new System.Windows.Forms.TextBox();
            this.textBoxFromSpeed = new System.Windows.Forms.TextBox();
            this.textBoxToSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFromRPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxToRPM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFromRatio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxToRatio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTireDiameter = new System.Windows.Forms.TextBox();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.textBoxRatio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxRPM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDifferential
            // 
            this.textBoxDifferential.Location = new System.Drawing.Point(73, 38);
            this.textBoxDifferential.Name = "textBoxDifferential";
            this.textBoxDifferential.Size = new System.Drawing.Size(100, 20);
            this.textBoxDifferential.TabIndex = 0;
            this.textBoxDifferential.Text = "3.20";
            // 
            // textBoxFromSpeed
            // 
            this.textBoxFromSpeed.Location = new System.Drawing.Point(249, 38);
            this.textBoxFromSpeed.Name = "textBoxFromSpeed";
            this.textBoxFromSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxFromSpeed.TabIndex = 1;
            this.textBoxFromSpeed.Text = "130";
            // 
            // textBoxToSpeed
            // 
            this.textBoxToSpeed.Location = new System.Drawing.Point(426, 38);
            this.textBoxToSpeed.Name = "textBoxToSpeed";
            this.textBoxToSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxToSpeed.TabIndex = 2;
            this.textBoxToSpeed.Text = "150";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Differential";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To Speed";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(358, 97);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "From RPM";
            // 
            // textBoxFromRPM
            // 
            this.textBoxFromRPM.Location = new System.Drawing.Point(73, 67);
            this.textBoxFromRPM.Name = "textBoxFromRPM";
            this.textBoxFromRPM.Size = new System.Drawing.Size(100, 20);
            this.textBoxFromRPM.TabIndex = 3;
            this.textBoxFromRPM.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "To RPM";
            // 
            // textBoxToRPM
            // 
            this.textBoxToRPM.Location = new System.Drawing.Point(249, 67);
            this.textBoxToRPM.Name = "textBoxToRPM";
            this.textBoxToRPM.Size = new System.Drawing.Size(100, 20);
            this.textBoxToRPM.TabIndex = 4;
            this.textBoxToRPM.Text = "7000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "From Ratio";
            // 
            // textBoxFromRatio
            // 
            this.textBoxFromRatio.Location = new System.Drawing.Point(73, 97);
            this.textBoxFromRatio.Name = "textBoxFromRatio";
            this.textBoxFromRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFromRatio.TabIndex = 6;
            this.textBoxFromRatio.Text = "0.776";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "To Ratio";
            // 
            // textBoxToRatio
            // 
            this.textBoxToRatio.Location = new System.Drawing.Point(249, 97);
            this.textBoxToRatio.Name = "textBoxToRatio";
            this.textBoxToRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxToRatio.TabIndex = 7;
            this.textBoxToRatio.Text = "3.400";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tire Diameter";
            // 
            // textBoxTireDiameter
            // 
            this.textBoxTireDiameter.Location = new System.Drawing.Point(426, 67);
            this.textBoxTireDiameter.Name = "textBoxTireDiameter";
            this.textBoxTireDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTireDiameter.TabIndex = 5;
            this.textBoxTireDiameter.Text = "28.7";
            // 
            // buttonSingle
            // 
            this.buttonSingle.Location = new System.Drawing.Point(451, 97);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(75, 23);
            this.buttonSingle.TabIndex = 14;
            this.buttonSingle.Text = "Single";
            this.buttonSingle.UseVisualStyleBackColor = true;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // textBoxRatio
            // 
            this.textBoxRatio.Location = new System.Drawing.Point(72, 129);
            this.textBoxRatio.Name = "textBoxRatio";
            this.textBoxRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRatio.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ratio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(249, 128);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 10;
            // 
            // textBoxRPM
            // 
            this.textBoxRPM.Location = new System.Drawing.Point(426, 128);
            this.textBoxRPM.Name = "textBoxRPM";
            this.textBoxRPM.ReadOnly = true;
            this.textBoxRPM.Size = new System.Drawing.Size(100, 20);
            this.textBoxRPM.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "RPM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 161);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRPM);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRatio);
            this.Controls.Add(this.buttonSingle);
            this.Controls.Add(this.textBoxTireDiameter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxToRatio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFromRatio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxToRPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFromRPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxToSpeed);
            this.Controls.Add(this.textBoxFromSpeed);
            this.Controls.Add(this.textBoxDifferential);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(556, 200);
            this.MinimumSize = new System.Drawing.Size(556, 200);
            this.Name = "Form1";
            this.Text = "Gear Ratio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDifferential;
        private System.Windows.Forms.TextBox textBoxFromSpeed;
        private System.Windows.Forms.TextBox textBoxToSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFromRPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxToRPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFromRatio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxToRatio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTireDiameter;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.TextBox textBoxRatio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxRPM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

