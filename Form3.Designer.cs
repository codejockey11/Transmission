
namespace Transmission
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rearDiffText = new System.Windows.Forms.TextBox();
            this.fromSpeedText = new System.Windows.Forms.TextBox();
            this.toSpeedText = new System.Windows.Forms.TextBox();
            this.rpmText = new System.Windows.Forms.TextBox();
            this.gForceCheckbox = new System.Windows.Forms.CheckBox();
            this.tireDiameterText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rear Differntial Ratio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Use GForce Gears";
            // 
            // rearDiffText
            // 
            this.rearDiffText.Location = new System.Drawing.Point(124, 13);
            this.rearDiffText.Name = "rearDiffText";
            this.rearDiffText.Size = new System.Drawing.Size(100, 20);
            this.rearDiffText.TabIndex = 0;
            // 
            // fromSpeedText
            // 
            this.fromSpeedText.Location = new System.Drawing.Point(124, 40);
            this.fromSpeedText.Name = "fromSpeedText";
            this.fromSpeedText.Size = new System.Drawing.Size(100, 20);
            this.fromSpeedText.TabIndex = 1;
            // 
            // toSpeedText
            // 
            this.toSpeedText.Location = new System.Drawing.Point(124, 67);
            this.toSpeedText.Name = "toSpeedText";
            this.toSpeedText.Size = new System.Drawing.Size(100, 20);
            this.toSpeedText.TabIndex = 2;
            // 
            // rpmText
            // 
            this.rpmText.Location = new System.Drawing.Point(124, 94);
            this.rpmText.Name = "rpmText";
            this.rpmText.Size = new System.Drawing.Size(100, 20);
            this.rpmText.TabIndex = 3;
            // 
            // gForceCheckbox
            // 
            this.gForceCheckbox.AutoSize = true;
            this.gForceCheckbox.Location = new System.Drawing.Point(124, 156);
            this.gForceCheckbox.Name = "gForceCheckbox";
            this.gForceCheckbox.Size = new System.Drawing.Size(15, 14);
            this.gForceCheckbox.TabIndex = 5;
            this.gForceCheckbox.UseVisualStyleBackColor = true;
            // 
            // tireDiameterText
            // 
            this.tireDiameterText.Location = new System.Drawing.Point(124, 121);
            this.tireDiameterText.Name = "tireDiameterText";
            this.tireDiameterText.Size = new System.Drawing.Size(100, 20);
            this.tireDiameterText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tire Diameter";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 187);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tireDiameterText);
            this.Controls.Add(this.gForceCheckbox);
            this.Controls.Add(this.rpmText);
            this.Controls.Add(this.toSpeedText);
            this.Controls.Add(this.fromSpeedText);
            this.Controls.Add(this.rearDiffText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(256, 226);
            this.MinimumSize = new System.Drawing.Size(256, 226);
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rearDiffText;
        private System.Windows.Forms.TextBox fromSpeedText;
        private System.Windows.Forms.TextBox toSpeedText;
        private System.Windows.Forms.TextBox rpmText;
        private System.Windows.Forms.CheckBox gForceCheckbox;
        private System.Windows.Forms.TextBox tireDiameterText;
        private System.Windows.Forms.Label label6;
    }
}