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

namespace UIPrincipal
{
    public partial class FormTarefa : Form
    {
        public FormTarefa()
        {
            InitializeComponent();
        }

        private void FormTarefa_Load(object sender, EventArgs e)
        {

           
        }

        private void buttonBuacar_Click(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            tarefaBindingSource.DataSource = tarefaBLL.Buscar(textBoxBuscar.Text);

        }

        

        private void buttonAdicionar_Click_1(object sender, EventArgs e)
        {
            CadastroTarefa frm = new CadastroTarefa();
            frm.ShowDialog();

        }
    }
}
