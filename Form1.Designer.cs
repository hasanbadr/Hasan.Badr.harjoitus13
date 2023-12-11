namespace Hasan.Badr.harjoitus13
{
    partial class SuosikkiForm
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
            label1 = new Label();
            VastausLB = new Label();
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(602, 30);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(12, 60);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(83, 30);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(621, 6);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(272, 35);
            NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(792, 50);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(101, 40);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // SuosikkiForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 101);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SuosikkiForm";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button TarkastaBT;
    }
}