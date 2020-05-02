using f1Teleform.Component;

namespace f1Teleform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbSteer = new System.Windows.Forms.ProgressBar();
            this.tbSteer = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pbBrake = new f1Teleform.Component.VerticalProgressBar();
            this.pbThrottle = new f1Teleform.Component.VerticalProgressBar();
            this.lbDRS = new System.Windows.Forms.Label();
            this.lbGear = new System.Windows.Forms.Label();
            this.pbRevLightPerc = new System.Windows.Forms.ProgressBar();
            this.pbClutch = new System.Windows.Forms.ProgressBar();
            this.vpbGaz = new f1Teleform.Component.VerticalProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLFTyreInTemp = new System.Windows.Forms.Label();
            this.lbLFTyreSurfaceTemp = new System.Windows.Forms.Label();
            this.lbLFBrakeTemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLFTyrePressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStartTelemetry_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStopTelemetry_Click);
            // 
            // pbSteer
            // 
            this.pbSteer.Location = new System.Drawing.Point(93, 339);
            this.pbSteer.Name = "pbSteer";
            this.pbSteer.Size = new System.Drawing.Size(100, 23);
            this.pbSteer.TabIndex = 4;
            this.pbSteer.Value = 50;
            // 
            // tbSteer
            // 
            this.tbSteer.Location = new System.Drawing.Point(89, 87);
            this.tbSteer.Maximum = 200;
            this.tbSteer.Name = "tbSteer";
            this.tbSteer.Size = new System.Drawing.Size(104, 45);
            this.tbSteer.TabIndex = 6;
            this.tbSteer.Value = 100;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(276, 138);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(29, 31);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "0";
            // 
            // pbBrake
            // 
            this.pbBrake.Location = new System.Drawing.Point(163, 138);
            this.pbBrake.Name = "pbBrake";
            this.pbBrake.Size = new System.Drawing.Size(26, 186);
            this.pbBrake.TabIndex = 3;
            this.pbBrake.Value = 1;
            // 
            // pbThrottle
            // 
            this.pbThrottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbThrottle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbThrottle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbThrottle.Location = new System.Drawing.Point(89, 138);
            this.pbThrottle.Name = "pbThrottle";
            this.pbThrottle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbThrottle.Size = new System.Drawing.Size(26, 186);
            this.pbThrottle.Step = 1;
            this.pbThrottle.TabIndex = 2;
            this.pbThrottle.Value = 1;
            // 
            // lbDRS
            // 
            this.lbDRS.AutoSize = true;
            this.lbDRS.BackColor = System.Drawing.Color.Gray;
            this.lbDRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDRS.Location = new System.Drawing.Point(259, 87);
            this.lbDRS.Name = "lbDRS";
            this.lbDRS.Size = new System.Drawing.Size(66, 29);
            this.lbDRS.TabIndex = 8;
            this.lbDRS.Text = "DRS";
            // 
            // lbGear
            // 
            this.lbGear.AutoSize = true;
            this.lbGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lbGear.Location = new System.Drawing.Point(259, 187);
            this.lbGear.Name = "lbGear";
            this.lbGear.Size = new System.Drawing.Size(66, 29);
            this.lbGear.TabIndex = 9;
            this.lbGear.Text = "Gear";
            // 
            // pbRevLightPerc
            // 
            this.pbRevLightPerc.Location = new System.Drawing.Point(264, 239);
            this.pbRevLightPerc.Name = "pbRevLightPerc";
            this.pbRevLightPerc.Size = new System.Drawing.Size(100, 23);
            this.pbRevLightPerc.TabIndex = 10;
            // 
            // pbClutch
            // 
            this.pbClutch.Location = new System.Drawing.Point(264, 280);
            this.pbClutch.Name = "pbClutch";
            this.pbClutch.Size = new System.Drawing.Size(100, 23);
            this.pbClutch.TabIndex = 11;
            // 
            // vpbGaz
            // 
            this.vpbGaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vpbGaz.Cursor = System.Windows.Forms.Cursors.Cross;
            this.vpbGaz.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.vpbGaz.Location = new System.Drawing.Point(47, 138);
            this.vpbGaz.Name = "vpbGaz";
            this.vpbGaz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vpbGaz.Size = new System.Drawing.Size(26, 186);
            this.vpbGaz.TabIndex = 12;
            this.vpbGaz.Value = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLFTyrePressure);
            this.panel1.Controls.Add(this.lbLFTyreInTemp);
            this.panel1.Controls.Add(this.lbLFTyreSurfaceTemp);
            this.panel1.Controls.Add(this.lbLFBrakeTemp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(472, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 332);
            this.panel1.TabIndex = 13;
            // 
            // lbLFTyreInTemp
            // 
            this.lbLFTyreInTemp.AutoSize = true;
            this.lbLFTyreInTemp.Location = new System.Drawing.Point(31, 45);
            this.lbLFTyreInTemp.Name = "lbLFTyreInTemp";
            this.lbLFTyreInTemp.Size = new System.Drawing.Size(35, 13);
            this.lbLFTyreInTemp.TabIndex = 3;
            this.lbLFTyreInTemp.Text = "label3";
            // 
            // lbLFTyreSurfaceTemp
            // 
            this.lbLFTyreSurfaceTemp.AutoSize = true;
            this.lbLFTyreSurfaceTemp.Location = new System.Drawing.Point(51, 77);
            this.lbLFTyreSurfaceTemp.Name = "lbLFTyreSurfaceTemp";
            this.lbLFTyreSurfaceTemp.Size = new System.Drawing.Size(35, 13);
            this.lbLFTyreSurfaceTemp.TabIndex = 2;
            this.lbLFTyreSurfaceTemp.Text = "label2";
            // 
            // lbLFBrakeTemp
            // 
            this.lbLFBrakeTemp.AutoSize = true;
            this.lbLFBrakeTemp.Location = new System.Drawing.Point(31, 111);
            this.lbLFBrakeTemp.Name = "lbLFBrakeTemp";
            this.lbLFBrakeTemp.Size = new System.Drawing.Size(35, 13);
            this.lbLFBrakeTemp.TabIndex = 1;
            this.lbLFBrakeTemp.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(92, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbLFTyrePressure
            // 
            this.lbLFTyrePressure.AutoSize = true;
            this.lbLFTyrePressure.Location = new System.Drawing.Point(4, 76);
            this.lbLFTyrePressure.Name = "lbLFTyrePressure";
            this.lbLFTyrePressure.Size = new System.Drawing.Size(35, 13);
            this.lbLFTyrePressure.TabIndex = 4;
            this.lbLFTyrePressure.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vpbGaz);
            this.Controls.Add(this.pbClutch);
            this.Controls.Add(this.pbRevLightPerc);
            this.Controls.Add(this.lbGear);
            this.Controls.Add(this.lbDRS);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.tbSteer);
            this.Controls.Add(this.pbSteer);
            this.Controls.Add(this.pbBrake);
            this.Controls.Add(this.pbThrottle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VerticalProgressBar pbThrottle;
        private VerticalProgressBar pbBrake;
        private System.Windows.Forms.ProgressBar pbSteer;
        private System.Windows.Forms.TrackBar tbSteer;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lbDRS;
        private System.Windows.Forms.Label lbGear;
        private System.Windows.Forms.ProgressBar pbRevLightPerc;
        private System.Windows.Forms.ProgressBar pbClutch;
        private VerticalProgressBar vpbGaz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLFTyreInTemp;
        private System.Windows.Forms.Label lbLFTyreSurfaceTemp;
        private System.Windows.Forms.Label lbLFBrakeTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLFTyrePressure;
    }
}

