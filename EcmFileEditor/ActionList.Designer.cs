namespace EcmFileEditor
{
    partial class ActionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ObjectsGrid = new System.Windows.Forms.DataGridView();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectsGrid
            // 
            this.ObjectsGrid.AllowDrop = true;
            this.ObjectsGrid.AllowUserToAddRows = false;
            this.ObjectsGrid.AllowUserToDeleteRows = false;
            this.ObjectsGrid.AllowUserToResizeColumns = false;
            this.ObjectsGrid.AllowUserToResizeRows = false;
            this.ObjectsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ObjectsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ObjectsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObjectsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ObjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ObjectsGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.ObjectsGrid.EnableHeadersVisualStyles = false;
            this.ObjectsGrid.Location = new System.Drawing.Point(0, 1);
            this.ObjectsGrid.Name = "ObjectsGrid";
            this.ObjectsGrid.ReadOnly = true;
            this.ObjectsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ObjectsGrid.RowHeadersVisible = false;
            this.ObjectsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjectsGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ObjectsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ObjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObjectsGrid.ShowCellErrors = false;
            this.ObjectsGrid.ShowCellToolTips = false;
            this.ObjectsGrid.ShowEditingIcon = false;
            this.ObjectsGrid.ShowRowErrors = false;
            this.ObjectsGrid.Size = new System.Drawing.Size(504, 330);
            this.ObjectsGrid.TabIndex = 27;
            this.ObjectsGrid.Tag = "3";
            // 
            // Accept
            // 
            this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept.Image = ((System.Drawing.Image)(resources.GetObject("Accept.Image")));
            this.Accept.Location = new System.Drawing.Point(0, 332);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(252, 42);
            this.Accept.TabIndex = 28;
            this.Accept.TabStop = false;
            this.Accept.Text = "Выбрать";
            this.Accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Accept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.Location = new System.Drawing.Point(252, 332);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(252, 42);
            this.Cancel.TabIndex = 29;
            this.Cancel.TabStop = false;
            this.Cancel.Text = "Отмена";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column2.FillWeight = 44.7233F;
            this.Column2.HeaderText = "Действие";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 155.5622F;
            this.Column5.HeaderText = "Модель";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 353;
            // 
            // ActionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 376);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ObjectsGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список действий";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView ObjectsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}