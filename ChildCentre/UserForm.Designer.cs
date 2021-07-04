
namespace ChildCentre
{
    partial class UserForm
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
            this.ExitBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBotton
            // 
            this.ExitBotton.Location = new System.Drawing.Point(25, 383);
            this.ExitBotton.Name = "ExitBotton";
            this.ExitBotton.Size = new System.Drawing.Size(75, 23);
            this.ExitBotton.TabIndex = 0;
            this.ExitBotton.Text = "Выход";
            this.ExitBotton.UseVisualStyleBackColor = true;
            this.ExitBotton.Click += new System.EventHandler(this.ExitBotton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 468);
            this.Controls.Add(this.ExitBotton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "Личная страница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBotton;
    }
}