namespace DemoWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnShowHelp = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Test_1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 79);
            btnSave.TabIndex = 1;
            btnSave.Text = "Enable";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(152, 27);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 79);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnShowHelp
            // 
            btnShowHelp.Location = new Point(295, 27);
            btnShowHelp.Name = "btnShowHelp";
            btnShowHelp.Size = new Size(118, 79);
            btnShowHelp.TabIndex = 3;
            btnShowHelp.Text = "button1";
            btnShowHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowHelp);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Demo Aplication";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnSave;
        private Button btnCancel;
        private Button btnShowHelp;
    }
}
