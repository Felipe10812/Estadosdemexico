Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            Label3.Text = ComboBox1.SelectedItem.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex <> -1 Then
            Dim estadoSeleccionado As String = ComboBox1.SelectedItem.ToString()
            Label3.Text = estadoSeleccionado

            MessageBox.Show("Estado seleccionado: " & estadoSeleccionado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class


