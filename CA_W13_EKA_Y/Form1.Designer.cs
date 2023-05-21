namespace CA_W13_EKA_Y
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_nat = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_tname = new System.Windows.Forms.Label();
            this.comb_team = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comb_nat = new System.Windows.Forms.ComboBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_numb = new System.Windows.Forms.TextBox();
            this.comb_pos = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(28, 106);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(12, 139);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(77, 13);
            this.lbl_team.TabIndex = 2;
            this.lbl_team.Text = "Team Number:";
            // 
            // lbl_nat
            // 
            this.lbl_nat.AutoSize = true;
            this.lbl_nat.Location = new System.Drawing.Point(21, 169);
            this.lbl_nat.Name = "lbl_nat";
            this.lbl_nat.Size = new System.Drawing.Size(59, 13);
            this.lbl_nat.TabIndex = 3;
            this.lbl_nat.Text = "Nationality:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(103, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(94, 237);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(191, 20);
            this.txt_height.TabIndex = 6;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(28, 237);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(41, 13);
            this.lbl_height.TabIndex = 7;
            this.lbl_height.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(29, 272);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(44, 13);
            this.lbl_weight.TabIndex = 9;
            this.lbl_weight.Text = "Weight:";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(28, 310);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(52, 13);
            this.lbl_birth.TabIndex = 10;
            this.lbl_birth.Text = "Birthdate:";
            // 
            // lbl_tname
            // 
            this.lbl_tname.AutoSize = true;
            this.lbl_tname.Location = new System.Drawing.Point(28, 341);
            this.lbl_tname.Name = "lbl_tname";
            this.lbl_tname.Size = new System.Drawing.Size(68, 13);
            this.lbl_tname.TabIndex = 11;
            this.lbl_tname.Text = "Team Name:";
            // 
            // comb_team
            // 
            this.comb_team.FormattingEnabled = true;
            this.comb_team.Location = new System.Drawing.Point(103, 338);
            this.comb_team.Name = "comb_team";
            this.comb_team.Size = new System.Drawing.Size(121, 21);
            this.comb_team.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comb_nat
            // 
            this.comb_nat.FormattingEnabled = true;
            this.comb_nat.Location = new System.Drawing.Point(103, 161);
            this.comb_nat.Name = "comb_nat";
            this.comb_nat.Size = new System.Drawing.Size(121, 21);
            this.comb_nat.TabIndex = 14;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(94, 265);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(191, 20);
            this.txt_weight.TabIndex = 15;
            // 
            // txt_numb
            // 
            this.txt_numb.Location = new System.Drawing.Point(103, 132);
            this.txt_numb.Name = "txt_numb";
            this.txt_numb.Size = new System.Drawing.Size(191, 20);
            this.txt_numb.TabIndex = 16;
            // 
            // comb_pos
            // 
            this.comb_pos.FormattingEnabled = true;
            this.comb_pos.Items.AddRange(new object[] {
            "G",
            "D",
            "M",
            "F"});
            this.comb_pos.Location = new System.Drawing.Point(103, 202);
            this.comb_pos.Name = "comb_pos";
            this.comb_pos.Size = new System.Drawing.Size(121, 21);
            this.comb_pos.TabIndex = 21;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(103, 382);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editManagerToolStripMenuItem,
            this.removePlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            // 
            // editManagerToolStripMenuItem
            // 
            this.editManagerToolStripMenuItem.Name = "editManagerToolStripMenuItem";
            this.editManagerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.editManagerToolStripMenuItem.Text = "Edit Manager";
            this.editManagerToolStripMenuItem.Click += new System.EventHandler(this.editManagerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comb_pos);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_numb);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.comb_nat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comb_team);
            this.Controls.Add(this.lbl_tname);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_nat);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_nat;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_tname;
        private System.Windows.Forms.ComboBox comb_team;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comb_nat;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_numb;
        private System.Windows.Forms.ComboBox comb_pos;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

