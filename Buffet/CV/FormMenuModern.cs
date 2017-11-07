using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.CV
{
    public partial class FormMenuModern : Form
    {
        private int y;

        private FormCadastrados fc = new FormCadastrados();
        public FormMenuModern()
        {
            InitializeComponent();
        }

        //Botoes
        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void bttMenu_Click_1(object sender, EventArgs e)
        {
            bttMenu.Enabled = false;
            if (panelMenu.Size.Width <= 53)
            {
                timerSlideOutBarra.Enabled = true;
                timerSlideOutBarra.Start();
            }
            else
            {
                timerSlideInBarra.Enabled = true;
                timerSlideInBarra.Start();
            }
        }






        //Timers
        private void TimerSlideOutBarra_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Size.Width >= 168)
            {
                timerSlideOutBarra.Stop();
                bttMenu.Enabled = true;
            }
            else
            {
                panelMenu.Width += 13;
            }
        }

        private void TimerSlideInBarra_Tick(object sender, EventArgs e)
        {

            if (panelMenu.Size.Width <= 53)
            {
                timerSlideInBarra.Stop();
                bttMenu.Enabled = true;
            }
            else
            {
                panelMenu.Width -= 13;
            }
        }

        private void timerSelecao_Tick(object sender, EventArgs e)
        {
            int x;
            x = panelSelecao.Location.Y;
            if (x <= y)
            {
                if (x >= y)
                {
                    timerSelecao.Stop();
                }
                else
                {
                    //x += 5;
                    panelSelecao.Location = new Point(0,y);
                }
            }
            else
            {
                if(x <= y)
                {
                    timerSelecao.Stop();
                }
                else
                {
                    //x -= 5;
                    panelSelecao.Location = new Point(0,y);
                }
            }
        }

        private void timerCadastroOut_Tick(object sender, EventArgs e)
        {
            if(panelSlideCadastro.Size.Height >= 85)
            {
                timerCadastroOut.Stop();
            }
            else
            {
                panelSlideCadastro.Height += 5;
            }
        }








        //Paineis MouseClick
        private void panelCardapio_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelCardapio.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();
        }
        private void panelRelatorio_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelRelatorio.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();
        }
        private void panelConsulta_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelConsulta.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();

            if (!fc.Visible)
            {
                fc.TopLevel = false;
                panelWorkstation.Controls.Add(fc);
                fc.FormBorderStyle = FormBorderStyle.None;
                fc.WindowState = FormWindowState.Maximized;
                fc.Show();
            }
        }
        private void panelContrato_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelContrato.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();
        }
        private void panelCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelCadastro.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();
            panelSlideCadastro.Visible = true;
            timerCadastroOut.Enabled = true;
            timerCadastroOut.Start();


        }
        private void panelAgendamento_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelAgendamento.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();
        }










        //Paineis MouseMove
        private void panelCardapio_MouseMove(object sender, MouseEventArgs e)
        {
            panelCardapio.BackColor = Color.FromArgb(86, 80, 84);
        }

        private void panelRelatorio_MouseMove(object sender, MouseEventArgs e)
        {
            panelRelatorio.BackColor = Color.FromArgb(86, 80, 84);
        }
        private void panelAgendamento_MouseMove(object sender, MouseEventArgs e)
        {
            panelAgendamento.BackColor = Color.FromArgb(86, 80, 84);
        }
        private void panelConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            panelConsulta.BackColor = Color.FromArgb(86, 80, 84);
        }
        private void panelContrato_MouseMove(object sender, MouseEventArgs e)
        {
            panelContrato.BackColor = Color.FromArgb(86, 80, 84);
        }
        private void panelCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            panelCadastro.BackColor = Color.FromArgb(86, 80, 84);
        }









        //Paineis MouseLeave
        private void panelCardapio_MouseLeave(object sender, EventArgs e)
        {
            panelCardapio.BackColor = Color.FromArgb(42, 39, 41);
        }

        private void panelRelatorio_MouseLeave(object sender, EventArgs e)
        {
            panelRelatorio.BackColor = Color.FromArgb(42, 39, 41);
        }
        private void panelConsulta_MouseLeave(object sender, EventArgs e)
        {
            panelConsulta.BackColor = Color.FromArgb(42, 39, 41);
        }
        private void panelContrato_MouseLeave(object sender, EventArgs e)
        {
            panelContrato.BackColor = Color.FromArgb(42, 39, 41);
        }
        private void panelCadastro_MouseLeave(object sender, EventArgs e)
        {
            panelCadastro.BackColor = Color.FromArgb(42, 39, 41);
        }
        private void panelAgendamento_MouseLeave(object sender, EventArgs e)
        {
            panelAgendamento.BackColor = Color.FromArgb(42, 39, 41);
        }







        //Metodos
        private void LocalizacaoNova(int posicao)
        {
            y = posicao;
        }

    }
}
