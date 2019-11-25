Public Class index
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("¿Esta seguro que quiere salir?", "Advertencia",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint

    End Sub

    Private Sub BtnAsuntos_Click(sender As Object, e As EventArgs) Handles BtnListAsuntos.Click
        openChildForm(New list_Asuntos())
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(childForm)
        PanelContenedor.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnAddAsunto_Click(sender As Object, e As EventArgs) Handles btnAddAsunto.Click
        openChildForm(New add_Asunto())
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        openChildForm(New list_Asuntos())
    End Sub

    Private Sub btnAddProcurador_Click(sender As Object, e As EventArgs) Handles btnAddProcurador.Click
        openChildForm(New add_Procurador())
    End Sub

    Private Sub btnEditAsunto_Click(sender As Object, e As EventArgs) Handles btnEditAsunto.Click
        openChildForm(New editAsuntoCliente())
    End Sub
End Class