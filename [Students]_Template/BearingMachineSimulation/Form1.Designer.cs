namespace BearingMachineSimulation
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
            this.NumofHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumofBearing = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.BearingCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Downtime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Repairperson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RepairTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Repair2Time = new System.Windows.Forms.TextBox();
            this.BearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumPropability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandamDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NumofHours
            // 
            this.NumofHours.Location = new System.Drawing.Point(182, 58);
            this.NumofHours.Name = "NumofHours";
            this.NumofHours.Size = new System.Drawing.Size(133, 20);
            this.NumofHours.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num of Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num of Bearing";
            // 
            // NumofBearing
            // 
            this.NumofBearing.Location = new System.Drawing.Point(182, 118);
            this.NumofBearing.Name = "NumofBearing";
            this.NumofBearing.Size = new System.Drawing.Size(133, 20);
            this.NumofBearing.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BearingLife,
            this.Propability,
            this.CumPropability,
            this.RandamDigit});
            this.dataGridView1.Location = new System.Drawing.Point(72, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(573, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bearing Life distribution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delay time distribution";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(577, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "BearingLife";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Propability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CumPropability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "RandamDigit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(61, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bearing Cost ";
            // 
            // BearingCost
            // 
            this.BearingCost.Location = new System.Drawing.Point(59, 474);
            this.BearingCost.Name = "BearingCost";
            this.BearingCost.Size = new System.Drawing.Size(133, 20);
            this.BearingCost.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(374, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Downtime Cost ";
            // 
            // Downtime
            // 
            this.Downtime.Location = new System.Drawing.Point(378, 474);
            this.Downtime.Name = "Downtime";
            this.Downtime.Size = new System.Drawing.Size(133, 20);
            this.Downtime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(689, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repairperson Cost ";
            // 
            // Repairperson
            // 
            this.Repairperson.Location = new System.Drawing.Point(711, 474);
            this.Repairperson.Name = "Repairperson";
            this.Repairperson.Size = new System.Drawing.Size(133, 20);
            this.Repairperson.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(86, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Repair Time/Bearing ";
            // 
            // RepairTime
            // 
            this.RepairTime.Location = new System.Drawing.Point(84, 569);
            this.RepairTime.Name = "RepairTime";
            this.RepairTime.Size = new System.Drawing.Size(44, 20);
            this.RepairTime.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(129, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "hour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(605, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "hour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(562, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Repair Time/All Bearing ";
            // 
            // Repair2Time
            // 
            this.Repair2Time.Location = new System.Drawing.Point(560, 569);
            this.Repair2Time.Name = "Repair2Time";
            this.Repair2Time.Size = new System.Drawing.Size(44, 20);
            this.Repair2Time.TabIndex = 19;
            // 
            // BearingLife
            // 
            this.BearingLife.HeaderText = "DelayTime";
            this.BearingLife.Name = "BearingLife";
            // 
            // Propability
            // 
            this.Propability.HeaderText = "Propability";
            this.Propability.Name = "Propability";
            // 
            // CumPropability
            // 
            this.CumPropability.HeaderText = "CumPropability";
            this.CumPropability.Name = "CumPropability";
            // 
            // RandamDigit
            // 
            this.RandamDigit.HeaderText = "RandamDigit";
            this.RandamDigit.Name = "RandamDigit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 644);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Repair2Time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RepairTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Repairperson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Downtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BearingCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumofBearing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumofHours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumofHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumofBearing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BearingCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Downtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Repairperson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RepairTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Repair2Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumPropability;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandamDigit;
    }
}