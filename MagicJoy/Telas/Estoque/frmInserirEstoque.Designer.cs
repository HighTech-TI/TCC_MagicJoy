﻿namespace MagicJoy.Telas.Estoque
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
            this.id_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_custp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ds_remover = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.nudidforncedor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidestoque = new System.Windows.Forms.TextBox();
            this.txtpesquisaproduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtdpesquisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidestoquepesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidforncedor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor de custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id do forncedor:";
            // 
            // txtqtds
            // 
            this.txtqtds.Location = new System.Drawing.Point(153, 147);
            this.txtqtds.Name = "txtqtds";
            this.txtqtds.Size = new System.Drawing.Size(100, 20);
            this.txtqtds.TabIndex = 21;
            // 
            // txtvlcusto
            // 
            this.txtvlcusto.Location = new System.Drawing.Point(166, 184);
            this.txtvlcusto.Name = "txtvlcusto";
            this.txtvlcusto.Size = new System.Drawing.Size(100, 20);
            this.txtvlcusto.TabIndex = 24;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(130, 111);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(160, 20);
            this.txtproduto.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estoque,
            this.nm_produto,
            this.ds_qtd,
            this.vl_custp,
            this.id_fornecedor,
            this.ds_image,
            this.ds_remover});
            this.dataGridView1.Location = new System.Drawing.Point(329, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 255);
            this.dataGridView1.TabIndex = 26;
            // 
            // id_estoque
            // 
            this.id_estoque.DataPropertyName = "id_estoque";
            this.id_estoque.HeaderText = "ID estque";
            this.id_estoque.Name = "id_estoque";
            // 
            // nm_produto
            // 
            this.nm_produto.DataPropertyName = "nm_produto";
            this.nm_produto.HeaderText = "Produto";
            this.nm_produto.Name = "nm_produto";
            // 
            // ds_qtd
            // 
            this.ds_qtd.DataPropertyName = "ds_qtd";
            this.ds_qtd.HeaderText = "Quantidade";
            this.ds_qtd.Name = "ds_qtd";
            // 
            // vl_custp
            // 
            this.vl_custp.DataPropertyName = "vl_custo";
            this.vl_custp.HeaderText = "Preço de Custo";
            this.vl_custp.Name = "vl_custp";
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.DataPropertyName = "id_fornecedor";
            this.id_fornecedor.HeaderText = "ID fornecedor";
            this.id_fornecedor.Name = "id_fornecedor";
            // 
            // ds_image
            // 
            this.ds_image.HeaderText = "Editar";
            this.ds_image.Image = global::MagicJoy.Properties.Resources.edit_icon_2375785_960_720;
            this.ds_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ds_image.Name = "ds_image";
            this.ds_image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ds_image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ds_image.Width = 52;
            // 
            // ds_remover
            // 
            this.ds_remover.HeaderText = "Remover";
            this.ds_remover.Image = global::MagicJoy.Properties.Resources.depositphotos_126646752_stock_illustration_the_trashcan_icon_dustbin_symbol;
            this.ds_remover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ds_remover.Name = "ds_remover";
            this.ds_remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ds_remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ds_remover.Width = 52;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Ananda", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(10, 303);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(114, 45);
            this.btnsalvar.TabIndex = 28;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // nudidforncedor
            // 
            this.nudidforncedor.Location = new System.Drawing.Point(191, 218);
            this.nudidforncedor.Name = "nudidforncedor";
            this.nudidforncedor.Size = new System.Drawing.Size(62, 20);
            this.nudidforncedor.TabIndex = 29;
            this.nudidforncedor.ValueChanged += new System.EventHandler(this.nudidforncedor_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID estoque:";
            // 
            // txtidestoque
            // 
            this.txtidestoque.Enabled = false;
            this.txtidestoque.Location = new System.Drawing.Point(155, 79);
            this.txtidestoque.Name = "txtidestoque";
            this.txtidestoque.Size = new System.Drawing.Size(53, 20);
            this.txtidestoque.TabIndex = 31;
            // 
            // txtpesquisaproduto
            // 
            this.txtpesquisaproduto.Location = new System.Drawing.Point(442, 313);
            this.txtpesquisaproduto.Name = "txtpesquisaproduto";
            this.txtpesquisaproduto.Size = new System.Drawing.Size(160, 20);
            this.txtpesquisaproduto.TabIndex = 33;
            this.txtpesquisaproduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Produto:";
            // 
            // txtqtdpesquisa
            // 
            this.txtqtdpesquisa.Location = new System.Drawing.Point(718, 315);
            this.txtqtdpesquisa.Name = "txtqtdpesquisa";
            this.txtqtdpesquisa.Size = new System.Drawing.Size(58, 20);
            this.txtqtdpesquisa.TabIndex = 35;
            this.txtqtdpesquisa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(608, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "ID estoque:";
            // 
            // txtidestoquepesquisa
            // 
            this.txtidestoquepesquisa.Location = new System.Drawing.Point(303, 318);
            this.txtidestoquepesquisa.Name = "txtidestoquepesquisa";
            this.txtidestoquepesquisa.Size = new System.Drawing.Size(43, 20);
            this.txtidestoquepesquisa.TabIndex = 37;
            this.txtidestoquepesquisa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::MagicJoy.Properties.Resources.edit_icon_2375785_960_720;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Remover";
            this.dataGridViewImageColumn2.Image = global::MagicJoy.Properties.Resources.depositphotos_126646752_stock_illustration_the_trashcan_icon_dustbin_symbol;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox24);
            this.panel1.Controls.Add(this.pictureBox26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 32);
            this.panel1.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Splatch", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 26);
            this.label13.TabIndex = 58;
            this.label13.Text = "Inserir Estoque\r\n";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.White;
            this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox24.Image = global::MagicJoy.Properties.Resources.minimizar;
            this.pictureBox24.Location = new System.Drawing.Point(718, 3);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(25, 25);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 56;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.White;
            this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox26.Image = global::MagicJoy.Properties.Resources._130877;
            this.pictureBox26.Location = new System.Drawing.Point(747, 3);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(25, 25);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox26.TabIndex = 57;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.pictureBox26_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MagicJoy.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(687, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInserirEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagicJoy.Properties.Resources.toys_embroidery_beautiful_1029444_wallhere_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidestoquepesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtqtdpesquisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpesquisaproduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidestoque);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.frmInserirEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidforncedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidestoque;
        private System.Windows.Forms.TextBox txtpesquisaproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtdpesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidestoquepesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_custp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedor;
        private System.Windows.Forms.DataGridViewImageColumn ds_image;
        private System.Windows.Forms.DataGridViewImageColumn ds_remover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}