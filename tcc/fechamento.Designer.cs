
namespace tcc
{
    partial class fechamento
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
            this.lbVendas = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.lblDiaHoje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTroco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.lblLucro = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnFecharodia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVendas
            // 
            this.lbVendas.AutoSize = true;
            this.lbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendas.Location = new System.Drawing.Point(63, 135);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(186, 29);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.Text = "Total vendido:";
            // 
            // txtVendas
            // 
            this.txtVendas.Enabled = false;
            this.txtVendas.Location = new System.Drawing.Point(272, 144);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(199, 20);
            this.txtVendas.TabIndex = 1;
            this.txtVendas.TextChanged += new System.EventHandler(this.txtVendas_TextChanged);
            // 
            // lblDiaHoje
            // 
            this.lblDiaHoje.AutoSize = true;
            this.lblDiaHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHoje.Location = new System.Drawing.Point(264, 41);
            this.lblDiaHoje.Name = "lblDiaHoje";
            this.lblDiaHoje.Size = new System.Drawing.Size(335, 39);
            this.lblDiaHoje.TabIndex = 2;
            this.lblDiaHoje.Text = "Fechamento do Dia";
            this.lblDiaHoje.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCodigo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtLucro);
            this.groupBox1.Controls.Add(this.lblLucro);
            this.groupBox1.Controls.Add(this.txtTroco);
            this.groupBox1.Controls.Add(this.lblTroco);
            this.groupBox1.Controls.Add(this.btnFecharodia);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblDiaHoje);
            this.groupBox1.Controls.Add(this.lbVendas);
            this.groupBox1.Controls.Add(this.txtVendas);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(149, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 635);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas do Dia";
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.Black;
            this.btnCodigo.Location = new System.Drawing.Point(877, 400);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(147, 45);
            this.btnCodigo.TabIndex = 13;
            this.btnCodigo.Text = "Escolher Data";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaData,
            this.colunaCod,
            this.colunaValorTotal,
            this.colunaFormaPag,
            this.colunaTroco});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(531, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 267);
            this.dataGridView1.TabIndex = 9;
            // 
            // colunaData
            // 
            this.colunaData.Frozen = true;
            this.colunaData.HeaderText = "Data";
            this.colunaData.MinimumWidth = 70;
            this.colunaData.Name = "colunaData";
            this.colunaData.Width = 70;
            // 
            // colunaCod
            // 
            this.colunaCod.Frozen = true;
            this.colunaCod.HeaderText = "Código";
            this.colunaCod.MinimumWidth = 110;
            this.colunaCod.Name = "colunaCod";
            this.colunaCod.Width = 110;
            // 
            // colunaValorTotal
            // 
            this.colunaValorTotal.Frozen = true;
            this.colunaValorTotal.HeaderText = "Valor Total";
            this.colunaValorTotal.MinimumWidth = 100;
            this.colunaValorTotal.Name = "colunaValorTotal";
            // 
            // colunaFormaPag
            // 
            this.colunaFormaPag.Frozen = true;
            this.colunaFormaPag.HeaderText = "Forma de Pagamento";
            this.colunaFormaPag.MinimumWidth = 100;
            this.colunaFormaPag.Name = "colunaFormaPag";
            // 
            // colunaTroco
            // 
            this.colunaTroco.Frozen = true;
            this.colunaTroco.HeaderText = "Troco";
            this.colunaTroco.Name = "colunaTroco";
            // 
            // txtLucro
            // 
            this.txtLucro.Enabled = false;
            this.txtLucro.Location = new System.Drawing.Point(272, 300);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(199, 20);
            this.txtLucro.TabIndex = 8;
            this.txtLucro.TextChanged += new System.EventHandler(this.txtLucro_TextChanged);
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(63, 291);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(172, 29);
            this.lblLucro.TabIndex = 7;
            this.lblLucro.Text = "Lucro do dia:";
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(272, 219);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(199, 20);
            this.txtTroco.TabIndex = 6;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(63, 210);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(158, 29);
            this.lblTroco.TabIndex = 5;
            this.lblTroco.Text = "Troco dado:";
            // 
            // btnFecharodia
            // 
            this.btnFecharodia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFecharodia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharodia.ForeColor = System.Drawing.Color.Black;
            this.btnFecharodia.Location = new System.Drawing.Point(181, 371);
            this.btnFecharodia.Name = "btnFecharodia";
            this.btnFecharodia.Size = new System.Drawing.Size(174, 45);
            this.btnFecharodia.TabIndex = 4;
            this.btnFecharodia.Text = "Fechar o Dia";
            this.btnFecharodia.UseVisualStyleBackColor = false;
            this.btnFecharodia.Click += new System.EventHandler(this.btnFecharodia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(923, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1380, 779);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1396, 818);
            this.MinimumSize = new System.Drawing.Size(1396, 818);
            this.Name = "fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fechamento";
            this.Load += new System.EventHandler(this.fechamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbVendas;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label lblDiaHoje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Button btnFecharodia;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTroco;
    }
}