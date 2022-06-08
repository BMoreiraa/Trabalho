using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class TelaLogin : Form
    {

        public bool logou;
        public TelaLogin()
        {
            InitializeComponent();
            logou = false;
        }

      

        private void checkBoxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostraSenha.Checked)
            {
                TXTBSenha.PasswordChar = '\0';
            }
            else
            {
                TXTBSenha.PasswordChar = '*';
            }
        }

        private void buttonSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BTTLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuariobindingSource = new BindingSource();
            usuariobindingSource.DataSource = usuarioBLL.Buscar(TXTBUsuario.Text);

            if (usuariobindingSource.Count != 0)
            {

                string nome = ((DataRowView)usuariobindingSource.Current).Row["Nome"].ToString();
                string senha = ((DataRowView)usuariobindingSource.Current).Row["Senha"].ToString();

                if (nome == TXTBUsuario.Text && senha == TXTBSenha.Text)
                {
                    logou = true;
                    FormTarefa frm = new FormTarefa();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorreta");
                    TXTBSenha.Text = "";
                    TXTBSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta");
                TXTBSenha.Text = "";
                TXTBSenha.Focus();
            }
        }
        
    }
}
