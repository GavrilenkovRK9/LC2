namespace LC2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadSecondStageMacro = new System.Windows.Forms.Button();
            this.btnLoadFirstStageMacro = new System.Windows.Forms.Button();
            this.chkAutoGenerateFirstStageMacro = new System.Windows.Forms.CheckBox();
            this.tblCriterions = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFirstStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDisplayFirstStageMacro = new System.Windows.Forms.CheckBox();
            this.tblParsedParameters = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParsedParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblParsedParameters);
            this.tabPage1.Controls.Add(this.chkDisplayFirstStageMacro);
            this.tabPage1.Controls.Add(this.tblCriterions);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание критериев и загрузка APDL кода";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoGenerateFirstStageMacro);
            this.groupBox1.Controls.Add(this.btnLoadFirstStageMacro);
            this.groupBox1.Controls.Add(this.btnLoadSecondStageMacro);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка файлов макросов";
            // 
            // btnLoadSecondStageMacro
            // 
            this.btnLoadSecondStageMacro.Location = new System.Drawing.Point(6, 28);
            this.btnLoadSecondStageMacro.Name = "btnLoadSecondStageMacro";
            this.btnLoadSecondStageMacro.Size = new System.Drawing.Size(123, 39);
            this.btnLoadSecondStageMacro.TabIndex = 0;
            this.btnLoadSecondStageMacro.Text = "Расчет 2 этапа";
            this.btnLoadSecondStageMacro.UseVisualStyleBackColor = true;
            // 
            // btnLoadFirstStageMacro
            // 
            this.btnLoadFirstStageMacro.Location = new System.Drawing.Point(6, 99);
            this.btnLoadFirstStageMacro.Name = "btnLoadFirstStageMacro";
            this.btnLoadFirstStageMacro.Size = new System.Drawing.Size(123, 39);
            this.btnLoadFirstStageMacro.TabIndex = 1;
            this.btnLoadFirstStageMacro.Text = "Расчет 1 этапа";
            this.btnLoadFirstStageMacro.UseVisualStyleBackColor = true;
            // 
            // chkAutoGenerateFirstStageMacro
            // 
            this.chkAutoGenerateFirstStageMacro.AutoSize = true;
            this.chkAutoGenerateFirstStageMacro.Location = new System.Drawing.Point(6, 76);
            this.chkAutoGenerateFirstStageMacro.Name = "chkAutoGenerateFirstStageMacro";
            this.chkAutoGenerateFirstStageMacro.Size = new System.Drawing.Size(255, 17);
            this.chkAutoGenerateFirstStageMacro.TabIndex = 2;
            this.chkAutoGenerateFirstStageMacro.Text = "Автоматически генерировать расчет 1 этапа";
            this.chkAutoGenerateFirstStageMacro.UseVisualStyleBackColor = true;
            // 
            // tblCriterions
            // 
            this.tblCriterions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCriterions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.IsMax,
            this.IsFirstStage});
            this.tblCriterions.Location = new System.Drawing.Point(8, 194);
            this.tblCriterions.Name = "tblCriterions";
            this.tblCriterions.Size = new System.Drawing.Size(250, 196);
            this.tblCriterions.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.Width = 70;
            // 
            // IsMax
            // 
            this.IsMax.HeaderText = "Max?";
            this.IsMax.Name = "IsMax";
            this.IsMax.Width = 70;
            // 
            // IsFirstStage
            // 
            this.IsFirstStage.HeaderText = "Расчет 1 этапа";
            this.IsFirstStage.Name = "IsFirstStage";
            this.IsFirstStage.Width = 70;
            // 
            // chkDisplayFirstStageMacro
            // 
            this.chkDisplayFirstStageMacro.AutoSize = true;
            this.chkDisplayFirstStageMacro.Location = new System.Drawing.Point(290, 13);
            this.chkDisplayFirstStageMacro.Name = "chkDisplayFirstStageMacro";
            this.chkDisplayFirstStageMacro.Size = new System.Drawing.Size(201, 17);
            this.chkDisplayFirstStageMacro.TabIndex = 3;
            this.chkDisplayFirstStageMacro.Text = "Отображать расчет первого этапа";
            this.chkDisplayFirstStageMacro.UseVisualStyleBackColor = true;
            // 
            // tblParsedParameters
            // 
            this.tblParsedParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblParsedParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tblParsedParameters.Location = new System.Drawing.Point(290, 46);
            this.tblParsedParameters.Name = "tblParsedParameters";
            this.tblParsedParameters.Size = new System.Drawing.Size(443, 356);
            this.tblParsedParameters.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя критерия";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Определяющее критерий выражение";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 436);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParsedParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadSecondStageMacro;
        private System.Windows.Forms.Button btnLoadFirstStageMacro;
        private System.Windows.Forms.CheckBox chkAutoGenerateFirstStageMacro;
        private System.Windows.Forms.DataGridView tblCriterions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsFirstStage;
        private System.Windows.Forms.CheckBox chkDisplayFirstStageMacro;
        private System.Windows.Forms.DataGridView tblParsedParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

