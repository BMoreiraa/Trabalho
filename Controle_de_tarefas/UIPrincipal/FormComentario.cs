using BLL;
using DAL;
using MODEL;
using System;
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

            Banco banco = new Banco();
            comboBoxUsuario.Items.Clear();
            comboBoxUsuario.DataSource = Banco.dql(banco.vqueryUsuarios);
            comboBoxUsuario.DisplayMember = "Nome";
            comboBoxUsuario.ValueMember = "Id";


        }
        private void retornartarefas()
        {
            Banco banco = new Banco();

            comboBoxTarefa.Items.Clear();
            comboBoxTarefa.DataSource = Banco.dql(banco.vqueryTarefas);
            comboBoxTarefa.DisplayMember = "Descriçao";
            

        }



        private void FormComentario_Load(object sender, EventArgs e)
        {
            retornarUsuario();
            retornartarefas();
        }

    }
}
