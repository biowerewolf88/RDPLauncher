namespace RDPLauncher
{
    partial class AboutForm
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
            lblInfo = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInfo.ImageAlign = ContentAlignment.TopCenter;
            lblInfo.Location = new Point(0, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(404, 261);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Информация";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(160, 226);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "ОК";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 261);
            Controls.Add(btnOK);
            Controls.Add(lblInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInfo;
        private Button btnOK;
    }
}