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
            this.база_данни1DataSet1 = new Cars_Project.База_данни1DataSet1();
            this.база_данни1DataSet = new Cars_Project.База_данни1DataSet();
            this.базаданни1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCarsTableAdapter = new Cars_Project.База_данни1DataSet1TableAdapters.IdCarsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(593, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "ПРОДЪЛЖИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Wheat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "ИЗХОД";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cars_Project.Properties.Resources.Без_име;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private База_данни1DataSet1 база_данни1DataSet1;
        private System.Windows.Forms.BindingSource idCarsBindingSource;
        private База_данни1DataSet1TableAdapters.IdCarsTableAdapter idCarsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

