Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace PopupContainerControlWithOKButton
	Friend Class PopupContainerEditOKButton
		Inherits PopupContainerEdit
		' static constructor
		Shared Sub New()
			RepositoryItemPopupContainerEditOKButton.RegisterPopupContainerEditOKButton()
		End Sub

		' public constructor
		Public Sub New()
		End Sub

		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemPopupContainerEditOKButton.PopupContainerEditOKButtonEditorName
			End Get
		End Property

		' property as corresponded repositoryitem
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemPopupContainerEditOKButton
			Get
				Return TryCast(MyBase.Properties, RepositoryItemPopupContainerEditOKButton)
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New PopupContainerFormOkButton(Me)
		End Function
	End Class
End Namespace
