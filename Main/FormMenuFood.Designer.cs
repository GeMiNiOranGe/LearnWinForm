namespace Main {
    partial class FormMenuFood {
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
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMenuAdded = new System.Windows.Forms.ListBox();
            this.txtBoxNameFood = new System.Windows.Forms.TextBox();
            this.listBoxMenuChoose = new System.Windows.Forms.ListBox();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(334, 12);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(80, 30);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name food";
            // 
            // listBoxMenuAdded
            // 
            this.listBoxMenuAdded.FormattingEnabled = true;
            this.listBoxMenuAdded.ItemHeight = 16;
            this.listBoxMenuAdded.Items.AddRange(new object[] {
            "Apple",
            "Fish fried",
            "Bread",
            "Salad",
            "Orange",
            "Lemon",
            "Pizza",
            "Sandwich",
            "Hotdog",
            "Hamburger"});
            this.listBoxMenuAdded.Location = new System.Drawing.Point(12, 52);
            this.listBoxMenuAdded.Name = "listBoxMenuAdded";
            this.listBoxMenuAdded.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMenuAdded.Size = new System.Drawing.Size(175, 340);
            this.listBoxMenuAdded.TabIndex = 2;
            // 
            // txtBoxNameFood
            // 
            this.txtBoxNameFood.Location = new System.Drawing.Point(94, 16);
            this.txtBoxNameFood.Name = "txtBoxNameFood";
            this.txtBoxNameFood.Size = new System.Drawing.Size(234, 22);
            this.txtBoxNameFood.TabIndex = 0;
            // 
            // listBoxMenuChoose
            // 
            this.listBoxMenuChoose.FormattingEnabled = true;
            this.listBoxMenuChoose.ItemHeight = 16;
            this.listBoxMenuChoose.Location = new System.Drawing.Point(239, 52);
            this.listBoxMenuChoose.Name = "listBoxMenuChoose";
            this.listBoxMenuChoose.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMenuChoose.Size = new System.Drawing.Size(175, 340);
            this.listBoxMenuChoose.TabIndex = 2;
            // 
            // btnAddOne
            // 
            this.btnAddOne.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOne.Location = new System.Drawing.Point(193, 127);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(40, 40);
            this.btnAddOne.TabIndex = 2;
            this.btnAddOne.Text = ">";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Location = new System.Drawing.Point(193, 173);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(40, 40);
            this.btnAddAll.TabIndex = 3;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOne.Location = new System.Drawing.Point(193, 219);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveOne.TabIndex = 4;
            this.btnRemoveOne.Text = "<";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(193, 265);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // frmMenuFood
            // 
            this.AcceptButton = this.btnAddFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 405);
            this.Controls.Add(this.txtBoxNameFood);
            this.Controls.Add(this.listBoxMenuChoose);
            this.Controls.Add(this.listBoxMenuAdded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnAddFood);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenuFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMenuAdded;
        private System.Windows.Forms.TextBox txtBoxNameFood;
        private System.Windows.Forms.ListBox listBoxMenuChoose;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}