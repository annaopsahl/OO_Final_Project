namespace OO_Final
{
    partial class FormViewList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAmount,
            this.ColumnIngredient});
            this.dataGridView1.Location = new System.Drawing.Point(81, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(874, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.MinimumWidth = 12;
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.Width = 167;
            // 
            // ColumnIngredient
            // 
            this.ColumnIngredient.HeaderText = "Ingredient";
            this.ColumnIngredient.MinimumWidth = 12;
            this.ColumnIngredient.Name = "ColumnIngredient";
            this.ColumnIngredient.Width = 196;
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Location = new System.Drawing.Point(306, 62);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(649, 39);
            this.comboBoxSchedule.TabIndex = 1;
            this.comboBoxSchedule.Text = "Select Schedule";
            this.comboBoxSchedule.SelectedIndexChanged += new System.EventHandler(this.comboBoxSchedule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schedule Name:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(792, 685);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(163, 83);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 956);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSchedule);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormViewList";
            this.Text = "Grocery List";
            this.Load += new System.EventHandler(this.FormViewList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIngredient;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
    }
}