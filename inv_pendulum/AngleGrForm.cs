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
    public partial class AngleGrForm : Form
    {
        public AngleGrForm()
        {
            InitializeComponent();
        }
        public void MakeGr(double tick, double angle)
        {
            if (this != null)
                chrtAngle.Series[0].Points.AddXY(tick, angle);
        }

    }
}
