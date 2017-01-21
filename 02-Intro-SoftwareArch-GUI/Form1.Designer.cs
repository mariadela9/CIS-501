namespace Intro_SoftwareArch_GUI
{
    partial class uxForm
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
            this.uxTextOne = new System.Windows.Forms.TextBox();
            this.uxButtonOne = new System.Windows.Forms.Button();
            this.uxLabelOne = new System.Windows.Forms.Label();
            this.uxLabelTwo = new System.Windows.Forms.Label();
            this.uxTextTwo = new System.Windows.Forms.TextBox();
            this.uxTextThree = new System.Windows.Forms.TextBox();
            this.uxButtonThree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxLabelThree = new System.Windows.Forms.Label();
            this.uxResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTextOne
            // 
            this.uxTextOne.Location = new System.Drawing.Point(321, 11);
            this.uxTextOne.Name = "uxTextOne";
            this.uxTextOne.Size = new System.Drawing.Size(58, 20);
            this.uxTextOne.TabIndex = 0;
            // 
            // uxButtonOne
            // 
            this.uxButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonOne.Location = new System.Drawing.Point(396, 7);
            this.uxButtonOne.Name = "uxButtonOne";
            this.uxButtonOne.Size = new System.Drawing.Size(68, 26);
            this.uxButtonOne.TabIndex = 1;
            this.uxButtonOne.Text = "Enter";
            this.uxButtonOne.UseVisualStyleBackColor = true;
            this.uxButtonOne.Click += new System.EventHandler(this.uxButtonOne_Click);
            // 
            // uxLabelOne
            // 
            this.uxLabelOne.AutoSize = true;
            this.uxLabelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelOne.Location = new System.Drawing.Point(36, 11);
            this.uxLabelOne.Name = "uxLabelOne";
            this.uxLabelOne.Size = new System.Drawing.Size(0, 18);
            this.uxLabelOne.TabIndex = 2;
            // 
            // uxLabelTwo
            // 
            this.uxLabelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelTwo.Location = new System.Drawing.Point(15, 34);
            this.uxLabelTwo.Name = "uxLabelTwo";
            this.uxLabelTwo.Size = new System.Drawing.Size(338, 43);
            this.uxLabelTwo.TabIndex = 3;
            this.uxLabelTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxTextTwo
            // 
            this.uxTextTwo.Location = new System.Drawing.Point(321, 40);
            this.uxTextTwo.Name = "uxTextTwo";
            this.uxTextTwo.Size = new System.Drawing.Size(58, 20);
            this.uxTextTwo.TabIndex = 4;
            // 
            // uxTextThree
            // 
            this.uxTextThree.Location = new System.Drawing.Point(456, 81);
            this.uxTextThree.Name = "uxTextThree";
            this.uxTextThree.Size = new System.Drawing.Size(58, 20);
            this.uxTextThree.TabIndex = 5;
            // 
            // uxButtonThree
            // 
            this.uxButtonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonThree.Location = new System.Drawing.Point(529, 76);
            this.uxButtonThree.Name = "uxButtonThree";
            this.uxButtonThree.Size = new System.Drawing.Size(68, 26);
            this.uxButtonThree.TabIndex = 7;
            this.uxButtonThree.Text = "Enter";
            this.uxButtonThree.UseVisualStyleBackColor = true;
            this.uxButtonThree.Click += new System.EventHandler(this.uxButtonThree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // uxLabelThree
            // 
            this.uxLabelThree.AutoSize = true;
            this.uxLabelThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelThree.Location = new System.Drawing.Point(36, 83);
            this.uxLabelThree.Name = "uxLabelThree";
            this.uxLabelThree.Size = new System.Drawing.Size(0, 20);
            this.uxLabelThree.TabIndex = 9;
            // 
            // uxResult
            // 
            this.uxResult.AutoSize = true;
            this.uxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResult.Location = new System.Drawing.Point(284, 139);
            this.uxResult.Name = "uxResult";
            this.uxResult.Size = new System.Drawing.Size(0, 24);
            this.uxResult.TabIndex = 10;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 195);
            this.Controls.Add(this.uxResult);
            this.Controls.Add(this.uxLabelThree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxButtonThree);
            this.Controls.Add(this.uxTextThree);
            this.Controls.Add(this.uxTextTwo);
            this.Controls.Add(this.uxLabelTwo);
            this.Controls.Add(this.uxLabelOne);
            this.Controls.Add(this.uxButtonOne);
            this.Controls.Add(this.uxTextOne);
            this.Name = "uxForm";
            this.Text = "Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextOne;
        private System.Windows.Forms.Button uxButtonOne;
        private System.Windows.Forms.Label uxLabelOne;
        private System.Windows.Forms.Label uxLabelTwo;
        private System.Windows.Forms.TextBox uxTextTwo;
        private System.Windows.Forms.TextBox uxTextThree;
        private System.Windows.Forms.Button uxButtonThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxLabelThree;
        private System.Windows.Forms.Label uxResult;
    }
}

