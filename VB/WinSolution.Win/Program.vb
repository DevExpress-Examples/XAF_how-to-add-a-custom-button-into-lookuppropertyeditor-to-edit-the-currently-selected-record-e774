Imports System
Imports System.Configuration
Imports System.Windows.Forms
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security

Namespace WinSolution.Win

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim _application As WinSolutionWindowsFormsApplication = New WinSolutionWindowsFormsApplication()
            _application.ConnectionString = DevExpress.Xpo.DB.InMemoryDataStore.GetConnectionString("data.xml")
            If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
                _application.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
            End If

            Try
                Xpo.InMemoryDataStoreProvider.Register()
                _application.ConnectionString = Xpo.InMemoryDataStoreProvider.ConnectionString
                _application.Setup()
                _application.Start()
            Catch e As Exception
                _application.HandleException(e)
            End Try
        End Sub
    End Module
End Namespace
