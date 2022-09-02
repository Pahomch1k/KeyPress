using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace KeyPress
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {  
            switch (e.KeyChar)
            {
                case 'w': Top += -50; break; 
                case 'd': Left += 50; break;
                case 's': Top += 50; break;
                case 'a': Left += -50; break;
                default: break;
            } 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: Top += -50; break;
                case Keys.Right: Left += 50; break;
                case Keys.Down: Top += 50; break;
                case Keys.Left: Left += -50; break;
                default: break;
            }
        }
    }
}
