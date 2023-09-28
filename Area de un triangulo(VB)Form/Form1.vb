Public Class Form1
    Private Sub BtnRespuesta_Click(sender As Object, e As EventArgs) Handles BtnRespuesta.Click
        Dim base As Integer
        Dim altura As Integer

        If Integer.TryParse(TextBox1.Text, base) AndAlso Integer.TryParse(TextBox2.Text, altura) Then
            ' Calcula el área
            Dim area As Integer = base * altura / 2

            ' Muestra el resultado en un cuadro de texto o etiqueta en el formulario
            TextBox3.Text = area.ToString()
        Else
            ' Muestra un mensaje de error si la entrada no es válida
            MessageBox.Show("Por favor, ingrese valores numéricos válidos para la base y la altura.")
        End If
    End Sub
End Class
