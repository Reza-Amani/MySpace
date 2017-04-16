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
    public partial class MainForm : Form
    {
        graphic graphics;
        public MainForm()
        {
            InitializeComponent();
            graphics = new graphic(pictureBoxSpace);
        }

        private void button_simple_start_Click(object sender, EventArgs e)
        {
            graphics.reset_view();
            graphics.draw_circle(50, 50, 10,Color.AliceBlue);
            graphics.apply_view();

        }

    }
}
