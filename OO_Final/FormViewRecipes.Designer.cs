namespace OO_Final
{
    partial class FormViewRecipes
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRecipes = new System.Windows.Forms.ComboBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(115, 185);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(325, 74);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a recipe to see instructions and ingredients!";
            // 
            // comboBoxRecipes
            // 
            this.comboBoxRecipes.FormattingEnabled = true;
            this.comboBoxRecipes.Location = new System.Drawing.Point(66, 88);
            this.comboBoxRecipes.Name = "comboBoxRecipes";
            this.comboBoxRecipes.Size = new System.Drawing.Size(765, 39);
            this.comboBoxRecipes.TabIndex = 3;
            this.comboBoxRecipes.Text = "Select Recipe";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(506, 185);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(325, 74);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // FormViewRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 328);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.comboBoxRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormViewRecipes";
            this.Text = "View Recipes";
            this.Load += new System.EventHandler(this.FormViewRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecipes;
        private System.Windows.Forms.Button buttonView;
    }
}