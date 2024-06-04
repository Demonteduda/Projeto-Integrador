
namespace tcc
{
    partial class pagamento
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
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtTroco1 = new System.Windows.Forms.TextBox();
            this.txtValorEntregue1 = new System.Windows.Forms.TextBox();
            this.txtTotalPago1 = new System.Windows.Forms.TextBox();
            this.btnConcluirPagamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodigoProduto.Location = new System.Drawing.Point(79, 19);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(165, 22);
            this.lblCodigoProduto.TabIndex = 20;
            this.lblCodigoProduto.Text = "Còdigo da Compra:";
            this.lblCodigoProduto.Click += new System.EventHandler(this.lblCodigoProduto_Click);
            // 
            // txtTroco1
            // 
            this.txtTroco1.Location = new System.Drawing.Point(171, 183);
            this.txtTroco1.Name = "txtTroco1";
            this.txtTroco1.Size = new System.Drawing.Size(178, 20);
            this.txtTroco1.TabIndex = 19;
            // 
            // txtValorEntregue1
            // 
            this.txtValorEntregue1.Location = new System.Drawing.Point(171, 146);
            this.txtValorEntregue1.Name = "txtValorEntregue1";
            this.txtValorEntregue1.Size = new System.Drawing.Size(178, 20);
            this.txtValorEntregue1.TabIndex = 18;
            this.txtValorEntregue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorEntregue1_KeyPress);
            // 
            // txtTotalPago1
            // 
            this.txtTotalPago1.Location = new System.Drawing.Point(171, 112);
            this.txtTotalPago1.Name = "txtTotalPago1";
            this.txtTotalPago1.Size = new System.Drawing.Size(178, 20);
            this.txtTotalPago1.TabIndex = 17;
            this.txtTotalPago1.TextChanged += new System.EventHandler(this.txtTotalPago_TextChanged_1);
            // 
            // btnConcluirPagamento
            // 
            this.btnConcluirPagamento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConcluirPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConcluirPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirPagamento.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnConcluirPagamento.Location = new System.Drawing.Point(171, 232);
            this.btnConcluirPagamento.Name = "btnConcluirPagamento";
            this.btnConcluirPagamento.Size = new System.Drawing.Size(139, 35);
            this.btnConcluirPagamento.TabIndex = 16;
            this.btnConcluirPagamento.Text = "Concluir Pagamento";
            this.btnConcluirPagamento.UseVisualStyleBackColor = false;
            this.btnConcluirPagamento.Click += new System.EventHandler(this.btnConcluirPagamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Troco:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor entregue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(249, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Finalização do Pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblCodigoProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotalPago1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnConcluirPagamento);
            this.panel1.Controls.Add(this.txtTroco1);
            this.panel1.Controls.Add(this.txtValorEntregue1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(191, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 299);
            this.panel1.TabIndex = 21;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(70, 110);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(95, 20);
            this.lblValorTotal.TabIndex = 20;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tcc.Properties.Resources.imagepagamentto1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(901, 555);
            this.MinimumSize = new System.Drawing.Size(901, 555);
            this.Name = "pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pagamento";
            this.Load += new System.EventHandler(this.pagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtTroco1;
        private System.Windows.Forms.TextBox txtValorEntregue1;
        private System.Windows.Forms.TextBox txtTotalPago1;
        private System.Windows.Forms.Button btnConcluirPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorTotal;
    }
}