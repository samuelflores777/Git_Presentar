Imports System.IO
Imports System.Data.OleDb
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox3.Lines)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ValorSeleccionado As String
        If (Not (ListBox1.SelectedItem Is Nothing)) Then
            ValorSeleccionado = ListBox1.SelectedItem.ToString()
            TextBox2.Text = ValorSeleccionado
            TextBox1.Text = ValorSeleccionado
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ListBox1.Items.AddRange(TextBox2.Text.Split(vbNewLine))
        'Verificar si seleccionó un item
        If ListBox1.SelectedIndex <> -1 Then
            'Obtenemos el indice actual
            Dim indice As Integer = ListBox1.SelectedIndex
            ListBox1.SelectedIndex = indice + 1
            'If indice = 0 Then
            'Si indice es 0, está en el primer item, y lo pasamos al último elemento
            'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            'Else
            'Sino, pasamos al item anterior
            '   ListBox1.SelectedIndex = indice + 1
            'End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            TextBox2.Text = ListBox1.SelectedIndex
            TextBox4.Text = ListBox1.SelectedIndex + 1
            TextBox5.Text = ListBox1.Items(TextBox2.Text)
            TextBox6.Text = ListBox1.Items(TextBox4.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "txt|*.txt"
        Dim resultadoOFD As String
        OFD.ShowDialog()
        resultadoOFD = OFD.FileName
        Me.Text = "SAM CTRL VMIX - " + resultadoOFD
        Try
            'TextBox7.Text = File.ReadLines(resultadoOFD)(0)
            TextBox3.Text = File.ReadAllText(resultadoOFD)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "txt|*.txt"
        Dim ResultadoSFD As String
        SFD.ShowDialog()
        ResultadoSFD = SFD.FileName
        Me.Text = "SAM CTRL VMIX - " + ResultadoSFD
        My.Computer.FileSystem.WriteAllText(ResultadoSFD, TextBox7.Text & vbCrLf &
TextBox3.Text & vbCrLf & vbCrLf, False)
    End Sub
End Class
