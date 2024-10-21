namespace PSP.View
{
    partial class FormDisciplines
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
            this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisciplines
            // 
            this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplines.Location = new System.Drawing.Point(66, 22);
            this.dataGridViewDisciplines.Name = "dataGridView1";
            this.dataGridViewDisciplines.Size = new System.Drawing.Size(650, 341);
            this.dataGridViewDisciplines.TabIndex = 0;
            
            // 
            // FormDisciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDisciplines);
            this.Name = "FormDisciplines";
            this.Text = "FormDisciplines";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisciplines;
    }
}