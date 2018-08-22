Option Strict On
Public Class configuracion

    Private conf As New Configexp

    Private Sub configuracion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim configuracion(4) As String, habilitar, en1, en2, sl1, sl2 As Integer
        configuracion = conf.ConfApp()
        If Not configuracion(0).Equals("") Then
            habilitar = CInt(configuracion(0))
        End If
        If Not configuracion(1).Equals("") Then
            en1 = CInt(configuracion(1))
        End If
        If Not configuracion(2).Equals("") Then
            sl1 = CInt(configuracion(2))
        End If
        If Not configuracion(3).Equals("") Then
            en2 = CInt(configuracion(3))
        End If
        If Not configuracion(4).Equals("") Then
            sl2 = CInt(configuracion(4))
        End If
        tbpass.Text = conf.passwd()
        tbpassconf.Text = tbpass.Text()
        If conf.paginicio().Equals("") Then
            tbPagina.Text = "http://"
        Else
            tbPagina.Text = conf.paginicio()
        End If
        If habilitar = 1 Then
            cbHabilitar.Checked = True
            mt1.Enabled = True
            mt1.Text = en1.ToString()
            mt2.Enabled = True
            mt2.Text = sl1.ToString()
            mt3.Enabled = True
            mt3.Text = en2.ToString()
            mt4.Enabled = True
            mt4.Text = sl2.ToString()
        Else
            cbHabilitar.Checked = False
            mt1.Enabled = False
            mt1.Text = ""
            mt2.Enabled = False
            mt2.Text = ""
            mt3.Enabled = False
            mt3.Text = ""
            mt4.Enabled = False
            mt4.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        explorador.ConfiguraciónToolStripMenuItem1.Enabled = True
        Me.Dispose()
    End Sub
    'Guardar Configuración
    Private Sub btnGuardar1_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar1.Click
        Dim e1, e2, s1, s2 As String
        e1 = mt1.Text
        s1 = mt2.Text
        e2 = mt3.Text
        s2 = mt4.Text
        If cbHabilitar.Checked = True Then 'Bloqueo habilitado
            If conf.Actualizar("1", e1, s1, e2, s2) = False Then
                MessageBox.Show("Error al guardar los cambios de bloqueo. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not tbpass.Text.Equals(tbpassconf.Text) Then
                MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tbpass.Focus()
                Exit Sub
            Else
                If conf.UpPwd(tbpass.Text()) = False Then
                    MessageBox.Show("Error al guardar los cambios de contraseña. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If conf.Uppaginicio(tbPagina.Text()) = False Then
                    MessageBox.Show("Error al guardar la pagina de inicio. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else 'Si esta deshabilitado el bloqueo
            If conf.Actualizar("0", "", "", "", "") = False Then
                MessageBox.Show("Error al guardar los cambios de bloqueo. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not tbpass.Text.Equals(tbpassconf.Text) Then
                MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tbpass.Focus()
                Exit Sub
            Else
                If conf.UpPwd(tbpass.Text()) = False Then
                    MessageBox.Show("Error al guardar los cambios de contraseña. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If conf.Uppaginicio(tbPagina.Text()) = False Then
                    MessageBox.Show("Error al guardar la pagina de inicio. Porfavor,revise que la informacion ingresada sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
        Me.Dispose()
    End Sub

    Private Sub cbHabilitar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbHabilitar.CheckedChanged
        If cbHabilitar.Checked = True Then
            mt1.Enabled = True
            mt2.Enabled = True
            mt3.Enabled = True
            mt4.Enabled = True
            mt1.Text = ""
            mt2.Text = ""
            mt3.Text = ""
            mt4.Text = ""
        Else
            mt1.Enabled = False
            mt2.Enabled = False
            mt3.Enabled = False
            mt4.Enabled = False
            mt1.Text = ""
            mt2.Text = ""
            mt3.Text = ""
            mt4.Text = ""
        End If
    End Sub

    Private Sub configuracion_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        explorador.ConfiguraciónToolStripMenuItem1.Enabled = True
        Me.Dispose()
    End Sub
End Class