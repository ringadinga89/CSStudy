namespace Ch11
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bntSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.nAge = new System.Windows.Forms.NumericUpDown();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Hp = new System.Windows.Forms.Label();
            this.labe13 = new System.Windows.Forms.Label();
            this.Uid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(24, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(283, 396);
            this.dataGrid.TabIndex = 0;
            // 
            // bntSelect
            // 
            this.bntSelect.Location = new System.Drawing.Point(0, 0);
            this.bntSelect.Name = "bntSelect";
            this.bntSelect.Size = new System.Drawing.Size(75, 23);
            this.bntSelect.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(0, 0);
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(120, 23);
            this.nAge.TabIndex = 0;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(0, 0);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 23);
            this.txtHp.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(0, 0);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 23);
            this.txtUid.TabIndex = 0;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(0, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 23);
            this.Age.TabIndex = 0;
            // 
            // Hp
            // 
            this.Hp.Location = new System.Drawing.Point(0, 0);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(100, 23);
            this.Hp.TabIndex = 0;
            // 
            // labe13
            // 
            this.labe13.Location = new System.Drawing.Point(0, 0);
            this.labe13.Name = "labe13";
            this.labe13.Size = new System.Drawing.Size(100, 23);
            this.labe13.TabIndex = 0;
            // 
            // Uid
            // 
            this.Uid.Location = new System.Drawing.Point(0, 0);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(100, 23);
            this.Uid.TabIndex = 0;
            // 
            // User
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGrid;
        private Button bntSelect;
        private GroupBox groupBox1;
        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private NumericUpDown nAge;
        private TextBox txtHp;
        private TextBox txtName;
        private TextBox txtUid;
        private Label Age;
        private Label Hp;
        private Label labe13;
        private Label Uid;
    }
}