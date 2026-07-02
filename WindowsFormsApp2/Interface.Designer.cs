namespace WindowsFormsApp2
{
    partial class Interface
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
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntovar = new System.Windows.Forms.Button();
            this.btnPVZ = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(51, 28);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "label1";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(51, 52);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(35, 13);
            this.lblFio.TabIndex = 1;
            this.lblFio.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 213);
            this.dataGridView1.TabIndex = 2;
            // 
            // btntovar
            // 
            this.btntovar.Location = new System.Drawing.Point(54, 95);
            this.btntovar.Name = "btntovar";
            this.btntovar.Size = new System.Drawing.Size(118, 23);
            this.btntovar.TabIndex = 3;
            this.btntovar.Text = "Товары";
            this.btntovar.UseVisualStyleBackColor = true;
            this.btntovar.Click += new System.EventHandler(this.btntovar_Click);
            // 
            // btnPVZ
            // 
            this.btnPVZ.Location = new System.Drawing.Point(178, 95);
            this.btnPVZ.Name = "btnPVZ";
            this.btnPVZ.Size = new System.Drawing.Size(103, 23);
            this.btnPVZ.TabIndex = 4;
            this.btnPVZ.Text = "ПВЗ";
            this.btnPVZ.UseVisualStyleBackColor = true;
            this.btnPVZ.Click += new System.EventHandler(this.btnPVZ_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(287, 95);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(118, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Заказы";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(54, 343);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 30);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(154, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPVZ);
            this.Controls.Add(this.btntovar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.lblRole);
            this.Name = "Interface";
            this.Text = "Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntovar;
        private System.Windows.Forms.Button btnPVZ;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
    }
}