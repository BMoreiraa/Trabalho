
namespace UIPrincipal
{
    partial class FormComentario
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.labelDescrição = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxTarefa = new System.Windows.Forms.ComboBox();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "Comentario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxUsuario);
            this.panel1.Controls.Add(this.comboBoxTarefa);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelDescrição);
            this.panel1.Controls.Add(this.textBoxDescrição);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.labelTarefa);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 301);
            this.panel1.TabIndex = 11;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(399, 52);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(62, 18);
            this.labelUsuario.TabIndex = 15;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Location = new System.Drawing.Point(197, 52);
            this.labelTarefa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(51, 18);
            this.labelTarefa.TabIndex = 13;
            this.labelTarefa.Text = "Tarefa";
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(23, 168);
            this.textBoxDescrição.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescrição.Multiline = true;
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(546, 69);
            this.textBoxDescrição.TabIndex = 17;
            // 
            // labelDescrição
            // 
            this.labelDescrição.AutoSize = true;
            this.labelDescrição.Location = new System.Drawing.Point(20, 136);
            this.labelDescrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescrição.Name = "labelDescrição";
            this.labelDescrição.Size = new System.Drawing.Size(80, 18);
            this.labelDescrição.TabIndex = 18;
            this.labelDescrição.Text = "Descrição";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(18, 84);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(148, 26);
            this.textBoxID.TabIndex = 20;
            this.textBoxID.Text = "0";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 52);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 18);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID ";
            // 
            // comboBoxTarefa
            // 
            this.comboBoxTarefa.FormattingEnabled = true;
            this.comboBoxTarefa.Location = new System.Drawing.Point(200, 84);
            this.comboBoxTarefa.Name = "comboBoxTarefa";
            this.comboBoxTarefa.Size = new System.Drawing.Size(169, 26);
            this.comboBoxTarefa.TabIndex = 21;
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(402, 84);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(167, 26);
            this.comboBoxUsuario.TabIndex = 22;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(12, 399);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(109, 41);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(611, 452);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormComentario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormComentario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.Label labelDescrição;
        private System.Windows.Forms.TextBox textBoxDescrição;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.ComboBox comboBoxTarefa;
        private System.Windows.Forms.Button buttonSalvar;
    }
}