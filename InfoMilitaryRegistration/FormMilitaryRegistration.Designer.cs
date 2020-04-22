namespace Personal_cardsApp1
{
    partial class FormMilitaryRegistration
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
            System.Windows.Forms.Label stock_categoryLabel;
            System.Windows.Forms.Label military_rankLabel;
            System.Windows.Forms.Label composition_profileLabel;
            System.Windows.Forms.Label full_code_designation_VUSLabel;
            System.Windows.Forms.Label category_of_fitness_for_military_serviceLabel;
            System.Windows.Forms.Label the_name_of_the_military_commissariatLabel;
            System.Windows.Forms.Label iD_military_registrationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMilitaryRegistration));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.military_registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.military_registrationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Military_registrationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.military_registrationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.military_registrationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stock_categoryTextBox = new System.Windows.Forms.TextBox();
            this.military_rankTextBox = new System.Windows.Forms.TextBox();
            this.composition_profileTextBox = new System.Windows.Forms.TextBox();
            this.full_code_designation_VUSTextBox = new System.Windows.Forms.TextBox();
            this.category_of_fitness_for_military_serviceTextBox = new System.Windows.Forms.TextBox();
            this.the_name_of_the_military_commissariatTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack8 = new System.Windows.Forms.Button();
            this.buttonSeal8 = new System.Windows.Forms.Button();
            this.buttonAdd8 = new System.Windows.Forms.Button();
            this.ID_military_registrationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            stock_categoryLabel = new System.Windows.Forms.Label();
            military_rankLabel = new System.Windows.Forms.Label();
            composition_profileLabel = new System.Windows.Forms.Label();
            full_code_designation_VUSLabel = new System.Windows.Forms.Label();
            category_of_fitness_for_military_serviceLabel = new System.Windows.Forms.Label();
            the_name_of_the_military_commissariatLabel = new System.Windows.Forms.Label();
            iD_military_registrationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingNavigator)).BeginInit();
            this.military_registrationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stock_categoryLabel
            // 
            stock_categoryLabel.AutoSize = true;
            stock_categoryLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stock_categoryLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            stock_categoryLabel.Location = new System.Drawing.Point(166, 191);
            stock_categoryLabel.Name = "stock_categoryLabel";
            stock_categoryLabel.Size = new System.Drawing.Size(328, 57);
            stock_categoryLabel.TabIndex = 1;
            stock_categoryLabel.Text = "Категория запаса:";
            // 
            // military_rankLabel
            // 
            military_rankLabel.AutoSize = true;
            military_rankLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            military_rankLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            military_rankLabel.Location = new System.Drawing.Point(166, 245);
            military_rankLabel.Name = "military_rankLabel";
            military_rankLabel.Size = new System.Drawing.Size(318, 57);
            military_rankLabel.TabIndex = 3;
            military_rankLabel.Text = "Воинское звание:";
            // 
            // composition_profileLabel
            // 
            composition_profileLabel.AutoSize = true;
            composition_profileLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            composition_profileLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            composition_profileLabel.Location = new System.Drawing.Point(166, 295);
            composition_profileLabel.Name = "composition_profileLabel";
            composition_profileLabel.Size = new System.Drawing.Size(331, 57);
            composition_profileLabel.TabIndex = 5;
            composition_profileLabel.Text = "Состав (профиль):";
            // 
            // full_code_designation_VUSLabel
            // 
            full_code_designation_VUSLabel.AutoSize = true;
            full_code_designation_VUSLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            full_code_designation_VUSLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            full_code_designation_VUSLabel.Location = new System.Drawing.Point(166, 354);
            full_code_designation_VUSLabel.Name = "full_code_designation_VUSLabel";
            full_code_designation_VUSLabel.Size = new System.Drawing.Size(582, 57);
            full_code_designation_VUSLabel.TabIndex = 7;
            full_code_designation_VUSLabel.Text = "Полное кодовое обоначение ВУС:";
            // 
            // category_of_fitness_for_military_serviceLabel
            // 
            category_of_fitness_for_military_serviceLabel.AutoSize = true;
            category_of_fitness_for_military_serviceLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            category_of_fitness_for_military_serviceLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            category_of_fitness_for_military_serviceLabel.Location = new System.Drawing.Point(166, 414);
            category_of_fitness_for_military_serviceLabel.Name = "category_of_fitness_for_military_serviceLabel";
            category_of_fitness_for_military_serviceLabel.Size = new System.Drawing.Size(362, 114);
            category_of_fitness_for_military_serviceLabel.TabIndex = 9;
            category_of_fitness_for_military_serviceLabel.Text = "Категория годности\r\nк военной службе:";
            category_of_fitness_for_military_serviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // the_name_of_the_military_commissariatLabel
            // 
            the_name_of_the_military_commissariatLabel.AutoSize = true;
            the_name_of_the_military_commissariatLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            the_name_of_the_military_commissariatLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            the_name_of_the_military_commissariatLabel.Location = new System.Drawing.Point(166, 528);
            the_name_of_the_military_commissariatLabel.Name = "the_name_of_the_military_commissariatLabel";
            the_name_of_the_military_commissariatLabel.Size = new System.Drawing.Size(518, 114);
            the_name_of_the_military_commissariatLabel.TabIndex = 11;
            the_name_of_the_military_commissariatLabel.Text = "Наименование комиссариата\r\nпо месту жительства:";
            the_name_of_the_military_commissariatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iD_military_registrationLabel
            // 
            iD_military_registrationLabel.AutoSize = true;
            iD_military_registrationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_military_registrationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_military_registrationLabel.Location = new System.Drawing.Point(166, 134);
            iD_military_registrationLabel.Name = "iD_military_registrationLabel";
            iD_military_registrationLabel.Size = new System.Drawing.Size(356, 57);
            iD_military_registrationLabel.TabIndex = 17;
            iD_military_registrationLabel.Text = "ID воинского учета:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // military_registrationBindingSource
            // 
            this.military_registrationBindingSource.DataMember = "Military_registration";
            this.military_registrationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // military_registrationTableAdapter
            // 
            this.military_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = this.military_registrationTableAdapter;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // military_registrationBindingNavigator
            // 
            this.military_registrationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.military_registrationBindingNavigator.BindingSource = this.military_registrationBindingSource;
            this.military_registrationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.military_registrationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.military_registrationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.military_registrationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.military_registrationBindingNavigatorSaveItem});
            this.military_registrationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.military_registrationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.military_registrationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.military_registrationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.military_registrationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.military_registrationBindingNavigator.Name = "military_registrationBindingNavigator";
            this.military_registrationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.military_registrationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.military_registrationBindingNavigator.TabIndex = 0;
            this.military_registrationBindingNavigator.Text = "bindingNavigator1";
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
            // military_registrationBindingNavigatorSaveItem
            // 
            this.military_registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.military_registrationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("military_registrationBindingNavigatorSaveItem.Image")));
            this.military_registrationBindingNavigatorSaveItem.Name = "military_registrationBindingNavigatorSaveItem";
            this.military_registrationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.military_registrationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.military_registrationBindingNavigatorSaveItem.Visible = false;
            this.military_registrationBindingNavigatorSaveItem.Click += new System.EventHandler(this.military_registrationBindingNavigatorSaveItem_Click);
            // 
            // stock_categoryTextBox
            // 
            this.stock_categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "Stock_category", true));
            this.stock_categoryTextBox.Location = new System.Drawing.Point(509, 217);
            this.stock_categoryTextBox.Name = "stock_categoryTextBox";
            this.stock_categoryTextBox.Size = new System.Drawing.Size(218, 26);
            this.stock_categoryTextBox.TabIndex = 2;
            // 
            // military_rankTextBox
            // 
            this.military_rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "Military_rank", true));
            this.military_rankTextBox.Location = new System.Drawing.Point(509, 271);
            this.military_rankTextBox.Name = "military_rankTextBox";
            this.military_rankTextBox.Size = new System.Drawing.Size(218, 26);
            this.military_rankTextBox.TabIndex = 4;
            // 
            // composition_profileTextBox
            // 
            this.composition_profileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "Composition_profile", true));
            this.composition_profileTextBox.Location = new System.Drawing.Point(509, 321);
            this.composition_profileTextBox.Name = "composition_profileTextBox";
            this.composition_profileTextBox.Size = new System.Drawing.Size(218, 26);
            this.composition_profileTextBox.TabIndex = 6;
            // 
            // full_code_designation_VUSTextBox
            // 
            this.full_code_designation_VUSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "Full_code_designation_VUS", true));
            this.full_code_designation_VUSTextBox.Location = new System.Drawing.Point(777, 380);
            this.full_code_designation_VUSTextBox.Name = "full_code_designation_VUSTextBox";
            this.full_code_designation_VUSTextBox.Size = new System.Drawing.Size(218, 26);
            this.full_code_designation_VUSTextBox.TabIndex = 8;
            // 
            // category_of_fitness_for_military_serviceTextBox
            // 
            this.category_of_fitness_for_military_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "Category_of_fitness_for_military_service", true));
            this.category_of_fitness_for_military_serviceTextBox.Location = new System.Drawing.Point(553, 463);
            this.category_of_fitness_for_military_serviceTextBox.Name = "category_of_fitness_for_military_serviceTextBox";
            this.category_of_fitness_for_military_serviceTextBox.Size = new System.Drawing.Size(235, 26);
            this.category_of_fitness_for_military_serviceTextBox.TabIndex = 10;
            // 
            // the_name_of_the_military_commissariatTextBox
            // 
            this.the_name_of_the_military_commissariatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "The_name_of_the_military_commissariat", true));
            this.the_name_of_the_military_commissariatTextBox.Location = new System.Drawing.Point(710, 583);
            this.the_name_of_the_military_commissariatTextBox.Name = "the_name_of_the_military_commissariatTextBox";
            this.the_name_of_the_military_commissariatTextBox.Size = new System.Drawing.Size(256, 26);
            this.the_name_of_the_military_commissariatTextBox.TabIndex = 12;
            // 
            // buttonBack8
            // 
            this.buttonBack8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack8.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack8.Location = new System.Drawing.Point(1118, 626);
            this.buttonBack8.Name = "buttonBack8";
            this.buttonBack8.Size = new System.Drawing.Size(131, 49);
            this.buttonBack8.TabIndex = 17;
            this.buttonBack8.Text = "Назад";
            this.buttonBack8.UseVisualStyleBackColor = false;
            this.buttonBack8.Click += new System.EventHandler(this.buttonBack8_Click);
            // 
            // buttonSeal8
            // 
            this.buttonSeal8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal8.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal8.Location = new System.Drawing.Point(1118, 571);
            this.buttonSeal8.Name = "buttonSeal8";
            this.buttonSeal8.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal8.TabIndex = 16;
            this.buttonSeal8.Text = "Печать";
            this.buttonSeal8.UseVisualStyleBackColor = false;
            this.buttonSeal8.Click += new System.EventHandler(this.buttonSeal8_Click);
            // 
            // buttonAdd8
            // 
            this.buttonAdd8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd8.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd8.Location = new System.Drawing.Point(1118, 462);
            this.buttonAdd8.Name = "buttonAdd8";
            this.buttonAdd8.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd8.TabIndex = 15;
            this.buttonAdd8.Text = "Добавить";
            this.buttonAdd8.UseVisualStyleBackColor = false;
            this.buttonAdd8.Click += new System.EventHandler(this.buttonAdd8_Click);
            // 
            // ID_military_registrationTextBox
            // 
            this.ID_military_registrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.military_registrationBindingSource, "ID_military_registration", true));
            this.ID_military_registrationTextBox.Location = new System.Drawing.Point(528, 160);
            this.ID_military_registrationTextBox.Name = "ID_military_registrationTextBox";
            this.ID_military_registrationTextBox.Size = new System.Drawing.Size(100, 26);
            this.ID_military_registrationTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1118, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormMilitaryRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_military_registrationLabel);
            this.Controls.Add(this.ID_military_registrationTextBox);
            this.Controls.Add(this.buttonBack8);
            this.Controls.Add(this.buttonSeal8);
            this.Controls.Add(this.buttonAdd8);
            this.Controls.Add(the_name_of_the_military_commissariatLabel);
            this.Controls.Add(this.the_name_of_the_military_commissariatTextBox);
            this.Controls.Add(category_of_fitness_for_military_serviceLabel);
            this.Controls.Add(this.category_of_fitness_for_military_serviceTextBox);
            this.Controls.Add(full_code_designation_VUSLabel);
            this.Controls.Add(this.full_code_designation_VUSTextBox);
            this.Controls.Add(composition_profileLabel);
            this.Controls.Add(this.composition_profileTextBox);
            this.Controls.Add(military_rankLabel);
            this.Controls.Add(this.military_rankTextBox);
            this.Controls.Add(stock_categoryLabel);
            this.Controls.Add(this.stock_categoryTextBox);
            this.Controls.Add(this.military_registrationBindingNavigator);
            this.Name = "FormMilitaryRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Воинский учет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMilitaryRegistration_FormClosed);
            this.Load += new System.EventHandler(this.FormMilitaryRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingNavigator)).EndInit();
            this.military_registrationBindingNavigator.ResumeLayout(false);
            this.military_registrationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource military_registrationBindingSource;
        private Personal_cardsDataSetTableAdapters.Military_registrationTableAdapter military_registrationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator military_registrationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton military_registrationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stock_categoryTextBox;
        private System.Windows.Forms.TextBox military_rankTextBox;
        private System.Windows.Forms.TextBox composition_profileTextBox;
        private System.Windows.Forms.TextBox full_code_designation_VUSTextBox;
        private System.Windows.Forms.TextBox category_of_fitness_for_military_serviceTextBox;
        private System.Windows.Forms.TextBox the_name_of_the_military_commissariatTextBox;
        private System.Windows.Forms.Button buttonBack8;
        private System.Windows.Forms.Button buttonSeal8;
        private System.Windows.Forms.Button buttonAdd8;
        private System.Windows.Forms.TextBox ID_military_registrationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}