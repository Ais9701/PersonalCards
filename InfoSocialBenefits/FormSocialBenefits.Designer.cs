namespace Personal_cardsApp1
{
    partial class FormSocialBenefits
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
            System.Windows.Forms.Label name_of_benefitLabel;
            System.Windows.Forms.Label document_numberLabel;
            System.Windows.Forms.Label date_of_issueLabel;
            System.Windows.Forms.Label iD_social_benefitsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSocialBenefits));
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
            this.name_of_benefitTextBox = new System.Windows.Forms.TextBox();
            this.document_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_of_issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.buttonAdd3 = new System.Windows.Forms.Button();
            this.buttonSeal3 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ID_social_benefitsTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            name_of_benefitLabel = new System.Windows.Forms.Label();
            document_numberLabel = new System.Windows.Forms.Label();
            date_of_issueLabel = new System.Windows.Forms.Label();
            iD_social_benefitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_benefitsBindingNavigator)).BeginInit();
            this.social_benefitsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_of_benefitLabel
            // 
            name_of_benefitLabel.AutoSize = true;
            name_of_benefitLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_benefitLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            name_of_benefitLabel.Location = new System.Drawing.Point(103, 216);
            name_of_benefitLabel.Name = "name_of_benefitLabel";
            name_of_benefitLabel.Size = new System.Drawing.Size(415, 57);
            name_of_benefitLabel.TabIndex = 1;
            name_of_benefitLabel.Text = "Наименование льготы:";
            // 
            // document_numberLabel
            // 
            document_numberLabel.AutoSize = true;
            document_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            document_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            document_numberLabel.Location = new System.Drawing.Point(102, 292);
            document_numberLabel.Name = "document_numberLabel";
            document_numberLabel.Size = new System.Drawing.Size(333, 57);
            document_numberLabel.TabIndex = 3;
            document_numberLabel.Text = "Номер документа:";
            // 
            // date_of_issueLabel
            // 
            date_of_issueLabel.AutoSize = true;
            date_of_issueLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_issueLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_of_issueLabel.Location = new System.Drawing.Point(103, 374);
            date_of_issueLabel.Name = "date_of_issueLabel";
            date_of_issueLabel.Size = new System.Drawing.Size(255, 57);
            date_of_issueLabel.TabIndex = 5;
            date_of_issueLabel.Text = "Дата выдачи:";
            // 
            // iD_social_benefitsLabel
            // 
            iD_social_benefitsLabel.AutoSize = true;
            iD_social_benefitsLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_social_benefitsLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_social_benefitsLabel.Location = new System.Drawing.Point(103, 159);
            iD_social_benefitsLabel.Name = "iD_social_benefitsLabel";
            iD_social_benefitsLabel.Size = new System.Drawing.Size(215, 50);
            iD_social_benefitsLabel.TabIndex = 15;
            iD_social_benefitsLabel.Text = "ID соц.льгот:";
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
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = this.social_benefitsTableAdapter;
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
            this.social_benefitsBindingNavigator.Size = new System.Drawing.Size(1290, 32);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
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
            // name_of_benefitTextBox
            // 
            this.name_of_benefitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.social_benefitsBindingSource, "Name_of_benefit", true));
            this.name_of_benefitTextBox.Location = new System.Drawing.Point(524, 242);
            this.name_of_benefitTextBox.Name = "name_of_benefitTextBox";
            this.name_of_benefitTextBox.Size = new System.Drawing.Size(177, 26);
            this.name_of_benefitTextBox.TabIndex = 2;
            // 
            // document_numberTextBox
            // 
            this.document_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.social_benefitsBindingSource, "Document_number", true));
            this.document_numberTextBox.Location = new System.Drawing.Point(452, 318);
            this.document_numberTextBox.Name = "document_numberTextBox";
            this.document_numberTextBox.Size = new System.Drawing.Size(177, 26);
            this.document_numberTextBox.TabIndex = 4;
            // 
            // date_of_issueDateTimePicker
            // 
            this.date_of_issueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.social_benefitsBindingSource, "Date_of_issue", true));
            this.date_of_issueDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.191489F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_of_issueDateTimePicker.Location = new System.Drawing.Point(383, 397);
            this.date_of_issueDateTimePicker.Name = "date_of_issueDateTimePicker";
            this.date_of_issueDateTimePicker.Size = new System.Drawing.Size(177, 28);
            this.date_of_issueDateTimePicker.TabIndex = 6;
            // 
            // buttonBack3
            // 
            this.buttonBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack3.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack3.Location = new System.Drawing.Point(929, 442);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(131, 49);
            this.buttonBack3.TabIndex = 12;
            this.buttonBack3.Text = "Назад";
            this.buttonBack3.UseVisualStyleBackColor = false;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // buttonAdd3
            // 
            this.buttonAdd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd3.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd3.Location = new System.Drawing.Point(929, 274);
            this.buttonAdd3.Name = "buttonAdd3";
            this.buttonAdd3.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd3.TabIndex = 13;
            this.buttonAdd3.Text = "Добавить";
            this.buttonAdd3.UseVisualStyleBackColor = false;
            this.buttonAdd3.Click += new System.EventHandler(this.buttonAdd3_Click);
            // 
            // buttonSeal3
            // 
            this.buttonSeal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal3.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal3.Location = new System.Drawing.Point(929, 387);
            this.buttonSeal3.Name = "buttonSeal3";
            this.buttonSeal3.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal3.TabIndex = 14;
            this.buttonSeal3.Text = "Печать";
            this.buttonSeal3.UseVisualStyleBackColor = false;
            this.buttonSeal3.Click += new System.EventHandler(this.buttonSeal3_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(929, 329);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 49);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ID_social_benefitsTextBox
            // 
            this.ID_social_benefitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.social_benefitsBindingSource, "ID_social_benefits", true));
            this.ID_social_benefitsTextBox.Location = new System.Drawing.Point(335, 180);
            this.ID_social_benefitsTextBox.Name = "ID_social_benefitsTextBox";
            this.ID_social_benefitsTextBox.Size = new System.Drawing.Size(86, 26);
            this.ID_social_benefitsTextBox.TabIndex = 16;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormSocialBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(iD_social_benefitsLabel);
            this.Controls.Add(this.ID_social_benefitsTextBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSeal3);
            this.Controls.Add(this.buttonAdd3);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(date_of_issueLabel);
            this.Controls.Add(this.date_of_issueDateTimePicker);
            this.Controls.Add(document_numberLabel);
            this.Controls.Add(this.document_numberTextBox);
            this.Controls.Add(name_of_benefitLabel);
            this.Controls.Add(this.name_of_benefitTextBox);
            this.Controls.Add(this.social_benefitsBindingNavigator);
            this.Name = "FormSocialBenefits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Социальные льготы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSocialBenefits_FormClosed);
            this.Load += new System.EventHandler(this.FormSocialBenefits_Load);
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
        private System.Windows.Forms.TextBox name_of_benefitTextBox;
        private System.Windows.Forms.TextBox document_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_of_issueDateTimePicker;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button buttonAdd3;
        private System.Windows.Forms.Button buttonSeal3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox ID_social_benefitsTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}