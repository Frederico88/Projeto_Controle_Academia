namespace SQLite_Project
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluiHorario = new System.Windows.Forms.Button();
            this.btn_saveHorario = new System.Windows.Forms.Button();
            this.btn_newHorario = new System.Windows.Forms.Button();
            this.dgv_horario = new System.Windows.Forms.DataGridView();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_horario = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.mtb_Horario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_excluiHorario);
            this.panel1.Controls.Add(this.btn_saveHorario);
            this.panel1.Controls.Add(this.btn_newHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_excluiHorario
            // 
            this.btn_excluiHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluiHorario.Location = new System.Drawing.Point(241, 14);
            this.btn_excluiHorario.Name = "btn_excluiHorario";
            this.btn_excluiHorario.Size = new System.Drawing.Size(108, 23);
            this.btn_excluiHorario.TabIndex = 2;
            this.btn_excluiHorario.Text = "Excluir Horário";
            this.btn_excluiHorario.UseVisualStyleBackColor = true;
            this.btn_excluiHorario.Click += new System.EventHandler(this.btn_excluiHorario_Click);
            // 
            // btn_saveHorario
            // 
            this.btn_saveHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveHorario.Location = new System.Drawing.Point(127, 14);
            this.btn_saveHorario.Name = "btn_saveHorario";
            this.btn_saveHorario.Size = new System.Drawing.Size(108, 23);
            this.btn_saveHorario.TabIndex = 1;
            this.btn_saveHorario.Text = "Salvar Horário";
            this.btn_saveHorario.UseVisualStyleBackColor = true;
            this.btn_saveHorario.Click += new System.EventHandler(this.btn_saveHorario_Click);
            // 
            // btn_newHorario
            // 
            this.btn_newHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newHorario.Location = new System.Drawing.Point(13, 14);
            this.btn_newHorario.Name = "btn_newHorario";
            this.btn_newHorario.Size = new System.Drawing.Size(108, 23);
            this.btn_newHorario.TabIndex = 0;
            this.btn_newHorario.Text = "Novo Horário";
            this.btn_newHorario.UseVisualStyleBackColor = true;
            this.btn_newHorario.Click += new System.EventHandler(this.btn_newHorario_Click);
            // 
            // dgv_horario
            // 
            this.dgv_horario.AllowUserToAddRows = false;
            this.dgv_horario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horario.EnableHeadersVisualStyles = false;
            this.dgv_horario.Location = new System.Drawing.Point(12, 57);
            this.dgv_horario.MultiSelect = false;
            this.dgv_horario.Name = "dgv_horario";
            this.dgv_horario.ReadOnly = true;
            this.dgv_horario.RowHeadersVisible = false;
            this.dgv_horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horario.Size = new System.Drawing.Size(335, 283);
            this.dgv_horario.TabIndex = 1;
            this.dgv_horario.SelectionChanged += new System.EventHandler(this.dgv_horario_SelectionChanged);
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
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.Location = new System.Drawing.Point(124, 9);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(41, 13);
            this.lb_horario.TabIndex = 3;
            this.lb_horario.Text = "Horário";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(15, 31);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(77, 20);
            this.tb_id.TabIndex = 4;
            this.tb_id.TabStop = false;
            // 
            // mtb_Horario
            // 
            this.mtb_Horario.Location = new System.Drawing.Point(127, 31);
            this.mtb_Horario.Mask = "99:99\\ - 99:99";
            this.mtb_Horario.Name = "mtb_Horario";
            this.mtb_Horario.Size = new System.Drawing.Size(76, 20);
            this.mtb_Horario.TabIndex = 5;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 394);
            this.Controls.Add(this.mtb_Horario);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_horario);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.dgv_horario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_excluiHorario;
        private System.Windows.Forms.Button btn_saveHorario;
        private System.Windows.Forms.Button btn_newHorario;
        private System.Windows.Forms.DataGridView dgv_horario;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.MaskedTextBox mtb_Horario;
    }
}