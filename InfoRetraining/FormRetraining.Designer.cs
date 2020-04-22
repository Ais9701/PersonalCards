namespace Personal_cardsApp1
{
    partial class FormRetraining
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
            System.Windows.Forms.Label the_beginning_of_the_trainingLabel;
            System.Windows.Forms.Label completion_of_retrainingLabel;
            System.Windows.Forms.Label specialtyLabel;
            System.Windows.Forms.Label document_nameLabel;
            System.Windows.Forms.Label document_numberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iD_retrainingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetraining));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.retrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retrainingTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.RetrainingTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.retrainingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.retrainingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.the_beginning_of_the_trainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completion_of_retrainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.document_nameTextBox = new System.Windows.Forms.TextBox();
            this.document_numberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack11 = new System.Windows.Forms.Button();
            this.buttonSeal11 = new System.Windows.Forms.Button();
            this.buttonAdd11 = new System.Windows.Forms.Button();
            this.ID_retrainingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            the_beginning_of_the_trainingLabel = new System.Windows.Forms.Label();
            completion_of_retrainingLabel = new System.Windows.Forms.Label();
            specialtyLabel = new System.Windows.Forms.Label();
            document_nameLabel = new System.Windows.Forms.Label();
            document_numberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iD_retrainingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingNavigator)).BeginInit();
            this.retrainingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // the_beginning_of_the_trainingLabel
            // 
            the_beginning_of_the_trainingLabel.AutoSize = true;
            the_beginning_of_the_trainingLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            the_beginning_of_the_trainingLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            the_beginning_of_the_trainingLabel.Location = new System.Drawing.Point(185, 208);
            the_beginning_of_the_trainingLabel.Name = "the_beginning_of_the_trainingLabel";
            the_beginning_of_the_trainingLabel.Size = new System.Drawing.Size(442, 57);
            the_beginning_of_the_trainingLabel.TabIndex = 1;
            the_beginning_of_the_trainingLabel.Text = "Начало переподготовки:";
            // 
            // completion_of_retrainingLabel
            // 
            completion_of_retrainingLabel.AutoSize = true;
            completion_of_retrainingLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            completion_of_retrainingLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            completion_of_retrainingLabel.Location = new System.Drawing.Point(185, 259);
            completion_of_retrainingLabel.Name = "completion_of_retrainingLabel";
            completion_of_retrainingLabel.Size = new System.Drawing.Size(505, 57);
            completion_of_retrainingLabel.TabIndex = 3;
            completion_of_retrainingLabel.Text = "Окончание переподготовки:";
            // 
            // specialtyLabel
            // 
            specialtyLabel.AutoSize = true;
            specialtyLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specialtyLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            specialtyLabel.Location = new System.Drawing.Point(185, 312);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new System.Drawing.Size(290, 57);
            specialtyLabel.TabIndex = 5;
            specialtyLabel.Text = "Специальность:";
            // 
            // document_nameLabel
            // 
            document_nameLabel.AutoSize = true;
            document_nameLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            document_nameLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_nameLabel.Location = new System.Drawing.Point(185, 374);
            document_nameLabel.Name = "document_nameLabel";
            document_nameLabel.Size = new System.Drawing.Size(475, 57);
            document_nameLabel.TabIndex = 7;
            document_nameLabel.Text = "Наименование документа:";
            // 
            // document_numberLabel
            // 
            document_numberLabel.AutoSize = true;
            document_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            document_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_numberLabel.Location = new System.Drawing.Point(185, 433);
            document_numberLabel.Name = "document_numberLabel";
            document_numberLabel.Size = new System.Drawing.Size(333, 57);
            document_numberLabel.TabIndex = 9;
            document_numberLabel.Text = "Номер документа:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            dateLabel.Location = new System.Drawing.Point(185, 492);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(116, 57);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Дата:";
            // 
            // iD_retrainingLabel
            // 
            iD_retrainingLabel.AutoSize = true;
            iD_retrainingLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_retrainingLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_retrainingLabel.Location = new System.Drawing.Point(185, 151);
            iD_retrainingLabel.Name = "iD_retrainingLabel";
            iD_retrainingLabel.Size = new System.Drawing.Size(354, 57);
            iD_retrainingLabel.TabIndex = 23;
            iD_retrainingLabel.Text = "ID переподготовки:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retrainingBindingSource
            // 
            this.retrainingBindingSource.DataMember = "Retraining";
            this.retrainingBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // retrainingTableAdapter
            // 
            this.retrainingTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RetrainingTableAdapter = this.retrainingTableAdapter;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // retrainingBindingNavigator
            // 
            this.retrainingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.retrainingBindingNavigator.BindingSource = this.retrainingBindingSource;
            this.retrainingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.retrainingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.retrainingBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.retrainingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.retrainingBindingNavigatorSaveItem});
            this.retrainingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.retrainingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.retrainingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.retrainingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.retrainingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.retrainingBindingNavigator.Name = "retrainingBindingNavigator";
            this.retrainingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.retrainingBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.retrainingBindingNavigator.TabIndex = 0;
            this.retrainingBindingNavigator.Text = "bindingNavigator1";
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
            // retrainingBindingNavigatorSaveItem
            // 
            this.retrainingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.retrainingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("retrainingBindingNavigatorSaveItem.Image")));
            this.retrainingBindingNavigatorSaveItem.Name = "retrainingBindingNavigatorSaveItem";
            this.retrainingBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.retrainingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.retrainingBindingNavigatorSaveItem.Visible = false;
            this.retrainingBindingNavigatorSaveItem.Click += new System.EventHandler(this.retrainingBindingNavigatorSaveItem_Click);
            // 
            // the_beginning_of_the_trainingDateTimePicker
            // 
            this.the_beginning_of_the_trainingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.retrainingBindingSource, "The_beginning_of_the_training", true));
            this.the_beginning_of_the_trainingDateTimePicker.Location = new System.Drawing.Point(654, 230);
            this.the_beginning_of_the_trainingDateTimePicker.Name = "the_beginning_of_the_trainingDateTimePicker";
            this.the_beginning_of_the_trainingDateTimePicker.Size = new System.Drawing.Size(178, 26);
            this.the_beginning_of_the_trainingDateTimePicker.TabIndex = 2;
            // 
            // completion_of_retrainingDateTimePicker
            // 
            this.completion_of_retrainingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.retrainingBindingSource, "Completion_of_retraining", true));
            this.completion_of_retrainingDateTimePicker.Location = new System.Drawing.Point(719, 283);
            this.completion_of_retrainingDateTimePicker.Name = "completion_of_retrainingDateTimePicker";
            this.completion_of_retrainingDateTimePicker.Size = new System.Drawing.Size(177, 26);
            this.completion_of_retrainingDateTimePicker.TabIndex = 4;
            // 
            // specialtyTextBox
            // 
            this.specialtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retrainingBindingSource, "Specialty", true));
            this.specialtyTextBox.Location = new System.Drawing.Point(501, 338);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(200, 26);
            this.specialtyTextBox.TabIndex = 6;
            // 
            // document_nameTextBox
            // 
            this.document_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retrainingBindingSource, "Document_name", true));
            this.document_nameTextBox.Location = new System.Drawing.Point(696, 393);
            this.document_nameTextBox.Name = "document_nameTextBox";
            this.document_nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.document_nameTextBox.TabIndex = 8;
            // 
            // document_numberTextBox
            // 
            this.document_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retrainingBindingSource, "Document_number", true));
            this.document_numberTextBox.Location = new System.Drawing.Point(524, 459);
            this.document_numberTextBox.Name = "document_numberTextBox";
            this.document_numberTextBox.Size = new System.Drawing.Size(200, 26);
            this.document_numberTextBox.TabIndex = 10;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.retrainingBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(307, 516);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(183, 26);
            this.dateDateTimePicker.TabIndex = 12;
            // 
            // buttonBack11
            // 
            this.buttonBack11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack11.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack11.Location = new System.Drawing.Point(1090, 493);
            this.buttonBack11.Name = "buttonBack11";
            this.buttonBack11.Size = new System.Drawing.Size(131, 49);
            this.buttonBack11.TabIndex = 23;
            this.buttonBack11.Text = "Назад";
            this.buttonBack11.UseVisualStyleBackColor = false;
            this.buttonBack11.Click += new System.EventHandler(this.buttonBack11_Click);
            // 
            // buttonSeal11
            // 
            this.buttonSeal11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal11.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal11.Location = new System.Drawing.Point(1090, 436);
            this.buttonSeal11.Name = "buttonSeal11";
            this.buttonSeal11.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal11.TabIndex = 22;
            this.buttonSeal11.Text = "Печать";
            this.buttonSeal11.UseVisualStyleBackColor = false;
            this.buttonSeal11.Click += new System.EventHandler(this.buttonSeal11_Click);
            // 
            // buttonAdd11
            // 
            this.buttonAdd11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd11.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd11.Location = new System.Drawing.Point(1090, 326);
            this.buttonAdd11.Name = "buttonAdd11";
            this.buttonAdd11.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd11.TabIndex = 21;
            this.buttonAdd11.Text = "Добавить";
            this.buttonAdd11.UseVisualStyleBackColor = false;
            this.buttonAdd11.Click += new System.EventHandler(this.buttonAdd11_Click);
            // 
            // ID_retrainingTextBox
            // 
            this.ID_retrainingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retrainingBindingSource, "ID_retraining", true));
            this.ID_retrainingTextBox.Location = new System.Drawing.Point(559, 177);
            this.ID_retrainingTextBox.Name = "ID_retrainingTextBox";
            this.ID_retrainingTextBox.Size = new System.Drawing.Size(83, 26);
            this.ID_retrainingTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1090, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormRetraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_retrainingLabel);
            this.Controls.Add(this.ID_retrainingTextBox);
            this.Controls.Add(this.buttonBack11);
            this.Controls.Add(this.buttonSeal11);
            this.Controls.Add(this.buttonAdd11);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(document_numberLabel);
            this.Controls.Add(this.document_numberTextBox);
            this.Controls.Add(document_nameLabel);
            this.Controls.Add(this.document_nameTextBox);
            this.Controls.Add(specialtyLabel);
            this.Controls.Add(this.specialtyTextBox);
            this.Controls.Add(completion_of_retrainingLabel);
            this.Controls.Add(this.completion_of_retrainingDateTimePicker);
            this.Controls.Add(the_beginning_of_the_trainingLabel);
            this.Controls.Add(this.the_beginning_of_the_trainingDateTimePicker);
            this.Controls.Add(this.retrainingBindingNavigator);
            this.Name = "FormRetraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профессиональная переподготовка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRetraining_FormClosed);
            this.Load += new System.EventHandler(this.FormRetraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingNavigator)).EndInit();
            this.retrainingBindingNavigator.ResumeLayout(false);
            this.retrainingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource retrainingBindingSource;
        private Personal_cardsDataSetTableAdapters.RetrainingTableAdapter retrainingTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator retrainingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton retrainingBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker the_beginning_of_the_trainingDateTimePicker;
        private System.Windows.Forms.DateTimePicker completion_of_retrainingDateTimePicker;
        private System.Windows.Forms.TextBox specialtyTextBox;
        private System.Windows.Forms.TextBox document_nameTextBox;
        private System.Windows.Forms.TextBox document_numberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button buttonBack11;
        private System.Windows.Forms.Button buttonSeal11;
        private System.Windows.Forms.Button buttonAdd11;
        private System.Windows.Forms.TextBox ID_retrainingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}