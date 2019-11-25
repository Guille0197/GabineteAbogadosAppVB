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
        'Registro cliente
        Dim sqlquery As String
        Dim commando As New SqlCommand

        'Registro Asunto
        Dim sqlquerys As String
        Dim commandos As New SqlCommand

        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
                MsgBox("Para registar ingrese los datos en los campos requeridos")
            Else
                'Registra el cliente
                sqlquery = "INSERT INTO Cliente (cedula, nombre, direccion, telefono, email, codASunto)
                VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & txtCodigo.Text & "')"

                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery()

                'Registra el asunto
                sqlquerys = "INSERT INTO Asunto (CodigoExpediente, estado, fechaInicio, fechaFin, cliente, procurador, tipoAsunto)
                VALUES('" & txtCodigo.Text & "', '" & cmboxEstado.Text & "', '" & dateInicio.Text & "', '" & dateFin.Text & "', '" & TextBox1.Text & "', '" & cmbBoxProcurador.Text & "', '" & cmboxTipoAsunto.Text & "')"
                commandos = New SqlCommand(sqlquerys, conexion)
                commandos.ExecuteNonQuery()



                MsgBox("Agregando cliente satisfactoriamente...")
                Me.Close()

                'Limpiando
                TextBox1.Clear()
                TextBox2.Clear()
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
        LLenarTipoAsunto() 'llenar comboBox de BD
        LLenarEstado() 'llenar comboBox de BD
        LLenarProcurador()
#Region "Generar un numero aleatorio para el codigo "
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((10000 * Rnd()) + 1000))
        txtCodigo.Text = value.ToString
#End Region
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

End Class