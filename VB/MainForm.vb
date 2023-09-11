Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Win

Namespace PopupContainerWithOKButton

    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub popupContainerEditOKButtonpopupContainerEditOKButtonForTest_Properties_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            e.Value = buttonEdit1.EditValue
        End Sub

        Private Sub checkEditShowOk_Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            popupContainerEditOKButtonForTest.Properties.ShowOkButton = CBool(checkEditShowOk.EditValue)
            Dim currentPopupWindow As Control = TryCast(popupContainerEditOKButtonForTest, IPopupControl).PopupWindow
            If currentPopupWindow IsNot Nothing Then currentPopupWindow.Dispose()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            checkEditShowOk.EditValue = True
        End Sub
    End Class
End Namespace
