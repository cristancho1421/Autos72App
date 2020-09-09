namespace AutosApp72
{
    partial class Vehiculos
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
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label lineaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precio_NetoLabel;
            System.Windows.Forms.Label precio_TotalLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos));
            this.autos72DataSet = new AutosApp72.Autos72DataSet();
            this.insVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insVehiculoTableAdapter = new AutosApp72.Autos72DataSetTableAdapters.InsVehiculoTableAdapter();
            this.tableAdapterManager = new AutosApp72.Autos72DataSetTableAdapters.TableAdapterManager();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.lineaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precio_NetoTextBox = new System.Windows.Forms.TextBox();
            this.precio_TotalTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.consVehXMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consVehXMarcaTableAdapter = new AutosApp72.Autos72DataSetTableAdapters.ConsVehXMarcaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.marcacomboBox = new System.Windows.Forms.ComboBox();
            this.consVehXMarcaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consVehiculoTableAdapter = new AutosApp72.Autos72DataSetTableAdapters.ConsVehiculoTableAdapter();
            this.consVehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.insVehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            lineaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precio_NetoLabel = new System.Windows.Forms.Label();
            precio_TotalLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autos72DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehXMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehXMarcaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehiculoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insVehiculoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(14, 44);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(57, 20);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(14, 76);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(65, 20);
            modeloLabel.TabIndex = 5;
            modeloLabel.Text = "Modelo:";
            // 
            // lineaLabel
            // 
            lineaLabel.AutoSize = true;
            lineaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lineaLabel.Location = new System.Drawing.Point(14, 108);
            lineaLabel.Name = "lineaLabel";
            lineaLabel.Size = new System.Drawing.Size(52, 20);
            lineaLabel.TabIndex = 7;
            lineaLabel.Text = "Linea:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(14, 140);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(96, 20);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precio_NetoLabel
            // 
            precio_NetoLabel.AutoSize = true;
            precio_NetoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_NetoLabel.Location = new System.Drawing.Point(14, 350);
            precio_NetoLabel.Name = "precio_NetoLabel";
            precio_NetoLabel.Size = new System.Drawing.Size(95, 20);
            precio_NetoLabel.TabIndex = 11;
            precio_NetoLabel.Text = "Precio Neto:";
            // 
            // precio_TotalLabel
            // 
            precio_TotalLabel.AutoSize = true;
            precio_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_TotalLabel.Location = new System.Drawing.Point(14, 382);
            precio_TotalLabel.Name = "precio_TotalLabel";
            precio_TotalLabel.Size = new System.Drawing.Size(96, 20);
            precio_TotalLabel.TabIndex = 13;
            precio_TotalLabel.Text = "Precio Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(294, 353);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(185, 20);
            label1.TabIndex = 56;
            label1.Text = "Busqueda por Marca: ";
            // 
            // autos72DataSet
            // 
            this.autos72DataSet.DataSetName = "Autos72DataSet";
            this.autos72DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insVehiculoBindingSource
            // 
            this.insVehiculoBindingSource.DataMember = "InsVehiculo";
            this.insVehiculoBindingSource.DataSource = this.autos72DataSet;
            // 
            // insVehiculoTableAdapter
            // 
            this.insVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.RevisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutosApp72.Autos72DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(112, 73);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(158, 26);
            this.modeloTextBox.TabIndex = 6;
            // 
            // lineaTextBox
            // 
            this.lineaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineaTextBox.Location = new System.Drawing.Point(112, 105);
            this.lineaTextBox.Name = "lineaTextBox";
            this.lineaTextBox.Size = new System.Drawing.Size(158, 26);
            this.lineaTextBox.TabIndex = 8;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(18, 163);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(252, 178);
            this.descripcionTextBox.TabIndex = 10;
            this.descripcionTextBox.Text = "Motor:\r\nPotencia (HP):\r\nLlantas:\r\nNro. de Cilindros:\r\nNro de Valvulas:\r\nTorque: \r" +
    "\nTraccion: ";
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.descripcionTextBox_TextChanged);
            // 
            // precio_NetoTextBox
            // 
            this.precio_NetoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_NetoTextBox.Location = new System.Drawing.Point(112, 347);
            this.precio_NetoTextBox.Name = "precio_NetoTextBox";
            this.precio_NetoTextBox.Size = new System.Drawing.Size(158, 26);
            this.precio_NetoTextBox.TabIndex = 12;
            this.precio_NetoTextBox.TextChanged += new System.EventHandler(this.precio_NetoTextBox_TextChanged);
            // 
            // precio_TotalTextBox
            // 
            this.precio_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_TotalTextBox.Location = new System.Drawing.Point(112, 379);
            this.precio_TotalTextBox.Name = "precio_TotalTextBox";
            this.precio_TotalTextBox.Size = new System.Drawing.Size(158, 26);
            this.precio_TotalTextBox.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(112, 411);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(756, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "ir a Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consVehXMarcaBindingSource
            // 
            this.consVehXMarcaBindingSource.DataMember = "ConsVehXMarca";
            this.consVehXMarcaBindingSource.DataSource = this.autos72DataSet;
            // 
            // consVehXMarcaTableAdapter
            // 
            this.consVehXMarcaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Audi",
            "Chevrolet",
            "Kia",
            "Renault",
            "Toyota",
            "Mazda",
            "Mitsubishi",
            "Honda",
            "Mercedez Benz"});
            this.comboBox1.Location = new System.Drawing.Point(485, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // marcacomboBox
            // 
            this.marcacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcacomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcacomboBox.FormattingEnabled = true;
            this.marcacomboBox.Items.AddRange(new object[] {
            "Audi",
            "Chevrolet",
            "Kia",
            "Renault",
            "Toyota",
            "Mazda",
            "Mitsubishi",
            "Honda",
            "Mercedez Benz"});
            this.marcacomboBox.Location = new System.Drawing.Point(112, 41);
            this.marcacomboBox.Name = "marcacomboBox";
            this.marcacomboBox.Size = new System.Drawing.Size(158, 28);
            this.marcacomboBox.TabIndex = 55;
            // 
            // consVehXMarcaDataGridView
            // 
            this.consVehXMarcaDataGridView.AllowUserToAddRows = false;
            this.consVehXMarcaDataGridView.AllowUserToDeleteRows = false;
            this.consVehXMarcaDataGridView.AutoGenerateColumns = false;
            this.consVehXMarcaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.consVehXMarcaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consVehXMarcaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.consVehXMarcaDataGridView.DataSource = this.consVehXMarcaBindingSource;
            this.consVehXMarcaDataGridView.Location = new System.Drawing.Point(276, 41);
            this.consVehXMarcaDataGridView.Name = "consVehXMarcaDataGridView";
            this.consVehXMarcaDataGridView.ReadOnly = true;
            this.consVehXMarcaDataGridView.Size = new System.Drawing.Size(651, 300);
            this.consVehXMarcaDataGridView.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn7.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Linea";
            this.dataGridViewTextBoxColumn9.HeaderText = "Linea";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Precio_Neto";
            this.dataGridViewTextBoxColumn11.HeaderText = "Precio_Neto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Precio_Total";
            this.dataGridViewTextBoxColumn12.HeaderText = "Precio_Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // consVehiculoBindingSource
            // 
            this.consVehiculoBindingSource.DataMember = "ConsVehiculo";
            this.consVehiculoBindingSource.DataSource = this.autos72DataSet;
            // 
            // consVehiculoTableAdapter
            // 
            this.consVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // consVehiculoDataGridView
            // 
            this.consVehiculoDataGridView.AllowUserToAddRows = false;
            this.consVehiculoDataGridView.AllowUserToDeleteRows = false;
            this.consVehiculoDataGridView.AutoGenerateColumns = false;
            this.consVehiculoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.consVehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consVehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.consVehiculoDataGridView.DataSource = this.consVehiculoBindingSource;
            this.consVehiculoDataGridView.Location = new System.Drawing.Point(276, 41);
            this.consVehiculoDataGridView.Name = "consVehiculoDataGridView";
            this.consVehiculoDataGridView.ReadOnly = true;
            this.consVehiculoDataGridView.Size = new System.Drawing.Size(651, 300);
            this.consVehiculoDataGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Linea";
            this.dataGridViewTextBoxColumn3.HeaderText = "Linea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio_Neto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio_Neto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio_Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio_Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(769, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 33);
            this.button2.TabIndex = 57;
            this.button2.Text = "Mostrar Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insVehiculoDataGridView
            // 
            this.insVehiculoDataGridView.AllowUserToAddRows = false;
            this.insVehiculoDataGridView.AllowUserToDeleteRows = false;
            this.insVehiculoDataGridView.AutoGenerateColumns = false;
            this.insVehiculoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.insVehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insVehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.insVehiculoDataGridView.DataSource = this.insVehiculoBindingSource;
            this.insVehiculoDataGridView.Location = new System.Drawing.Point(276, 41);
            this.insVehiculoDataGridView.Name = "insVehiculoDataGridView";
            this.insVehiculoDataGridView.ReadOnly = true;
            this.insVehiculoDataGridView.Size = new System.Drawing.Size(651, 300);
            this.insVehiculoDataGridView.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn13.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn14.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Linea";
            this.dataGridViewTextBoxColumn15.HeaderText = "Linea";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn16.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Precio_Neto";
            this.dataGridViewTextBoxColumn17.HeaderText = "Precio_Neto";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Precio_Total";
            this.dataGridViewTextBoxColumn18.HeaderText = "Precio_Total";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(14, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(316, 20);
            label2.TabIndex = 58;
            label2.Text = "Agregar nueva referencia de Vehiculo ";
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(label1);
            this.Controls.Add(this.marcacomboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(lineaLabel);
            this.Controls.Add(this.lineaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precio_NetoLabel);
            this.Controls.Add(this.precio_NetoTextBox);
            this.Controls.Add(precio_TotalLabel);
            this.Controls.Add(this.precio_TotalTextBox);
            this.Controls.Add(this.consVehiculoDataGridView);
            this.Controls.Add(this.consVehXMarcaDataGridView);
            this.Controls.Add(this.insVehiculoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autos 72 - Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autos72DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehXMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehXMarcaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consVehiculoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insVehiculoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Autos72DataSet autos72DataSet;
        private System.Windows.Forms.BindingSource insVehiculoBindingSource;
        private Autos72DataSetTableAdapters.InsVehiculoTableAdapter insVehiculoTableAdapter;
        private Autos72DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox lineaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox precio_NetoTextBox;
        private System.Windows.Forms.TextBox precio_TotalTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource consVehXMarcaBindingSource;
        private Autos72DataSetTableAdapters.ConsVehXMarcaTableAdapter consVehXMarcaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox marcacomboBox;
        private System.Windows.Forms.DataGridView consVehXMarcaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource consVehiculoBindingSource;
        private Autos72DataSetTableAdapters.ConsVehiculoTableAdapter consVehiculoTableAdapter;
        private System.Windows.Forms.DataGridView consVehiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView insVehiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}