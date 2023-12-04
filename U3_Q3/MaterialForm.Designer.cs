namespace U3_Q3
{
    partial class MaterialForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disasterGroupBox = new System.Windows.Forms.GroupBox();
            this.fundingRadioButton = new System.Windows.Forms.RadioButton();
            this.explodeRadioButton = new System.Windows.Forms.RadioButton();
            this.tornadoRadioButton = new System.Windows.Forms.RadioButton();
            this.specialItemGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.saveInventionButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.materialsGroupBox = new System.Windows.Forms.GroupBox();
            this.explosionLabel = new System.Windows.Forms.Label();
            this.disasterGroupBox.SuspendLayout();
            this.specialItemGroupBox.SuspendLayout();
            this.materialsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gather Materials Within the Time Limit!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 426);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(552, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // disasterGroupBox
            // 
            this.disasterGroupBox.Controls.Add(this.tornadoRadioButton);
            this.disasterGroupBox.Controls.Add(this.explodeRadioButton);
            this.disasterGroupBox.Controls.Add(this.fundingRadioButton);
            this.disasterGroupBox.Location = new System.Drawing.Point(389, 236);
            this.disasterGroupBox.Name = "disasterGroupBox";
            this.disasterGroupBox.Size = new System.Drawing.Size(128, 123);
            this.disasterGroupBox.TabIndex = 4;
            this.disasterGroupBox.TabStop = false;
            this.disasterGroupBox.Text = "Most Ideal Disaster";
            // 
            // fundingRadioButton
            // 
            this.fundingRadioButton.AutoSize = true;
            this.fundingRadioButton.ForeColor = System.Drawing.Color.Red;
            this.fundingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.fundingRadioButton.Name = "fundingRadioButton";
            this.fundingRadioButton.Size = new System.Drawing.Size(107, 30);
            this.fundingRadioButton.TabIndex = 0;
            this.fundingRadioButton.TabStop = true;
            this.fundingRadioButton.Text = "Head Scientist\r\n Cuts My Funding";
            this.fundingRadioButton.UseVisualStyleBackColor = true;
            // 
            // explodeRadioButton
            // 
            this.explodeRadioButton.AutoSize = true;
            this.explodeRadioButton.ForeColor = System.Drawing.Color.Red;
            this.explodeRadioButton.Location = new System.Drawing.Point(6, 55);
            this.explodeRadioButton.Name = "explodeRadioButton";
            this.explodeRadioButton.Size = new System.Drawing.Size(115, 17);
            this.explodeRadioButton.TabIndex = 1;
            this.explodeRadioButton.TabStop = true;
            this.explodeRadioButton.Text = "Invention Explodes";
            this.explodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // tornadoRadioButton
            // 
            this.tornadoRadioButton.AutoSize = true;
            this.tornadoRadioButton.ForeColor = System.Drawing.Color.Red;
            this.tornadoRadioButton.Location = new System.Drawing.Point(6, 78);
            this.tornadoRadioButton.Name = "tornadoRadioButton";
            this.tornadoRadioButton.Size = new System.Drawing.Size(115, 30);
            this.tornadoRadioButton.TabIndex = 2;
            this.tornadoRadioButton.TabStop = true;
            this.tornadoRadioButton.Text = "Tornado Sends My\r\nInvention to Oz";
            this.tornadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // specialItemGroupBox
            // 
            this.specialItemGroupBox.Controls.Add(this.radioButton6);
            this.specialItemGroupBox.Controls.Add(this.radioButton5);
            this.specialItemGroupBox.Controls.Add(this.radioButton4);
            this.specialItemGroupBox.Location = new System.Drawing.Point(121, 236);
            this.specialItemGroupBox.Name = "specialItemGroupBox";
            this.specialItemGroupBox.Size = new System.Drawing.Size(168, 141);
            this.specialItemGroupBox.TabIndex = 5;
            this.specialItemGroupBox.TabStop = false;
            this.specialItemGroupBox.Text = "Choose ONE Special Item!";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Teal;
            this.radioButton4.Location = new System.Drawing.Point(7, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Magic Screwdriver";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton5.Location = new System.Drawing.Point(7, 68);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(96, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Magic Hammer";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton6.Location = new System.Drawing.Point(7, 105);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Magic Welder";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // saveInventionButton
            // 
            this.saveInventionButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInventionButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.saveInventionButton.Location = new System.Drawing.Point(239, 104);
            this.saveInventionButton.Name = "saveInventionButton";
            this.saveInventionButton.Size = new System.Drawing.Size(207, 41);
            this.saveInventionButton.TabIndex = 6;
            this.saveInventionButton.Text = "SAVE YOUR INVENTION!";
            this.saveInventionButton.UseVisualStyleBackColor = true;
            this.saveInventionButton.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(43, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Screws";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox2.Location = new System.Drawing.Point(6, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Glass";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox3.Location = new System.Drawing.Point(43, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Nails";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox4.Location = new System.Drawing.Point(14, 94);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Steel";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox5.Location = new System.Drawing.Point(12, 117);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(55, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Wood";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // materialsGroupBox
            // 
            this.materialsGroupBox.Controls.Add(this.checkBox5);
            this.materialsGroupBox.Controls.Add(this.checkBox4);
            this.materialsGroupBox.Controls.Add(this.checkBox3);
            this.materialsGroupBox.Controls.Add(this.checkBox2);
            this.materialsGroupBox.Controls.Add(this.checkBox1);
            this.materialsGroupBox.Location = new System.Drawing.Point(23, 79);
            this.materialsGroupBox.Name = "materialsGroupBox";
            this.materialsGroupBox.Size = new System.Drawing.Size(121, 140);
            this.materialsGroupBox.TabIndex = 12;
            this.materialsGroupBox.TabStop = false;
            this.materialsGroupBox.Text = "Choose Your Materials!";
            // 
            // explosionLabel
            // 
            this.explosionLabel.AutoSize = true;
            this.explosionLabel.BackColor = System.Drawing.Color.Transparent;
            this.explosionLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explosionLabel.ForeColor = System.Drawing.Color.Yellow;
            this.explosionLabel.Location = new System.Drawing.Point(175, 161);
            this.explosionLabel.Name = "explosionLabel";
            this.explosionLabel.Size = new System.Drawing.Size(365, 52);
            this.explosionLabel.TabIndex = 13;
            this.explosionLabel.Text = "YOUR INVENTION \r\nEXPLOSION IS ABOUT TO EXPLODE!";
            this.explosionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.explosionLabel.Visible = false;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.explosionLabel);
            this.Controls.Add(this.materialsGroupBox);
            this.Controls.Add(this.saveInventionButton);
            this.Controls.Add(this.specialItemGroupBox);
            this.Controls.Add(this.disasterGroupBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.disasterGroupBox.ResumeLayout(false);
            this.disasterGroupBox.PerformLayout();
            this.specialItemGroupBox.ResumeLayout(false);
            this.specialItemGroupBox.PerformLayout();
            this.materialsGroupBox.ResumeLayout(false);
            this.materialsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox disasterGroupBox;
        private System.Windows.Forms.RadioButton tornadoRadioButton;
        private System.Windows.Forms.RadioButton explodeRadioButton;
        private System.Windows.Forms.RadioButton fundingRadioButton;
        private System.Windows.Forms.GroupBox specialItemGroupBox;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button saveInventionButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox materialsGroupBox;
        private System.Windows.Forms.Label explosionLabel;
    }
}