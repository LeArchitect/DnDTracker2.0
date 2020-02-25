namespace DnDTracker2._0
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.HourLabel = new System.Windows.Forms.Label();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondBox = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.TimeInfoLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(81, 172);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(25, 44);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(38, 13);
            this.HourLabel.TabIndex = 2;
            this.HourLabel.Text = "Hours:";
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(81, 41);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(75, 20);
            this.HourBox.TabIndex = 3;
            // 
            // MinuteBox
            // 
            this.MinuteBox.Location = new System.Drawing.Point(81, 67);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(75, 20);
            this.MinuteBox.TabIndex = 5;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(25, 70);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(47, 13);
            this.MinuteLabel.TabIndex = 4;
            this.MinuteLabel.Text = "Minutes:";
            // 
            // SecondBox
            // 
            this.SecondBox.Location = new System.Drawing.Point(81, 93);
            this.SecondBox.Name = "SecondBox";
            this.SecondBox.Size = new System.Drawing.Size(75, 20);
            this.SecondBox.TabIndex = 7;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(25, 96);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(52, 13);
            this.SecondLabel.TabIndex = 6;
            this.SecondLabel.Text = "Seconds:";
            // 
            // TimeInfoLabel
            // 
            this.TimeInfoLabel.AutoSize = true;
            this.TimeInfoLabel.Location = new System.Drawing.Point(93, 9);
            this.TimeInfoLabel.Name = "TimeInfoLabel";
            this.TimeInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.TimeInfoLabel.TabIndex = 8;
            this.TimeInfoLabel.Text = "Duration:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(81, 132);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(75, 20);
            this.ResultBox.TabIndex = 10;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(25, 135);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Result:";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(81, 201);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 236);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TimeInfoLabel);
            this.Controls.Add(this.SecondBox);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.CalculateButton);
            this.MaximumSize = new System.Drawing.Size(249, 275);
            this.MinimumSize = new System.Drawing.Size(249, 275);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label TimeInfoLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResetButton;
        public System.Windows.Forms.TextBox ResultBox;
        public System.Windows.Forms.TextBox HourBox;
        public System.Windows.Forms.TextBox MinuteBox;
        public System.Windows.Forms.TextBox SecondBox;
    }
}