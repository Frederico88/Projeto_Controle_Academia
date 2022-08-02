namespace SQLite_Project
{
    partial class F_New_User
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
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.nud_level = new System.Windows.Forms.NumericUpDown();
            this.lb_level = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 90);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(43, 13);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Usuário";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 107);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(134, 107);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(121, 20);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(134, 90);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(38, 13);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Senha";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 34);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(243, 20);
            this.tb_nome.TabIndex = 5;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 17);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Nome";
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
            this.cb_status.TabIndex = 9;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(134, 143);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 10;
            this.lb_status.Text = "Status";
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
            this.nud_level.TabIndex = 11;
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(8, 142);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(33, 13);
            this.lb_level.TabIndex = 12;
            this.lb_level.Text = "Nível";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "A= Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "B= Bloqueado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "D= Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 29);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Location = new System.Drawing.Point(3, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Novo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(84, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(165, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Redefinir";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(246, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // F_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 300);
            this.Controls.Add(this.panel1);
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
            this.Name = "F_New_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.F_New_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.NumericUpDown nud_level;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
    }
}