Imports System.Windows.Forms

Public Class frminicio
     
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcategoria.MdiParent = Me
        frmcategoria.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmproducto.MdiParent = Me
        frmproducto.Show()

    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmventa.MdiParent = Me
        frmventa.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcliente.MdiParent = Me
        frmcliente.Show()

    End Sub

    Private Sub ReporteDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmreporteproductos.MdiParent = Me
        frmreporteproductos.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmbackupbase.MdiParent = Me
        frmbackupbase.Show()
    End Sub

    Private Sub frminicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPro.Visible = False
        btnCat.Visible = False
        btnConfigurar.Visible = False
        btnBuscar.Visible = False
        btnBackup.Visible = False
        btnReporCat.Visible = False
        btnRerporPro.Visible = False
        btnBuscar.Visible = False
        btnventas.Visible = False
        btnCliente.Visible = False
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub btnPro_Click(sender As Object, e As EventArgs) Handles btnPro.Click
        frmproducto.MdiParent = Me
        frmproducto.Show()
        btnPro.Visible = False
        btnCat.Visible = False
    End Sub

    Private Sub btnMante_Click(sender As Object, e As EventArgs) Handles btnMante.Click
        btnPro.Visible = True
        btnCat.Visible = True
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        frmcategoria.MdiParent = Me
        frmcategoria.Show()
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False
    End Sub

    Private Sub btnRerporPro_Click(sender As Object, e As EventArgs) Handles btnRerporPro.Click
        frmreporteproductos.MdiParent = Me
        frmreporteproductos.Show()
    End Sub

    Private Sub btnConfigurar_Click(sender As Object, e As EventArgs) Handles btnConfigurar.Click
        frmbackupbase.MdiParent = Me
        frmbackupbase.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        frmbackupbase.MdiParent = Me
        frmbackupbase.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMante_MouseHover(sender As Object, e As EventArgs) Handles btnMante.MouseHover
        btnPro.Visible = True
        btnCat.Visible = True
        btnCliente.Visible = True

        btnventas.Visible = False

        btnReporCat.Visible = False
        btnRerporPro.Visible = False

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False

    End Sub

    Private Sub btnReporte_MouseHover(sender As Object, e As EventArgs) Handles btnReporte.MouseHover
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False

        btnventas.Visible = False

        btnReporCat.Visible = True
        btnRerporPro.Visible = True

    End Sub

    Private Sub MenuStrip_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseClick
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False

        btnventas.Visible = False

        btnReporCat.Visible = False
        btnRerporPro.Visible = False
    End Sub

    Private Sub piboxfondo_Click(sender As Object, e As EventArgs)
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False


        btnReporCat.Visible = False
        btnRerporPro.Visible = False
    End Sub

    Private Sub frminicio_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False


        btnReporCat.Visible = False
        btnRerporPro.Visible = False
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmcliente.MdiParent = Me
        frmcliente.Show()

        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False

    End Sub

    Private Sub btnVenta_MouseHover(sender As Object, e As EventArgs) Handles btnVenta.MouseHover
        btnPro.Visible = False
        btnCat.Visible = False
        btnCliente.Visible = False

        btnventas.Visible = True

        btnReporCat.Visible = False
        btnRerporPro.Visible = False
    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        frmventa.MdiParent = Me
        frmventa.Show()
    End Sub
End Class
