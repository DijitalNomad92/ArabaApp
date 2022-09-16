namespace ArabaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArabalar = new System.Windows.Forms.DataGridView();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bDetay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.dvfFiltrele = new System.Windows.Forms.DataGridView();
            this.bFiltrele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVites = new System.Windows.Forms.TextBox();
            this.bVitesDetay = new System.Windows.Forms.Button();
            this.dvfVites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArabalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvfFiltrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvfVites)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArabalar
            // 
            this.dgvArabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArabalar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArabalar.Location = new System.Drawing.Point(3, -3);
            this.dgvArabalar.Name = "dgvArabalar";
            this.dgvArabalar.RowHeadersWidth = 62;
            this.dgvArabalar.RowTemplate.Height = 33;
            this.dgvArabalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArabalar.Size = new System.Drawing.Size(823, 174);
            this.dgvArabalar.TabIndex = 0;
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(981, 21);
            this.nudId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(134, 31);
            this.nudId.TabIndex = 1;
            this.nudId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id: ";
            // 
            // bDetay
            // 
            this.bDetay.Location = new System.Drawing.Point(910, 85);
            this.bDetay.Name = "bDetay";
            this.bDetay.Size = new System.Drawing.Size(112, 34);
            this.bDetay.TabIndex = 3;
            this.bDetay.Text = "Detay";
            this.bDetay.UseVisualStyleBackColor = true;
            this.bDetay.Click += new System.EventHandler(this.bDetay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model: ";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(104, 210);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(150, 31);
            this.tbMarka.TabIndex = 6;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(104, 256);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(150, 31);
            this.tbModel.TabIndex = 7;
            // 
            // dvfFiltrele
            // 
            this.dvfFiltrele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvfFiltrele.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvfFiltrele.Location = new System.Drawing.Point(429, 177);
            this.dvfFiltrele.Name = "dvfFiltrele";
            this.dvfFiltrele.RowHeadersWidth = 62;
            this.dvfFiltrele.RowTemplate.Height = 33;
            this.dvfFiltrele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvfFiltrele.Size = new System.Drawing.Size(632, 132);
            this.dvfFiltrele.TabIndex = 8;
            // 
            // bFiltrele
            // 
            this.bFiltrele.Location = new System.Drawing.Point(280, 229);
            this.bFiltrele.Name = "bFiltrele";
            this.bFiltrele.Size = new System.Drawing.Size(112, 34);
            this.bFiltrele.TabIndex = 9;
            this.bFiltrele.Text = "Filtrele";
            this.bFiltrele.UseVisualStyleBackColor = true;
            this.bFiltrele.Click += new System.EventHandler(this.bFiltrele_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vites: ";
            // 
            // tbVites
            // 
            this.tbVites.Location = new System.Drawing.Point(104, 370);
            this.tbVites.Name = "tbVites";
            this.tbVites.Size = new System.Drawing.Size(150, 31);
            this.tbVites.TabIndex = 12;
            // 
            // bVitesDetay
            // 
            this.bVitesDetay.Location = new System.Drawing.Point(280, 367);
            this.bVitesDetay.Name = "bVitesDetay";
            this.bVitesDetay.Size = new System.Drawing.Size(112, 34);
            this.bVitesDetay.TabIndex = 13;
            this.bVitesDetay.Text = "Detay";
            this.bVitesDetay.UseVisualStyleBackColor = true;
            this.bVitesDetay.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvfVites
            // 
            this.dvfVites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvfVites.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvfVites.Location = new System.Drawing.Point(429, 315);
            this.dvfVites.Name = "dvfVites";
            this.dvfVites.RowHeadersWidth = 62;
            this.dvfVites.RowTemplate.Height = 33;
            this.dvfVites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvfVites.Size = new System.Drawing.Size(632, 133);
            this.dvfVites.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 475);
            this.Controls.Add(this.dvfVites);
            this.Controls.Add(this.bVitesDetay);
            this.Controls.Add(this.tbVites);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bFiltrele);
            this.Controls.Add(this.dvfFiltrele);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDetay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.dgvArabalar);
            this.Name = "Form1";
            this.Text = "Arabalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArabalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvfFiltrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvfVites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvArabalar;
        private NumericUpDown nudId;
        private Label label1;
        private Button bDetay;
        private Label label2;
        private Label label3;
        private TextBox tbMarka;
        private TextBox tbModel;
        private DataGridView dvfFiltrele;
        private Button bFiltrele;
        private Label label5;
        private TextBox tbVites;
        private Button bVitesDetay;
        private DataGridView dvfVites;
    }
}