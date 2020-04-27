namespace Personal_cardsApp1
{
    partial class FormOrderAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderAdmission));
            System.Windows.Forms.Label iD_orderLabel;
            System.Windows.Forms.Label name_organizationLabel;
            System.Windows.Forms.Label document_numberLabel;
            System.Windows.Forms.Label date_compilationLabel;
            System.Windows.Forms.Label to_take_withLabel;
            System.Windows.Forms.Label service_numberLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label structural_divisionLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label nature_workLabel;
            System.Windows.Forms.Label with_tariff_rateLabel;
            System.Windows.Forms.Label at_premiumLabel;
            System.Windows.Forms.Label with_trial_periodLabel;
            System.Windows.Forms.Label employment_contract_fromLabel;
            System.Windows.Forms.Label contract_numberLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.order_admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_admissionTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Order_admissionTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.order_admissionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.order_admissionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.IDOrderTextBox = new System.Windows.Forms.TextBox();
            this.NameOrganizationTextBox = new System.Windows.Forms.TextBox();
            this.DocumentNumberTextBox = new System.Windows.Forms.TextBox();
            this.CompilationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TakeWithDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ServiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.DivisionTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.WorkTextBox = new System.Windows.Forms.TextBox();
            this.TariffTextBox = new System.Windows.Forms.TextBox();
            this.PremiumTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.ContractNumTextBox = new System.Windows.Forms.TextBox();
            this.ContractDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonExportWord = new System.Windows.Forms.Button();
            iD_orderLabel = new System.Windows.Forms.Label();
            name_organizationLabel = new System.Windows.Forms.Label();
            document_numberLabel = new System.Windows.Forms.Label();
            date_compilationLabel = new System.Windows.Forms.Label();
            to_take_withLabel = new System.Windows.Forms.Label();
            service_numberLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            structural_divisionLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            nature_workLabel = new System.Windows.Forms.Label();
            with_tariff_rateLabel = new System.Windows.Forms.Label();
            at_premiumLabel = new System.Windows.Forms.Label();
            with_trial_periodLabel = new System.Windows.Forms.Label();
            employment_contract_fromLabel = new System.Windows.Forms.Label();
            contract_numberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingNavigator)).BeginInit();
            this.order_admissionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContractDateTimePicker);
            this.groupBox1.Controls.Add(this.ContractNumTextBox);
            this.groupBox1.Controls.Add(this.PeriodTextBox);
            this.groupBox1.Controls.Add(this.PremiumTextBox);
            this.groupBox1.Controls.Add(this.TariffTextBox);
            this.groupBox1.Controls.Add(this.WorkTextBox);
            this.groupBox1.Controls.Add(this.PositionTextBox);
            this.groupBox1.Controls.Add(this.DivisionTextBox);
            this.groupBox1.Controls.Add(this.FIOTextBox);
            this.groupBox1.Controls.Add(this.ServiceNumberTextBox);
            this.groupBox1.Controls.Add(this.TakeWithDateTimePicker);
            this.groupBox1.Controls.Add(this.CompilationDateTimePicker);
            this.groupBox1.Controls.Add(this.DocumentNumberTextBox);
            this.groupBox1.Controls.Add(this.NameOrganizationTextBox);
            this.groupBox1.Controls.Add(this.IDOrderTextBox);
            this.groupBox1.Controls.Add(iD_orderLabel);
            this.groupBox1.Controls.Add(name_organizationLabel);
            this.groupBox1.Controls.Add(document_numberLabel);
            this.groupBox1.Controls.Add(date_compilationLabel);
            this.groupBox1.Controls.Add(to_take_withLabel);
            this.groupBox1.Controls.Add(service_numberLabel);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(structural_divisionLabel);
            this.groupBox1.Controls.Add(positionLabel);
            this.groupBox1.Controls.Add(nature_workLabel);
            this.groupBox1.Controls.Add(with_tariff_rateLabel);
            this.groupBox1.Controls.Add(at_premiumLabel);
            this.groupBox1.Controls.Add(with_trial_periodLabel);
            this.groupBox1.Controls.Add(employment_contract_fromLabel);
            this.groupBox1.Controls.Add(contract_numberLabel);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12.25532F);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(66, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 812);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление приказа";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_admissionBindingSource
            // 
            this.order_admissionBindingSource.DataMember = "Order_admission";
            this.order_admissionBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // order_admissionTableAdapter
            // 
            this.order_admissionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Granting_leaveTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Order_admissionTableAdapter = this.order_admissionTableAdapter;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.Staff_listTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // order_admissionBindingNavigator
            // 
            this.order_admissionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.order_admissionBindingNavigator.BindingSource = this.order_admissionBindingSource;
            this.order_admissionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_admissionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order_admissionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.order_admissionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.order_admissionBindingNavigatorSaveItem});
            this.order_admissionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_admissionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_admissionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_admissionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_admissionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_admissionBindingNavigator.Name = "order_admissionBindingNavigator";
            this.order_admissionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_admissionBindingNavigator.Size = new System.Drawing.Size(1357, 32);
            this.order_admissionBindingNavigator.TabIndex = 1;
            this.order_admissionBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // order_admissionBindingNavigatorSaveItem
            // 
            this.order_admissionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order_admissionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order_admissionBindingNavigatorSaveItem.Image")));
            this.order_admissionBindingNavigatorSaveItem.Name = "order_admissionBindingNavigatorSaveItem";
            this.order_admissionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.order_admissionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.order_admissionBindingNavigatorSaveItem.Click += new System.EventHandler(this.order_admissionBindingNavigatorSaveItem_Click);
            // 
            // iD_orderLabel
            // 
            iD_orderLabel.AutoSize = true;
            iD_orderLabel.Location = new System.Drawing.Point(6, 118);
            iD_orderLabel.Name = "iD_orderLabel";
            iD_orderLabel.Size = new System.Drawing.Size(101, 36);
            iD_orderLabel.TabIndex = 0;
            iD_orderLabel.Text = "ID order:";
            // 
            // name_organizationLabel
            // 
            name_organizationLabel.AutoSize = true;
            name_organizationLabel.Location = new System.Drawing.Point(6, 163);
            name_organizationLabel.Name = "name_organizationLabel";
            name_organizationLabel.Size = new System.Drawing.Size(202, 36);
            name_organizationLabel.TabIndex = 2;
            name_organizationLabel.Text = "Name organization:";
            // 
            // document_numberLabel
            // 
            document_numberLabel.AutoSize = true;
            document_numberLabel.Location = new System.Drawing.Point(6, 208);
            document_numberLabel.Name = "document_numberLabel";
            document_numberLabel.Size = new System.Drawing.Size(199, 36);
            document_numberLabel.TabIndex = 4;
            document_numberLabel.Text = "Document number:";
            // 
            // date_compilationLabel
            // 
            date_compilationLabel.AutoSize = true;
            date_compilationLabel.Location = new System.Drawing.Point(6, 254);
            date_compilationLabel.Name = "date_compilationLabel";
            date_compilationLabel.Size = new System.Drawing.Size(182, 36);
            date_compilationLabel.TabIndex = 6;
            date_compilationLabel.Text = "Date compilation:";
            // 
            // to_take_withLabel
            // 
            to_take_withLabel.AutoSize = true;
            to_take_withLabel.Location = new System.Drawing.Point(6, 300);
            to_take_withLabel.Name = "to_take_withLabel";
            to_take_withLabel.Size = new System.Drawing.Size(139, 36);
            to_take_withLabel.TabIndex = 8;
            to_take_withLabel.Text = "To take with:";
            // 
            // service_numberLabel
            // 
            service_numberLabel.AutoSize = true;
            service_numberLabel.Location = new System.Drawing.Point(6, 345);
            service_numberLabel.Name = "service_numberLabel";
            service_numberLabel.Size = new System.Drawing.Size(170, 36);
            service_numberLabel.TabIndex = 10;
            service_numberLabel.Text = "Service number:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(6, 390);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(57, 36);
            fIOLabel.TabIndex = 12;
            fIOLabel.Text = "FIO:";
            // 
            // structural_divisionLabel
            // 
            structural_divisionLabel.AutoSize = true;
            structural_divisionLabel.Location = new System.Drawing.Point(6, 435);
            structural_divisionLabel.Name = "structural_divisionLabel";
            structural_divisionLabel.Size = new System.Drawing.Size(196, 36);
            structural_divisionLabel.TabIndex = 14;
            structural_divisionLabel.Text = "Structural division:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(6, 480);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(97, 36);
            positionLabel.TabIndex = 16;
            positionLabel.Text = "Position:";
            // 
            // nature_workLabel
            // 
            nature_workLabel.AutoSize = true;
            nature_workLabel.Location = new System.Drawing.Point(6, 525);
            nature_workLabel.Name = "nature_workLabel";
            nature_workLabel.Size = new System.Drawing.Size(140, 36);
            nature_workLabel.TabIndex = 18;
            nature_workLabel.Text = "Nature work:";
            // 
            // with_tariff_rateLabel
            // 
            with_tariff_rateLabel.AutoSize = true;
            with_tariff_rateLabel.Location = new System.Drawing.Point(6, 570);
            with_tariff_rateLabel.Name = "with_tariff_rateLabel";
            with_tariff_rateLabel.Size = new System.Drawing.Size(165, 36);
            with_tariff_rateLabel.TabIndex = 20;
            with_tariff_rateLabel.Text = "With tariff rate:";
            // 
            // at_premiumLabel
            // 
            at_premiumLabel.AutoSize = true;
            at_premiumLabel.Location = new System.Drawing.Point(6, 615);
            at_premiumLabel.Name = "at_premiumLabel";
            at_premiumLabel.Size = new System.Drawing.Size(136, 36);
            at_premiumLabel.TabIndex = 22;
            at_premiumLabel.Text = "At premium:";
            // 
            // with_trial_periodLabel
            // 
            with_trial_periodLabel.AutoSize = true;
            with_trial_periodLabel.Location = new System.Drawing.Point(6, 660);
            with_trial_periodLabel.Name = "with_trial_periodLabel";
            with_trial_periodLabel.Size = new System.Drawing.Size(180, 36);
            with_trial_periodLabel.TabIndex = 24;
            with_trial_periodLabel.Text = "With trial period:";
            // 
            // employment_contract_fromLabel
            // 
            employment_contract_fromLabel.AutoSize = true;
            employment_contract_fromLabel.Location = new System.Drawing.Point(6, 706);
            employment_contract_fromLabel.Name = "employment_contract_fromLabel";
            employment_contract_fromLabel.Size = new System.Drawing.Size(277, 36);
            employment_contract_fromLabel.TabIndex = 26;
            employment_contract_fromLabel.Text = "Employment contract from:";
            // 
            // contract_numberLabel
            // 
            contract_numberLabel.AutoSize = true;
            contract_numberLabel.Location = new System.Drawing.Point(6, 751);
            contract_numberLabel.Name = "contract_numberLabel";
            contract_numberLabel.Size = new System.Drawing.Size(184, 36);
            contract_numberLabel.TabIndex = 28;
            contract_numberLabel.Text = "Contract number:";
            // 
            // IDOrderTextBox
            // 
            this.IDOrderTextBox.Location = new System.Drawing.Point(137, 115);
            this.IDOrderTextBox.Name = "IDOrderTextBox";
            this.IDOrderTextBox.Size = new System.Drawing.Size(100, 38);
            this.IDOrderTextBox.TabIndex = 29;
            // 
            // NameOrganizationTextBox
            // 
            this.NameOrganizationTextBox.Location = new System.Drawing.Point(214, 163);
            this.NameOrganizationTextBox.Name = "NameOrganizationTextBox";
            this.NameOrganizationTextBox.Size = new System.Drawing.Size(100, 38);
            this.NameOrganizationTextBox.TabIndex = 30;
            // 
            // DocumentNumberTextBox
            // 
            this.DocumentNumberTextBox.Location = new System.Drawing.Point(211, 205);
            this.DocumentNumberTextBox.Name = "DocumentNumberTextBox";
            this.DocumentNumberTextBox.Size = new System.Drawing.Size(109, 38);
            this.DocumentNumberTextBox.TabIndex = 31;
            // 
            // CompilationDateTimePicker
            // 
            this.CompilationDateTimePicker.Location = new System.Drawing.Point(211, 254);
            this.CompilationDateTimePicker.Name = "CompilationDateTimePicker";
            this.CompilationDateTimePicker.Size = new System.Drawing.Size(209, 38);
            this.CompilationDateTimePicker.TabIndex = 32;
            // 
            // TakeWithDateTimePicker
            // 
            this.TakeWithDateTimePicker.Location = new System.Drawing.Point(211, 298);
            this.TakeWithDateTimePicker.Name = "TakeWithDateTimePicker";
            this.TakeWithDateTimePicker.Size = new System.Drawing.Size(209, 38);
            this.TakeWithDateTimePicker.TabIndex = 33;
            // 
            // ServiceNumberTextBox
            // 
            this.ServiceNumberTextBox.Location = new System.Drawing.Point(211, 345);
            this.ServiceNumberTextBox.Name = "ServiceNumberTextBox";
            this.ServiceNumberTextBox.Size = new System.Drawing.Size(200, 38);
            this.ServiceNumberTextBox.TabIndex = 34;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(71, 387);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(100, 38);
            this.FIOTextBox.TabIndex = 35;
            // 
            // DivisionTextBox
            // 
            this.DivisionTextBox.Location = new System.Drawing.Point(211, 435);
            this.DivisionTextBox.Name = "DivisionTextBox";
            this.DivisionTextBox.Size = new System.Drawing.Size(100, 38);
            this.DivisionTextBox.TabIndex = 36;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(109, 480);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 38);
            this.PositionTextBox.TabIndex = 37;
            // 
            // WorkTextBox
            // 
            this.WorkTextBox.Location = new System.Drawing.Point(152, 523);
            this.WorkTextBox.Name = "WorkTextBox";
            this.WorkTextBox.Size = new System.Drawing.Size(100, 38);
            this.WorkTextBox.TabIndex = 38;
            // 
            // TariffTextBox
            // 
            this.TariffTextBox.Location = new System.Drawing.Point(177, 570);
            this.TariffTextBox.Name = "TariffTextBox";
            this.TariffTextBox.Size = new System.Drawing.Size(100, 38);
            this.TariffTextBox.TabIndex = 39;
            // 
            // PremiumTextBox
            // 
            this.PremiumTextBox.Location = new System.Drawing.Point(177, 615);
            this.PremiumTextBox.Name = "PremiumTextBox";
            this.PremiumTextBox.Size = new System.Drawing.Size(100, 38);
            this.PremiumTextBox.TabIndex = 40;
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(187, 665);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(124, 38);
            this.PeriodTextBox.TabIndex = 41;
            // 
            // ContractNumTextBox
            // 
            this.ContractNumTextBox.Location = new System.Drawing.Point(211, 751);
            this.ContractNumTextBox.Name = "ContractNumTextBox";
            this.ContractNumTextBox.Size = new System.Drawing.Size(100, 38);
            this.ContractNumTextBox.TabIndex = 42;
            // 
            // ContractDateTimePicker
            // 
            this.ContractDateTimePicker.Location = new System.Drawing.Point(289, 709);
            this.ContractDateTimePicker.Name = "ContractDateTimePicker";
            this.ContractDateTimePicker.Size = new System.Drawing.Size(218, 38);
            this.ContractDateTimePicker.TabIndex = 43;
            // 
            // buttonExportWord
            // 
            this.buttonExportWord.ForeColor = System.Drawing.Color.Black;
            this.buttonExportWord.Location = new System.Drawing.Point(1159, 270);
            this.buttonExportWord.Name = "buttonExportWord";
            this.buttonExportWord.Size = new System.Drawing.Size(139, 68);
            this.buttonExportWord.TabIndex = 2;
            this.buttonExportWord.Text = "Сформировать";
            this.buttonExportWord.UseVisualStyleBackColor = true;
            this.buttonExportWord.Click += new System.EventHandler(this.buttonExportWord_Click);
            // 
            // FormOrderAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 1010);
            this.Controls.Add(this.buttonExportWord);
            this.Controls.Add(this.order_admissionBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormOrderAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приказ о приеме работника на работу";
            this.Load += new System.EventHandler(this.FormOrderAdmission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingNavigator)).EndInit();
            this.order_admissionBindingNavigator.ResumeLayout(false);
            this.order_admissionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource order_admissionBindingSource;
        private Personal_cardsDataSetTableAdapters.Order_admissionTableAdapter order_admissionTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator order_admissionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton order_admissionBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker ContractDateTimePicker;
        private System.Windows.Forms.TextBox ContractNumTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.TextBox PremiumTextBox;
        private System.Windows.Forms.TextBox TariffTextBox;
        private System.Windows.Forms.TextBox WorkTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox DivisionTextBox;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.TextBox ServiceNumberTextBox;
        private System.Windows.Forms.DateTimePicker TakeWithDateTimePicker;
        private System.Windows.Forms.DateTimePicker CompilationDateTimePicker;
        private System.Windows.Forms.TextBox DocumentNumberTextBox;
        private System.Windows.Forms.TextBox NameOrganizationTextBox;
        private System.Windows.Forms.TextBox IDOrderTextBox;
        private System.Windows.Forms.Button buttonExportWord;
    }
}