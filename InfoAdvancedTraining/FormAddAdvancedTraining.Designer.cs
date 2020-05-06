namespace Personal_cardsApp1
{
    partial class FormAddAdvancedTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAdvancedTraining));
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
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ID_qualificationTextBox = new System.Windows.Forms.TextBox();
            this.Type_of_qualificationTextBox = new System.Windows.Forms.TextBox();
            this.Name_of_educational_institutionTextBox = new System.Windows.Forms.TextBox();
            this.Its_locationTextBox = new System.Windows.Forms.TextBox();
            this.Document_nameTextBox = new System.Windows.Forms.TextBox();
            this.Series_document_numberTextBox = new System.Windows.Forms.TextBox();
            this.Beginning_of_trainingTextBox = new System.Windows.Forms.TextBox();
            this.The_end_of_the_trainingTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingNavigator)).BeginInit();
            this.advanced_trainingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.Granting_leaveTableAdapter = null;
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
            this.advanced_trainingBindingNavigator.Size = new System.Drawing.Size(1357, 32);
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
            // buttonBack2
            // 
            this.buttonBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(1064, 525);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(128, 48);
            this.buttonBack2.TabIndex = 4;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID квалификации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(67, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начало обучения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(67, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "Конец обучения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(67, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 57);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вид повышения квалификации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(67, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(812, 57);
            this.label5.TabIndex = 9;
            this.label5.Text = "Наименование образовательного учреждения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(67, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 57);
            this.label6.TabIndex = 10;
            this.label6.Text = "Место его нахождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(67, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(475, 57);
            this.label7.TabIndex = 11;
            this.label7.Text = "Наименование документа:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label8.Location = new System.Drawing.Point(67, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(470, 57);
            this.label8.TabIndex = 12;
            this.label8.Text = "Серия и номер документа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label9.Location = new System.Drawing.Point(67, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 57);
            this.label9.TabIndex = 13;
            this.label9.Text = "Дата:";
            // 
            // ID_qualificationTextBox
            // 
            this.ID_qualificationTextBox.Location = new System.Drawing.Point(442, 89);
            this.ID_qualificationTextBox.Name = "ID_qualificationTextBox";
            this.ID_qualificationTextBox.Size = new System.Drawing.Size(100, 26);
            this.ID_qualificationTextBox.TabIndex = 14;
            // 
            // Type_of_qualificationTextBox
            // 
            this.Type_of_qualificationTextBox.Location = new System.Drawing.Point(659, 283);
            this.Type_of_qualificationTextBox.Name = "Type_of_qualificationTextBox";
            this.Type_of_qualificationTextBox.Size = new System.Drawing.Size(420, 26);
            this.Type_of_qualificationTextBox.TabIndex = 15;
            // 
            // Name_of_educational_institutionTextBox
            // 
            this.Name_of_educational_institutionTextBox.Location = new System.Drawing.Point(896, 340);
            this.Name_of_educational_institutionTextBox.Name = "Name_of_educational_institutionTextBox";
            this.Name_of_educational_institutionTextBox.Size = new System.Drawing.Size(338, 26);
            this.Name_of_educational_institutionTextBox.TabIndex = 16;
            // 
            // Its_locationTextBox
            // 
            this.Its_locationTextBox.Location = new System.Drawing.Point(487, 394);
            this.Its_locationTextBox.Name = "Its_locationTextBox";
            this.Its_locationTextBox.Size = new System.Drawing.Size(376, 26);
            this.Its_locationTextBox.TabIndex = 17;
            // 
            // Document_nameTextBox
            // 
            this.Document_nameTextBox.Location = new System.Drawing.Point(566, 454);
            this.Document_nameTextBox.Name = "Document_nameTextBox";
            this.Document_nameTextBox.Size = new System.Drawing.Size(193, 26);
            this.Document_nameTextBox.TabIndex = 18;
            // 
            // Series_document_numberTextBox
            // 
            this.Series_document_numberTextBox.Location = new System.Drawing.Point(566, 511);
            this.Series_document_numberTextBox.Name = "Series_document_numberTextBox";
            this.Series_document_numberTextBox.Size = new System.Drawing.Size(193, 26);
            this.Series_document_numberTextBox.TabIndex = 19;
            // 
            // Beginning_of_trainingTextBox
            // 
            this.Beginning_of_trainingTextBox.Location = new System.Drawing.Point(442, 160);
            this.Beginning_of_trainingTextBox.Name = "Beginning_of_trainingTextBox";
            this.Beginning_of_trainingTextBox.Size = new System.Drawing.Size(201, 26);
            this.Beginning_of_trainingTextBox.TabIndex = 20;
            // 
            // The_end_of_the_trainingTextBox
            // 
            this.The_end_of_the_trainingTextBox.Location = new System.Drawing.Point(442, 217);
            this.The_end_of_the_trainingTextBox.Name = "The_end_of_the_trainingTextBox";
            this.The_end_of_the_trainingTextBox.Size = new System.Drawing.Size(201, 26);
            this.The_end_of_the_trainingTextBox.TabIndex = 21;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(204, 568);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(179, 26);
            this.DateTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1064, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1064, 448);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(128, 49);
            this.buttonSeal2.TabIndex = 24;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(73, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(598, 20);
            this.label16.TabIndex = 104;
            this.label16.Text = "Перед введении ID сотрудника проверьте правильность нумерации!";
            // 
            // FormAddAdvancedTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.The_end_of_the_trainingTextBox);
            this.Controls.Add(this.Beginning_of_trainingTextBox);
            this.Controls.Add(this.Series_document_numberTextBox);
            this.Controls.Add(this.Document_nameTextBox);
            this.Controls.Add(this.Its_locationTextBox);
            this.Controls.Add(this.Name_of_educational_institutionTextBox);
            this.Controls.Add(this.Type_of_qualificationTextBox);
            this.Controls.Add(this.ID_qualificationTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.advanced_trainingBindingNavigator);
            this.Name = "FormAddAdvancedTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление квалификации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddAdvancedTraining_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddAdvancedTraining_FormClosed);
            this.Load += new System.EventHandler(this.FormAddAdvancedTraining_Load);
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
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID_qualificationTextBox;
        private System.Windows.Forms.TextBox Type_of_qualificationTextBox;
        private System.Windows.Forms.TextBox Name_of_educational_institutionTextBox;
        private System.Windows.Forms.TextBox Its_locationTextBox;
        private System.Windows.Forms.TextBox Document_nameTextBox;
        private System.Windows.Forms.TextBox Series_document_numberTextBox;
        private System.Windows.Forms.TextBox Beginning_of_trainingTextBox;
        private System.Windows.Forms.TextBox The_end_of_the_trainingTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label16;
    }
}