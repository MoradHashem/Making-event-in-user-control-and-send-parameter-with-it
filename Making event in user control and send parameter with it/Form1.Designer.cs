namespace Making_event_in_user_control_and_send_parameter_with_it
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
            this.ctrlCalculationNumbers1 = new Making_event_in_user_control_and_send_parameter_with_it.ctrlCalculationNumbers();
            this.SuspendLayout();
            // 
            // ctrlCalculationNumbers1
            // 
            this.ctrlCalculationNumbers1.BackColor = System.Drawing.Color.Teal;
            this.ctrlCalculationNumbers1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCalculationNumbers1.Name = "ctrlCalculationNumbers1";
            this.ctrlCalculationNumbers1.Size = new System.Drawing.Size(382, 194);
            this.ctrlCalculationNumbers1.TabIndex = 0;
            this.ctrlCalculationNumbers1.OnCalculationComplete += new System.Action<int>(this.ctrlCalculationNumbers1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 190);
            this.Controls.Add(this.ctrlCalculationNumbers1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculationNumbers ctrlCalculationNumbers1;
    }
}

