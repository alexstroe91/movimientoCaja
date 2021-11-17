Public Class frmPrincipal
    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            lblImagen.Top += 10
        End If
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajusto la posicion de la caja a la mitad
        lblImagen.Top = Me.Height / 6
        lblImagen.Left = Me.Width / 2.25
    End Sub

End Class
