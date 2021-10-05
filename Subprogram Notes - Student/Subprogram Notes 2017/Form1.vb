Public Class Form1
    'SUBPROGRAMS
    '1. Helps us:
    '    a. Reuse repeated code
    '    b. Break up large complex tasks into smaller ones
    '2. Each subprogram has a name that is used to call it
    '3. If you call a subprogram, then its code executes
    '4. You can send PARAMETERS to the subprogram inside its ( ) 

    'SUB SHOWMULTIPLES
    'PARAMETER: num 
    'TASK: Shows the multiples of num up to 10,000


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shows the multiples of 5 up to 10,000

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Shows the multiples of 25 up to 10,000

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Shows the multiples of 200 up to 10,000

    End Sub

    'SUB HOLIDAYMESSAGE
    'Parameter:
    'Task: 
    Sub holidayMessage(holiday As String)
        MsgBox("Happy " & holiday & "!")
        MsgBox(holiday & " is the best because you can eat sweets!")
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Call the sub with "Halloween"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Call the sub with "Thanksgiving"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Call the sub with "Valentine's Day"

    End Sub

    'DISPLAYWINNER
    'Parameters: 
    'Task:



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim r As New Random
        Dim player1Score, player2Score As Integer

        player1Score = r.Next(20, 30)
        player2Score = r.Next(10, 40)

        'Uncomment the next line once the sub is written
        'displayWinner(player1Score, player2Score)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim base, height As Integer
        base = InputBox("What is the base of your triangle?")
        height = InputBox("What is the height of your triangle?")

        'Write a subprogram called displayArea that takes parameters
        'for the base and height. The subprogram should compute and display 
        'the area in a message box. Area = 0.5 * base * height

        'Call your subprogram below

    End Sub
End Class
