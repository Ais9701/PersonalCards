namespace Personal_cardsApp1
{
    partial class FormOrderAdmission1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderAdmission1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_orderTextBox = new System.Windows.Forms.TextBox();
            this.order_admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.name_organizationTextBox = new System.Windows.Forms.TextBox();
            this.document_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_compilationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_take_withDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.service_numberTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.structural_divisionTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nature_workTextBox = new System.Windows.Forms.TextBox();
            this.with_tariff_rateTextBox = new System.Windows.Forms.TextBox();
            this.at_premiumTextBox = new System.Windows.Forms.TextBox();
            this.with_trial_periodTextBox = new System.Windows.Forms.TextBox();
            this.employment_contract_fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contract_numberTextBox = new System.Windows.Forms.TextBox();
            this.order_admissionTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Order_admissionTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.order_admissionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.order_admissionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxpoisk = new System.Windows.Forms.TextBox();
            this.buttonpoisk = new System.Windows.Forms.Button();
            this.buttonfilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingNavigator)).BeginInit();
            this.order_admissionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_orderLabel
            // 
            iD_orderLabel.AutoSize = true;
            iD_orderLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            iD_orderLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_orderLabel.Location = new System.Drawing.Point(6, 34);
            iD_orderLabel.Name = "iD_orderLabel";
            iD_orderLabel.Size = new System.Drawing.Size(151, 39);
            iD_orderLabel.TabIndex = 0;
            iD_orderLabel.Text = "ID приказа:";
            // 
            // name_organizationLabel
            // 
            name_organizationLabel.AutoSize = true;
            name_organizationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            name_organizationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_organizationLabel.Location = new System.Drawing.Point(6, 79);
            name_organizationLabel.Name = "name_organizationLabel";
            name_organizationLabel.Size = new System.Drawing.Size(356, 39);
            name_organizationLabel.TabIndex = 2;
            name_organizationLabel.Text = "Наименование организации:";
            // 
            // document_numberLabel
            // 
            document_numberLabel.AutoSize = true;
            document_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            document_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_numberLabel.Location = new System.Drawing.Point(6, 124);
            document_numberLabel.Name = "document_numberLabel";
            document_numberLabel.Size = new System.Drawing.Size(229, 39);
            document_numberLabel.TabIndex = 4;
            document_numberLabel.Text = "Номер документа:";
            // 
            // date_compilationLabel
            // 
            date_compilationLabel.AutoSize = true;
            date_compilationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            date_compilationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_compilationLabel.Location = new System.Drawing.Point(6, 170);
            date_compilationLabel.Name = "date_compilationLabel";
            date_compilationLabel.Size = new System.Drawing.Size(228, 39);
            date_compilationLabel.TabIndex = 6;
            date_compilationLabel.Text = "Дата составления:";
            // 
            // to_take_withLabel
            // 
            to_take_withLabel.AutoSize = true;
            to_take_withLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            to_take_withLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            to_take_withLabel.Location = new System.Drawing.Point(6, 216);
            to_take_withLabel.Name = "to_take_withLabel";
            to_take_withLabel.Size = new System.Drawing.Size(274, 39);
            to_take_withLabel.TabIndex = 8;
            to_take_withLabel.Text = "Принятие на работу с:\r\n";
            // 
            // service_numberLabel
            // 
            service_numberLabel.AutoSize = true;
            service_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            service_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            service_numberLabel.Location = new System.Drawing.Point(6, 261);
            service_numberLabel.Name = "service_numberLabel";
            service_numberLabel.Size = new System.Drawing.Size(230, 39);
            service_numberLabel.TabIndex = 10;
            service_numberLabel.Text = "Табельный номер:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            fIOLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            fIOLabel.Location = new System.Drawing.Point(6, 306);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(79, 39);
            fIOLabel.TabIndex = 12;
            fIOLabel.Text = "ФИО:";
            // 
            // structural_divisionLabel
            // 
            structural_divisionLabel.AutoSize = true;
            structural_divisionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            structural_divisionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            structural_divisionLabel.Location = new System.Drawing.Point(6, 351);
            structural_divisionLabel.Name = "structural_divisionLabel";
            structural_divisionLabel.Size = new System.Drawing.Size(351, 39);
            structural_divisionLabel.TabIndex = 14;
            structural_divisionLabel.Text = "Структурное подразделение:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            positionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            positionLabel.Location = new System.Drawing.Point(6, 396);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(152, 39);
            positionLabel.TabIndex = 16;
            positionLabel.Text = "Должность:";
            // 
            // nature_workLabel
            // 
            nature_workLabel.AutoSize = true;
            nature_workLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            nature_workLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            nature_workLabel.Location = new System.Drawing.Point(6, 441);
            nature_workLabel.Name = "nature_workLabel";
            nature_workLabel.Size = new System.Drawing.Size(220, 39);
            nature_workLabel.TabIndex = 18;
            nature_workLabel.Text = "Характер работы:";
            // 
            // with_tariff_rateLabel
            // 
            with_tariff_rateLabel.AutoSize = true;
            with_tariff_rateLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            with_tariff_rateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            with_tariff_rateLabel.Location = new System.Drawing.Point(6, 486);
            with_tariff_rateLabel.Name = "with_tariff_rateLabel";
            with_tariff_rateLabel.Size = new System.Drawing.Size(258, 39);
            with_tariff_rateLabel.TabIndex = 20;
            with_tariff_rateLabel.Text = "С тарифной ставкой:";
            // 
            // at_premiumLabel
            // 
            at_premiumLabel.AutoSize = true;
            at_premiumLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            at_premiumLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            at_premiumLabel.Location = new System.Drawing.Point(6, 531);
            at_premiumLabel.Name = "at_premiumLabel";
            at_premiumLabel.Size = new System.Drawing.Size(168, 39);
            at_premiumLabel.TabIndex = 22;
            at_premiumLabel.Text = "С надбавкой:";
            // 
            // with_trial_periodLabel
            // 
            with_trial_periodLabel.AutoSize = true;
            with_trial_periodLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            with_trial_periodLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            with_trial_periodLabel.Location = new System.Drawing.Point(6, 576);
            with_trial_periodLabel.Name = "with_trial_periodLabel";
            with_trial_periodLabel.Size = new System.Drawing.Size(283, 39);
            with_trial_periodLabel.TabIndex = 24;
            with_trial_periodLabel.Text = "С испытанием на срок:";
            // 
            // employment_contract_fromLabel
            // 
            employment_contract_fromLabel.AutoSize = true;
            employment_contract_fromLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            employment_contract_fromLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            employment_contract_fromLabel.Location = new System.Drawing.Point(6, 622);
            employment_contract_fromLabel.Name = "employment_contract_fromLabel";
            employment_contract_fromLabel.Size = new System.Drawing.Size(264, 39);
            employment_contract_fromLabel.TabIndex = 26;
            employment_contract_fromLabel.Text = "Трудовой договор от:";
            // 
            // contract_numberLabel
            // 
            contract_numberLabel.AutoSize = true;
            contract_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            contract_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            contract_numberLabel.Location = new System.Drawing.Point(6, 667);
            contract_numberLabel.Name = "contract_numberLabel";
            contract_numberLabel.Size = new System.Drawing.Size(210, 39);
            contract_numberLabel.TabIndex = 28;
            contract_numberLabel.Text = "Номер договора:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(iD_orderLabel);
            this.groupBox1.Controls.Add(this.iD_orderTextBox);
            this.groupBox1.Controls.Add(name_organizationLabel);
            this.groupBox1.Controls.Add(this.name_organizationTextBox);
            this.groupBox1.Controls.Add(document_numberLabel);
            this.groupBox1.Controls.Add(this.document_numberTextBox);
            this.groupBox1.Controls.Add(date_compilationLabel);
            this.groupBox1.Controls.Add(this.date_compilationDateTimePicker);
            this.groupBox1.Controls.Add(to_take_withLabel);
            this.groupBox1.Controls.Add(this.to_take_withDateTimePicker);
            this.groupBox1.Controls.Add(service_numberLabel);
            this.groupBox1.Controls.Add(this.service_numberTextBox);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(this.fIOTextBox);
            this.groupBox1.Controls.Add(structural_divisionLabel);
            this.groupBox1.Controls.Add(this.structural_divisionTextBox);
            this.groupBox1.Controls.Add(positionLabel);
            this.groupBox1.Controls.Add(this.positionTextBox);
            this.groupBox1.Controls.Add(nature_workLabel);
            this.groupBox1.Controls.Add(this.nature_workTextBox);
            this.groupBox1.Controls.Add(with_tariff_rateLabel);
            this.groupBox1.Controls.Add(this.with_tariff_rateTextBox);
            this.groupBox1.Controls.Add(at_premiumLabel);
            this.groupBox1.Controls.Add(this.at_premiumTextBox);
            this.groupBox1.Controls.Add(with_trial_periodLabel);
            this.groupBox1.Controls.Add(this.with_trial_periodTextBox);
            this.groupBox1.Controls.Add(employment_contract_fromLabel);
            this.groupBox1.Controls.Add(this.employment_contract_fromDateTimePicker);
            this.groupBox1.Controls.Add(contract_numberLabel);
            this.groupBox1.Controls.Add(this.contract_numberTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12.25532F);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приказы";
            // 
            // iD_orderTextBox
            // 
            this.iD_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "ID_order", true));
            this.iD_orderTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_orderTextBox.Location = new System.Drawing.Point(182, 43);
            this.iD_orderTextBox.Name = "iD_orderTextBox";
            this.iD_orderTextBox.Size = new System.Drawing.Size(53, 30);
            this.iD_orderTextBox.TabIndex = 1;
            // 
            // order_admissionBindingSource
            // 
            this.order_admissionBindingSource.DataMember = "Order_admission";
            this.order_admissionBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // name_organizationTextBox
            // 
            this.name_organizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Name_organization", true));
            this.name_organizationTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_organizationTextBox.Location = new System.Drawing.Point(390, 86);
            this.name_organizationTextBox.Name = "name_organizationTextBox";
            this.name_organizationTextBox.Size = new System.Drawing.Size(316, 30);
            this.name_organizationTextBox.TabIndex = 3;
            // 
            // document_numberTextBox
            // 
            this.document_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Document_number", true));
            this.document_numberTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.document_numberTextBox.Location = new System.Drawing.Point(390, 135);
            this.document_numberTextBox.Name = "document_numberTextBox";
            this.document_numberTextBox.Size = new System.Drawing.Size(316, 30);
            this.document_numberTextBox.TabIndex = 5;
            // 
            // date_compilationDateTimePicker
            // 
            this.date_compilationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_admissionBindingSource, "Date_compilation", true));
            this.date_compilationDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_compilationDateTimePicker.Location = new System.Drawing.Point(390, 179);
            this.date_compilationDateTimePicker.Name = "date_compilationDateTimePicker";
            this.date_compilationDateTimePicker.Size = new System.Drawing.Size(316, 30);
            this.date_compilationDateTimePicker.TabIndex = 7;
            // 
            // to_take_withDateTimePicker
            // 
            this.to_take_withDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_admissionBindingSource, "To_take_with", true));
            this.to_take_withDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_take_withDateTimePicker.Location = new System.Drawing.Point(390, 225);
            this.to_take_withDateTimePicker.Name = "to_take_withDateTimePicker";
            this.to_take_withDateTimePicker.Size = new System.Drawing.Size(316, 30);
            this.to_take_withDateTimePicker.TabIndex = 9;
            // 
            // service_numberTextBox
            // 
            this.service_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Service_number", true));
            this.service_numberTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_numberTextBox.Location = new System.Drawing.Point(390, 261);
            this.service_numberTextBox.Name = "service_numberTextBox";
            this.service_numberTextBox.Size = new System.Drawing.Size(316, 30);
            this.service_numberTextBox.TabIndex = 11;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "FIO", true));
            this.fIOTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIOTextBox.Location = new System.Drawing.Point(390, 315);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(316, 30);
            this.fIOTextBox.TabIndex = 13;
            // 
            // structural_divisionTextBox
            // 
            this.structural_divisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Structural_division", true));
            this.structural_divisionTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.structural_divisionTextBox.Location = new System.Drawing.Point(390, 360);
            this.structural_divisionTextBox.Name = "structural_divisionTextBox";
            this.structural_divisionTextBox.Size = new System.Drawing.Size(316, 30);
            this.structural_divisionTextBox.TabIndex = 15;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextBox.Location = new System.Drawing.Point(390, 407);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(316, 30);
            this.positionTextBox.TabIndex = 17;
            // 
            // nature_workTextBox
            // 
            this.nature_workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Nature_work", true));
            this.nature_workTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nature_workTextBox.Location = new System.Drawing.Point(390, 452);
            this.nature_workTextBox.Name = "nature_workTextBox";
            this.nature_workTextBox.Size = new System.Drawing.Size(316, 30);
            this.nature_workTextBox.TabIndex = 19;
            // 
            // with_tariff_rateTextBox
            // 
            this.with_tariff_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "With_tariff_rate", true));
            this.with_tariff_rateTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.with_tariff_rateTextBox.Location = new System.Drawing.Point(390, 497);
            this.with_tariff_rateTextBox.Name = "with_tariff_rateTextBox";
            this.with_tariff_rateTextBox.Size = new System.Drawing.Size(316, 30);
            this.with_tariff_rateTextBox.TabIndex = 21;
            // 
            // at_premiumTextBox
            // 
            this.at_premiumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "At_premium", true));
            this.at_premiumTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.at_premiumTextBox.Location = new System.Drawing.Point(390, 542);
            this.at_premiumTextBox.Name = "at_premiumTextBox";
            this.at_premiumTextBox.Size = new System.Drawing.Size(316, 30);
            this.at_premiumTextBox.TabIndex = 23;
            // 
            // with_trial_periodTextBox
            // 
            this.with_trial_periodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "With_trial_period", true));
            this.with_trial_periodTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.with_trial_periodTextBox.Location = new System.Drawing.Point(390, 587);
            this.with_trial_periodTextBox.Name = "with_trial_periodTextBox";
            this.with_trial_periodTextBox.Size = new System.Drawing.Size(316, 30);
            this.with_trial_periodTextBox.TabIndex = 25;
            // 
            // employment_contract_fromDateTimePicker
            // 
            this.employment_contract_fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_admissionBindingSource, "Employment_contract_from", true));
            this.employment_contract_fromDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employment_contract_fromDateTimePicker.Location = new System.Drawing.Point(390, 633);
            this.employment_contract_fromDateTimePicker.Name = "employment_contract_fromDateTimePicker";
            this.employment_contract_fromDateTimePicker.Size = new System.Drawing.Size(316, 30);
            this.employment_contract_fromDateTimePicker.TabIndex = 27;
            // 
            // contract_numberTextBox
            // 
            this.contract_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_admissionBindingSource, "Contract_number", true));
            this.contract_numberTextBox.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contract_numberTextBox.Location = new System.Drawing.Point(390, 678);
            this.contract_numberTextBox.Name = "contract_numberTextBox";
            this.contract_numberTextBox.Size = new System.Drawing.Size(316, 30);
            this.contract_numberTextBox.TabIndex = 29;
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
            this.order_admissionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.order_admissionBindingNavigator.Location = new System.Drawing.Point(729, 9);
            this.order_admissionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_admissionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_admissionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_admissionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_admissionBindingNavigator.Name = "order_admissionBindingNavigator";
            this.order_admissionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_admissionBindingNavigator.Size = new System.Drawing.Size(289, 37);
            this.order_admissionBindingNavigator.TabIndex = 1;
            this.order_admissionBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Times New Roman", 9.191489F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(67, 28);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Times New Roman", 9.191489F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 28);
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
            // order_admissionBindingNavigatorSaveItem
            // 
            this.order_admissionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order_admissionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order_admissionBindingNavigatorSaveItem.Image")));
            this.order_admissionBindingNavigatorSaveItem.Name = "order_admissionBindingNavigatorSaveItem";
            this.order_admissionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.order_admissionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.order_admissionBindingNavigatorSaveItem.Visible = false;
            this.order_admissionBindingNavigatorSaveItem.Click += new System.EventHandler(this.order_admissionBindingNavigatorSaveItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(1059, 427);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(218, 55);
            this.buttonAdd.TabIndex = 139;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(1059, 758);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(218, 55);
            this.buttonBack.TabIndex = 142;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(1059, 499);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(218, 55);
            this.buttonDelete.TabIndex = 143;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxpoisk
            // 
            this.textBoxpoisk.Location = new System.Drawing.Point(1059, 173);
            this.textBoxpoisk.Name = "textBoxpoisk";
            this.textBoxpoisk.Size = new System.Drawing.Size(218, 26);
            this.textBoxpoisk.TabIndex = 144;
            // 
            // buttonpoisk
            // 
            this.buttonpoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonpoisk.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonpoisk.ForeColor = System.Drawing.Color.Black;
            this.buttonpoisk.Location = new System.Drawing.Point(1059, 216);
            this.buttonpoisk.Name = "buttonpoisk";
            this.buttonpoisk.Size = new System.Drawing.Size(218, 55);
            this.buttonpoisk.TabIndex = 145;
            this.buttonpoisk.Text = "Поиск";
            this.buttonpoisk.UseVisualStyleBackColor = false;
            this.buttonpoisk.Click += new System.EventHandler(this.buttonpoisk_Click);
            // 
            // buttonfilter
            // 
            this.buttonfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonfilter.Font = new System.Drawing.Font("Times New Roman", 12.25532F);
            this.buttonfilter.ForeColor = System.Drawing.Color.Black;
            this.buttonfilter.Location = new System.Drawing.Point(1059, 277);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(218, 55);
            this.buttonfilter.TabIndex = 146;
            this.buttonfilter.Text = "Фильтр";
            this.buttonfilter.UseVisualStyleBackColor = false;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1094, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 147;
            this.label1.Text = "Для поиска ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(712, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 39);
            this.label2.TabIndex = 48;
            this.label2.Text = "(мес.)";
            // 
            // FormOrderAdmission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 1010);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.buttonpoisk);
            this.Controls.Add(this.textBoxpoisk);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.order_admissionBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "FormOrderAdmission1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приказ о приеме на работу";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrderAdmission1_FormClosed);
            this.Load += new System.EventHandler(this.FormOrderAdmission1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_admissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox iD_orderTextBox;
        private System.Windows.Forms.TextBox name_organizationTextBox;
        private System.Windows.Forms.TextBox document_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_compilationDateTimePicker;
        private System.Windows.Forms.DateTimePicker to_take_withDateTimePicker;
        private System.Windows.Forms.TextBox service_numberTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox structural_divisionTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox nature_workTextBox;
        private System.Windows.Forms.TextBox with_tariff_rateTextBox;
        private System.Windows.Forms.TextBox at_premiumTextBox;
        private System.Windows.Forms.TextBox with_trial_periodTextBox;
        private System.Windows.Forms.DateTimePicker employment_contract_fromDateTimePicker;
        private System.Windows.Forms.TextBox contract_numberTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxpoisk;
        private System.Windows.Forms.Button buttonpoisk;
        private System.Windows.Forms.Button buttonfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}