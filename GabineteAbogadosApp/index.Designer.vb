<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnMini = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.BtnListAsuntos = New System.Windows.Forms.Button()
        Me.btnAddProcurador = New System.Windows.Forms.Button()
        Me.btnEditAsunto = New System.Windows.Forms.Button()
        Me.btnAddAsunto = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuVertical.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BarraTitulo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Label2)
        Me.MenuVertical.Controls.Add(Me.Panel2)
        Me.MenuVertical.Controls.Add(Me.btnHome)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(250, 650)
        Me.MenuVertical.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnListAsuntos)
        Me.Panel2.Controls.Add(Me.btnAddProcurador)
        Me.Panel2.Controls.Add(Me.btnEditAsunto)
        Me.Panel2.Controls.Add(Me.btnAddAsunto)
        Me.Panel2.Location = New System.Drawing.Point(-5, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 368)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 210)
        Me.Panel1.TabIndex = 0
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.BtnMini)
        Me.BarraTitulo.Controls.Add(Me.btnClose)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(250, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1050, 50)
        Me.BarraTitulo.TabIndex = 1
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.PictureBox2)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(250, 50)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1050, 600)
        Me.PanelContenedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BIENVENDIDO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.GabineteAbogadosApp.My.Resources.Resources.William_George
        Me.PictureBox2.Location = New System.Drawing.Point(289, 97)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(473, 456)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnMini
        '
        Me.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMini.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_minimize_window_24px_1
        Me.BtnMini.Location = New System.Drawing.Point(965, 7)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(37, 28)
        Me.BtnMini.TabIndex = 1
        Me.BtnMini.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_close_window_24px_3
        Me.btnClose.Location = New System.Drawing.Point(1008, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'BtnListAsuntos
        '
        Me.BtnListAsuntos.FlatAppearance.BorderSize = 0
        Me.BtnListAsuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListAsuntos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListAsuntos.ForeColor = System.Drawing.Color.White
        Me.BtnListAsuntos.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_grid_32px
        Me.BtnListAsuntos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListAsuntos.Location = New System.Drawing.Point(5, 16)
        Me.BtnListAsuntos.Name = "BtnListAsuntos"
        Me.BtnListAsuntos.Size = New System.Drawing.Size(250, 40)
        Me.BtnListAsuntos.TabIndex = 1
        Me.BtnListAsuntos.Text = "Lista Asuntos"
        Me.BtnListAsuntos.UseVisualStyleBackColor = True
        '
        'btnAddProcurador
        '
        Me.btnAddProcurador.FlatAppearance.BorderSize = 0
        Me.btnAddProcurador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcurador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProcurador.ForeColor = System.Drawing.Color.White
        Me.btnAddProcurador.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_scales_32px
        Me.btnAddProcurador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProcurador.Location = New System.Drawing.Point(5, 108)
        Me.btnAddProcurador.Name = "btnAddProcurador"
        Me.btnAddProcurador.Size = New System.Drawing.Size(250, 40)
        Me.btnAddProcurador.TabIndex = 5
        Me.btnAddProcurador.Text = "Procurador"
        Me.btnAddProcurador.UseVisualStyleBackColor = True
        '
        'btnEditAsunto
        '
        Me.btnEditAsunto.FlatAppearance.BorderSize = 0
        Me.btnEditAsunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAsunto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAsunto.ForeColor = System.Drawing.Color.White
        Me.btnEditAsunto.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_edit_file_32px
        Me.btnEditAsunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAsunto.Location = New System.Drawing.Point(8, 154)
        Me.btnEditAsunto.Name = "btnEditAsunto"
        Me.btnEditAsunto.Size = New System.Drawing.Size(244, 61)
        Me.btnEditAsunto.TabIndex = 2
        Me.btnEditAsunto.Text = "Editar Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asunto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEditAsunto.UseVisualStyleBackColor = True
        '
        'btnAddAsunto
        '
        Me.btnAddAsunto.FlatAppearance.BorderSize = 0
        Me.btnAddAsunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAsunto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAsunto.ForeColor = System.Drawing.Color.White
        Me.btnAddAsunto.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_add_file_32px_1
        Me.btnAddAsunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAsunto.Location = New System.Drawing.Point(5, 62)
        Me.btnAddAsunto.Name = "btnAddAsunto"
        Me.btnAddAsunto.Size = New System.Drawing.Size(250, 40)
        Me.btnAddAsunto.TabIndex = 3
        Me.btnAddAsunto.Text = "Asunto"
        Me.btnAddAsunto.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.GabineteAbogadosApp.My.Resources.Resources.icons8_home_filled_32px
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 216)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(250, 40)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Inicio"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GabineteAbogadosApp.My.Resources.Resources.William_George
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(3, 630)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "V1.0.0"
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "index"
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.BarraTitulo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuVertical As Panel
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents BtnMini As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnListAsuntos As Button
    Friend WithEvents btnEditAsunto As Button
    Friend WithEvents btnAddAsunto As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAddProcurador As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
