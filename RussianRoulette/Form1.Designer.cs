namespace RussianRoulette
{
    partial class RussianRoulette
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
            this.Wins = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.BulletPosition_lbl = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.BulletsFired_Lbl = new System.Windows.Forms.Label();
            this.lblBulletsFired = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.ShootAway = new System.Windows.Forms.Label();
            this.Totals = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblKill = new System.Windows.Forms.Label();
            this.btnShootAway = new System.Windows.Forms.Button();
            this.PicBox_Gun = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wins.ForeColor = System.Drawing.Color.Red;
            this.Wins.Location = new System.Drawing.Point(747, 52);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(44, 20);
            this.Wins.TabIndex = 0;
            this.Wins.Text = "Wins";
            // 
            // Losses
            // 
            this.Losses.AutoSize = true;
            this.Losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Losses.ForeColor = System.Drawing.Color.Red;
            this.Losses.Location = new System.Drawing.Point(747, 99);
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(60, 20);
            this.Losses.TabIndex = 1;
            this.Losses.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Red;
            this.lblWins.Location = new System.Drawing.Point(917, 52);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(18, 20);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.Red;
            this.lblLosses.Location = new System.Drawing.Point(917, 99);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(18, 20);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "0";
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.OrangeRed;
            this.btnShoot.Enabled = false;
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShoot.Location = new System.Drawing.Point(501, 142);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(136, 44);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpin.Location = new System.Drawing.Point(502, 11);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(135, 46);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.Text = "Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // BulletPosition_lbl
            // 
            this.BulletPosition_lbl.AutoSize = true;
            this.BulletPosition_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletPosition_lbl.ForeColor = System.Drawing.Color.Red;
            this.BulletPosition_lbl.Location = new System.Drawing.Point(747, 264);
            this.BulletPosition_lbl.Name = "BulletPosition_lbl";
            this.BulletPosition_lbl.Size = new System.Drawing.Size(109, 20);
            this.BulletPosition_lbl.TabIndex = 7;
            this.BulletPosition_lbl.Text = "Bullet Position";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ForeColor = System.Drawing.Color.Red;
            this.lblRandom.Location = new System.Drawing.Point(917, 264);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 20);
            this.lblRandom.TabIndex = 8;
            // 
            // BulletsFired_Lbl
            // 
            this.BulletsFired_Lbl.AutoSize = true;
            this.BulletsFired_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletsFired_Lbl.ForeColor = System.Drawing.Color.Red;
            this.BulletsFired_Lbl.Location = new System.Drawing.Point(747, 212);
            this.BulletsFired_Lbl.Name = "BulletsFired_Lbl";
            this.BulletsFired_Lbl.Size = new System.Drawing.Size(97, 20);
            this.BulletsFired_Lbl.TabIndex = 9;
            this.BulletsFired_Lbl.Text = "Bullets Fired";
            // 
            // lblBulletsFired
            // 
            this.lblBulletsFired.AutoSize = true;
            this.lblBulletsFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletsFired.ForeColor = System.Drawing.Color.Red;
            this.lblBulletsFired.Location = new System.Drawing.Point(917, 212);
            this.lblBulletsFired.Name = "lblBulletsFired";
            this.lblBulletsFired.Size = new System.Drawing.Size(18, 20);
            this.lblBulletsFired.TabIndex = 10;
            this.lblBulletsFired.Text = "0";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.ForeColor = System.Drawing.Color.Red;
            this.lblAway.Location = new System.Drawing.Point(917, 154);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(18, 20);
            this.lblAway.TabIndex = 11;
            this.lblAway.Text = "0";
            // 
            // ShootAway
            // 
            this.ShootAway.AutoSize = true;
            this.ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.Color.Red;
            this.ShootAway.Location = new System.Drawing.Point(747, 154);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(94, 20);
            this.ShootAway.TabIndex = 12;
            this.ShootAway.Text = "Shoot Away";
            // 
            // Totals
            // 
            this.Totals.AutoSize = true;
            this.Totals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totals.ForeColor = System.Drawing.Color.Red;
            this.Totals.Location = new System.Drawing.Point(747, 11);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(44, 20);
            this.Totals.TabIndex = 14;
            this.Totals.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(916, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.lblKill);
            this.panel1.Controls.Add(this.btnShootAway);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.Totals);
            this.panel1.Controls.Add(this.PicBox_Gun);
            this.panel1.Controls.Add(this.ShootAway);
            this.panel1.Controls.Add(this.lblAway);
            this.panel1.Controls.Add(this.lblBulletsFired);
            this.panel1.Controls.Add(this.BulletsFired_Lbl);
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Controls.Add(this.BulletPosition_lbl);
            this.panel1.Controls.Add(this.btnSpin);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Controls.Add(this.lblLosses);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.Losses);
            this.panel1.Controls.Add(this.Wins);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 481);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(751, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 46);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(501, 73);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(135, 46);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load Chamber";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Location = new System.Drawing.Point(289, 191);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(10, 13);
            this.lblKill.TabIndex = 17;
            this.lblKill.Text = " ";
            this.lblKill.Visible = false;
            // 
            // btnShootAway
            // 
            this.btnShootAway.BackColor = System.Drawing.Color.OrangeRed;
            this.btnShootAway.Enabled = false;
            this.btnShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootAway.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShootAway.Location = new System.Drawing.Point(501, 199);
            this.btnShootAway.Name = "btnShootAway";
            this.btnShootAway.Size = new System.Drawing.Size(136, 46);
            this.btnShootAway.TabIndex = 16;
            this.btnShootAway.Text = "Shoot Away";
            this.btnShootAway.UseVisualStyleBackColor = false;
            this.btnShootAway.Click += new System.EventHandler(this.btnShootAway_Click);
            // 
            // PicBox_Gun
            // 
            this.PicBox_Gun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBox_Gun.ErrorImage = global::RussianRoulette.Properties.Resources.spinning;
            this.PicBox_Gun.Image = global::RussianRoulette.Properties.Resources.spinning;
            this.PicBox_Gun.InitialImage = global::RussianRoulette.Properties.Resources.spinning;
            this.PicBox_Gun.Location = new System.Drawing.Point(19, 11);
            this.PicBox_Gun.Name = "PicBox_Gun";
            this.PicBox_Gun.Size = new System.Drawing.Size(446, 293);
            this.PicBox_Gun.TabIndex = 13;
            this.PicBox_Gun.TabStop = false;
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(972, 505);
            this.Controls.Add(this.panel1);
            this.Name = "RussianRoulette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label Losses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button btnShoot;
        //private System.Windows.Forms.Button btnPointAway;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label BulletPosition_lbl;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label BulletsFired_Lbl;
        private System.Windows.Forms.Label lblBulletsFired;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label ShootAway;
        private System.Windows.Forms.PictureBox PicBox_Gun;
        private System.Windows.Forms.Label Totals;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShootAway;
        private System.Windows.Forms.Label lblKill;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}

