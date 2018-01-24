using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equalizer
{
    public partial class SpeedGrForm : Form
    {
        public SpeedGrForm()
        {
            InitializeComponent();
        }
        public void MakeGr(double tick, double speed)
        {
            if (this != null)
                chrtVel.Series[0].Points.AddXY(tick, speed);

        }
    }
}
