Option Strict On

Public Class Form1

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        ' Read the input from the user
        Dim st As String
        st = InputBox("Please type the initial string")
        Dim i As Integer
        Dim c As Char
        Dim result As String = ""
        For i = (st.Length - 1) To 0 Step -1
            c = CChar(st.Substring(i, 1))
            result = result & CStr(c)
        Next
        ' Report the output to the user
        MessageBox.Show(result)
    End Sub
End Class
