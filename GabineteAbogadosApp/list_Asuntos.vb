Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class list_Asuntos
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub list_Asuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "LLenar Grid Lista de Asuntos"
        Dim sqlquery As String 'cadena sentencia sql
        Dim commando As New SqlCommand 'objeto de comando
        Dim data As SqlDataReader ' objeto de lectura
        Dim conta As Int16
        Try
            sqlquery = "SELECT * FROM Asunto"
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            While (data.Read())
                conta = conta + 1
                DataGridViewListaAsuntos.Rows.Add(conta, data("CodigoExpediente"), data("cliente"), data("tipoAsunto"), data("estado"), data("fechaInicio"), data("fechaFin"), data("procurador")) 'se pone lo que esta en la BD
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        data.Close()
#End Region
    End Sub
End Class