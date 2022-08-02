namespace SQLite_Project
{
    partial class F_SQLite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.lb_acessoEsc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestãoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lb_usuario);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.lb_acessoEsc);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 56);
            this.panel1.TabIndex = 0;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(186, 22);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(16, 13);
            this.lb_usuario.TabIndex = 4;
            this.lb_usuario.Text = "---";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(141, 23);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(49, 13);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "Usuário: ";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(112, 23);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // lb_acessoEsc
            // 
            this.lb_acessoEsc.AutoSize = true;
            this.lb_acessoEsc.Location = new System.Drawing.Point(68, 23);
            this.lb_acessoEsc.Name = "lb_acessoEsc";
            this.lb_acessoEsc.Size = new System.Drawing.Size(48, 13);
            this.lb_acessoEsc.TabIndex = 1;
            this.lb_acessoEsc.Text = "Acesso: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.logINToolStripMenuItem,
            this.logOFFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gestãoDeUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // gestãoDeUsuárioToolStripMenuItem
            // 
            this.gestãoDeUsuárioToolStripMenuItem.Name = "gestãoDeUsuárioToolStripMenuItem";
            this.gestãoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsuárioToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuárioToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.gestãoDeTurmasToolStripMenuItem,
            this.gestãoDeAlunosToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // gestãoDeTurmasToolStripMenuItem
            // 
            this.gestãoDeTurmasToolStripMenuItem.Name = "gestãoDeTurmasToolStripMenuItem";
            this.gestãoDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoDeTurmasToolStripMenuItem.Text = "Gestão de Turmas";
            this.gestãoDeTurmasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeTurmasToolStripMenuItem_Click);
            // 
            // logINToolStripMenuItem
            // 
            this.logINToolStripMenuItem.Name = "logINToolStripMenuItem";
            this.logINToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.logINToolStripMenuItem.Text = "LogIN";
            this.logINToolStripMenuItem.Click += new System.EventHandler(this.logINToolStripMenuItem_Click);
            // 
            // logOFFToolStripMenuItem
            // 
            this.logOFFToolStripMenuItem.Name = "logOFFToolStripMenuItem";
            this.logOFFToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOFFToolStripMenuItem.Text = "LogOFF";
            this.logOFFToolStripMenuItem.Click += new System.EventHandler(this.logOFFToolStripMenuItem_Click);
            // 
            // gestãoDeAlunosToolStripMenuItem
            // 
            this.gestãoDeAlunosToolStripMenuItem.Name = "gestãoDeAlunosToolStripMenuItem";
            this.gestãoDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoDeAlunosToolStripMenuItem.Text = "Gestão de Alunos";
            this.gestãoDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAlunosToolStripMenuItem_Click);
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::SQLite_Project.Properties.Resources.png_transparent_light_emitting_diode_computer_icons_light_camera_lens_light_led_thumbnail;
            this.pb_ledLogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(48, 51);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // F_SQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_SQLite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Academia - Frederico Rezende (V1.0)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_acessoEsc;
        public System.Windows.Forms.Label lb_usuario;
        public System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAlunosToolStripMenuItem;
    }
}