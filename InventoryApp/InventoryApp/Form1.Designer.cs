namespace InventoryApp
{
    partial class InventoryManagementSystem
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementSystem));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            txtBrand = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            Title = new Label();
            txtQuantity = new TextBox();
            txtThreshold = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Name = "txtName";
            // 
            // txtCode
            // 
            resources.ApplyResources(txtCode, "txtCode");
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Name = "txtCode";
            // 
            // txtBrand
            // 
            resources.ApplyResources(txtBrand, "txtBrand");
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Name = "txtBrand";
            // 
            // txtPrice
            // 
            resources.ApplyResources(txtPrice, "txtPrice");
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Name = "txtPrice";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.BackColor = Color.FromArgb(0, 184, 148);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = Color.White;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.BackColor = Color.FromArgb(9, 132, 227);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = Color.FromArgb(214, 48, 49);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            resources.ApplyResources(btnLoad, "btnLoad");
            btnLoad.BackColor = Color.FromArgb(108, 92, 231);
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.ForeColor = Color.White;
            btnLoad.Name = "btnLoad";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridViewCellStyle1.BackColor = Color.FromArgb(234, 242, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            resources.ApplyResources(Title, "Title");
            Title.ForeColor = Color.FromArgb(44, 62, 80);
            Title.Name = "Title";
            Title.Click += Title_Click;
            // 
            // txtQuantity
            // 
            resources.ApplyResources(txtQuantity, "txtQuantity");
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Name = "txtQuantity";
            // 
            // txtThreshold
            // 
            resources.ApplyResources(txtThreshold, "txtThreshold");
            txtThreshold.BorderStyle = BorderStyle.FixedSingle;
            txtThreshold.Name = "txtThreshold";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.FromArgb(100, 110, 120);
            label7.Name = "label7";
            label7.Click += label7_Click;
            // 
            // InventoryManagementSystem
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtThreshold);
            Controls.Add(txtQuantity);
            Controls.Add(Title);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtCode);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InventoryManagementSystem";
            Load += InventoryManagementSystem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtCode;
        private TextBox txtBrand;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dataGridView1;
        private Label Title;
        private TextBox txtQuantity;
        private TextBox txtThreshold;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
