Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bill1, bill2 As Byte
        ListBox1.Items.Clear()
        'For bill1 = 1 To 5
        '    ListBox1.Items.Add(bill1 & ".")
        '    For bill2 = 1 To 5
        '        ListBox1.Items.Add(bill1 & "." & bill2)
        '    Next
        'Next

        'bill1 = 1
        'Do While bill1 <= 5
        '    ListBox1.Items.Add(bill1 & ".")
        '    bill2 = 1
        '    Do While bill2 <= 5
        '        ListBox1.Items.Add(bill1 & "." & bill2)
        '        bill2 = bill2 + 1
        '    Loop
        '    bill1 = bill1 + 1
        'Loop

        bill1 = 1
        Do Until bill1 > 5
            ListBox1.Items.Add(bill1 & ".")
            bill2 = 1
            Do Until bill2 > 5
                ListBox1.Items.Add(bill1 & "." & bill2)
                bill2 = bill2 + 1
            Loop
            bill1 = bill1 + 1
        Loop
    End Sub
End Class
