﻿namespace Personal_cardsApp1.InfoPersonalCards
{
    partial class FormGrantingLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrantingLeave));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label iD_granting_leaveLabel;
            System.Windows.Forms.Label name_organizationLabel;
            System.Windows.Forms.Label document_numberLabel;
            System.Windows.Forms.Label date_compilationLabel;
            System.Windows.Forms.Label service_numberLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label structural_divisionLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label period_working_withLabel;
            System.Windows.Forms.Label period_working__forLabel;
            System.Windows.Forms.Label number_vacation_daysLabel;
            System.Windows.Forms.Label provided_withLabel;
            System.Windows.Forms.Label provided__forLabel;
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.granting_leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.granting_leaveTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Granting_leaveTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.granting_leaveBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.granting_leaveBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.granting_leaveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExcelGrantingLeave = new System.Windows.Forms.Button();
            iD_granting_leaveLabel = new System.Windows.Forms.Label();
            name_organizationLabel = new System.Windows.Forms.Label();
            document_numberLabel = new System.Windows.Forms.Label();
            date_compilationLabel = new System.Windows.Forms.Label();
            service_numberLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            structural_divisionLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            period_working_withLabel = new System.Windows.Forms.Label();
            period_working__forLabel = new System.Windows.Forms.Label();
            number_vacation_daysLabel = new System.Windows.Forms.Label();
            provided_withLabel = new System.Windows.Forms.Label();
            provided__forLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveBindingNavigator)).BeginInit();
            this.granting_leaveBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // granting_leaveBindingSource
            // 
            this.granting_leaveBindingSource.DataMember = "Granting_leave";
            this.granting_leaveBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // granting_leaveTableAdapter
            // 
            this.granting_leaveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Granting_leaveTableAdapter = this.granting_leaveTableAdapter;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Order_admissionTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.Staff_listTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // granting_leaveBindingNavigator
            // 
            this.granting_leaveBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.granting_leaveBindingNavigator.BindingSource = this.granting_leaveBindingSource;
            this.granting_leaveBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.granting_leaveBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.granting_leaveBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.granting_leaveBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.granting_leaveBindingNavigatorSaveItem});
            this.granting_leaveBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.granting_leaveBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.granting_leaveBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.granting_leaveBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.granting_leaveBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.granting_leaveBindingNavigator.Name = "granting_leaveBindingNavigator";
            this.granting_leaveBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.granting_leaveBindingNavigator.Size = new System.Drawing.Size(1357, 37);
            this.granting_leaveBindingNavigator.TabIndex = 0;
            this.granting_leaveBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.191489F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // granting_leaveBindingNavigatorSaveItem
            // 
            this.granting_leaveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.granting_leaveBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("granting_leaveBindingNavigatorSaveItem.Image")));
            this.granting_leaveBindingNavigatorSaveItem.Name = "granting_leaveBindingNavigatorSaveItem";
            this.granting_leaveBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.granting_leaveBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.granting_leaveBindingNavigatorSaveItem.Click += new System.EventHandler(this.granting_leaveBindingNavigatorSaveItem_Click);
            // 
            // granting_leaveDataGridView
            // 
            this.granting_leaveDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.granting_leaveDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.granting_leaveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.granting_leaveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.granting_leaveDataGridView.DataSource = this.granting_leaveBindingSource;
            this.granting_leaveDataGridView.Location = new System.Drawing.Point(0, 52);
            this.granting_leaveDataGridView.Name = "granting_leaveDataGridView";
            this.granting_leaveDataGridView.RowHeadersWidth = 60;
            this.granting_leaveDataGridView.RowTemplate.Height = 28;
            this.granting_leaveDataGridView.Size = new System.Drawing.Size(1357, 290);
            this.granting_leaveDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_granting_leave";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_предоставления отпуска";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 147;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_organization";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование организации";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 147;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Document_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер документа";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_compilation";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата составления";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 147;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Service_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Табельный номер";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 147;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn6.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 147;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Structural_division";
            this.dataGridViewTextBoxColumn7.HeaderText = "Структурное подразделение";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 147;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn8.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 147;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Period_working_with";
            this.dataGridViewTextBoxColumn9.HeaderText = "За период работы с";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 147;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Period_working_ for";
            this.dataGridViewTextBoxColumn10.HeaderText = "За период работы по";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 147;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Number_vacation_days";
            this.dataGridViewTextBoxColumn11.HeaderText = "Количество календарных дней";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 147;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Provided_with";
            this.dataGridViewTextBoxColumn12.HeaderText = "Предоставление отпуска с";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 147;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Provided_ for";
            this.dataGridViewTextBoxColumn13.HeaderText = "Предоставление отпуска по";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 147;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iD_granting_leaveLabel);
            this.groupBox1.Controls.Add(name_organizationLabel);
            this.groupBox1.Controls.Add(document_numberLabel);
            this.groupBox1.Controls.Add(date_compilationLabel);
            this.groupBox1.Controls.Add(service_numberLabel);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(structural_divisionLabel);
            this.groupBox1.Controls.Add(positionLabel);
            this.groupBox1.Controls.Add(period_working_withLabel);
            this.groupBox1.Controls.Add(period_working__forLabel);
            this.groupBox1.Controls.Add(number_vacation_daysLabel);
            this.groupBox1.Controls.Add(provided_withLabel);
            this.groupBox1.Controls.Add(provided__forLabel);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 633);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление отпуска";
            // 
            // iD_granting_leaveLabel
            // 
            iD_granting_leaveLabel.AutoSize = true;
            iD_granting_leaveLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_granting_leaveLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_granting_leaveLabel.Location = new System.Drawing.Point(6, 44);
            iD_granting_leaveLabel.Name = "iD_granting_leaveLabel";
            iD_granting_leaveLabel.Size = new System.Drawing.Size(243, 39);
            iD_granting_leaveLabel.TabIndex = 0;
            iD_granting_leaveLabel.Text = "ID предоставления:";
            // 
            // name_organizationLabel
            // 
            name_organizationLabel.AutoSize = true;
            name_organizationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_organizationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_organizationLabel.Location = new System.Drawing.Point(6, 88);
            name_organizationLabel.Name = "name_organizationLabel";
            name_organizationLabel.Size = new System.Drawing.Size(356, 39);
            name_organizationLabel.TabIndex = 2;
            name_organizationLabel.Text = "Наименование организации:";
            // 
            // document_numberLabel
            // 
            document_numberLabel.AutoSize = true;
            document_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            document_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_numberLabel.Location = new System.Drawing.Point(6, 132);
            document_numberLabel.Name = "document_numberLabel";
            document_numberLabel.Size = new System.Drawing.Size(229, 39);
            document_numberLabel.TabIndex = 4;
            document_numberLabel.Text = "Номер документа:";
            // 
            // date_compilationLabel
            // 
            date_compilationLabel.AutoSize = true;
            date_compilationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_compilationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_compilationLabel.Location = new System.Drawing.Point(6, 177);
            date_compilationLabel.Name = "date_compilationLabel";
            date_compilationLabel.Size = new System.Drawing.Size(228, 39);
            date_compilationLabel.TabIndex = 6;
            date_compilationLabel.Text = "Дата составления:";
            // 
            // service_numberLabel
            // 
            service_numberLabel.AutoSize = true;
            service_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            service_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            service_numberLabel.Location = new System.Drawing.Point(6, 221);
            service_numberLabel.Name = "service_numberLabel";
            service_numberLabel.Size = new System.Drawing.Size(230, 39);
            service_numberLabel.TabIndex = 8;
            service_numberLabel.Text = "Табельный номер:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIOLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            fIOLabel.Location = new System.Drawing.Point(6, 265);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(79, 39);
            fIOLabel.TabIndex = 10;
            fIOLabel.Text = "ФИО:";
            // 
            // structural_divisionLabel
            // 
            structural_divisionLabel.AutoSize = true;
            structural_divisionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            structural_divisionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            structural_divisionLabel.Location = new System.Drawing.Point(6, 309);
            structural_divisionLabel.Name = "structural_divisionLabel";
            structural_divisionLabel.Size = new System.Drawing.Size(351, 39);
            structural_divisionLabel.TabIndex = 12;
            structural_divisionLabel.Text = "Структурное подразделение:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            positionLabel.Location = new System.Drawing.Point(6, 353);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(152, 39);
            positionLabel.TabIndex = 14;
            positionLabel.Text = "Должность:";
            // 
            // period_working_withLabel
            // 
            period_working_withLabel.AutoSize = true;
            period_working_withLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            period_working_withLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            period_working_withLabel.Location = new System.Drawing.Point(6, 398);
            period_working_withLabel.Name = "period_working_withLabel";
            period_working_withLabel.Size = new System.Drawing.Size(247, 39);
            period_working_withLabel.TabIndex = 16;
            period_working_withLabel.Text = "За период работы с:";
            // 
            // period_working__forLabel
            // 
            period_working__forLabel.AutoSize = true;
            period_working__forLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            period_working__forLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            period_working__forLabel.Location = new System.Drawing.Point(6, 443);
            period_working__forLabel.Name = "period_working__forLabel";
            period_working__forLabel.Size = new System.Drawing.Size(264, 39);
            period_working__forLabel.TabIndex = 18;
            period_working__forLabel.Text = "За период работы по:";
            // 
            // number_vacation_daysLabel
            // 
            number_vacation_daysLabel.AutoSize = true;
            number_vacation_daysLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_vacation_daysLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            number_vacation_daysLabel.Location = new System.Drawing.Point(6, 487);
            number_vacation_daysLabel.Name = "number_vacation_daysLabel";
            number_vacation_daysLabel.Size = new System.Drawing.Size(376, 39);
            number_vacation_daysLabel.TabIndex = 20;
            number_vacation_daysLabel.Text = "Количество календарных дней";
            // 
            // provided_withLabel
            // 
            provided_withLabel.AutoSize = true;
            provided_withLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            provided_withLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            provided_withLabel.Location = new System.Drawing.Point(6, 532);
            provided_withLabel.Name = "provided_withLabel";
            provided_withLabel.Size = new System.Drawing.Size(230, 39);
            provided_withLabel.TabIndex = 22;
            provided_withLabel.Text = "Предоставление с:";
            // 
            // provided__forLabel
            // 
            provided__forLabel.AutoSize = true;
            provided__forLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            provided__forLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            provided__forLabel.Location = new System.Drawing.Point(6, 577);
            provided__forLabel.Name = "provided__forLabel";
            provided__forLabel.Size = new System.Drawing.Size(247, 39);
            provided__forLabel.TabIndex = 24;
            provided__forLabel.Text = "Предоставление по:";
            // 
            // buttonExcelGrantingLeave
            // 
            this.buttonExcelGrantingLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExcelGrantingLeave.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonExcelGrantingLeave.Location = new System.Drawing.Point(1108, 376);
            this.buttonExcelGrantingLeave.Name = "buttonExcelGrantingLeave";
            this.buttonExcelGrantingLeave.Size = new System.Drawing.Size(218, 55);
            this.buttonExcelGrantingLeave.TabIndex = 102;
            this.buttonExcelGrantingLeave.Text = "Экспорт в Excel";
            this.buttonExcelGrantingLeave.UseVisualStyleBackColor = false;
            this.buttonExcelGrantingLeave.Click += new System.EventHandler(this.buttonExcelGrantingLeave_Click);
            // 
            // FormGrantingLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 1010);
            this.Controls.Add(this.buttonExcelGrantingLeave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.granting_leaveDataGridView);
            this.Controls.Add(this.granting_leaveBindingNavigator);
            this.Name = "FormGrantingLeave";
            this.Text = "Предоставление отпуска";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGrantingLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveBindingNavigator)).EndInit();
            this.granting_leaveBindingNavigator.ResumeLayout(false);
            this.granting_leaveBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.granting_leaveDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource granting_leaveBindingSource;
        private Personal_cardsDataSetTableAdapters.Granting_leaveTableAdapter granting_leaveTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator granting_leaveBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton granting_leaveBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView granting_leaveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExcelGrantingLeave;
    }
}