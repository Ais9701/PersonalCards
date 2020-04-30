namespace Personal_cardsApp1
{
    partial class FormAddCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCertification));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.certificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.CertificationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.certificationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.certificationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBack7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_certificationTextBox = new System.Windows.Forms.TextBox();
            this.Date_of_certificationTextBox = new System.Windows.Forms.TextBox();
            this.Commission_decisionTextBox = new System.Windows.Forms.TextBox();
            this.Protocol_numberTextBox = new System.Windows.Forms.TextBox();
            this.Date_of_reportTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeal2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingNavigator)).BeginInit();
            this.certificationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificationBindingSource
            // 
            this.certificationBindingSource.DataMember = "Certification";
            this.certificationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // certificationTableAdapter
            // 
            this.certificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = this.certificationTableAdapter;
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
            // certificationBindingNavigator
            // 
            this.certificationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.certificationBindingNavigator.BindingSource = this.certificationBindingSource;
            this.certificationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.certificationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.certificationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.certificationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.certificationBindingNavigatorSaveItem});
            this.certificationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.certificationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.certificationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.certificationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.certificationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.certificationBindingNavigator.Name = "certificationBindingNavigator";
            this.certificationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.certificationBindingNavigator.Size = new System.Drawing.Size(1357, 32);
            this.certificationBindingNavigator.TabIndex = 0;
            this.certificationBindingNavigator.Text = "bindingNavigator1";
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
            // certificationBindingNavigatorSaveItem
            // 
            this.certificationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.certificationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("certificationBindingNavigatorSaveItem.Image")));
            this.certificationBindingNavigatorSaveItem.Name = "certificationBindingNavigatorSaveItem";
            this.certificationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.certificationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.certificationBindingNavigatorSaveItem.Visible = false;
            this.certificationBindingNavigatorSaveItem.Click += new System.EventHandler(this.certificationBindingNavigatorSaveItem_Click);
            // 
            // buttonBack7
            // 
            this.buttonBack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack7.Location = new System.Drawing.Point(1134, 400);
            this.buttonBack7.Name = "buttonBack7";
            this.buttonBack7.Size = new System.Drawing.Size(128, 48);
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
            this.label1.Location = new System.Drawing.Point(312, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID аттестации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(312, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата аттестации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(312, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Решение комиссии:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(312, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер протокола:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(312, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 57);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата:";
            // 
            // ID_certificationTextBox
            // 
            this.ID_certificationTextBox.Location = new System.Drawing.Point(603, 198);
            this.ID_certificationTextBox.Name = "ID_certificationTextBox";
            this.ID_certificationTextBox.Size = new System.Drawing.Size(66, 26);
            this.ID_certificationTextBox.TabIndex = 12;
            // 
            // Date_of_certificationTextBox
            // 
            this.Date_of_certificationTextBox.Location = new System.Drawing.Point(655, 257);
            this.Date_of_certificationTextBox.Name = "Date_of_certificationTextBox";
            this.Date_of_certificationTextBox.Size = new System.Drawing.Size(169, 26);
            this.Date_of_certificationTextBox.TabIndex = 13;
            // 
            // Commission_decisionTextBox
            // 
            this.Commission_decisionTextBox.Location = new System.Drawing.Point(702, 314);
            this.Commission_decisionTextBox.Name = "Commission_decisionTextBox";
            this.Commission_decisionTextBox.Size = new System.Drawing.Size(262, 26);
            this.Commission_decisionTextBox.TabIndex = 14;
            // 
            // Protocol_numberTextBox
            // 
            this.Protocol_numberTextBox.Location = new System.Drawing.Point(682, 371);
            this.Protocol_numberTextBox.Name = "Protocol_numberTextBox";
            this.Protocol_numberTextBox.Size = new System.Drawing.Size(142, 26);
            this.Protocol_numberTextBox.TabIndex = 15;
            // 
            // Date_of_reportTextBox
            // 
            this.Date_of_reportTextBox.Location = new System.Drawing.Point(447, 428);
            this.Date_of_reportTextBox.Name = "Date_of_reportTextBox";
            this.Date_of_reportTextBox.Size = new System.Drawing.Size(150, 26);
            this.Date_of_reportTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1131, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeal2
            // 
            this.buttonSeal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal2.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal2.Location = new System.Drawing.Point(1131, 330);
            this.buttonSeal2.Name = "buttonSeal2";
            this.buttonSeal2.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal2.TabIndex = 18;
            this.buttonSeal2.Text = "Печать";
            this.buttonSeal2.UseVisualStyleBackColor = false;
            this.buttonSeal2.Click += new System.EventHandler(this.buttonSeal2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormAddCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonSeal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Date_of_reportTextBox);
            this.Controls.Add(this.Protocol_numberTextBox);
            this.Controls.Add(this.Commission_decisionTextBox);
            this.Controls.Add(this.Date_of_certificationTextBox);
            this.Controls.Add(this.ID_certificationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack7);
            this.Controls.Add(this.certificationBindingNavigator);
            this.Name = "FormAddCertification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление аттестации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddCertification_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddCertification_FormClosed);
            this.Load += new System.EventHandler(this.FormAddCertification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingNavigator)).EndInit();
            this.certificationBindingNavigator.ResumeLayout(false);
            this.certificationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource certificationBindingSource;
        private Personal_cardsDataSetTableAdapters.CertificationTableAdapter certificationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator certificationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton certificationBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonBack7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_certificationTextBox;
        private System.Windows.Forms.TextBox Date_of_certificationTextBox;
        private System.Windows.Forms.TextBox Commission_decisionTextBox;
        private System.Windows.Forms.TextBox Protocol_numberTextBox;
        private System.Windows.Forms.TextBox Date_of_reportTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeal2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}