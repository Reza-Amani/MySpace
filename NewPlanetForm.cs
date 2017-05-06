using System;
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
        public double x
        {
            get { return Globals.scale_xy * Convert.ToInt16(this.textBoxX.Text); }
            set { this.textBoxX.Text = value.ToString(); }
        }
        public double y
        {
            get { return Globals.scale_xy * Convert.ToInt16(this.textBoxY.Text); }
            set { this.textBoxY.Text = value.ToString(); }
        }
        public double mass
        {
            get { return Globals.scale_mass* Convert.ToDouble(this.textBoxMass.Text); }
            set { this.textBoxMass.Text = value.ToString(); }
        }
        public int radius
        {
            get { return Convert.ToInt16(this.textBoxRadius.Text); }
            set { this.textBoxRadius.Text = value.ToString(); }
        }
        public double speed_x
        {
            get { return Globals.scale_v * Convert.ToDouble(this.textBoxSpeedX.Text); }
            set { this.textBoxSpeedX.Text = value.ToString(); }

        }
        public double speed_y
        {
            get { return Globals.scale_v * Convert.ToDouble(this.textBoxSpeedY.Text); }
            set { this.textBoxSpeedY.Text = value.ToString(); }
        }
        public bool fix
        {
            get { return Convert.ToBoolean(this.checkBoxFixed.Checked); }
        }

    }
}
