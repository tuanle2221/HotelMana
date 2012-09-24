namespace HotelMana
{
    partial class Nhatky
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectAllEmployBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new HotelMana.dataDataSet();
            this.selectAllEmployTableAdapter = new HotelMana.dataDataSetTableAdapters.selectAllEmployTableAdapter();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ggiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllEmployBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng thuê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomDataGridViewTextBoxColumn,
            this.ffromDataGridViewTextBoxColumn,
            this.ttoDataGridViewTextBoxColumn,
            this.ttotalDataGridViewTextBoxColumn,
            this.ggiaDataGridViewTextBoxColumn,
            this.ccostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectAllEmployBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.GreenYellow;
            this.dataGridView1.Location = new System.Drawing.Point(18, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectAllEmployBindingSource
            // 
            this.selectAllEmployBindingSource.DataMember = "selectAllEmploy";
            this.selectAllEmployBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllEmployTableAdapter
            // 
            this.selectAllEmployTableAdapter.ClearBeforeFill = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 70;
            // 
            // ffromDataGridViewTextBoxColumn
            // 
            this.ffromDataGridViewTextBoxColumn.DataPropertyName = "ffrom";
            this.ffromDataGridViewTextBoxColumn.HeaderText = "Thời gian đến";
            this.ffromDataGridViewTextBoxColumn.Name = "ffromDataGridViewTextBoxColumn";
            this.ffromDataGridViewTextBoxColumn.ReadOnly = true;
            this.ffromDataGridViewTextBoxColumn.Width = 145;
            // 
            // ttoDataGridViewTextBoxColumn
            // 
            this.ttoDataGridViewTextBoxColumn.DataPropertyName = "tto";
            this.ttoDataGridViewTextBoxColumn.HeaderText = "Thời gian đi";
            this.ttoDataGridViewTextBoxColumn.Name = "ttoDataGridViewTextBoxColumn";
            this.ttoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ttoDataGridViewTextBoxColumn.Width = 145;
            // 
            // ttotalDataGridViewTextBoxColumn
            // 
            this.ttotalDataGridViewTextBoxColumn.DataPropertyName = "ttotal";
            this.ttotalDataGridViewTextBoxColumn.HeaderText = "Tổng thời gian";
            this.ttotalDataGridViewTextBoxColumn.Name = "ttotalDataGridViewTextBoxColumn";
            this.ttotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.ttotalDataGridViewTextBoxColumn.Width = 130;
            // 
            // ggiaDataGridViewTextBoxColumn
            // 
            this.ggiaDataGridViewTextBoxColumn.DataPropertyName = "ggia";
            this.ggiaDataGridViewTextBoxColumn.HeaderText = "Giá phòng 1 giờ (VNĐ)";
            this.ggiaDataGridViewTextBoxColumn.Name = "ggiaDataGridViewTextBoxColumn";
            this.ggiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ggiaDataGridViewTextBoxColumn.Width = 200;
            // 
            // ccostDataGridViewTextBoxColumn
            // 
            this.ccostDataGridViewTextBoxColumn.DataPropertyName = "ccost";
            this.ccostDataGridViewTextBoxColumn.HeaderText = "Thành tiền (VNĐ)";
            this.ccostDataGridViewTextBoxColumn.Name = "ccostDataGridViewTextBoxColumn";
            this.ccostDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccostDataGridViewTextBoxColumn.Width = 200;
            // 
            // Nhatky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 442);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhatky";
            this.Text = "Danh sách phòng cho thuê";
            this.Load += new System.EventHandler(this.Nhatky_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllEmployBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource selectAllEmployBindingSource;
        private HotelMana.dataDataSetTableAdapters.selectAllEmployTableAdapter selectAllEmployTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ggiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccostDataGridViewTextBoxColumn;
    }
}