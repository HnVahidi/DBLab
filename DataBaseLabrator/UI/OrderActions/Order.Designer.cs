namespace DataBaseLabrator.UI.OrderActions
{
    partial class Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRaisedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspberryDataSet = new DataBaseLabrator.RaspberryDataSet();
            this.orderTTableAdapter = new DataBaseLabrator.RaspberryDataSetTableAdapters.orderTTableAdapter();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.invoicetextBox = new System.Windows.Forms.TextBox();
            this.paymenttextBox = new System.Windows.Forms.TextBox();
            this.shipmenttextBox = new System.Windows.Forms.TextBox();
            this.raiseddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.paiddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.GetInfoTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderTDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.dateRaisedDataGridViewTextBoxColumn,
            this.datePaidDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.shipmentMethodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(463, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 421);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderTDataGridViewTextBoxColumn
            // 
            this.orderTDataGridViewTextBoxColumn.DataPropertyName = "OrderT#";
            this.orderTDataGridViewTextBoxColumn.HeaderText = "OrderT#";
            this.orderTDataGridViewTextBoxColumn.Name = "orderTDataGridViewTextBoxColumn";
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "invoice#";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "invoice#";
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            // 
            // dateRaisedDataGridViewTextBoxColumn
            // 
            this.dateRaisedDataGridViewTextBoxColumn.DataPropertyName = "DateRaised";
            this.dateRaisedDataGridViewTextBoxColumn.HeaderText = "DateRaised";
            this.dateRaisedDataGridViewTextBoxColumn.Name = "dateRaisedDataGridViewTextBoxColumn";
            // 
            // datePaidDataGridViewTextBoxColumn
            // 
            this.datePaidDataGridViewTextBoxColumn.DataPropertyName = "DatePaid";
            this.datePaidDataGridViewTextBoxColumn.HeaderText = "DatePaid";
            this.datePaidDataGridViewTextBoxColumn.Name = "datePaidDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod#";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod#";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // shipmentMethodDataGridViewTextBoxColumn
            // 
            this.shipmentMethodDataGridViewTextBoxColumn.DataPropertyName = "ShipmentMethod#";
            this.shipmentMethodDataGridViewTextBoxColumn.HeaderText = "ShipmentMethod#";
            this.shipmentMethodDataGridViewTextBoxColumn.Name = "shipmentMethodDataGridViewTextBoxColumn";
            // 
            // orderTBindingSource
            // 
            this.orderTBindingSource.DataMember = "orderT";
            this.orderTBindingSource.DataSource = this.raspberryDataSet;
            // 
            // raspberryDataSet
            // 
            this.raspberryDataSet.DataSetName = "RaspberryDataSet";
            this.raspberryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTTableAdapter
            // 
            this.orderTTableAdapter.ClearBeforeFill = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(242, 473);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 37);
            this.insertBtn.TabIndex = 33;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(147, 472);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 38);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(39, 471);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 38);
            this.deleteBtn.TabIndex = 35;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(274, 74);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(130, 37);
            this.findBtn.TabIndex = 36;
            this.findBtn.Text = "Find by id";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(161, 81);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 37;
            // 
            // invoicetextBox
            // 
            this.invoicetextBox.Location = new System.Drawing.Point(161, 143);
            this.invoicetextBox.Name = "invoicetextBox";
            this.invoicetextBox.Size = new System.Drawing.Size(100, 22);
            this.invoicetextBox.TabIndex = 38;
            // 
            // paymenttextBox
            // 
            this.paymenttextBox.Location = new System.Drawing.Point(160, 292);
            this.paymenttextBox.Name = "paymenttextBox";
            this.paymenttextBox.Size = new System.Drawing.Size(100, 22);
            this.paymenttextBox.TabIndex = 39;
            // 
            // shipmenttextBox
            // 
            this.shipmenttextBox.Location = new System.Drawing.Point(160, 360);
            this.shipmenttextBox.Name = "shipmenttextBox";
            this.shipmenttextBox.Size = new System.Drawing.Size(100, 22);
            this.shipmenttextBox.TabIndex = 40;
            // 
            // raiseddateTimePicker1
            // 
            this.raiseddateTimePicker1.Location = new System.Drawing.Point(160, 196);
            this.raiseddateTimePicker1.Name = "raiseddateTimePicker1";
            this.raiseddateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.raiseddateTimePicker1.TabIndex = 41;
            // 
            // paiddateTimePicker1
            // 
            this.paiddateTimePicker1.Location = new System.Drawing.Point(160, 245);
            this.paiddateTimePicker1.Name = "paiddateTimePicker1";
            this.paiddateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.paiddateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Order id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Invoice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date Raised";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date Paid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Shipment Method";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(342, 473);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(94, 37);
            this.refreshBtn.TabIndex = 49;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // GetInfoTextBox
            // 
            this.GetInfoTextBox.Location = new System.Drawing.Point(342, 379);
            this.GetInfoTextBox.Name = "GetInfoTextBox";
            this.GetInfoTextBox.Size = new System.Drawing.Size(75, 23);
            this.GetInfoTextBox.TabIndex = 50;
            this.GetInfoTextBox.Text = "Get Info";
            this.GetInfoTextBox.UseVisualStyleBackColor = true;
            this.GetInfoTextBox.Click += new System.EventHandler(this.GetInfoTextBox_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 521);
            this.Controls.Add(this.GetInfoTextBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paiddateTimePicker1);
            this.Controls.Add(this.raiseddateTimePicker1);
            this.Controls.Add(this.shipmenttextBox);
            this.Controls.Add(this.paymenttextBox);
            this.Controls.Add(this.invoicetextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private RaspberryDataSet raspberryDataSet;
        private System.Windows.Forms.BindingSource orderTBindingSource;
        private RaspberryDataSetTableAdapters.orderTTableAdapter orderTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRaisedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox invoicetextBox;
        private System.Windows.Forms.TextBox paymenttextBox;
        private System.Windows.Forms.TextBox shipmenttextBox;
        private System.Windows.Forms.DateTimePicker raiseddateTimePicker1;
        private System.Windows.Forms.DateTimePicker paiddateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button GetInfoTextBox;
    }
}