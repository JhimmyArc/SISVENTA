<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminicio
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPro = New System.Windows.Forms.Button()
        Me.btnMante = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnConfigurar = New System.Windows.Forms.Button()
        Me.btnReporCat = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnRerporPro = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1232, 38)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InicioToolStripMenuItem.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(90, 34)
        Me.InicioToolStripMenuItem.Text = "INICIO"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 764)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1232, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'btnPro
        '
        Me.btnPro.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnPro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPro.Location = New System.Drawing.Point(121, 64)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(179, 28)
        Me.btnPro.TabIndex = 9
        Me.btnPro.Text = "Producto"
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'btnMante
        '
        Me.btnMante.BackColor = System.Drawing.Color.Transparent
        Me.btnMante.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnMante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMante.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMante.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMante.Location = New System.Drawing.Point(121, 4)
        Me.btnMante.Name = "btnMante"
        Me.btnMante.Size = New System.Drawing.Size(179, 31)
        Me.btnMante.TabIndex = 10
        Me.btnMante.Text = "MANTENIMIENTO"
        Me.btnMante.UseVisualStyleBackColor = False
        '
        'btnCat
        '
        Me.btnCat.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCat.Location = New System.Drawing.Point(121, 40)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(179, 28)
        Me.btnCat.TabIndex = 11
        Me.btnCat.Text = "Categoria"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(3, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 28)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInicio.Location = New System.Drawing.Point(3, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(112, 31)
        Me.btnInicio.TabIndex = 13
        Me.btnInicio.Text = "INICIO"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnConfigurar
        '
        Me.btnConfigurar.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnConfigurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfigurar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfigurar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConfigurar.Location = New System.Drawing.Point(3, 64)
        Me.btnConfigurar.Name = "btnConfigurar"
        Me.btnConfigurar.Size = New System.Drawing.Size(112, 28)
        Me.btnConfigurar.TabIndex = 12
        Me.btnConfigurar.Text = "Configuracion"
        Me.btnConfigurar.UseVisualStyleBackColor = True
        '
        'btnReporCat
        '
        Me.btnReporCat.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnReporCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporCat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnReporCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReporCat.Location = New System.Drawing.Point(305, 40)
        Me.btnReporCat.Name = "btnReporCat"
        Me.btnReporCat.Size = New System.Drawing.Size(179, 28)
        Me.btnReporCat.TabIndex = 17
        Me.btnReporCat.Text = "Categoria"
        Me.btnReporCat.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Transparent
        Me.btnReporte.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReporte.Location = New System.Drawing.Point(305, 4)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(179, 31)
        Me.btnReporte.TabIndex = 16
        Me.btnReporte.Text = "REPORTES"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnRerporPro
        '
        Me.btnRerporPro.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnRerporPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRerporPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRerporPro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRerporPro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRerporPro.Location = New System.Drawing.Point(305, 64)
        Me.btnRerporPro.Name = "btnRerporPro"
        Me.btnRerporPro.Size = New System.Drawing.Size(179, 28)
        Me.btnRerporPro.TabIndex = 15
        Me.btnRerporPro.Text = "Producto"
        Me.btnRerporPro.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(674, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 31)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnBackup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackup.Location = New System.Drawing.Point(3, 91)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(112, 28)
        Me.btnBackup.TabIndex = 21
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnventas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnventas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnventas.Location = New System.Drawing.Point(490, 40)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(179, 28)
        Me.btnventas.TabIndex = 25
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnVenta.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVenta.Location = New System.Drawing.Point(490, 4)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(179, 31)
        Me.btnVenta.TabIndex = 24
        Me.btnVenta.Text = "VENTA"
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackgroundImage = Global.sisventas.My.Resources.Resources.fond
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCliente.Location = New System.Drawing.Point(120, 91)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(179, 28)
        Me.btnCliente.TabIndex = 23
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'frminicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sisventas.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(1232, 786)
        Me.Controls.Add(Me.btnventas)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReporCat)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnRerporPro)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnConfigurar)
        Me.Controls.Add(Me.btnCat)
        Me.Controls.Add(Me.btnMante)
        Me.Controls.Add(Me.btnPro)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frminicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. Sistema de Ventas .:."
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents btnPro As System.Windows.Forms.Button
    Friend WithEvents btnMante As System.Windows.Forms.Button
    Friend WithEvents btnCat As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnConfigurar As System.Windows.Forms.Button
    Friend WithEvents btnReporCat As System.Windows.Forms.Button
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnRerporPro As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
