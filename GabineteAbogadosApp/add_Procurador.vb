Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class add_Procurador
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, PictureBox1.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub add_Procurador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "LLenar Grid Procurador"
        Dim sqlquery As String 'cadena sentencia sql
        Dim commando As New SqlCommand 'objeto de comando
        Dim data As SqlDataReader ' objeto de lectura
        Dim conta As Int16
        Try
            sqlquery = "SELECT * FROM Procurador"
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            While (data.Read())
                conta = conta + 1
                DataGridViewProcurador.Rows.Add(conta, data("DNI"), data("nombre"), data("email"), data("telefono")) 'se pone lo que esta en la BD
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        data.Close()
#End Region
    End Sub

    Private Sub BtnAdd_Procurador_Click(sender As Object, e As EventArgs) Handles BtnAdd_Procurador.Click
        Dim sqlquery As String 'cadena centencia sql 
        Dim commando As New SqlCommand 'Objeto de comando

        Try
            If txt_cedula.Text = "" Or txt_nombre.Text = "" Or txt_email.Text = "" Or txt_telefono.Text = "" Then
                MsgBox("Para registar ingrese los datos en los campos requeridos")
            Else
                sqlquery = "INSERT INTO Procurador (DNI, nombre, email, telefono)
                VALUES('" & txt_cedula.Text & "', '" & txt_nombre.Text & "', '" & txt_email.Text & "', '" & txt_telefono.Text & "')"

                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Agregando procurador...")

                'Limpiando
                txt_cedula.Clear()
                txt_nombre.Clear()
                txt_telefono.Clear()
                txt_email.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("La cedula ya existe")
        End Try
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        DataGridViewProcurador.Rows().Clear()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim data As SqlDataReader ' objeto de lectura
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql
        Try
            If txt_cedula.Text = "" Then
                MsgBox("Para Consultar ingrese el número de cédula en el campo requerido")
            End If
            sqlquery = "SELECT * FROM Procurador WHERE DNI = '" & txt_cedula.Text & "' "
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            data.Read()

            txt_cedula.Text = data("DNI")
            txt_nombre.Text = data("nombre")
            txt_telefono.Text = data("telefono")
            txt_email.Text = data("email")

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
            If txt_cedula.Text = "" Then
                MsgBox("Para eliminar ingrese el número de cédula en el campo requerido")

            ElseIf MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                sqlquery = "DELETE FROM Procurador WHERE DNI = '" & txt_cedula.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Elimando...")

                'Limpiando
                txt_cedula.Clear()
                txt_nombre.Clear()
                txt_telefono.Clear()
                txt_email.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql

        Try
            If txt_cedula.Text = "" Then
                MsgBox("Para actualizar ingrese el número de cédula en el campo requerido")
            Else
                sqlquery = "UPDATE Procurador SET DNI = '" & txt_cedula.Text & "',
                                         nombre = '" & txt_nombre.Text & "',
                                         email = '" & txt_email.Text & "',
                                         telefono = '" & txt_telefono.Text & "'
                WHERE DNI = '" & txt_cedula.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Actualizando...")

                'Limpiando
                txt_cedula.Clear()
                txt_nombre.Clear()
                txt_telefono.Clear()
                txt_email.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class