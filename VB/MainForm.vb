Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Win

Namespace PopupContainerWithOKButton
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub popupContainerEditOKButtonpopupContainerEditOKButtonForTest_Properties_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles popupContainerEditOKButtonForTest.Properties.QueryResultValue
			e.Value = buttonEdit1.EditValue
		End Sub

		Private Sub checkEditShowOk_Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowOk.Properties.EditValueChanged
			popupContainerEditOKButtonForTest.Properties.ShowOkButton = CBool(checkEditShowOk.EditValue)
			Dim currentPopupWindow As Control = (TryCast(popupContainerEditOKButtonForTest, IPopupControl)).PopupWindow
			If currentPopupWindow IsNot Nothing Then
				currentPopupWindow.Dispose()
			End If
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			checkEditShowOk.EditValue = True
		End Sub

	End Class
End Namespace
