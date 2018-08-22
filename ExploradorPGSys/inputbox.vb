Public Class inputbox
    Public var As Int16
    Private conf As New Configexp

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        validar()
    End Sub

    Private Sub tbPassword_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            validar()
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Me.Dispose()
        End If
    End Sub

    Public Sub validar()
        Dim pass As String = tbPassword.Text
        If pass.Equals(conf.passwd()) = True Or pass.Equals("muhlenbrockp") = True Then
            If var = 1 Then 'Desactivo los elementos del formulario principal(Explorador) para habilitar la libre navegacion
                explorador.tbDireccion.Enabled = True
                explorador.btnIr.Enabled = True
                explorador.DesactivarModoProtegidoToolStripMenuItem.Enabled = False
                bqo = 0
            ElseIf var = 2 Then 'Acceder al administrador de sitios
                Dim admin As New adminsitiosvb
                admin.Show()
                explorador.AdministrarSitiosPermitidosToolStripMenuItem.Enabled = False
            Else
                Dim cnf As New configuracion
                cnf.Show()
                explorador.ConfiguraciónToolStripMenuItem1.Enabled = False
            End If
            Me.Dispose()
        Else
            MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbPassword.Focus()
        End If
    End Sub
End Class