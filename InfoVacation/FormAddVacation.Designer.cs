namespace Personal_cardsApp1
{
    partial class FormAddPersonalCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPersonalCards));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.VacationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.vacationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vacationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBack6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_vacationTextBox = new System.Windows.Forms.TextBox();
            this.Type_of_vacationTextBox = new System.Windows.Forms.TextBox();
            this.Working_period_withTextBox = new System.Windows.Forms.TextBox();
            this.Period_of_work_onTextBox = new System.Windows.Forms.TextBox();
            this.Number_of_vacation_daysTextBox = new System.Windows.Forms.TextBox();
            this.Start_dateTextBox = new System.Windows.Forms.TextBox();
            this.Expiry_dateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingNavigator)).BeginInit();
            this.vacationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.Staff_listTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = this.vacationTableAdapter;
            // 
            // vacationBindingNavigator
            // 
            this.vacationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacationBindingNavigator.BindingSource = this.vacationBindingSource;
            this.vacationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.vacationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacationBindingNavigatorSaveItem});
            this.vacationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacationBindingNavigator.Name = "vacationBindingNavigator";
            this.vacationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacationBindingNavigator.Size = new System.Drawing.Size(1357, 32);
            this.vacationBindingNavigator.TabIndex = 0;
            this.vacationBindingNavigator.Text = "bindingNavigator1";
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
            // vacationBindingNavigatorSaveItem
            // 
            this.vacationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacationBindingNavigatorSaveItem.Image")));
            this.vacationBindingNavigatorSaveItem.Name = "vacationBindingNavigatorSaveItem";
            this.vacationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.vacationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vacationBindingNavigatorSaveItem.Visible = false;
            this.vacationBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacationBindingNavigatorSaveItem_Click);
            // 
            // buttonBack6
            // 
            this.buttonBack6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack6.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack6.Location = new System.Drawing.Point(1157, 381);
            this.buttonBack6.Name = "buttonBack6";
            this.buttonBack6.Size = new System.Drawing.Size(134, 48);
            this.buttonBack6.TabIndex = 4;
            this.buttonBack6.Text = "Назад";
            this.buttonBack6.UseVisualStyleBackColor = false;
            this.buttonBack6.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(232, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID отпуска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(232, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид отпуска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(232, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "Период работы с:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(232, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 57);
            this.label4.TabIndex = 8;
            this.label4.Text = "Период работы по:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(232, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(696, 57);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество календарных дней отпуска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(232, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 57);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата начала:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(232, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 57);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата окончания:";
            // 
            // ID_vacationTextBox
            // 
            this.ID_vacationTextBox.Location = new System.Drawing.Point(462, 217);
            this.ID_vacationTextBox.Name = "ID_vacationTextBox";
            this.ID_vacationTextBox.Size = new System.Drawing.Size(80, 26);
            this.ID_vacationTextBox.TabIndex = 12;
            // 
            // Type_of_vacationTextBox
            // 
            this.Type_of_vacationTextBox.Location = new System.Drawing.Point(498, 269);
            this.Type_of_vacationTextBox.Name = "Type_of_vacationTextBox";
            this.Type_of_vacationTextBox.Size = new System.Drawing.Size(274, 26);
            this.Type_of_vacationTextBox.TabIndex = 13;
            // 
            // Working_period_withTextBox
            // 
            this.Working_period_withTextBox.Location = new System.Drawing.Point(569, 324);
            this.Working_period_withTextBox.Name = "Working_period_withTextBox";
            this.Working_period_withTextBox.Size = new System.Drawing.Size(203, 26);
            this.Working_period_withTextBox.TabIndex = 14;
            // 
            // Period_of_work_onTextBox
            // 
            this.Period_of_work_onTextBox.Location = new System.Drawing.Point(598, 381);
            this.Period_of_work_onTextBox.Name = "Period_of_work_onTextBox";
            this.Period_of_work_onTextBox.Size = new System.Drawing.Size(174, 26);
            this.Period_of_work_onTextBox.TabIndex = 15;
            // 
            // Number_of_vacation_daysTextBox
            // 
            this.Number_of_vacation_daysTextBox.Location = new System.Drawing.Point(946, 438);
            this.Number_of_vacation_daysTextBox.Name = "Number_of_vacation_daysTextBox";
            this.Number_of_vacation_daysTextBox.Size = new System.Drawing.Size(100, 26);
            this.Number_of_vacation_daysTextBox.TabIndex = 16;
            // 
            // Start_dateTextBox
            // 
            this.Start_dateTextBox.Location = new System.Drawing.Point(486, 489);
            this.Start_dateTextBox.Name = "Start_dateTextBox";
            this.Start_dateTextBox.Size = new System.Drawing.Size(162, 26);
            this.Start_dateTextBox.TabIndex = 17;
            // 
            // Expiry_dateTextBox
            // 
            this.Expiry_dateTextBox.Location = new System.Drawing.Point(569, 546);
            this.Expiry_dateTextBox.Name = "Expiry_dateTextBox";
            this.Expiry_dateTextBox.Size = new System.Drawing.Size(154, 26);
            this.Expiry_dateTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1157, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1157, 301);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(134, 55);
            this.buttonSeal2.TabIndex = 20;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAddPersonalCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Expiry_dateTextBox);
            this.Controls.Add(this.Start_dateTextBox);
            this.Controls.Add(this.Number_of_vacation_daysTextBox);
            this.Controls.Add(this.Period_of_work_onTextBox);
            this.Controls.Add(this.Working_period_withTextBox);
            this.Controls.Add(this.Type_of_vacationTextBox);
            this.Controls.Add(this.ID_vacationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack6);
            this.Controls.Add(this.vacationBindingNavigator);
            this.Name = "FormAddPersonalCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление отпуска";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddPersonalCards_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddPersonalCards_FormClosed);
            this.Load += new System.EventHandler(this.FormAddVacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingNavigator)).EndInit();
            this.vacationBindingNavigator.ResumeLayout(false);
            this.vacationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private Personal_cardsDataSetTableAdapters.VacationTableAdapter vacationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacationBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonBack6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_vacationTextBox;
        private System.Windows.Forms.TextBox Type_of_vacationTextBox;
        private System.Windows.Forms.TextBox Working_period_withTextBox;
        private System.Windows.Forms.TextBox Period_of_work_onTextBox;
        private System.Windows.Forms.TextBox Number_of_vacation_daysTextBox;
        private System.Windows.Forms.TextBox Start_dateTextBox;
        private System.Windows.Forms.TextBox Expiry_dateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}