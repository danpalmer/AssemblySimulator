namespace Assembly_Simulator
{
    partial class ValidationWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.rad = new Assembly_Simulator.EnhancedTextBox();
            this.evd = new Assembly_Simulator.EnhancedTextBox();
            this.rah = new Assembly_Simulator.EnhancedTextBox();
            this.evh = new Assembly_Simulator.EnhancedTextBox();
            this.rab = new Assembly_Simulator.EnhancedTextBox();
            this.evb = new Assembly_Simulator.EnhancedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxLabel = new Assembly_Simulator.EnhancedTextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hexadecimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exact Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "RAM Address:";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK.Location = new System.Drawing.Point(336, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "Insert";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(99, 63);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(100, 21);
            this.rad.TabIndex = 2;
            this.rad.TextChanged += new System.EventHandler(this.rad_TextChanged);
            // 
            // evd
            // 
            this.evd.Location = new System.Drawing.Point(99, 34);
            this.evd.Name = "evd";
            this.evd.Size = new System.Drawing.Size(100, 21);
            this.evd.TabIndex = 1;
            this.evd.TextChanged += new System.EventHandler(this.evd_TextChanged);
            // 
            // rah
            // 
            this.rah.Location = new System.Drawing.Point(311, 63);
            this.rah.Name = "rah";
            this.rah.ReadOnly = true;
            this.rah.Size = new System.Drawing.Size(100, 21);
            this.rah.TabIndex = 10;
            this.rah.TabStop = false;
            // 
            // evh
            // 
            this.evh.Location = new System.Drawing.Point(311, 34);
            this.evh.Name = "evh";
            this.evh.ReadOnly = true;
            this.evh.Size = new System.Drawing.Size(100, 21);
            this.evh.TabIndex = 9;
            this.evh.TabStop = false;
            // 
            // rab
            // 
            this.rab.Location = new System.Drawing.Point(205, 63);
            this.rab.Name = "rab";
            this.rab.ReadOnly = true;
            this.rab.Size = new System.Drawing.Size(100, 21);
            this.rab.TabIndex = 8;
            this.rab.TabStop = false;
            // 
            // evb
            // 
            this.evb.Location = new System.Drawing.Point(205, 34);
            this.evb.Name = "evb";
            this.evb.ReadOnly = true;
            this.evb.Size = new System.Drawing.Size(100, 21);
            this.evb.TabIndex = 6;
            this.evb.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(255, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxLabel
            // 
            this.textboxLabel.Location = new System.Drawing.Point(99, 105);
            this.textboxLabel.Name = "textboxLabel";
            this.textboxLabel.Size = new System.Drawing.Size(100, 21);
            this.textboxLabel.TabIndex = 12;
            this.textboxLabel.Visible = false;
            this.textboxLabel.TextChanged += new System.EventHandler(this.textboxLabel_TextChanged);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Location = new System.Drawing.Point(52, 108);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(41, 15);
            this.labelLabel.TabIndex = 13;
            this.labelLabel.Text = "Label:";
            this.labelLabel.Visible = false;
            // 
            // ValidationWindow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(439, 175);
            this.ControlBox = false;
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.textboxLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.evd);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.rah);
            this.Controls.Add(this.evh);
            this.Controls.Add(this.rab);
            this.Controls.Add(this.evb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidationWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(121)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOK;
        internal EnhancedTextBox evb;
        internal EnhancedTextBox rab;
        internal EnhancedTextBox evh;
        internal EnhancedTextBox rah;
        private EnhancedTextBox evd;
        private EnhancedTextBox rad;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLabel;
        public EnhancedTextBox textboxLabel;
    }
}