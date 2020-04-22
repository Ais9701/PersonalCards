namespace Personal_cardsApp1
{
    partial class FormAdvancedTraining
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
            System.Windows.Forms.Label beginning_of_trainingLabel;
            System.Windows.Forms.Label the_end_of_the_trainingLabel;
            System.Windows.Forms.Label type_of_qualificationLabel;
            System.Windows.Forms.Label name_of_educational_institutionLabel;
            System.Windows.Forms.Label its_locationLabel;
            System.Windows.Forms.Label document_nameLabel;
            System.Windows.Forms.Label series_document_numberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iD_qualificationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvancedTraining));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.advanced_trainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanced_trainingTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Advanced_trainingTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.advanced_trainingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.advanced_trainingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.beginning_of_trainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.the_end_of_the_trainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.type_of_qualificationTextBox = new System.Windows.Forms.TextBox();
            this.name_of_educational_institutionTextBox = new System.Windows.Forms.TextBox();
            this.its_locationTextBox = new System.Windows.Forms.TextBox();
            this.document_nameTextBox = new System.Windows.Forms.TextBox();
            this.series_document_numberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack5 = new System.Windows.Forms.Button();
            this.buttonSeal5 = new System.Windows.Forms.Button();
            this.buttonAdd5 = new System.Windows.Forms.Button();
            this.ID_qualificationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            beginning_of_trainingLabel = new System.Windows.Forms.Label();
            the_end_of_the_trainingLabel = new System.Windows.Forms.Label();
            type_of_qualificationLabel = new System.Windows.Forms.Label();
            name_of_educational_institutionLabel = new System.Windows.Forms.Label();
            its_locationLabel = new System.Windows.Forms.Label();
            document_nameLabel = new System.Windows.Forms.Label();
            series_document_numberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iD_qualificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingNavigator)).BeginInit();
            this.advanced_trainingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginning_of_trainingLabel
            // 
            beginning_of_trainingLabel.AutoSize = true;
            beginning_of_trainingLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            beginning_of_trainingLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            beginning_of_trainingLabel.Location = new System.Drawing.Point(116, 174);
            beginning_of_trainingLabel.Name = "beginning_of_trainingLabel";
            beginning_of_trainingLabel.Size = new System.Drawing.Size(329, 57);
            beginning_of_trainingLabel.TabIndex = 1;
            beginning_of_trainingLabel.Text = "Начало обучения:";
            // 
            // the_end_of_the_trainingLabel
            // 
            the_end_of_the_trainingLabel.AutoSize = true;
            the_end_of_the_trainingLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            the_end_of_the_trainingLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            the_end_of_the_trainingLabel.Location = new System.Drawing.Point(116, 230);
            the_end_of_the_trainingLabel.Name = "the_end_of_the_trainingLabel";
            the_end_of_the_trainingLabel.Size = new System.Drawing.Size(308, 57);
            the_end_of_the_trainingLabel.TabIndex = 3;
            the_end_of_the_trainingLabel.Text = "Конец обучения:";
            // 
            // type_of_qualificationLabel
            // 
            type_of_qualificationLabel.AutoSize = true;
            type_of_qualificationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_of_qualificationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            type_of_qualificationLabel.Location = new System.Drawing.Point(116, 282);
            type_of_qualificationLabel.Name = "type_of_qualificationLabel";
            type_of_qualificationLabel.Size = new System.Drawing.Size(576, 57);
            type_of_qualificationLabel.TabIndex = 5;
            type_of_qualificationLabel.Text = "Вид повышения квалификации:";
            // 
            // name_of_educational_institutionLabel
            // 
            name_of_educational_institutionLabel.AutoSize = true;
            name_of_educational_institutionLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_educational_institutionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_of_educational_institutionLabel.Location = new System.Drawing.Point(116, 333);
            name_of_educational_institutionLabel.Name = "name_of_educational_institutionLabel";
            name_of_educational_institutionLabel.Size = new System.Drawing.Size(763, 57);
            name_of_educational_institutionLabel.TabIndex = 7;
            name_of_educational_institutionLabel.Text = "Наименование образовательного обучения:";
            // 
            // its_locationLabel
            // 
            its_locationLabel.AutoSize = true;
            its_locationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            its_locationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            its_locationLabel.Location = new System.Drawing.Point(116, 386);
            its_locationLabel.Name = "its_locationLabel";
            its_locationLabel.Size = new System.Drawing.Size(414, 57);
            its_locationLabel.TabIndex = 9;
            its_locationLabel.Text = "Место его нахождения:";
            // 
            // document_nameLabel
            // 
            document_nameLabel.AutoSize = true;
            document_nameLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            document_nameLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_nameLabel.Location = new System.Drawing.Point(116, 439);
            document_nameLabel.Name = "document_nameLabel";
            document_nameLabel.Size = new System.Drawing.Size(475, 57);
            document_nameLabel.TabIndex = 11;
            document_nameLabel.Text = "Наименование документа:";
            // 
            // series_document_numberLabel
            // 
            series_document_numberLabel.AutoSize = true;
            series_document_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series_document_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            series_document_numberLabel.Location = new System.Drawing.Point(116, 490);
            series_document_numberLabel.Name = "series_document_numberLabel";
            series_document_numberLabel.Size = new System.Drawing.Size(470, 57);
            series_document_numberLabel.TabIndex = 13;
            series_document_numberLabel.Text = "Серия и номер документа:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            dateLabel.Location = new System.Drawing.Point(116, 547);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(116, 57);
            dateLabel.TabIndex = 15;
            dateLabel.Text = "Дата:";
            // 
            // iD_qualificationLabel
            // 
            iD_qualificationLabel.AutoSize = true;
            iD_qualificationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_qualificationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_qualificationLabel.Location = new System.Drawing.Point(116, 117);
            iD_qualificationLabel.Name = "iD_qualificationLabel";
            iD_qualificationLabel.Size = new System.Drawing.Size(337, 57);
            iD_qualificationLabel.TabIndex = 20;
            iD_qualificationLabel.Text = "ID квалификации:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advanced_trainingBindingSource
            // 
            this.advanced_trainingBindingSource.DataMember = "Advanced_training";
            this.advanced_trainingBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // advanced_trainingTableAdapter
            // 
            this.advanced_trainingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = this.advanced_trainingTableAdapter;
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
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // advanced_trainingBindingNavigator
            // 
            this.advanced_trainingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.advanced_trainingBindingNavigator.BindingSource = this.advanced_trainingBindingSource;
            this.advanced_trainingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.advanced_trainingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.advanced_trainingBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.advanced_trainingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.advanced_trainingBindingNavigatorSaveItem});
            this.advanced_trainingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.advanced_trainingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.advanced_trainingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.advanced_trainingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.advanced_trainingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.advanced_trainingBindingNavigator.Name = "advanced_trainingBindingNavigator";
            this.advanced_trainingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.advanced_trainingBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.advanced_trainingBindingNavigator.TabIndex = 0;
            this.advanced_trainingBindingNavigator.Text = "bindingNavigator1";
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
            // advanced_trainingBindingNavigatorSaveItem
            // 
            this.advanced_trainingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.advanced_trainingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("advanced_trainingBindingNavigatorSaveItem.Image")));
            this.advanced_trainingBindingNavigatorSaveItem.Name = "advanced_trainingBindingNavigatorSaveItem";
            this.advanced_trainingBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.advanced_trainingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.advanced_trainingBindingNavigatorSaveItem.Visible = false;
            this.advanced_trainingBindingNavigatorSaveItem.Click += new System.EventHandler(this.advanced_trainingBindingNavigatorSaveItem_Click);
            // 
            // beginning_of_trainingDateTimePicker
            // 
            this.beginning_of_trainingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanced_trainingBindingSource, "Beginning_of_training", true));
            this.beginning_of_trainingDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginning_of_trainingDateTimePicker.Location = new System.Drawing.Point(474, 196);
            this.beginning_of_trainingDateTimePicker.Name = "beginning_of_trainingDateTimePicker";
            this.beginning_of_trainingDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.beginning_of_trainingDateTimePicker.TabIndex = 2;
            // 
            // the_end_of_the_trainingDateTimePicker
            // 
            this.the_end_of_the_trainingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanced_trainingBindingSource, "The_end_of_the_training", true));
            this.the_end_of_the_trainingDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.the_end_of_the_trainingDateTimePicker.Location = new System.Drawing.Point(474, 252);
            this.the_end_of_the_trainingDateTimePicker.Name = "the_end_of_the_trainingDateTimePicker";
            this.the_end_of_the_trainingDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.the_end_of_the_trainingDateTimePicker.TabIndex = 4;
            // 
            // type_of_qualificationTextBox
            // 
            this.type_of_qualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "Type_of_qualification", true));
            this.type_of_qualificationTextBox.Location = new System.Drawing.Point(716, 304);
            this.type_of_qualificationTextBox.Name = "type_of_qualificationTextBox";
            this.type_of_qualificationTextBox.Size = new System.Drawing.Size(213, 26);
            this.type_of_qualificationTextBox.TabIndex = 6;
            // 
            // name_of_educational_institutionTextBox
            // 
            this.name_of_educational_institutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "Name_of_educational_institution", true));
            this.name_of_educational_institutionTextBox.Location = new System.Drawing.Point(896, 359);
            this.name_of_educational_institutionTextBox.Name = "name_of_educational_institutionTextBox";
            this.name_of_educational_institutionTextBox.Size = new System.Drawing.Size(369, 26);
            this.name_of_educational_institutionTextBox.TabIndex = 8;
            // 
            // its_locationTextBox
            // 
            this.its_locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "Its_location", true));
            this.its_locationTextBox.Location = new System.Drawing.Point(606, 412);
            this.its_locationTextBox.Name = "its_locationTextBox";
            this.its_locationTextBox.Size = new System.Drawing.Size(242, 26);
            this.its_locationTextBox.TabIndex = 10;
            // 
            // document_nameTextBox
            // 
            this.document_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "Document_name", true));
            this.document_nameTextBox.Location = new System.Drawing.Point(606, 465);
            this.document_nameTextBox.Name = "document_nameTextBox";
            this.document_nameTextBox.Size = new System.Drawing.Size(242, 26);
            this.document_nameTextBox.TabIndex = 12;
            // 
            // series_document_numberTextBox
            // 
            this.series_document_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "Series_document_number", true));
            this.series_document_numberTextBox.Location = new System.Drawing.Point(606, 516);
            this.series_document_numberTextBox.Name = "series_document_numberTextBox";
            this.series_document_numberTextBox.Size = new System.Drawing.Size(242, 26);
            this.series_document_numberTextBox.TabIndex = 14;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanced_trainingBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(269, 569);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.dateDateTimePicker.TabIndex = 16;
            // 
            // buttonBack5
            // 
            this.buttonBack5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack5.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack5.Location = new System.Drawing.Point(1134, 596);
            this.buttonBack5.Name = "buttonBack5";
            this.buttonBack5.Size = new System.Drawing.Size(131, 49);
            this.buttonBack5.TabIndex = 19;
            this.buttonBack5.Text = "Назад";
            this.buttonBack5.UseVisualStyleBackColor = false;
            this.buttonBack5.Click += new System.EventHandler(this.buttonBack5_Click);
            // 
            // buttonSeal5
            // 
            this.buttonSeal5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal5.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal5.Location = new System.Drawing.Point(1134, 541);
            this.buttonSeal5.Name = "buttonSeal5";
            this.buttonSeal5.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal5.TabIndex = 18;
            this.buttonSeal5.Text = "Печать";
            this.buttonSeal5.UseVisualStyleBackColor = false;
            this.buttonSeal5.Click += new System.EventHandler(this.buttonSeal5_Click);
            // 
            // buttonAdd5
            // 
            this.buttonAdd5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd5.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd5.Location = new System.Drawing.Point(1134, 429);
            this.buttonAdd5.Name = "buttonAdd5";
            this.buttonAdd5.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd5.TabIndex = 17;
            this.buttonAdd5.Text = "Добавить";
            this.buttonAdd5.UseVisualStyleBackColor = false;
            this.buttonAdd5.Click += new System.EventHandler(this.buttonAdd5_Click);
            // 
            // ID_qualificationTextBox
            // 
            this.ID_qualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "ID_qualification", true));
            this.ID_qualificationTextBox.Location = new System.Drawing.Point(474, 143);
            this.ID_qualificationTextBox.Name = "ID_qualificationTextBox";
            this.ID_qualificationTextBox.Size = new System.Drawing.Size(81, 26);
            this.ID_qualificationTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1134, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAdvancedTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_qualificationLabel);
            this.Controls.Add(this.ID_qualificationTextBox);
            this.Controls.Add(this.buttonBack5);
            this.Controls.Add(this.buttonSeal5);
            this.Controls.Add(this.buttonAdd5);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(series_document_numberLabel);
            this.Controls.Add(this.series_document_numberTextBox);
            this.Controls.Add(document_nameLabel);
            this.Controls.Add(this.document_nameTextBox);
            this.Controls.Add(its_locationLabel);
            this.Controls.Add(this.its_locationTextBox);
            this.Controls.Add(name_of_educational_institutionLabel);
            this.Controls.Add(this.name_of_educational_institutionTextBox);
            this.Controls.Add(type_of_qualificationLabel);
            this.Controls.Add(this.type_of_qualificationTextBox);
            this.Controls.Add(the_end_of_the_trainingLabel);
            this.Controls.Add(this.the_end_of_the_trainingDateTimePicker);
            this.Controls.Add(beginning_of_trainingLabel);
            this.Controls.Add(this.beginning_of_trainingDateTimePicker);
            this.Controls.Add(this.advanced_trainingBindingNavigator);
            this.Name = "FormAdvancedTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Повышение квалификации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdvancedTraining_FormClosed);
            this.Load += new System.EventHandler(this.FormAdvancedTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingNavigator)).EndInit();
            this.advanced_trainingBindingNavigator.ResumeLayout(false);
            this.advanced_trainingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource advanced_trainingBindingSource;
        private Personal_cardsDataSetTableAdapters.Advanced_trainingTableAdapter advanced_trainingTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator advanced_trainingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton advanced_trainingBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker beginning_of_trainingDateTimePicker;
        private System.Windows.Forms.DateTimePicker the_end_of_the_trainingDateTimePicker;
        private System.Windows.Forms.TextBox type_of_qualificationTextBox;
        private System.Windows.Forms.TextBox name_of_educational_institutionTextBox;
        private System.Windows.Forms.TextBox its_locationTextBox;
        private System.Windows.Forms.TextBox document_nameTextBox;
        private System.Windows.Forms.TextBox series_document_numberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button buttonBack5;
        private System.Windows.Forms.Button buttonSeal5;
        private System.Windows.Forms.Button buttonAdd5;
        private System.Windows.Forms.TextBox ID_qualificationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}