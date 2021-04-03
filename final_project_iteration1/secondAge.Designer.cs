namespace final_project_iteration1
{
    partial class secondAge
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
            this.eventBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.secondAgeYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eventBox
            // 
            this.eventBox.Location = new System.Drawing.Point(271, 188);
            this.eventBox.Multiline = true;
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(222, 117);
            this.eventBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(377, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search Year";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // secondAgeYear
            // 
            this.secondAgeYear.Location = new System.Drawing.Point(309, 133);
            this.secondAgeYear.Name = "secondAgeYear";
            this.secondAgeYear.Size = new System.Drawing.Size(47, 20);
            this.secondAgeYear.TabIndex = 7;
            this.secondAgeYear.TextChanged += new System.EventHandler(this.secondAgeYear_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Please enter a date in the format: Year 1 - 3441";
            // 
            // secondAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.secondAgeYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "secondAge";
            this.Text = "secondAge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox secondAgeYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}