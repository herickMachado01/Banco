using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class FormContainer : Form
    {
        public static Agencia agencia = new Agencia();
        public static string teste;

        public FormContainer()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormCliente f_cliente = new FormCliente(this);
            f_cliente.MdiParent = this;
            f_cliente.Show();
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FormConta formConta = new FormConta();
            formConta.MdiParent = this; 
            formConta.Show();
        }
    }
}
