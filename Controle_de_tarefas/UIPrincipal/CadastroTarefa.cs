using BLL;
using DAL;
using MODEL;
using System;
using System.Data;
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
            tarefa.Id_Usuario = Convert.ToInt32(comboBoxUsuario.SelectedValue.ToString());
            tarefa.Descricao = textBoxDescricao.Text;
            tarefa.Estatus = comboBoxESTATUS.SelectedItem.ToString();

            tarefaBLL.Inserir(tarefa);

        }

        private void retornarUsuario()
        {
            String vqueryUsuarios =  @"SELECT Id, Nome FROM Usuario order by Id";

            comboBoxUsuario.Items.Clear();
            comboBoxUsuario.DataSource = Banco.dql(vqueryUsuarios);
            comboBoxUsuario.DisplayMember = "Nome";
            comboBoxUsuario.ValueMember = "Id";


        }

        private void CadastroTarefa_Load(object sender, EventArgs e)
        {
            retornarUsuario();
        }
    }
}
