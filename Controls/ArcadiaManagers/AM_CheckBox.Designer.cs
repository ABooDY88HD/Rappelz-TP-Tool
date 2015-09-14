namespace TP_Tool_11._2.Controls.ArcadiaManagers
{
    partial class AM_CheckBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.am_tooltip = new System.Windows.Forms.Label();
            this.AM_cb = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.am_tooltip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AM_cb, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(115, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // am_tooltip
            // 
            this.am_tooltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.am_tooltip.AutoSize = true;
            this.am_tooltip.Font = new System.Drawing.Font("Tahoma", 10F);
            this.am_tooltip.Location = new System.Drawing.Point(98, 5);
            this.am_tooltip.Name = "am_tooltip";
            this.am_tooltip.Size = new System.Drawing.Size(14, 17);
            this.am_tooltip.TabIndex = 2;
            this.am_tooltip.Text = "?";
            // 
            // AM_cb
            // 
            this.AM_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AM_cb.AutoSize = true;
            this.AM_cb.Location = new System.Drawing.Point(3, 5);
            this.AM_cb.Name = "AM_cb";
            this.AM_cb.Size = new System.Drawing.Size(77, 17);
            this.AM_cb.TabIndex = 3;
            this.AM_cb.Text = "checkBox1";
            this.AM_cb.UseVisualStyleBackColor = true;
            // 
            // AM_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AM_CheckBox";
            this.Size = new System.Drawing.Size(115, 27);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label am_tooltip;
        private System.Windows.Forms.CheckBox AM_cb;
    }
}
