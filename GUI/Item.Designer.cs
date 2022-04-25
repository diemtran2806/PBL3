namespace GUI
{
    partial class Item
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
            this.pb_Item = new System.Windows.Forms.PictureBox();
            this.lbName_Item = new System.Windows.Forms.Label();
            this.lbUnit_Item = new System.Windows.Forms.Label();
            this.lbPrice_Item = new System.Windows.Forms.Label();
            this.btnAdd_Item = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Item
            // 
            this.pb_Item.Location = new System.Drawing.Point(3, 3);
            this.pb_Item.Name = "pb_Item";
            this.pb_Item.Size = new System.Drawing.Size(248, 158);
            this.pb_Item.TabIndex = 0;
            this.pb_Item.TabStop = false;
            // 
            // lbName_Item
            // 
            this.lbName_Item.AutoSize = true;
            this.lbName_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName_Item.Location = new System.Drawing.Point(3, 164);
            this.lbName_Item.Name = "lbName_Item";
            this.lbName_Item.Size = new System.Drawing.Size(79, 29);
            this.lbName_Item.TabIndex = 1;
            this.lbName_Item.Text = "label1";
            // 
            // lbUnit_Item
            // 
            this.lbUnit_Item.AutoSize = true;
            this.lbUnit_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit_Item.Location = new System.Drawing.Point(3, 207);
            this.lbUnit_Item.Name = "lbUnit_Item";
            this.lbUnit_Item.Size = new System.Drawing.Size(61, 26);
            this.lbUnit_Item.TabIndex = 2;
            this.lbUnit_Item.Text = "ĐVT:";
            this.lbUnit_Item.Click += new System.EventHandler(this.lbUnit_Item_Click);
            // 
            // lbPrice_Item
            // 
            this.lbPrice_Item.AutoSize = true;
            this.lbPrice_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice_Item.Location = new System.Drawing.Point(14, 233);
            this.lbPrice_Item.Name = "lbPrice_Item";
            this.lbPrice_Item.Size = new System.Drawing.Size(35, 29);
            this.lbPrice_Item.TabIndex = 3;
            this.lbPrice_Item.Text = " ₫";
            this.lbPrice_Item.Click += new System.EventHandler(this.lbPrice_Item_Click);
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.Location = new System.Drawing.Point(31, 266);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.Size = new System.Drawing.Size(188, 41);
            this.btnAdd_Item.TabIndex = 4;
            this.btnAdd_Item.Text = "button1";
            this.btnAdd_Item.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd_Item);
            this.Controls.Add(this.lbPrice_Item);
            this.Controls.Add(this.lbUnit_Item);
            this.Controls.Add(this.lbName_Item);
            this.Controls.Add(this.pb_Item);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(254, 310);
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Item;
        private System.Windows.Forms.Label lbName_Item;
        private System.Windows.Forms.Label lbUnit_Item;
        private System.Windows.Forms.Label lbPrice_Item;
        private System.Windows.Forms.Button btnAdd_Item;
    }
}
