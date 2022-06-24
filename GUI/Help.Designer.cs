namespace GUI
{
    partial class Help
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
            this.btnHow = new Guna.UI2.WinForms.Guna2Button();
            this.btnProblem = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnHow
            // 
            this.btnHow.BackColor = System.Drawing.Color.Transparent;
            this.btnHow.BorderRadius = 15;
            this.btnHow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.btnHow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHow.ForeColor = System.Drawing.Color.White;
            this.btnHow.Location = new System.Drawing.Point(423, 190);
            this.btnHow.Margin = new System.Windows.Forms.Padding(4);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(254, 44);
            this.btnHow.TabIndex = 23;
            this.btnHow.Text = "How to use this app";
            this.btnHow.UseTransparentBackground = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnProblem
            // 
            this.btnProblem.BackColor = System.Drawing.Color.Transparent;
            this.btnProblem.BorderRadius = 15;
            this.btnProblem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProblem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProblem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProblem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProblem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.btnProblem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnProblem.ForeColor = System.Drawing.Color.White;
            this.btnProblem.Location = new System.Drawing.Point(131, 190);
            this.btnProblem.Margin = new System.Windows.Forms.Padding(4);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(254, 44);
            this.btnProblem.TabIndex = 24;
            this.btnProblem.Text = "Report  a problem";
            this.btnProblem.UseTransparentBackground = true;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProblem);
            this.Controls.Add(this.btnHow);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHow;
        private Guna.UI2.WinForms.Guna2Button btnProblem;
    }
}