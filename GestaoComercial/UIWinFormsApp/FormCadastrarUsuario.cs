using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormCadastrarUsuario : Form
    {
        private int id;
        public FormCadastrarUsuario(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Usuario usuario = (Usuario)bindingSourceCadastro.Current;
                if(id == 0)
                    new UsuarioBLL().Inserir(usuario);
                else
                    new UsuarioBLL().Alterar(usuario);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
