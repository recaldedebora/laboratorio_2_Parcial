﻿namespace FrmAtencion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(22, 26);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(231, 229);
            lstMedicos.TabIndex = 0;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(259, 26);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(256, 229);
            lstPacientes.TabIndex = 1;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(22, 276);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(493, 162);
            rtbInfoMedico.TabIndex = 2;
            rtbInfoMedico.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(566, 58);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(126, 60);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(566, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 63);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(24, 6);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Personal Médico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(261, 4);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Débora Recalde";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}