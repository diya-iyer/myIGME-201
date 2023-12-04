namespace U3_Q3
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
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.scientistNameLabel = new System.Windows.Forms.Label();
            this.scientistNameTextBox = new System.Windows.Forms.TextBox();
            this.inventionNameTextBox = new System.Windows.Forms.TextBox();
            this.inventionNameLabel = new System.Windows.Forms.Label();
            this.submitNamebutton = new System.Windows.Forms.Button();
            this.toLabButton = new System.Windows.Forms.Button();
            this.nameChangeLabel = new System.Windows.Forms.Label();
            this.scientistNameChangedLabel = new System.Windows.Forms.Label();
            this.inventionNameChangedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.mainTitleLabel.Location = new System.Drawing.Point(56, 28);
            this.mainTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(436, 30);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Welcome to the Invention Lab!";
            // 
            // scientistNameLabel
            // 
            this.scientistNameLabel.AutoSize = true;
            this.scientistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scientistNameLabel.ForeColor = System.Drawing.Color.Red;
            this.scientistNameLabel.Location = new System.Drawing.Point(58, 91);
            this.scientistNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scientistNameLabel.Name = "scientistNameLabel";
            this.scientistNameLabel.Size = new System.Drawing.Size(96, 13);
            this.scientistNameLabel.TabIndex = 1;
            this.scientistNameLabel.Text = "Scientist Name:";
            // 
            // scientistNameTextBox
            // 
            this.scientistNameTextBox.Font = new System.Drawing.Font("Adobe Devanagari", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scientistNameTextBox.Location = new System.Drawing.Point(160, 88);
            this.scientistNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scientistNameTextBox.Name = "scientistNameTextBox";
            this.scientistNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.scientistNameTextBox.TabIndex = 2;
            // 
            // inventionNameTextBox
            // 
            this.inventionNameTextBox.Font = new System.Drawing.Font("Adobe Devanagari", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventionNameTextBox.Location = new System.Drawing.Point(160, 118);
            this.inventionNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inventionNameTextBox.Name = "inventionNameTextBox";
            this.inventionNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.inventionNameTextBox.TabIndex = 4;
            // 
            // inventionNameLabel
            // 
            this.inventionNameLabel.AutoSize = true;
            this.inventionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventionNameLabel.ForeColor = System.Drawing.Color.Red;
            this.inventionNameLabel.Location = new System.Drawing.Point(58, 121);
            this.inventionNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventionNameLabel.Name = "inventionNameLabel";
            this.inventionNameLabel.Size = new System.Drawing.Size(100, 13);
            this.inventionNameLabel.TabIndex = 3;
            this.inventionNameLabel.Text = "Invention Name:";
            // 
            // submitNamebutton
            // 
            this.submitNamebutton.Location = new System.Drawing.Point(217, 156);
            this.submitNamebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.submitNamebutton.Name = "submitNamebutton";
            this.submitNamebutton.Size = new System.Drawing.Size(88, 23);
            this.submitNamebutton.TabIndex = 5;
            this.submitNamebutton.Text = "Submit";
            this.submitNamebutton.UseVisualStyleBackColor = true;
            // 
            // toLabButton
            // 
            this.toLabButton.Location = new System.Drawing.Point(177, 386);
            this.toLabButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toLabButton.Name = "toLabButton";
            this.toLabButton.Size = new System.Drawing.Size(163, 36);
            this.toLabButton.TabIndex = 6;
            this.toLabButton.Text = "Go To Lab!";
            this.toLabButton.UseVisualStyleBackColor = true;
            this.toLabButton.Visible = false;
            // 
            // nameChangeLabel
            // 
            this.nameChangeLabel.AutoSize = true;
            this.nameChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChangeLabel.ForeColor = System.Drawing.Color.Red;
            this.nameChangeLabel.Location = new System.Drawing.Point(127, 203);
            this.nameChangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameChangeLabel.Name = "nameChangeLabel";
            this.nameChangeLabel.Size = new System.Drawing.Size(290, 39);
            this.nameChangeLabel.TabIndex = 7;
            this.nameChangeLabel.Text = "Whoops! Looks like the head scientist took over! \r\nHere\'s the new approved names." +
    "..\r\nTry again to see if you can get one you like!";
            this.nameChangeLabel.Visible = false;
            // 
            // scientistNameChangedLabel
            // 
            this.scientistNameChangedLabel.AutoSize = true;
            this.scientistNameChangedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scientistNameChangedLabel.ForeColor = System.Drawing.Color.Red;
            this.scientistNameChangedLabel.Location = new System.Drawing.Point(132, 270);
            this.scientistNameChangedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scientistNameChangedLabel.Name = "scientistNameChangedLabel";
            this.scientistNameChangedLabel.Size = new System.Drawing.Size(96, 13);
            this.scientistNameChangedLabel.TabIndex = 8;
            this.scientistNameChangedLabel.Text = "Scientist Name:";
            this.scientistNameChangedLabel.Visible = false;
            // 
            // inventionNameChangedLabel
            // 
            this.inventionNameChangedLabel.AutoSize = true;
            this.inventionNameChangedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventionNameChangedLabel.ForeColor = System.Drawing.Color.Red;
            this.inventionNameChangedLabel.Location = new System.Drawing.Point(132, 305);
            this.inventionNameChangedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventionNameChangedLabel.Name = "inventionNameChangedLabel";
            this.inventionNameChangedLabel.Size = new System.Drawing.Size(104, 13);
            this.inventionNameChangedLabel.TabIndex = 9;
            this.inventionNameChangedLabel.Text = "Invention Name: ";
            this.inventionNameChangedLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.inventionNameChangedLabel);
            this.Controls.Add(this.scientistNameChangedLabel);
            this.Controls.Add(this.nameChangeLabel);
            this.Controls.Add(this.toLabButton);
            this.Controls.Add(this.submitNamebutton);
            this.Controls.Add(this.inventionNameTextBox);
            this.Controls.Add(this.inventionNameLabel);
            this.Controls.Add(this.scientistNameTextBox);
            this.Controls.Add(this.scientistNameLabel);
            this.Controls.Add(this.mainTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Invention Lab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label scientistNameLabel;
        private System.Windows.Forms.TextBox scientistNameTextBox;
        private System.Windows.Forms.TextBox inventionNameTextBox;
        private System.Windows.Forms.Label inventionNameLabel;
        private System.Windows.Forms.Button submitNamebutton;
        private System.Windows.Forms.Button toLabButton;
        private System.Windows.Forms.Label nameChangeLabel;
        private System.Windows.Forms.Label scientistNameChangedLabel;
        private System.Windows.Forms.Label inventionNameChangedLabel;
    }
}

