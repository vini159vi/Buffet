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
        private bool moving, slideFechado;
        private int fX, fY;

        private FormCadastrados fc = new FormCadastrados();
        private FormFisico ff = new FormFisico();
        private FormJuridico fj = new FormJuridico();
        private FormRepresentante fr = new FormRepresentante();
        private FormAgenda fa = new FormAgenda();
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
            {
                this.WindowState = FormWindowState.Normal;
                if (fc.Visible)
                {
                    fc.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                if (fc.Visible)
                {
                    fc.WindowState = FormWindowState.Maximized;
                }
            }
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
                    x += 20;
                    panelSelecao.Location = new Point(0,x);
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
                    x -= 20;
                    panelSelecao.Location = new Point(0,x);
                }
            }
        }
        private void timerSubMenuOut_Tick(object sender, EventArgs e)
        {
            int x;
            x = panelSubMenu.Location.X;
            if (panelSubMenu.Location.X >= 0)
            {
                timerSubMenuOut.Stop();
            }
            else
            {
                x += 15;
                panelSubMenu.Location = new Point(x , 0);
            }
        }
        private void timerSubMenuIn_Tick(object sender, EventArgs e)
        {
            Point x = panelSubMenu.Location;
            if (panelSubMenu.Location.X <= -180)
            {
                timerSubMenuIn.Stop();
                panelSubMenu.Visible = false;
            }
            else
            {
                x.X -= 15;
                panelSubMenu.Location = x;
            }
        }

        private void timerSelecao2_Tick(object sender, EventArgs e)
        {
            int x;
            x = panelSelecao2.Location.Y;
            if (x <= y)
            {
                if (x >= y)
                {
                    timerSelecao2.Stop();
                }
                else
                {
                    panelSelecao2.Location = new Point(0, y);
                }
            }
            else
            {
                if (x <= y)
                {
                    timerSelecao2.Stop();
                }
                else
                {
                    panelSelecao2.Location = new Point(0, y);
                }
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

            FecharTelas();

            if (!fc.Visible)
            {
                fc.TopLevel = false;
                panelWorkstation.Controls.Add(fc);
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

            opcaoCadastro();
            panelSubMenu.Visible = true;
            timerSubMenuOut.Enabled = true;
            timerSubMenuOut.Start();
        }
        private void panelAgendamento_MouseClick(object sender, MouseEventArgs e)
        {
            LocalizacaoNova(panelAgendamento.Location.Y);
            timerSelecao.Enabled = true;
            timerSelecao.Start();

            if (!fa.Visible)
            {
                fa.TopLevel = false;
                panelWorkstation.Controls.Add(fa);
                fa.Show();
            }
        }

        private void bttHome_Click(object sender, EventArgs e)
        {
            FecharTelas();
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
        private void topPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                this.Left += e.X - (fX - topPage.Left);
                this.Top += e.Y - (fY - topPage.Top);
            }
        }


        //Paineis MouseLeave
        private void panelCardapio_MouseLeave(object sender, EventArgs e)
        {
            panelCardapio.BackColor = Color.FromArgb(20, 20, 20);
        }
        private void panelRelatorio_MouseLeave(object sender, EventArgs e)
        {
            panelRelatorio.BackColor = Color.FromArgb(20, 20, 20);
        }
        private void panelConsulta_MouseLeave(object sender, EventArgs e)
        {
            panelConsulta.BackColor = Color.FromArgb(20, 20, 20);
        }
        private void panelContrato_MouseLeave(object sender, EventArgs e)
        {
            panelContrato.BackColor = Color.FromArgb(20, 20, 20);
        }
        private void panelCadastro_MouseLeave(object sender, EventArgs e)
        {
            panelCadastro.BackColor = Color.FromArgb(20, 20, 20);
        }
        private void panelAgendamento_MouseLeave(object sender, EventArgs e)
        {
            panelAgendamento.BackColor = Color.FromArgb(20, 20, 20);
        }

        //MouseUp
        private void topPage_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }


        //MouseDown
        private void topPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fX = e.X;
                fY = e.Y;
                moving = true;
            }
        }

        //------------------------------------------------------------------------------------------------------
        //SubMenu comandos
        private void bttMenuVoltar_Click(object sender, EventArgs e)
        {
            timerSubMenuIn.Enabled = true;
            timerSubMenuIn.Start();

            bttOpcao1.Controls.Clear();
            bttOpcao2.Controls.Clear();
            bttOpcao3.Controls.Clear();
        }


        //Click
        private void CadastroFisico_Click(object sender, EventArgs e)
        {
            FecharTelas();
            LocalizacaoNova(bttOpcao1.Location.Y);
            timerSelecao2.Enabled = true;
            timerSelecao2.Start();


            if (!ff.Visible)
            {
                ff.TopLevel = false;
                panelWorkstation.Controls.Add(ff);
                ff.Show();
            }

            bttOpcao1.Click -= new EventHandler(CadastroFisico_Click);
            timerSubMenuIn.Enabled = true;
            timerSubMenuIn.Start();

        }
        private void CadastroJuridico_Click(object sender, EventArgs e)
        {
            FecharTelas();
            LocalizacaoNova(bttOpcao2.Location.Y);
            timerSelecao2.Enabled = true;
            timerSelecao2.Start();

            if (!fj.Visible)
            {
                fj.TopLevel = false;
                panelWorkstation.Controls.Add(fj);
                fj.Show();
            }

            bttOpcao2.Click -= new EventHandler(CadastroJuridico_Click);
            timerSubMenuIn.Enabled = true;
            timerSubMenuIn.Start();
        }
        private void CadastroRepresentante_Click(object sender, EventArgs e)
        {
            FecharTelas();
            LocalizacaoNova(bttOpcao3.Location.Y);
            timerSelecao2.Enabled = true;
            timerSelecao2.Start();

            if (!fr.Visible)
            {
                fr.TopLevel = false;
                panelWorkstation.Controls.Add(fr);
                fr.Show();
            }

            bttOpcao3.Click -= new EventHandler(CadastroRepresentante_Click);
            timerSubMenuIn.Enabled = true;
            timerSubMenuIn.Start();
        }




        //------------------------------------------------------------------------------------------------------
        //Gerais

        //Metodos
        private int LocalizacaoNova(int posicao)
        {
            y = posicao;
            return y;
        }

        private void opcaoCadastro()
        {
            bttOpcao1.Text = "Pessoa Fisica";
            bttOpcao2.Text = "Pessoa Juridica";
            bttOpcao3.Text = "Representante";
            lblOpcao.Text = "Cadastro";

            bttOpcao1.Click += new EventHandler(CadastroFisico_Click);
            bttOpcao2.Click += new EventHandler(CadastroJuridico_Click);
            bttOpcao3.Click += new EventHandler(CadastroRepresentante_Click);
        }

        private void FecharTelas()
        {
            if (ff.Visible)
            {
                ff.Hide();
            }

            if (fc.Visible)
            {
                fc.Hide();
            }

            if (fj.Visible)
            {
                fj.Hide();
            }

            if (fr.Visible)
            {
                fr.Hide();
            }
        }



    }
}
