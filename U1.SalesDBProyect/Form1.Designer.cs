namespace U1.SalesDBProyect
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
            btnFilterCountry = new Button();
            dgvData = new DataGridView();
            cbxCountry = new ComboBox();
            label1 = new Label();
            btnShow = new Button();
            groupBox1 = new GroupBox();
            btnFilterGender = new Button();
            cbxGender = new ComboBox();
            label4 = new Label();
            btnFilterName = new Button();
            cbxName = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnGo = new Button();
            btnExportPDF = new Button();
            btnExportXML = new Button();
            btnExportJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFilterCountry
            // 
            btnFilterCountry.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterCountry.Location = new Point(16, 199);
            btnFilterCountry.Name = "btnFilterCountry";
            btnFilterCountry.Size = new Size(90, 30);
            btnFilterCountry.TabIndex = 0;
            btnFilterCountry.Text = "Filter";
            btnFilterCountry.UseVisualStyleBackColor = true;
            btnFilterCountry.Click += btnFilterCountry_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(245, 100);
            dgvData.Name = "dgvData";
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(654, 349);
            dgvData.TabIndex = 1;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // cbxCountry
            // 
            cbxCountry.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Location = new Point(16, 165);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new Size(121, 28);
            cbxCountry.TabIndex = 2;
            cbxCountry.SelectedIndexChanged += cbxCountry_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 142);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 4;
            label1.Text = "Country";
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(30, 23);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 30);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFilterGender);
            groupBox1.Controls.Add(cbxGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnFilterName);
            groupBox1.Controls.Add(cbxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxCountry);
            groupBox1.Controls.Add(btnFilterCountry);
            groupBox1.Location = new Point(30, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 358);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnFilterGender
            // 
            btnFilterGender.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterGender.Location = new Point(16, 306);
            btnFilterGender.Name = "btnFilterGender";
            btnFilterGender.Size = new Size(90, 30);
            btnFilterGender.TabIndex = 12;
            btnFilterGender.Text = "Filter";
            btnFilterGender.UseVisualStyleBackColor = true;
            btnFilterGender.Click += btnFilterGender_Click;
            // 
            // cbxGender
            // 
            cbxGender.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(16, 272);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(121, 28);
            cbxGender.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 249);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 10;
            label4.Text = "Gender";
            // 
            // btnFilterName
            // 
            btnFilterName.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterName.Location = new Point(16, 76);
            btnFilterName.Name = "btnFilterName";
            btnFilterName.Size = new Size(90, 30);
            btnFilterName.TabIndex = 9;
            btnFilterName.Text = "Filter";
            btnFilterName.UseVisualStyleBackColor = true;
            btnFilterName.Click += btnFilterName_Click;
            // 
            // cbxName
            // 
            cbxName.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxName.FormattingEnabled = true;
            cbxName.Location = new Point(16, 42);
            cbxName.Name = "cbxName";
            cbxName.Size = new Size(121, 28);
            cbxName.TabIndex = 8;
            cbxName.SelectedIndexChanged += cbxName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Country";
            // 
            // btnGo
            // 
            btnGo.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGo.Location = new Point(928, 522);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(71, 30);
            btnGo.TabIndex = 13;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportPDF.Location = new Point(67, 478);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(100, 49);
            btnExportPDF.TabIndex = 13;
            btnExportPDF.Text = "PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnExportXML
            // 
            btnExportXML.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportXML.Location = new Point(197, 478);
            btnExportXML.Name = "btnExportXML";
            btnExportXML.Size = new Size(100, 49);
            btnExportXML.TabIndex = 14;
            btnExportXML.Text = "XML";
            btnExportXML.UseVisualStyleBackColor = true;
            btnExportXML.Click += btnExportXML_Click;
            // 
            // btnExportJson
            // 
            btnExportJson.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportJson.Location = new Point(326, 478);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(100, 49);
            btnExportJson.TabIndex = 15;
            btnExportJson.Text = "JSON";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 564);
            Controls.Add(btnExportJson);
            Controls.Add(btnExportXML);
            Controls.Add(btnExportPDF);
            Controls.Add(btnGo);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnShow);
            Controls.Add(dgvData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilterCountry;
        private DataGridView dgvData;
        private ComboBox cbxCountry;
        private Label label1;
        private Button btnShow;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnFilterName;
        private ComboBox cbxName;
        private Label label3;
        private Button btnFilterGender;
        private ComboBox cbxGender;
        private Label label4;
        private Button btnGo;
        private Button btnExportPDF;
        private Button btnExportXML;
        private Button btnExportJson;
    }
}
