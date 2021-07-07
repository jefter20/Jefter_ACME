
namespace Jefter_AMCE.Visualizacao
{
    partial class FormVoo
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.rbtnCapturaNao = new System.Windows.Forms.RadioButton();
            this.rbtnCapturaSim = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.GridVoo = new System.Windows.Forms.DataGridView();
            this.Id_voo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_voo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_dor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridVoo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(416, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(89, 30);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(511, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(502, 177);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(221, 20);
            this.txtDistancia.TabIndex = 5;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(502, 137);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(221, 20);
            this.txtCusto.TabIndex = 4;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Location = new System.Drawing.Point(502, 258);
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(221, 20);
            this.txtNivelDor.TabIndex = 8;
            this.txtNivelDor.TextChanged += new System.EventHandler(this.txtNivelDor_TextChanged);
            // 
            // rbtnCapturaNao
            // 
            this.rbtnCapturaNao.AutoSize = true;
            this.rbtnCapturaNao.Location = new System.Drawing.Point(502, 220);
            this.rbtnCapturaNao.Name = "rbtnCapturaNao";
            this.rbtnCapturaNao.Size = new System.Drawing.Size(45, 17);
            this.rbtnCapturaNao.TabIndex = 6;
            this.rbtnCapturaNao.TabStop = true;
            this.rbtnCapturaNao.Text = "Nao";
            this.rbtnCapturaNao.UseVisualStyleBackColor = true;
            this.rbtnCapturaNao.CheckedChanged += new System.EventHandler(this.rbtnCapturaNao_CheckedChanged);
            // 
            // rbtnCapturaSim
            // 
            this.rbtnCapturaSim.AutoSize = true;
            this.rbtnCapturaSim.Location = new System.Drawing.Point(623, 220);
            this.rbtnCapturaSim.Name = "rbtnCapturaSim";
            this.rbtnCapturaSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnCapturaSim.TabIndex = 7;
            this.rbtnCapturaSim.TabStop = true;
            this.rbtnCapturaSim.Text = "Sim";
            this.rbtnCapturaSim.UseVisualStyleBackColor = true;
            this.rbtnCapturaSim.CheckedChanged += new System.EventHandler(this.rbtnCapturaSim_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(558, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(463, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Distancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NivelDor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Captura";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(502, 94);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(221, 20);
            this.txtData.TabIndex = 3;
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            // 
            // GridVoo
            // 
            this.GridVoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVoo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_voo,
            this.Data_voo,
            this.Custo,
            this.Distancia,
            this.Capturas,
            this.Nivel_dor});
            this.GridVoo.Location = new System.Drawing.Point(13, 12);
            this.GridVoo.Name = "GridVoo";
            this.GridVoo.Size = new System.Drawing.Size(384, 403);
            this.GridVoo.TabIndex = 16;
            this.GridVoo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVoo_CellClick);
            // 
            // Id_voo
            // 
            this.Id_voo.DataPropertyName = "Id_voo";
            this.Id_voo.HeaderText = "Id_voo";
            this.Id_voo.Name = "Id_voo";
            this.Id_voo.Visible = false;
            // 
            // Data_voo
            // 
            this.Data_voo.DataPropertyName = "Data_voo";
            this.Data_voo.HeaderText = "Data";
            this.Data_voo.Name = "Data_voo";
            // 
            // Custo
            // 
            this.Custo.DataPropertyName = "Custo";
            this.Custo.HeaderText = "Custo";
            this.Custo.Name = "Custo";
            this.Custo.Visible = false;
            // 
            // Distancia
            // 
            this.Distancia.DataPropertyName = "Distancia";
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            this.Distancia.Visible = false;
            // 
            // Capturas
            // 
            this.Capturas.DataPropertyName = "Captura";
            this.Capturas.HeaderText = "Captura";
            this.Capturas.Name = "Capturas";
            // 
            // Nivel_dor
            // 
            this.Nivel_dor.DataPropertyName = "Nivel_dor";
            this.Nivel_dor.HeaderText = "Nível de Dor";
            this.Nivel_dor.Name = "Nivel_dor";
            this.Nivel_dor.Width = 150;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(651, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 20);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // FormVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 427);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.GridVoo);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rbtnCapturaSim);
            this.Controls.Add(this.rbtnCapturaNao);
            this.Controls.Add(this.txtNivelDor);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FormVoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME FLIGTH MANAGER";
            this.Load += new System.EventHandler(this.FormVoo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.RadioButton rbtnCapturaNao;
        private System.Windows.Forms.RadioButton rbtnCapturaSim;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DataGridView GridVoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_voo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_voo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_dor;
        private System.Windows.Forms.TextBox txtId;
    }
}

