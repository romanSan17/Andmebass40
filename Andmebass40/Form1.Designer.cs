﻿namespace Andmebass40
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Nimetustxt = new System.Windows.Forms.TextBox();
            this.Kogustxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hindtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toodeDataSet = new Andmebass40.ToodeDataSet();
            this.toodeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LisaBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            // 
            // Nimetustxt
            // 
            this.Nimetustxt.Location = new System.Drawing.Point(141, 75);
            this.Nimetustxt.Name = "Nimetustxt";
            this.Nimetustxt.Size = new System.Drawing.Size(100, 20);
            this.Nimetustxt.TabIndex = 1;
            // 
            // Kogustxt
            // 
            this.Kogustxt.Location = new System.Drawing.Point(141, 126);
            this.Kogustxt.Name = "Kogustxt";
            this.Kogustxt.Size = new System.Drawing.Size(100, 20);
            this.Kogustxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogu";
            // 
            // Hindtxt
            // 
            this.Hindtxt.Location = new System.Drawing.Point(141, 177);
            this.Hindtxt.Name = "Hindtxt";
            this.Hindtxt.Size = new System.Drawing.Size(100, 20);
            this.Hindtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hind";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // toodeDataSet
            // 
            this.toodeDataSet.DataSetName = "ToodeDataSet";
            this.toodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodeDataSetBindingSource
            // 
            this.toodeDataSetBindingSource.DataSource = this.toodeDataSet;
            this.toodeDataSetBindingSource.Position = 0;
            // 
            // LisaBut
            // 
            this.LisaBut.Location = new System.Drawing.Point(82, 203);
            this.LisaBut.Name = "LisaBut";
            this.LisaBut.Size = new System.Drawing.Size(80, 37);
            this.LisaBut.TabIndex = 7;
            this.LisaBut.Text = "Lisa";
            this.LisaBut.UseVisualStyleBackColor = true;
            this.LisaBut.Click += new System.EventHandler(this.LisaBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LisaBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hindtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kogustxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nimetustxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nimetustxt;
        private System.Windows.Forms.TextBox Kogustxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hindtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource toodeDataSetBindingSource;
        private ToodeDataSet toodeDataSet;
        private System.Windows.Forms.Button LisaBut;
    }
}
