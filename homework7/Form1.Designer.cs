namespace homework7
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonPLus = new System.Windows.Forms.Button();
            this.labelRandom = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonNewGame.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewGame.Location = new System.Drawing.Point(564, 125);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(149, 85);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.BackColor = System.Drawing.Color.MistyRose;
            this.buttonMulti.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMulti.Location = new System.Drawing.Point(564, 324);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(149, 47);
            this.buttonMulti.TabIndex = 1;
            this.buttonMulti.Text = "x2";
            this.buttonMulti.UseVisualStyleBackColor = false;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonPLus
            // 
            this.buttonPLus.BackColor = System.Drawing.Color.MistyRose;
            this.buttonPLus.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPLus.Location = new System.Drawing.Point(564, 376);
            this.buttonPLus.Name = "buttonPLus";
            this.buttonPLus.Size = new System.Drawing.Size(149, 47);
            this.buttonPLus.TabIndex = 2;
            this.buttonPLus.Text = "+1";
            this.buttonPLus.UseVisualStyleBackColor = false;
            this.buttonPLus.Click += new System.EventHandler(this.buttonPLus_Click);
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.BackColor = System.Drawing.Color.MistyRose;
            this.labelRandom.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelRandom.Location = new System.Drawing.Point(64, 183);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(217, 29);
            this.labelRandom.TabIndex = 3;
            this.labelRandom.Text = "Получите число: ";
            this.labelRandom.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.MistyRose;
            this.labelUser.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(64, 274);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(161, 29);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Ваше число: ";
            this.labelUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.MistyRose;
            this.labelCount.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelCount.Location = new System.Drawing.Point(64, 394);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(192, 29);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Ходов сделано: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 462);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.buttonPLus);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonNewGame);
            this.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 501);
            this.MinimumSize = new System.Drawing.Size(754, 501);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNewGame;
        private Button buttonMulti;
        private Button buttonPLus;
        private Label labelRandom;
        private Label labelUser;
        private Label labelCount;
    }
}