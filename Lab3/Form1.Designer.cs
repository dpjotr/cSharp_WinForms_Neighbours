namespace Lab3
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
            this.buttonPannel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.candidateButton = new System.Windows.Forms.Button();
            this.bluesButton = new System.Windows.Forms.Button();
            this.redsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPannel
            // 
            this.buttonPannel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPannel.Controls.Add(this.label1);
            this.buttonPannel.Controls.Add(this.button1);
            this.buttonPannel.Controls.Add(this.neighborsComboBox);
            this.buttonPannel.Controls.Add(this.calculateButton);
            this.buttonPannel.Controls.Add(this.clearButton);
            this.buttonPannel.Controls.Add(this.candidateButton);
            this.buttonPannel.Controls.Add(this.bluesButton);
            this.buttonPannel.Controls.Add(this.redsButton);
            this.buttonPannel.Location = new System.Drawing.Point(9, 9);
            this.buttonPannel.Name = "buttonPannel";
            this.buttonPannel.Size = new System.Drawing.Size(190, 396);
            this.buttonPannel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Items.AddRange(new object[] {
            "5",
            "9",
            "15"});
            this.neighborsComboBox.Location = new System.Drawing.Point(14, 187);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(159, 33);
            this.neighborsComboBox.TabIndex = 8;
            this.neighborsComboBox.Text = "5";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 281);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(159, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(14, 333);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(159, 35);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // candidateButton
            // 
            this.candidateButton.Location = new System.Drawing.Point(14, 114);
            this.candidateButton.Name = "candidateButton";
            this.candidateButton.Size = new System.Drawing.Size(159, 35);
            this.candidateButton.TabIndex = 2;
            this.candidateButton.Text = "Candidate";
            this.candidateButton.UseVisualStyleBackColor = true;
            this.candidateButton.Click += new System.EventHandler(this.candidateButton_Click);
            // 
            // bluesButton
            // 
            this.bluesButton.Location = new System.Drawing.Point(14, 73);
            this.bluesButton.Name = "bluesButton";
            this.bluesButton.Size = new System.Drawing.Size(159, 35);
            this.bluesButton.TabIndex = 1;
            this.bluesButton.Text = "Blues";
            this.bluesButton.UseVisualStyleBackColor = true;
            this.bluesButton.Click += new System.EventHandler(this.bluesButton_Click);
            // 
            // redsButton
            // 
            this.redsButton.Location = new System.Drawing.Point(14, 30);
            this.redsButton.Name = "redsButton";
            this.redsButton.Size = new System.Drawing.Size(159, 35);
            this.redsButton.TabIndex = 0;
            this.redsButton.Text = "Reds";
            this.redsButton.UseVisualStyleBackColor = true;
            this.redsButton.Click += new System.EventHandler(this.redsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Neibourghs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 411);
            this.Controls.Add(this.buttonPannel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximumSize = new System.Drawing.Size(1020, 760);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flying Points";
            this.buttonPannel.ResumeLayout(false);
            this.buttonPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPannel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button bluesButton;
        private System.Windows.Forms.Button redsButton;
        private System.Windows.Forms.Button candidateButton;
        private System.Windows.Forms.ComboBox neighborsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

