
namespace Inventory
{
    partial class Sell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.prodDGV1 = new Guna.UI.WinForms.GunaDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sellPrice = new System.Windows.Forms.TextBox();
            this.sellQty = new System.Windows.Forms.TextBox();
            this.sellName = new System.Windows.Forms.TextBox();
            this.sellID = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.orderDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sellDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.catBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodBtn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // prodDGV1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.prodDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDGV1.BackgroundColor = System.Drawing.Color.White;
            this.prodDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodDGV1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodDGV1.EnableHeadersVisualStyles = false;
            this.prodDGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV1.Location = new System.Drawing.Point(16, 226);
            this.prodDGV1.Name = "prodDGV1";
            this.prodDGV1.RowHeadersVisible = false;
            this.prodDGV1.RowTemplate.Height = 25;
            this.prodDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDGV1.Size = new System.Drawing.Size(293, 217);
            this.prodDGV1.TabIndex = 22;
            this.prodDGV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.prodDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prodDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.prodDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDGV1.ThemeStyle.HeaderStyle.Height = 25;
            this.prodDGV1.ThemeStyle.ReadOnly = false;
            this.prodDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prodDGV1.ThemeStyle.RowsStyle.Height = 25;
            this.prodDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "NAMA";
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(15, 181);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(182, 28);
            this.CatCb.TabIndex = 10;
            this.CatCb.Text = "Select Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.sellPrice);
            this.panel2.Controls.Add(this.sellQty);
            this.panel2.Controls.Add(this.sellName);
            this.panel2.Controls.Add(this.sellID);
            this.panel2.Controls.Add(this.totalLbl);
            this.panel2.Controls.Add(this.orderDGV);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.sellDGV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.prodDGV1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CatCb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sellAdd);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 460);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sellPrice
            // 
            this.sellPrice.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPrice.Location = new System.Drawing.Point(111, 139);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(198, 28);
            this.sellPrice.TabIndex = 38;
            // 
            // sellQty
            // 
            this.sellQty.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellQty.Location = new System.Drawing.Point(111, 98);
            this.sellQty.Name = "sellQty";
            this.sellQty.Size = new System.Drawing.Size(198, 28);
            this.sellQty.TabIndex = 37;
            // 
            // sellName
            // 
            this.sellName.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellName.Location = new System.Drawing.Point(111, 56);
            this.sellName.Name = "sellName";
            this.sellName.Size = new System.Drawing.Size(198, 28);
            this.sellName.TabIndex = 36;
            // 
            // sellID
            // 
            this.sellID.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellID.Location = new System.Drawing.Point(111, 13);
            this.sellID.Name = "sellID";
            this.sellID.Size = new System.Drawing.Size(198, 28);
            this.sellID.TabIndex = 35;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.White;
            this.totalLbl.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalLbl.Location = new System.Drawing.Point(548, 231);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(144, 28);
            this.totalLbl.TabIndex = 34;
            this.totalLbl.Text = "Rp";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.orderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.BackgroundColor = System.Drawing.Color.White;
            this.orderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sound Bubble DEMO", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderDGV.ColumnHeadersHeight = 25;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prod,
            this.PName,
            this.Prc,
            this.Price,
            this.Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderDGV.EnableHeadersVisualStyles = false;
            this.orderDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDGV.Location = new System.Drawing.Point(331, 13);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersVisible = false;
            this.orderDGV.RowTemplate.Height = 25;
            this.orderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDGV.Size = new System.Drawing.Size(360, 210);
            this.orderDGV.TabIndex = 33;
            this.orderDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.orderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.orderDGV.ThemeStyle.ReadOnly = false;
            this.orderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.orderDGV.ThemeStyle.RowsStyle.Height = 25;
            this.orderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Prod
            // 
            this.Prod.HeaderText = "Prod ID";
            this.Prod.Name = "Prod";
            // 
            // PName
            // 
            this.PName.HeaderText = "Produk";
            this.PName.Name = "PName";
            // 
            // Prc
            // 
            this.Prc.HeaderText = "Harga";
            this.Prc.Name = "Prc";
            // 
            // Price
            // 
            this.Price.HeaderText = "Banyak";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(488, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Jumlah";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(233, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.sellDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.sellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellDGV.BackgroundColor = System.Drawing.Color.White;
            this.sellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.sellDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.sellDGV.EnableHeadersVisualStyles = false;
            this.sellDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.Location = new System.Drawing.Point(331, 267);
            this.sellDGV.Name = "sellDGV";
            this.sellDGV.RowHeadersVisible = false;
            this.sellDGV.RowTemplate.Height = 25;
            this.sellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellDGV.Size = new System.Drawing.Size(360, 176);
            this.sellDGV.TabIndex = 29;
            this.sellDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sellDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.sellDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.sellDGV.ThemeStyle.ReadOnly = false;
            this.sellDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.sellDGV.ThemeStyle.RowsStyle.Height = 25;
            this.sellDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "HARGA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID PENUALAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "BANYAK";
            // 
            // sellAdd
            // 
            this.sellAdd.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellAdd.Location = new System.Drawing.Point(331, 231);
            this.sellAdd.Name = "sellAdd";
            this.sellAdd.Size = new System.Drawing.Size(70, 28);
            this.sellAdd.TabIndex = 8;
            this.sellAdd.Text = "Tambah";
            this.sellAdd.UseVisualStyleBackColor = true;
            this.sellAdd.Click += new System.EventHandler(this.sellAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sound Bubble DEMO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(586, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "PENJUALAN";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dateLbl.Location = new System.Drawing.Point(328, 11);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(68, 24);
            this.dateLbl.TabIndex = 14;
            this.dateLbl.Text = "TANGGAL";
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.Color.White;
            this.catBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.catBtn.Location = new System.Drawing.Point(51, 0);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(90, 45);
            this.catBtn.TabIndex = 25;
            this.catBtn.Text = "Kategori";
            this.catBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sound Bubble DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prodBtn
            // 
            this.prodBtn.BackColor = System.Drawing.Color.White;
            this.prodBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prodBtn.Location = new System.Drawing.Point(147, 0);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(90, 45);
            this.prodBtn.TabIndex = 26;
            this.prodBtn.Text = "ProduK";
            this.prodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateLbl);
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView prodDGV1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sellAdd;
        private System.Windows.Forms.Label catBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDataGridView orderDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaDataGridView sellDGV;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label prodBtn;
        private System.Windows.Forms.TextBox sellPrice;
        private System.Windows.Forms.TextBox sellQty;
        private System.Windows.Forms.TextBox sellName;
        private System.Windows.Forms.TextBox sellID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}