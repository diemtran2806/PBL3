namespace PBL_3
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
            this.btnAdd_Item = new System.Windows.Forms.Button();
            this.lbPrice_Item = new System.Windows.Forms.Label();
            this.lbUnit_Item = new System.Windows.Forms.Label();
            this.lbName_Item = new System.Windows.Forms.Label();
            this.pb_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.Location = new System.Drawing.Point(42, 380);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.Size = new System.Drawing.Size(188, 41);
            this.btnAdd_Item.TabIndex = 9;
            this.btnAdd_Item.Text = "button1";
            this.btnAdd_Item.UseVisualStyleBackColor = true;
            // 
            // lbPrice_Item
            // 
            this.lbPrice_Item.AutoSize = true;
            this.lbPrice_Item.Location = new System.Drawing.Point(14, 333);
            this.lbPrice_Item.Name = "lbPrice_Item";
            this.lbPrice_Item.Size = new System.Drawing.Size(44, 16);
            this.lbPrice_Item.TabIndex = 8;
            this.lbPrice_Item.Text = "label3";
            // 
            // lbUnit_Item
            // 
            this.lbUnit_Item.AutoSize = true;
            this.lbUnit_Item.Location = new System.Drawing.Point(14, 304);
            this.lbUnit_Item.Name = "lbUnit_Item";
            this.lbUnit_Item.Size = new System.Drawing.Size(44, 16);
            this.lbUnit_Item.TabIndex = 7;
            this.lbUnit_Item.Text = "label2";
            // 
            // lbName_Item
            // 
            this.lbName_Item.AutoSize = true;
            this.lbName_Item.Location = new System.Drawing.Point(14, 235);
            this.lbName_Item.Name = "lbName_Item";
            this.lbName_Item.Size = new System.Drawing.Size(44, 16);
            this.lbName_Item.TabIndex = 6;
            this.lbName_Item.Text = "label1";
            // 
            // pb_Item
            // 
            this.pb_Item.Location = new System.Drawing.Point(3, 12);
            this.pb_Item.Name = "pb_Item";
            this.pb_Item.Size = new System.Drawing.Size(269, 211);
            this.pb_Item.TabIndex = 5;
            this.pb_Item.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd_Item);
            this.Controls.Add(this.lbPrice_Item);
            this.Controls.Add(this.lbUnit_Item);
            this.Controls.Add(this.lbName_Item);
            this.Controls.Add(this.pb_Item);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(275, 449);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_Item;
        private System.Windows.Forms.Label lbPrice_Item;
        private System.Windows.Forms.Label lbUnit_Item;
        private System.Windows.Forms.Label lbName_Item;
        private System.Windows.Forms.PictureBox pb_Item;
    }
}
