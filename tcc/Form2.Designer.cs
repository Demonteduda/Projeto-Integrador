
namespace tcc
{
    partial class Form2
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
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.dataGridProdu = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(533, 330);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(167, 21);
            this.cmbQuantidade.TabIndex = 8;
            this.cmbQuantidade.Text = "    Quantidade";
            this.cmbQuantidade.SelectedIndexChanged += new System.EventHandler(this.cmbPagamento_SelectedIndexChanged);
            this.cmbQuantidade.Click += new System.EventHandler(this.cmbQuantidade_Click);
            this.cmbQuantidade.Enter += new System.EventHandler(this.cmbQuantidade_Enter);
            this.cmbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPagamento_KeyDown);
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.MintCream;
            this.txtCod.Location = new System.Drawing.Point(430, 270);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(270, 20);
            this.txtCod.TabIndex = 10;
            this.txtCod.Click += new System.EventHandler(this.txtCod_Click);
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.Enter += new System.EventHandler(this.txtCod_Enter);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(383, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(372, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(430, 300);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(270, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(374, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Efetuar pagamento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Location = new System.Drawing.Point(554, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Produtos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Location = new System.Drawing.Point(632, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Location = new System.Drawing.Point(384, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Apagar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button5.Location = new System.Drawing.Point(384, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Apagar item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::tcc.Properties.Resources.s__3_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tcc.Properties.Resources._11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(757, 489);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(515, 371);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 19;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // dataGridProdu
            // 
            this.dataGridProdu.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridProdu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProdu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridProdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.name,
            this.Preço,
            this.Quanti});
            this.dataGridProdu.Location = new System.Drawing.Point(386, 23);
            this.dataGridProdu.MultiSelect = false;
            this.dataGridProdu.Name = "dataGridProdu";
            this.dataGridProdu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdu.Size = new System.Drawing.Size(314, 225);
            this.dataGridProdu.TabIndex = 20;
            this.dataGridProdu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.Width = 50;
            // 
            // Quanti
            // 
            this.Quanti.HeaderText = "Quantidade";
            this.Quanti.Name = "Quanti";
            this.Quanti.Width = 70;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 694);
            this.Controls.Add(this.dataGridProdu);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbQuantidade);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridView dataGridProdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanti;
    }
}