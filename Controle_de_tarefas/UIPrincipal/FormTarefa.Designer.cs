
namespace UIPrincipal
{
    partial class FormTarefa
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
            this.components = new System.ComponentModel.Container();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonBuacar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AllowUserToOrderColumns = true;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tarefaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource;
            this.tarefaDataGridView.Location = new System.Drawing.Point(12, 134);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.Size = new System.Drawing.Size(744, 342);
            this.tarefaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(MODEL.Tarefa);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 491);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(124, 34);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Nova Tarefa";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click_1);
            // 
            // buttonBuacar
            // 
            this.buttonBuacar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBuacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuacar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuacar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonBuacar.Location = new System.Drawing.Point(678, 98);
            this.buttonBuacar.Name = "buttonBuacar";
            this.buttonBuacar.Size = new System.Drawing.Size(78, 28);
            this.buttonBuacar.TabIndex = 1;
            this.buttonBuacar.Text = "Buscar";
            this.buttonBuacar.UseVisualStyleBackColor = true;
            this.buttonBuacar.Click += new System.EventHandler(this.buttonBuacar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonExcluir.Location = new System.Drawing.Point(632, 491);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(124, 34);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 98);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(646, 26);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(153, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Comentario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Tarefas";
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonBuacar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.tarefaDataGridView);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonBuacar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}