namespace PopupContainerWithOKButton
{
    partial class MainForm
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.checkEditShowOk = new DevExpress.XtraEditors.CheckEdit();
            this.popupContainerEditOKButtonForTest = new PopupContainerControlWithOKButton.PopupContainerEditOKButton();
            this.popupContainerControlForTest = new DevExpress.XtraEditors.PopupContainerControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEditOKButtonForTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControlForTest)).BeginInit();
            this.popupContainerControlForTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditShowOk
            // 
            this.checkEditShowOk.Location = new System.Drawing.Point(12, 106);
            this.checkEditShowOk.Name = "checkEditShowOk";
            this.checkEditShowOk.Properties.Caption = "Show ok button in popup window";
            this.checkEditShowOk.Properties.EditValueChanged += new System.EventHandler(this.checkEditShowOk_Properties_EditValueChanged);
            this.checkEditShowOk.Size = new System.Drawing.Size(249, 19);
            this.checkEditShowOk.TabIndex = 4;
            // 
            // popupContainerEditOKButtonForTest
            // 
            this.popupContainerEditOKButtonForTest.Location = new System.Drawing.Point(12, 10);
            this.popupContainerEditOKButtonForTest.Name = "popupContainerEditOKButtonForTest";
            this.popupContainerEditOKButtonForTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEditOKButtonForTest.Properties.PopupControl = this.popupContainerControlForTest;
            this.popupContainerEditOKButtonForTest.Properties.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.popupContainerEditOKButtonpopupContainerEditOKButtonForTest_Properties_QueryResultValue);
            this.popupContainerEditOKButtonForTest.Size = new System.Drawing.Size(250, 20);
            this.popupContainerEditOKButtonForTest.TabIndex = 3;
            // 
            // popupContainerControlForTest
            // 
            this.popupContainerControlForTest.Controls.Add(this.buttonEdit1);
            this.popupContainerControlForTest.Location = new System.Drawing.Point(13, 36);
            this.popupContainerControlForTest.Name = "popupContainerControlForTest";
            this.popupContainerControlForTest.Size = new System.Drawing.Size(249, 64);
            this.popupContainerControlForTest.TabIndex = 0;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(11, 10);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(222, 20);
            this.buttonEdit1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 132);
            this.Controls.Add(this.checkEditShowOk);
            this.Controls.Add(this.popupContainerEditOKButtonForTest);
            this.Controls.Add(this.popupContainerControlForTest);
            this.Name = "MainForm";
            this.Text = "Example main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEditOKButtonForTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControlForTest)).EndInit();
            this.popupContainerControlForTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerControl popupContainerControlForTest;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private PopupContainerControlWithOKButton.PopupContainerEditOKButton popupContainerEditOKButtonForTest;
        private System.Windows.Forms.FontDialog fontDialog1;
        private DevExpress.XtraEditors.CheckEdit checkEditShowOk;
    }
}

