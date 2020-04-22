namespace Personal_cardsApp1
{
    partial class FormCertification
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
            System.Windows.Forms.Label date_of_certificationLabel;
            System.Windows.Forms.Label commission_decisionLabel;
            System.Windows.Forms.Label protocol_numberLabel;
            System.Windows.Forms.Label date_of_reportLabel;
            System.Windows.Forms.Label iD_certificationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCertification));
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
            this.date_of_certificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commission_decisionTextBox = new System.Windows.Forms.TextBox();
            this.protocol_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_of_reportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack9 = new System.Windows.Forms.Button();
            this.buttonSeal9 = new System.Windows.Forms.Button();
            this.buttonAdd9 = new System.Windows.Forms.Button();
            this.ID_certificationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            date_of_certificationLabel = new System.Windows.Forms.Label();
            commission_decisionLabel = new System.Windows.Forms.Label();
            protocol_numberLabel = new System.Windows.Forms.Label();
            date_of_reportLabel = new System.Windows.Forms.Label();
            iD_certificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingNavigator)).BeginInit();
            this.certificationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_of_certificationLabel
            // 
            date_of_certificationLabel.AutoSize = true;
            date_of_certificationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_certificationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_of_certificationLabel.Location = new System.Drawing.Point(233, 253);
            date_of_certificationLabel.Name = "date_of_certificationLabel";
            date_of_certificationLabel.Size = new System.Drawing.Size(315, 57);
            date_of_certificationLabel.TabIndex = 1;
            date_of_certificationLabel.Text = "Дата аттестации:";
            // 
            // commission_decisionLabel
            // 
            commission_decisionLabel.AutoSize = true;
            commission_decisionLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            commission_decisionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            commission_decisionLabel.Location = new System.Drawing.Point(233, 316);
            commission_decisionLabel.Name = "commission_decisionLabel";
            commission_decisionLabel.Size = new System.Drawing.Size(357, 57);
            commission_decisionLabel.TabIndex = 3;
            commission_decisionLabel.Text = "Решение комиссии:";
            // 
            // protocol_numberLabel
            // 
            protocol_numberLabel.AutoSize = true;
            protocol_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            protocol_numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            protocol_numberLabel.Location = new System.Drawing.Point(233, 378);
            protocol_numberLabel.Name = "protocol_numberLabel";
            protocol_numberLabel.Size = new System.Drawing.Size(330, 57);
            protocol_numberLabel.TabIndex = 5;
            protocol_numberLabel.Text = "Номер протокола:";
            // 
            // date_of_reportLabel
            // 
            date_of_reportLabel.AutoSize = true;
            date_of_reportLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_reportLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            date_of_reportLabel.Location = new System.Drawing.Point(233, 437);
            date_of_reportLabel.Name = "date_of_reportLabel";
            date_of_reportLabel.Size = new System.Drawing.Size(116, 57);
            date_of_reportLabel.TabIndex = 7;
            date_of_reportLabel.Text = "Дата:";
            // 
            // iD_certificationLabel
            // 
            iD_certificationLabel.AutoSize = true;
            iD_certificationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_certificationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_certificationLabel.Location = new System.Drawing.Point(238, 195);
            iD_certificationLabel.Name = "iD_certificationLabel";
            iD_certificationLabel.Size = new System.Drawing.Size(272, 57);
            iD_certificationLabel.TabIndex = 17;
            iD_certificationLabel.Text = "ID аттестации:";
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
            this.certificationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
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
            // date_of_certificationDateTimePicker
            // 
            this.date_of_certificationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.certificationBindingSource, "Date_of_certification", true));
            this.date_of_certificationDateTimePicker.Location = new System.Drawing.Point(565, 277);
            this.date_of_certificationDateTimePicker.Name = "date_of_certificationDateTimePicker";
            this.date_of_certificationDateTimePicker.Size = new System.Drawing.Size(174, 26);
            this.date_of_certificationDateTimePicker.TabIndex = 2;
            // 
            // commission_decisionTextBox
            // 
            this.commission_decisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "Commission_decision", true));
            this.commission_decisionTextBox.Location = new System.Drawing.Point(626, 347);
            this.commission_decisionTextBox.Name = "commission_decisionTextBox";
            this.commission_decisionTextBox.Size = new System.Drawing.Size(254, 26);
            this.commission_decisionTextBox.TabIndex = 4;
            // 
            // protocol_numberTextBox
            // 
            this.protocol_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "Protocol_number", true));
            this.protocol_numberTextBox.Location = new System.Drawing.Point(626, 402);
            this.protocol_numberTextBox.Name = "protocol_numberTextBox";
            this.protocol_numberTextBox.Size = new System.Drawing.Size(254, 26);
            this.protocol_numberTextBox.TabIndex = 6;
            // 
            // date_of_reportDateTimePicker
            // 
            this.date_of_reportDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.certificationBindingSource, "Date_of_report", true));
            this.date_of_reportDateTimePicker.Location = new System.Drawing.Point(363, 460);
            this.date_of_reportDateTimePicker.Name = "date_of_reportDateTimePicker";
            this.date_of_reportDateTimePicker.Size = new System.Drawing.Size(185, 26);
            this.date_of_reportDateTimePicker.TabIndex = 8;
            // 
            // buttonBack9
            // 
            this.buttonBack9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack9.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack9.Location = new System.Drawing.Point(957, 510);
            this.buttonBack9.Name = "buttonBack9";
            this.buttonBack9.Size = new System.Drawing.Size(131, 49);
            this.buttonBack9.TabIndex = 17;
            this.buttonBack9.Text = "Назад";
            this.buttonBack9.UseVisualStyleBackColor = false;
            this.buttonBack9.Click += new System.EventHandler(this.buttonBack9_Click);
            // 
            // buttonSeal9
            // 
            this.buttonSeal9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal9.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal9.Location = new System.Drawing.Point(957, 455);
            this.buttonSeal9.Name = "buttonSeal9";
            this.buttonSeal9.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal9.TabIndex = 16;
            this.buttonSeal9.Text = "Печать";
            this.buttonSeal9.UseVisualStyleBackColor = false;
            this.buttonSeal9.Click += new System.EventHandler(this.buttonSeal9_Click);
            // 
            // buttonAdd9
            // 
            this.buttonAdd9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd9.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd9.Location = new System.Drawing.Point(957, 347);
            this.buttonAdd9.Name = "buttonAdd9";
            this.buttonAdd9.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd9.TabIndex = 15;
            this.buttonAdd9.Text = "Добавить";
            this.buttonAdd9.UseVisualStyleBackColor = false;
            this.buttonAdd9.Click += new System.EventHandler(this.buttonAdd9_Click);
            // 
            // ID_certificationTextBox
            // 
            this.ID_certificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "ID_certification", true));
            this.ID_certificationTextBox.Location = new System.Drawing.Point(542, 221);
            this.ID_certificationTextBox.Name = "ID_certificationTextBox";
            this.ID_certificationTextBox.Size = new System.Drawing.Size(77, 26);
            this.ID_certificationTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(957, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_certificationLabel);
            this.Controls.Add(this.ID_certificationTextBox);
            this.Controls.Add(this.buttonBack9);
            this.Controls.Add(this.buttonSeal9);
            this.Controls.Add(this.buttonAdd9);
            this.Controls.Add(date_of_reportLabel);
            this.Controls.Add(this.date_of_reportDateTimePicker);
            this.Controls.Add(protocol_numberLabel);
            this.Controls.Add(this.protocol_numberTextBox);
            this.Controls.Add(commission_decisionLabel);
            this.Controls.Add(this.commission_decisionTextBox);
            this.Controls.Add(date_of_certificationLabel);
            this.Controls.Add(this.date_of_certificationDateTimePicker);
            this.Controls.Add(this.certificationBindingNavigator);
            this.Name = "FormCertification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аттестация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCertification_FormClosed);
            this.Load += new System.EventHandler(this.FormCertification_Load);
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
        private System.Windows.Forms.DateTimePicker date_of_certificationDateTimePicker;
        private System.Windows.Forms.TextBox commission_decisionTextBox;
        private System.Windows.Forms.TextBox protocol_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_of_reportDateTimePicker;
        private System.Windows.Forms.Button buttonBack9;
        private System.Windows.Forms.Button buttonSeal9;
        private System.Windows.Forms.Button buttonAdd9;
        private System.Windows.Forms.TextBox ID_certificationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}