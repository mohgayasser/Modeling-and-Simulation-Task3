namespace BearingMachineSimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BearingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomBear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BearLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accumulated_BearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalDelay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BearingNumber,
            this.RandomBear,
            this.BearLife,
            this.Accumulated_BearingLife,
            this.RandomDelay,
            this.DelayTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // BearingNumber
            // 
            this.BearingNumber.HeaderText = "BearingNumber";
            this.BearingNumber.Name = "BearingNumber";
            // 
            // RandomBear
            // 
            this.RandomBear.HeaderText = "RandomBear";
            this.RandomBear.Name = "RandomBear";
            // 
            // BearLife
            // 
            this.BearLife.HeaderText = "BearLife";
            this.BearLife.Name = "BearLife";
            // 
            // Accumulated_BearingLife
            // 
            this.Accumulated_BearingLife.HeaderText = "Accumulated_BearingLife";
            this.Accumulated_BearingLife.Name = "Accumulated_BearingLife";
            // 
            // RandomDelay
            // 
            this.RandomDelay.HeaderText = "RandomDelay";
            this.RandomDelay.Name = "RandomDelay";
            // 
            // DelayTime
            // 
            this.DelayTime.HeaderText = "DelayTime";
            this.DelayTime.Name = "DelayTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(819, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Delay";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TotalDelay
            // 
            this.TotalDelay.Location = new System.Drawing.Point(823, 161);
            this.TotalDelay.Name = "TotalDelay";
            this.TotalDelay.Size = new System.Drawing.Size(133, 20);
            this.TotalDelay.TabIndex = 4;
            this.TotalDelay.TextChanged += new System.EventHandler(this.NumofBearing_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalDelay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomBear;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accumulated_BearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalDelay;
    }
}