namespace WindowsFormsApp2
{
    partial class AddEditTovarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtarticle = new System.Windows.Forms.TextBox();
            this.txtpostavshik = new System.Windows.Forms.TextBox();
            this.txtcnt = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcreator = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.btnaddtotable = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Скидка";
            // 
            // txtarticle
            // 
            this.txtarticle.Location = new System.Drawing.Point(184, 96);
            this.txtarticle.Name = "txtarticle";
            this.txtarticle.Size = new System.Drawing.Size(221, 20);
            this.txtarticle.TabIndex = 7;
            // 
            // txtpostavshik
            // 
            this.txtpostavshik.Location = new System.Drawing.Point(184, 202);
            this.txtpostavshik.Name = "txtpostavshik";
            this.txtpostavshik.Size = new System.Drawing.Size(221, 20);
            this.txtpostavshik.TabIndex = 8;
            // 
            // txtcnt
            // 
            this.txtcnt.Location = new System.Drawing.Point(184, 176);
            this.txtcnt.Name = "txtcnt";
            this.txtcnt.Size = new System.Drawing.Size(221, 20);
            this.txtcnt.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(184, 150);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(221, 20);
            this.txtprice.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(184, 124);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(221, 20);
            this.txtname.TabIndex = 11;
            // 
            // txtcreator
            // 
            this.txtcreator.Location = new System.Drawing.Point(184, 230);
            this.txtcreator.Name = "txtcreator";
            this.txtcreator.Size = new System.Drawing.Size(221, 20);
            this.txtcreator.TabIndex = 12;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(184, 257);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(221, 20);
            this.txtdiscount.TabIndex = 13;
            // 
            // btnaddtotable
            // 
            this.btnaddtotable.Location = new System.Drawing.Point(240, 318);
            this.btnaddtotable.Name = "btnaddtotable";
            this.btnaddtotable.Size = new System.Drawing.Size(138, 35);
            this.btnaddtotable.TabIndex = 14;
            this.btnaddtotable.Text = "Добавить и сохранить";
            this.btnaddtotable.UseVisualStyleBackColor = true;
            this.btnaddtotable.Click += new System.EventHandler(this.btnaddtotable_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(440, 107);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 13);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Описание";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(443, 123);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(270, 150);
            this.txtdesc.TabIndex = 16;
            // 
            // AddEditTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnaddtotable);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtcreator);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcnt);
            this.Controls.Add(this.txtpostavshik);
            this.Controls.Add(this.txtarticle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditTovarForm";
            this.Text = "AddTovarForm";
            this.Load += new System.EventHandler(this.AddEditTovarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtarticle;
        private System.Windows.Forms.TextBox txtpostavshik;
        private System.Windows.Forms.TextBox txtcnt;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcreator;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Button btnaddtotable;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtdesc;
    }
}