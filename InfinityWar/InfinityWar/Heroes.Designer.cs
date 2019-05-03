namespace InfinityWar
{
    partial class Heroes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Heroes));
            this.choose = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.heroHealth = new System.Windows.Forms.Label();
            this.heroAttack = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.heroName = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.blackPanther = new System.Windows.Forms.Button();
            this.ironMan = new System.Windows.Forms.Button();
            this.thor = new System.Windows.Forms.Button();
            this.captainMarvel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.captainAmerica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choose.Location = new System.Drawing.Point(706, 411);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 25;
            this.choose.Text = "CHOOSE";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.button6_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Aqua;
            this.description.Location = new System.Drawing.Point(277, 308);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(268, 91);
            this.description.TabIndex = 24;
            this.description.Text = "label13";
            // 
            // heroHealth
            // 
            this.heroHealth.AutoSize = true;
            this.heroHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroHealth.ForeColor = System.Drawing.Color.Green;
            this.heroHealth.Location = new System.Drawing.Point(319, 237);
            this.heroHealth.Name = "heroHealth";
            this.heroHealth.Size = new System.Drawing.Size(70, 24);
            this.heroHealth.TabIndex = 23;
            this.heroHealth.Text = "label12";
            // 
            // heroAttack
            // 
            this.heroAttack.AutoSize = true;
            this.heroAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroAttack.ForeColor = System.Drawing.Color.Red;
            this.heroAttack.Location = new System.Drawing.Point(319, 200);
            this.heroAttack.Name = "heroAttack";
            this.heroAttack.Size = new System.Drawing.Size(70, 24);
            this.heroAttack.TabIndex = 22;
            this.heroAttack.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DESCRIPTION:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "HEALTH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ATTACK:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "STATS:";
            // 
            // heroName
            // 
            this.heroName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroName.Location = new System.Drawing.Point(561, 352);
            this.heroName.Name = "heroName";
            this.heroName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heroName.Size = new System.Drawing.Size(173, 19);
            this.heroName.TabIndex = 17;
            this.heroName.Text = "label6";
            this.heroName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(625, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button8_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.White;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(607, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 20);
            this.min.TabIndex = 3;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(360, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "VILLAINS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(561, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 236);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "CHOOSE YOUR HERO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(319, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "VS";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "captain america.jpg");
            this.imageList1.Images.SetKeyName(1, "captain marvel.jpg");
            this.imageList1.Images.SetKeyName(2, "thor.jpg");
            this.imageList1.Images.SetKeyName(3, "iron man.jpg");
            this.imageList1.Images.SetKeyName(4, "black panther.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 60);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HEROES";
            // 
            // blackPanther
            // 
            this.blackPanther.BackColor = System.Drawing.Color.Teal;
            this.blackPanther.Dock = System.Windows.Forms.DockStyle.Top;
            this.blackPanther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackPanther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackPanther.ForeColor = System.Drawing.Color.White;
            this.blackPanther.Location = new System.Drawing.Point(0, 300);
            this.blackPanther.Name = "blackPanther";
            this.blackPanther.Size = new System.Drawing.Size(154, 60);
            this.blackPanther.TabIndex = 11;
            this.blackPanther.Text = "Black Panther";
            this.blackPanther.UseVisualStyleBackColor = false;
            this.blackPanther.Click += new System.EventHandler(this.button5_Click);
            // 
            // ironMan
            // 
            this.ironMan.BackColor = System.Drawing.Color.Teal;
            this.ironMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ironMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ironMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ironMan.ForeColor = System.Drawing.Color.White;
            this.ironMan.Location = new System.Drawing.Point(0, 240);
            this.ironMan.Name = "ironMan";
            this.ironMan.Size = new System.Drawing.Size(154, 60);
            this.ironMan.TabIndex = 10;
            this.ironMan.Text = "Iron-Man";
            this.ironMan.UseVisualStyleBackColor = false;
            this.ironMan.Click += new System.EventHandler(this.button4_Click);
            // 
            // thor
            // 
            this.thor.BackColor = System.Drawing.Color.Teal;
            this.thor.Dock = System.Windows.Forms.DockStyle.Top;
            this.thor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thor.ForeColor = System.Drawing.Color.White;
            this.thor.Location = new System.Drawing.Point(0, 180);
            this.thor.Name = "thor";
            this.thor.Size = new System.Drawing.Size(154, 60);
            this.thor.TabIndex = 9;
            this.thor.Text = "Thor";
            this.thor.UseVisualStyleBackColor = false;
            this.thor.Click += new System.EventHandler(this.button3_Click);
            // 
            // captainMarvel
            // 
            this.captainMarvel.BackColor = System.Drawing.Color.Teal;
            this.captainMarvel.Dock = System.Windows.Forms.DockStyle.Top;
            this.captainMarvel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captainMarvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captainMarvel.ForeColor = System.Drawing.Color.White;
            this.captainMarvel.Location = new System.Drawing.Point(0, 120);
            this.captainMarvel.Name = "captainMarvel";
            this.captainMarvel.Size = new System.Drawing.Size(154, 60);
            this.captainMarvel.TabIndex = 8;
            this.captainMarvel.Text = "Captain Marvel";
            this.captainMarvel.UseVisualStyleBackColor = false;
            this.captainMarvel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(41, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "HEROES";
            // 
            // captainAmerica
            // 
            this.captainAmerica.BackColor = System.Drawing.Color.Teal;
            this.captainAmerica.Dock = System.Windows.Forms.DockStyle.Top;
            this.captainAmerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captainAmerica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captainAmerica.ForeColor = System.Drawing.Color.White;
            this.captainAmerica.Location = new System.Drawing.Point(0, 60);
            this.captainAmerica.Name = "captainAmerica";
            this.captainAmerica.Size = new System.Drawing.Size(154, 60);
            this.captainAmerica.TabIndex = 3;
            this.captainAmerica.Text = "Captain America";
            this.captainAmerica.UseVisualStyleBackColor = false;
            this.captainAmerica.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.blackPanther);
            this.panel1.Controls.Add(this.ironMan);
            this.panel1.Controls.Add(this.thor);
            this.panel1.Controls.Add(this.captainMarvel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.captainAmerica);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 457);
            this.panel1.TabIndex = 13;
            // 
            // Heroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.description);
            this.Controls.Add(this.heroHealth);
            this.Controls.Add(this.heroAttack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heroName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Heroes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heroes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label heroHealth;
        private System.Windows.Forms.Label heroAttack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blackPanther;
        private System.Windows.Forms.Button ironMan;
        private System.Windows.Forms.Button thor;
        private System.Windows.Forms.Button captainMarvel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button captainAmerica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}