Imports System.Runtime.InteropServices

Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Public Class FormLogin
#Region "Form Behaviors"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region
#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'txtUsername
        txtUser.AutoSize = False
        'txtPassword
        txtPass.AutoSize = False
        txtPass.UseSystemPasswordChar = True
    End Sub

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        'btnLogin.Paint()
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim LoginName As String = "admin"
        Dim pass As String = "123"
        Try

            If LoginName = txtUser.Text And pass = txtPass.Text Then
                index.Show()
                Me.Hide()
            Else
                MsgBox("ERROR: USUARIO Y/O CONTRASEÑA INCORRECTA" + vbNewLine + "Intentelo nuevamente")
                txtPass.Clear()
                txtPass.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' data.Close()

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario, psw, BD, servidor As String
        Try
            servidor = "DESKTOP-OR1POIQ"
            usuario = "sa"
            psw = "123456"
            BD = "GaAbogados"
            conexion = New SqlConnection
            conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Class
