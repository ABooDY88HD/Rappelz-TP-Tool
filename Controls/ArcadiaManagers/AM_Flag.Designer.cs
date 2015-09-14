namespace TP_Tool_11._2.Controls.ArcadiaManagers
{
    partial class AM_Flag
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
            this.am_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.am_lb = new System.Windows.Forms.Label();
            this.am_tooltip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // am_tb
            // 
            this.am_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.am_tb.Location = new System.Drawing.Point(44, 3);
            this.am_tb.Name = "am_tb";
            this.am_tb.Size = new System.Drawing.Size(237, 20);
            this.am_tb.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.am_lb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.am_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.am_tooltip, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // am_lb
            // 
            this.am_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.am_lb.AutoSize = true;
            this.am_lb.Location = new System.Drawing.Point(3, 7);
            this.am_lb.Name = "am_lb";
            this.am_lb.Size = new System.Drawing.Size(35, 13);
            this.am_lb.TabIndex = 1;
            this.am_lb.Text = "label1";
            // 
            // am_tooltip
            // 
            this.am_tooltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.am_tooltip.AutoSize = true;
            this.am_tooltip.Font = new System.Drawing.Font("Tahoma", 10F);
            this.am_tooltip.Location = new System.Drawing.Point(287, 5);
            this.am_tooltip.Name = "am_tooltip";
            this.am_tooltip.Size = new System.Drawing.Size(14, 17);
            this.am_tooltip.TabIndex = 2;
            this.am_tooltip.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AM_Flag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AM_Flag";
            this.Size = new System.Drawing.Size(354, 27);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox am_tb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label am_lb;
        private System.Windows.Forms.Label am_tooltip;
        private System.Windows.Forms.Button button1;
    }
}
