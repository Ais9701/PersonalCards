namespace Personal_cardsApp1
{
    partial class FormEducation
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
            System.Windows.Forms.Label level_of_educationLabel;
            System.Windows.Forms.Label name_of_educational_institutionLabel;
            System.Windows.Forms.Label name_of_the_document_on_educationLabel;
            System.Windows.Forms.Label seriesLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label year_of_graduationLabel;
            System.Windows.Forms.Label iD_educationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEducation));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.EducationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.educationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.educationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.level_of_educationTextBox = new System.Windows.Forms.TextBox();
            this.name_of_educational_institutionTextBox = new System.Windows.Forms.TextBox();
            this.name_of_the_document_on_educationTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.year_of_graduationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack10 = new System.Windows.Forms.Button();
            this.buttonSeal10 = new System.Windows.Forms.Button();
            this.buttonAdd10 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.iD_educationTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            level_of_educationLabel = new System.Windows.Forms.Label();
            name_of_educational_institutionLabel = new System.Windows.Forms.Label();
            name_of_the_document_on_educationLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            year_of_graduationLabel = new System.Windows.Forms.Label();
            iD_educationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingNavigator)).BeginInit();
            this.educationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // level_of_educationLabel
            // 
            level_of_educationLabel.AutoSize = true;
            level_of_educationLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            level_of_educationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            level_of_educationLabel.Location = new System.Drawing.Point(32, 215);
            level_of_educationLabel.Name = "level_of_educationLabel";
            level_of_educationLabel.Size = new System.Drawing.Size(354, 50);
            level_of_educationLabel.TabIndex = 1;
            level_of_educationLabel.Text = "Уровень образования:";
            level_of_educationLabel.Click += new System.EventHandler(this.level_of_educationLabel_Click);
            // 
            // name_of_educational_institutionLabel
            // 
            name_of_educational_institutionLabel.AutoSize = true;
            name_of_educational_institutionLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_educational_institutionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_of_educational_institutionLabel.Location = new System.Drawing.Point(32, 273);
            name_of_educational_institutionLabel.Name = "name_of_educational_institutionLabel";
            name_of_educational_institutionLabel.Size = new System.Drawing.Size(728, 50);
            name_of_educational_institutionLabel.TabIndex = 3;
            name_of_educational_institutionLabel.Text = "Наименование образовательного учреждения:";
            name_of_educational_institutionLabel.Click += new System.EventHandler(this.name_of_educational_institutionLabel_Click);
            // 
            // name_of_the_document_on_educationLabel
            // 
            name_of_the_document_on_educationLabel.AutoSize = true;
            name_of_the_document_on_educationLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_the_document_on_educationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_of_the_document_on_educationLabel.Location = new System.Drawing.Point(32, 334);
            name_of_the_document_on_educationLabel.Name = "name_of_the_document_on_educationLabel";
            name_of_the_document_on_educationLabel.Size = new System.Drawing.Size(669, 50);
            name_of_the_document_on_educationLabel.TabIndex = 5;
            name_of_the_document_on_educationLabel.Text = "Наименование документа об образовании:";
            name_of_the_document_on_educationLabel.Click += new System.EventHandler(this.name_of_the_document_on_educationLabel_Click);
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seriesLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            seriesLabel.Location = new System.Drawing.Point(32, 386);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(123, 50);
            seriesLabel.TabIndex = 7;
            seriesLabel.Text = "Серия:";
            seriesLabel.Click += new System.EventHandler(this.seriesLabel_Click);
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            numberLabel.Location = new System.Drawing.Point(32, 440);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(130, 50);
            numberLabel.TabIndex = 9;
            numberLabel.Text = "Номер:";
            numberLabel.Click += new System.EventHandler(this.numberLabel_Click);
            // 
            // year_of_graduationLabel
            // 
            year_of_graduationLabel.AutoSize = true;
            year_of_graduationLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_of_graduationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            year_of_graduationLabel.Location = new System.Drawing.Point(32, 498);
            year_of_graduationLabel.Name = "year_of_graduationLabel";
            year_of_graduationLabel.Size = new System.Drawing.Size(258, 50);
            year_of_graduationLabel.TabIndex = 11;
            year_of_graduationLabel.Text = "Год окончания:";
            year_of_graduationLabel.Click += new System.EventHandler(this.year_of_graduationLabel_Click);
            // 
            // iD_educationLabel
            // 
            iD_educationLabel.AutoSize = true;
            iD_educationLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_educationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_educationLabel.Location = new System.Drawing.Point(35, 147);
            iD_educationLabel.Name = "iD_educationLabel";
            iD_educationLabel.Size = new System.Drawing.Size(264, 50);
            iD_educationLabel.TabIndex = 23;
            iD_educationLabel.Text = "ID образования:";
            iD_educationLabel.Click += new System.EventHandler(this.iD_educationLabel_Click);
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "Education";
            this.educationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = this.educationTableAdapter;
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
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // educationBindingNavigator
            // 
            this.educationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.educationBindingNavigator.BindingSource = this.educationBindingSource;
            this.educationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.educationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.educationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.educationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.educationBindingNavigatorSaveItem});
            this.educationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.educationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.educationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.educationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.educationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.educationBindingNavigator.Name = "educationBindingNavigator";
            this.educationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.educationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.educationBindingNavigator.TabIndex = 0;
            this.educationBindingNavigator.Text = "bindingNavigator1";
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
            // educationBindingNavigatorSaveItem
            // 
            this.educationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.educationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("educationBindingNavigatorSaveItem.Image")));
            this.educationBindingNavigatorSaveItem.Name = "educationBindingNavigatorSaveItem";
            this.educationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.educationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.educationBindingNavigatorSaveItem.Visible = false;
            this.educationBindingNavigatorSaveItem.Click += new System.EventHandler(this.educationBindingNavigatorSaveItem_Click);
            // 
            // level_of_educationTextBox
            // 
            this.level_of_educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Level_of_education", true));
            this.level_of_educationTextBox.Location = new System.Drawing.Point(407, 236);
            this.level_of_educationTextBox.Name = "level_of_educationTextBox";
            this.level_of_educationTextBox.Size = new System.Drawing.Size(378, 26);
            this.level_of_educationTextBox.TabIndex = 2;
            // 
            // name_of_educational_institutionTextBox
            // 
            this.name_of_educational_institutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Name_of_educational_institution", true));
            this.name_of_educational_institutionTextBox.Location = new System.Drawing.Point(784, 294);
            this.name_of_educational_institutionTextBox.Name = "name_of_educational_institutionTextBox";
            this.name_of_educational_institutionTextBox.Size = new System.Drawing.Size(494, 26);
            this.name_of_educational_institutionTextBox.TabIndex = 4;
            // 
            // name_of_the_document_on_educationTextBox
            // 
            this.name_of_the_document_on_educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Name_of_the_document_on_education", true));
            this.name_of_the_document_on_educationTextBox.Location = new System.Drawing.Point(729, 355);
            this.name_of_the_document_on_educationTextBox.Name = "name_of_the_document_on_educationTextBox";
            this.name_of_the_document_on_educationTextBox.Size = new System.Drawing.Size(217, 26);
            this.name_of_the_document_on_educationTextBox.TabIndex = 6;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Series", true));
            this.seriesTextBox.Location = new System.Drawing.Point(168, 407);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(181, 26);
            this.seriesTextBox.TabIndex = 8;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(168, 461);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(181, 26);
            this.numberTextBox.TabIndex = 10;
            // 
            // year_of_graduationDateTimePicker
            // 
            this.year_of_graduationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.educationBindingSource, "Year_of_graduation", true));
            this.year_of_graduationDateTimePicker.Location = new System.Drawing.Point(310, 517);
            this.year_of_graduationDateTimePicker.Name = "year_of_graduationDateTimePicker";
            this.year_of_graduationDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.year_of_graduationDateTimePicker.TabIndex = 12;
            // 
            // buttonBack10
            // 
            this.buttonBack10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack10.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack10.Location = new System.Drawing.Point(1080, 594);
            this.buttonBack10.Name = "buttonBack10";
            this.buttonBack10.Size = new System.Drawing.Size(131, 49);
            this.buttonBack10.TabIndex = 20;
            this.buttonBack10.Text = "Назад";
            this.buttonBack10.UseVisualStyleBackColor = false;
            this.buttonBack10.Click += new System.EventHandler(this.buttonBack10_Click);
            // 
            // buttonSeal10
            // 
            this.buttonSeal10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal10.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal10.Location = new System.Drawing.Point(1080, 539);
            this.buttonSeal10.Name = "buttonSeal10";
            this.buttonSeal10.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal10.TabIndex = 19;
            this.buttonSeal10.Text = "Печать";
            this.buttonSeal10.UseVisualStyleBackColor = false;
            this.buttonSeal10.Click += new System.EventHandler(this.buttonSeal10_Click);
            // 
            // buttonAdd10
            // 
            this.buttonAdd10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd10.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd10.Location = new System.Drawing.Point(1080, 419);
            this.buttonAdd10.Name = "buttonAdd10";
            this.buttonAdd10.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd10.TabIndex = 18;
            this.buttonAdd10.Text = "Добавить";
            this.buttonAdd10.UseVisualStyleBackColor = false;
            this.buttonAdd10.Click += new System.EventHandler(this.buttonAdd10_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(1080, 478);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 49);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // iD_educationTextBox
            // 
            this.iD_educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.educationBindingSource, "ID_education", true));
            this.iD_educationTextBox.Location = new System.Drawing.Point(310, 168);
            this.iD_educationTextBox.Name = "iD_educationTextBox";
            this.iD_educationTextBox.Size = new System.Drawing.Size(76, 26);
            this.iD_educationTextBox.TabIndex = 24;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(iD_educationLabel);
            this.Controls.Add(this.iD_educationTextBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack10);
            this.Controls.Add(this.buttonSeal10);
            this.Controls.Add(this.buttonAdd10);
            this.Controls.Add(year_of_graduationLabel);
            this.Controls.Add(this.year_of_graduationDateTimePicker);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(seriesLabel);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(name_of_the_document_on_educationLabel);
            this.Controls.Add(this.name_of_the_document_on_educationTextBox);
            this.Controls.Add(name_of_educational_institutionLabel);
            this.Controls.Add(this.name_of_educational_institutionTextBox);
            this.Controls.Add(level_of_educationLabel);
            this.Controls.Add(this.level_of_educationTextBox);
            this.Controls.Add(this.educationBindingNavigator);
            this.Name = "FormEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Образование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEducation_FormClosed);
            this.Load += new System.EventHandler(this.FormEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingNavigator)).EndInit();
            this.educationBindingNavigator.ResumeLayout(false);
            this.educationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private Personal_cardsDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator educationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton educationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox level_of_educationTextBox;
        private System.Windows.Forms.TextBox name_of_educational_institutionTextBox;
        private System.Windows.Forms.TextBox name_of_the_document_on_educationTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.DateTimePicker year_of_graduationDateTimePicker;
        private System.Windows.Forms.Button buttonBack10;
        private System.Windows.Forms.Button buttonSeal10;
        private System.Windows.Forms.Button buttonAdd10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox iD_educationTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}