
namespace Inventory
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodAdd = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodEdt = new System.Windows.Forms.Button();
            this.prodDel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.prodQty = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBcat = new System.Windows.Forms.ComboBox();
            this.prodDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.catBtn = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(416, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kuantitas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(416, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // prodAdd
            // 
            this.prodAdd.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAdd.Location = new System.Drawing.Point(476, 267);
            this.prodAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prodAdd.Name = "prodAdd";
            this.prodAdd.Size = new System.Drawing.Size(70, 35);
            this.prodAdd.TabIndex = 8;
            this.prodAdd.Text = "Tambah";
            this.prodAdd.UseVisualStyleBackColor = true;
            this.prodAdd.Click += new System.EventHandler(this.prodAdd_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(513, 223);
            this.CatCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(182, 28);
            this.CatCb.TabIndex = 10;
            this.CatCb.Text = "Pilih Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(416, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sound Bubble DEMO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(502, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Manajemen Produk";
            // 
            // prodEdt
            // 
            this.prodEdt.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEdt.Location = new System.Drawing.Point(550, 267);
            this.prodEdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prodEdt.Name = "prodEdt";
            this.prodEdt.Size = new System.Drawing.Size(70, 35);
            this.prodEdt.TabIndex = 17;
            this.prodEdt.Text = "Ubah";
            this.prodEdt.UseVisualStyleBackColor = true;
            this.prodEdt.Click += new System.EventHandler(this.prodEdt_Click);
            // 
            // prodDel
            // 
            this.prodDel.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDel.Location = new System.Drawing.Point(624, 267);
            this.prodDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prodDel.Name = "prodDel";
            this.prodDel.Size = new System.Drawing.Size(70, 35);
            this.prodDel.TabIndex = 18;
            this.prodDel.Text = "Hapus";
            this.prodDel.UseVisualStyleBackColor = true;
            this.prodDel.Click += new System.EventHandler(this.prodDel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.prodPrice);
            this.panel2.Controls.Add(this.prodQty);
            this.panel2.Controls.Add(this.prodName);
            this.panel2.Controls.Add(this.prodId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CBcat);
            this.panel2.Controls.Add(this.prodDGV);
            this.panel2.Controls.Add(this.prodDel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CatCb);
            this.panel2.Controls.Add(this.prodEdt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.prodAdd);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 458);
            this.panel2.TabIndex = 19;
            // 
            // prodPrice
            // 
            this.prodPrice.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPrice.Location = new System.Drawing.Point(513, 176);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(182, 28);
            this.prodPrice.TabIndex = 30;
            // 
            // prodQty
            // 
            this.prodQty.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodQty.Location = new System.Drawing.Point(513, 131);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(182, 28);
            this.prodQty.TabIndex = 29;
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(513, 85);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(182, 28);
            this.prodName.TabIndex = 28;
            // 
            // prodId
            // 
            this.prodId.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodId.Location = new System.Drawing.Point(513, 37);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(182, 28);
            this.prodId.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(416, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Harga";
            // 
            // CBcat
            // 
            this.CBcat.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcat.FormattingEnabled = true;
            this.CBcat.Location = new System.Drawing.Point(11, 7);
            this.CBcat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBcat.Name = "CBcat";
            this.CBcat.Size = new System.Drawing.Size(182, 28);
            this.CBcat.TabIndex = 23;
            this.CBcat.Text = "Pilih Kategori";
            this.CBcat.SelectionChangeCommitted += new System.EventHandler(this.CBcat_SelectionChangeCommitted);
            // 
            // prodDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.prodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDGV.BackgroundColor = System.Drawing.Color.White;
            this.prodDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodDGV.EnableHeadersVisualStyles = false;
            this.prodDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.Location = new System.Drawing.Point(11, 41);
            this.prodDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.RowHeadersVisible = false;
            this.prodDGV.RowTemplate.Height = 25;
            this.prodDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDGV.Size = new System.Drawing.Size(385, 401);
            this.prodDGV.TabIndex = 22;
            this.prodDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.prodDGV.ThemeStyle.ReadOnly = false;
            this.prodDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sound Bubble DEMO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDGV.ThemeStyle.RowsStyle.Height = 25;
            this.prodDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(416, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nama";
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.Color.White;
            this.catBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.catBtn.Location = new System.Drawing.Point(144, 0);
            this.catBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(90, 45);
            this.catBtn.TabIndex = 21;
            this.catBtn.Text = "Kategori";
            this.catBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.White;
            this.sellBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellBtn.Location = new System.Drawing.Point(50, 0);
            this.sellBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(90, 45);
            this.sellBtn.TabIndex = 22;
            this.sellBtn.Text = "Jual";
            this.sellBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
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
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prodAdd;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button prodEdt;
        private System.Windows.Forms.Button prodDel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label catBtn;
        private System.Windows.Forms.ComboBox CBcat;
        private Guna.UI.WinForms.GunaDataGridView prodDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sellBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox prodId;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.TextBox prodQty;
        private System.Windows.Forms.Button button2;
    }
}