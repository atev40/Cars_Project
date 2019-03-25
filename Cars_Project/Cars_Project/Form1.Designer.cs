namespace Cars_Project
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.база_данни1DataSet = new Cars_Project.База_данни1DataSet();
            this.базаданни1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данни1DataSet1 = new Cars_Project.База_данни1DataSet1();
            this.idCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCarsTableAdapter = new Cars_Project.База_данни1DataSet1TableAdapters.IdCarsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.моделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.двигателDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.горивоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бройВратиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.новВносУпотребяванDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаданни1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.моделDataGridViewTextBoxColumn,
            this.годинаDataGridViewTextBoxColumn,
            this.двигателDataGridViewTextBoxColumn,
            this.горивоDataGridViewTextBoxColumn,
            this.бройВратиDataGridViewTextBoxColumn,
            this.новВносУпотребяванDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.idCarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // база_данни1DataSet
            // 
            this.база_данни1DataSet.DataSetName = "База_данни1DataSet";
            this.база_данни1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // базаданни1DataSetBindingSource
            // 
            this.базаданни1DataSetBindingSource.DataSource = this.база_данни1DataSet;
            this.базаданни1DataSetBindingSource.Position = 0;
            // 
            // база_данни1DataSet1
            // 
            this.база_данни1DataSet1.DataSetName = "База_данни1DataSet1";
            this.база_данни1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idCarsBindingSource
            // 
            this.idCarsBindingSource.DataMember = "IdCars";
            this.idCarsBindingSource.DataSource = this.база_данни1DataSet1;
            // 
            // idCarsTableAdapter
            // 
            this.idCarsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cars_Project.Properties.Resources.изтеглен_файл;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаданни1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource базаданни1DataSetBindingSource;
        private База_данни1DataSet база_данни1DataSet;
        private База_данни1DataSet1 база_данни1DataSet1;
        private System.Windows.Forms.BindingSource idCarsBindingSource;
        private База_данни1DataSet1TableAdapters.IdCarsTableAdapter idCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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

