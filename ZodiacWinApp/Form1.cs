using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetSign_Click(object sender, EventArgs e)
        {
            ZodiacLib zodiac = new ZodiacLib();
            zodiac.Day = Convert.ToInt16(numericUpDownDay.Value);
            zodiac.Month = comboBoxMonth.Text;
            labelDisplaySign.Text = zodiac.GetSign();
        }
    }
}
