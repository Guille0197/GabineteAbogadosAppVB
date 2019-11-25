Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class editAsuntoCliente
    Private Sub editAsuntoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "LLenar Grid Clientes"
        Dim sqlquery As String 'cadena sentencia sql
        Dim commando As New SqlCommand 'objeto de comando
        Dim data As SqlDataReader ' objeto de lectura
        Dim conta As Int16
        Try
            sqlquery = "SELECT * FROM Cliente"
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            While (data.Read())
                conta = conta + 1
                DataGridViewClientes.Rows.Add(data("codAsunto"), data("cedula"), data("nombre"), data("direccion"), data("telefono"), data("email")) 'se pone lo que esta en la BD
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        data.Close()
#End Region
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim data As SqlDataReader ' objeto de lectura
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql
        Try
            If TextBox1.Text = "" Then
                MsgBox("Para buscar ingrese el número de expediente en el campo requerido")
            End If
            sqlquery = "SELECT * FROM Cliente WHERE codAsunto = '" & TextBox1.Text & "' "
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            data.Read()

            TextBox1.Text = data("codAsunto")
            TextBox2.Text = data("cedula")
            TextBox3.Text = data("nombre")
            TextBox4.Text = data("direccion")
            TextBox5.Text = data("email")
            TextBox6.Text = data("telefono")

        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("ERROR: INGRESO INFORMACIÓN INCORRECTA!!!")
        End Try
        data.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql

        Try
            If TextBox1.Text = "" Then
                MsgBox("Para eliminar ingrese el número de cédula en el campo requerido")

            ElseIf MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                sqlquery = "DELETE FROM cliente WHERE codAsunto = '" & TextBox1.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Elimando...")

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
        End Try
    End Sub
End Class