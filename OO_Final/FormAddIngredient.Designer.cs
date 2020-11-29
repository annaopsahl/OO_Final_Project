namespace OO_Final
{
    partial class FormAddIngredient
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
            this.labelIngredient = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxIngredient = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonAddToRecipe = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelAdded = new System.Windows.Forms.Label();
            this.labelIngredientAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Location = new System.Drawing.Point(64, 77);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(150, 32);
            this.labelIngredient.TabIndex = 0;
            this.labelIngredient.Text = "Ingredient:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(93, 146);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(121, 32);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Amount:";
            // 
            // textBoxIngredient
            // 
            this.textBoxIngredient.Location = new System.Drawing.Point(233, 77);
            this.textBoxIngredient.Name = "textBoxIngredient";
            this.textBoxIngredient.Size = new System.Drawing.Size(489, 38);
            this.textBoxIngredient.TabIndex = 2;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(233, 146);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(489, 38);
            this.textBoxAmount.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(221, 215);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(240, 88);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Done!";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonAddToRecipe
            // 
            this.buttonAddToRecipe.Location = new System.Drawing.Point(482, 215);
            this.buttonAddToRecipe.Name = "buttonAddToRecipe";
            this.buttonAddToRecipe.Size = new System.Drawing.Size(240, 88);
            this.buttonAddToRecipe.TabIndex = 5;
            this.buttonAddToRecipe.Text = "Add To Recipe";
            this.buttonAddToRecipe.UseVisualStyleBackColor = true;
            this.buttonAddToRecipe.Click += new System.EventHandler(this.buttonAddToRecipe_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(64, 22);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(678, 32);
            this.labelInstructions.TabIndex = 6;
            this.labelInstructions.Text = "Add all ingredients separately, click \"Done!\" to finish.";
            // 
            // labelAdded
            // 
            this.labelAdded.AutoSize = true;
            this.labelAdded.Location = new System.Drawing.Point(108, 342);
            this.labelAdded.Name = "labelAdded";
            this.labelAdded.Size = new System.Drawing.Size(106, 32);
            this.labelAdded.TabIndex = 7;
            this.labelAdded.Text = "Added:";
            this.labelAdded.Visible = false;
            // 
            // labelIngredientAdded
            // 
            this.labelIngredientAdded.AutoSize = true;
            this.labelIngredientAdded.Location = new System.Drawing.Point(215, 342);
            this.labelIngredientAdded.Name = "labelIngredientAdded";
            this.labelIngredientAdded.Size = new System.Drawing.Size(171, 32);
            this.labelIngredientAdded.TabIndex = 8;
            this.labelIngredientAdded.Text = "[change me]";
            this.labelIngredientAdded.Visible = false;
            // 
            // FormAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.labelIngredientAdded);
            this.Controls.Add(this.labelAdded);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonAddToRecipe);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxIngredient);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelIngredient);
            this.Name = "FormAddIngredient";
            this.Text = "Add Ingredient";
            this.Load += new System.EventHandler(this.FormAddIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIngredient;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxIngredient;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonAddToRecipe;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelAdded;
        private System.Windows.Forms.Label labelIngredientAdded;
    }
}