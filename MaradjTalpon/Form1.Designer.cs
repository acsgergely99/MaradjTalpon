namespace MaradjTalpon
{
    partial class MaradjTalponAlkalmazas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaradjTalponAlkalmazas));
            this.JatekKezdesGomb = new System.Windows.Forms.Button();
            this.KilepesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JatekKezdesGomb
            // 
            this.JatekKezdesGomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.JatekKezdesGomb.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JatekKezdesGomb.Location = new System.Drawing.Point(200, 424);
            this.JatekKezdesGomb.Name = "JatekKezdesGomb";
            this.JatekKezdesGomb.Size = new System.Drawing.Size(242, 120);
            this.JatekKezdesGomb.TabIndex = 0;
            this.JatekKezdesGomb.Text = "A Játék Indítása";
            this.JatekKezdesGomb.UseVisualStyleBackColor = false;
            this.JatekKezdesGomb.Click += new System.EventHandler(this.JatekKezdesGomb_Click);
            // 
            // KilepesButton
            // 
            this.KilepesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KilepesButton.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilepesButton.Location = new System.Drawing.Point(574, 723);
            this.KilepesButton.Name = "KilepesButton";
            this.KilepesButton.Size = new System.Drawing.Size(228, 76);
            this.KilepesButton.TabIndex = 1;
            this.KilepesButton.Text = "Kilépés";
            this.KilepesButton.UseVisualStyleBackColor = false;
            this.KilepesButton.Click += new System.EventHandler(this.KilepesButton_Click);
            // 
            // MaradjTalponAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 811);
            this.Controls.Add(this.KilepesButton);
            this.Controls.Add(this.JatekKezdesGomb);
            this.Name = "MaradjTalponAlkalmazas";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JatekKezdesGomb;
        private System.Windows.Forms.Button KilepesButton;
    }
}

