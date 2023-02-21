namespace Controle_de_restaurante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPesagem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPesagemFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecoKG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtValorUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TxtCodProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtValorProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(245, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controle de restaurante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValor.Location = new System.Drawing.Point(245, 200);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(175, 34);
            this.TxtValor.TabIndex = 6;
            this.TxtValor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pesagem total (g)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtPesagem
            // 
            this.TxtPesagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPesagem.Location = new System.Drawing.Point(19, 128);
            this.TxtPesagem.Name = "TxtPesagem";
            this.TxtPesagem.Size = new System.Drawing.Size(175, 34);
            this.TxtPesagem.TabIndex = 10;
            this.TxtPesagem.TextChanged += new System.EventHandler(this.TxtPesagem_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(19, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Corrige";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPesagemFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPrecoKG);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtTara);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtPesagem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir produto por peso";
            // 
            // TxtPesagemFinal
            // 
            this.TxtPesagemFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPesagemFinal.Location = new System.Drawing.Point(19, 200);
            this.TxtPesagemFinal.Name = "TxtPesagemFinal";
            this.TxtPesagemFinal.ReadOnly = true;
            this.TxtPesagemFinal.Size = new System.Drawing.Size(175, 34);
            this.TxtPesagemFinal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pesagem Considerada";
            // 
            // TxtPrecoKG
            // 
            this.TxtPrecoKG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecoKG.Location = new System.Drawing.Point(245, 57);
            this.TxtPrecoKG.Name = "TxtPrecoKG";
            this.TxtPrecoKG.Size = new System.Drawing.Size(175, 34);
            this.TxtPrecoKG.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Preço do Kg";
            // 
            // TxtTara
            // 
            this.TxtTara.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTara.Location = new System.Drawing.Point(19, 57);
            this.TxtTara.Name = "TxtTara";
            this.TxtTara.Size = new System.Drawing.Size(175, 34);
            this.TxtTara.TabIndex = 3;
            this.TxtTara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(482, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 453);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de compras";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 408);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nome do restaurante\r\nEndereço\r\nNova Acemão\r\n\r\nNota fiscal\r\n----------------------" +
    "---\r\nProduto   Qtdade.  Preço\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(796, 642);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 53);
            this.button3.TabIndex = 13;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtValorUnitario);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtNomeProduto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.TxtCodProduto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtQuantidade);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtValorProduto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 251);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inserir produto por unidade";
            // 
            // TxtValorUnitario
            // 
            this.TxtValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValorUnitario.Location = new System.Drawing.Point(123, 128);
            this.TxtValorUnitario.Name = "TxtValorUnitario";
            this.TxtValorUnitario.Size = new System.Drawing.Size(100, 34);
            this.TxtValorUnitario.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Valor Unitário";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNomeProduto.Location = new System.Drawing.Point(219, 57);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(201, 34);
            this.TxtNomeProduto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Produto";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(19, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 53);
            this.button4.TabIndex = 12;
            this.button4.Text = "Corrige";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LawnGreen;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(245, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 53);
            this.button5.TabIndex = 0;
            this.button5.Text = "Confirma";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // TxtCodProduto
            // 
            this.TxtCodProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodProduto.Location = new System.Drawing.Point(19, 57);
            this.TxtCodProduto.Name = "TxtCodProduto";
            this.TxtCodProduto.Size = new System.Drawing.Size(175, 34);
            this.TxtCodProduto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantidade";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtQuantidade.Location = new System.Drawing.Point(19, 128);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(87, 34);
            this.TxtQuantidade.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Código";
            // 
            // TxtValorProduto
            // 
            this.TxtValorProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValorProduto.Location = new System.Drawing.Point(245, 128);
            this.TxtValorProduto.Name = "TxtValorProduto";
            this.TxtValorProduto.Size = new System.Drawing.Size(175, 34);
            this.TxtValorProduto.TabIndex = 6;
            this.TxtValorProduto.TextChanged += new System.EventHandler(this.TxtValorProduto_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "DESCONTO";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDesconto.Location = new System.Drawing.Point(482, 594);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(175, 34);
            this.TxtDesconto.TabIndex = 15;
            this.TxtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "SUBTOTAL";
            this.label13.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSubtotal.Location = new System.Drawing.Point(482, 532);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(175, 34);
            this.TxtSubtotal.TabIndex = 15;
            this.TxtSubtotal.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(712, 531);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "TOTAL";
            this.label14.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTotal.Location = new System.Drawing.Point(712, 554);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(175, 43);
            this.TxtTotal.TabIndex = 15;
            this.TxtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(656, 642);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 53);
            this.button6.TabIndex = 20;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 666);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "©2023 Guilherme Pilz Moreira";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 24);
            this.toolStripButton1.Text = "Mod. Fonte Nota";
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controle de Restaurante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label4;
        private TextBox TxtValor;
        private Label label6;
        private TextBox TxtPesagem;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox TxtPrecoKG;
        private Label label9;
        private TextBox TxtTara;
        private Label label2;
        private TextBox TxtPesagemFinal;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox TxtValorUnitario;
        private Label label5;
        private TextBox TxtNomeProduto;
        private Label label7;
        private Button button4;
        private Button button5;
        private TextBox TxtCodProduto;
        private Label label8;
        private TextBox TxtQuantidade;
        private Label label10;
        private TextBox TxtValorProduto;
        private Label label12;
        private Label label11;
        private TextBox TxtDesconto;
        private Label label13;
        private TextBox TxtSubtotal;
        private Label label14;
        private TextBox TxtTotal;
        private Button button6;
        private Label label15;
        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}