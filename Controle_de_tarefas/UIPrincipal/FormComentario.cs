using BLL;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormComentario : Form
    {
        public FormComentario()
        {
            InitializeComponent();
        }
        private void Inserir()
        {
            ComentarioBLL comentarioBLL = new ComentarioBLL();
            Comentario comentario = new Comentario();

            comentario.Id = Convert.ToInt32(textBoxID.Text);
            comentario.Id_Usuario = Convert.ToInt32(comboBoxUsuario.SelectedValue.ToString());
            comentario.Descricao = textBoxDescrição.Text;
            comentario.Id_tarefa = Convert.ToInt32(comboBoxTarefa.SelectedValue.ToString());

            comentarioBLL.Inserir(comentario);

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Inserir();

                MessageBox.Show("Cadastro realizado com sucesso!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocorreu um erro: " + ex.Message);

            }
        }

        private void retornarUsuario()
        {
            String vqueryUsuarios = @"SELECT Id, Nome FROM Usuario order by Id";

            comboBoxUsuario.Items.Clear();
            comboBoxUsuario.DataSource = Banco.dql(vqueryUsuarios);
            comboBoxUsuario.DisplayMember = "Nome";
            comboBoxUsuario.ValueMember = "Id";


        }

        private void retornarTarefa()
        {
          String vqueryTarefas = @"SELECT Id, Descricao FROM Usuario order by Id";

            comboBoxTarefa.Items.Clear();
            comboBoxTarefa.DataSource = Banco.dql(vqueryTarefas);
            comboBoxTarefa.DisplayMember = "Descricao";
            comboBoxTarefa.ValueMember = "Id";
        }

        private void FormComentario_Load(object sender, EventArgs e)
        {
            retornarUsuario();
            retornarTarefa();
        }

    }
}
