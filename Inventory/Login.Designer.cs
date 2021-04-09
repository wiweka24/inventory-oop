
namespace Inventory
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // passw
            // 
            this.passw.BackColor = System.Drawing.Color.White;
            this.passw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passw.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passw.HintForeColor = System.Drawing.Color.Empty;
            this.passw.HintText = "";
            this.passw.isPassword = false;
            this.passw.LineFocusedColor = System.Drawing.Color.Goldenrod;
            this.passw.LineIdleColor = System.Drawing.Color.Gray;
            this.passw.LineMouseHoverColor = System.Drawing.Color.Goldenrod;
            this.passw.LineThickness = 4;
            this.passw.Location = new System.Drawing.Point(50, 284);
            this.passw.Margin = new System.Windows.Forms.Padding(4);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(187, 38);
            this.passw.TabIndex = 1;
            this.passw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sound Bubble DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(114, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.WindowText;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.WindowText;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.bunifuThinButton21.Location = new System.Drawing.Point(73, 340);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(131, 39);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sound Bubble DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(255, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(47, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ussername";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(47, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.White;
            this.uname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname.Font = new System.Drawing.Font("Sound Bubble DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uname.HintForeColor = System.Drawing.Color.Empty;
            this.uname.HintText = "";
            this.uname.isPassword = false;
            this.uname.LineFocusedColor = System.Drawing.Color.Goldenrod;
            this.uname.LineIdleColor = System.Drawing.Color.Gray;
            this.uname.LineMouseHoverColor = System.Drawing.Color.Goldenrod;
            this.uname.LineThickness = 4;
            this.uname.Location = new System.Drawing.Point(50, 220);
            this.uname.Margin = new System.Windows.Forms.Padding(4);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(187, 39);
            this.uname.TabIndex = 9;
            this.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passw);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox passw;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uname;
    }
}

