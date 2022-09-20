
namespace Licenta
{
    partial class Adaugacursa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statisticiCurseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiSoferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label38 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.cbtipcursa = new System.Windows.Forms.ComboBox();
            this.cbclient = new System.Windows.Forms.ComboBox();
            this.cbsofer = new System.Windows.Forms.ComboBox();
            this.cbcamion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.costcursa = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtDistanta = new System.Windows.Forms.TextBox();
            this.txtDestinatie = new System.Windows.Forms.TextBox();
            this.txtPlecare = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transLoDataSet = new Licenta.TransLoDataSet();
            this.curseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curseTableAdapter = new Licenta.TransLoDataSetTableAdapters.CurseTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transLoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticiCurseToolStripMenuItem,
            this.statisticiSoferiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // statisticiCurseToolStripMenuItem
            // 
            this.statisticiCurseToolStripMenuItem.Name = "statisticiCurseToolStripMenuItem";
            this.statisticiCurseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.statisticiCurseToolStripMenuItem.Text = "Statistici curse";
            this.statisticiCurseToolStripMenuItem.Click += new System.EventHandler(this.statisticiCurseToolStripMenuItem_Click);
            // 
            // statisticiSoferiToolStripMenuItem
            // 
            this.statisticiSoferiToolStripMenuItem.Name = "statisticiSoferiToolStripMenuItem";
            this.statisticiSoferiToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.statisticiSoferiToolStripMenuItem.Text = "Statistici soferi";
            this.statisticiSoferiToolStripMenuItem.Click += new System.EventHandler(this.statisticiSoferiToolStripMenuItem_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(524, 36);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(358, 36);
            this.label38.TabIndex = 33;
            this.label38.Text = "Managementul curselor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.cbtipcursa);
            this.panel2.Controls.Add(this.cbclient);
            this.panel2.Controls.Add(this.cbsofer);
            this.panel2.Controls.Add(this.cbcamion);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.costcursa);
            this.panel2.Controls.Add(this.txtTarif);
            this.panel2.Controls.Add(this.txtDistanta);
            this.panel2.Controls.Add(this.txtDestinatie);
            this.panel2.Controls.Add(this.txtPlecare);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(32, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 254);
            this.panel2.TabIndex = 34;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(1081, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(181, 54);
            this.button9.TabIndex = 73;
            this.button9.Text = "Sterge cursa";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(1081, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 54);
            this.button8.TabIndex = 72;
            this.button8.Text = "Modifica cursa";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cbtipcursa
            // 
            this.cbtipcursa.DropDownHeight = 80;
            this.cbtipcursa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipcursa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbtipcursa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbtipcursa.FormattingEnabled = true;
            this.cbtipcursa.IntegralHeight = false;
            this.cbtipcursa.Items.AddRange(new object[] {
            "internationala",
            "nationala     "});
            this.cbtipcursa.Location = new System.Drawing.Point(521, 129);
            this.cbtipcursa.Name = "cbtipcursa";
            this.cbtipcursa.Size = new System.Drawing.Size(145, 29);
            this.cbtipcursa.TabIndex = 71;
            // 
            // cbclient
            // 
            this.cbclient.DropDownHeight = 80;
            this.cbclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbclient.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbclient.FormattingEnabled = true;
            this.cbclient.IntegralHeight = false;
            this.cbclient.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbclient.Location = new System.Drawing.Point(521, 207);
            this.cbclient.Name = "cbclient";
            this.cbclient.Size = new System.Drawing.Size(145, 29);
            this.cbclient.TabIndex = 70;
            // 
            // cbsofer
            // 
            this.cbsofer.DropDownHeight = 80;
            this.cbsofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsofer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbsofer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbsofer.FormattingEnabled = true;
            this.cbsofer.IntegralHeight = false;
            this.cbsofer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbsofer.Location = new System.Drawing.Point(284, 210);
            this.cbsofer.Name = "cbsofer";
            this.cbsofer.Size = new System.Drawing.Size(130, 29);
            this.cbsofer.TabIndex = 69;
            // 
            // cbcamion
            // 
            this.cbcamion.DropDownHeight = 80;
            this.cbcamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcamion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbcamion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbcamion.FormattingEnabled = true;
            this.cbcamion.IntegralHeight = false;
            this.cbcamion.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115"});
            this.cbcamion.Location = new System.Drawing.Point(75, 212);
            this.cbcamion.Name = "cbcamion";
            this.cbcamion.Size = new System.Drawing.Size(130, 29);
            this.cbcamion.TabIndex = 68;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(752, 164);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 26);
            this.dateTimePicker2.TabIndex = 67;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 26);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // costcursa
            // 
            this.costcursa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.costcursa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costcursa.ForeColor = System.Drawing.Color.White;
            this.costcursa.Location = new System.Drawing.Point(284, 132);
            this.costcursa.Name = "costcursa";
            this.costcursa.Size = new System.Drawing.Size(129, 28);
            this.costcursa.TabIndex = 64;
            this.costcursa.Leave += new System.EventHandler(this.costcursa_Leave);
            // 
            // txtTarif
            // 
            this.txtTarif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtTarif.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarif.ForeColor = System.Drawing.Color.White;
            this.txtTarif.Location = new System.Drawing.Point(75, 131);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(129, 28);
            this.txtTarif.TabIndex = 61;
            this.txtTarif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarif_KeyDown);
            this.txtTarif.Leave += new System.EventHandler(this.txtTarif_Leave);
            // 
            // txtDistanta
            // 
            this.txtDistanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtDistanta.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanta.ForeColor = System.Drawing.Color.White;
            this.txtDistanta.Location = new System.Drawing.Point(521, 49);
            this.txtDistanta.Name = "txtDistanta";
            this.txtDistanta.Size = new System.Drawing.Size(138, 28);
            this.txtDistanta.TabIndex = 60;
            this.txtDistanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistanta_KeyDown);
            this.txtDistanta.Leave += new System.EventHandler(this.txtDistanta_Leave);
            // 
            // txtDestinatie
            // 
            this.txtDestinatie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtDestinatie.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatie.ForeColor = System.Drawing.Color.White;
            this.txtDestinatie.Location = new System.Drawing.Point(284, 49);
            this.txtDestinatie.Name = "txtDestinatie";
            this.txtDestinatie.Size = new System.Drawing.Size(129, 28);
            this.txtDestinatie.TabIndex = 59;
            this.txtDestinatie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinatie_KeyDown);
            // 
            // txtPlecare
            // 
            this.txtPlecare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtPlecare.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlecare.ForeColor = System.Drawing.Color.White;
            this.txtPlecare.Location = new System.Drawing.Point(75, 49);
            this.txtPlecare.Name = "txtPlecare";
            this.txtPlecare.Size = new System.Drawing.Size(129, 28);
            this.txtPlecare.TabIndex = 58;
            this.txtPlecare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlecare_KeyDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1081, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 52);
            this.button5.TabIndex = 57;
            this.button5.Text = "Adauga cursa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(280, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 21);
            this.label11.TabIndex = 46;
            this.label11.Text = "Alege soferul:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(517, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Alege clientul:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(71, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Alege camionul:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(280, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Costul cursei:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tariful cursei:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(517, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipul cursei:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(517, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Distanta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(748, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data intoarcerii:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(748, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data plecarii:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Destinatia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Plecarea:";
            // 
            // transLoDataSet
            // 
            this.transLoDataSet.DataSetName = "TransLoDataSet";
            this.transLoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curseBindingSource
            // 
            this.curseBindingSource.DataMember = "Curse";
            this.curseBindingSource.DataSource = this.transLoDataSet;
            // 
            // curseTableAdapter
            // 
            this.curseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(32, 345);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 401);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_cursa";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "plecare";
            this.Column2.FillWeight = 110F;
            this.Column2.HeaderText = "PLECARE";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "destinatie";
            this.Column3.FillWeight = 110F;
            this.Column3.HeaderText = "DESTINATIE";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "data_plecare";
            this.Column4.HeaderText = "DATA PLECARII";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "data_intoarcere";
            this.Column5.HeaderText = "DATA INTOARCERII";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "distanta";
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "DISTANTA";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tarif_cursa";
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "TARIF CURSA";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cost_transport";
            this.Column8.FillWeight = 60F;
            this.Column8.HeaderText = "COST CURSA";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tip_cursa";
            this.Column9.HeaderText = "TIP CURSA";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "id_camion";
            this.Column10.FillWeight = 50F;
            this.Column10.HeaderText = "CAMION";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "id_client";
            this.Column11.FillWeight = 50F;
            this.Column11.HeaderText = "CLIENT";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "id_sofer";
            this.Column12.FillWeight = 50F;
            this.Column12.HeaderText = "SOFER";
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Adaugacursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1569, 798);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label38);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adaugacursa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugacursa";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transLoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbclient;
        private System.Windows.Forms.ComboBox cbsofer;
        private System.Windows.Forms.ComboBox cbcamion;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox costcursa;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtDistanta;
        private System.Windows.Forms.TextBox txtDestinatie;
        private System.Windows.Forms.TextBox txtPlecare;
        private TransLoDataSet transLoDataSet;
        private System.Windows.Forms.BindingSource curseBindingSource;
        private TransLoDataSetTableAdapters.CurseTableAdapter curseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbtipcursa;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statisticiCurseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiSoferiToolStripMenuItem;
    }
}