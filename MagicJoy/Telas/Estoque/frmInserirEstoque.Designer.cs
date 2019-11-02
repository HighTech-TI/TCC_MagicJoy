namespace MagicJoy.Telas.Estoque
{
    partial class frmInserirEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtds = new System.Windows.Forms.TextBox();
            this.txtvlcusto = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.nudidforncedor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidforncedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor de custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id do forncedor:";
            // 
            // txtqtds
            // 
            this.txtqtds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqtds.Location = new System.Drawing.Point(135, 88);
            this.txtqtds.Name = "txtqtds";
            this.txtqtds.Size = new System.Drawing.Size(100, 20);
            this.txtqtds.TabIndex = 21;
            // 
            // txtvlcusto
            // 
            this.txtvlcusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvlcusto.Location = new System.Drawing.Point(135, 125);
            this.txtvlcusto.Name = "txtvlcusto";
            this.txtvlcusto.Size = new System.Drawing.Size(100, 20);
            this.txtvlcusto.TabIndex = 24;
            // 
            // txtproduto
            // 
            this.txtproduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproduto.Location = new System.Drawing.Point(135, 50);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(160, 20);
            this.txtproduto.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 255);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(21, 232);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(103, 41);
            this.btnsalvar.TabIndex = 28;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // nudidforncedor
            // 
            this.nudidforncedor.Location = new System.Drawing.Point(135, 169);
            this.nudidforncedor.Name = "nudidforncedor";
            this.nudidforncedor.Size = new System.Drawing.Size(62, 20);
            this.nudidforncedor.TabIndex = 29;
            // 
            // frmInserirEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 299);
            this.Controls.Add(this.nudidforncedor);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtvlcusto);
            this.Controls.Add(this.txtqtds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirEstoque";
            this.Text = "frmInserirEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidforncedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqtds;
        private System.Windows.Forms.TextBox txtvlcusto;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.NumericUpDown nudidforncedor;
    }
}