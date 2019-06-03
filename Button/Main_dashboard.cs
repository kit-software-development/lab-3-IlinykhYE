using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Main_dashboard : Form
    {
        public Main_dashboard()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > button.Left - 10 && e.X < button.Left + button.Width+10)
            {
                if (e.X >= (button.Left + (button.Width / 2)))
                    button.Left -= 10;
                else
                    button.Left += 10;
            }

            if (e.Y >= button.Top - 10 && e.Y <= button.Top + button.Height + 10)
            {
                if (e.Y >= (button.Top + (button.Height / 2)))
                    button.Top -= 10;
                else
                    button.Top += 10;
            }

            //проверка, выходит ли кнопка за границы формы
            if (button.Left < 0)
                button.Left = 0; 
            if ((button.Left + button.Width) > this.ClientSize.Width)
                button.Left = this.ClientSize.Width - button.Width;
            if (button.Top < 0)
                button.Top = 0;
            if ((button.Top + button.Height) > this.ClientSize.Height)
                button.Top = this.ClientSize.Height - button.Height;
        }
    }
}
