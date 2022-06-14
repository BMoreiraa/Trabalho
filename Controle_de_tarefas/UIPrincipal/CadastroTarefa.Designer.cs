
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
            this.textBoxIDUsuario = new System.Windows.Forms.TextBox();
            this.label_IdUsuario = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxEstatus = new System.Windows.Forms.TextBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(27, 108);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(16, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "Id";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(30, 124);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxIDUsuario
            // 
            this.textBoxIDUsuario.Location = new System.Drawing.Point(164, 124);
            this.textBoxIDUsuario.Name = "textBoxIDUsuario";
            this.textBoxIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDUsuario.TabIndex = 4;
            // 
            // label_IdUsuario
            // 
            this.label_IdUsuario.AutoSize = true;
            this.label_IdUsuario.Location = new System.Drawing.Point(161, 108);
            this.label_IdUsuario.Name = "label_IdUsuario";
            this.label_IdUsuario.Size = new System.Drawing.Size(55, 13);
            this.label_IdUsuario.TabIndex = 3;
            this.label_IdUsuario.Text = "Id Usuário";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(30, 176);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(450, 39);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(27, 160);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 5;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBoxEstatus
            // 
            this.textBoxEstatus.Location = new System.Drawing.Point(30, 246);
            this.textBoxEstatus.Name = "textBoxEstatus";
            this.textBoxEstatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstatus.TabIndex = 8;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(27, 230);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(42, 13);
            this.labelEstatus.TabIndex = 7;
            this.labelEstatus.Text = "Estatus";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonSalvar.Location = new System.Drawing.Point(30, 318);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(110, 32);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 72);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nova Tarefa";
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxEstatus);
            this.Controls.Add(this.labelEstatus);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxIDUsuario);
            this.Controls.Add(this.label_IdUsuario);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label_ID);
            this.Name = "CadastroTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxIDUsuario;
        private System.Windows.Forms.Label label_IdUsuario;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
    }
}