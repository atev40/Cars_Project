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
            this.idCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данни1DataSet = new Cars_Project.База_данни1DataSet();
            this.idCarsTableAdapter = new Cars_Project.База_данни1DataSetTableAdapters.IdCarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idCarsBindingSource
            // 
            this.idCarsBindingSource.DataMember = "IdCars";
            this.idCarsBindingSource.DataSource = this.база_данни1DataSet;
            // 
            // база_данни1DataSet
            // 
            this.база_данни1DataSet.DataSetName = "База_данни1DataSet";
            this.база_данни1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idCarsTableAdapter
            // 
            this.idCarsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private База_данни1DataSet база_данни1DataSet;
        private System.Windows.Forms.BindingSource idCarsBindingSource;
        private База_данни1DataSetTableAdapters.IdCarsTableAdapter idCarsTableAdapter;
    }
}