namespace task6
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
            this.dllButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.methodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dllButton
            // 
            this.dllButton.Location = new System.Drawing.Point(8, 8);
            this.dllButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dllButton.Name = "dllButton";
            this.dllButton.Size = new System.Drawing.Size(474, 30);
            this.dllButton.TabIndex = 36;
            this.dllButton.Text = "Open dll";
            this.dllButton.UseVisualStyleBackColor = true;
            this.dllButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.Visible = false;
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(123, 48);
            this.classButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(81, 25);
            this.classButton.TabIndex = 38;
            this.classButton.Text = "Find class";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Visible = false;
            this.classButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 81);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 21);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.Visible = false;
            // 
            // methodButton
            // 
            this.methodButton.Location = new System.Drawing.Point(283, 77);
            this.methodButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.methodButton.Name = "methodButton";
            this.methodButton.Size = new System.Drawing.Size(81, 26);
            this.methodButton.TabIndex = 40;
            this.methodButton.Text = "Find method";
            this.methodButton.UseVisualStyleBackColor = true;
            this.methodButton.Visible = false;
            this.methodButton.Click += new System.EventHandler(this.methodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 385);
            this.Controls.Add(this.methodButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dllButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dllButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button methodButton;
    }
}