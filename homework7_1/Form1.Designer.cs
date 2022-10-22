namespace homework7_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUser.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUser.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUser.Location = new System.Drawing.Point(445, 242);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(128, 76);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "Your number";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(211, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelUser.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(211, 242);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(173, 31);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Введите число";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(128, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(189, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Угадайте число от 1 до 100!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUser);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(859, 593);
            this.MinimumSize = new System.Drawing.Size(859, 593);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonUser;
        private TextBox textBox1;
        private Label labelUser;
        private Label label1;
        private Label label2;
    }
}