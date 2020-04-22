namespace Personal_cardsApp1
{
    partial class FormLevelEducation
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
            System.Windows.Forms.Label level_of_educationLabel;
            System.Windows.Forms.Label iD_level_of_educationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevelEducation));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.level_of_educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_of_educationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.Level_of_educationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.level_of_educationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.level_of_educationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.level_of_educationTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack12 = new System.Windows.Forms.Button();
            this.buttonSeal12 = new System.Windows.Forms.Button();
            this.buttonAdd12 = new System.Windows.Forms.Button();
            this.ID_level_of_educationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            level_of_educationLabel = new System.Windows.Forms.Label();
            iD_level_of_educationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_of_educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_of_educationBindingNavigator)).BeginInit();
            this.level_of_educationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // level_of_educationLabel
            // 
            level_of_educationLabel.AutoSize = true;
            level_of_educationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            level_of_educationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            level_of_educationLabel.Location = new System.Drawing.Point(106, 347);
            level_of_educationLabel.Name = "level_of_educationLabel";
            level_of_educationLabel.Size = new System.Drawing.Size(395, 57);
            level_of_educationLabel.TabIndex = 1;
            level_of_educationLabel.Text = "Уровень образования:";
            // 
            // iD_level_of_educationLabel
            // 
            iD_level_of_educationLabel.AutoSize = true;
            iD_level_of_educationLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_level_of_educationLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_level_of_educationLabel.Location = new System.Drawing.Point(106, 279);
            iD_level_of_educationLabel.Name = "iD_level_of_educationLabel";
            iD_level_of_educationLabel.Size = new System.Drawing.Size(423, 57);
            iD_level_of_educationLabel.TabIndex = 26;
            iD_level_of_educationLabel.Text = "ID уровня образования:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // level_of_educationBindingSource
            // 
            this.level_of_educationBindingSource.DataMember = "Level_of_education";
            this.level_of_educationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // level_of_educationTableAdapter
            // 
            this.level_of_educationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = this.level_of_educationTableAdapter;
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
            // level_of_educationBindingNavigator
            // 
            this.level_of_educationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.level_of_educationBindingNavigator.BindingSource = this.level_of_educationBindingSource;
            this.level_of_educationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.level_of_educationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.level_of_educationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.level_of_educationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.level_of_educationBindingNavigatorSaveItem});
            this.level_of_educationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.level_of_educationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.level_of_educationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.level_of_educationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.level_of_educationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.level_of_educationBindingNavigator.Name = "level_of_educationBindingNavigator";
            this.level_of_educationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.level_of_educationBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.level_of_educationBindingNavigator.TabIndex = 0;
            this.level_of_educationBindingNavigator.Text = "bindingNavigator1";
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
            // level_of_educationBindingNavigatorSaveItem
            // 
            this.level_of_educationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.level_of_educationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("level_of_educationBindingNavigatorSaveItem.Image")));
            this.level_of_educationBindingNavigatorSaveItem.Name = "level_of_educationBindingNavigatorSaveItem";
            this.level_of_educationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.level_of_educationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.level_of_educationBindingNavigatorSaveItem.Visible = false;
            this.level_of_educationBindingNavigatorSaveItem.Click += new System.EventHandler(this.level_of_educationBindingNavigatorSaveItem_Click);
            // 
            // level_of_educationTextBox
            // 
            this.level_of_educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.level_of_educationBindingSource, "Level_of_education", true));
            this.level_of_educationTextBox.Location = new System.Drawing.Point(553, 373);
            this.level_of_educationTextBox.Name = "level_of_educationTextBox";
            this.level_of_educationTextBox.Size = new System.Drawing.Size(323, 26);
            this.level_of_educationTextBox.TabIndex = 2;
            // 
            // buttonBack12
            // 
            this.buttonBack12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack12.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack12.Location = new System.Drawing.Point(955, 440);
            this.buttonBack12.Name = "buttonBack12";
            this.buttonBack12.Size = new System.Drawing.Size(131, 49);
            this.buttonBack12.TabIndex = 26;
            this.buttonBack12.Text = "Назад";
            this.buttonBack12.UseVisualStyleBackColor = false;
            this.buttonBack12.Click += new System.EventHandler(this.buttonBack12_Click);
            // 
            // buttonSeal12
            // 
            this.buttonSeal12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal12.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal12.Location = new System.Drawing.Point(955, 385);
            this.buttonSeal12.Name = "buttonSeal12";
            this.buttonSeal12.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal12.TabIndex = 25;
            this.buttonSeal12.Text = "Печать";
            this.buttonSeal12.UseVisualStyleBackColor = false;
            this.buttonSeal12.Click += new System.EventHandler(this.buttonSeal12_Click);
            // 
            // buttonAdd12
            // 
            this.buttonAdd12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd12.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd12.Location = new System.Drawing.Point(955, 275);
            this.buttonAdd12.Name = "buttonAdd12";
            this.buttonAdd12.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd12.TabIndex = 24;
            this.buttonAdd12.Text = "Добавить";
            this.buttonAdd12.UseVisualStyleBackColor = false;
            this.buttonAdd12.Click += new System.EventHandler(this.buttonAdd12_Click);
            // 
            // ID_level_of_educationTextBox
            // 
            this.ID_level_of_educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.level_of_educationBindingSource, "ID_level_of_education", true));
            this.ID_level_of_educationTextBox.Location = new System.Drawing.Point(553, 305);
            this.ID_level_of_educationTextBox.Name = "ID_level_of_educationTextBox";
            this.ID_level_of_educationTextBox.Size = new System.Drawing.Size(100, 26);
            this.ID_level_of_educationTextBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(955, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 28;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormLevelEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_level_of_educationLabel);
            this.Controls.Add(this.ID_level_of_educationTextBox);
            this.Controls.Add(this.buttonBack12);
            this.Controls.Add(this.buttonSeal12);
            this.Controls.Add(this.buttonAdd12);
            this.Controls.Add(level_of_educationLabel);
            this.Controls.Add(this.level_of_educationTextBox);
            this.Controls.Add(this.level_of_educationBindingNavigator);
            this.Name = "FormLevelEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровень образования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLevelEducation_FormClosed);
            this.Load += new System.EventHandler(this.FormLevelEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_of_educationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_of_educationBindingNavigator)).EndInit();
            this.level_of_educationBindingNavigator.ResumeLayout(false);
            this.level_of_educationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource level_of_educationBindingSource;
        private Personal_cardsDataSetTableAdapters.Level_of_educationTableAdapter level_of_educationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator level_of_educationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton level_of_educationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox level_of_educationTextBox;
        private System.Windows.Forms.Button buttonBack12;
        private System.Windows.Forms.Button buttonSeal12;
        private System.Windows.Forms.Button buttonAdd12;
        private System.Windows.Forms.TextBox ID_level_of_educationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}