
namespace Assingment_02
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
            this.txtInput_09 = new System.Windows.Forms.TextBox();
            this.lblName_09 = new System.Windows.Forms.Label();
            this.btnSubmit_09 = new System.Windows.Forms.Button();
            this.txtOutput_09 = new System.Windows.Forms.TextBox();
            this.lblResult_09 = new System.Windows.Forms.Label();
            this.lblTitle_09 = new System.Windows.Forms.Label();
            this.btnClear_09 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput_09
            // 
            this.txtInput_09.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtInput_09.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput_09.Location = new System.Drawing.Point(12, 82);
            this.txtInput_09.Multiline = true;
            this.txtInput_09.Name = "txtInput_09";
            this.txtInput_09.Size = new System.Drawing.Size(286, 86);
            this.txtInput_09.TabIndex = 0;
            // 
            // lblName_09
            // 
            this.lblName_09.AutoSize = true;
            this.lblName_09.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_09.Location = new System.Drawing.Point(161, 60);
            this.lblName_09.Name = "lblName_09";
            this.lblName_09.Size = new System.Drawing.Size(137, 19);
            this.lblName_09.TabIndex = 1;
            this.lblName_09.Text = "Enter Your Text Hear";
            // 
            // btnSubmit_09
            // 
            this.btnSubmit_09.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubmit_09.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_09.Location = new System.Drawing.Point(178, 174);
            this.btnSubmit_09.Name = "btnSubmit_09";
            this.btnSubmit_09.Size = new System.Drawing.Size(120, 35);
            this.btnSubmit_09.TabIndex = 2;
            this.btnSubmit_09.Text = "Submit";
            this.btnSubmit_09.UseVisualStyleBackColor = false;
            this.btnSubmit_09.Click += new System.EventHandler(this.btnSubmit_09_Click);
            // 
            // txtOutput_09
            // 
            this.txtOutput_09.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtOutput_09.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput_09.Location = new System.Drawing.Point(12, 241);
            this.txtOutput_09.Multiline = true;
            this.txtOutput_09.Name = "txtOutput_09";
            this.txtOutput_09.Size = new System.Drawing.Size(286, 81);
            this.txtOutput_09.TabIndex = 3;
            // 
            // lblResult_09
            // 
            this.lblResult_09.AutoSize = true;
            this.lblResult_09.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult_09.Location = new System.Drawing.Point(249, 219);
            this.lblResult_09.Name = "lblResult_09";
            this.lblResult_09.Size = new System.Drawing.Size(46, 19);
            this.lblResult_09.TabIndex = 4;
            this.lblResult_09.Text = "Result";
            // 
            // lblTitle_09
            // 
            this.lblTitle_09.AutoSize = true;
            this.lblTitle_09.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_09.Location = new System.Drawing.Point(74, 9);
            this.lblTitle_09.Name = "lblTitle_09";
            this.lblTitle_09.Size = new System.Drawing.Size(151, 39);
            this.lblTitle_09.TabIndex = 5;
            this.lblTitle_09.Text = "Text Encoder";
            // 
            // btnClear_09
            // 
            this.btnClear_09.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClear_09.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_09.Location = new System.Drawing.Point(178, 328);
            this.btnClear_09.Name = "btnClear_09";
            this.btnClear_09.Size = new System.Drawing.Size(120, 35);
            this.btnClear_09.TabIndex = 6;
            this.btnClear_09.Text = "Clear";
            this.btnClear_09.UseVisualStyleBackColor = false;
            this.btnClear_09.Click += new System.EventHandler(this.btnClear_09_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(307, 375);
            this.Controls.Add(this.btnClear_09);
            this.Controls.Add(this.lblTitle_09);
            this.Controls.Add(this.lblResult_09);
            this.Controls.Add(this.txtOutput_09);
            this.Controls.Add(this.btnSubmit_09);
            this.Controls.Add(this.lblName_09);
            this.Controls.Add(this.txtInput_09);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput_09;
        private System.Windows.Forms.Label lblName_09;
        private System.Windows.Forms.Button btnSubmit_09;
        private System.Windows.Forms.TextBox txtOutput_09;
        private System.Windows.Forms.Label lblResult_09;
        private System.Windows.Forms.Label lblTitle_09;
        private System.Windows.Forms.Button btnClear_09;
    }
}

