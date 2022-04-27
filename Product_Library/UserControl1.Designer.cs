namespace Product_Library
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUnit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Number = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddToCard = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(194, 160);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(3, 169);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Location = new System.Drawing.Point(3, 199);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(30, 15);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price:";
            // 
            // lbUnit
            // 
            this.lbUnit.BackColor = System.Drawing.Color.Transparent;
            this.lbUnit.Location = new System.Drawing.Point(3, 220);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(25, 15);
            this.lbUnit.TabIndex = 3;
            this.lbUnit.Text = "Unit:";
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Number.ForeColor = System.Drawing.Color.Black;
            this.Number.Location = new System.Drawing.Point(142, 199);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 27);
            this.Number.TabIndex = 4;
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToCard.ForeColor = System.Drawing.Color.White;
            this.btnAddToCard.Location = new System.Drawing.Point(3, 241);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(194, 35);
            this.btnAddToCard.TabIndex = 5;
            this.btnAddToCard.Text = "Add To Card";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddToCard);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(200, 281);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUnit;
        private Guna.UI2.WinForms.Guna2NumericUpDown Number;
        private Guna.UI2.WinForms.Guna2Button btnAddToCard;
    }
}
