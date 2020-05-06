namespace Personal_cardsApp1
{
    partial class FormAddSocialBenefits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSocialBenefits));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.social_benefitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.social_benefitsTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Social_benefitsTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.social_benefitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.social_benefitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_social_benefitsTextBox = new System.Windows.Forms.TextBox();
            this.Name_of_benefitTextBox = new System.Windows.Forms.TextBox();
            this.Document_numberTextBox = new System.Windows.Forms.TextBox();
            this.Date_of_issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingNavigator)).BeginInit();
            this.social_benefitsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // social_benefitsBindingSource
            // 
            this.social_benefitsBindingSource.DataMember = "Social_benefits";
            this.social_benefitsBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // social_benefitsTableAdapter
            // 
            this.social_benefitsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Order_admissionTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = this.social_benefitsTableAdapter;
            this.tableAdapterManager.Staff_listTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // social_benefitsBindingNavigator
            // 
            this.social_benefitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.social_benefitsBindingNavigator.BindingSource = this.social_benefitsBindingSource;
            this.social_benefitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.social_benefitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.social_benefitsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.social_benefitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.social_benefitsBindingNavigatorSaveItem});
            this.social_benefitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.social_benefitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.social_benefitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.social_benefitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.social_benefitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.social_benefitsBindingNavigator.Name = "social_benefitsBindingNavigator";
            this.social_benefitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.social_benefitsBindingNavigator.Size = new System.Drawing.Size(1357, 32);
            this.social_benefitsBindingNavigator.TabIndex = 0;
            this.social_benefitsBindingNavigator.Text = "bindingNavigator1";
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
            // social_benefitsBindingNavigatorSaveItem
            // 
            this.social_benefitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.social_benefitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("social_benefitsBindingNavigatorSaveItem.Image")));
            this.social_benefitsBindingNavigatorSaveItem.Name = "social_benefitsBindingNavigatorSaveItem";
            this.social_benefitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.social_benefitsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.social_benefitsBindingNavigatorSaveItem.Visible = false;
            this.social_benefitsBindingNavigatorSaveItem.Click += new System.EventHandler(this.social_benefitsBindingNavigatorSaveItem_Click);
            // 
            // buttonBack3
            // 
            this.buttonBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack3.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack3.Location = new System.Drawing.Point(1091, 450);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(134, 55);
            this.buttonBack3.TabIndex = 3;
            this.buttonBack3.Text = "Назад";
            this.buttonBack3.UseVisualStyleBackColor = false;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1091, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(242, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID соц.льгот:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(242, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование льготы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(242, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер документа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(242, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 57);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата выдачи:";
            // 
            // ID_social_benefitsTextBox
            // 
            this.ID_social_benefitsTextBox.Location = new System.Drawing.Point(498, 242);
            this.ID_social_benefitsTextBox.Name = "ID_social_benefitsTextBox";
            this.ID_social_benefitsTextBox.Size = new System.Drawing.Size(77, 26);
            this.ID_social_benefitsTextBox.TabIndex = 9;
            // 
            // Name_of_benefitTextBox
            // 
            this.Name_of_benefitTextBox.Location = new System.Drawing.Point(675, 299);
            this.Name_of_benefitTextBox.Name = "Name_of_benefitTextBox";
            this.Name_of_benefitTextBox.Size = new System.Drawing.Size(264, 26);
            this.Name_of_benefitTextBox.TabIndex = 10;
            // 
            // Document_numberTextBox
            // 
            this.Document_numberTextBox.Location = new System.Drawing.Point(598, 356);
            this.Document_numberTextBox.Name = "Document_numberTextBox";
            this.Document_numberTextBox.Size = new System.Drawing.Size(109, 26);
            this.Document_numberTextBox.TabIndex = 11;
            // 
            // Date_of_issueDateTimePicker
            // 
            this.Date_of_issueDateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_of_issueDateTimePicker.Location = new System.Drawing.Point(533, 411);
            this.Date_of_issueDateTimePicker.Name = "Date_of_issueDateTimePicker";
            this.Date_of_issueDateTimePicker.Size = new System.Drawing.Size(174, 26);
            this.Date_of_issueDateTimePicker.TabIndex = 12;
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1091, 303);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(134, 55);
            this.buttonSeal2.TabIndex = 13;
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
            this.label16.Location = new System.Drawing.Point(248, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(598, 20);
            this.label16.TabIndex = 104;
            this.label16.Text = "Перед введении ID сотрудника проверьте правильность нумерации!";
            // 
            // FormAddSocialBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.Date_of_issueDateTimePicker);
            this.Controls.Add(this.Document_numberTextBox);
            this.Controls.Add(this.Name_of_benefitTextBox);
            this.Controls.Add(this.ID_social_benefitsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(this.social_benefitsBindingNavigator);
            this.Name = "FormAddSocialBenefits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление социальных льгот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddSocialBenefits_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddSocialBenefits_FormClosed);
            this.Load += new System.EventHandler(this.FormAddSocialBenefits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingNavigator)).EndInit();
            this.social_benefitsBindingNavigator.ResumeLayout(false);
            this.social_benefitsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource social_benefitsBindingSource;
        private Personal_cardsDataSetTableAdapters.Social_benefitsTableAdapter social_benefitsTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator social_benefitsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton social_benefitsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_social_benefitsTextBox;
        private System.Windows.Forms.TextBox Name_of_benefitTextBox;
        private System.Windows.Forms.TextBox Document_numberTextBox;
        private System.Windows.Forms.DateTimePicker Date_of_issueDateTimePicker;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label16;
    }
}