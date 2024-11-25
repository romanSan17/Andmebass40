namespace andmebaas_C_
{
    partial class Form2
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
            this.Nimetus_txt = new System.Windows.Forms.Label();
            this.Kogus_txt = new System.Windows.Forms.Label();
            this.Hind_txt = new System.Windows.Forms.Label();
            this.Nimetus = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.Hind = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new andmebaas_C_.AndmebaasSQLDataSet();
            this.Lisa = new System.Windows.Forms.Button();
            this.uuendaBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kustuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nimetus_txt
            // 
            this.Nimetus_txt.AutoSize = true;
            this.Nimetus_txt.Location = new System.Drawing.Point(65, 22);
            this.Nimetus_txt.Name = "Nimetus_txt";
            this.Nimetus_txt.Size = new System.Drawing.Size(45, 13);
            this.Nimetus_txt.TabIndex = 0;
            this.Nimetus_txt.Text = "Nimetus";
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.AutoSize = true;
            this.Kogus_txt.Location = new System.Drawing.Point(75, 60);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(37, 13);
            this.Kogus_txt.TabIndex = 1;
            this.Kogus_txt.Text = "Kogus";
            this.Kogus_txt.Click += new System.EventHandler(this.label2_Click);
            // 
            // Hind_txt
            // 
            this.Hind_txt.AllowDrop = true;
            this.Hind_txt.AutoSize = true;
            this.Hind_txt.Location = new System.Drawing.Point(75, 105);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(29, 13);
            this.Hind_txt.TabIndex = 2;
            this.Hind_txt.Text = "Hind";
            // 
            // Nimetus
            // 
            this.Nimetus.Location = new System.Drawing.Point(116, 19);
            this.Nimetus.Name = "Nimetus";
            this.Nimetus.Size = new System.Drawing.Size(100, 20);
            this.Nimetus.TabIndex = 3;
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(116, 60);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(100, 20);
            this.Kogus.TabIndex = 4;
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(116, 102);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(100, 20);
            this.Hind.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataBaseDataSetBindingSource
            // 
            this.dataBaseDataSetBindingSource.DataSource = this.dataBaseDataSet;
            this.dataBaseDataSetBindingSource.Position = 0;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lisa
            // 
            this.Lisa.Location = new System.Drawing.Point(77, 179);
            this.Lisa.Name = "Lisa";
            this.Lisa.Size = new System.Drawing.Size(75, 23);
            this.Lisa.TabIndex = 7;
            this.Lisa.Text = "Lisa";
            this.Lisa.UseVisualStyleBackColor = true;
            this.Lisa.Click += new System.EventHandler(this.Lisa_Click);
            // 
            // uuendaBTN
            // 
            this.uuendaBTN.Location = new System.Drawing.Point(158, 179);
            this.uuendaBTN.Name = "uuendaBTN";
            this.uuendaBTN.Size = new System.Drawing.Size(75, 23);
            this.uuendaBTN.TabIndex = 8;
            this.uuendaBTN.Text = "uuenda";
            this.uuendaBTN.UseVisualStyleBackColor = true;
            this.uuendaBTN.Click += new System.EventHandler(this.uuendaBTN_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 142);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kustuta
            // 
            this.kustuta.Location = new System.Drawing.Point(239, 179);
            this.kustuta.Name = "kustuta";
            this.kustuta.Size = new System.Drawing.Size(75, 23);
            this.kustuta.TabIndex = 10;
            this.kustuta.Text = "kustuta";
            this.kustuta.UseVisualStyleBackColor = true;
            this.kustuta.Click += new System.EventHandler(this.kustuta_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kustuta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uuendaBTN);
            this.Controls.Add(this.Lisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Nimetus);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Nimetus_txt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nimetus_txt;
        private System.Windows.Forms.Label Kogus_txt;
        private System.Windows.Forms.Label Hind_txt;
        private System.Windows.Forms.TextBox Nimetus;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
        private AndmebaasSQLDataSet dataBaseDataSet;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.Button uuendaBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kustuta;
    }
}