namespace Main {
    partial class FormSimpleCalculator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox1st = new System.Windows.Forms.TextBox();
            this.txtBox2nd = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnSum = new System.Windows.Forms.RadioButton();
            this.radioBtnSubtract = new System.Windows.Forms.RadioButton();
            this.radioBtnMultiplication = new System.Windows.Forms.RadioButton();
            this.radioBtnDivision = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.grBoxOperator = new System.Windows.Forms.GroupBox();
            this.grBoxOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st para:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2nd para:";
            // 
            // txtBox1st
            // 
            this.txtBox1st.Location = new System.Drawing.Point(83, 12);
            this.txtBox1st.Name = "txtBox1st";
            this.txtBox1st.Size = new System.Drawing.Size(170, 22);
            this.txtBox1st.TabIndex = 0;
            this.txtBox1st.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // txtBox2nd
            // 
            this.txtBox2nd.Location = new System.Drawing.Point(83, 42);
            this.txtBox2nd.Name = "txtBox2nd";
            this.txtBox2nd.Size = new System.Drawing.Size(170, 22);
            this.txtBox2nd.TabIndex = 1;
            this.txtBox2nd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(83, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(170, 22);
            this.txtResult.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result:";
            // 
            // radioBtnSum
            // 
            this.radioBtnSum.AutoSize = true;
            this.radioBtnSum.Location = new System.Drawing.Point(6, 22);
            this.radioBtnSum.Name = "radioBtnSum";
            this.radioBtnSum.Size = new System.Drawing.Size(54, 20);
            this.radioBtnSum.TabIndex = 0;
            this.radioBtnSum.TabStop = true;
            this.radioBtnSum.Text = "Sum";
            this.radioBtnSum.UseVisualStyleBackColor = true;
            // 
            // radioBtnSubtract
            // 
            this.radioBtnSubtract.AutoSize = true;
            this.radioBtnSubtract.Location = new System.Drawing.Point(6, 48);
            this.radioBtnSubtract.Name = "radioBtnSubtract";
            this.radioBtnSubtract.Size = new System.Drawing.Size(78, 20);
            this.radioBtnSubtract.TabIndex = 1;
            this.radioBtnSubtract.TabStop = true;
            this.radioBtnSubtract.Text = "Subtract";
            this.radioBtnSubtract.UseVisualStyleBackColor = true;
            // 
            // radioBtnMultiplication
            // 
            this.radioBtnMultiplication.AutoSize = true;
            this.radioBtnMultiplication.Location = new System.Drawing.Point(6, 74);
            this.radioBtnMultiplication.Name = "radioBtnMultiplication";
            this.radioBtnMultiplication.Size = new System.Drawing.Size(108, 20);
            this.radioBtnMultiplication.TabIndex = 2;
            this.radioBtnMultiplication.TabStop = true;
            this.radioBtnMultiplication.Text = "Multiplication";
            this.radioBtnMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioBtnDivision
            // 
            this.radioBtnDivision.AutoSize = true;
            this.radioBtnDivision.Location = new System.Drawing.Point(6, 100);
            this.radioBtnDivision.Name = "radioBtnDivision";
            this.radioBtnDivision.Size = new System.Drawing.Size(74, 20);
            this.radioBtnDivision.TabIndex = 3;
            this.radioBtnDivision.TabStop = true;
            this.radioBtnDivision.Text = "Division";
            this.radioBtnDivision.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Para input (default): 0";
            // 
            // grBoxOperator
            // 
            this.grBoxOperator.Controls.Add(this.radioBtnSum);
            this.grBoxOperator.Controls.Add(this.radioBtnMultiplication);
            this.grBoxOperator.Controls.Add(this.radioBtnSubtract);
            this.grBoxOperator.Controls.Add(this.radioBtnDivision);
            this.grBoxOperator.Location = new System.Drawing.Point(259, 5);
            this.grBoxOperator.Name = "grBoxOperator";
            this.grBoxOperator.Size = new System.Drawing.Size(119, 123);
            this.grBoxOperator.TabIndex = 5;
            this.grBoxOperator.TabStop = false;
            this.grBoxOperator.Text = "Operator";
            // 
            // frmSimpleCalculate
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 139);
            this.Controls.Add(this.grBoxOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtBox2nd);
            this.Controls.Add(this.txtBox1st);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSimpleCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple calculate";
            this.grBoxOperator.ResumeLayout(false);
            this.grBoxOperator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox1st;
        private System.Windows.Forms.TextBox txtBox2nd;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnSum;
        private System.Windows.Forms.RadioButton radioBtnSubtract;
        private System.Windows.Forms.RadioButton radioBtnMultiplication;
        private System.Windows.Forms.RadioButton radioBtnDivision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grBoxOperator;
    }
}