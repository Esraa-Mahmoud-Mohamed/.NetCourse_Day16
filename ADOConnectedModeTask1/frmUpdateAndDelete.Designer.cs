namespace ADOConnectedModeTask1
{
    partial class frmUpdateAndDelete
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
            label1 = new Label();
            comboEmployees = new ComboBox();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            lblResult = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Authors";
            // 
            // comboEmployees
            // 
            comboEmployees.FormattingEnabled = true;
            comboEmployees.Location = new Point(81, 25);
            comboEmployees.Name = "comboAuthors";
            comboEmployees.Size = new Size(166, 23);
            comboEmployees.TabIndex = 1;
            comboEmployees.SelectedIndexChanged += comboEmployees_SelectedIndexChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(81, 250);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 23);
            txtAddress.TabIndex = 16;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(81, 204);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(173, 23);
            txtLName.TabIndex = 15;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(81, 168);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(173, 23);
            txtFName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 130);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 253);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 207);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 171);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 133);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 9;
            label5.Text = "Id";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(310, 337);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(420, 384);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 18;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(332, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmUpdateAndDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(lblResult);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(comboEmployees);
            Controls.Add(label1);
            Name = "frmUpdateAndDelete";
            Text = "frmUpdateAndDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboEmployees;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnUpdate;
        private Label lblResult;
        private Button btnDelete;
    }
}