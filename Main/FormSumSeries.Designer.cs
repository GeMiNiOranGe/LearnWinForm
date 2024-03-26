namespace Main {
    partial class FormSumSeries {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.inputN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxResultPower = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNumPowerNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxXPowerNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(81, 37);
            this.inputN.Margin = new System.Windows.Forms.Padding(4);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(226, 22);
            this.inputN.TabIndex = 0;
            this.inputN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input N:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sum:";
            // 
            // outputResult
            // 
            this.outputResult.Location = new System.Drawing.Point(51, 111);
            this.outputResult.Margin = new System.Windows.Forms.Padding(4);
            this.outputResult.Name = "outputResult";
            this.outputResult.ReadOnly = true;
            this.outputResult.Size = new System.Drawing.Size(237, 22);
            this.outputResult.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Para input (default): 0";
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(81, 67);
            this.inputX.Margin = new System.Windows.Forms.Padding(4);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(226, 22);
            this.inputX.TabIndex = 1;
            this.inputX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Input X power N";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxXPowerNum);
            this.groupBox1.Controls.Add(this.txtBoxResultPower);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxNumPowerNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.outputResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sum:";
            // 
            // txtBoxResultPower
            // 
            this.txtBoxResultPower.Location = new System.Drawing.Point(51, 81);
            this.txtBoxResultPower.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxResultPower.Name = "txtBoxResultPower";
            this.txtBoxResultPower.ReadOnly = true;
            this.txtBoxResultPower.Size = new System.Drawing.Size(237, 22);
            this.txtBoxResultPower.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sum:";
            // 
            // txtBoxNumPowerNum
            // 
            this.txtBoxNumPowerNum.Location = new System.Drawing.Point(51, 51);
            this.txtBoxNumPowerNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNumPowerNum.Name = "txtBoxNumPowerNum";
            this.txtBoxNumPowerNum.ReadOnly = true;
            this.txtBoxNumPowerNum.Size = new System.Drawing.Size(237, 22);
            this.txtBoxNumPowerNum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sum:";
            // 
            // txtBoxXPowerNum
            // 
            this.txtBoxXPowerNum.Location = new System.Drawing.Point(51, 21);
            this.txtBoxXPowerNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxXPowerNum.Name = "txtBoxXPowerNum";
            this.txtBoxXPowerNum.ReadOnly = true;
            this.txtBoxXPowerNum.Size = new System.Drawing.Size(237, 22);
            this.txtBoxXPowerNum.TabIndex = 1;
            // 
            // frmSumSeries
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.inputN);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSumSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sum series";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxXPowerNum;
        private System.Windows.Forms.TextBox txtBoxResultPower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNumPowerNum;
        private System.Windows.Forms.Label label7;
    }
}