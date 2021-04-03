namespace final_project_iteration1
{
    partial class lotrTree
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.elrondButton = new System.Windows.Forms.RadioButton();
            this.aragornButton = new System.Windows.Forms.RadioButton();
            this.frodoButton = new System.Windows.Forms.RadioButton();
            this.gimliButton = new System.Windows.Forms.RadioButton();
            this.legolasButton = new System.Windows.Forms.RadioButton();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Whose family tree would you like to explore?";
            // 
            // elrondButton
            // 
            this.elrondButton.AutoSize = true;
            this.elrondButton.Location = new System.Drawing.Point(214, 108);
            this.elrondButton.Name = "elrondButton";
            this.elrondButton.Size = new System.Drawing.Size(105, 17);
            this.elrondButton.TabIndex = 1;
            this.elrondButton.TabStop = true;
            this.elrondButton.Text = "Elrond half-Elven";
            this.elrondButton.UseVisualStyleBackColor = true;
            // 
            // aragornButton
            // 
            this.aragornButton.AutoSize = true;
            this.aragornButton.Location = new System.Drawing.Point(325, 108);
            this.aragornButton.Name = "aragornButton";
            this.aragornButton.Size = new System.Drawing.Size(108, 17);
            this.aragornButton.TabIndex = 2;
            this.aragornButton.TabStop = true;
            this.aragornButton.Text = "Aragorn II Elessar";
            this.aragornButton.UseVisualStyleBackColor = true;
            // 
            // frodoButton
            // 
            this.frodoButton.AutoSize = true;
            this.frodoButton.Location = new System.Drawing.Point(437, 108);
            this.frodoButton.Name = "frodoButton";
            this.frodoButton.Size = new System.Drawing.Size(93, 17);
            this.frodoButton.TabIndex = 3;
            this.frodoButton.TabStop = true;
            this.frodoButton.Text = "Frodo Baggins";
            this.frodoButton.UseVisualStyleBackColor = true;
            // 
            // gimliButton
            // 
            this.gimliButton.AutoSize = true;
            this.gimliButton.Location = new System.Drawing.Point(259, 131);
            this.gimliButton.Name = "gimliButton";
            this.gimliButton.Size = new System.Drawing.Size(106, 17);
            this.gimliButton.TabIndex = 4;
            this.gimliButton.TabStop = true;
            this.gimliButton.Text = "Gimli son of Gloin";
            this.gimliButton.UseVisualStyleBackColor = true;
            // 
            // legolasButton
            // 
            this.legolasButton.AutoSize = true;
            this.legolasButton.Location = new System.Drawing.Point(371, 131);
            this.legolasButton.Name = "legolasButton";
            this.legolasButton.Size = new System.Drawing.Size(111, 17);
            this.legolasButton.TabIndex = 5;
            this.legolasButton.TabStop = true;
            this.legolasButton.Text = "Legolas Greenleaf";
            this.legolasButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(347, 203);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 6;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // lotrTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.legolasButton);
            this.Controls.Add(this.gimliButton);
            this.Controls.Add(this.frodoButton);
            this.Controls.Add(this.aragornButton);
            this.Controls.Add(this.elrondButton);
            this.Controls.Add(this.textBox1);
            this.Name = "lotrTree";
            this.Text = "Family Trees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton elrondButton;
        private System.Windows.Forms.RadioButton aragornButton;
        private System.Windows.Forms.RadioButton frodoButton;
        private System.Windows.Forms.RadioButton gimliButton;
        private System.Windows.Forms.RadioButton legolasButton;
        private System.Windows.Forms.Button viewButton;
    }
}