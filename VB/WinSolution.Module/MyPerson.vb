Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace WinSolution.Module

    <DefaultClassOptions>
    Public Class MyPerson
        Inherits Person

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class
End Namespace
