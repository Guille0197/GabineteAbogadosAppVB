Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class editAsuntoCliente
    Private Sub editAsuntoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarTipoAsunto() 'llenar comboBox de BD
        LLenarEstado() 'llenar comboBox de BD
        LLenarProcurador()
        LLenarClientes()
        txtCodigo.Focus()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        index.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim data As SqlDataReader ' objeto de lectura
        Dim commando, commandos As New SqlCommand 'Objeto de comando
        Dim sqlquery, sqlquerys As String 'cadena sentencia sql
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Para buscar ingrese el número de expediente en el campo requerido")
            End If
            sqlquery = "SELECT * FROM Cliente WHERE codAsunto = '" & txtCodigo.Text & "' "
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            data.Read()

            txtCodigo.Text = data("codAsunto")
            txtCedula.Text = data("cedula")
            txtNombre.Text = data("nombre")
            txtDireccion.Text = data("direccion")
            txtEmail.Text = data("email")
            txtTelefono.Text = data("telefono")
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
            If txtCodigo.Text = "" Then
                MsgBox("Para eliminar ingrese el número de cédula en el campo requerido")

            ElseIf MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                sqlquery = "DELETE FROM Asunto WHERE codigoExpediente = '" & txtCodigo.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD

                sqlquery = "DELETE FROM Cliente WHERE codAsunto = '" & txtCodigo.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD

                MsgBox("Elimando...")

                'Limpiando
                txtCodigo.Clear()
                txtCedula.Clear()
                txtNombre.Clear()
                txtDireccion.Clear()
                txtEmail.Clear()
                txtTelefono.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "LLenar ComboBox Tipo de Asunto BD"
    Sub LLenarTipoAsunto()

        Dim dt = New DataTable
        Dim dat = New SqlDataAdapter
        Try
            dat = New SqlDataAdapter("SELECT * FROM TipoAsuntos", conexion)
            dat.Fill(dt)

            cmboxTipoAsunto.DataSource = dt
            cmboxTipoAsunto.DisplayMember = "TipoAsunto"
            cmboxTipoAsunto.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "LLenar ComboBox Estado BD"
    Sub LLenarEstado()

        Dim dt = New DataTable
        Dim dat = New SqlDataAdapter
        Try
            dat = New SqlDataAdapter("SELECT * FROM estados", conexion)
            dat.Fill(dt)

            cmboxEstado.DataSource = dt
            cmboxEstado.DisplayMember = "estado"
            cmboxEstado.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "LLenar ComboBox Procurador BD"
    Sub LLenarProcurador()

        Dim dt = New DataTable
        Dim dat = New SqlDataAdapter
        Try
            dat = New SqlDataAdapter("SELECT * FROM Procurador", conexion)
            dat.Fill(dt)

            cmbBoxProcurador.DataSource = dt
            cmbBoxProcurador.DisplayMember = "nombre"
            cmbBoxProcurador.ValueMember = "DNI"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "LLenar Grid Clientes"
    Sub LLenarClientes()
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
    End Sub
#End Region

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql

        Try
            If txtCodigo.Text = "" Then
                MsgBox("Para actualizar ingrese el número de codigo en el campo requerido")
            Else
                sqlquery = "UPDATE Cliente SET cedula = '" & txtCedula.Text & "',
                                         nombre = '" & txtNombre.Text & "',
                                         direccion = '" & txtDireccion.Text & "',
                                         email = '" & txtEmail.Text & "',
                                         telefono = '" & txtTelefono.Text & "'
                WHERE codAsunto = '" & txtCodigo.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery() ' Actualiza la BD

                'actualizar el nombre del cliente en la tabla asunto
                sqlquery = "UPDATE Asunto SET cliente = '" & txtNombre.Text & "'
                            WHERE codigoExpediente = '" & txtCodigo.Text & "' "
                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery()


                MsgBox("Actualizando datos del cliente...")
                DataGridViewClientes.Rows().Clear()
                LLenarClientes()


                'Limpiando
                txtCodigo.Clear()
                txtCedula.Clear()
                txtNombre.Clear()
                txtDireccion.Clear()
                txtTelefono.Clear()
                txtEmail.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizarAsunto_Click(sender As Object, e As EventArgs) Handles btnActualizarAsunto.Click
        'Registro Asunto
        Dim sqlquerys As String
        Dim commandos As New SqlCommand
        Try
            If txtCodigo.Text = "" Then
                MsgBox("ERROR: Para poder actualizar los datos del asunto debe ingresar el código de expediente del cliente que desea")
            End If
            'Registra el asunto
            sqlquerys = "UPDATE Asunto SET fechaInicio = '" & dateInicio.Text & "',
                                          fechaFin = '" & dateFin.Text & "', 
                                          tipoAsunto = '" & cmboxTipoAsunto.Text & "', 
                                          estado = '" & cmboxEstado.Text & "', 
                                          procurador = '" & cmbBoxProcurador.Text & "' 
                        WHERE codigoExpediente = '" & txtCodigo.Text & "' "
            commandos = New SqlCommand(sqlquerys, conexion)
            commandos.ExecuteNonQuery()

            MsgBox("Actualizando el asunto del cliente satisfactoriamente...")
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("El codigo ya existe")
        End Try
    End Sub

End Class