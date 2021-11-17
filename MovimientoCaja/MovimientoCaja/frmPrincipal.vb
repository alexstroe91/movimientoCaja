Public Class frmPrincipal
    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'capturo las pulsaciones en las teclas y modifico la posicion del lblImagen
        If e.KeyCode = Keys.Down Then
            lblImagen.Top += 10
        End If

        If e.KeyCode = Keys.Up Then
            lblImagen.Top -= 10
        End If

        If e.KeyCode = Keys.Left Then
            lblImagen.Left -= 10
        End If

        If e.KeyCode = Keys.Right Then
            lblImagen.Left += 10
        End If

        'Pongo la informacion de .top y .left de la imagen
        lblLeft.Text = ".Left = " & lblImagen.Left
        lblTop.Text = ".Top = " & lblImagen.Top

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajusto la posicion de la caja a la mitad
        lblImagen.Top = Me.Height / 6
        lblImagen.Left = Me.Width / 2.25

        'Pongo la informacion de .top y .left de la imagen
        lblLeft.Text = ".Left = " & lblImagen.Left
        lblTop.Text = ".Top = " & lblImagen.Top
    End Sub

End Class
