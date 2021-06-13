
namespace Planner
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskControl));
            this.titleLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(8, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 17);
            this.titleLabel.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkButton.BackgroundImage")));
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkButton.Location = new System.Drawing.Point(237, 8);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(35, 30);
            this.checkButton.TabIndex = 3;
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(11, 37);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 17);
            this.descriptionLabel.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(247, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(25, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(214, 67);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(25, 25);
            this.editButton.TabIndex = 9;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(14, 84);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(0, 13);
            this.dueDateLabel.TabIndex = 10;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(280, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label dueDateLabel;
    }
}
