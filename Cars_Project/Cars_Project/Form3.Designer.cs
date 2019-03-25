namespace Cars_Project
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.база_данни1DataSet = new Cars_Project.База_данни1DataSet();
            this.idCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCarsTableAdapter = new Cars_Project.База_данни1DataSetTableAdapters.IdCarsTableAdapter();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.моделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.двигателDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.горивоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бройВратиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.новВносУпотребяванDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(703, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(183, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(175, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.маркаDataGridViewTextBoxColumn,
            this.моделDataGridViewTextBoxColumn,
            this.годинаDataGridViewTextBoxColumn,
            this.двигателDataGridViewTextBoxColumn,
            this.горивоDataGridViewTextBoxColumn,
            this.бройВратиDataGridViewTextBoxColumn,
            this.новВносУпотребяванDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.idCarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // база_данни1DataSet
            // 
            this.база_данни1DataSet.DataSetName = "База_данни1DataSet";
            this.база_данни1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idCarsBindingSource
            // 
            this.idCarsBindingSource.DataMember = "IdCars";
            this.idCarsBindingSource.DataSource = this.база_данни1DataSet;
            // 
            // idCarsTableAdapter
            // 
            this.idCarsTableAdapter.ClearBeforeFill = true;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            // 
            // моделDataGridViewTextBoxColumn
            // 
            this.моделDataGridViewTextBoxColumn.DataPropertyName = "Модел";
            this.моделDataGridViewTextBoxColumn.HeaderText = "Модел";
            this.моделDataGridViewTextBoxColumn.Name = "моделDataGridViewTextBoxColumn";
            // 
            // годинаDataGridViewTextBoxColumn
            // 
            this.годинаDataGridViewTextBoxColumn.DataPropertyName = "Година";
            this.годинаDataGridViewTextBoxColumn.HeaderText = "Година";
            this.годинаDataGridViewTextBoxColumn.Name = "годинаDataGridViewTextBoxColumn";
            // 
            // двигателDataGridViewTextBoxColumn
            // 
            this.двигателDataGridViewTextBoxColumn.DataPropertyName = "Двигател";
            this.двигателDataGridViewTextBoxColumn.HeaderText = "Двигател";
            this.двигателDataGridViewTextBoxColumn.Name = "двигателDataGridViewTextBoxColumn";
            // 
            // горивоDataGridViewTextBoxColumn
            // 
            this.горивоDataGridViewTextBoxColumn.DataPropertyName = "Гориво";
            this.горивоDataGridViewTextBoxColumn.HeaderText = "Гориво";
            this.горивоDataGridViewTextBoxColumn.Name = "горивоDataGridViewTextBoxColumn";
            // 
            // бройВратиDataGridViewTextBoxColumn
            // 
            this.бройВратиDataGridViewTextBoxColumn.DataPropertyName = "Брой врати";
            this.бройВратиDataGridViewTextBoxColumn.HeaderText = "Брой врати";
            this.бройВратиDataGridViewTextBoxColumn.Name = "бройВратиDataGridViewTextBoxColumn";
            // 
            // новВносУпотребяванDataGridViewTextBoxColumn
            // 
            this.новВносУпотребяванDataGridViewTextBoxColumn.DataPropertyName = "Нов внос/Употребяван";
            this.новВносУпотребяванDataGridViewTextBoxColumn.HeaderText = "Нов внос/Употребяван";
            this.новВносУпотребяванDataGridViewTextBoxColumn.Name = "новВносУпотребяванDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данни1DataSet база_данни1DataSet;
        private System.Windows.Forms.BindingSource idCarsBindingSource;
        private База_данни1DataSetTableAdapters.IdCarsTableAdapter idCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn моделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn двигателDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn горивоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бройВратиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn новВносУпотребяванDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}