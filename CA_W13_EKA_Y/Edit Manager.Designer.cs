namespace CA_W13_EKA_Y
{
    partial class Edit_Manager
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
            this.comb_team = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_working = new System.Windows.Forms.DataGridView();
            this.dgv_unemployed = new System.Windows.Forms.DataGridView();
            this.lbl_work = new System.Windows.Forms.Label();
            this.lbl_not = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_working)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unemployed)).BeginInit();
            this.SuspendLayout();
            // 
            // comb_team
            // 
            this.comb_team.FormattingEnabled = true;
            this.comb_team.Location = new System.Drawing.Point(27, 21);
            this.comb_team.Name = "comb_team";
            this.comb_team.Size = new System.Drawing.Size(121, 21);
            this.comb_team.TabIndex = 0;
            this.comb_team.SelectedIndexChanged += new System.EventHandler(this.comb_team_SelectedIndexChanged);
            this.comb_team.SelectionChangeCommitted += new System.EventHandler(this.comb_team_SelectionChangeCommitted);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(161, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_working
            // 
            this.dgv_working.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_working.Location = new System.Drawing.Point(27, 83);
            this.dgv_working.Name = "dgv_working";
            this.dgv_working.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_working.Size = new System.Drawing.Size(719, 83);
            this.dgv_working.TabIndex = 2;
            // 
            // dgv_unemployed
            // 
            this.dgv_unemployed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_unemployed.Location = new System.Drawing.Point(27, 195);
            this.dgv_unemployed.Name = "dgv_unemployed";
            this.dgv_unemployed.Size = new System.Drawing.Size(719, 243);
            this.dgv_unemployed.TabIndex = 3;
            // 
            // lbl_work
            // 
            this.lbl_work.AutoSize = true;
            this.lbl_work.Location = new System.Drawing.Point(33, 64);
            this.lbl_work.Name = "lbl_work";
            this.lbl_work.Size = new System.Drawing.Size(47, 13);
            this.lbl_work.TabIndex = 4;
            this.lbl_work.Text = "Working";
            // 
            // lbl_not
            // 
            this.lbl_not.AutoSize = true;
            this.lbl_not.Location = new System.Drawing.Point(30, 176);
            this.lbl_not.Name = "lbl_not";
            this.lbl_not.Size = new System.Drawing.Size(67, 13);
            this.lbl_not.TabIndex = 5;
            this.lbl_not.Text = "Not Working";
            // 
            // Edit_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_not);
            this.Controls.Add(this.lbl_work);
            this.Controls.Add(this.dgv_unemployed);
            this.Controls.Add(this.dgv_working);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.comb_team);
            this.Name = "Edit_Manager";
            this.Text = "Edit_Manager";
            this.Load += new System.EventHandler(this.Edit_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_working)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unemployed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comb_team;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_working;
        private System.Windows.Forms.DataGridView dgv_unemployed;
        private System.Windows.Forms.Label lbl_work;
        private System.Windows.Forms.Label lbl_not;
    }
}