﻿namespace NeverSpace
{
    partial class MainForm
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
            this.pictureBoxSpace = new System.Windows.Forms.PictureBox();
            this.button_simple_start = new System.Windows.Forms.Button();
            this.buttonAddPlanet = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.button1Tick = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlanetOnSpace = new System.Windows.Forms.Button();
            this.button_zoomin = new System.Windows.Forms.Button();
            this.button_zoomout = new System.Windows.Forms.Button();
            this.buttonTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSpace
            // 
            this.pictureBoxSpace.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSpace.Location = new System.Drawing.Point(108, 0);
            this.pictureBoxSpace.Name = "pictureBoxSpace";
            this.pictureBoxSpace.Size = new System.Drawing.Size(945, 586);
            this.pictureBoxSpace.TabIndex = 0;
            this.pictureBoxSpace.TabStop = false;
            this.pictureBoxSpace.Click += new System.EventHandler(this.pictureBoxSpace_Click);
            // 
            // button_simple_start
            // 
            this.button_simple_start.BackColor = System.Drawing.Color.White;
            this.button_simple_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simple_start.ForeColor = System.Drawing.Color.Black;
            this.button_simple_start.Location = new System.Drawing.Point(12, 12);
            this.button_simple_start.Name = "button_simple_start";
            this.button_simple_start.Size = new System.Drawing.Size(75, 30);
            this.button_simple_start.TabIndex = 1;
            this.button_simple_start.Text = "simple start";
            this.button_simple_start.UseVisualStyleBackColor = false;
            this.button_simple_start.Click += new System.EventHandler(this.button_simple_start_Click);
            // 
            // buttonAddPlanet
            // 
            this.buttonAddPlanet.BackColor = System.Drawing.Color.White;
            this.buttonAddPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlanet.ForeColor = System.Drawing.Color.Black;
            this.buttonAddPlanet.Location = new System.Drawing.Point(12, 48);
            this.buttonAddPlanet.Name = "buttonAddPlanet";
            this.buttonAddPlanet.Size = new System.Drawing.Size(75, 30);
            this.buttonAddPlanet.TabIndex = 2;
            this.buttonAddPlanet.Text = "Add Planet";
            this.buttonAddPlanet.UseVisualStyleBackColor = false;
            this.buttonAddPlanet.Click += new System.EventHandler(this.buttonAddPlanet_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.ForeColor = System.Drawing.Color.Black;
            this.labelOut.Location = new System.Drawing.Point(30, 501);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(35, 13);
            this.labelOut.TabIndex = 3;
            this.labelOut.Text = "label1";
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.White;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.ForeColor = System.Drawing.Color.Black;
            this.buttonGo.Location = new System.Drawing.Point(12, 264);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 30);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // button1Tick
            // 
            this.button1Tick.BackColor = System.Drawing.Color.White;
            this.button1Tick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Tick.ForeColor = System.Drawing.Color.Black;
            this.button1Tick.Location = new System.Drawing.Point(12, 300);
            this.button1Tick.Name = "button1Tick";
            this.button1Tick.Size = new System.Drawing.Size(75, 30);
            this.button1Tick.TabIndex = 5;
            this.button1Tick.Text = "1 tick";
            this.button1Tick.UseVisualStyleBackColor = false;
            this.button1Tick.Click += new System.EventHandler(this.button1Tick_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.White;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.ForeColor = System.Drawing.Color.Black;
            this.buttonPause.Location = new System.Drawing.Point(12, 336);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 30);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlanetOnSpace
            // 
            this.buttonPlanetOnSpace.BackColor = System.Drawing.Color.White;
            this.buttonPlanetOnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlanetOnSpace.ForeColor = System.Drawing.Color.Black;
            this.buttonPlanetOnSpace.Location = new System.Drawing.Point(12, 84);
            this.buttonPlanetOnSpace.Name = "buttonPlanetOnSpace";
            this.buttonPlanetOnSpace.Size = new System.Drawing.Size(75, 37);
            this.buttonPlanetOnSpace.TabIndex = 7;
            this.buttonPlanetOnSpace.Text = "Planet on Space";
            this.buttonPlanetOnSpace.UseVisualStyleBackColor = false;
            this.buttonPlanetOnSpace.Click += new System.EventHandler(this.buttonPlanetOnSpace_Click);
            // 
            // button_zoomin
            // 
            this.button_zoomin.BackColor = System.Drawing.Color.White;
            this.button_zoomin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zoomin.ForeColor = System.Drawing.Color.Black;
            this.button_zoomin.Location = new System.Drawing.Point(12, 398);
            this.button_zoomin.Name = "button_zoomin";
            this.button_zoomin.Size = new System.Drawing.Size(75, 30);
            this.button_zoomin.TabIndex = 8;
            this.button_zoomin.Text = "zoom in";
            this.button_zoomin.UseVisualStyleBackColor = false;
            this.button_zoomin.Click += new System.EventHandler(this.button_zoomin_Click);
            // 
            // button_zoomout
            // 
            this.button_zoomout.BackColor = System.Drawing.Color.White;
            this.button_zoomout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zoomout.ForeColor = System.Drawing.Color.Black;
            this.button_zoomout.Location = new System.Drawing.Point(12, 434);
            this.button_zoomout.Name = "button_zoomout";
            this.button_zoomout.Size = new System.Drawing.Size(75, 30);
            this.button_zoomout.TabIndex = 9;
            this.button_zoomout.Text = "zoom out";
            this.button_zoomout.UseVisualStyleBackColor = false;
            this.button_zoomout.Click += new System.EventHandler(this.button_zoomout_Click);
            // 
            // buttonTemp
            // 
            this.buttonTemp.BackColor = System.Drawing.Color.White;
            this.buttonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemp.ForeColor = System.Drawing.Color.Black;
            this.buttonTemp.Location = new System.Drawing.Point(12, 156);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(75, 30);
            this.buttonTemp.TabIndex = 10;
            this.buttonTemp.Text = "temp";
            this.buttonTemp.UseVisualStyleBackColor = false;
            this.buttonTemp.Click += new System.EventHandler(this.buttonTemp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1052, 587);
            this.Controls.Add(this.buttonTemp);
            this.Controls.Add(this.button_zoomout);
            this.Controls.Add(this.button_zoomin);
            this.Controls.Add(this.buttonPlanetOnSpace);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.button1Tick);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.buttonAddPlanet);
            this.Controls.Add(this.button_simple_start);
            this.Controls.Add(this.pictureBoxSpace);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "MainForm";
            this.Text = "Space";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSpace;
        private System.Windows.Forms.Button button_simple_start;
        private System.Windows.Forms.Button buttonAddPlanet;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button button1Tick;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlanetOnSpace;
        private System.Windows.Forms.Button button_zoomin;
        private System.Windows.Forms.Button button_zoomout;
        private System.Windows.Forms.Button buttonTemp;
    }
}

