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
            get { return Globals.scale_xy* Convert.ToInt16(this.textBoxX.Text); }
        }
        public double y
        {
            get { return Globals.scale_xy * Convert.ToInt16(this.textBoxY.Text); }
        }
        public double mass
        {
            get { return Globals.scale_mass* Convert.ToDouble(this.textBoxMass.Text); }
        }
        public int radius
        {
            get { return Convert.ToInt16(this.textBoxRadius.Text); }
        }
        public double speed_x
        {
            get { return Globals.scale_v * Convert.ToDouble(this.textBoxSpeedX.Text); }
        }
        public double speed_y
        {
            get { return Globals.scale_v * Convert.ToDouble(this.textBoxSpeedY.Text); }
        }
        public bool fix
        {
            get { return Convert.ToBoolean(this.checkBoxFixed); }
        }

    }
}
