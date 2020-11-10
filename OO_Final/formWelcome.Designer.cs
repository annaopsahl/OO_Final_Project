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
            this.labelCurrentSchedule = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1101, 297);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(146, 50);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
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
            // labelCurrentSchedule
            // 
            this.labelCurrentSchedule.AutoSize = true;
            this.labelCurrentSchedule.Location = new System.Drawing.Point(51, 56);
            this.labelCurrentSchedule.Name = "labelCurrentSchedule";
            this.labelCurrentSchedule.Size = new System.Drawing.Size(350, 32);
            this.labelCurrentSchedule.TabIndex = 4;
            this.labelCurrentSchedule.Text = "Current Schedule Starting:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(407, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(291, 32);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "[No schedule created]";
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 384);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCurrentSchedule);
            this.Controls.Add(this.buttonViewGroceryList);
            this.Controls.Add(this.buttonNewSchedule);
            this.Controls.Add(this.buttonViewSchedule);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "FormWelcome";
            this.Text = "Welcome! ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonNewSchedule;
        private System.Windows.Forms.Button buttonViewGroceryList;
        private System.Windows.Forms.Label labelCurrentSchedule;
        private System.Windows.Forms.Label labelDate;
    }
}