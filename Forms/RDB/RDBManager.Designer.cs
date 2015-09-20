namespace TP_Tool_11._2.Forms.RDB
{
    partial class RDBManager
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
            this.dg_rdb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rdb)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_rdb
            // 
            this.dg_rdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rdb.Location = new System.Drawing.Point(12, 12);
            this.dg_rdb.Name = "dg_rdb";
            this.dg_rdb.Size = new System.Drawing.Size(717, 398);
            this.dg_rdb.TabIndex = 0;
            // 
            // RDBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 422);
            this.Controls.Add(this.dg_rdb);
            this.Name = "RDBManager";
            this.Text = "RDBManager";
            ((System.ComponentModel.ISupportInitialize)(this.dg_rdb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_rdb;
    }
}