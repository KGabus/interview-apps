namespace InterviewProject
{
    partial class Control_Validation_Form
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
            this.intTBox = new System.Windows.Forms.TextBox();
            this.stringTBox = new System.Windows.Forms.TextBox();
            this.dateTBox = new System.Windows.Forms.TextBox();
            this.intLabel = new System.Windows.Forms.Label();
            this.stringLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intTBox
            // 
            this.intTBox.Location = new System.Drawing.Point(821, 129);
            this.intTBox.Name = "intTBox";
            this.intTBox.Size = new System.Drawing.Size(100, 38);
            this.intTBox.TabIndex = 0;
            // 
            // stringTBox
            // 
            this.stringTBox.Location = new System.Drawing.Point(821, 296);
            this.stringTBox.Name = "stringTBox";
            this.stringTBox.Size = new System.Drawing.Size(100, 38);
            this.stringTBox.TabIndex = 1;
            // 
            // dateTBox
            // 
            this.dateTBox.Location = new System.Drawing.Point(821, 513);
            this.dateTBox.Name = "dateTBox";
            this.dateTBox.Size = new System.Drawing.Size(100, 38);
            this.dateTBox.TabIndex = 2;
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(121, 129);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(225, 32);
            this.intLabel.TabIndex = 3;
            this.intLabel.Text = "Enter an integer:";
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(127, 296);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(191, 32);
            this.stringLabel.TabIndex = 4;
            this.stringLabel.Text = "Enter a string:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(133, 513);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(177, 32);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Enter a date:";
            // 
            // Control_Validation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 867);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.dateTBox);
            this.Controls.Add(this.stringTBox);
            this.Controls.Add(this.intTBox);
            this.Name = "Control_Validation_Form";
            this.Text = "Control Validation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intTBox;
        private System.Windows.Forms.TextBox stringTBox;
        private System.Windows.Forms.TextBox dateTBox;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}