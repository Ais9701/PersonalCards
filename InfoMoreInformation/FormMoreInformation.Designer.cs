namespace Personal_cardsApp1
{
    partial class FormMoreInformation
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
            System.Windows.Forms.Label dismissalLabel;
            System.Windows.Forms.Label date_of_dismissalLabel;
            System.Windows.Forms.Label the_order_numberLabel;
            System.Windows.Forms.Label date_of_orderLabel;
            System.Windows.Forms.Label iD_additional_informationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoreInformation));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.more_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.more_informationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.More_informationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.more_informationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dismissalTextBox = new System.Windows.Forms.TextBox();
            this.date_of_dismissalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.the_order_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_of_orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.employee_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_informationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Employee_informationTableAdapter();
            this.iD_additional_informationTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.more_informationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            dismissalLabel = new System.Windows.Forms.Label();
            date_of_dismissalLabel = new System.Windows.Forms.Label();
            the_order_numberLabel = new System.Windows.Forms.Label();
            date_of_orderLabel = new System.Windows.Forms.Label();
            iD_additional_informationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingNavigator)).BeginInit();
            this.more_informationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_informationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dismissalLabel
            // 
            dismissalLabel.AutoSize = true;
            dismissalLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dismissalLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            dismissalLabel.Location = new System.Drawing.Point(78, 223);
            dismissalLabel.Name = "dismissalLabel";
            dismissalLabel.Size = new System.Drawing.Size(401, 100);
            dismissalLabel.TabIndex = 1;
            dismissalLabel.Text = "Основание прекращения\r\nтрудового договора:";
            dismissalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dismissalLabel.Click += new System.EventHandler(this.dismissalLabel_Click);
            // 
            // date_of_dismissalLabel
            // 
            date_of_dismissalLabel.AutoSize = true;
            date_of_dismissalLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_dismissalLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_of_dismissalLabel.Location = new System.Drawing.Point(78, 324);
            date_of_dismissalLabel.Name = "date_of_dismissalLabel";
            date_of_dismissalLabel.Size = new System.Drawing.Size(290, 50);
            date_of_dismissalLabel.TabIndex = 3;
            date_of_dismissalLabel.Text = "Дата увольнения:";
            date_of_dismissalLabel.Click += new System.EventHandler(this.date_of_dismissalLabel_Click);
            // 
            // the_order_numberLabel
            // 
            the_order_numberLabel.AutoSize = true;
            the_order_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            the_order_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            the_order_numberLabel.Location = new System.Drawing.Point(78, 391);
            the_order_numberLabel.Name = "the_order_numberLabel";
            the_order_numberLabel.Size = new System.Drawing.Size(261, 50);
            the_order_numberLabel.TabIndex = 5;
            the_order_numberLabel.Text = "Номер приказа:";
            the_order_numberLabel.Click += new System.EventHandler(this.the_order_numberLabel_Click);
            // 
            // date_of_orderLabel
            // 
            date_of_orderLabel.AutoSize = true;
            date_of_orderLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_orderLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_of_orderLabel.Location = new System.Drawing.Point(78, 455);
            date_of_orderLabel.Name = "date_of_orderLabel";
            date_of_orderLabel.Size = new System.Drawing.Size(234, 50);
            date_of_orderLabel.TabIndex = 7;
            date_of_orderLabel.Text = "Дата приказа:";
            date_of_orderLabel.Click += new System.EventHandler(this.date_of_orderLabel_Click);
            // 
            // iD_additional_informationLabel
            // 
            iD_additional_informationLabel.AutoSize = true;
            iD_additional_informationLabel.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_additional_informationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_additional_informationLabel.Location = new System.Drawing.Point(78, 158);
            iD_additional_informationLabel.Name = "iD_additional_informationLabel";
            iD_additional_informationLabel.Size = new System.Drawing.Size(280, 50);
            iD_additional_informationLabel.TabIndex = 12;
            iD_additional_informationLabel.Text = "ID доп.сведений:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // more_informationBindingSource
            // 
            this.more_informationBindingSource.DataMember = "More_information";
            this.more_informationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // more_informationTableAdapter
            // 
            this.more_informationTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.More_informationTableAdapter = this.more_informationTableAdapter;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // more_informationBindingNavigator
            // 
            this.more_informationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.more_informationBindingNavigator.BindingSource = this.more_informationBindingSource;
            this.more_informationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.more_informationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.more_informationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.more_informationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.more_informationBindingNavigatorSaveItem});
            this.more_informationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.more_informationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.more_informationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.more_informationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.more_informationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.more_informationBindingNavigator.Name = "more_informationBindingNavigator";
            this.more_informationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.more_informationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.more_informationBindingNavigator.TabIndex = 0;
            this.more_informationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // dismissalTextBox
            // 
            this.dismissalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.more_informationBindingSource, "Dismissal", true));
            this.dismissalTextBox.Location = new System.Drawing.Point(511, 269);
            this.dismissalTextBox.Name = "dismissalTextBox";
            this.dismissalTextBox.Size = new System.Drawing.Size(290, 26);
            this.dismissalTextBox.TabIndex = 2;
            // 
            // date_of_dismissalDateTimePicker
            // 
            this.date_of_dismissalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.more_informationBindingSource, "Date_of_dismissal", true));
            this.date_of_dismissalDateTimePicker.Location = new System.Drawing.Point(405, 343);
            this.date_of_dismissalDateTimePicker.Name = "date_of_dismissalDateTimePicker";
            this.date_of_dismissalDateTimePicker.Size = new System.Drawing.Size(175, 26);
            this.date_of_dismissalDateTimePicker.TabIndex = 4;
            // 
            // the_order_numberTextBox
            // 
            this.the_order_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.more_informationBindingSource, "The_order_number", true));
            this.the_order_numberTextBox.Location = new System.Drawing.Point(376, 412);
            this.the_order_numberTextBox.Name = "the_order_numberTextBox";
            this.the_order_numberTextBox.Size = new System.Drawing.Size(190, 26);
            this.the_order_numberTextBox.TabIndex = 6;
            // 
            // date_of_orderDateTimePicker
            // 
            this.date_of_orderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.more_informationBindingSource, "Date_of_order", true));
            this.date_of_orderDateTimePicker.Location = new System.Drawing.Point(343, 474);
            this.date_of_orderDateTimePicker.Name = "date_of_orderDateTimePicker";
            this.date_of_orderDateTimePicker.Size = new System.Drawing.Size(175, 26);
            this.date_of_orderDateTimePicker.TabIndex = 8;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd2.Location = new System.Drawing.Point(962, 324);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd2.TabIndex = 9;
            this.buttonAdd2.Text = "Добавить";
            this.buttonAdd2.UseVisualStyleBackColor = false;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(962, 434);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal2.TabIndex = 10;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(962, 489);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(131, 49);
            this.buttonBack2.TabIndex = 11;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // employee_informationBindingSource
            // 
            this.employee_informationBindingSource.DataMember = "Employee_information";
            this.employee_informationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // employee_informationTableAdapter
            // 
            this.employee_informationTableAdapter.ClearBeforeFill = true;
            // 
            // iD_additional_informationTextBox
            // 
            this.iD_additional_informationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.more_informationBindingSource, "ID_additional_information", true));
            this.iD_additional_informationTextBox.Location = new System.Drawing.Point(376, 179);
            this.iD_additional_informationTextBox.Name = "iD_additional_informationTextBox";
            this.iD_additional_informationTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_additional_informationTextBox.TabIndex = 13;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(962, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 49);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
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
            // more_informationBindingNavigatorSaveItem
            // 
            this.more_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.more_informationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("more_informationBindingNavigatorSaveItem.Image")));
            this.more_informationBindingNavigatorSaveItem.Name = "more_informationBindingNavigatorSaveItem";
            this.more_informationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.more_informationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.more_informationBindingNavigatorSaveItem.Visible = false;
            this.more_informationBindingNavigatorSaveItem.Click += new System.EventHandler(this.more_informationBindingNavigatorSaveItem_Click);
            // 
            // FormMoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(iD_additional_informationLabel);
            this.Controls.Add(this.iD_additional_informationTextBox);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(date_of_orderLabel);
            this.Controls.Add(this.date_of_orderDateTimePicker);
            this.Controls.Add(the_order_numberLabel);
            this.Controls.Add(this.the_order_numberTextBox);
            this.Controls.Add(date_of_dismissalLabel);
            this.Controls.Add(this.date_of_dismissalDateTimePicker);
            this.Controls.Add(dismissalLabel);
            this.Controls.Add(this.dismissalTextBox);
            this.Controls.Add(this.more_informationBindingNavigator);
            this.Name = "FormMoreInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительные сведения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMoreInformation_FormClosed);
            this.Load += new System.EventHandler(this.FormMoreInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingNavigator)).EndInit();
            this.more_informationBindingNavigator.ResumeLayout(false);
            this.more_informationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_informationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource more_informationBindingSource;
        private Personal_cardsDataSetTableAdapters.More_informationTableAdapter more_informationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator more_informationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton more_informationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dismissalTextBox;
        private System.Windows.Forms.DateTimePicker date_of_dismissalDateTimePicker;
        private System.Windows.Forms.TextBox the_order_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_of_orderDateTimePicker;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.BindingSource employee_informationBindingSource;
        private Personal_cardsDataSetTableAdapters.Employee_informationTableAdapter employee_informationTableAdapter;
        private System.Windows.Forms.TextBox iD_additional_informationTextBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}