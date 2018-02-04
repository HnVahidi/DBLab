namespace DataBaseLabrator.UI.OrderActions
{
    partial class OrderDetails
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
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promisedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspberryDataSet = new DataBaseLabrator.RaspberryDataSet();
            this.orderDetailsTableAdapter = new DataBaseLabrator.RaspberryDataSetTableAdapters.OrderDetailsTableAdapter();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.orderIdtextBox = new System.Windows.Forms.TextBox();
            this.customerIdtextBox = new System.Windows.Forms.TextBox();
            this.empIdtextBox = new System.Windows.Forms.TextBox();
            this.statustextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.orderdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.promiseddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipmentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.orderTDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.empDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.promisedDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.shipmentDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(523, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product#";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product#";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // orderTDataGridViewTextBoxColumn
            // 
            this.orderTDataGridViewTextBoxColumn.DataPropertyName = "OrderT#";
            this.orderTDataGridViewTextBoxColumn.HeaderText = "OrderT#";
            this.orderTDataGridViewTextBoxColumn.Name = "orderTDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer#";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer#";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // empDataGridViewTextBoxColumn
            // 
            this.empDataGridViewTextBoxColumn.DataPropertyName = "Emp#";
            this.empDataGridViewTextBoxColumn.HeaderText = "Emp#";
            this.empDataGridViewTextBoxColumn.Name = "empDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // promisedDateDataGridViewTextBoxColumn
            // 
            this.promisedDateDataGridViewTextBoxColumn.DataPropertyName = "PromisedDate";
            this.promisedDateDataGridViewTextBoxColumn.HeaderText = "PromisedDate";
            this.promisedDateDataGridViewTextBoxColumn.Name = "promisedDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status#";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status#";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // shipmentDateDataGridViewTextBoxColumn
            // 
            this.shipmentDateDataGridViewTextBoxColumn.DataPropertyName = "ShipmentDate";
            this.shipmentDateDataGridViewTextBoxColumn.HeaderText = "ShipmentDate";
            this.shipmentDateDataGridViewTextBoxColumn.Name = "shipmentDateDataGridViewTextBoxColumn";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.raspberryDataSet;
            // 
            // raspberryDataSet
            // 
            this.raspberryDataSet.DataSetName = "RaspberryDataSet";
            this.raspberryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(142, 29);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIdTextBox.TabIndex = 1;
            // 
            // orderIdtextBox
            // 
            this.orderIdtextBox.Location = new System.Drawing.Point(142, 70);
            this.orderIdtextBox.Name = "orderIdtextBox";
            this.orderIdtextBox.Size = new System.Drawing.Size(100, 22);
            this.orderIdtextBox.TabIndex = 2;
            // 
            // customerIdtextBox
            // 
            this.customerIdtextBox.Location = new System.Drawing.Point(142, 115);
            this.customerIdtextBox.Name = "customerIdtextBox";
            this.customerIdtextBox.Size = new System.Drawing.Size(100, 22);
            this.customerIdtextBox.TabIndex = 3;
            // 
            // empIdtextBox
            // 
            this.empIdtextBox.Location = new System.Drawing.Point(142, 161);
            this.empIdtextBox.Name = "empIdtextBox";
            this.empIdtextBox.Size = new System.Drawing.Size(100, 22);
            this.empIdtextBox.TabIndex = 4;
            // 
            // statustextBox
            // 
            this.statustextBox.Location = new System.Drawing.Point(142, 306);
            this.statustextBox.Name = "statustextBox";
            this.statustextBox.Size = new System.Drawing.Size(100, 22);
            this.statustextBox.TabIndex = 5;
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(142, 347);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(100, 22);
            this.quantitytextBox.TabIndex = 6;
            // 
            // orderdateTimePicker
            // 
            this.orderdateTimePicker.Location = new System.Drawing.Point(142, 220);
            this.orderdateTimePicker.Name = "orderdateTimePicker";
            this.orderdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.orderdateTimePicker.TabIndex = 7;
            // 
            // promiseddateTimePicker
            // 
            this.promiseddateTimePicker.Location = new System.Drawing.Point(142, 257);
            this.promiseddateTimePicker.Name = "promiseddateTimePicker";
            this.promiseddateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.promiseddateTimePicker.TabIndex = 8;
            // 
            // shipmentdateTimePicker
            // 
            this.shipmentdateTimePicker.Location = new System.Drawing.Point(142, 392);
            this.shipmentdateTimePicker.Name = "shipmentdateTimePicker";
            this.shipmentdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.shipmentdateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Order Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Promised Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Shipment Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Find by p# and o#";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(414, 467);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(103, 42);
            this.refreshbutton.TabIndex = 20;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(305, 467);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(103, 42);
            this.insertbutton.TabIndex = 21;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(196, 467);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(103, 42);
            this.updatebutton.TabIndex = 22;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(87, 467);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(103, 42);
            this.deletebutton.TabIndex = 23;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 521);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipmentdateTimePicker);
            this.Controls.Add(this.promiseddateTimePicker);
            this.Controls.Add(this.orderdateTimePicker);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.statustextBox);
            this.Controls.Add(this.empIdtextBox);
            this.Controls.Add(this.customerIdtextBox);
            this.Controls.Add(this.orderIdtextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspberryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RaspberryDataSet raspberryDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private RaspberryDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promisedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox orderIdtextBox;
        private System.Windows.Forms.TextBox customerIdtextBox;
        private System.Windows.Forms.TextBox empIdtextBox;
        private System.Windows.Forms.TextBox statustextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.DateTimePicker orderdateTimePicker;
        private System.Windows.Forms.DateTimePicker promiseddateTimePicker;
        private System.Windows.Forms.DateTimePicker shipmentdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
    }
}