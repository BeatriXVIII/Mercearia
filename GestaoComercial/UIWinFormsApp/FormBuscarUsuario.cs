using BLL;
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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bindingSourceUsuario_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNomeUsuario(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
