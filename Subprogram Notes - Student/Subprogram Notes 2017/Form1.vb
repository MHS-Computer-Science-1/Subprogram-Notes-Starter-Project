Public Class Form1
    'SUBPROGRAMS
    '1. Helps us:
    '    a. Reuse repeated code
    '    b. Break up large complex tasks into smaller ones
    '2. Each subprogram has a name that is used to call it
    '3. If you call a subprogram, then its code executes
    '4. You can send PARAMETERS to the subprogram inside its ( ) 

    'Sub: SHOWMULTIPLES
    'Parameter: num 
    'Task: Shows the multiples of num up to 10,000


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shows the multiples of 5 up to 10,000


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Shows the multiples of 25 up to 10,000


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Shows the multiples of 200 up to 10,000


    End Sub

    'Sub: holidayMessage
    'Parameter:
    'Task: 
    Sub holidayMessage(holiday As String)
        MsgBox("Happy " & holiday & "!")
        MsgBox(holiday & " is the best because you can eat sweets!")
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Call sub for Halloween

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Call Sub for Thanksgiving

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Call sub for Valentine's Day

    End Sub

    'Sub: displayWinner
    'Parameters: 
    'Task:

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim r As New Random
        Dim player1Score, player2Score As Integer

        player1Score = r.Next(20, 30)
        player2Score = r.Next(10, 40)

        'Uncomment the line below once the displayWinner
        'Subprogram is complete

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

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'The code below counts from 10 to 1. We need to be 
        'able to start the countdown at any number

        'Create a subprogram called countdown that takes one
        'parameter representing the start number. Then, replace 
        'the code below with a call to your subprogram

        'Countdown from 10
        ListBox1.Items.Clear()
        Dim i As Integer
        For i = 10 To 1 Step -1
            ListBox1.Items.Add(i)
        Next
        ListBox1.Items.Add("Blastoff!")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Countdown from 100

        'Call your sub

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Countdown from 1000

        'Call your sub

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'The code below calls a subprogram called midpoint
        'Midpoint takes 4 parameters representing two points (x1, y1) and (x2, y2)
        'The subprogram should compute and display the midpoint as an ordered pair (mid_x, mid_y)

        'The midpoint is computed as follows:
        '   mid_x = (x1 + x2) / 2
        '   mid_y - (y1 + y2) / 2

        'Uncomment the line below to test your subprogram

        'midPoint(2, 5, 10, -7)
    End Sub
End Class
