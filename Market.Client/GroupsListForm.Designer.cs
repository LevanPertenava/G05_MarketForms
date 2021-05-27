
namespace Market.Client
{
    partial class GroupsListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupsDGV = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsDGV
            // 
            this.groupsDGV.AllowUserToAddRows = false;
            this.groupsDGV.AllowUserToDeleteRows = false;
            this.groupsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmGroupName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.groupsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsDGV.EnableHeadersVisualStyles = false;
            this.groupsDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupsDGV.Location = new System.Drawing.Point(0, 0);
            this.groupsDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsDGV.MultiSelect = false;
            this.groupsDGV.Name = "groupsDGV";
            this.groupsDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.groupsDGV.RowHeadersWidth = 62;
            this.groupsDGV.RowTemplate.Height = 25;
            this.groupsDGV.Size = new System.Drawing.Size(800, 450);
            this.groupsDGV.TabIndex = 1;
            this.groupsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empDGV_RowHeaderMouseClick);
            this.groupsDGV.DoubleClick += new System.EventHandler(this.empDGV_DoubleClick);
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
            // clmGroupName
            // 
            this.clmGroupName.DataPropertyName = "Name";
            this.clmGroupName.HeaderText = "Name";
            this.clmGroupName.MinimumWidth = 8;
            this.clmGroupName.Name = "clmGroupName";
            this.clmGroupName.ReadOnly = true;
            this.clmGroupName.Width = 150;
            // 
            // GroupsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupsDGV);
            this.Name = "GroupsListForm";
            this.Text = "GroupsListForm";
            this.Load += new System.EventHandler(this.GroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGroupName;
    }
}