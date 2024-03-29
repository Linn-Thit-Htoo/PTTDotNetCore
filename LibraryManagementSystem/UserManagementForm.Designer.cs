namespace LibraryManagementSystem
{
    partial class UserManagementForm
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
            panel1 = new Panel();
            btnEdit = new Button();
            button1 = new Button();
            dgv1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgv1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1568, 1001);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 255);
            btnEdit.Location = new Point(1414, 131);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 59);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(3, 125);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(147, 64);
            button1.TabIndex = 5;
            button1.Text = "Add New User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(3, 223);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(1561, 751);
            dgv1.TabIndex = 4;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(450, 20);
            label1.Name = "label1";
            label1.Size = new Size(704, 94);
            label1.TabIndex = 3;
            label1.Text = "User Management";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 1044);
            Controls.Add(panel1);
            MinimumSize = new Size(1597, 1028);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            FormClosed += UserManagementForm_FormClosed;
            Load += UserManagementForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv1;
        private Label label1;
        private Button button1;
        private Button btnEdit;
    }
}