Imports Microsoft.VisualBasic
Imports System
Namespace PopupContainerWithOKButton
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.fontDialog1 = New System.Windows.Forms.FontDialog()
			Me.checkEditShowOk = New DevExpress.XtraEditors.CheckEdit()
			Me.popupContainerEditOKButtonForTest = New PopupContainerControlWithOKButton.PopupContainerEditOKButton()
			Me.popupContainerControlForTest = New DevExpress.XtraEditors.PopupContainerControl()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.checkEditShowOk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerEditOKButtonForTest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControlForTest, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControlForTest.SuspendLayout()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkEditShowOk
			' 
			Me.checkEditShowOk.Location = New System.Drawing.Point(12, 106)
			Me.checkEditShowOk.Name = "checkEditShowOk"
			Me.checkEditShowOk.Properties.Caption = "Show ok button in popup window"
'			Me.checkEditShowOk.Properties.EditValueChanged += New System.EventHandler(Me.checkEditShowOk_Properties_EditValueChanged);
			Me.checkEditShowOk.Size = New System.Drawing.Size(249, 19)
			Me.checkEditShowOk.TabIndex = 4
			' 
			' popupContainerEditOKButtonForTest
			' 
			Me.popupContainerEditOKButtonForTest.Location = New System.Drawing.Point(12, 10)
			Me.popupContainerEditOKButtonForTest.Name = "popupContainerEditOKButtonForTest"
			Me.popupContainerEditOKButtonForTest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEditOKButtonForTest.Properties.PopupControl = Me.popupContainerControlForTest
'			Me.popupContainerEditOKButtonForTest.Properties.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.popupContainerEditOKButtonpopupContainerEditOKButtonForTest_Properties_QueryResultValue);
			Me.popupContainerEditOKButtonForTest.Size = New System.Drawing.Size(250, 20)
			Me.popupContainerEditOKButtonForTest.TabIndex = 3
			' 
			' popupContainerControlForTest
			' 
			Me.popupContainerControlForTest.Controls.Add(Me.buttonEdit1)
			Me.popupContainerControlForTest.Location = New System.Drawing.Point(13, 36)
			Me.popupContainerControlForTest.Name = "popupContainerControlForTest"
			Me.popupContainerControlForTest.Size = New System.Drawing.Size(249, 64)
			Me.popupContainerControlForTest.TabIndex = 0
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(11, 10)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(222, 20)
			Me.buttonEdit1.TabIndex = 0
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(275, 132)
			Me.Controls.Add(Me.checkEditShowOk)
			Me.Controls.Add(Me.popupContainerEditOKButtonForTest)
			Me.Controls.Add(Me.popupContainerControlForTest)
			Me.Name = "MainForm"
			Me.Text = "Example main form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.checkEditShowOk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerEditOKButtonForTest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControlForTest, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControlForTest.ResumeLayout(False)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private popupContainerControlForTest As DevExpress.XtraEditors.PopupContainerControl
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents popupContainerEditOKButtonForTest As PopupContainerControlWithOKButton.PopupContainerEditOKButton
		Private fontDialog1 As System.Windows.Forms.FontDialog
		Private WithEvents checkEditShowOk As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

