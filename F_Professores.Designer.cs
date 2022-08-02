namespace SQLite_Project
{
    partial class F_Professores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exclude = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_nameProf = new System.Windows.Forms.Label();
            this.lb_Tel = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.mtb_professores = new System.Windows.Forms.MaskedTextBox();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exclude);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_exclude
            // 
            this.btn_exclude.Location = new System.Drawing.Point(325, 13);
            this.btn_exclude.Name = "btn_exclude";
            this.btn_exclude.Size = new System.Drawing.Size(155, 23);
            this.btn_exclude.TabIndex = 2;
            this.btn_exclude.Text = "Excluir Professor";
            this.btn_exclude.UseVisualStyleBackColor = true;
            this.btn_exclude.Click += new System.EventHandler(this.btn_exclude_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(164, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Salvar Professor";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(3, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(155, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Novo Professor";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(12, 9);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 2;
            this.lb_id.Text = "ID";
            // 
            // lb_nameProf
            // 
            this.lb_nameProf.AutoSize = true;
            this.lb_nameProf.Location = new System.Drawing.Point(123, 9);
            this.lb_nameProf.Name = "lb_nameProf";
            this.lb_nameProf.Size = new System.Drawing.Size(51, 13);
            this.lb_nameProf.TabIndex = 3;
            this.lb_nameProf.Text = "Professor";
            // 
            // lb_Tel
            // 
            this.lb_Tel.AutoSize = true;
            this.lb_Tel.Location = new System.Drawing.Point(365, 9);
            this.lb_Tel.Name = "lb_Tel";
            this.lb_Tel.Size = new System.Drawing.Size(49, 13);
            this.lb_Tel.TabIndex = 4;
            this.lb_Tel.Text = "Telefone";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(15, 36);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(81, 20);
            this.tb_id.TabIndex = 5;
            this.tb_id.TabStop = false;
            // 
            // tb_professor
            // 
            this.tb_professor.Location = new System.Drawing.Point(126, 36);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(224, 20);
            this.tb_professor.TabIndex = 6;
            // 
            // mtb_professores
            // 
            this.mtb_professores.Location = new System.Drawing.Point(368, 35);
            this.mtb_professores.Mask = "(99)99999-9999";
            this.mtb_professores.Name = "mtb_professores";
            this.mtb_professores.Size = new System.Drawing.Size(85, 20);
            this.mtb_professores.TabIndex = 7;
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(12, 62);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(461, 284);
            this.dgv_professores.TabIndex = 8;
            this.dgv_professores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horario_CellContentClick);
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // F_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 396);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.mtb_professores);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_Tel);
            this.Controls.Add(this.lb_nameProf);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.F_Professores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_exclude;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_nameProf;
        private System.Windows.Forms.Label lb_Tel;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.MaskedTextBox mtb_professores;
        private System.Windows.Forms.DataGridView dgv_professores;
    }
}