namespace WFA230926
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudSor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOszlop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAknaSzam = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAknaSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "sor:";
            // 
            // nudSor
            // 
            this.nudSor.Location = new System.Drawing.Point(156, 46);
            this.nudSor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSor.Name = "nudSor";
            this.nudSor.Size = new System.Drawing.Size(64, 26);
            this.nudSor.TabIndex = 1;
            this.nudSor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "oszlop:";
            // 
            // nudOszlop
            // 
            this.nudOszlop.Location = new System.Drawing.Point(156, 90);
            this.nudOszlop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOszlop.Name = "nudOszlop";
            this.nudOszlop.Size = new System.Drawing.Size(64, 26);
            this.nudOszlop.TabIndex = 1;
            this.nudOszlop.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "aknák száma:";
            // 
            // nudAknaSzam
            // 
            this.nudAknaSzam.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAknaSzam.Location = new System.Drawing.Point(156, 134);
            this.nudAknaSzam.Name = "nudAknaSzam";
            this.nudAknaSzam.Size = new System.Drawing.Size(64, 26);
            this.nudAknaSzam.TabIndex = 1;
            this.nudAknaSzam.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Játék indítása!";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 306);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudAknaSzam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudOszlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAknaSzam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOszlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAknaSzam;
        private System.Windows.Forms.Button btnStart;
    }
}

