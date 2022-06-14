using BLL;
using MODEL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class CadastroTarefa : Form
    {
        public CadastroTarefa()
        {
            InitializeComponent();
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

        private void Inserir()
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            Tarefa tarefa = new Tarefa();

            tarefa.Id = Convert.ToInt32(textBoxID.Text);
            tarefa.Id_Usuario = Convert.ToInt32(textBoxIDUsuario.Text);
            tarefa.Descricao = textBoxDescricao.Text;
            tarefa.Estatus = textBoxEstatus.Text;

            tarefaBLL.Inserir(tarefa);

        }

    }
}
