namespace PROYECTO_CINE.FORMULARIOS
{
    partial class SalaDeadPool
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
            this.sillaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaDEADpolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cINEDataSet = new PROYECTO_CINE.CINEDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.suelto = new System.Windows.Forms.Label();
            this.txtSuelto = new System.Windows.Forms.TextBox();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtsilla = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.salaDEADpolTableAdapter = new PROYECTO_CINE.CINEDataSetTableAdapters.salaDEADpolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaDEADpolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sillaIdDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salaDEADpolBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(356, 731);
            this.dataGridView1.TabIndex = 0;
            // 
            // sillaIdDataGridViewTextBoxColumn
            // 
            this.sillaIdDataGridViewTextBoxColumn.DataPropertyName = "SillaId";
            this.sillaIdDataGridViewTextBoxColumn.HeaderText = "SillaId";
            this.sillaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sillaIdDataGridViewTextBoxColumn.Name = "sillaIdDataGridViewTextBoxColumn";
            this.sillaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaDEADpolBindingSource
            // 
            this.salaDEADpolBindingSource.DataMember = "salaDEADpol";
            this.salaDEADpolBindingSource.DataSource = this.cINEDataSet;
            // 
            // cINEDataSet
            // 
            this.cINEDataSet.DataSetName = "CINEDataSet";
            this.cINEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 78);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 78);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 78);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(999, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(937, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 78);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1307, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "6";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1245, 36);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 78);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1458, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "7";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1397, 36);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 78);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1152, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "5";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1091, 36);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 78);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "8";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(631, 123);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 78);
            this.button8.TabIndex = 23;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(846, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "9";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(785, 123);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 78);
            this.button9.TabIndex = 25;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(999, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "10";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(937, 123);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 78);
            this.button10.TabIndex = 27;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1153, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "11";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1092, 123);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(144, 78);
            this.button11.TabIndex = 29;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1307, 131);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "12";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1245, 123);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(144, 78);
            this.button12.TabIndex = 31;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(846, 219);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "13";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(785, 211);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(144, 78);
            this.button13.TabIndex = 33;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(999, 219);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "14";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(937, 211);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(144, 78);
            this.button14.TabIndex = 35;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1152, 219);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "15";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1091, 211);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(144, 78);
            this.button15.TabIndex = 37;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(846, 307);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "16";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(785, 299);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(144, 78);
            this.button16.TabIndex = 39;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(999, 307);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "17";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(937, 299);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(144, 78);
            this.button17.TabIndex = 41;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1152, 307);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "18";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1091, 299);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(144, 78);
            this.button18.TabIndex = 43;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(936, 394);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "19";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(875, 387);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(144, 78);
            this.button19.TabIndex = 45;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1089, 394);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 20);
            this.label21.TabIndex = 50;
            this.label21.Text = "20";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(1027, 387);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(144, 78);
            this.button20.TabIndex = 49;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.suelto);
            this.panel1.Controls.Add(this.txtSuelto);
            this.panel1.Controls.Add(this.txtpago);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.txtPelicula);
            this.panel1.Controls.Add(this.txtsilla);
            this.panel1.Location = new System.Drawing.Point(401, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 275);
            this.panel1.TabIndex = 51;
            this.panel1.TabStop = true;
            // 
            // suelto
            // 
            this.suelto.AutoSize = true;
            this.suelto.Location = new System.Drawing.Point(280, 120);
            this.suelto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suelto.Name = "suelto";
            this.suelto.Size = new System.Drawing.Size(55, 20);
            this.suelto.TabIndex = 11;
            this.suelto.Text = "Suelto";
            // 
            // txtSuelto
            // 
            this.txtSuelto.Enabled = false;
            this.txtSuelto.Location = new System.Drawing.Point(344, 114);
            this.txtSuelto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSuelto.Name = "txtSuelto";
            this.txtSuelto.Size = new System.Drawing.Size(85, 26);
            this.txtSuelto.TabIndex = 10;
            this.txtSuelto.TextChanged += new System.EventHandler(this.txtSuelto_TextChanged);
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(344, 69);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(85, 26);
            this.txtpago.TabIndex = 9;
            this.txtpago.TextChanged += new System.EventHandler(this.txtpago_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(294, 74);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "Pago";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(147, 134);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 26);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(72, 134);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Total";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(72, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "Pelicula";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(72, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 20);
            this.label20.TabIndex = 4;
            this.label20.Text = "silla";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(184, 209);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 35);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Enabled = false;
            this.txtPelicula.Location = new System.Drawing.Point(147, 89);
            this.txtPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(97, 26);
            this.txtPelicula.TabIndex = 1;
            this.txtPelicula.Text = " DeadPool";
            this.txtPelicula.TextChanged += new System.EventHandler(this.txtPelicula_TextChanged);
            // 
            // txtsilla
            // 
            this.txtsilla.Enabled = false;
            this.txtsilla.Location = new System.Drawing.Point(147, 49);
            this.txtsilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsilla.Name = "txtsilla";
            this.txtsilla.Size = new System.Drawing.Size(97, 26);
            this.txtsilla.TabIndex = 0;
            this.txtsilla.TextChanged += new System.EventHandler(this.txtsilla_TextChanged);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(22, 760);
            this.button21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(112, 35);
            this.button21.TabIndex = 12;
            this.button21.Text = "Regresar";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(266, 760);
            this.button22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(112, 35);
            this.button22.TabIndex = 52;
            this.button22.Text = "Salir";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // salaDEADpolTableAdapter
            // 
            this.salaDEADpolTableAdapter.ClearBeforeFill = true;
            // 
            // SalaDeadPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1570, 849);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalaDeadPool";
            this.Text = "SalaDeadPool";
            this.Load += new System.EventHandler(this.SalaDeadPool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaDEADpolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CINEDataSet cINEDataSet;
        private System.Windows.Forms.BindingSource salaDEADpolBindingSource;
        private CINEDataSetTableAdapters.salaDEADpolTableAdapter salaDEADpolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sillaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtsilla;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label suelto;
        private System.Windows.Forms.TextBox txtSuelto;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
    }
}