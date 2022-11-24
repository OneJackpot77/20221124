namespace WinFormsApp1
{
    partial class form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nevheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nemheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szuletettheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idheader,
            this.Nevheader,
            this.Nemheader,
            this.Szuletettheader});
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(724, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // Idheader
            // 
            this.Idheader.HeaderText = "Id";
            this.Idheader.Name = "Idheader";
            this.Idheader.ReadOnly = true;
            // 
            // Nevheader
            // 
            this.Nevheader.HeaderText = "Név";
            this.Nevheader.Name = "Nevheader";
            this.Nevheader.ReadOnly = true;
            // 
            // Nemheader
            // 
            this.Nemheader.HeaderText = "Nem";
            this.Nemheader.Name = "Nemheader";
            this.Nemheader.ReadOnly = true;
            // 
            // Szuletettheader
            // 
            this.Szuletettheader.HeaderText = "Született";
            this.Szuletettheader.Name = "Szuletettheader";
            this.Szuletettheader.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Idheader;
        private DataGridViewTextBoxColumn Nevheader;
        private DataGridViewTextBoxColumn Nemheader;
        private DataGridViewTextBoxColumn Szuletettheader;
        private Button button1;
    }
}