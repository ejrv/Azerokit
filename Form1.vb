Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("cmd", "/k adb devices -t && pause")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Process.Start("cmd", "/k adb install app.apk -t && pause")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Process.Start("cmd", "/k fastboot recovery recovery.img -t && pause")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Process.Start("cmd", "/k fastboot flash kernel.img -t && pause")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Process.Start("cmd", "/k fastboot flash recovery.img -t && pause")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Process.Start("cmd", "/k fastboot boot recovery.img -t && pause")
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Process.Start("cmd", "/k adb install f.apk -t && echo Now open the Framaroot app and Click Anagorn, Gandalf or Any other. && pause")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Process.Start("cmd", "/k dontopen.bat -t")
    End Sub
End Class
