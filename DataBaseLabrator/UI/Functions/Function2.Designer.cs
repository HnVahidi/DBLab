namespace DataBaseLabrator.UI.Functions
{
    partial class Function2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raspberryDataSet = new DataBaseLabrator.RaspberryDataSet();
            this.orderTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTTableAdapter = new DataBaseLabrator.RaspberryDataSetTableAdapters.orderTTableAdapter();
            this.orderTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRaisedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Date Difference";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(248, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 440);
            this.dataGridView1.TabIndex = 4;
            // 
            // raspberryDataSet
            // 
            this.raspberryDataSet.DataSetName = "RaspberryDataSet";
            this.raspberryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTBindingSource
            // 
            this.orderTBindingSource.DataMember = "orderT";
            this.orderTBindingSource.DataSource = this.raspberryDataSet;
            // 
            // orderTTableAdapter
            // 
            this.orderTTableAdapter.ClearBeforeFill = true;
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
            // Function2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Function2";
            this.Text = "Function2";
            this.Load += new System.EventHandler(this.Function2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
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
    }
}