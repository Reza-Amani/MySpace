﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeverSpace
{
    public partial class NewPlanetForm : Form
    {
        public NewPlanetForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
        public int x
        {
            get { return Convert.ToInt16(this.textBoxX.Text); }
        }
        public int y
        {
            get { return Convert.ToInt16(this.textBoxY.Text); }
        }
        public double mass
        {
            get { return Convert.ToDouble(this.textBoxMass.Text); }
        }
        public int radius
        {
            get { return Convert.ToInt16(this.textBoxRadius.Text); }
        }
        public double speed_x
        {
            get { return Convert.ToDouble(this.textBoxSpeedX.Text); }
        }
        public double speed_y
        {
            get { return Convert.ToDouble(this.textBoxSpeedY.Text); }
        }

    }
}