namespace Personal_cardsApp1
{
    partial class FormAddEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEducation));
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
            this.buttonBack7 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iD_educationTextBox = new System.Windows.Forms.TextBox();
            this.level_of_educationTextBox = new System.Windows.Forms.TextBox();
            this.name_of_educational_institutionTextBox = new System.Windows.Forms.TextBox();
            this.name_of_the_document_on_educationTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.year_of_graduationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingNavigator)).BeginInit();
            this.educationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.educationBindingNavigator.Size = new System.Drawing.Size(1357, 37);
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
            // buttonBack7
            // 
            this.buttonBack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack7.Location = new System.Drawing.Point(1144, 430);
            this.buttonBack7.Name = "buttonBack7";
            this.buttonBack7.Size = new System.Drawing.Size(137, 54);
            this.buttonBack7.TabIndex = 7;
            this.buttonBack7.Text = "Назад";
            this.buttonBack7.UseVisualStyleBackColor = false;
            this.buttonBack7.Click += new System.EventHandler(this.buttonBack7_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(1144, 280);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 55);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(38, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(38, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 50);
            this.label2.TabIndex = 23;
            this.label2.Text = "Уровень образования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(38, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 100);
            this.label3.TabIndex = 24;
            this.label3.Text = "Наименование \r\nобразовательного учреждения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(38, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 50);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата выдачи:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(38, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 50);
            this.label5.TabIndex = 26;
            this.label5.Text = "Серия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(38, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 50);
            this.label6.TabIndex = 27;
            this.label6.Text = "Наименование документа:";
            // 
            // iD_educationTextBox
            // 
            this.iD_educationTextBox.Location = new System.Drawing.Point(310, 139);
            this.iD_educationTextBox.Name = "iD_educationTextBox";
            this.iD_educationTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_educationTextBox.TabIndex = 28;
            // 
            // level_of_educationTextBox
            // 
            this.level_of_educationTextBox.Location = new System.Drawing.Point(455, 210);
            this.level_of_educationTextBox.Name = "level_of_educationTextBox";
            this.level_of_educationTextBox.Size = new System.Drawing.Size(381, 26);
            this.level_of_educationTextBox.TabIndex = 29;
            // 
            // name_of_educational_institutionTextBox
            // 
            this.name_of_educational_institutionTextBox.Location = new System.Drawing.Point(563, 313);
            this.name_of_educational_institutionTextBox.Name = "name_of_educational_institutionTextBox";
            this.name_of_educational_institutionTextBox.Size = new System.Drawing.Size(509, 26);
            this.name_of_educational_institutionTextBox.TabIndex = 30;
            // 
            // name_of_the_document_on_educationTextBox
            // 
            this.name_of_the_document_on_educationTextBox.Location = new System.Drawing.Point(489, 387);
            this.name_of_the_document_on_educationTextBox.Name = "name_of_the_document_on_educationTextBox";
            this.name_of_the_document_on_educationTextBox.Size = new System.Drawing.Size(183, 26);
            this.name_of_the_document_on_educationTextBox.TabIndex = 31;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(213, 452);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(148, 26);
            this.seriesTextBox.TabIndex = 32;
            // 
            // year_of_graduationDateTimePicker
            // 
            this.year_of_graduationDateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_of_graduationDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_of_graduationDateTimePicker.Location = new System.Drawing.Point(298, 557);
            this.year_of_graduationDateTimePicker.Name = "year_of_graduationDateTimePicker";
            this.year_of_graduationDateTimePicker.Size = new System.Drawing.Size(199, 30);
            this.year_of_graduationDateTimePicker.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(38, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 50);
            this.label7.TabIndex = 34;
            this.label7.Text = "Номер:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(213, 502);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(148, 26);
            this.numberTextBox.TabIndex = 35;
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1144, 343);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(137, 55);
            this.buttonSeal2.TabIndex = 36;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAddEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.year_of_graduationDateTimePicker);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.name_of_the_document_on_educationTextBox);
            this.Controls.Add(this.name_of_educational_institutionTextBox);
            this.Controls.Add(this.level_of_educationTextBox);
            this.Controls.Add(this.iD_educationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack7);
            this.Controls.Add(this.educationBindingNavigator);
            this.Name = "FormAddEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление образования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddEducation_FormClosed);
            this.Load += new System.EventHandler(this.FormAddEducation_Load);
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
        private System.Windows.Forms.Button buttonBack7;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iD_educationTextBox;
        private System.Windows.Forms.TextBox level_of_educationTextBox;
        private System.Windows.Forms.TextBox name_of_educational_institutionTextBox;
        private System.Windows.Forms.TextBox name_of_the_document_on_educationTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.DateTimePicker year_of_graduationDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}