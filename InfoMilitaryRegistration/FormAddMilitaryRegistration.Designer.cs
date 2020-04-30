namespace Personal_cardsApp1
{
    partial class FormAddMilitaryRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMilitaryRegistration));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.military_registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.military_registrationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Military_registrationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.military_registrationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.military_registrationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBack7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_military_registrationTextBox = new System.Windows.Forms.TextBox();
            this.Stock_categoryTextBox = new System.Windows.Forms.TextBox();
            this.Military_rankTextBox = new System.Windows.Forms.TextBox();
            this.Composition_profileTextBox = new System.Windows.Forms.TextBox();
            this.Full_code_designation_VUSTextBox = new System.Windows.Forms.TextBox();
            this.Category_of_fitness_for_military_serviceTextBox = new System.Windows.Forms.TextBox();
            this.The_name_of_the_military_commissariatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingNavigator)).BeginInit();
            this.military_registrationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // military_registrationBindingSource
            // 
            this.military_registrationBindingSource.DataMember = "Military_registration";
            this.military_registrationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // military_registrationTableAdapter
            // 
            this.military_registrationTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Military_registrationTableAdapter = this.military_registrationTableAdapter;
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
            // military_registrationBindingNavigator
            // 
            this.military_registrationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.military_registrationBindingNavigator.BindingSource = this.military_registrationBindingSource;
            this.military_registrationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.military_registrationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.military_registrationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.military_registrationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.military_registrationBindingNavigatorSaveItem});
            this.military_registrationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.military_registrationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.military_registrationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.military_registrationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.military_registrationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.military_registrationBindingNavigator.Name = "military_registrationBindingNavigator";
            this.military_registrationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.military_registrationBindingNavigator.Size = new System.Drawing.Size(1357, 32);
            this.military_registrationBindingNavigator.TabIndex = 0;
            this.military_registrationBindingNavigator.Text = "bindingNavigator1";
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
            // military_registrationBindingNavigatorSaveItem
            // 
            this.military_registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.military_registrationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("military_registrationBindingNavigatorSaveItem.Image")));
            this.military_registrationBindingNavigatorSaveItem.Name = "military_registrationBindingNavigatorSaveItem";
            this.military_registrationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.military_registrationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.military_registrationBindingNavigatorSaveItem.Visible = false;
            this.military_registrationBindingNavigatorSaveItem.Click += new System.EventHandler(this.military_registrationBindingNavigatorSaveItem_Click);
            // 
            // buttonBack7
            // 
            this.buttonBack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack7.Location = new System.Drawing.Point(1137, 385);
            this.buttonBack7.Name = "buttonBack7";
            this.buttonBack7.Size = new System.Drawing.Size(128, 55);
            this.buttonBack7.TabIndex = 6;
            this.buttonBack7.Text = "Назад";
            this.buttonBack7.UseVisualStyleBackColor = false;
            this.buttonBack7.Click += new System.EventHandler(this.buttonBack7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(179, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID воинского учета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(179, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "Категория запаса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(179, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Воинское звание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(179, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Состав(профиль):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(179, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 57);
            this.label5.TabIndex = 11;
            this.label5.Text = "Полное кодовое обозначение ВУС:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(179, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 114);
            this.label6.TabIndex = 12;
            this.label6.Text = "Категория годности к \r\nвоенной службе:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(179, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(689, 114);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наименование военного комиссариата \r\nпо месту жительства:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_military_registrationTextBox
            // 
            this.ID_military_registrationTextBox.Location = new System.Drawing.Point(557, 100);
            this.ID_military_registrationTextBox.Name = "ID_military_registrationTextBox";
            this.ID_military_registrationTextBox.Size = new System.Drawing.Size(79, 26);
            this.ID_military_registrationTextBox.TabIndex = 14;
            // 
            // Stock_categoryTextBox
            // 
            this.Stock_categoryTextBox.Location = new System.Drawing.Point(526, 157);
            this.Stock_categoryTextBox.Name = "Stock_categoryTextBox";
            this.Stock_categoryTextBox.Size = new System.Drawing.Size(268, 26);
            this.Stock_categoryTextBox.TabIndex = 15;
            // 
            // Military_rankTextBox
            // 
            this.Military_rankTextBox.Location = new System.Drawing.Point(526, 214);
            this.Military_rankTextBox.Name = "Military_rankTextBox";
            this.Military_rankTextBox.Size = new System.Drawing.Size(268, 26);
            this.Military_rankTextBox.TabIndex = 16;
            // 
            // Composition_profileTextBox
            // 
            this.Composition_profileTextBox.Location = new System.Drawing.Point(526, 271);
            this.Composition_profileTextBox.Name = "Composition_profileTextBox";
            this.Composition_profileTextBox.Size = new System.Drawing.Size(110, 26);
            this.Composition_profileTextBox.TabIndex = 17;
            // 
            // Full_code_designation_VUSTextBox
            // 
            this.Full_code_designation_VUSTextBox.Location = new System.Drawing.Point(794, 328);
            this.Full_code_designation_VUSTextBox.Name = "Full_code_designation_VUSTextBox";
            this.Full_code_designation_VUSTextBox.Size = new System.Drawing.Size(237, 26);
            this.Full_code_designation_VUSTextBox.TabIndex = 18;
            // 
            // Category_of_fitness_for_military_serviceTextBox
            // 
            this.Category_of_fitness_for_military_serviceTextBox.Location = new System.Drawing.Point(594, 414);
            this.Category_of_fitness_for_military_serviceTextBox.Name = "Category_of_fitness_for_military_serviceTextBox";
            this.Category_of_fitness_for_military_serviceTextBox.Size = new System.Drawing.Size(184, 26);
            this.Category_of_fitness_for_military_serviceTextBox.TabIndex = 19;
            // 
            // The_name_of_the_military_commissariatTextBox
            // 
            this.The_name_of_the_military_commissariatTextBox.Location = new System.Drawing.Point(874, 528);
            this.The_name_of_the_military_commissariatTextBox.Name = "The_name_of_the_military_commissariatTextBox";
            this.The_name_of_the_military_commissariatTextBox.Size = new System.Drawing.Size(307, 26);
            this.The_name_of_the_military_commissariatTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1131, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1131, 271);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(134, 55);
            this.buttonSeal2.TabIndex = 22;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAddMilitaryRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.The_name_of_the_military_commissariatTextBox);
            this.Controls.Add(this.Category_of_fitness_for_military_serviceTextBox);
            this.Controls.Add(this.Full_code_designation_VUSTextBox);
            this.Controls.Add(this.Composition_profileTextBox);
            this.Controls.Add(this.Military_rankTextBox);
            this.Controls.Add(this.Stock_categoryTextBox);
            this.Controls.Add(this.ID_military_registrationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack7);
            this.Controls.Add(this.military_registrationBindingNavigator);
            this.Name = "FormAddMilitaryRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление воинского учета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddMilitaryRegistration_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddMilitaryRegistration_FormClosed);
            this.Load += new System.EventHandler(this.FormAddMilitaryRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.military_registrationBindingNavigator)).EndInit();
            this.military_registrationBindingNavigator.ResumeLayout(false);
            this.military_registrationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource military_registrationBindingSource;
        private Personal_cardsDataSetTableAdapters.Military_registrationTableAdapter military_registrationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator military_registrationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton military_registrationBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonBack7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_military_registrationTextBox;
        private System.Windows.Forms.TextBox Stock_categoryTextBox;
        private System.Windows.Forms.TextBox Military_rankTextBox;
        private System.Windows.Forms.TextBox Composition_profileTextBox;
        private System.Windows.Forms.TextBox Full_code_designation_VUSTextBox;
        private System.Windows.Forms.TextBox Category_of_fitness_for_military_serviceTextBox;
        private System.Windows.Forms.TextBox The_name_of_the_military_commissariatTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}