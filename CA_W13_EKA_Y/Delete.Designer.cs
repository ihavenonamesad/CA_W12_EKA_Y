namespace CA_W13_EKA_Y
{
    partial class Delete
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
            this.comb_team = new System.Windows.Forms.ComboBox();
            this.lbl_Team = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // comb_team
            // 
            this.comb_team.FormattingEnabled = true;
            this.comb_team.Location = new System.Drawing.Point(44, 47);
            this.comb_team.Name = "comb_team";
            this.comb_team.Size = new System.Drawing.Size(121, 21);
            this.comb_team.TabIndex = 1;
            this.comb_team.SelectedIndexChanged += new System.EventHandler(this.comb_team_SelectedIndexChanged);
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.Location = new System.Drawing.Point(52, 31);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(34, 13);
            this.lbl_Team.TabIndex = 2;
            this.lbl_Team.Text = "Team";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(185, 47);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lbl_Team);
            this.Controls.Add(this.comb_team);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comb_team;
        private System.Windows.Forms.Label lbl_Team;
        private System.Windows.Forms.Button btn_del;
    }
}