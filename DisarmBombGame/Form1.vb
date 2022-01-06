Imports System.ComponentModel

Public Class Form1
    Public rnd As New Random
    Public correct As Integer = 0
    Public selection As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.alarm, AudioPlayMode.Background)
        correct = rnd.Next(1, 4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selection = 1

        If correct = selection Then
            MessageBox.Show("You Win!")
            Me.Dispose()
            Me.Close()
            Form2.Show()
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.boom, AudioPlayMode.Background)
            MessageBox.Show("You Loose!")
            Threading.Thread.Sleep(1000)
            Me.Dispose()
            Me.Close()
            Form2.Show()
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selection = 2

        If correct = selection Then
            MessageBox.Show("You Win!")
            Me.Dispose()
            Me.Close()
            Form2.Show()

        Else
            My.Computer.Audio.Play(My.Resources.boom, AudioPlayMode.Background)
            MessageBox.Show("You Loose!")
            Threading.Thread.Sleep(1000)
            Me.Dispose()
            Me.Close()
            Form2.Show()
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selection = 3

        If correct = selection Then
            MessageBox.Show("You Win!")
            Me.Dispose()
            Me.Close()
            Form2.Show()
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.boom, AudioPlayMode.Background)
            MessageBox.Show("You Loose!")
            Threading.Thread.Sleep(1000)
            Me.Dispose()
            Me.Close()
            Form2.Show()
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub
End Class
