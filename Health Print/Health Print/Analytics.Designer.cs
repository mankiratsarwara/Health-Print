
namespace Health_Print
{
    partial class analyticsForm
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.sleepLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.goalsButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.analyticsButton = new System.Windows.Forms.Button();
            this.caloriesTrackerButton = new System.Windows.Forms.Button();
            this.generalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.sleepGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exerciseGroupBox = new System.Windows.Forms.GroupBox();
            this.goalsGroupBox = new System.Windows.Forms.GroupBox();
            this.bmiGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.generalInfoGroupBox.SuspendLayout();
            this.sleepGroupBox.SuspendLayout();
            this.bmiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 70);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health Print - Analytics";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 44);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height:";
            // 
            // sleepLabel
            // 
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Location = new System.Drawing.Point(8, 45);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(122, 13);
            this.sleepLabel.TabIndex = 3;
            this.sleepLabel.Text = "Sleep(Weekly Average):";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(6, 22);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(6, 26);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(29, 13);
            this.bmiLabel.TabIndex = 5;
            this.bmiLabel.Text = "BMI:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(151, 77);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Welcome back !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.goalsButton);
            this.panel1.Controls.Add(this.exerciseButton);
            this.panel1.Controls.Add(this.analyticsButton);
            this.panel1.Controls.Add(this.caloriesTrackerButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 450);
            this.panel1.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitButton.Location = new System.Drawing.Point(12, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 32);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // goalsButton
            // 
            this.goalsButton.BackColor = System.Drawing.Color.SlateGray;
            this.goalsButton.Location = new System.Drawing.Point(12, 224);
            this.goalsButton.Name = "goalsButton";
            this.goalsButton.Size = new System.Drawing.Size(122, 30);
            this.goalsButton.TabIndex = 10;
            this.goalsButton.Text = "Goals";
            this.goalsButton.UseVisualStyleBackColor = false;
            // 
            // exerciseButton
            // 
            this.exerciseButton.BackColor = System.Drawing.Color.SlateGray;
            this.exerciseButton.Location = new System.Drawing.Point(12, 190);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(122, 30);
            this.exerciseButton.TabIndex = 9;
            this.exerciseButton.Text = "Exercise";
            this.exerciseButton.UseVisualStyleBackColor = false;
            // 
            // analyticsButton
            // 
            this.analyticsButton.BackColor = System.Drawing.Color.SlateGray;
            this.analyticsButton.Location = new System.Drawing.Point(12, 118);
            this.analyticsButton.Name = "analyticsButton";
            this.analyticsButton.Size = new System.Drawing.Size(122, 30);
            this.analyticsButton.TabIndex = 8;
            this.analyticsButton.Text = "Analytics";
            this.analyticsButton.UseVisualStyleBackColor = false;
            // 
            // caloriesTrackerButton
            // 
            this.caloriesTrackerButton.BackColor = System.Drawing.Color.SlateGray;
            this.caloriesTrackerButton.Location = new System.Drawing.Point(12, 154);
            this.caloriesTrackerButton.Name = "caloriesTrackerButton";
            this.caloriesTrackerButton.Size = new System.Drawing.Size(122, 30);
            this.caloriesTrackerButton.TabIndex = 7;
            this.caloriesTrackerButton.Text = "Calories";
            this.caloriesTrackerButton.UseVisualStyleBackColor = false;
            // 
            // generalInfoGroupBox
            // 
            this.generalInfoGroupBox.Controls.Add(this.ageLabel);
            this.generalInfoGroupBox.Controls.Add(this.heightLabel);
            this.generalInfoGroupBox.Controls.Add(this.weightLabel);
            this.generalInfoGroupBox.Location = new System.Drawing.Point(166, 48);
            this.generalInfoGroupBox.Name = "generalInfoGroupBox";
            this.generalInfoGroupBox.Size = new System.Drawing.Size(222, 90);
            this.generalInfoGroupBox.TabIndex = 8;
            this.generalInfoGroupBox.TabStop = false;
            this.generalInfoGroupBox.Text = "General Info";
            // 
            // sleepGroupBox
            // 
            this.sleepGroupBox.Controls.Add(this.label2);
            this.sleepGroupBox.Controls.Add(this.sleepLabel);
            this.sleepGroupBox.Location = new System.Drawing.Point(164, 145);
            this.sleepGroupBox.Name = "sleepGroupBox";
            this.sleepGroupBox.Size = new System.Drawing.Size(224, 100);
            this.sleepGroupBox.TabIndex = 9;
            this.sleepGroupBox.TabStop = false;
            this.sleepGroupBox.Text = "Sleep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sleep (Last 24H):";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(407, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calories";
            // 
            // exerciseGroupBox
            // 
            this.exerciseGroupBox.Location = new System.Drawing.Point(164, 251);
            this.exerciseGroupBox.Name = "exerciseGroupBox";
            this.exerciseGroupBox.Size = new System.Drawing.Size(224, 100);
            this.exerciseGroupBox.TabIndex = 11;
            this.exerciseGroupBox.TabStop = false;
            this.exerciseGroupBox.Text = "Exercises";
            // 
            // goalsGroupBox
            // 
            this.goalsGroupBox.Location = new System.Drawing.Point(407, 251);
            this.goalsGroupBox.Name = "goalsGroupBox";
            this.goalsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.goalsGroupBox.TabIndex = 12;
            this.goalsGroupBox.TabStop = false;
            this.goalsGroupBox.Text = "Goals";
            // 
            // bmiGroupBox
            // 
            this.bmiGroupBox.Controls.Add(this.bmiLabel);
            this.bmiGroupBox.Location = new System.Drawing.Point(407, 145);
            this.bmiGroupBox.Name = "bmiGroupBox";
            this.bmiGroupBox.Size = new System.Drawing.Size(200, 100);
            this.bmiGroupBox.TabIndex = 13;
            this.bmiGroupBox.TabStop = false;
            this.bmiGroupBox.Text = "BMI";
            // 
            // analyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bmiGroupBox);
            this.Controls.Add(this.goalsGroupBox);
            this.Controls.Add(this.exerciseGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sleepGroupBox);
            this.Controls.Add(this.generalInfoGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "analyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.panel1.ResumeLayout(false);
            this.generalInfoGroupBox.ResumeLayout(false);
            this.generalInfoGroupBox.PerformLayout();
            this.sleepGroupBox.ResumeLayout(false);
            this.sleepGroupBox.PerformLayout();
            this.bmiGroupBox.ResumeLayout(false);
            this.bmiGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label sleepLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goalsButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Button analyticsButton;
        private System.Windows.Forms.Button caloriesTrackerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox generalInfoGroupBox;
        private System.Windows.Forms.GroupBox sleepGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox exerciseGroupBox;
        private System.Windows.Forms.GroupBox goalsGroupBox;
        private System.Windows.Forms.GroupBox bmiGroupBox;
    }
}