Imports System.ComponentModel
Imports System.IO 'Para la lectura de archivos.
Imports System.Configuration 'Para importar el fichero de configuracion de la aplicación
Imports System.Collections.Specialized
Imports System.Xml
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text

Public Class explorador

    Public pag As Object
    Dim i As Int16 = 1 'LLeva el contador de pestañas.
    Private conf As New Configexp
    Private inicio As String 'Pagina de inicio

    Private Sub btnHome_Click(sender As System.Object, e As System.EventArgs)
        Home(1)
    End Sub
    'Manejo la nueva ventana que se abrira.
    Private Sub NuevaVentana(sender As Object, e As CancelEventArgs)
        Try
            If BuscarTexto("http", CType(sender, WebBrowser).StatusText.ToString()) = True Then 'Si es un link entrara,si no,no hara nada
                e.Cancel = True        'Cancela la nueva ventana en internet explorer
                Dim browse As New WebBrowser
                browse.IsWebBrowserContextMenuEnabled = False
                browse.ContextMenuStrip = Menubrowser
                browse.ScriptErrorsSuppressed = True
                browse.Navigate(CType(sender, WebBrowser).StatusText.ToString())
                tcTabs.TabPages.Add(i, "Nueva pestaña")
                tcTabs.SelectTab(i - 1)
                browse.Name = "wb"
                browse.Dock = DockStyle.Fill
                tcTabs.SelectedTab.Controls.Add(browse)
                i = i + 1
                AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).NewWindow, AddressOf NuevaVentana
                AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).ProgressChanged, New WebBrowserProgressChangedEventHandler(AddressOf CargarBarra)
                AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
                AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigated, New WebBrowserNavigatedEventHandler(AddressOf Validar)
            Else
                e.Cancel = True        'Cancela la nueva ventana en internet explorer
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    'Al cargar el programa.
    Private Sub explorador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim actual As Date = Format(Date.Now(), "dd-MM-yyyy")
        'If actual > CDate("10-02-2017") Then
        'MessageBox.Show("El tiempo de uso ha expirado.Porfavor Contactese con PGSys.", "Licencia caducada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Application.Exit()
        'End If
        'Aqui validar si el horario esta dentro de lo laboral o no.(Siempre y cuando este activada esta opcion)
        Dim cadena(4) As String
        cadena = conf.ConfApp()
        If Not cadena(0).Equals("") Then 'Si la cadena no esta vacia tomara su valor
            bqo = CInt(cadena(0))
        Else 'si esta vacia tomara el valor por defecto para bloquearse
            bqo = 1
        End If
        If bqo = 1 Then 'Esta activada
            Try
                If DateTime.Now.Hour >= CInt(cadena(1)) And DateTime.Now.Hour < CInt(cadena(2)) Then
                    tbDireccion.Enabled = False
                    btnIr.Enabled = False
                ElseIf DateTime.Now.Hour >= CInt(cadena(3)) And DateTime.Now.Hour < CInt(cadena(4)) Then
                    tbDireccion.Enabled = False
                    btnIr.Enabled = False
                End If
            Catch ex As Exception
                tbDireccion.Enabled = False
                btnIr.Enabled = False
            End Try
        Else 'Esta desactivada
            tbDireccion.Enabled = True
            btnIr.Enabled = True
        End If
        If Not bwCargar.IsBusy Then
            bwCargar.RunWorkerAsync()
        End If
        Home(2)
        'MiIP()
    End Sub
    'Lleno el combobox con los sitios permitidos
    Private Sub llenarPermitidos()
        Dim con As New confsts, perm As New ArrayList, st As sitios, dr, dr2 As DataRow
        perm = con.Sitios()
        Dim dt As DataTable = New DataTable("Permitidos")
        dt.Columns.Add("url")
        dt.Columns.Add("Nombre")
        dr2 = dt.NewRow
        dr2("url") = ""
        dr2("Nombre") = "Seleccione un sitio"
        dt.Rows.Add(dr2)
        For Each st In perm
            dr = dt.NewRow()
            dr("url") = st.Dir
            dr("Nombre") = st.Nomb
            dt.Rows.Add(dr)
        Next
        'Ahora los cargo en el combobox
        cbPermitidos.DataSource = dt
        cbPermitidos.ValueMember = "url"
        cbPermitidos.DisplayMember = "nombre"
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs)
        Home(2)
    End Sub
    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs)
        If i > 1 Then
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Dispose()
            tcTabs.TabPages.RemoveAt(tcTabs.SelectedIndex)
            i = i - 1
        End If
    End Sub
    'Cargara el titulo para las pestañas despues de que haya terminado de cargar la pagina.
    Private Sub CargarTitulo(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Try
            tcTabs.SelectedTab.Text = CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Barra de progreso
    Private Sub CargarBarra(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs)
        bpcarga.Maximum = e.MaximumProgress
        bpcarga.Value = e.MaximumProgress
    End Sub

    Private Sub Cargar()
        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).ProgressChanged, New WebBrowserProgressChangedEventHandler(AddressOf CargarBarra)
        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbDireccion.Text)
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Focus()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Print()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub DesactivarModoProtegidoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DesactivarModoProtegidoToolStripMenuItem.Click
        Dim desactivar As New inputbox
        desactivar.var = 1
        desactivar.Show()
    End Sub

    Private Sub cbPermitidos_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cbPermitidos.SelectionChangeCommitted
        If i = 1 Then
            Dim browse As New WebBrowser
            browse.ScriptErrorsSuppressed = True
            browse.IsWebBrowserContextMenuEnabled = False
            browse.ContextMenuStrip = Menubrowser
            browse.Navigate(cbPermitidos.SelectedValue)
            tcTabs.TabPages.Add(i, "Nueva pestaña")
            tcTabs.SelectTab(i - 1)
            browse.Name = "wb"
            browse.Dock = DockStyle.Fill
            tcTabs.SelectedTab.Controls.Add(browse)
            i = i + 1

            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).NewWindow, AddressOf NuevaVentana
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).ProgressChanged, New WebBrowserProgressChangedEventHandler(AddressOf CargarBarra)
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigated, New WebBrowserNavigatedEventHandler(AddressOf Validar)
            browse.Focus()
        Else
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(cbPermitidos.SelectedValue) 'Va a la pagina de inicio.
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Focus()
        End If
    End Sub

    Private Sub AdministrarSitiosPermitidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdministrarSitiosPermitidosToolStripMenuItem.Click
        Dim desactivar As New inputbox
        desactivar.var = 2
        desactivar.Show()
    End Sub

    Private Sub explorador_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        llenarPermitidos()
    End Sub

    Private Sub Home(ByVal ejec As Integer)
        If ejec = 2 Then 'Si agrega una pestaña
            Dim browse As New WebBrowser
            browse.IsWebBrowserContextMenuEnabled = False
            browse.ContextMenuStrip = Menubrowser
            browse.ScriptErrorsSuppressed = True
            If pag = Nothing Then
                browse.Navigate(inicio)
            Else
                browse.Navigate(CType(pag, WebBrowser).Url.ToString())
            End If
            tcTabs.TabPages.Add(i, "Nueva pestaña")
            tcTabs.SelectTab(i - 1)
            browse.Name = "wb"
            browse.Dock = DockStyle.Fill
            tcTabs.SelectedTab.Controls.Add(browse)
            i = i + 1
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).NewWindow, AddressOf NuevaVentana
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).ProgressChanged, New WebBrowserProgressChangedEventHandler(AddressOf CargarBarra)
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigated, New WebBrowserNavigatedEventHandler(AddressOf Validar)
        Else 'Si va al home
            If pag = Nothing Then
                CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(inicio) 'Va a la pagina de inicio.
            Else
                CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(CType(pag, WebBrowser).Url.ToString()) 'Va a la pagina de inicio.
            End If
            AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
        End If
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem1.Click
        Dim desactivar As New inputbox
        desactivar.var = 3
        desactivar.Show()
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String
        Try
            If Directory.Exists("C:\Navegador Asa") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory("C:\Navegador Asa")
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = "C:\Navegador Asa\Sitios" & Format(Today.Date, "ddMMyyyy") & ".txt" ' Se determina el nombre del archivo con la fecha actual
            'verificamos si existe el archivo
            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If
            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
            'escribimos en el archivo
            Dim con As New confsts, perm As New ArrayList, st As sitios
            perm = con.Sitios()
            For Each st In perm
                strStreamWriter.WriteLine(Encriptar(st.Cod) & ";" & Encriptar(st.Nomb) & ";" & Encriptar(st.Dir))
            Next
            strStreamWriter.Close() ' cerramos
        Catch ex As Exception
            MessageBox.Show("Error al intentar generar el archivo. Error: " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportarToolStripMenuItem.Click
        Dim archivo As String = ""
        Dim oFD As New OpenFileDialog 'Defino un cuadro de dialogo
        With oFD
            .Filter = "Archivo Plano (*.txt)|*.txt" 'Indico el tipo de archivos que puede buscar.
            If .ShowDialog = DialogResult.OK Then 'Si lo encuentra y da click en aceptar,cargara la ruta en el textbox
                archivo = .FileName
            End If
        End With
        If Not archivo.Equals("") Then
            Dim sr As New System.IO.StreamReader(archivo), arrsts As New ArrayList
            Dim linea As String, i, j As Int16
            i = 0
            j = 0
            Do
                linea = sr.ReadLine()
                If Not linea Is Nothing Then
                    Dim datos() As String = Split(linea, ";")
                    Dim sts As New sitios
                    sts.Cod = Desencriptar(datos(0))
                    sts.Nomb = Desencriptar(datos(1))
                    sts.Dir = Desencriptar(datos(2))
                    arrsts.Add(sts)
                    End If
            Loop Until linea Is Nothing
            sr.Close()
            Dim con As New confsts
            If con.Actualizar(arrsts) = False Then
                MessageBox.Show("Error al importar los sitios.", "Sitios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    'Muestra el texto de carga
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            ToolStripStatusLabel1.Text = CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).StatusText.ToString()
            tbDireccion.Text = CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbrirEnUnaNuevaPestañaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirEnUnaNuevaPestañaToolStripMenuItem.Click
        Dim browse As New WebBrowser
        browse.IsWebBrowserContextMenuEnabled = False
        browse.ContextMenuStrip = Menubrowser
        browse.ScriptErrorsSuppressed = True
        browse.Navigate(CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).StatusText.ToString())
        tcTabs.TabPages.Add(i, "Nueva pestaña")
        tcTabs.SelectTab(i - 1)
        browse.Name = "wb"
        browse.Dock = DockStyle.Fill
        tcTabs.SelectedTab.Controls.Add(browse)
        i = i + 1

        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).NewWindow, AddressOf NuevaVentana
        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).ProgressChanged, New WebBrowserProgressChangedEventHandler(AddressOf CargarBarra)
        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf CargarTitulo)
        AddHandler CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigated, New WebBrowserNavigatedEventHandler(AddressOf Validar)
    End Sub
    Private Sub AbrirEnUnaNuevaVentanaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirEnUnaNuevaVentanaToolStripMenuItem.Click
        Dim newvent As explorador
        newvent = New explorador
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).StatusText.ToString())
        newvent.Show()
        newvent = Nothing
    End Sub
    'Validar que la pagina que esta cargando es valida
    Private Sub Validar(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
        If bqo = 1 Then
            If Filtro(CType(sender, WebBrowser).Url.ToString()) = True Then
                MessageBox.Show("Sitio Web Bloqueado.Será redirigido a la pagina de inicio.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Stop()
                CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(inicio)
            End If
        End If
    End Sub

    Private Sub tbDireccion_Click(sender As System.Object, e As System.EventArgs)
            if bqo=0 then
            Timer1.Stop()
            end if
    End Sub

    Private Sub NuevaPestañaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        Home(2)
    End Sub

    Private Sub EliminarPestañaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarPestañaToolStripMenuItem.Click
        If i > 1 Then
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Dispose()
            tcTabs.TabPages.RemoveAt(tcTabs.SelectedIndex)
            i = i - 1
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub AcercadeToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AcercadeToolStripMenuItem2.Click
        Dim acd As New acercade
        acd.Show()
    End Sub

    Private Sub ContactarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ContactarToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("mailto:matiasherrera@pgsys.cl?subject=Consulta Explorador Asa")
    End Sub

    Private Sub tbDireccion_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbDireccion.MouseClick
        If bqo = 0 Then
            Timer1.Stop()
            tbDireccion.SelectAll()
        End If
    End Sub
    'Al momento de ingresar una direccion y presionar enter,tendra la misma validez que hacer click en el boton IR
    Private Sub tbDireccion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Timer1.Start()
            Cargar()
        End If
    End Sub

    Private Sub bwCargar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCargar.DoWork
        inicio = conf.paginicio()
        llenarPermitidos()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Timer1.Start()
        Cargar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
            CType(tcTabs.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        End If
    End Sub
End Class
