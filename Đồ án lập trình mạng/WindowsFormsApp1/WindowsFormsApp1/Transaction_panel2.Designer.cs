namespace WindowsFormsApp1
{
    partial class Transaction_panel2
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
            this.panel_search = new System.Windows.Forms.Panel();
            this.panel_List_Transactor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_search
            // 
            this.panel_search.Location = new System.Drawing.Point(2, 3);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(794, 83);
            this.panel_search.TabIndex = 0;
            // 
            // panel_List_Transactor
            // 
            this.panel_List_Transactor.Location = new System.Drawing.Point(2, 92);
            this.panel_List_Transactor.Name = "panel_List_Transactor";
            this.panel_List_Transactor.Size = new System.Drawing.Size(794, 359);
            this.panel_List_Transactor.TabIndex = 1;
            // 
            // Transaction_panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_List_Transactor);
            this.Controls.Add(this.panel_search);
            this.Name = "Transaction_panel2";
            this.Text = "Transactor";
            this.Load += new System.EventHandler(this.Transactor_panel2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Panel panel_List_Transactor;
    }
}