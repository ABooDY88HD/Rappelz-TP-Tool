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
            this.cb_advanced = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_value, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_common, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_advanced, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_filter_value
            // 
            this.tb_filter_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_value.Location = new System.Drawing.Point(3, 4);
            this.tb_filter_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_filter_value.Name = "tb_filter_value";
            this.tb_filter_value.Size = new System.Drawing.Size(1050, 24);
            this.tb_filter_value.TabIndex = 1;
            this.tb_filter_value.Text = "name";
            this.tb_filter_value.TextChanged += new System.EventHandler(this.tb_filter);
            // 
            // tb_filter_common
            // 
            this.tb_filter_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_common.Location = new System.Drawing.Point(3, 36);
            this.tb_filter_common.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_filter_common.Name = "tb_filter_common";
            this.tb_filter_common.Size = new System.Drawing.Size(1050, 24);
            this.tb_filter_common.TabIndex = 0;
            this.tb_filter_common.Text = "value LIKE \'%name%\'";
            this.tb_filter_common.TextChanged += new System.EventHandler(this.tb_filter);
            // 
            // cb_advanced
            // 
            this.cb_advanced.AutoSize = true;
            this.cb_advanced.Checked = true;
            this.cb_advanced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_advanced.Location = new System.Drawing.Point(3, 68);
            this.cb_advanced.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_advanced.Name = "cb_advanced";
            this.cb_advanced.Size = new System.Drawing.Size(88, 21);
            this.cb_advanced.TabIndex = 2;
            this.cb_advanced.Text = "Advanced";
            this.cb_advanced.UseVisualStyleBackColor = true;
            this.cb_advanced.CheckedChanged += new System.EventHandler(this.cb_advanced_CheckedChanged);
            // 
            // DatagridViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatagridViewer";
            this.Text = "DatagridViewer";
            this.Load += new System.EventHandler(this.DatagridViewer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_filter_common;
        private System.Windows.Forms.TextBox tb_filter_value;
        private System.Windows.Forms.CheckBox cb_advanced;
    }
}