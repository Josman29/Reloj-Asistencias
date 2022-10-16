<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContraseña))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMostrar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnCambiar)
        Me.GroupBox1.Controls.Add(Me.lblPassword2)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.txtPassword2)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.Location = New System.Drawing.Point(21, 153)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(118, 17)
        Me.chkMostrar.TabIndex = 8
        Me.chkMostrar.Text = "Mostrar Contraseña"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(21, 205)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(209, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(21, 175)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(209, 23)
        Me.btnCambiar.TabIndex = 6
        Me.btnCambiar.Text = "Cambiar Contraseña"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(18, 109)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(98, 13)
        Me.lblPassword2.TabIndex = 5
        Me.lblPassword2.Text = "Repetir Contraseña"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(18, 70)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(18, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(21, 126)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(209, 20)
        Me.txtPassword2.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(21, 86)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(209, 20)
        Me.txtpassword.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(21, 43)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(209, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'frmCambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(308, 314)
        Me.MinimumSize = New System.Drawing.Size(308, 314)
        Me.Name = "frmCambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
