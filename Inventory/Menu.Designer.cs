
namespace Inventory
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.catBtn = new System.Windows.Forms.Button();
            this.prodBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.catBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("catBtn.BackgroundImage")));
            this.catBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.catBtn.Location = new System.Drawing.Point(69, 174);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(145, 145);
            this.catBtn.TabIndex = 0;
            this.catBtn.UseVisualStyleBackColor = false;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // prodBtn
            // 
            this.prodBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.prodBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prodBtn.BackgroundImage")));
            this.prodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.prodBtn.Location = new System.Drawing.Point(277, 174);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(145, 145);
            this.prodBtn.TabIndex = 1;
            this.prodBtn.UseVisualStyleBackColor = false;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.sellBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sellBtn.BackgroundImage")));
            this.sellBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.sellBtn.Location = new System.Drawing.Point(491, 174);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(145, 145);
            this.sellBtn.TabIndex = 2;
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sound Bubble DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU UTAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "KATEGORI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRODUK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sound Bubble DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "JUAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 62);
            this.panel1.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.catBtn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}