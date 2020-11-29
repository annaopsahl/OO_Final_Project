namespace OO_Final
{
    partial class FormAddRecipe
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.richTextBoxInstructions = new System.Windows.Forms.RichTextBox();
            this.buttonAddIngredients = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(119, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(203, 53);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(754, 38);
            this.textTitle.TabIndex = 1;
            this.textTitle.TextChanged += new System.EventHandler(this.textTitle_TextChanged);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(29, 117);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(168, 32);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Instructions:";
            // 
            // richTextBoxInstructions
            // 
            this.richTextBoxInstructions.Location = new System.Drawing.Point(203, 117);
            this.richTextBoxInstructions.Name = "richTextBoxInstructions";
            this.richTextBoxInstructions.Size = new System.Drawing.Size(754, 329);
            this.richTextBoxInstructions.TabIndex = 3;
            this.richTextBoxInstructions.Text = "";
            // 
            // buttonAddIngredients
            // 
            this.buttonAddIngredients.Enabled = false;
            this.buttonAddIngredients.Location = new System.Drawing.Point(203, 462);
            this.buttonAddIngredients.Name = "buttonAddIngredients";
            this.buttonAddIngredients.Size = new System.Drawing.Size(754, 61);
            this.buttonAddIngredients.TabIndex = 4;
            this.buttonAddIngredients.Text = "Add Ingredients";
            this.buttonAddIngredients.UseVisualStyleBackColor = true;
            this.buttonAddIngredients.Click += new System.EventHandler(this.buttonAddIngredients_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(797, 554);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 53);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(615, 554);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 53);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.ForeColor = System.Drawing.Color.Crimson;
            this.labelDone.Location = new System.Drawing.Point(106, 477);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(91, 32);
            this.labelDone.TabIndex = 7;
            this.labelDone.Text = "Done!";
            this.labelDone.Visible = false;
            // 
            // FormAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 650);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddIngredients);
            this.Controls.Add(this.richTextBoxInstructions);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormAddRecipe";
            this.Text = "Add Recipe";
            this.Load += new System.EventHandler(this.FormAddRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.RichTextBox richTextBoxInstructions;
        private System.Windows.Forms.Button buttonAddIngredients;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDone;
    }
}