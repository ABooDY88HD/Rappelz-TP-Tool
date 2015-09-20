namespace TP_Tool_11._2.Forms.Common
{
    partial class DataPicker
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
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.Dataview = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_value, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_filter_common, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pb_icon, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dataview, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tb_filter_value
            // 
            this.tb_filter_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_value.Location = new System.Drawing.Point(3, 4);
            this.tb_filter_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_filter_value.Name = "tb_filter_value";
            this.tb_filter_value.Size = new System.Drawing.Size(1050, 20);
            this.tb_filter_value.TabIndex = 1;
            this.tb_filter_value.Text = "name";
            // 
            // tb_filter_common
            // 
            this.tb_filter_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter_common.Location = new System.Drawing.Point(3, 32);
            this.tb_filter_common.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_filter_common.Name = "tb_filter_common";
            this.tb_filter_common.Size = new System.Drawing.Size(1050, 20);
            this.tb_filter_common.TabIndex = 0;
            this.tb_filter_common.Text = "value LIKE \'%name%\'";
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(3, 59);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(32, 32);
            this.pb_icon.TabIndex = 2;
            this.pb_icon.TabStop = false;
            // 
            // Dataview
            // 
            this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dataview.Location = new System.Drawing.Point(3, 97);
            this.Dataview.Name = "Dataview";
            this.Dataview.Size = new System.Drawing.Size(240, 150);
            this.Dataview.TabIndex = 3;
            this.Dataview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dataview_CellEnter);
            // 
            // DataPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataPicker";
            this.Text = "DataPicker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_filter_value;
        private System.Windows.Forms.TextBox tb_filter_common;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.DataGridView Dataview;
    }
}