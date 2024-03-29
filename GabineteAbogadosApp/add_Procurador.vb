﻿Imports System.Data
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
        LlenarProcurador()
        txtCedula.Focus()
    End Sub
#Region "LLenar Grid Procurador"
    Sub LlenarProcurador()
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
            If txtCedula.Text = "" Or txtNombre.Text = "" Or txtEmail.Text = "" Or txtTelefono.Text = "" Then
                MsgBox("Para registar ingrese los datos en los campos requeridos")
            Else
                sqlquery = "INSERT INTO Procurador (DNI, nombre, email, telefono)
                VALUES('" & txtCedula.Text & "', '" & txtNombre.Text & "', '" & txtEmail.Text & "', '" & txtTelefono.Text & "')"

                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Agregando procurador...")
                DataGridViewProcurador.Rows.Clear()
                LlenarProcurador()


                'Limpiando
                txtCedula.Clear()
                txtNombre.Clear()
                txtTelefono.Clear()
                txtEmail.Clear()

            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("ERROR: Número de cedula ya esta registrada, intente nuevamente")
            'Limpiando
            txtCedula.Clear()
            txtNombre.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()
        End Try
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs)
        DataGridViewProcurador.Rows().Clear()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim data As SqlDataReader ' objeto de lectura
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql
        Try
            If txtCedula.Text = "" Then
                MsgBox("Para Consultar ingrese el número de cédula en el campo requerido")
            End If
            sqlquery = "SELECT * FROM Procurador WHERE DNI = '" & txtCedula.Text & "' "
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            data.Read()

            txtCedula.Text = data("DNI")
            txtNombre.Text = data("nombre")
            txtTelefono.Text = data("telefono")
            txtEmail.Text = data("email")

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
            If txtCedula.Text = "" Then
                MsgBox("Para eliminar ingrese el número de cédula en el campo requerido")

            ElseIf MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                sqlquery = "DELETE FROM Procurador WHERE DNI = '" & txtCedula.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Elimando...")
                DataGridViewProcurador.Rows().Clear()
                LlenarProcurador()

                'Limpiando
                txtCedula.Clear()
                txtNombre.Clear()
                txtTelefono.Clear()
                txtEmail.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql

        Try
            If txtCedula.Text = "" Then
                MsgBox("Para actualizar ingrese el número de cédula en el campo requerido")
            Else
                sqlquery = "UPDATE Procurador SET DNI = '" & txtCedula.Text & "',
                                         nombre = '" & txtNombre.Text & "',
                                         email = '" & txtEmail.Text & "',
                                         telefono = '" & txtTelefono.Text & "'
                WHERE DNI = '" & txtCedula.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD
                MsgBox("Actualizando...")
                DataGridViewProcurador.Rows().Clear()
                LlenarProcurador()

                'Limpiando
                txtCedula.Clear()
                txtNombre.Clear()
                txtTelefono.Clear()
                txtEmail.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class