﻿
namespace DangKyTiemChung.GUI
{
    partial class MHVacXin
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
            this.huy = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.view_vacxin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.view_vacxin)).BeginInit();
            this.SuspendLayout();
            // 
            // huy
            // 
            this.huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy.Location = new System.Drawing.Point(462, 391);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(111, 47);
            this.huy.TabIndex = 7;
            this.huy.Text = "Hủy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(276, 391);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(106, 47);
            this.them.TabIndex = 6;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // view_vacxin
            // 
            this.view_vacxin.AllowUserToAddRows = false;
            this.view_vacxin.AllowUserToDeleteRows = false;
            this.view_vacxin.AllowUserToResizeColumns = false;
            this.view_vacxin.AllowUserToResizeRows = false;
            this.view_vacxin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_vacxin.Location = new System.Drawing.Point(52, 12);
            this.view_vacxin.Name = "view_vacxin";
            this.view_vacxin.RowHeadersWidth = 51;
            this.view_vacxin.RowTemplate.Height = 24;
            this.view_vacxin.Size = new System.Drawing.Size(690, 307);
            this.view_vacxin.TabIndex = 4;
            this.view_vacxin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.view_vacxin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MHVacXin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.them);
            this.Controls.Add(this.view_vacxin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MHVacXin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VacXin";
            this.Load += new System.EventHandler(this.VacXin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_vacxin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView view_vacxin;
    }
}