namespace InterviewProject
{
    partial class DateDiff
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.firstDateLabel = new System.Windows.Forms.Label();
            this.secondDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(464, 38);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 255);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(464, 38);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(280, 495);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(173, 90);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Difference";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // firstDateLabel
            // 
            this.firstDateLabel.AutoSize = true;
            this.firstDateLabel.Location = new System.Drawing.Point(13, 133);
            this.firstDateLabel.Name = "firstDateLabel";
            this.firstDateLabel.Size = new System.Drawing.Size(145, 32);
            this.firstDateLabel.TabIndex = 3;
            this.firstDateLabel.Text = "First Date:";
            // 
            // secondDateLabel
            // 
            this.secondDateLabel.AutoSize = true;
            this.secondDateLabel.Location = new System.Drawing.Point(13, 255);
            this.secondDateLabel.Name = "secondDateLabel";
            this.secondDateLabel.Size = new System.Drawing.Size(187, 32);
            this.secondDateLabel.TabIndex = 4;
            this.secondDateLabel.Text = "Second Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(637, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Two Dates To Find Their Difference In Days";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(329, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 358);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(292, 32);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Number of Days Apart";
            // 
            // DateDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 666);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondDateLabel);
            this.Controls.Add(this.firstDateLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateDiff";
            this.Text = "Date Difference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label firstDateLabel;
        private System.Windows.Forms.Label secondDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
    }
}