﻿namespace Apresentacao
{
    partial class FrmMenuAcaoAluno
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
            this.components = new System.ComponentModel.Container();
            this.labelAcaoAlunoNome = new System.Windows.Forms.Label();
            this.labelAcaoAlunoMatricula = new System.Windows.Forms.Label();
            this.labelAcaoAlunoTelefone = new System.Windows.Forms.Label();
            this.labelAcaoAlunoCurso = new System.Windows.Forms.Label();
            this.textBoxAcaoAlunoNome = new System.Windows.Forms.TextBox();
            this.textBoxAcaoAlunoMatricula = new System.Windows.Forms.TextBox();
            this.buttonAcaoAlunoConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoAlunoCancelar = new System.Windows.Forms.Button();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet16 = new Apresentacao.GerencTCCsDataSet16();
            this.labelAcaoAlunoCO = new System.Windows.Forms.Label();
            this.maskedTextBoxAcaoAlunoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelAcaoAlunoID = new System.Windows.Forms.Label();
            this.textBoxAcaoAlunoID = new System.Windows.Forms.TextBox();
            this.comboBoxAcaoAlunoCursoNome = new System.Windows.Forms.ComboBox();
            this.tblCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet17 = new Apresentacao.GerencTCCsDataSet17();
            this.tblUnidadeTableAdapter = new Apresentacao.GerencTCCsDataSet16TableAdapters.tblUnidadeTableAdapter();
            this.tblCursoTableAdapter = new Apresentacao.GerencTCCsDataSet17TableAdapters.tblCursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAcaoAlunoNome
            // 
            this.labelAcaoAlunoNome.AutoSize = true;
            this.labelAcaoAlunoNome.Location = new System.Drawing.Point(16, 46);
            this.labelAcaoAlunoNome.Name = "labelAcaoAlunoNome";
            this.labelAcaoAlunoNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoAlunoNome.TabIndex = 0;
            this.labelAcaoAlunoNome.Text = "Nome*: ";
            // 
            // labelAcaoAlunoMatricula
            // 
            this.labelAcaoAlunoMatricula.AutoSize = true;
            this.labelAcaoAlunoMatricula.Location = new System.Drawing.Point(16, 75);
            this.labelAcaoAlunoMatricula.Name = "labelAcaoAlunoMatricula";
            this.labelAcaoAlunoMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelAcaoAlunoMatricula.TabIndex = 1;
            this.labelAcaoAlunoMatricula.Text = "Matrícula*:";
            // 
            // labelAcaoAlunoTelefone
            // 
            this.labelAcaoAlunoTelefone.AutoSize = true;
            this.labelAcaoAlunoTelefone.Location = new System.Drawing.Point(164, 75);
            this.labelAcaoAlunoTelefone.Name = "labelAcaoAlunoTelefone";
            this.labelAcaoAlunoTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelAcaoAlunoTelefone.TabIndex = 2;
            this.labelAcaoAlunoTelefone.Text = "Telefone: ";
            // 
            // labelAcaoAlunoCurso
            // 
            this.labelAcaoAlunoCurso.AutoSize = true;
            this.labelAcaoAlunoCurso.Location = new System.Drawing.Point(16, 104);
            this.labelAcaoAlunoCurso.Name = "labelAcaoAlunoCurso";
            this.labelAcaoAlunoCurso.Size = new System.Drawing.Size(41, 13);
            this.labelAcaoAlunoCurso.TabIndex = 3;
            this.labelAcaoAlunoCurso.Text = "Curso*:";
            // 
            // textBoxAcaoAlunoNome
            // 
            this.textBoxAcaoAlunoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoAlunoNome.Location = new System.Drawing.Point(67, 42);
            this.textBoxAcaoAlunoNome.Name = "textBoxAcaoAlunoNome";
            this.textBoxAcaoAlunoNome.Size = new System.Drawing.Size(363, 20);
            this.textBoxAcaoAlunoNome.TabIndex = 0;
            // 
            // textBoxAcaoAlunoMatricula
            // 
            this.textBoxAcaoAlunoMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoAlunoMatricula.Location = new System.Drawing.Point(79, 71);
            this.textBoxAcaoAlunoMatricula.Name = "textBoxAcaoAlunoMatricula";
            this.textBoxAcaoAlunoMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxAcaoAlunoMatricula.TabIndex = 1;
            // 
            // buttonAcaoAlunoConfirmar
            // 
            this.buttonAcaoAlunoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoAlunoConfirmar.Name = "buttonAcaoAlunoConfirmar";
            this.buttonAcaoAlunoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoAlunoConfirmar.TabIndex = 5;
            this.buttonAcaoAlunoConfirmar.Text = "Confirmar";
            this.buttonAcaoAlunoConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoAlunoConfirmar.Click += new System.EventHandler(this.buttonAcaoAlunoConfirmar_Click);
            // 
            // buttonAcaoAlunoCancelar
            // 
            this.buttonAcaoAlunoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoAlunoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoAlunoCancelar.Name = "buttonAcaoAlunoCancelar";
            this.buttonAcaoAlunoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoAlunoCancelar.TabIndex = 6;
            this.buttonAcaoAlunoCancelar.Text = "Cancelar";
            this.buttonAcaoAlunoCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoAlunoCancelar.Click += new System.EventHandler(this.buttonAcaoAlunoCancelar_Click);
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.gerencTCCsDataSet16;
            // 
            // gerencTCCsDataSet16
            // 
            this.gerencTCCsDataSet16.DataSetName = "GerencTCCsDataSet16";
            this.gerencTCCsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoAlunoCO
            // 
            this.labelAcaoAlunoCO.AutoSize = true;
            this.labelAcaoAlunoCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoAlunoCO.Name = "labelAcaoAlunoCO";
            this.labelAcaoAlunoCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoAlunoCO.TabIndex = 15;
            this.labelAcaoAlunoCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // maskedTextBoxAcaoAlunoTelefone
            // 
            this.maskedTextBoxAcaoAlunoTelefone.Location = new System.Drawing.Point(224, 71);
            this.maskedTextBoxAcaoAlunoTelefone.Mask = "(99)999999999";
            this.maskedTextBoxAcaoAlunoTelefone.Name = "maskedTextBoxAcaoAlunoTelefone";
            this.maskedTextBoxAcaoAlunoTelefone.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxAcaoAlunoTelefone.TabIndex = 2;
            this.maskedTextBoxAcaoAlunoTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelAcaoAlunoID
            // 
            this.labelAcaoAlunoID.AutoSize = true;
            this.labelAcaoAlunoID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoAlunoID.Name = "labelAcaoAlunoID";
            this.labelAcaoAlunoID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoAlunoID.TabIndex = 18;
            this.labelAcaoAlunoID.Text = "Código: ";
            // 
            // textBoxAcaoAlunoID
            // 
            this.textBoxAcaoAlunoID.Enabled = false;
            this.textBoxAcaoAlunoID.Location = new System.Drawing.Point(68, 13);
            this.textBoxAcaoAlunoID.Name = "textBoxAcaoAlunoID";
            this.textBoxAcaoAlunoID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoAlunoID.TabIndex = 19;
            // 
            // comboBoxAcaoAlunoCursoNome
            // 
            this.comboBoxAcaoAlunoCursoNome.DataSource = this.tblCursoBindingSource;
            this.comboBoxAcaoAlunoCursoNome.DisplayMember = "CursoNome";
            this.comboBoxAcaoAlunoCursoNome.FormattingEnabled = true;
            this.comboBoxAcaoAlunoCursoNome.Location = new System.Drawing.Point(63, 100);
            this.comboBoxAcaoAlunoCursoNome.Name = "comboBoxAcaoAlunoCursoNome";
            this.comboBoxAcaoAlunoCursoNome.Size = new System.Drawing.Size(365, 21);
            this.comboBoxAcaoAlunoCursoNome.TabIndex = 4;
            this.comboBoxAcaoAlunoCursoNome.ValueMember = "CursoNome";
            this.comboBoxAcaoAlunoCursoNome.Click += new System.EventHandler(this.comboBoxAcaoAlunoCursoNome_Click);
            // 
            // tblCursoBindingSource
            // 
            this.tblCursoBindingSource.DataMember = "tblCurso";
            this.tblCursoBindingSource.DataSource = this.gerencTCCsDataSet17;
            // 
            // gerencTCCsDataSet17
            // 
            this.gerencTCCsDataSet17.DataSetName = "GerencTCCsDataSet17";
            this.gerencTCCsDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tblCursoTableAdapter
            // 
            this.tblCursoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuAcaoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.comboBoxAcaoAlunoCursoNome);
            this.Controls.Add(this.textBoxAcaoAlunoID);
            this.Controls.Add(this.labelAcaoAlunoID);
            this.Controls.Add(this.maskedTextBoxAcaoAlunoTelefone);
            this.Controls.Add(this.labelAcaoAlunoCO);
            this.Controls.Add(this.buttonAcaoAlunoCancelar);
            this.Controls.Add(this.buttonAcaoAlunoConfirmar);
            this.Controls.Add(this.textBoxAcaoAlunoMatricula);
            this.Controls.Add(this.textBoxAcaoAlunoNome);
            this.Controls.Add(this.labelAcaoAlunoCurso);
            this.Controls.Add(this.labelAcaoAlunoTelefone);
            this.Controls.Add(this.labelAcaoAlunoMatricula);
            this.Controls.Add(this.labelAcaoAlunoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoAlunoNome;
        private System.Windows.Forms.Label labelAcaoAlunoMatricula;
        private System.Windows.Forms.Label labelAcaoAlunoTelefone;
        private System.Windows.Forms.Label labelAcaoAlunoCurso;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoNome;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoMatricula;
        private System.Windows.Forms.Button buttonAcaoAlunoConfirmar;
        private System.Windows.Forms.Button buttonAcaoAlunoCancelar;
        private System.Windows.Forms.Label labelAcaoAlunoCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAcaoAlunoTelefone;
        private System.Windows.Forms.Label labelAcaoAlunoID;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoID;
        private System.Windows.Forms.ComboBox comboBoxAcaoAlunoCursoNome;
        private GerencTCCsDataSet16 gerencTCCsDataSet16;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private GerencTCCsDataSet16TableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
        private GerencTCCsDataSet17 gerencTCCsDataSet17;
        private System.Windows.Forms.BindingSource tblCursoBindingSource;
        private GerencTCCsDataSet17TableAdapters.tblCursoTableAdapter tblCursoTableAdapter;
    }
}