using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();

            // criamos um objeto da classe de controle passando esta tela como parâmetro
            PrincipalController principalC = new PrincipalController(this);
        }
    }
}
