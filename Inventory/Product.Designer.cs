
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodAdd = new System.Windows.Forms.Button();
            this.prodId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.prodName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodEdt = new System.Windows.Forms.Button();
            this.prodDel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.prodDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.prodQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.catBtn = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sound Bubble DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(31, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // prodAdd
            // 
            this.prodAdd.Font = new System.Drawing.Font("Futura PT Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAdd.Location = new System.Drawing.Point(128, 331);
            this.prodAdd.Name = "prodAdd";
            this.prodAdd.Size = new System.Drawing.Size(57, 24);
            this.prodAdd.TabIndex = 8;
            this.prodAdd.Text = "Add";
            this.prodAdd.UseVisualStyleBackColor = true;
            this.prodAdd.Click += new System.EventHandler(this.prodAdd_Click);
            // 
            // prodId
            // 
            this.prodId.BackColor = System.Drawing.Color.White;
            this.prodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodId.Font = new System.Drawing.Font("Futura PT Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodId.ForeColor = System.Drawing.Color.Black;
            this.prodId.HintForeColor = System.Drawing.Color.Empty;
            this.prodId.HintText = "";
            this.prodId.isPassword = false;
            this.prodId.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodId.LineIdleColor = System.Drawing.Color.Transparent;
            this.prodId.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.prodId.LineThickness = 3;
            this.prodId.Location = new System.Drawing.Point(128, 103);
            this.prodId.Margin = new System.Windows.Forms.Padding(4);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(181, 25);
            this.prodId.TabIndex = 9;
            this.prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Futura PT Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(128, 285);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(182, 25);
            this.CatCb.TabIndex = 10;
            this.CatCb.Text = "Select Category";
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.Color.White;
            this.prodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prodName.ForeColor = System.Drawing.Color.Black;
            this.prodName.HintForeColor = System.Drawing.Color.Empty;
            this.prodName.HintText = "";
            this.prodName.isPassword = false;
            this.prodName.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodName.LineIdleColor = System.Drawing.Color.Transparent;
            this.prodName.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.prodName.LineThickness = 3;
            this.prodName.Location = new System.Drawing.Point(128, 151);
            this.prodName.Margin = new System.Windows.Forms.Padding(4);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(181, 25);
            this.prodName.TabIndex = 11;
            this.prodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(31, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Futura PT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(310, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Manage Product";
            // 
            // prodEdt
            // 
            this.prodEdt.Font = new System.Drawing.Font("Futura PT Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEdt.Location = new System.Drawing.Point(190, 331);
            this.prodEdt.Name = "prodEdt";
            this.prodEdt.Size = new System.Drawing.Size(57, 24);
            this.prodEdt.TabIndex = 17;
            this.prodEdt.Text = "Edit";
            this.prodEdt.UseVisualStyleBackColor = true;
            this.prodEdt.Click += new System.EventHandler(this.prodEdt_Click);
            // 
            // prodDel
            // 
            this.prodDel.Font = new System.Drawing.Font("Futura PT Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDel.Location = new System.Drawing.Point(254, 331);
            this.prodDel.Name = "prodDel";
            this.prodDel.Size = new System.Drawing.Size(55, 24);
            this.prodDel.TabIndex = 18;
            this.prodDel.Text = "Delete";
            this.prodDel.UseVisualStyleBackColor = true;
            this.prodDel.Click += new System.EventHandler(this.prodDel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.prodPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.prodDGV);
            this.panel2.Controls.Add(this.prodQty);
            this.panel2.Controls.Add(this.prodDel);
            this.panel2.Controls.Add(this.prodName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CatCb);
            this.panel2.Controls.Add(this.prodEdt);
            this.panel2.Controls.Add(this.prodId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.prodAdd);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 520);
            this.panel2.TabIndex = 19;
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.Color.White;
            this.prodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prodPrice.ForeColor = System.Drawing.Color.Black;
            this.prodPrice.HintForeColor = System.Drawing.Color.Empty;
            this.prodPrice.HintText = "";
            this.prodPrice.isPassword = false;
            this.prodPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodPrice.LineIdleColor = System.Drawing.Color.Transparent;
            this.prodPrice.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.prodPrice.LineThickness = 3;
            this.prodPrice.Location = new System.Drawing.Point(128, 242);
            this.prodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(181, 25);
            this.prodPrice.TabIndex = 26;
            this.prodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(31, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Price";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Futura PT Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(571, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 25);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.Text = "Select Category";
            // 
            // prodDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.prodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.prodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDGV.BackgroundColor = System.Drawing.Color.White;
            this.prodDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Futura PT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.prodDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Futura PT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.prodDGV.EnableHeadersVisualStyles = false;
            this.prodDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.Location = new System.Drawing.Point(328, 103);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.RowHeadersVisible = false;
            this.prodDGV.RowTemplate.Height = 25;
            this.prodDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDGV.Size = new System.Drawing.Size(425, 404);
            this.prodDGV.TabIndex = 22;
            this.prodDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.prodDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Futura PT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.prodDGV.ThemeStyle.ReadOnly = false;
            this.prodDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Futura PT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prodDGV.ThemeStyle.RowsStyle.Height = 25;
            this.prodDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV_CellContentClick);
            // 
            // prodQty
            // 
            this.prodQty.BackColor = System.Drawing.Color.White;
            this.prodQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prodQty.ForeColor = System.Drawing.Color.Black;
            this.prodQty.HintForeColor = System.Drawing.Color.Empty;
            this.prodQty.HintText = "";
            this.prodQty.isPassword = false;
            this.prodQty.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodQty.LineIdleColor = System.Drawing.Color.Transparent;
            this.prodQty.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.prodQty.LineThickness = 3;
            this.prodQty.Location = new System.Drawing.Point(128, 197);
            this.prodQty.Margin = new System.Windows.Forms.Padding(4);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(181, 25);
            this.prodQty.TabIndex = 21;
            this.prodQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(31, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name";
            // 
            // catBtn
            // 
            this.catBtn.AutoSize = true;
            this.catBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.catBtn.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.catBtn.Location = new System.Drawing.Point(10, 7);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(90, 21);
            this.catBtn.TabIndex = 21;
            this.catBtn.Text = "Categories";
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.AutoSize = true;
            this.sellBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.sellBtn.Font = new System.Drawing.Font("Futura PT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellBtn.Location = new System.Drawing.Point(106, 7);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(36, 21);
            this.sellBtn.TabIndex = 22;
            this.sellBtn.Text = "Sell";
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 556);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prodAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodId;
        private System.Windows.Forms.ComboBox CatCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button prodEdt;
        private System.Windows.Forms.Button prodDel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label catBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodQty;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI.WinForms.GunaDataGridView prodDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sellBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}