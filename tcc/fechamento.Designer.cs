
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblLucro = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.btnFecharodia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVendas
            // 
            this.lbVendas.AutoSize = true;
            this.lbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendas.Location = new System.Drawing.Point(16, 106);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(162, 25);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.Text = "Total vendido:";
            // 
            // txtVendas
            // 
            this.txtVendas.Enabled = false;
            this.txtVendas.Location = new System.Drawing.Point(181, 112);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(119, 20);
            this.txtVendas.TabIndex = 1;
            this.txtVendas.TextChanged += new System.EventHandler(this.txtVendas_TextChanged);
            // 
            // lblDiaHoje
            // 
            this.lblDiaHoje.AutoSize = true;
            this.lblDiaHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHoje.Location = new System.Drawing.Point(28, 30);
            this.lblDiaHoje.Name = "lblDiaHoje";
            this.lblDiaHoje.Size = new System.Drawing.Size(335, 39);
            this.lblDiaHoje.TabIndex = 2;
            this.lblDiaHoje.Text = "Fechamento do Dia";
            this.lblDiaHoje.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(95, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas do Dia";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(478, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(37, 153);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(138, 25);
            this.lblTroco.TabIndex = 5;
            this.lblTroco.Text = "Troco dado:";
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(181, 158);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(119, 20);
            this.txtTroco.TabIndex = 6;
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(25, 201);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(150, 25);
            this.lblLucro.TabIndex = 7;
            this.lblLucro.Text = "Lucro do dia:";
            // 
            // txtLucro
            // 
            this.txtLucro.Enabled = false;
            this.txtLucro.Location = new System.Drawing.Point(181, 207);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(119, 20);
            this.txtLucro.TabIndex = 8;
            // 
            // btnFecharodia
            // 
            this.btnFecharodia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFecharodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharodia.ForeColor = System.Drawing.Color.Black;
            this.btnFecharodia.Location = new System.Drawing.Point(35, 253);
            this.btnFecharodia.Name = "btnFecharodia";
            this.btnFecharodia.Size = new System.Drawing.Size(138, 32);
            this.btnFecharodia.TabIndex = 4;
            this.btnFecharodia.Text = "Fechar o Dia";
            this.btnFecharodia.UseVisualStyleBackColor = false;
            // 
            // fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "fechamento";
            this.Text = "fechamento";
            this.Load += new System.EventHandler(this.fechamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}