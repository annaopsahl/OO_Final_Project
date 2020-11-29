namespace OO_Final
{
    partial class FormWelcome
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.buttonNewSchedule = new System.Windows.Forms.Button();
            this.buttonViewGroceryList = new System.Windows.Forms.Button();
            this.labelTodaysDate = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonViewRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1101, 297);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(146, 75);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Location = new System.Drawing.Point(458, 125);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(373, 153);
            this.buttonViewSchedule.TabIndex = 1;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonNewSchedule
            // 
            this.buttonNewSchedule.Location = new System.Drawing.Point(42, 125);
            this.buttonNewSchedule.Name = "buttonNewSchedule";
            this.buttonNewSchedule.Size = new System.Drawing.Size(373, 153);
            this.buttonNewSchedule.TabIndex = 2;
            this.buttonNewSchedule.Text = "New Schedule";
            this.buttonNewSchedule.UseVisualStyleBackColor = true;
            this.buttonNewSchedule.Click += new System.EventHandler(this.buttonNewSchedule_Click);
            // 
            // buttonViewGroceryList
            // 
            this.buttonViewGroceryList.Location = new System.Drawing.Point(874, 125);
            this.buttonViewGroceryList.Name = "buttonViewGroceryList";
            this.buttonViewGroceryList.Size = new System.Drawing.Size(373, 153);
            this.buttonViewGroceryList.TabIndex = 3;
            this.buttonViewGroceryList.Text = "ViewGroceryList";
            this.buttonViewGroceryList.UseVisualStyleBackColor = true;
            // 
            // labelTodaysDate
            // 
            this.labelTodaysDate.AutoSize = true;
            this.labelTodaysDate.Location = new System.Drawing.Point(36, 49);
            this.labelTodaysDate.Name = "labelTodaysDate";
            this.labelTodaysDate.Size = new System.Drawing.Size(212, 32);
            this.labelTodaysDate.TabIndex = 4;
            this.labelTodaysDate.Text = "Today\'s date is:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(254, 49);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 32);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "[blank]";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(724, 297);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(319, 75);
            this.buttonAddRecipe.TabIndex = 7;
            this.buttonAddRecipe.Text = "Add New Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // buttonViewRecipes
            // 
            this.buttonViewRecipes.Location = new System.Drawing.Point(355, 297);
            this.buttonViewRecipes.Name = "buttonViewRecipes";
            this.buttonViewRecipes.Size = new System.Drawing.Size(319, 75);
            this.buttonViewRecipes.TabIndex = 8;
            this.buttonViewRecipes.Text = "View All Recipes";
            this.buttonViewRecipes.UseVisualStyleBackColor = true;
            this.buttonViewRecipes.Click += new System.EventHandler(this.buttonViewRecipes_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 415);
            this.Controls.Add(this.buttonViewRecipes);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTodaysDate);
            this.Controls.Add(this.buttonViewGroceryList);
            this.Controls.Add(this.buttonNewSchedule);
            this.Controls.Add(this.buttonViewSchedule);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "FormWelcome";
            this.Text = "Welcome! ";
            this.Load += new System.EventHandler(this.FormWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonNewSchedule;
        private System.Windows.Forms.Button buttonViewGroceryList;
        private System.Windows.Forms.Label labelTodaysDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonViewRecipes;
    }
}