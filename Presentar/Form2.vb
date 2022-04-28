Imports System.IO
Imports System.Data.OleDb
Public Class Form2
    Public wc As New Net.WebClient
    Dim ipconfig As String
    Dim valida As Boolean
    Dim validaip As Boolean
    Dim filaActualip As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            If ListBox1.SelectedIndex <> -1 Then
                Dim indice As Integer = ListBox1.SelectedIndex
                ListBox1.SelectedIndex = indice + 1
            End If
            TextBox1.Text = ListBox1.SelectedIndex
            TextBox2.Text = ListBox1.SelectedIndex + 1
            TextBox3.Text = ListBox1.Items(TextBox1.Text)
            TextBox4.Text = ListBox1.Items(TextBox2.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "txt|*.txt"
        Dim resultadoOFD As String
        OFD.ShowDialog()
        'resultadoOFD = OFD.FileName
        resultadoOFD = OFD.FileName
        Me.Text = "SAMNET VMIX - " + resultadoOFD
        Try
            'TextBox7.Text = File.ReadLines(resultadoOFD)(0)
            TextBox5.Text = File.ReadAllText(resultadoOFD)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox5.Lines)
    End Sub

    Private Sub ASIGÍSTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGÍSTAToolStripMenuItem.Click
        Dim BTN As String
        BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
        TextBox7.Text = BTN
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim guardar As String
        guardar = Button4.Text
        Select Case guardar
            Case "GUARDAR_IP"
                ipconfig = TextBox6.Text
                validaip = validardatosip(ipconfig)
                If validaip = True Then
                    DataGridView1.Rows.Add(ipconfig)
                    guardardatosip()
                    TextBox6.Enabled = False
                    Button4.Text = "CAMBIAR_IP"
                End If
            Case "CAMBIAR_IP"
                Dim BTN As String
                BTN = InputBox("ESCRIBA NUEVO IP DEL VMIX", "IP VMIX")
                TextBox6.Text = BTN
                Button4.Text = "GUARDAR_CAMBIO"

            Case "GUARDAR_CAMBIO"
                ipconfig = TextBox6.Text
                validaip = validardatosip(ipconfig)
                filaActualip = DataGridView1.CurrentRow.Index
                If validaip = True Then
                    DataGridView1.Rows(filaActualip).Cells("ColumnIP").Value = ipconfig
                    MsgBox("IP VMIX ACTUALIZADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
                    TextBox6.Enabled = False
                    Button4.Text = "CAMBIAR_IP"
                End If
        End Select
    End Sub
    Function validardatosip(paripconfig As String) As Boolean
        If paripconfig = "" Then
            MsgBox("IP VMIX ESTA VACIO", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            ErrorProvider1.SetError(TextBox6, "INGRESE IP VMIX")
            TextBox6.Focus()
            valida = False
        Else
            valida = True
            ErrorProvider1.SetError(TextBox6, "")
            guardardatosip()
        End If
        Return valida
    End Function
    Private Sub guardardatosip()
        Dim archivo_escritura As StreamWriter
        Dim linea As String
        archivo_escritura = New StreamWriter("./samnetip2.txt")
        With DataGridView1
            For y = 0 To .RowCount - 1
                linea = .Rows(y).Cells("ColumnIP").Value & ";"
                archivo_escritura.WriteLine(linea)
            Next

        End With
        archivo_escritura.Close()
    End Sub

    Private Sub Overlay01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay01ToolStripMenuItem.Click
        TextBox8.Text = "1"
    End Sub

    Private Sub Overlay02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay02ToolStripMenuItem.Click
        TextBox8.Text = "2"
    End Sub

    Private Sub Overlay03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay03ToolStripMenuItem.Click
        TextBox8.Text = "3"
    End Sub

    Private Sub Overlay04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay04ToolStripMenuItem.Click
        TextBox8.Text = "4"
    End Sub

    Private Sub InsertarIPVMIXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarIPVMIXToolStripMenuItem.Click
        Dim BTN As String
        BTN = InputBox("ESCRIBA NUMERO DE IP DEL VMIX", "IP VMIX")
        TextBox6.Text = BTN
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim archivo_leerip As StreamReader
            archivo_leerip = New StreamReader("./samnetip2.txt")
            While Not archivo_leerip.EndOfStream
                Dim cadenaip As String = archivo_leerip.ReadLine
                Dim leerip As String() = cadenaip.Split(New Char() {";"})
                DataGridView1.Rows.Add(leerip)
                filaActualip = DataGridView1.CurrentRow.Index
                TextBox6.Text = DataGridView1.Rows(filaActualip).Cells("ColumnIP").Value
            End While
            archivo_leerip.Close()
        Catch ex As Exception

        End Try
        If TextBox6.Text = "" Then
            Button4.Text = "GUARDAR_IP"
        Else
            Button4.Text = "CAMBIAR_IP"
        End If

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim pregnta As String
        pregnta = MsgBox("DESEA GUARDAR LOS DATOS?", MsgBoxStyle.YesNo, "INFORMACION SAMNET")
        If pregnta = vbYes Then
            guardardatosip()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=0&Input=" + TextBox7.Text + "&Value=" + TextBox3.Text)
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=1&Input=" + TextBox7.Text + "&Value=" + TextBox4.Text)
            wc.DownloadString(TextBox6.Text + "/api/?Function=OverlayInput" + TextBox8.Text + "in&Input=" + TextBox7.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox6.Focus()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Try
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=0&Input=" + TextBox7.Text + "&Value=" + TextBox3.Text)
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=1&Input=" + TextBox7.Text + "&Value=" + TextBox4.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox6.Focus()
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=0&Input=" + TextBox7.Text + "&Value=" + TextBox3.Text)
            wc.DownloadString(TextBox6.Text + "/API/?Function=SetText&SelectedIndex=1&Input=" + TextBox7.Text + "&Value=" + TextBox4.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox6.Focus()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            wc.DownloadString(TextBox6.Text + "/api/?Function=OverlayInput" + TextBox8.Text + "out&Input=" + TextBox7.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox6.Focus()
        End Try
    End Sub
End Class