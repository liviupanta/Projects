namespace InfinityWar
{
    partial class Winner
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
            this.close = new System.Windows.Forms.Button();
            this.conclusion = new System.Windows.Forms.Label();
            this.tryAgain = new System.Windows.Forms.Button();
            this.planet = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(216, 448);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 12;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // conclusion
            // 
            this.conclusion.BackColor = System.Drawing.Color.Transparent;
            this.conclusion.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclusion.ForeColor = System.Drawing.Color.Black;
            this.conclusion.Location = new System.Drawing.Point(40, 16);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(251, 40);
            this.conclusion.TabIndex = 11;
            this.conclusion.Text = "label3";
            this.conclusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tryAgain
            // 
            this.tryAgain.Location = new System.Drawing.Point(40, 448);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(75, 23);
            this.tryAgain.TabIndex = 10;
            this.tryAgain.Text = "TRY AGAIN";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // planet
            // 
            this.planet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planet.Location = new System.Drawing.Point(37, 373);
            this.planet.Name = "planet";
            this.planet.Size = new System.Drawing.Size(255, 23);
            this.planet.TabIndex = 9;
            this.planet.Text = "label2";
            this.planet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.Location = new System.Drawing.Point(40, 334);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(251, 23);
            this.name.TabIndex = 8;
            this.name.Text = "label1";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 486);
            this.Controls.Add(this.close);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.planet);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label conclusion;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Label planet;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}