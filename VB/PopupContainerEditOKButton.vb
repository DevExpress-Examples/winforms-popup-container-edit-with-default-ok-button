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
        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemPopupContainerEditOKButton.PopupContainerEditOKButtonEditorName
            End Get
        End Property

        ' property as corresponded repositoryitem
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemPopupContainerEditOKButton
            Get
                Return TryCast(MyBase.Properties, RepositoryItemPopupContainerEditOKButton)
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As Popup.PopupBaseForm
            Return New PopupContainerFormOkButton(Me)
        End Function
    End Class
End Namespace
