namespace DnDTracker2._0
{
    partial class Form2
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
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.NextLabel = new System.Windows.Forms.Label();
            this.PreviousLabel = new System.Windows.Forms.Label();
            this.PreviousName = new System.Windows.Forms.Label();
            this.NextName = new System.Windows.Forms.Label();
            this.CurrentName = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimeInfoLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SpellList = new System.Windows.Forms.ListBox();
            this.TimerList = new System.Windows.Forms.ListBox();
            this.SpellBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.SpeelNameLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.Location = new System.Drawing.Point(158, 82);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(93, 17);
            this.CurrentLabel.TabIndex = 20;
            this.CurrentLabel.Text = "Current Turn:";
            // 
            // NextLabel
            // 
            this.NextLabel.AutoSize = true;
            this.NextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLabel.Location = new System.Drawing.Point(302, 86);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(54, 13);
            this.NextLabel.TabIndex = 20;
            this.NextLabel.Text = "Next Turn:";
            // 
            // PreviousLabel
            // 
            this.PreviousLabel.AutoSize = true;
            this.PreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousLabel.Location = new System.Drawing.Point(28, 86);
            this.PreviousLabel.Name = "PreviousLabel";
            this.PreviousLabel.Size = new System.Drawing.Size(74, 13);
            this.PreviousLabel.TabIndex = 20;
            this.PreviousLabel.Text = "Previous Turn:";
            // 
            // PreviousName
            // 
            this.PreviousName.AutoSize = true;
            this.PreviousName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousName.Location = new System.Drawing.Point(27, 99);
            this.PreviousName.Name = "PreviousName";
            this.PreviousName.Size = new System.Drawing.Size(51, 20);
            this.PreviousName.TabIndex = 20;
            this.PreviousName.Text = "Name";
            // 
            // NextName
            // 
            this.NextName.AutoSize = true;
            this.NextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextName.Location = new System.Drawing.Point(301, 99);
            this.NextName.Name = "NextName";
            this.NextName.Size = new System.Drawing.Size(51, 20);
            this.NextName.TabIndex = 20;
            this.NextName.Text = "Name";
            // 
            // CurrentName
            // 
            this.CurrentName.AutoSize = true;
            this.CurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentName.Location = new System.Drawing.Point(156, 99);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.Size = new System.Drawing.Size(68, 25);
            this.CurrentName.TabIndex = 20;
            this.CurrentName.Text = "Name";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(222, 386);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(107, 386);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 5;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(180, 36);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(24, 25);
            this.TimerLabel.TabIndex = 20;
            this.TimerLabel.Text = "0";
            // 
            // TimeInfoLabel
            // 
            this.TimeInfoLabel.AutoSize = true;
            this.TimeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInfoLabel.Location = new System.Drawing.Point(173, 19);
            this.TimeInfoLabel.Name = "TimeInfoLabel";
            this.TimeInfoLabel.Size = new System.Drawing.Size(43, 17);
            this.TimeInfoLabel.TabIndex = 20;
            this.TimeInfoLabel.Text = "Time:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(78, 342);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add Spell";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(247, 342);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove Spell";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SpellList
            // 
            this.SpellList.FormattingEnabled = true;
            this.SpellList.Location = new System.Drawing.Point(107, 146);
            this.SpellList.Name = "SpellList";
            this.SpellList.Size = new System.Drawing.Size(132, 134);
            this.SpellList.TabIndex = 12;
            // 
            // TimerList
            // 
            this.TimerList.FormattingEnabled = true;
            this.TimerList.Location = new System.Drawing.Point(254, 146);
            this.TimerList.Name = "TimerList";
            this.TimerList.Size = new System.Drawing.Size(43, 134);
            this.TimerList.TabIndex = 13;
            // 
            // SpellBox
            // 
            this.SpellBox.Location = new System.Drawing.Point(107, 304);
            this.SpellBox.Name = "SpellBox";
            this.SpellBox.Size = new System.Drawing.Size(132, 20);
            this.SpellBox.TabIndex = 1;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(254, 304);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(43, 20);
            this.DurationBox.TabIndex = 2;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(251, 288);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(47, 13);
            this.DurationLabel.TabIndex = 17;
            this.DurationLabel.Text = "Duration";
            // 
            // SpeelNameLabel
            // 
            this.SpeelNameLabel.AutoSize = true;
            this.SpeelNameLabel.Location = new System.Drawing.Point(104, 288);
            this.SpeelNameLabel.Name = "SpeelNameLabel";
            this.SpeelNameLabel.Size = new System.Drawing.Size(61, 13);
            this.SpeelNameLabel.TabIndex = 16;
            this.SpeelNameLabel.Text = "Spell Name";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(104, 327);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 21;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Location = new System.Drawing.Point(107, 431);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatorButton.TabIndex = 22;
            this.CalculatorButton.Text = "Calculator";
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(222, 431);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 23;
            this.InputButton.Text = "Place";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 480);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.CalculatorButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.SpeelNameLabel);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.SpellBox);
            this.Controls.Add(this.TimerList);
            this.Controls.Add(this.SpellList);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.TimeInfoLabel);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousName);
            this.Controls.Add(this.NextName);
            this.Controls.Add(this.CurrentName);
            this.Controls.Add(this.PreviousLabel);
            this.Controls.Add(this.NextLabel);
            this.Controls.Add(this.CurrentLabel);
            this.MaximumSize = new System.Drawing.Size(407, 519);
            this.MinimumSize = new System.Drawing.Size(407, 519);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.Label NextLabel;
        private System.Windows.Forms.Label PreviousLabel;
        public System.Windows.Forms.Label PreviousName;
        public System.Windows.Forms.Label NextName;
        public System.Windows.Forms.Label CurrentName;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        public System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label TimeInfoLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.ListBox SpellList;
        public System.Windows.Forms.ListBox TimerList;
        private System.Windows.Forms.TextBox SpellBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label SpeelNameLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Button InputButton;
    }
}