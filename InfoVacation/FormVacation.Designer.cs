namespace Personal_cardsApp1
{
    partial class FormVacation
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
            System.Windows.Forms.Label type_of_vacationLabel;
            System.Windows.Forms.Label working_period_withLabel;
            System.Windows.Forms.Label period_of_work_onLabel;
            System.Windows.Forms.Label number_of_vacation_daysLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label expiry_dateLabel;
            System.Windows.Forms.Label iD_vacationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVacation));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.VacationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.vacationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vacationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.type_of_vacationTextBox = new System.Windows.Forms.TextBox();
            this.working_period_withDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.period_of_work_onDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.number_of_vacation_daysTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiry_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack6 = new System.Windows.Forms.Button();
            this.buttonSeal6 = new System.Windows.Forms.Button();
            this.buttonAdd6 = new System.Windows.Forms.Button();
            this.ID_vacationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            type_of_vacationLabel = new System.Windows.Forms.Label();
            working_period_withLabel = new System.Windows.Forms.Label();
            period_of_work_onLabel = new System.Windows.Forms.Label();
            number_of_vacation_daysLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            expiry_dateLabel = new System.Windows.Forms.Label();
            iD_vacationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingNavigator)).BeginInit();
            this.vacationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_of_vacationLabel
            // 
            type_of_vacationLabel.AutoSize = true;
            type_of_vacationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_of_vacationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            type_of_vacationLabel.Location = new System.Drawing.Point(184, 233);
            type_of_vacationLabel.Name = "type_of_vacationLabel";
            type_of_vacationLabel.Size = new System.Drawing.Size(242, 57);
            type_of_vacationLabel.TabIndex = 1;
            type_of_vacationLabel.Text = "Тип отпуска:";
            // 
            // working_period_withLabel
            // 
            working_period_withLabel.AutoSize = true;
            working_period_withLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            working_period_withLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            working_period_withLabel.Location = new System.Drawing.Point(184, 294);
            working_period_withLabel.Name = "working_period_withLabel";
            working_period_withLabel.Size = new System.Drawing.Size(316, 57);
            working_period_withLabel.TabIndex = 3;
            working_period_withLabel.Text = "Период работы с:";
            // 
            // period_of_work_onLabel
            // 
            period_of_work_onLabel.AutoSize = true;
            period_of_work_onLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            period_of_work_onLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            period_of_work_onLabel.Location = new System.Drawing.Point(184, 351);
            period_of_work_onLabel.Name = "period_of_work_onLabel";
            period_of_work_onLabel.Size = new System.Drawing.Size(342, 57);
            period_of_work_onLabel.TabIndex = 5;
            period_of_work_onLabel.Text = "Период работы по:";
            // 
            // number_of_vacation_daysLabel
            // 
            number_of_vacation_daysLabel.AutoSize = true;
            number_of_vacation_daysLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_vacation_daysLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            number_of_vacation_daysLabel.Location = new System.Drawing.Point(184, 408);
            number_of_vacation_daysLabel.Name = "number_of_vacation_daysLabel";
            number_of_vacation_daysLabel.Size = new System.Drawing.Size(464, 114);
            number_of_vacation_daysLabel.TabIndex = 7;
            number_of_vacation_daysLabel.Text = "Количество календарных \r\nдней отпуска";
            number_of_vacation_daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            start_dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            start_dateLabel.Location = new System.Drawing.Point(184, 527);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(244, 57);
            start_dateLabel.TabIndex = 9;
            start_dateLabel.Text = "Дата начала:";
            // 
            // expiry_dateLabel
            // 
            expiry_dateLabel.AutoSize = true;
            expiry_dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            expiry_dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            expiry_dateLabel.Location = new System.Drawing.Point(184, 591);
            expiry_dateLabel.Name = "expiry_dateLabel";
            expiry_dateLabel.Size = new System.Drawing.Size(310, 57);
            expiry_dateLabel.TabIndex = 11;
            expiry_dateLabel.Text = "Дата окончания:";
            // 
            // iD_vacationLabel
            // 
            iD_vacationLabel.AutoSize = true;
            iD_vacationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_vacationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_vacationLabel.Location = new System.Drawing.Point(184, 176);
            iD_vacationLabel.Name = "iD_vacationLabel";
            iD_vacationLabel.Size = new System.Drawing.Size(211, 57);
            iD_vacationLabel.TabIndex = 16;
            iD_vacationLabel.Text = "ID отпуска:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = this.vacationTableAdapter;
            // 
            // vacationBindingNavigator
            // 
            this.vacationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacationBindingNavigator.BindingSource = this.vacationBindingSource;
            this.vacationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.vacationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacationBindingNavigatorSaveItem});
            this.vacationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacationBindingNavigator.Name = "vacationBindingNavigator";
            this.vacationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.vacationBindingNavigator.TabIndex = 0;
            this.vacationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // vacationBindingNavigatorSaveItem
            // 
            this.vacationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacationBindingNavigatorSaveItem.Image")));
            this.vacationBindingNavigatorSaveItem.Name = "vacationBindingNavigatorSaveItem";
            this.vacationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.vacationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vacationBindingNavigatorSaveItem.Visible = false;
            this.vacationBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacationBindingNavigatorSaveItem_Click);
            // 
            // type_of_vacationTextBox
            // 
            this.type_of_vacationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "Type_of_vacation", true));
            this.type_of_vacationTextBox.Location = new System.Drawing.Point(460, 259);
            this.type_of_vacationTextBox.Name = "type_of_vacationTextBox";
            this.type_of_vacationTextBox.Size = new System.Drawing.Size(200, 26);
            this.type_of_vacationTextBox.TabIndex = 2;
            // 
            // working_period_withDateTimePicker
            // 
            this.working_period_withDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "Working_period_with", true));
            this.working_period_withDateTimePicker.Location = new System.Drawing.Point(542, 318);
            this.working_period_withDateTimePicker.Name = "working_period_withDateTimePicker";
            this.working_period_withDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.working_period_withDateTimePicker.TabIndex = 4;
            // 
            // period_of_work_onDateTimePicker
            // 
            this.period_of_work_onDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "Period_of_work_on", true));
            this.period_of_work_onDateTimePicker.Location = new System.Drawing.Point(542, 375);
            this.period_of_work_onDateTimePicker.Name = "period_of_work_onDateTimePicker";
            this.period_of_work_onDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.period_of_work_onDateTimePicker.TabIndex = 6;
            // 
            // number_of_vacation_daysTextBox
            // 
            this.number_of_vacation_daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "Number_of_vacation_days", true));
            this.number_of_vacation_daysTextBox.Location = new System.Drawing.Point(641, 472);
            this.number_of_vacation_daysTextBox.Name = "number_of_vacation_daysTextBox";
            this.number_of_vacation_daysTextBox.Size = new System.Drawing.Size(144, 26);
            this.number_of_vacation_daysTextBox.TabIndex = 8;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "Start_date", true));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(444, 551);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(179, 26);
            this.start_dateDateTimePicker.TabIndex = 10;
            // 
            // expiry_dateDateTimePicker
            // 
            this.expiry_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "Expiry_date", true));
            this.expiry_dateDateTimePicker.Location = new System.Drawing.Point(512, 615);
            this.expiry_dateDateTimePicker.Name = "expiry_dateDateTimePicker";
            this.expiry_dateDateTimePicker.Size = new System.Drawing.Size(178, 26);
            this.expiry_dateDateTimePicker.TabIndex = 12;
            // 
            // buttonBack6
            // 
            this.buttonBack6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack6.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack6.Location = new System.Drawing.Point(1005, 633);
            this.buttonBack6.Name = "buttonBack6";
            this.buttonBack6.Size = new System.Drawing.Size(131, 49);
            this.buttonBack6.TabIndex = 15;
            this.buttonBack6.Text = "Назад";
            this.buttonBack6.UseVisualStyleBackColor = false;
            this.buttonBack6.Click += new System.EventHandler(this.buttonBack6_Click);
            // 
            // buttonSeal6
            // 
            this.buttonSeal6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal6.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal6.Location = new System.Drawing.Point(1005, 578);
            this.buttonSeal6.Name = "buttonSeal6";
            this.buttonSeal6.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal6.TabIndex = 14;
            this.buttonSeal6.Text = "Печать";
            this.buttonSeal6.UseVisualStyleBackColor = false;
            this.buttonSeal6.Click += new System.EventHandler(this.buttonSeal6_Click);
            // 
            // buttonAdd6
            // 
            this.buttonAdd6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd6.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd6.Location = new System.Drawing.Point(1005, 468);
            this.buttonAdd6.Name = "buttonAdd6";
            this.buttonAdd6.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd6.TabIndex = 13;
            this.buttonAdd6.Text = "Добавить";
            this.buttonAdd6.UseVisualStyleBackColor = false;
            this.buttonAdd6.Click += new System.EventHandler(this.buttonAdd6_Click);
            // 
            // ID_vacationTextBox
            // 
            this.ID_vacationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "ID_vacation", true));
            this.ID_vacationTextBox.Location = new System.Drawing.Point(419, 202);
            this.ID_vacationTextBox.Name = "ID_vacationTextBox";
            this.ID_vacationTextBox.Size = new System.Drawing.Size(100, 26);
            this.ID_vacationTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1005, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_vacationLabel);
            this.Controls.Add(this.ID_vacationTextBox);
            this.Controls.Add(this.buttonBack6);
            this.Controls.Add(this.buttonSeal6);
            this.Controls.Add(this.buttonAdd6);
            this.Controls.Add(expiry_dateLabel);
            this.Controls.Add(this.expiry_dateDateTimePicker);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(number_of_vacation_daysLabel);
            this.Controls.Add(this.number_of_vacation_daysTextBox);
            this.Controls.Add(period_of_work_onLabel);
            this.Controls.Add(this.period_of_work_onDateTimePicker);
            this.Controls.Add(working_period_withLabel);
            this.Controls.Add(this.working_period_withDateTimePicker);
            this.Controls.Add(type_of_vacationLabel);
            this.Controls.Add(this.type_of_vacationTextBox);
            this.Controls.Add(this.vacationBindingNavigator);
            this.Name = "FormVacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отпуск";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVacation_FormClosed);
            this.Load += new System.EventHandler(this.FormVacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingNavigator)).EndInit();
            this.vacationBindingNavigator.ResumeLayout(false);
            this.vacationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private Personal_cardsDataSetTableAdapters.VacationTableAdapter vacationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox type_of_vacationTextBox;
        private System.Windows.Forms.DateTimePicker working_period_withDateTimePicker;
        private System.Windows.Forms.DateTimePicker period_of_work_onDateTimePicker;
        private System.Windows.Forms.TextBox number_of_vacation_daysTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiry_dateDateTimePicker;
        private System.Windows.Forms.Button buttonBack6;
        private System.Windows.Forms.Button buttonSeal6;
        private System.Windows.Forms.Button buttonAdd6;
        private System.Windows.Forms.TextBox ID_vacationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}