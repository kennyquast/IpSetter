Imports System

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentIP()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeIP()

    End Sub
    Private Sub ChangeIP()

        Dim psi As New ProcessStartInfo("cmd", "/c netsh interface ipv4 set address name=""Local Area Connection"" static 10.102.20.254 255.255.0.0")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = False
        psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False

        Dim process As Process = Process.Start(psi)

        process.WaitForExit()
        'trigger the command to change my IP address

        'update Form label to reflect new IP
        Timer1.Enabled = True




    End Sub
    Public Sub GetCurrentIP()
        Dim strIPAddress As String
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(1).ToString()
        If strIPAddress = "127.0.0.1" Then
            lblCurrentIpAddress.Text = "Updating IP Address ... Please Wait"
        Else

            lblCurrentIpAddress.Text = strIPAddress
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        GetCurrentIP()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'trigger the command to change my IP address
        Process.Start("cmd", "/c netsh interface ipv4 set address ""Local Area Connection"" dhcp")

        'update Form label to reflect new IP

        GetCurrentIP()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Application.Exit()

    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        MessageBox.Show("This is a down and dirty way for me to change my Ip address from DHCP to STATIC and back, while working on PLC's, Cameras and other equiptment at work", "About IP Setter v0.0.0.1")
    End Sub
End Class
