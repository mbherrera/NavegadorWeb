Public Class adminsitiosvb

    Private con As New confsts
    Private dt As DataTable = New DataTable("Permitidos")

    Private Sub adminsitiosvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim perm As New ArrayList, st As sitios, cod As Int16
        perm = con.Sitios()
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Direccion")
        dt.Columns.Add("Nombre")
        For Each st In perm
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("Codigo") = st.Cod
            dr("Direccion") = st.Dir
            dr("Nombre") = st.Nomb
            dt.Rows.Add(dr)
            cod = st.Cod
        Next
        dtvSitios.DataSource = dt
        dtvSitios.Columns(0).Width = 50
        dtvSitios.Columns(1).Width = 200
        dtvSitios.Columns(2).Width = 190
        dtvSitios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        agregar(cod + 1)
        Me.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        cerrar()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim arr As New ArrayList, sts As sitios
        If dtvSitios.RowCount() > 0 Then
            For Each row As DataGridViewRow In dtvSitios.Rows
                If row.Cells(0).Value.ToString = "" Then
                    MessageBox.Show("Debe ingresar un código para el sitio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                ElseIf row.Cells(1).Value.ToString = "" Then
                    MessageBox.Show("Debe ingresar una dirección valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                ElseIf row.Cells(2).Value.ToString = "" Then
                    MessageBox.Show("Debe ingresar un nombre valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                sts = New sitios()
                sts.Cod = CInt(row.Cells(0).Value)
                sts.Dir = CStr(row.Cells(1).Value)
                sts.Nomb = CStr(row.Cells(2).Value)
                arr.Add(sts)
            Next
            If con.Actualizar(arr) = True Then
                cerrar()
            Else
                MessageBox.Show("Error al actualizar los sitios,porfavor vuelva a intentarlo.", "Administrador de Sitios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe ingresar al menos un sitio web.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Codigo") = tbCodigo.Text
        dr("Direccion") = tbDireccion.Text
        dr("Nombre") = tbNombre.Text
        dt.Rows.Add(dr)
        dtvSitios.DataSource = dt
        dtvSitios.Columns(0).Width = 50
        dtvSitios.Columns(1).Width = 200
        dtvSitios.Columns(2).Width = 190
        dtvSitios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        agregar(CInt(tbCodigo.Text) + 1)
        Me.dtvSitios.Focus()
    End Sub

    Private Sub adminsitiosvb_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cerrar()
    End Sub

    Public Sub agregar(ByVal cod As Integer)
        tbCodigo.Text = cod
        tbDireccion.Text = "http://"
        tbNombre.Text = ""
    End Sub

    Public Sub cerrar()
        explorador.AdministrarSitiosPermitidosToolStripMenuItem.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub dtvSitios_KeyDown(sender As Object, e As KeyEventArgs) Handles dtvSitios.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.dtvSitios.Rows.Remove(Me.dtvSitios.CurrentRow)
        End If
    End Sub
End Class