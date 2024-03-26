namespace Main {
    partial class FormFindMinMax {
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
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInputA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInputB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxInputC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxOutputMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxOutputMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(151, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 50);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxInputC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxInputB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxInputA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txtBoxInputA
            // 
            this.txtBoxInputA.Location = new System.Drawing.Point(27, 24);
            this.txtBoxInputA.Name = "txtBoxInputA";
            this.txtBoxInputA.Size = new System.Drawing.Size(95, 22);
            this.txtBoxInputA.TabIndex = 0;
            this.txtBoxInputA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "B";
            // 
            // txtBoxInputB
            // 
            this.txtBoxInputB.Location = new System.Drawing.Point(27, 52);
            this.txtBoxInputB.Name = "txtBoxInputB";
            this.txtBoxInputB.Size = new System.Drawing.Size(95, 22);
            this.txtBoxInputB.TabIndex = 1;
            this.txtBoxInputB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "C";
            // 
            // txtBoxInputC
            // 
            this.txtBoxInputC.Location = new System.Drawing.Point(27, 80);
            this.txtBoxInputC.Name = "txtBoxInputC";
            this.txtBoxInputC.Size = new System.Drawing.Size(95, 22);
            this.txtBoxInputC.TabIndex = 2;
            this.txtBoxInputC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxOutputMin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxOutputMax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(207, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // txtBoxOutputMin
            // 
            this.txtBoxOutputMin.Location = new System.Drawing.Point(96, 52);
            this.txtBoxOutputMin.Name = "txtBoxOutputMin";
            this.txtBoxOutputMin.ReadOnly = true;
            this.txtBoxOutputMin.Size = new System.Drawing.Size(95, 22);
            this.txtBoxOutputMin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min number";
            // 
            // txtBoxOutputMax
            // 
            this.txtBoxOutputMax.Location = new System.Drawing.Point(96, 24);
            this.txtBoxOutputMax.Name = "txtBoxOutputMax";
            this.txtBoxOutputMax.ReadOnly = true;
            this.txtBoxOutputMax.Size = new System.Drawing.Size(95, 22);
            this.txtBoxOutputMax.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Para input (default): 0";
            // 
            // frmFindMinAndMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 131);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Montserrat", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFindMinAndMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find the smallest and largest number among 3 numbers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxInputB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInputA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInputC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxOutputMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxOutputMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}