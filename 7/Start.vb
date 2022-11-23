Public Class Start
    Private Sub S9_Click(sender As Object, e As EventArgs) Handles S9.Click
        Dim f As New GV1
        f.gm = 0
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub S3_Click(sender As Object, e As EventArgs) Handles S3.Click
        Dim f As New GV2
        f.gm = 0
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        Dim files As String() = System.Environment.GetCommandLineArgs()
        If files.Length > 1 Then
            Dim i As Integer
            Dim fn, fnl, fxn As String
            For i = 1 To files.Length - 1
                fn = files(i)
                fnl = fn.Length
                fxn = fn.Substring(fnl - 4)
                If fxn = ".sty" Then
                    MsgBox("対戦中断記録から再開します。", MsgBoxStyle.OkOnly, "確認")
                    Dim sr As New System.IO.StreamReader(fn, System.Text.Encoding.GetEncoding("shift_jis"))
                    Dim x As String
                    x = sr.ReadLine
                    If x = "1" Then
                        GV1.t = sr.ReadLine
                        GV1.f1a = sr.ReadLine
                        GV1.f2a = sr.ReadLine
                        GV1.f3a = sr.ReadLine
                        GV1.f4a = sr.ReadLine
                        GV1.f5a = sr.ReadLine
                        GV1.f6a = sr.ReadLine
                        GV1.f7a = sr.ReadLine
                        GV1.f8a = sr.ReadLine
                        GV1.f9a = sr.ReadLine
                        GV1.f1b = sr.ReadLine
                        GV1.f2b = sr.ReadLine
                        GV1.f3b = sr.ReadLine
                        GV1.f4b = sr.ReadLine
                        GV1.f5b = sr.ReadLine
                        GV1.f6b = sr.ReadLine
                        GV1.f7b = sr.ReadLine
                        GV1.f8b = sr.ReadLine
                        GV1.f9b = sr.ReadLine
                        GV1.f1c = sr.ReadLine
                        GV1.f2c = sr.ReadLine
                        GV1.f3c = sr.ReadLine
                        GV1.f4c = sr.ReadLine
                        GV1.f5c = sr.ReadLine
                        GV1.f6c = sr.ReadLine
                        GV1.f7c = sr.ReadLine
                        GV1.f8c = sr.ReadLine
                        GV1.f9c = sr.ReadLine
                        GV1.f1d = sr.ReadLine
                        GV1.f2d = sr.ReadLine
                        GV1.f3d = sr.ReadLine
                        GV1.f4d = sr.ReadLine
                        GV1.f5d = sr.ReadLine
                        GV1.f6d = sr.ReadLine
                        GV1.f7d = sr.ReadLine
                        GV1.f8d = sr.ReadLine
                        GV1.f9d = sr.ReadLine
                        GV1.f1e = sr.ReadLine
                        GV1.f2e = sr.ReadLine
                        GV1.f3e = sr.ReadLine
                        GV1.f4e = sr.ReadLine
                        GV1.f5e = sr.ReadLine
                        GV1.f6e = sr.ReadLine
                        GV1.f7e = sr.ReadLine
                        GV1.f8e = sr.ReadLine
                        GV1.f9e = sr.ReadLine
                        GV1.f1f = sr.ReadLine
                        GV1.f2f = sr.ReadLine
                        GV1.f3f = sr.ReadLine
                        GV1.f4f = sr.ReadLine
                        GV1.f5f = sr.ReadLine
                        GV1.f6f = sr.ReadLine
                        GV1.f7f = sr.ReadLine
                        GV1.f8f = sr.ReadLine
                        GV1.f9f = sr.ReadLine
                        GV1.f1g = sr.ReadLine
                        GV1.f2g = sr.ReadLine
                        GV1.f3g = sr.ReadLine
                        GV1.f4g = sr.ReadLine
                        GV1.f5g = sr.ReadLine
                        GV1.f6g = sr.ReadLine
                        GV1.f7g = sr.ReadLine
                        GV1.f8g = sr.ReadLine
                        GV1.f9g = sr.ReadLine
                        GV1.f1h = sr.ReadLine
                        GV1.f2h = sr.ReadLine
                        GV1.f3h = sr.ReadLine
                        GV1.f4h = sr.ReadLine
                        GV1.f5h = sr.ReadLine
                        GV1.f6h = sr.ReadLine
                        GV1.f7h = sr.ReadLine
                        GV1.f8h = sr.ReadLine
                        GV1.f9h = sr.ReadLine
                        GV1.f1i = sr.ReadLine
                        GV1.f2i = sr.ReadLine
                        GV1.f3i = sr.ReadLine
                        GV1.f4i = sr.ReadLine
                        GV1.f5i = sr.ReadLine
                        GV1.f6i = sr.ReadLine
                        GV1.f7i = sr.ReadLine
                        GV1.f8i = sr.ReadLine
                        GV1.f9i = sr.ReadLine
                        GV1.a1 = sr.ReadLine
                        GV1.a2 = sr.ReadLine
                        GV1.a3 = sr.ReadLine
                        GV1.a4 = sr.ReadLine
                        GV1.a5 = sr.ReadLine
                        GV1.a6 = sr.ReadLine
                        GV1.a7 = sr.ReadLine
                        GV1.a8 = sr.ReadLine
                        GV1.a9 = sr.ReadLine
                        GV1.a10 = sr.ReadLine
                        GV1.a11 = sr.ReadLine
                        GV1.a12 = sr.ReadLine
                        GV1.a13 = sr.ReadLine
                        GV1.a14 = sr.ReadLine
                        GV1.a15 = sr.ReadLine
                        GV1.a16 = sr.ReadLine
                        GV1.a17 = sr.ReadLine
                        GV1.a18 = sr.ReadLine
                        GV1.a19 = sr.ReadLine
                        GV1.a20 = sr.ReadLine
                        GV1.a21 = sr.ReadLine
                        GV1.a22 = sr.ReadLine
                        GV1.a23 = sr.ReadLine
                        GV1.a24 = sr.ReadLine
                        GV1.a25 = sr.ReadLine
                        GV1.a26 = sr.ReadLine
                        GV1.a27 = sr.ReadLine
                        GV1.a28 = sr.ReadLine
                        GV1.a29 = sr.ReadLine
                        GV1.a30 = sr.ReadLine
                        GV1.a31 = sr.ReadLine
                        GV1.a32 = sr.ReadLine
                        GV1.a33 = sr.ReadLine
                        GV1.a34 = sr.ReadLine
                        GV1.a35 = sr.ReadLine
                        GV1.a36 = sr.ReadLine
                        GV1.a37 = sr.ReadLine
                        GV1.a38 = sr.ReadLine
                        GV1.b1 = sr.ReadLine
                        GV1.b2 = sr.ReadLine
                        GV1.b3 = sr.ReadLine
                        GV1.b4 = sr.ReadLine
                        GV1.b5 = sr.ReadLine
                        GV1.b6 = sr.ReadLine
                        GV1.b7 = sr.ReadLine
                        GV1.b8 = sr.ReadLine
                        GV1.b9 = sr.ReadLine
                        GV1.b10 = sr.ReadLine
                        GV1.b11 = sr.ReadLine
                        GV1.b12 = sr.ReadLine
                        GV1.b13 = sr.ReadLine
                        GV1.b14 = sr.ReadLine
                        GV1.b15 = sr.ReadLine
                        GV1.b16 = sr.ReadLine
                        GV1.b17 = sr.ReadLine
                        GV1.b18 = sr.ReadLine
                        GV1.b19 = sr.ReadLine
                        GV1.b20 = sr.ReadLine
                        GV1.b21 = sr.ReadLine
                        GV1.b22 = sr.ReadLine
                        GV1.b23 = sr.ReadLine
                        GV1.b24 = sr.ReadLine
                        GV1.b25 = sr.ReadLine
                        GV1.b26 = sr.ReadLine
                        GV1.b27 = sr.ReadLine
                        GV1.b28 = sr.ReadLine
                        GV1.b29 = sr.ReadLine
                        GV1.b30 = sr.ReadLine
                        GV1.b31 = sr.ReadLine
                        GV1.b32 = sr.ReadLine
                        GV1.b33 = sr.ReadLine
                        GV1.b34 = sr.ReadLine
                        GV1.b35 = sr.ReadLine
                        GV1.b36 = sr.ReadLine
                        GV1.b37 = sr.ReadLine
                        GV1.b38 = sr.ReadLine
                        '不適切ファイルの排除
                        GV1.gm = 1
                        sr.Close()
                        GV1.ShowDialog(Me)
                        GV1.Dispose()
                    ElseIf x = "2" Then
                        GV2.t = sr.ReadLine
                        GV2.f1a = sr.ReadLine
                        GV2.f2a = sr.ReadLine
                        GV2.f3a = sr.ReadLine
                        GV2.f1b = sr.ReadLine
                        GV2.f2b = sr.ReadLine
                        GV2.f3b = sr.ReadLine
                        GV2.f1c = sr.ReadLine
                        GV2.f2c = sr.ReadLine
                        GV2.f3c = sr.ReadLine
                        GV2.a1 = sr.ReadLine
                        GV2.a2 = sr.ReadLine
                        GV2.a3 = sr.ReadLine
                        GV2.a4 = sr.ReadLine
                        GV2.a5 = sr.ReadLine
                        GV2.a6 = sr.ReadLine
                        GV2.a7 = sr.ReadLine
                        GV2.b1 = sr.ReadLine
                        GV2.b2 = sr.ReadLine
                        GV2.b3 = sr.ReadLine
                        GV2.b4 = sr.ReadLine
                        GV2.b5 = sr.ReadLine
                        GV2.b6 = sr.ReadLine
                        GV2.b7 = sr.ReadLine
                        '不適切ファイルの排除
                        GV2.gm = 1
                        sr.Close()
                        GV2.ShowDialog(Me)
                        GV2.Dispose()
                    Else
                        MsgBox("選択された中断記録ファイルは不適切、または破損しています。別のファイルをお試しください。", MsgBoxStyle.OkOnly, "警告")
                    End If
                Else
                    MsgBox("選択された中断記録ファイルは不適切、または破損しています。別のファイルをお試しください。", MsgBoxStyle.OkOnly, "警告")
                End If
            Next
        End If
    End Sub
End Class