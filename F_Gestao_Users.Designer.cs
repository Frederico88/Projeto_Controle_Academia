namespace SQLite_Project
{
    partial class F_Gestao_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.nud_level = new System.Windows.Forms.NumericUpDown();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exclude = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "D= Desligado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "B= Bloqueado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "A= Ativo";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(8, 142);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(33, 13);
            this.lb_level.TabIndex = 25;
            this.lb_level.Text = "Nível";
            // 
            // nud_level
            // 
            this.nud_level.Location = new System.Drawing.Point(8, 161);
            this.nud_level.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_level.Name = "nud_level";
            this.nud_level.Size = new System.Drawing.Size(120, 20);
            this.nud_level.TabIndex = 24;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(134, 143);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 23;
            this.lb_status.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(134, 160);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 22;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 34);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(243, 20);
            this.tb_nome.TabIndex = 21;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 17);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 20;
            this.lb_name.Text = "Nome";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(134, 107);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(121, 20);
            this.tb_password.TabIndex = 19;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(134, 90);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(38, 13);
            this.lb_password.TabIndex = 18;
            this.lb_password.Text = "Senha";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 107);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 17;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 90);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(43, 13);
            this.lb_username.TabIndex = 16;
            this.lb_username.Text = "Usuário";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(276, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(88, 20);
            this.tb_id.TabIndex = 30;
            this.tb_id.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(276, 17);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 29;
            this.lb_id.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exclude);
            this.panel1.Controls.Add(this.btn_saveChanges);
            this.panel1.Controls.Add(this.btn_newUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 31);
            this.panel1.TabIndex = 31;
            // 
            // btn_exclude
            // 
            this.btn_exclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclude.Location = new System.Drawing.Point(228, 4);
            this.btn_exclude.Name = "btn_exclude";
            this.btn_exclude.Size = new System.Drawing.Size(104, 23);
            this.btn_exclude.TabIndex = 2;
            this.btn_exclude.Text = "Excluir Usuário";
            this.btn_exclude.UseVisualStyleBackColor = true;
            this.btn_exclude.Click += new System.EventHandler(this.btn_exclude_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveChanges.Location = new System.Drawing.Point(118, 4);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(104, 23);
            this.btn_saveChanges.TabIndex = 1;
            this.btn_saveChanges.Text = "Salvar Alterações";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newUser.Location = new System.Drawing.Point(8, 4);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(104, 23);
            this.btn_newUser.TabIndex = 0;
            this.btn_newUser.Text = "Novo Usuário";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.Location = new System.Drawing.Point(370, 31);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(293, 216);
            this.dgv_users.TabIndex = 32;
            this.dgv_users.SelectionChanged += new System.EventHandler(this.dgv_users_SelectionChanged);
            // 
            // F_Gestao_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 344);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.nud_level);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Gestao_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão dos Usuários";
            this.Load += new System.EventHandler(this.F_Gestao_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.NumericUpDown nud_level;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_exclude;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_newUser;
    }
}