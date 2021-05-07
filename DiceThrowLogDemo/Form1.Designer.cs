
namespace DataVisualizationDotNetCore
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
            this.AddRolls = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExceptionButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RollTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRolls
            // 
            this.AddRolls.Location = new System.Drawing.Point(191, 108);
            this.AddRolls.Name = "AddRolls";
            this.AddRolls.Size = new System.Drawing.Size(152, 56);
            this.AddRolls.TabIndex = 2;
            this.AddRolls.Text = "Roll 100 Times";
            this.AddRolls.UseVisualStyleBackColor = true;
            this.AddRolls.Click += new System.EventHandler(this.AddRolls_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(796, 108);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(152, 56);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear Rolls";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExceptionButton
            // 
            this.ExceptionButton.Location = new System.Drawing.Point(466, 647);
            this.ExceptionButton.Name = "ExceptionButton";
            this.ExceptionButton.Size = new System.Drawing.Size(216, 46);
            this.ExceptionButton.TabIndex = 4;
            this.ExceptionButton.Text = "Generate Divide By Zero!";
            this.ExceptionButton.UseVisualStyleBackColor = true;
            this.ExceptionButton.Click += new System.EventHandler(this.ExceptionButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(335, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(502, 55);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Dice Throw Simulator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Die Rolls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dice Totals";
            // 
            // RollTotalLabel
            // 
            this.RollTotalLabel.AutoSize = true;
            this.RollTotalLabel.Location = new System.Drawing.Point(529, 211);
            this.RollTotalLabel.Name = "RollTotalLabel";
            this.RollTotalLabel.Size = new System.Drawing.Size(106, 25);
            this.RollTotalLabel.TabIndex = 8;
            this.RollTotalLabel.Text = "0 Total Rolls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 712);
            this.Controls.Add(this.RollTotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ExceptionButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddRolls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";

            // If you modify the form in the designer, you'll need to comment out these two statements
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DiceThrowChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DieRollChart;
        private System.Windows.Forms.Button AddRolls;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExceptionButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RollTotalLabel;
    }
}

