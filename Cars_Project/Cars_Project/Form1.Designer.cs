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
            this.idCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данни1DataSet1 = new Cars_Project.База_данни1DataSet4();
            this.база_данни1DataSet = new Cars_Project.База_данни1DataSet();
            this.базаданни1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCarsTableAdapter = new Cars_Project.База_данни1DataSet4TableAdapters.IdCarsTableAdapter();
            this.butContinue = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаданни1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCarsBindingSource
            // 
            this.idCarsBindingSource.DataMember = "IdCars";
            this.idCarsBindingSource.DataSource = this.база_данни1DataSet1;
            // 
            // база_данни1DataSet1
            // 
            this.база_данни1DataSet1.DataSetName = "База_данни1DataSet1";
            this.база_данни1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idCarsTableAdapter
            // 
            this.idCarsTableAdapter.ClearBeforeFill = true;
            // 
            // butContinue
            // 
            this.butContinue.BackColor = System.Drawing.Color.Wheat;
            this.butContinue.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butContinue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butContinue.Location = new System.Drawing.Point(541, 132);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(163, 97);
            this.butContinue.TabIndex = 0;
            this.butContinue.Text = "ПРОДЪЛЖИ";
            this.butContinue.UseVisualStyleBackColor = false;
            this.butContinue.Click += new System.EventHandler(this.butContinue_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Wheat;
            this.butExit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(24, 124);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(168, 97);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "ИЗХОД";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cars_Project.Properties.Resources.Без_име;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butContinue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данни1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаданни1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource базаданни1DataSetBindingSource;
        private База_данни1DataSet база_данни1DataSet;
        private База_данни1DataSet4 база_данни1DataSet1;
        private System.Windows.Forms.BindingSource idCarsBindingSource;
        private База_данни1DataSet4TableAdapters.IdCarsTableAdapter idCarsTableAdapter;
        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.Button butExit;
    }
}

