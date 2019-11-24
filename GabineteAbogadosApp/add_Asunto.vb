Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Public Class add_Asunto
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        'MsgBox(dateInicio.Text)

        Dim sqlquery As String 'cadena centencia sql 
        Dim commando As New SqlCommand 'Objeto de comando

        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
                MsgBox("Para registar ingrese los datos en los campos requeridos")
            Else
                sqlquery = "INSERT INTO clientes (codigo, cedula, nombre, apellido, direccion, telefono, email, fechaInicio, fechaFin,tipoAsunto, estado)
                VALUES('" & txtCodigo.Text & "','" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & dateInicio.Text & "', '" & dateFin.Text & "', '" & cmboxTipoAsunto.Text & "', '" & cmboxEstado.Text & "')"

                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Agregando cliente satisfactoriamente...")

                'Limpiando
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("El codigo ya existe")
        End Try
    End Sub

    Private Sub add_Asunto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Generar un numero aleatorio para el codigo "
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((10000 * Rnd()) + 1000))
        txtCodigo.Text = value.ToString
#End Region
    End Sub

End Class