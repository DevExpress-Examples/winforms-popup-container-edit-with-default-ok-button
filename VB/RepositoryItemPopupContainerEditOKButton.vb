Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel

Namespace PopupContainerControlWithOKButton

    Friend Class RepositoryItemPopupContainerEditOKButton
        Inherits RepositoryItemPopupContainerEdit

        ' static constructor which calls static registration method
        Shared Sub New()
            Call RegisterPopupContainerEditOKButton()
        End Sub

        ' static register method
        Public Shared Sub RegisterPopupContainerEditOKButton()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(PopupContainerEditOKButtonEditorName, GetType(PopupContainerEditOKButton), GetType(RepositoryItemPopupContainerEditOKButton), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True, CType(Nothing, System.Drawing.Image)))
        End Sub

        ' internal editor name
        Friend Const PopupContainerEditOKButtonEditorName As String = "PopupContainerEditOKButton"

        ' public constructor
        Public Sub New()
            MyBase.New()
            protShowOkButton = True
        End Sub

        Protected protShowOkButton As Boolean

        <Description("Determines whether the Ok button will be displayed in the popup form or not.")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property ShowOkButton As Boolean
            Get
                Return protShowOkButton
            End Get

            Set(ByVal value As Boolean)
                If value <> protShowOkButton Then protShowOkButton = value
            End Set
        End Property

        ' ovverride property
        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return PopupContainerEditOKButtonEditorName
            End Get
        End Property

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            MyBase.Assign(item)
            Dim currentRepository As RepositoryItemPopupContainerEditOKButton = TryCast(item, RepositoryItemPopupContainerEditOKButton)
            ShowOkButton = currentRepository.ShowOkButton
        End Sub
    End Class
End Namespace
