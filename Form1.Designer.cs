namespace FigurUppgifter
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
            lbl_fignr = new Label();
            lbl_name = new Label();
            hScrollBar = new HScrollBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_fignr
            // 
            lbl_fignr.AutoSize = true;
            lbl_fignr.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fignr.Location = new Point(738, 9);
            lbl_fignr.MinimumSize = new Size(37, 30);
            lbl_fignr.Name = "lbl_fignr";
            lbl_fignr.Size = new Size(37, 30);
            lbl_fignr.TabIndex = 0;
            lbl_fignr.Text = "00";
            lbl_fignr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe Print", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.Location = new Point(12, 1);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(209, 38);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "Namn Namnsson";
            // 
            // hScrollBar
            // 
            hScrollBar.LargeChange = 1;
            hScrollBar.Location = new Point(9, 39);
            hScrollBar.Maximum = 32;
            hScrollBar.Minimum = 1;
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new Size(766, 17);
            hScrollBar.TabIndex = 6;
            hScrollBar.Value = 1;
            hScrollBar.ValueChanged += hScrollBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 7;
            label1.Text = "Figurnummer:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(hScrollBar);
            Controls.Add(lbl_name);
            Controls.Add(lbl_fignr);
            Name = "Form1";
            Text = "Figurnummer:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_fignr;
        private Label lbl_name;
        private HScrollBar hScrollBar;
        private Label label1;
    }
}