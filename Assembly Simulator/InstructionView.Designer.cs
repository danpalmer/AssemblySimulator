namespace Assembly_Simulator
{
    partial class InstructionView
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
            this.labelName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxOPERAND = new System.Windows.Forms.TextBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.radBefore = new System.Windows.Forms.RadioButton();
            this.radAfter = new System.Windows.Forms.RadioButton();
            this.radEnd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOPCODESmall = new System.Windows.Forms.Label();
            this.addInstruction = new System.Windows.Forms.Button();
            this.clearInstruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Location = new System.Drawing.Point(-1, -1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(297, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name Placeholder";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Label";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "OPERAND";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLabel.Location = new System.Drawing.Point(125, 31);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(68, 22);
            this.textBoxLabel.TabIndex = 13;
            // 
            // textBoxOPERAND
            // 
            this.textBoxOPERAND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOPERAND.Location = new System.Drawing.Point(125, 52);
            this.textBoxOPERAND.Name = "textBoxOPERAND";
            this.textBoxOPERAND.ReadOnly = true;
            this.textBoxOPERAND.Size = new System.Drawing.Size(68, 22);
            this.textBoxOPERAND.TabIndex = 12;
            this.textBoxOPERAND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxOPERAND_Click);
            // 
            // labelDetail
            // 
            this.labelDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDetail.Location = new System.Drawing.Point(6, 87);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(187, 103);
            this.labelDetail.TabIndex = 17;
            this.labelDetail.Text = "Details...";
            // 
            // radBefore
            // 
            this.radBefore.AutoSize = true;
            this.radBefore.Location = new System.Drawing.Point(205, 49);
            this.radBefore.Name = "radBefore";
            this.radBefore.Size = new System.Drawing.Size(59, 17);
            this.radBefore.TabIndex = 18;
            this.radBefore.Text = "Before";
            this.radBefore.UseVisualStyleBackColor = true;
            // 
            // radAfter
            // 
            this.radAfter.AutoSize = true;
            this.radAfter.Location = new System.Drawing.Point(205, 79);
            this.radAfter.Name = "radAfter";
            this.radAfter.Size = new System.Drawing.Size(50, 17);
            this.radAfter.TabIndex = 19;
            this.radAfter.Text = "After";
            this.radAfter.UseVisualStyleBackColor = true;
            // 
            // radEnd
            // 
            this.radEnd.AutoSize = true;
            this.radEnd.Checked = true;
            this.radEnd.Location = new System.Drawing.Point(205, 109);
            this.radEnd.Name = "radEnd";
            this.radEnd.Size = new System.Drawing.Size(59, 17);
            this.radEnd.TabIndex = 20;
            this.radEnd.TabStop = true;
            this.radEnd.Text = "At End";
            this.radEnd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Insert:";
            // 
            // labelOPCODESmall
            // 
            this.labelOPCODESmall.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelOPCODESmall.Location = new System.Drawing.Point(177, 2);
            this.labelOPCODESmall.Name = "labelOPCODESmall";
            this.labelOPCODESmall.Size = new System.Drawing.Size(115, 19);
            this.labelOPCODESmall.TabIndex = 22;
            this.labelOPCODESmall.Text = "OPCODE Placeholder";
            this.labelOPCODESmall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOPCODESmall.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // addInstruction
            // 
            this.addInstruction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addInstruction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInstruction.Location = new System.Drawing.Point(199, 161);
            this.addInstruction.Name = "addInstruction";
            this.addInstruction.Size = new System.Drawing.Size(87, 29);
            this.addInstruction.TabIndex = 23;
            this.addInstruction.Text = "Add";
            this.addInstruction.UseVisualStyleBackColor = false;
            this.addInstruction.Click += new System.EventHandler(this.addInstruction_Click);
            // 
            // clearInstruction
            // 
            this.clearInstruction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearInstruction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInstruction.Location = new System.Drawing.Point(199, 133);
            this.clearInstruction.Name = "clearInstruction";
            this.clearInstruction.Size = new System.Drawing.Size(87, 29);
            this.clearInstruction.TabIndex = 24;
            this.clearInstruction.Text = "Clear";
            this.clearInstruction.UseVisualStyleBackColor = false;
            this.clearInstruction.Click += new System.EventHandler(this.clearInstruction_Click);
            // 
            // InstructionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clearInstruction);
            this.Controls.Add(this.addInstruction);
            this.Controls.Add(this.labelOPCODESmall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radEnd);
            this.Controls.Add(this.radAfter);
            this.Controls.Add(this.radBefore);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxOPERAND);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InstructionView";
            this.Size = new System.Drawing.Size(295, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxOPERAND;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.RadioButton radBefore;
        private System.Windows.Forms.RadioButton radAfter;
        private System.Windows.Forms.RadioButton radEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOPCODESmall;
        private System.Windows.Forms.Button addInstruction;
        private System.Windows.Forms.Button clearInstruction;

    }
}
