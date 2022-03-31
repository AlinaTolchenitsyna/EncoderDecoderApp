
namespace EncodDecod
{
    partial class FormHelp
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp.Location = new System.Drawing.Point(0, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(330, 70);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "Программа разработана\r\nСтудентом группы 23-Д9-2ИСП\r\nТолченицыной А. А.\r\nВ качеств" +
    "е индивидуального проекта приложения";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 70);
            this.Controls.Add(this.labelHelp);
            this.MaximizeBox = false;
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelp;
    }
}