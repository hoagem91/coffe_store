using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                int borderWidth = 2; // Độ dày đường viền
                Color borderColor = Color.Red; // Màu đường viền
                ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }
}
