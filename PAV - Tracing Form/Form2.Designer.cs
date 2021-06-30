
namespace PAV___Tracing_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing Form ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.StreetAdd,
            this.City,
            this.Province,
            this.PostalCode,
            this.Sex,
            this.DateOfBirth});
            this.dataGridView1.Location = new System.Drawing.Point(6, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 387);
            this.dataGridView1.TabIndex = 3;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // StreetAdd
            // 
            this.StreetAdd.HeaderText = "Street address";
            this.StreetAdd.MinimumWidth = 6;
            this.StreetAdd.Name = "StreetAdd";
            this.StreetAdd.ReadOnly = true;
            this.StreetAdd.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.MinimumWidth = 6;
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            this.Province.Width = 125;
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "Postal code";
            this.PostalCode.MinimumWidth = 6;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            this.PostalCode.Width = 125;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
    }
}