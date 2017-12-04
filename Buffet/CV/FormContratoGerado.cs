using Buffet.DAO;
using Buffet.Modelos;
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
    public partial class FormContratoGerado : Form
    {
        public FormContratoGerado()
        {
            InitializeComponent();
        }

        public FormContratoGerado(Contrato c, long cpf, long cnpj, int tipoPessoa, int contrato)
        {
            InitializeComponent();
            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            ClienteFisico cf = cfDAO.FindByCPF(cpf);
            if (cnpj != null)
            {
                ClienteJuridico cj = cjDAO.FindByCNPJ(cnpj);
            }




        }
        
    }
}
