Imports DevExpress.XtraEditors.Popup
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

        Private Overloads ReadOnly Property Properties As RepositoryItemPopupContainerEditOKButton
            Get
                Dim edit As PopupContainerEditOKButton = TryCast(OwnerEdit, PopupContainerEditOKButton)
                If edit Is Nothing Then Return Nothing
                Return edit.Properties
            End Get
        End Property

        Friend Sub UpdatePopupButtons()
            If Properties Is Nothing Then Return
            fShowOkButton = Properties.ShowOkButton
            If Properties.ShowPopupCloseButton Then
                fCloseButtonStyle = If(Properties.ShowOkButton, BlobCloseButtonStyle.Caption, BlobCloseButtonStyle.Glyph)
            Else
                fCloseButtonStyle = BlobCloseButtonStyle.None
            End If

            AllowSizing = Properties.PopupSizeable
            If Not AllowSizing AndAlso Not fShowOkButton AndAlso fCloseButtonStyle = BlobCloseButtonStyle.None Then ViewInfo.ShowSizeBar = False
        End Sub
    End Class
End Namespace
