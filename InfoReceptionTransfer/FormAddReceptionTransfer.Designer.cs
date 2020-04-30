namespace Personal_cardsApp1
{
    partial class FormAddReceptionTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReceptionTransfer));
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
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_of_reception_and_transfer_to_workTextBox = new System.Windows.Forms.TextBox();
            this.Structural_subdivisionTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.Tariff_rateTextBox = new System.Windows.Forms.TextBox();
            this.Date1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reception_and_transferBindingNavigator)).BeginInit();
            this.reception_and_transferBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.Granting_leaveTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Order_admissionTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = this.reception_and_transferTableAdapter;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.Staff_listTableAdapter = null;
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
            this.reception_and_transferBindingNavigator.Size = new System.Drawing.Size(1357, 32);
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
            // buttonBack2
            // 
            this.buttonBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(989, 400);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(137, 56);
            this.buttonBack2.TabIndex = 3;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(127, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID приема и перевода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(127, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(127, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "Структурное подразделение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(127, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 57);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(127, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 57);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тарифная ставка:";
            // 
            // ID_of_reception_and_transfer_to_workTextBox
            // 
            this.ID_of_reception_and_transfer_to_workTextBox.Location = new System.Drawing.Point(544, 236);
            this.ID_of_reception_and_transfer_to_workTextBox.Name = "ID_of_reception_and_transfer_to_workTextBox";
            this.ID_of_reception_and_transfer_to_workTextBox.Size = new System.Drawing.Size(79, 26);
            this.ID_of_reception_and_transfer_to_workTextBox.TabIndex = 9;
            // 
            // Structural_subdivisionTextBox
            // 
            this.Structural_subdivisionTextBox.Location = new System.Drawing.Point(651, 350);
            this.Structural_subdivisionTextBox.Name = "Structural_subdivisionTextBox";
            this.Structural_subdivisionTextBox.Size = new System.Drawing.Size(253, 26);
            this.Structural_subdivisionTextBox.TabIndex = 11;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(367, 419);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(282, 26);
            this.PositionTextBox.TabIndex = 12;
            // 
            // Tariff_rateTextBox
            // 
            this.Tariff_rateTextBox.Location = new System.Drawing.Point(464, 491);
            this.Tariff_rateTextBox.Name = "Tariff_rateTextBox";
            this.Tariff_rateTextBox.Size = new System.Drawing.Size(120, 26);
            this.Tariff_rateTextBox.TabIndex = 13;
            // 
            // Date1DateTimePicker
            // 
            this.Date1DateTimePicker.Location = new System.Drawing.Point(255, 291);
            this.Date1DateTimePicker.Name = "Date1DateTimePicker";
            this.Date1DateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.Date1DateTimePicker.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(989, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(989, 321);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(137, 55);
            this.buttonSeal2.TabIndex = 16;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAddReceptionTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Date1DateTimePicker);
            this.Controls.Add(this.Tariff_rateTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.Structural_subdivisionTextBox);
            this.Controls.Add(this.ID_of_reception_and_transfer_to_workTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.reception_and_transferBindingNavigator);
            this.Name = "FormAddReceptionTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление приема и перевода";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddReceptionTransfer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddReceptionTransfer_FormClosed);
            this.Load += new System.EventHandler(this.FormAddReceptionTransfer_Load);
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
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_of_reception_and_transfer_to_workTextBox;
        private System.Windows.Forms.TextBox Structural_subdivisionTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox Tariff_rateTextBox;
        private System.Windows.Forms.DateTimePicker Date1DateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}