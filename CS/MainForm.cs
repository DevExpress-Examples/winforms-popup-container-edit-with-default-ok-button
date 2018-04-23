using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Win;

namespace PopupContainerWithOKButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void popupContainerEditOKButtonpopupContainerEditOKButtonForTest_Properties_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = buttonEdit1.EditValue;
        }

        private void checkEditShowOk_Properties_EditValueChanged(object sender, EventArgs e)
        {
            popupContainerEditOKButtonForTest.Properties.ShowOkButton = (bool)checkEditShowOk.EditValue;
            Control currentPopupWindow = (popupContainerEditOKButtonForTest as IPopupControl).PopupWindow;
            if (currentPopupWindow != null) currentPopupWindow.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkEditShowOk.EditValue = true;
        }

    }
}
