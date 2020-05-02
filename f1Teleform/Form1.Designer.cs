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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFLTyrePressure = new System.Windows.Forms.Label();
            this.lbFLTyreInTemp = new System.Windows.Forms.Label();
            this.lbFLTyreSurfaceTemp = new System.Windows.Forms.Label();
            this.lbFLBrakeTemp = new System.Windows.Forms.Label();
            this.lbFRTyreInTemp = new System.Windows.Forms.Label();
            this.lbRLTyreInTemp = new System.Windows.Forms.Label();
            this.lbRRTyreInTemp = new System.Windows.Forms.Label();
            this.lbFRTyreSurfaceTemp = new System.Windows.Forms.Label();
            this.lbRLTyreSurfaceTemp = new System.Windows.Forms.Label();
            this.lbRRTyreSurfaceTemp = new System.Windows.Forms.Label();
            this.lbFRBrakeTemp = new System.Windows.Forms.Label();
            this.lbRLBrakeTemp = new System.Windows.Forms.Label();
            this.lbRRBrakeTemp = new System.Windows.Forms.Label();
            this.lbFRTyrePressure = new System.Windows.Forms.Label();
            this.lbRLTyrePressure = new System.Windows.Forms.Label();
            this.lbRRTyrePressure = new System.Windows.Forms.Label();
            this.lbEngineTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::f1Teleform.Properties.Resources.tyresWear1;
            this.panel2.Location = new System.Drawing.Point(484, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 260);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::f1Teleform.Properties.Resources.mfd;
            this.panel1.Controls.Add(this.lbEngineTemp);
            this.panel1.Controls.Add(this.lbRRTyrePressure);
            this.panel1.Controls.Add(this.lbRLTyrePressure);
            this.panel1.Controls.Add(this.lbFRTyrePressure);
            this.panel1.Controls.Add(this.lbRRBrakeTemp);
            this.panel1.Controls.Add(this.lbRLBrakeTemp);
            this.panel1.Controls.Add(this.lbFRBrakeTemp);
            this.panel1.Controls.Add(this.lbRRTyreSurfaceTemp);
            this.panel1.Controls.Add(this.lbRLTyreSurfaceTemp);
            this.panel1.Controls.Add(this.lbFRTyreSurfaceTemp);
            this.panel1.Controls.Add(this.lbRRTyreInTemp);
            this.panel1.Controls.Add(this.lbRLTyreInTemp);
            this.panel1.Controls.Add(this.lbFRTyreInTemp);
            this.panel1.Controls.Add(this.lbFLTyrePressure);
            this.panel1.Controls.Add(this.lbFLTyreInTemp);
            this.panel1.Controls.Add(this.lbFLTyreSurfaceTemp);
            this.panel1.Controls.Add(this.lbFLBrakeTemp);
            this.panel1.Location = new System.Drawing.Point(484, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 269);
            this.panel1.TabIndex = 13;
            // 
            // lbFLTyrePressure
            // 
            this.lbFLTyrePressure.AutoSize = true;
            this.lbFLTyrePressure.BackColor = System.Drawing.Color.Transparent;
            this.lbFLTyrePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFLTyrePressure.ForeColor = System.Drawing.Color.White;
            this.lbFLTyrePressure.Location = new System.Drawing.Point(168, 38);
            this.lbFLTyrePressure.Name = "lbFLTyrePressure";
            this.lbFLTyrePressure.Size = new System.Drawing.Size(15, 15);
            this.lbFLTyrePressure.TabIndex = 4;
            this.lbFLTyrePressure.Text = "0";
            // 
            // lbFLTyreInTemp
            // 
            this.lbFLTyreInTemp.AutoSize = true;
            this.lbFLTyreInTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFLTyreInTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFLTyreInTemp.ForeColor = System.Drawing.Color.White;
            this.lbFLTyreInTemp.Location = new System.Drawing.Point(62, 30);
            this.lbFLTyreInTemp.Name = "lbFLTyreInTemp";
            this.lbFLTyreInTemp.Size = new System.Drawing.Size(15, 15);
            this.lbFLTyreInTemp.TabIndex = 3;
            this.lbFLTyreInTemp.Text = "0";
            // 
            // lbFLTyreSurfaceTemp
            // 
            this.lbFLTyreSurfaceTemp.AutoSize = true;
            this.lbFLTyreSurfaceTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFLTyreSurfaceTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFLTyreSurfaceTemp.ForeColor = System.Drawing.Color.White;
            this.lbFLTyreSurfaceTemp.Location = new System.Drawing.Point(62, 60);
            this.lbFLTyreSurfaceTemp.Name = "lbFLTyreSurfaceTemp";
            this.lbFLTyreSurfaceTemp.Size = new System.Drawing.Size(15, 15);
            this.lbFLTyreSurfaceTemp.TabIndex = 2;
            this.lbFLTyreSurfaceTemp.Text = "0";
            // 
            // lbFLBrakeTemp
            // 
            this.lbFLBrakeTemp.AutoSize = true;
            this.lbFLBrakeTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFLBrakeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFLBrakeTemp.ForeColor = System.Drawing.Color.White;
            this.lbFLBrakeTemp.Location = new System.Drawing.Point(62, 89);
            this.lbFLBrakeTemp.Name = "lbFLBrakeTemp";
            this.lbFLBrakeTemp.Size = new System.Drawing.Size(15, 15);
            this.lbFLBrakeTemp.TabIndex = 1;
            this.lbFLBrakeTemp.Text = "0";
            // 
            // lbFRTyreInTemp
            // 
            this.lbFRTyreInTemp.AutoSize = true;
            this.lbFRTyreInTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFRTyreInTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRTyreInTemp.ForeColor = System.Drawing.Color.White;
            this.lbFRTyreInTemp.Location = new System.Drawing.Point(367, 30);
            this.lbFRTyreInTemp.Name = "lbFRTyreInTemp";
            this.lbFRTyreInTemp.Size = new System.Drawing.Size(17, 17);
            this.lbFRTyreInTemp.TabIndex = 5;
            this.lbFRTyreInTemp.Text = "0";
            // 
            // lbRLTyreInTemp
            // 
            this.lbRLTyreInTemp.AutoSize = true;
            this.lbRLTyreInTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRLTyreInTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLTyreInTemp.ForeColor = System.Drawing.Color.White;
            this.lbRLTyreInTemp.Location = new System.Drawing.Point(62, 169);
            this.lbRLTyreInTemp.Name = "lbRLTyreInTemp";
            this.lbRLTyreInTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRLTyreInTemp.TabIndex = 6;
            this.lbRLTyreInTemp.Text = "0";
            // 
            // lbRRTyreInTemp
            // 
            this.lbRRTyreInTemp.AutoSize = true;
            this.lbRRTyreInTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRRTyreInTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRRTyreInTemp.ForeColor = System.Drawing.Color.White;
            this.lbRRTyreInTemp.Location = new System.Drawing.Point(367, 169);
            this.lbRRTyreInTemp.Name = "lbRRTyreInTemp";
            this.lbRRTyreInTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRRTyreInTemp.TabIndex = 7;
            this.lbRRTyreInTemp.Text = "0";
            // 
            // lbFRTyreSurfaceTemp
            // 
            this.lbFRTyreSurfaceTemp.AutoSize = true;
            this.lbFRTyreSurfaceTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFRTyreSurfaceTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRTyreSurfaceTemp.ForeColor = System.Drawing.Color.White;
            this.lbFRTyreSurfaceTemp.Location = new System.Drawing.Point(367, 60);
            this.lbFRTyreSurfaceTemp.Name = "lbFRTyreSurfaceTemp";
            this.lbFRTyreSurfaceTemp.Size = new System.Drawing.Size(17, 17);
            this.lbFRTyreSurfaceTemp.TabIndex = 8;
            this.lbFRTyreSurfaceTemp.Text = "0";
            // 
            // lbRLTyreSurfaceTemp
            // 
            this.lbRLTyreSurfaceTemp.AutoSize = true;
            this.lbRLTyreSurfaceTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRLTyreSurfaceTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLTyreSurfaceTemp.ForeColor = System.Drawing.Color.White;
            this.lbRLTyreSurfaceTemp.Location = new System.Drawing.Point(62, 197);
            this.lbRLTyreSurfaceTemp.Name = "lbRLTyreSurfaceTemp";
            this.lbRLTyreSurfaceTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRLTyreSurfaceTemp.TabIndex = 9;
            this.lbRLTyreSurfaceTemp.Text = "0";
            // 
            // lbRRTyreSurfaceTemp
            // 
            this.lbRRTyreSurfaceTemp.AutoSize = true;
            this.lbRRTyreSurfaceTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRRTyreSurfaceTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRRTyreSurfaceTemp.ForeColor = System.Drawing.Color.White;
            this.lbRRTyreSurfaceTemp.Location = new System.Drawing.Point(367, 197);
            this.lbRRTyreSurfaceTemp.Name = "lbRRTyreSurfaceTemp";
            this.lbRRTyreSurfaceTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRRTyreSurfaceTemp.TabIndex = 10;
            this.lbRRTyreSurfaceTemp.Text = "0";
            // 
            // lbFRBrakeTemp
            // 
            this.lbFRBrakeTemp.AutoSize = true;
            this.lbFRBrakeTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbFRBrakeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRBrakeTemp.ForeColor = System.Drawing.Color.White;
            this.lbFRBrakeTemp.Location = new System.Drawing.Point(367, 89);
            this.lbFRBrakeTemp.Name = "lbFRBrakeTemp";
            this.lbFRBrakeTemp.Size = new System.Drawing.Size(17, 17);
            this.lbFRBrakeTemp.TabIndex = 11;
            this.lbFRBrakeTemp.Text = "0";
            // 
            // lbRLBrakeTemp
            // 
            this.lbRLBrakeTemp.AutoSize = true;
            this.lbRLBrakeTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRLBrakeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLBrakeTemp.ForeColor = System.Drawing.Color.White;
            this.lbRLBrakeTemp.Location = new System.Drawing.Point(62, 227);
            this.lbRLBrakeTemp.Name = "lbRLBrakeTemp";
            this.lbRLBrakeTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRLBrakeTemp.TabIndex = 12;
            this.lbRLBrakeTemp.Text = "0";
            // 
            // lbRRBrakeTemp
            // 
            this.lbRRBrakeTemp.AutoSize = true;
            this.lbRRBrakeTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbRRBrakeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRRBrakeTemp.ForeColor = System.Drawing.Color.White;
            this.lbRRBrakeTemp.Location = new System.Drawing.Point(367, 227);
            this.lbRRBrakeTemp.Name = "lbRRBrakeTemp";
            this.lbRRBrakeTemp.Size = new System.Drawing.Size(17, 17);
            this.lbRRBrakeTemp.TabIndex = 13;
            this.lbRRBrakeTemp.Text = "0";
            // 
            // lbFRTyrePressure
            // 
            this.lbFRTyrePressure.AutoSize = true;
            this.lbFRTyrePressure.BackColor = System.Drawing.Color.Transparent;
            this.lbFRTyrePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRTyrePressure.ForeColor = System.Drawing.Color.White;
            this.lbFRTyrePressure.Location = new System.Drawing.Point(299, 36);
            this.lbFRTyrePressure.Name = "lbFRTyrePressure";
            this.lbFRTyrePressure.Size = new System.Drawing.Size(17, 17);
            this.lbFRTyrePressure.TabIndex = 14;
            this.lbFRTyrePressure.Text = "0";
            // 
            // lbRLTyrePressure
            // 
            this.lbRLTyrePressure.AutoSize = true;
            this.lbRLTyrePressure.BackColor = System.Drawing.Color.Transparent;
            this.lbRLTyrePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLTyrePressure.ForeColor = System.Drawing.Color.White;
            this.lbRLTyrePressure.Location = new System.Drawing.Point(164, 176);
            this.lbRLTyrePressure.Name = "lbRLTyrePressure";
            this.lbRLTyrePressure.Size = new System.Drawing.Size(17, 17);
            this.lbRLTyrePressure.TabIndex = 15;
            this.lbRLTyrePressure.Text = "0";
            // 
            // lbRRTyrePressure
            // 
            this.lbRRTyrePressure.AutoSize = true;
            this.lbRRTyrePressure.BackColor = System.Drawing.Color.Transparent;
            this.lbRRTyrePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRRTyrePressure.ForeColor = System.Drawing.Color.White;
            this.lbRRTyrePressure.Location = new System.Drawing.Point(301, 177);
            this.lbRRTyrePressure.Name = "lbRRTyrePressure";
            this.lbRRTyrePressure.Size = new System.Drawing.Size(17, 17);
            this.lbRRTyrePressure.TabIndex = 16;
            this.lbRRTyrePressure.Text = "0";
            // 
            // lbEngineTemp
            // 
            this.lbEngineTemp.AutoSize = true;
            this.lbEngineTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbEngineTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEngineTemp.ForeColor = System.Drawing.Color.White;
            this.lbEngineTemp.Location = new System.Drawing.Point(233, 149);
            this.lbEngineTemp.Name = "lbEngineTemp";
            this.lbEngineTemp.Size = new System.Drawing.Size(17, 17);
            this.lbEngineTemp.TabIndex = 18;
            this.lbEngineTemp.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 559);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Label lbFLTyreInTemp;
        private System.Windows.Forms.Label lbFLTyreSurfaceTemp;
        private System.Windows.Forms.Label lbFLBrakeTemp;
        private System.Windows.Forms.Label lbFLTyrePressure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRRBrakeTemp;
        private System.Windows.Forms.Label lbRLBrakeTemp;
        private System.Windows.Forms.Label lbFRBrakeTemp;
        private System.Windows.Forms.Label lbRRTyreSurfaceTemp;
        private System.Windows.Forms.Label lbRLTyreSurfaceTemp;
        private System.Windows.Forms.Label lbFRTyreSurfaceTemp;
        private System.Windows.Forms.Label lbRRTyreInTemp;
        private System.Windows.Forms.Label lbRLTyreInTemp;
        private System.Windows.Forms.Label lbFRTyreInTemp;
        private System.Windows.Forms.Label lbRRTyrePressure;
        private System.Windows.Forms.Label lbRLTyrePressure;
        private System.Windows.Forms.Label lbFRTyrePressure;
        private System.Windows.Forms.Label lbEngineTemp;
    }
}

