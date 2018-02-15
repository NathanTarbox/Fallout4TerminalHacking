namespace Fallout4Helper
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnReduce = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLikeness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChosen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 42);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter New Word";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 178);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Best:";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(128, 178);
            this.txtPower.Name = "txtPower";
            this.txtPower.ReadOnly = true;
            this.txtPower.Size = new System.Drawing.Size(61, 20);
            this.txtPower.TabIndex = 5;
            this.txtPower.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ListSize";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(128, 42);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(61, 20);
            this.txtSize.TabIndex = 7;
            this.txtSize.TabStop = false;
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(195, 103);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(75, 23);
            this.btnReduce.TabIndex = 4;
            this.btnReduce.Text = "Reduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Likeness";
            // 
            // txtLikeness
            // 
            this.txtLikeness.Location = new System.Drawing.Point(128, 105);
            this.txtLikeness.Name = "txtLikeness";
            this.txtLikeness.Size = new System.Drawing.Size(61, 20);
            this.txtLikeness.TabIndex = 3;
            this.txtLikeness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chosen_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chosen Word";
            // 
            // txtChosen
            // 
            this.txtChosen.Location = new System.Drawing.Point(12, 105);
            this.txtChosen.Name = "txtChosen";
            this.txtChosen.Size = new System.Drawing.Size(100, 20);
            this.txtChosen.TabIndex = 2;
            this.txtChosen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chosen_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLikeness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChosen);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLikeness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChosen;
        private System.Windows.Forms.Button button1;
    }
}

