namespace MaradjTalpon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.JatekKezdesGomb = new System.Windows.Forms.Button();
            this.JatekosnevLabel = new System.Windows.Forms.Label();
            this.JatekosNevTextBox = new System.Windows.Forms.TextBox();
            this.KezdesVisszaButton = new System.Windows.Forms.Button();
            this.JatekosLakhelyLabel = new System.Windows.Forms.Label();
            this.JatekosLakhelyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // JatekKezdesGomb
            // 
            this.JatekKezdesGomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.JatekKezdesGomb.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JatekKezdesGomb.ForeColor = System.Drawing.Color.White;
            this.JatekKezdesGomb.Location = new System.Drawing.Point(305, 316);
            this.JatekKezdesGomb.Name = "JatekKezdesGomb";
            this.JatekKezdesGomb.Size = new System.Drawing.Size(213, 77);
            this.JatekKezdesGomb.TabIndex = 0;
            this.JatekKezdesGomb.Text = "Kezdés";
            this.JatekKezdesGomb.UseVisualStyleBackColor = false;
            this.JatekKezdesGomb.Click += new System.EventHandler(this.JatekKezdesGomb_Click);
            // 
            // JatekosnevLabel
            // 
            this.JatekosnevLabel.AutoSize = true;
            this.JatekosnevLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.JatekosnevLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosnevLabel.ForeColor = System.Drawing.Color.White;
            this.JatekosnevLabel.Location = new System.Drawing.Point(12, 151);
            this.JatekosnevLabel.Name = "JatekosnevLabel";
            this.JatekosnevLabel.Size = new System.Drawing.Size(229, 32);
            this.JatekosnevLabel.TabIndex = 1;
            this.JatekosnevLabel.Text = "Add meg a neved:";
            // 
            // JatekosNevTextBox
            // 
            this.JatekosNevTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosNevTextBox.Location = new System.Drawing.Point(305, 150);
            this.JatekosNevTextBox.Multiline = true;
            this.JatekosNevTextBox.Name = "JatekosNevTextBox";
            this.JatekosNevTextBox.Size = new System.Drawing.Size(213, 32);
            this.JatekosNevTextBox.TabIndex = 2;
            // 
            // KezdesVisszaButton
            // 
            this.KezdesVisszaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KezdesVisszaButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KezdesVisszaButton.ForeColor = System.Drawing.Color.White;
            this.KezdesVisszaButton.Location = new System.Drawing.Point(649, 386);
            this.KezdesVisszaButton.Name = "KezdesVisszaButton";
            this.KezdesVisszaButton.Size = new System.Drawing.Size(139, 52);
            this.KezdesVisszaButton.TabIndex = 3;
            this.KezdesVisszaButton.Text = "Vissza";
            this.KezdesVisszaButton.UseVisualStyleBackColor = false;
            this.KezdesVisszaButton.Click += new System.EventHandler(this.KezdesVisszaButton_Click);
            // 
            // JatekosLakhelyLabel
            // 
            this.JatekosLakhelyLabel.AutoSize = true;
            this.JatekosLakhelyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.JatekosLakhelyLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosLakhelyLabel.ForeColor = System.Drawing.Color.White;
            this.JatekosLakhelyLabel.Location = new System.Drawing.Point(12, 199);
            this.JatekosLakhelyLabel.Name = "JatekosLakhelyLabel";
            this.JatekosLakhelyLabel.Size = new System.Drawing.Size(274, 32);
            this.JatekosLakhelyLabel.TabIndex = 4;
            this.JatekosLakhelyLabel.Text = "Add meg a lakhelyed:";
            // 
            // JatekosLakhelyTextBox
            // 
            this.JatekosLakhelyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosLakhelyTextBox.Location = new System.Drawing.Point(305, 199);
            this.JatekosLakhelyTextBox.Multiline = true;
            this.JatekosLakhelyTextBox.Name = "JatekosLakhelyTextBox";
            this.JatekosLakhelyTextBox.Size = new System.Drawing.Size(213, 32);
            this.JatekosLakhelyTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JatekosLakhelyTextBox);
            this.Controls.Add(this.JatekosLakhelyLabel);
            this.Controls.Add(this.KezdesVisszaButton);
            this.Controls.Add(this.JatekosNevTextBox);
            this.Controls.Add(this.JatekosnevLabel);
            this.Controls.Add(this.JatekKezdesGomb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JatekKezdesGomb;
        private System.Windows.Forms.Label JatekosnevLabel;
        private System.Windows.Forms.TextBox JatekosNevTextBox;
        private System.Windows.Forms.Button KezdesVisszaButton;
        private System.Windows.Forms.Label JatekosLakhelyLabel;
        private System.Windows.Forms.TextBox JatekosLakhelyTextBox;
    }
}