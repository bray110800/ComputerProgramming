'Bri Ray 4/11/16

Public Class Lockers

    Dim n As Integer = 2   'accumulator for the for loop in the simulate button sub
    Structure Locker
        Dim status As String   'changed from boolean to string
    End Structure

    Dim lockers(100) As Locker

    Private Sub btnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitialize.Click
        'set all the locker statuses to open
        For i As Integer = 0 To 99
            lockers(i).status = "Opened"
        Next

        Me.ListBox.Items.Clear()
        'add the statuses of the lockers to the listbox by using a loop
        Me.ListBox.Items.Add("Locker" & vbTab & "Status" & vbCrLf)
        For j As Integer = 1 To 100
            Me.ListBox.Items.Add(j & vbTab & lockers(j - 1).status & vbCrLf)
        Next

        n = 2
    End Sub

    Private Sub btnSimulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimulate.Click
        'loop to change the statuses of the lockers
        For i As Integer = 0 To 100 Step n
            If lockers(i).status = "Opened" Then
                lockers(i).status = "Closed"
            Else
                lockers(i).status = "Opened"
            End If

        Next

        'edit 4/13/16 : will make array(100) so that locker 0 will not be shown but will be counted in the previous
        'loop. i think it worked okay cool

        Me.ListBox.Items.Clear()
        Me.ListBox.Items.Add("Locker" & vbTab & "Status" & vbCrLf)

        For j As Integer = 1 To 100
            Me.ListBox.Items.Add(j & vbTab & lockers(j).status & vbCrLf)
        Next

        n += 1
    End Sub
End Class
