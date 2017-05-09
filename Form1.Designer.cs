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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblParsedParameters = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDisplayFirstStageMacro = new System.Windows.Forms.CheckBox();
            this.tblCriterions = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFirstStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoGenerateFirstStageMacro = new System.Windows.Forms.CheckBox();
            this.btnLoadFirstStageMacro = new System.Windows.Forms.Button();
            this.btnLoadSecondStageMacro = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblParameters = new System.Windows.Forms.DataGridView();
            this.tblFunctionalConstraints = new System.Windows.Forms.DataGridView();
            this.clmnCnstrEq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnRated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьСтатусПеременнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblParsedParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterions)).BeginInit();
            this.DeleteRow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFunctionalConstraints)).BeginInit();
            this.ChangeStatus.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            // tblCriterions
            // 
            this.tblCriterions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCriterions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.IsMax,
            this.IsFirstStage});
            this.tblCriterions.ContextMenuStrip = this.DeleteRow;
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
            // DeleteRow
            // 
            this.DeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
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
            // btnLoadFirstStageMacro
            // 
            this.btnLoadFirstStageMacro.Location = new System.Drawing.Point(6, 99);
            this.btnLoadFirstStageMacro.Name = "btnLoadFirstStageMacro";
            this.btnLoadFirstStageMacro.Size = new System.Drawing.Size(123, 39);
            this.btnLoadFirstStageMacro.TabIndex = 1;
            this.btnLoadFirstStageMacro.Text = "Расчет 1 этапа";
            this.btnLoadFirstStageMacro.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tblFunctionalConstraints);
            this.tabPage2.Controls.Add(this.tblParameters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбор управляющих параметров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblParameters
            // 
            this.tblParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.ClmnRated,
            this.ClmnLower,
            this.ClmnUpper,
            this.ClmnStatus});
            this.tblParameters.ContextMenuStrip = this.ChangeStatus;
            this.tblParameters.Location = new System.Drawing.Point(8, 16);
            this.tblParameters.Name = "tblParameters";
            this.tblParameters.Size = new System.Drawing.Size(396, 388);
            this.tblParameters.TabIndex = 0;
            // 
            // tblFunctionalConstraints
            // 
            this.tblFunctionalConstraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFunctionalConstraints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCnstrEq});
            this.tblFunctionalConstraints.Location = new System.Drawing.Point(431, 16);
            this.tblFunctionalConstraints.Name = "tblFunctionalConstraints";
            this.tblFunctionalConstraints.Size = new System.Drawing.Size(312, 386);
            this.tblFunctionalConstraints.TabIndex = 1;
            // 
            // clmnCnstrEq
            // 
            this.clmnCnstrEq.HeaderText = "Уравнения ограничения";
            this.clmnCnstrEq.Name = "clmnCnstrEq";
            this.clmnCnstrEq.Width = 300;
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Имя";
            this.clmnName.Name = "clmnName";
            // 
            // ClmnRated
            // 
            this.ClmnRated.HeaderText = "Номинал";
            this.ClmnRated.Name = "ClmnRated";
            this.ClmnRated.Width = 60;
            // 
            // ClmnLower
            // 
            this.ClmnLower.HeaderText = "Нижняя граница";
            this.ClmnLower.Name = "ClmnLower";
            this.ClmnLower.Width = 60;
            // 
            // ClmnUpper
            // 
            this.ClmnUpper.HeaderText = "Верхняя граница";
            this.ClmnUpper.Name = "ClmnUpper";
            this.ClmnUpper.Width = 60;
            // 
            // ClmnStatus
            // 
            this.ClmnStatus.HeaderText = "Статус";
            this.ClmnStatus.Name = "ClmnStatus";
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьСтатусПеременнойToolStripMenuItem});
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(238, 26);
            // 
            // изменитьСтатусПеременнойToolStripMenuItem
            // 
            this.изменитьСтатусПеременнойToolStripMenuItem.Name = "изменитьСтатусПеременнойToolStripMenuItem";
            this.изменитьСтатусПеременнойToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.изменитьСтатусПеременнойToolStripMenuItem.Text = "Изменить статус переменной";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(762, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конфигурация МИС";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Настройка эксперимента";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(762, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "График параллельных отрезков";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.trackBar1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(762, 410);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Задание критериальных ограничений";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(150, 164);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblParsedParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterions)).EndInit();
            this.DeleteRow.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFunctionalConstraints)).EndInit();
            this.ChangeStatus.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip DeleteRow;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView tblParameters;
        private System.Windows.Forms.DataGridView tblFunctionalConstraints;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCnstrEq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnRated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUpper;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnStatus;
        private System.Windows.Forms.ContextMenuStrip ChangeStatus;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтатусПеременнойToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

