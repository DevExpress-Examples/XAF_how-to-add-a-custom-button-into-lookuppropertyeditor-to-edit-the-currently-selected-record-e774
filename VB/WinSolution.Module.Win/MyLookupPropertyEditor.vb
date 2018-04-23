Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp.Model

Namespace WinSolution.Module.Win
	Public Class MyLookupPropertyEditor
		Inherits LookupPropertyEditor
		Public Sub New(ByVal objectType As Type, ByVal model As IModelMemberViewItem)
			MyBase.New(objectType, model)
		End Sub
		Protected Overrides Sub SetupRepositoryItem(ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem)
			MyBase.SetupRepositoryItem(item)
			CType(item, RepositoryItemLookupEdit).Init(Me, DisplayFormat, Me.Helper)
			Dim appearance As New AppearanceObject()
			appearance.Font = New Font(FontFamily.GenericSansSerif, 10F, FontStyle.Underline)
			CType(item, RepositoryItemLookupEdit).Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "Edit", -1, True, True, True, HorzAlignment.Default, Nothing, New KeyShortcut(System.Windows.Forms.Keys.Enter), appearance, "Press this button to edit the object"))
			AddHandler (CType(item, RepositoryItemLookupEdit)).ButtonClick, AddressOf MyLookupPropertyEditor_ButtonClick
		End Sub
		Private Sub MyLookupPropertyEditor_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
			If (Not e.Button.IsDefaultButton) Then
				Dim objectSpace As IObjectSpace = Helper.Application.CreateObjectSpace()
				Dim editedObject As Object = Nothing
				If BindingHelper IsNot Nothing Then
					editedObject = objectSpace.GetObject(BindingHelper.GetControlValue())
				ElseIf TypeOf sender Is LookupEdit Then
					editedObject = objectSpace.GetObject((TryCast(sender, LookupEdit)).EditValue)
				End If
				If editedObject IsNot Nothing Then
					Dim svp As New ShowViewParameters()
					svp.CreatedView = Helper.Application.CreateDetailView(objectSpace, editedObject, True)
					svp.TargetWindow = TargetWindow.Default
					svp.Context = TemplateContext.View
					svp.CreateAllControllers = True
					Dim svs As New ShowViewSource(Helper.Application.MainWindow, Nothing)
					Helper.Application.ShowViewStrategy.ShowView(svp, svs)
				End If
			End If
		End Sub
	End Class
End Namespace
