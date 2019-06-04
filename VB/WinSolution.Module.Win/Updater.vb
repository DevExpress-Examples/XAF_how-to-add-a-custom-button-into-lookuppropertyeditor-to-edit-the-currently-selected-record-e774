Imports DevExpress.ExpressApp
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo

Namespace WinSolution.Module.Win
	Public Class Updater
		Inherits ModuleUpdater

'INSTANT VB NOTE: The variable objectSpace was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable currentDBVersion was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal objectSpace_Renamed As IObjectSpace, ByVal currentDBVersion_Renamed As Version)
			MyBase.New(objectSpace_Renamed, currentDBVersion_Renamed)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
		End Sub
	End Class
End Namespace
