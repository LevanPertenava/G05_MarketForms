
namespace Market.Client
{
    partial class EmployeesListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.mnuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // empDGV
            // 
            this.empDGV.AllowUserToAddRows = false;
            this.empDGV.AllowUserToDeleteRows = false;
            this.empDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmFirstName,
            this.clmLastName,
            this.clmPosition,
            this.clmPhoneNumber,
            this.clmEmail});
            this.empDGV.ContextMenuStrip = this.mnuGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.empDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empDGV.EnableHeadersVisualStyles = false;
            this.empDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.empDGV.Location = new System.Drawing.Point(0, 0);
            this.empDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empDGV.MultiSelect = false;
            this.empDGV.Name = "empDGV";
            this.empDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empDGV.RowHeadersWidth = 62;
            this.empDGV.RowTemplate.Height = 25;
            this.empDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empDGV.Size = new System.Drawing.Size(930, 329);
            this.empDGV.TabIndex = 0;
            this.empDGV.DoubleClick += new System.EventHandler(this.empDGV_DoubleClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 8;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            this.clmID.Width = 150;
            // 
            // clmFirstName
            // 
            this.clmFirstName.DataPropertyName = "FirstName";
            this.clmFirstName.HeaderText = "FirstName";
            this.clmFirstName.MinimumWidth = 8;
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            this.clmFirstName.Width = 150;
            // 
            // clmLastName
            // 
            this.clmLastName.DataPropertyName = "LastName";
            this.clmLastName.HeaderText = "LastName";
            this.clmLastName.MinimumWidth = 8;
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            this.clmLastName.Width = 150;
            // 
            // clmPosition
            // 
            this.clmPosition.DataPropertyName = "Position";
            this.clmPosition.HeaderText = "Position";
            this.clmPosition.MinimumWidth = 8;
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 150;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.DataPropertyName = "PhoneNumber";
            this.clmPhoneNumber.HeaderText = "PhoneNumber";
            this.clmPhoneNumber.MinimumWidth = 8;
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            this.clmPhoneNumber.Width = 150;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "Email";
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.MinimumWidth = 8;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 150;
            // 
            // mnuGrid
            // 
            this.mnuGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mnuGrid.Name = "mnuGrid";
            this.mnuGrid.Size = new System.Drawing.Size(103, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem2.Text = "111";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem3.Text = "222";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem4.Text = "333";
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 329);
            this.Controls.Add(this.empDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EmployeesListForm";
            this.Text = "EmployeesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.mnuGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.ContextMenuStrip mnuGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}