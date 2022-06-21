
namespace UIPrincipal
{
    partial class CadastroTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label_IdUsuario = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxESTATUS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(36, 141);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(19, 17);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "Id";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(40, 162);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(132, 25);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.Text = "0";
            // 
            // label_IdUsuario
            // 
            this.label_IdUsuario.AutoSize = true;
            this.label_IdUsuario.Location = new System.Drawing.Point(215, 141);
            this.label_IdUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IdUsuario.Name = "label_IdUsuario";
            this.label_IdUsuario.Size = new System.Drawing.Size(58, 17);
            this.label_IdUsuario.TabIndex = 0;
            this.label_IdUsuario.Text = "Usuário";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(40, 230);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(599, 67);
            this.textBoxDescricao.TabIndex = 3;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(36, 209);
            this.labelDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(75, 17);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(37, 312);
            this.labelEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(58, 17);
            this.labelEstatus.TabIndex = 4;
            this.labelEstatus.Text = "Estatus";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonSalvar.Location = new System.Drawing.Point(40, 416);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(147, 42);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nova Tarefa";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.BackColor = System.Drawing.Color.White;
            this.comboBoxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(219, 162);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(274, 25);
            this.comboBoxUsuario.TabIndex = 10;
            // 
            // comboBoxESTATUS
            // 
            this.comboBoxESTATUS.BackColor = System.Drawing.Color.White;
            this.comboBoxESTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxESTATUS.FormattingEnabled = true;
            this.comboBoxESTATUS.Items.AddRange(new object[] {
            "COMPLETO",
            "NÃO COMPETO"});
            this.comboBoxESTATUS.Location = new System.Drawing.Point(40, 333);
            this.comboBoxESTATUS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxESTATUS.Name = "comboBoxESTATUS";
            this.comboBoxESTATUS.Size = new System.Drawing.Size(198, 25);
            this.comboBoxESTATUS.TabIndex = 11;
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.comboBoxESTATUS);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelEstatus);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.label_IdUsuario);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label_ID);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadastroTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label_IdUsuario;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.ComboBox comboBoxESTATUS;
    }
}