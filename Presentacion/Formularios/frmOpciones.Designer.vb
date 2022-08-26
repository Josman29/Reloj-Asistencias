<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpciones
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
        Me.gbOpacidad = New System.Windows.Forms.GroupBox()
        Me.lblTrackbar = New System.Windows.Forms.Label()
        Me.tbNivel = New System.Windows.Forms.TrackBar()
        Me.tlpOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.gbOpacidad.SuspendLayout()
        CType(Me.tbNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOpacidad
        '
        Me.gbOpacidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbOpacidad.Controls.Add(Me.lblTrackbar)
        Me.gbOpacidad.Controls.Add(Me.tbNivel)
        Me.gbOpacidad.Location = New System.Drawing.Point(141, 59)
        Me.gbOpacidad.Name = "gbOpacidad"
        Me.gbOpacidad.Size = New System.Drawing.Size(201, 126)
        Me.gbOpacidad.TabIndex = 0
        Me.gbOpacidad.TabStop = False
        Me.gbOpacidad.Text = "Opacidad"
        '
        'lblTrackbar
        '
        Me.lblTrackbar.AutoSize = True
        Me.lblTrackbar.Location = New System.Drawing.Point(154, 79)
        Me.lblTrackbar.Name = "lblTrackbar"
        Me.lblTrackbar.Size = New System.Drawing.Size(37, 13)
        Me.lblTrackbar.TabIndex = 4
        Me.lblTrackbar.Text = "10000"
        '
        'tbNivel
        '
        Me.tbNivel.Location = New System.Drawing.Point(11, 61)
        Me.tbNivel.Maximum = 100
        Me.tbNivel.Minimum = 30
        Me.tbNivel.Name = "tbNivel"
        Me.tbNivel.Size = New System.Drawing.Size(137, 45)
        Me.tbNivel.TabIndex = 3
        Me.tbNivel.Value = 30
        '
        'tlpOpciones
        '
        Me.tlpOpciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOpciones.ColumnCount = 3
        Me.tlpOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.75666!))
        Me.tlpOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.48718!))
        Me.tlpOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.75615!))
        Me.tlpOpciones.Controls.Add(Me.gbOpacidad, 1, 1)
        Me.tlpOpciones.Location = New System.Drawing.Point(3, 6)
        Me.tlpOpciones.Name = "tlpOpciones"
        Me.tlpOpciones.RowCount = 3
        Me.tlpOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.0!))
        Me.tlpOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpOpciones.Size = New System.Drawing.Size(485, 246)
        Me.tlpOpciones.TabIndex = 1
        '
        'frmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 264)
        Me.Controls.Add(Me.tlpOpciones)
        Me.MinimumSize = New System.Drawing.Size(516, 303)
        Me.Name = "frmOpciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOpciones"
        Me.gbOpacidad.ResumeLayout(False)
        Me.gbOpacidad.PerformLayout()
        CType(Me.tbNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbOpacidad As GroupBox
    Friend WithEvents tbNivel As TrackBar
    Friend WithEvents lblTrackbar As Label
    Friend WithEvents tlpOpciones As TableLayoutPanel
End Class
