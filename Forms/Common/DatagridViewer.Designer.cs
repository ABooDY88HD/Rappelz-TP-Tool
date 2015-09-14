namespace TP_Tool_11._2
{
    partial class DatagridViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_filter_value = new System.Windows.Forms.TextBox();
            this.tb_filter_common = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_value, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_common, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_filter_value
            // 
            this.tb_filter_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_value.Location = new System.Drawing.Point(3, 3);
            this.tb_filter_value.Name = "tb_filter_value";
            this.tb_filter_value.Size = new System.Drawing.Size(901, 20);
            this.tb_filter_value.TabIndex = 1;
            this.tb_filter_value.Text = "name";
            this.tb_filter_value.TextChanged += new System.EventHandler(this.tb_filter);
            // 
            // tb_filter_common
            // 
            this.tb_filter_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_common.Location = new System.Drawing.Point(3, 29);
            this.tb_filter_common.Name = "tb_filter_common";
            this.tb_filter_common.Size = new System.Drawing.Size(901, 20);
            this.tb_filter_common.TabIndex = 0;
            this.tb_filter_common.Text = "value LIKE \'%name%\'";
            this.tb_filter_common.TextChanged += new System.EventHandler(this.tb_filter);
            // 
            // DatagridViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DatagridViewer";
            this.Text = "DatagridViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_filter_common;
        private System.Windows.Forms.TextBox tb_filter_value;
    }
}