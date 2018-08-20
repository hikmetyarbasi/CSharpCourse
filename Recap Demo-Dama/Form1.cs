using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap_Demo_Dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int left = 0, top = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].BackColor = (i + j) % 2 == 0 ? Color.Black : Color.White;
                }
                top += 50;
                left = 0;
            }
        }
    }
}
