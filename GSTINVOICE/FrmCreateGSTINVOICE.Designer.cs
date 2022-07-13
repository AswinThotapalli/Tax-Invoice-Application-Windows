namespace GSTINVOICE
{
    partial class FrmCreateGSTINVOICE
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.txtinvoicedate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hsccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxableval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgstamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sgstamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSgstAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotalinvoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotaldiscounts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalTaxval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalCgst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalsgst = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create GST Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(177, 175);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(147, 23);
            this.txtInvoice.TabIndex = 0;
            this.txtInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoice_KeyDown);
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.Location = new System.Drawing.Point(890, 175);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(147, 23);
            this.txtinvoicedate.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invoice date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(456, 174);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(251, 23);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodDesc,
            this.Hsccode,
            this.Quantity,
            this.Rate,
            this.totalsale,
            this.Discount,
            this.Taxableval,
            this.cgst,
            this.cgstamount,
            this.Sgstamount,
            this.grdSgstAmount,
            this.catid,
            this.RowId});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(69, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 249);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // goodDesc
            // 
            this.goodDesc.HeaderText = "Description of Goods";
            this.goodDesc.MinimumWidth = 6;
            this.goodDesc.Name = "goodDesc";
            this.goodDesc.Width = 250;
            // 
            // Hsccode
            // 
            this.Hsccode.HeaderText = "HSE/SAC Code";
            this.Hsccode.MinimumWidth = 6;
            this.Hsccode.Name = "Hsccode";
            this.Hsccode.ReadOnly = true;
            this.Hsccode.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty.";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.Width = 125;
            // 
            // totalsale
            // 
            this.totalsale.HeaderText = "Total Sale";
            this.totalsale.MinimumWidth = 6;
            this.totalsale.Name = "totalsale";
            this.totalsale.ReadOnly = true;
            this.totalsale.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount%";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Taxableval
            // 
            this.Taxableval.HeaderText = "Taxable Value";
            this.Taxableval.MinimumWidth = 6;
            this.Taxableval.Name = "Taxableval";
            this.Taxableval.ReadOnly = true;
            this.Taxableval.Width = 125;
            // 
            // cgst
            // 
            this.cgst.HeaderText = "CGST Rate %";
            this.cgst.MinimumWidth = 6;
            this.cgst.Name = "cgst";
            this.cgst.ReadOnly = true;
            this.cgst.Width = 50;
            // 
            // cgstamount
            // 
            this.cgstamount.HeaderText = "Amount";
            this.cgstamount.MinimumWidth = 6;
            this.cgstamount.Name = "cgstamount";
            this.cgstamount.ReadOnly = true;
            this.cgstamount.Width = 125;
            // 
            // Sgstamount
            // 
            this.Sgstamount.HeaderText = "SGST Rate %";
            this.Sgstamount.MinimumWidth = 6;
            this.Sgstamount.Name = "Sgstamount";
            this.Sgstamount.ReadOnly = true;
            this.Sgstamount.Width = 50;
            // 
            // grdSgstAmount
            // 
            this.grdSgstAmount.HeaderText = "Amount";
            this.grdSgstAmount.MinimumWidth = 6;
            this.grdSgstAmount.Name = "grdSgstAmount";
            this.grdSgstAmount.ReadOnly = true;
            this.grdSgstAmount.Width = 125;
            // 
            // catid
            // 
            this.catid.HeaderText = "Column1";
            this.catid.MinimumWidth = 6;
            this.catid.Name = "catid";
            this.catid.ReadOnly = true;
            this.catid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catid.Width = 6;
            // 
            // RowId
            // 
            this.RowId.HeaderText = "RowID";
            this.RowId.MinimumWidth = 6;
            this.RowId.Name = "RowId";
            this.RowId.Width = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(996, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1144, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Amount";
            // 
            // txttotalinvoice
            // 
            this.txttotalinvoice.Location = new System.Drawing.Point(1149, 497);
            this.txttotalinvoice.Name = "txttotalinvoice";
            this.txttotalinvoice.ReadOnly = true;
            this.txttotalinvoice.Size = new System.Drawing.Size(143, 23);
            this.txttotalinvoice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(997, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total Invoice value";
            // 
            // txttotaldiscounts
            // 
            this.txttotaldiscounts.Location = new System.Drawing.Point(1149, 523);
            this.txttotaldiscounts.Name = "txttotaldiscounts";
            this.txttotaldiscounts.ReadOnly = true;
            this.txttotaldiscounts.Size = new System.Drawing.Size(143, 23);
            this.txttotaldiscounts.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(997, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total Discounts";
            // 
            // txttotalTaxval
            // 
            this.txttotalTaxval.Location = new System.Drawing.Point(1149, 549);
            this.txttotalTaxval.Name = "txttotalTaxval";
            this.txttotalTaxval.ReadOnly = true;
            this.txttotalTaxval.Size = new System.Drawing.Size(143, 23);
            this.txttotalTaxval.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(997, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total Taxable Value";
            // 
            // txttotalCgst
            // 
            this.txttotalCgst.Location = new System.Drawing.Point(1149, 575);
            this.txttotalCgst.Name = "txttotalCgst";
            this.txttotalCgst.ReadOnly = true;
            this.txttotalCgst.Size = new System.Drawing.Size(143, 23);
            this.txttotalCgst.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(997, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total CGST";
            // 
            // txttotalsgst
            // 
            this.txttotalsgst.Location = new System.Drawing.Point(1149, 601);
            this.txttotalsgst.Name = "txttotalsgst";
            this.txttotalsgst.ReadOnly = true;
            this.txttotalsgst.Size = new System.Drawing.Size(143, 23);
            this.txttotalsgst.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(997, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total SGST";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(1149, 627);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(143, 23);
            this.txtgrandtotal.TabIndex = 152;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(997, 630);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Grand Total";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 52);
            this.button2.TabIndex = 154;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 569);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 52);
            this.button3.TabIndex = 155;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 52);
            this.button4.TabIndex = 156;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1077, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 23);
            this.dateTimePicker2.TabIndex = 157;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // FrmCreateGSTINVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1550, 822);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttotalsgst);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttotalCgst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttotalTaxval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttotaldiscounts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttotalinvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtinvoicedate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateGSTINVOICE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCreateGSTINVOICE";
            this.Load += new System.EventHandler(this.FrmCreateGSTINVOICE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.TextBox txtinvoicedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotalinvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotaldiscounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotalTaxval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalCgst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalsgst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hsccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxableval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgstamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sgstamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdSgstAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowId;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}