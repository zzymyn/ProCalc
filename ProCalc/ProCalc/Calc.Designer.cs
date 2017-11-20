namespace ProCalc.UI
{
    partial class Calc
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
            this.m_Eq = new System.Windows.Forms.TextBox();
            this.m_Result = new System.Windows.Forms.Label();
            this.m_EvaluateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_Eq
            // 
            this.m_Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Eq.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Eq.Location = new System.Drawing.Point(12, 12);
            this.m_Eq.Name = "m_Eq";
            this.m_Eq.Size = new System.Drawing.Size(524, 23);
            this.m_Eq.TabIndex = 0;
            this.m_Eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_Result
            // 
            this.m_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Result.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Result.Location = new System.Drawing.Point(12, 38);
            this.m_Result.Name = "m_Result";
            this.m_Result.Size = new System.Drawing.Size(524, 39);
            this.m_Result.TabIndex = 1;
            this.m_Result.Text = "0";
            this.m_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_EvaluateButton
            // 
            this.m_EvaluateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_EvaluateButton.Location = new System.Drawing.Point(477, 146);
            this.m_EvaluateButton.Name = "m_EvaluateButton";
            this.m_EvaluateButton.Size = new System.Drawing.Size(59, 46);
            this.m_EvaluateButton.TabIndex = 2;
            this.m_EvaluateButton.Text = "=";
            this.m_EvaluateButton.UseVisualStyleBackColor = true;
            this.m_EvaluateButton.Click += new System.EventHandler(this.m_EvaluateButton_Click);
            // 
            // Calc
            // 
            this.AcceptButton = this.m_EvaluateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 204);
            this.Controls.Add(this.m_EvaluateButton);
            this.Controls.Add(this.m_Result);
            this.Controls.Add(this.m_Eq);
            this.Name = "Calc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_Eq;
        private System.Windows.Forms.Label m_Result;
        private System.Windows.Forms.Button m_EvaluateButton;
    }
}

