namespace Gomoku
{
    partial class GForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HumanvsComputer = new System.Windows.Forms.RadioButton();
            this.HumanvsHuman = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Fifteenx15 = new System.Windows.Forms.RadioButton();
            this.Tenx10 = new System.Windows.Forms.RadioButton();
            this.Fivex5 = new System.Windows.Forms.RadioButton();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Fifteenx15);
            this.panel1.Controls.Add(this.Tenx10);
            this.panel1.Controls.Add(this.Fivex5);
            this.panel1.Location = new System.Drawing.Point(31, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 115);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.HumanvsComputer);
            this.panel2.Controls.Add(this.HumanvsHuman);
            this.panel2.Location = new System.Drawing.Point(352, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 109);
            this.panel2.TabIndex = 4;
            // 
            // HumanvsComputer
            // 
            this.HumanvsComputer.AutoSize = true;
            this.HumanvsComputer.Location = new System.Drawing.Point(30, 69);
            this.HumanvsComputer.Name = "HumanvsComputer";
            this.HumanvsComputer.Size = new System.Drawing.Size(121, 17);
            this.HumanvsComputer.TabIndex = 3;
            this.HumanvsComputer.TabStop = true;
            this.HumanvsComputer.Text = "Human vs Computer";
            this.HumanvsComputer.UseVisualStyleBackColor = true;
            // 
            // HumanvsHuman
            // 
            this.HumanvsHuman.AutoSize = true;
            this.HumanvsHuman.Location = new System.Drawing.Point(30, 17);
            this.HumanvsHuman.Name = "HumanvsHuman";
            this.HumanvsHuman.Size = new System.Drawing.Size(108, 17);
            this.HumanvsHuman.TabIndex = 2;
            this.HumanvsHuman.TabStop = true;
            this.HumanvsHuman.Text = "Human vs human";
            this.HumanvsHuman.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Cyan;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Location = new System.Drawing.Point(142, 72);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(175, 40);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Fifteenx15
            // 
            this.Fifteenx15.AutoSize = true;
            this.Fifteenx15.Location = new System.Drawing.Point(214, 20);
            this.Fifteenx15.Name = "Fifteenx15";
            this.Fifteenx15.Size = new System.Drawing.Size(54, 17);
            this.Fifteenx15.TabIndex = 2;
            this.Fifteenx15.TabStop = true;
            this.Fifteenx15.Text = "15x15";
            this.Fifteenx15.UseVisualStyleBackColor = true;
            // 
            // Tenx10
            // 
            this.Tenx10.AutoSize = true;
            this.Tenx10.Location = new System.Drawing.Point(108, 20);
            this.Tenx10.Name = "Tenx10";
            this.Tenx10.Size = new System.Drawing.Size(54, 17);
            this.Tenx10.TabIndex = 1;
            this.Tenx10.TabStop = true;
            this.Tenx10.Text = "10x10";
            this.Tenx10.UseVisualStyleBackColor = true;
            // 
            // Fivex5
            // 
            this.Fivex5.AutoSize = true;
            this.Fivex5.Location = new System.Drawing.Point(12, 20);
            this.Fivex5.Name = "Fivex5";
            this.Fivex5.Size = new System.Drawing.Size(42, 17);
            this.Fivex5.TabIndex = 0;
            this.Fivex5.TabStop = true;
            this.Fivex5.Text = "5x5";
            this.Fivex5.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.BackColor = System.Drawing.SystemColors.ControlText;
            this.Grid.Location = new System.Drawing.Point(12, 137);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(992, 375);
            this.Grid.TabIndex = 1;
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1016, 524);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel1);
            this.Name = "GForm";
            this.Text = "Gomoku";
            this.Load += new System.EventHandler(this.GForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton Fifteenx15;
        private System.Windows.Forms.RadioButton Tenx10;
        private System.Windows.Forms.RadioButton Fivex5;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton HumanvsComputer;
        private System.Windows.Forms.RadioButton HumanvsHuman;
    }
}

