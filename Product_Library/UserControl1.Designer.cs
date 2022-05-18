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
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUnit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.number = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddToCard = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(9, 9);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(155, 113);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(13, 132);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(13, 163);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 17);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price:";
            // 
            // lbUnit
            // 
            this.lbUnit.BackColor = System.Drawing.Color.Transparent;
            this.lbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.ForeColor = System.Drawing.Color.Black;
            this.lbUnit.Location = new System.Drawing.Point(13, 184);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(28, 17);
            this.lbUnit.TabIndex = 3;
            this.lbUnit.Text = "Unit:";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.BorderRadius = 6;
            this.number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.number.ForeColor = System.Drawing.Color.Black;
            this.number.Location = new System.Drawing.Point(115, 163);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(49, 28);
            this.number.TabIndex = 4;
            this.number.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.number.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.BorderRadius = 12;
            this.btnAddToCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.btnAddToCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToCard.ForeColor = System.Drawing.Color.White;
            this.btnAddToCard.Location = new System.Drawing.Point(9, 205);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(155, 34);
            this.btnAddToCard.TabIndex = 5;
            this.btnAddToCard.Text = "Add To Card";
            this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddToCard);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picture);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(172, 251);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picture;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUnit;
        private Guna.UI2.WinForms.Guna2NumericUpDown number;
        private Guna.UI2.WinForms.Guna2Button btnAddToCard;
    }
}
