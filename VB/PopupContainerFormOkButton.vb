Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Drawing

Namespace PopupContainerControlWithOKButton
	Friend Class PopupContainerFormOkButton
		Inherits PopupContainerForm
		' constructor
		Public Sub New(ByVal ownerEdit As PopupContainerEditOKButton)
			MyBase.New(ownerEdit)
		End Sub

		' override methods
		Protected Overrides Sub SetupButtons()
			UpdatePopupButtons()
		End Sub

		Private Shadows ReadOnly Property Properties() As RepositoryItemPopupContainerEditOKButton
			Get
				Dim edit As PopupContainerEditOKButton = TryCast(OwnerEdit, PopupContainerEditOKButton)
				If edit Is Nothing Then
					Return Nothing
				End If
				Return edit.Properties
			End Get
		End Property
		Friend Sub UpdatePopupButtons()
			If Properties Is Nothing Then
				Return
			End If
			Me.fShowOkButton = Properties.ShowOkButton
			If Properties.ShowPopupCloseButton Then
				Me.fCloseButtonStyle = If(Properties.ShowOkButton, BlobCloseButtonStyle.Caption, BlobCloseButtonStyle.Glyph)
			Else
				Me.fCloseButtonStyle = BlobCloseButtonStyle.None
			End If
			Me.AllowSizing = Properties.PopupSizeable
			If (Not AllowSizing) AndAlso (Not fShowOkButton) AndAlso fCloseButtonStyle = BlobCloseButtonStyle.None Then
				ViewInfo.ShowSizeBar = False
			End If
		End Sub
	End Class
End Namespace
