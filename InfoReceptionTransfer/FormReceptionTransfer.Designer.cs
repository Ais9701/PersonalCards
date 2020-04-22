namespace Personal_cardsApp1
{
    partial class FormReceptionTransfer
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label structural_subdivisionLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label tariff_rateLabel;
            System.Windows.Forms.Label iD_of_reception_and_transfer_to_workLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceptionTransfer));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.reception_and_transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reception_and_transferTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Reception_and_transferTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.reception_and_transferBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.reception_and_transferBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.structural_subdivisionTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.tariff_rateTextBox = new System.Windows.Forms.TextBox();
            this.buttonSeal4 = new System.Windows.Forms.Button();
            this.buttonAdd4 = new System.Windows.Forms.Button();
            this.buttonBack4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ID_of_reception_and_transfer_to_workTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            dateLabel = new System.Windows.Forms.Label();
            structural_subdivisionLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            tariff_rateLabel = new System.Windows.Forms.Label();
            iD_of_reception_and_transfer_to_workLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingNavigator)).BeginInit();
            this.reception_and_transferBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            dateLabel.Location = new System.Drawing.Point(168, 224);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(116, 57);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата:";
            // 
            // structural_subdivisionLabel
            // 
            structural_subdivisionLabel.AutoSize = true;
            structural_subdivisionLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            structural_subdivisionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            structural_subdivisionLabel.Location = new System.Drawing.Point(168, 295);
            structural_subdivisionLabel.Name = "structural_subdivisionLabel";
            structural_subdivisionLabel.Size = new System.Drawing.Size(510, 57);
            structural_subdivisionLabel.TabIndex = 3;
            structural_subdivisionLabel.Text = "Структурное подразделение:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            positionLabel.Location = new System.Drawing.Point(168, 364);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(222, 57);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Должность:";
            // 
            // tariff_rateLabel
            // 
            tariff_rateLabel.AutoSize = true;
            tariff_rateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tariff_rateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            tariff_rateLabel.Location = new System.Drawing.Point(168, 430);
            tariff_rateLabel.Name = "tariff_rateLabel";
            tariff_rateLabel.Size = new System.Drawing.Size(320, 57);
            tariff_rateLabel.TabIndex = 7;
            tariff_rateLabel.Text = "Тарифная ставка:";
            // 
            // iD_of_reception_and_transfer_to_workLabel
            // 
            iD_of_reception_and_transfer_to_workLabel.AutoSize = true;
            iD_of_reception_and_transfer_to_workLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_of_reception_and_transfer_to_workLabel.Location = new System.Drawing.Point(168, 162);
            iD_of_reception_and_transfer_to_workLabel.Name = "iD_of_reception_and_transfer_to_workLabel";
            iD_of_reception_and_transfer_to_workLabel.Size = new System.Drawing.Size(402, 57);
            iD_of_reception_and_transfer_to_workLabel.TabIndex = 18;
            iD_of_reception_and_transfer_to_workLabel.Text = "ID приема и перевода:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reception_and_transferBindingSource
            // 
            this.reception_and_transferBindingSource.DataMember = "Reception_and_transfer";
            this.reception_and_transferBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // reception_and_transferTableAdapter
            // 
            this.reception_and_transferTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Reception_and_transferTableAdapter = this.reception_and_transferTableAdapter;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // reception_and_transferBindingNavigator
            // 
            this.reception_and_transferBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reception_and_transferBindingNavigator.BindingSource = this.reception_and_transferBindingSource;
            this.reception_and_transferBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reception_and_transferBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reception_and_transferBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.reception_and_transferBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reception_and_transferBindingNavigatorSaveItem});
            this.reception_and_transferBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reception_and_transferBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reception_and_transferBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reception_and_transferBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reception_and_transferBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reception_and_transferBindingNavigator.Name = "reception_and_transferBindingNavigator";
            this.reception_and_transferBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reception_and_transferBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.reception_and_transferBindingNavigator.TabIndex = 0;
            this.reception_and_transferBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black;
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
            // reception_and_transferBindingNavigatorSaveItem
            // 
            this.reception_and_transferBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reception_and_transferBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reception_and_transferBindingNavigatorSaveItem.Image")));
            this.reception_and_transferBindingNavigatorSaveItem.Name = "reception_and_transferBindingNavigatorSaveItem";
            this.reception_and_transferBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.reception_and_transferBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.reception_and_transferBindingNavigatorSaveItem.Visible = false;
            this.reception_and_transferBindingNavigatorSaveItem.Click += new System.EventHandler(this.reception_and_transferBindingNavigatorSaveItem_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reception_and_transferBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(313, 248);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(175, 26);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // structural_subdivisionTextBox
            // 
            this.structural_subdivisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reception_and_transferBindingSource, "Structural_subdivision", true));
            this.structural_subdivisionTextBox.Location = new System.Drawing.Point(706, 319);
            this.structural_subdivisionTextBox.Name = "structural_subdivisionTextBox";
            this.structural_subdivisionTextBox.Size = new System.Drawing.Size(275, 26);
            this.structural_subdivisionTextBox.TabIndex = 4;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reception_and_transferBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(420, 388);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(258, 26);
            this.positionTextBox.TabIndex = 6;
            // 
            // tariff_rateTextBox
            // 
            this.tariff_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reception_and_transferBindingSource, "Tariff_rate", true));
            this.tariff_rateTextBox.Location = new System.Drawing.Point(508, 452);
            this.tariff_rateTextBox.Name = "tariff_rateTextBox";
            this.tariff_rateTextBox.Size = new System.Drawing.Size(170, 26);
            this.tariff_rateTextBox.TabIndex = 8;
            // 
            // buttonSeal4
            // 
            this.buttonSeal4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal4.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal4.ForeColor = System.Drawing.Color.Black;
            this.buttonSeal4.Location = new System.Drawing.Point(1084, 429);
            this.buttonSeal4.Name = "buttonSeal4";
            this.buttonSeal4.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal4.TabIndex = 17;
            this.buttonSeal4.Text = "Печать";
            this.buttonSeal4.UseVisualStyleBackColor = false;
            this.buttonSeal4.Click += new System.EventHandler(this.buttonSeal4_Click);
            // 
            // buttonAdd4
            // 
            this.buttonAdd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd4.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd4.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd4.Location = new System.Drawing.Point(1084, 306);
            this.buttonAdd4.Name = "buttonAdd4";
            this.buttonAdd4.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd4.TabIndex = 16;
            this.buttonAdd4.Text = "Добавить";
            this.buttonAdd4.UseVisualStyleBackColor = false;
            this.buttonAdd4.Click += new System.EventHandler(this.buttonAdd4_Click);
            // 
            // buttonBack4
            // 
            this.buttonBack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack4.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack4.ForeColor = System.Drawing.Color.Black;
            this.buttonBack4.Location = new System.Drawing.Point(1084, 492);
            this.buttonBack4.Name = "buttonBack4";
            this.buttonBack4.Size = new System.Drawing.Size(131, 49);
            this.buttonBack4.TabIndex = 15;
            this.buttonBack4.Text = "Назад";
            this.buttonBack4.UseVisualStyleBackColor = false;
            this.buttonBack4.Click += new System.EventHandler(this.buttonBack4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1084, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_of_reception_and_transfer_to_workTextBox
            // 
            this.ID_of_reception_and_transfer_to_workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reception_and_transferBindingSource, "ID_of_reception_and_transfer_to_work", true));
            this.ID_of_reception_and_transfer_to_workTextBox.Location = new System.Drawing.Point(585, 188);
            this.ID_of_reception_and_transfer_to_workTextBox.Name = "ID_of_reception_and_transfer_to_workTextBox";
            this.ID_of_reception_and_transfer_to_workTextBox.Size = new System.Drawing.Size(79, 26);
            this.ID_of_reception_and_transfer_to_workTextBox.TabIndex = 19;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormReceptionTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(iD_of_reception_and_transfer_to_workLabel);
            this.Controls.Add(this.ID_of_reception_and_transfer_to_workTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSeal4);
            this.Controls.Add(this.buttonAdd4);
            this.Controls.Add(this.buttonBack4);
            this.Controls.Add(tariff_rateLabel);
            this.Controls.Add(this.tariff_rateTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(structural_subdivisionLabel);
            this.Controls.Add(this.structural_subdivisionTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.reception_and_transferBindingNavigator);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Name = "FormReceptionTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прием и перевод на работу";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptionTransfer_FormClosed);
            this.Load += new System.EventHandler(this.FormReceptionTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingNavigator)).EndInit();
            this.reception_and_transferBindingNavigator.ResumeLayout(false);
            this.reception_and_transferBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource reception_and_transferBindingSource;
        private Personal_cardsDataSetTableAdapters.Reception_and_transferTableAdapter reception_and_transferTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reception_and_transferBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reception_and_transferBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox structural_subdivisionTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox tariff_rateTextBox;
        private System.Windows.Forms.Button buttonSeal4;
        private System.Windows.Forms.Button buttonAdd4;
        private System.Windows.Forms.Button buttonBack4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ID_of_reception_and_transfer_to_workTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}