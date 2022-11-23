Public Class GV2
    Public t, tr, sp, ss, sc, gm, w, ok As String '先手後手・コマの種類・元の場所・選択状況・選択の保存
    Public f1a, f2a, f3a As String
    Public f1b, f2b, f3b As String
    Public f1c, f2c, f3c As String
    Public a1, a2, a3, a4, a5, a6, a7 As String
    Public b1, b2, b3, b4, b5, b6, b7 As String
    Private f As New S
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        w = 0
        ok = 0
        f.Owner = Me
        'Shape
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        path.AddEllipse(New Rectangle(3, 3, 142, 142))
        path.AddEllipse(New Rectangle(8, 8, 132, 132))
        C1A.Region = New Region(path)
        C1B.Region = New Region(path)
        C1C.Region = New Region(path)
        C2A.Region = New Region(path)
        C2B.Region = New Region(path)
        C2C.Region = New Region(path)
        C3A.Region = New Region(path)
        C3B.Region = New Region(path)
        C3C.Region = New Region(path)
        'Grid
        Dim canvas As New Bitmap(Grid.Width, Grid.Height)
        Dim graphic As Graphics = Graphics.FromImage(canvas)
        Dim gl As New Pen(Color.Black, 2)
        graphic.DrawLine(gl, 3, 3, 467, 3)
        graphic.DrawLine(gl, 3, 167, 467, 167)
        graphic.DrawLine(gl, 3, 332, 467, 332)
        graphic.DrawLine(gl, 3, 496, 467, 496)
        graphic.DrawLine(gl, 3, 3, 3, 497)
        graphic.DrawLine(gl, 157, 3, 157, 497)
        graphic.DrawLine(gl, 312, 3, 312, 497)
        graphic.DrawLine(gl, 466, 3, 466, 497)
        gl.Dispose()
        graphic.Dispose()
        Grid.Image = canvas
        If gm = 0 Then
            GP()
            t = 1
        ElseIf gm = 1 Then
            GS()
        End If
    End Sub

    'ゲーム準備
    Sub GP()
        ss = 0
        P12.Hide()
        P13.Hide()
        P14.Hide()
        P15.Hide()
        P16.Hide()
        P17.Hide()
        P22.Hide()
        P23.Hide()
        P24.Hide()
        P25.Hide()
        P26.Hide()
        P27.Hide()
        P1L.Hide()
        P2L.Hide()
        C1A.Hide()
        C1B.Hide()
        C1C.Hide()
        C2A.Hide()
        C2B.Hide()
        C2C.Hide()
        C3A.Hide()
        C3B.Hide()
        C3C.Hide()
        P1O.Hide()
        P2O.Hide()
        f.Show(Me)
    End Sub

    'ゲーム開始
    Sub GS()
        ss = 1
        P1L.Hide()
        P2L.Hide()
        C1A.Hide()
        C1B.Hide()
        C1C.Hide()
        C2A.Hide()
        C2B.Hide()
        C2C.Hide()
        C3A.Hide()
        C3B.Hide()
        C3C.Hide()
        P1O.Hide()
        P2O.Hide()
        tr = ""
        sp = ""
        M()
        G()
        S1()
        If t = 2 Then
            t = 1
        ElseIf t = 1 Then
            t = 2
        End If
        S2()
    End Sub

    'すべて無効化
    Sub S1()
        PB1A.Enabled = False
        PB1B.Enabled = False
        PB1C.Enabled = False
        PB2A.Enabled = False
        PB2B.Enabled = False
        PB2C.Enabled = False
        PB3A.Enabled = False
        PB3B.Enabled = False
        PB3C.Enabled = False
    End Sub

    '先手後手入れ替え
    Sub S2()
        If w = 1 Then
            If t = 1 Then
                Dim f As New Result
                f.LR.Text = "先手"
                f.ShowDialog(Me)
                f.Dispose()
                Close()
            ElseIf t = 2 Then
                Dim f As New Result
                f.LR.Text = "後手"
                f.ShowDialog(Me)
                f.Dispose()
                Close()
            End If
        ElseIf w = 0 Then
            If t = 2 Then
                t = 1
                P1L.Show()
                P2L.Hide()
                Label1.BackColor = Color.Yellow
                Label2.BackColor = Color.Empty
            ElseIf t = 1 Then
                t = 2
                P1L.Hide()
                P2L.Show()
                Label1.BackColor = Color.Empty
                Label2.BackColor = Color.Yellow
            End If
            If t = 1 Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                    PB1A.Enabled = True
                End If
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    PB1B.Enabled = True
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                    PB1C.Enabled = True
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    PB2A.Enabled = True
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    PB2B.Enabled = True
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    PB2C.Enabled = True
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                    PB3A.Enabled = True
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    PB3B.Enabled = True
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                    PB3C.Enabled = True
                End If
            ElseIf t = 2 Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                    PB1A.Enabled = True
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    PB1B.Enabled = True
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                    PB1C.Enabled = True
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    PB2A.Enabled = True
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    PB2B.Enabled = True
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    PB2C.Enabled = True
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                    PB3A.Enabled = True
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    PB3B.Enabled = True
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                    PB3C.Enabled = True
                End If
            End If
            If t = 1 Then
                P11.Enabled = True
                P12.Enabled = True
                P13.Enabled = True
                P14.Enabled = True
                P15.Enabled = True
                P16.Enabled = True
                P17.Enabled = True
                P21.Enabled = False
                P22.Enabled = False
                P23.Enabled = False
                P24.Enabled = False
                P25.Enabled = False
                P26.Enabled = False
                P27.Enabled = False
            ElseIf t = 2 Then
                P11.Enabled = False
                P12.Enabled = False
                P13.Enabled = False
                P14.Enabled = False
                P15.Enabled = False
                P16.Enabled = False
                P17.Enabled = False
                P21.Enabled = True
                P22.Enabled = True
                P23.Enabled = True
                P24.Enabled = True
                P25.Enabled = True
                P26.Enabled = True
                P27.Enabled = True
            End If
            P11.Show()
            P12.Show()
            P13.Show()
            P14.Show()
            P15.Show()
            P16.Show()
            P17.Show()
            P21.Show()
            P22.Show()
            P23.Show()
            P24.Show()
            P25.Show()
            P26.Show()
            P27.Show()
            If a1 = "" Then
                P11.Hide()
                P12.Hide()
                P13.Hide()
                P14.Hide()
                P15.Hide()
                P16.Hide()
                P17.Hide()
            ElseIf a2 = "" Then
                P12.Hide()
                P13.Hide()
                P14.Hide()
                P15.Hide()
                P16.Hide()
                P17.Hide()
            ElseIf a3 = "" Then
                P13.Hide()
                P14.Hide()
                P15.Hide()
                P16.Hide()
                P17.Hide()
            ElseIf a4 = "" Then
                P14.Hide()
                P15.Hide()
                P16.Hide()
                P17.Hide()
            ElseIf a5 = "" Then
                P15.Hide()
                P16.Hide()
                P17.Hide()
            ElseIf a6 = "" Then
                P16.Hide()
                P17.Hide()
            ElseIf a7 = "" Then
                P17.Hide()
            End If
            If b1 = "" Then
                P21.Hide()
                P22.Hide()
                P23.Hide()
                P24.Hide()
                P25.Hide()
                P26.Hide()
                P27.Hide()
            ElseIf b2 = "" Then
                P22.Hide()
                P23.Hide()
                P24.Hide()
                P25.Hide()
                P26.Hide()
                P27.Hide()
            ElseIf b3 = "" Then
                P23.Hide()
                P24.Hide()
                P25.Hide()
                P26.Hide()
                P27.Hide()
            ElseIf b4 = "" Then
                P24.Hide()
                P25.Hide()
                P26.Hide()
                P27.Hide()
            ElseIf b5 = "" Then
                P25.Hide()
                P26.Hide()
                P27.Hide()
            ElseIf b6 = "" Then
                P26.Hide()
                P27.Hide()
            ElseIf b7 = "" Then
                P27.Hide()
            End If
            sc = ""
        End If
    End Sub

    '持ち駒の整列
    Sub M()
        If a1 = "" Then
            a1 = a2
            a2 = a3
            a3 = a4
            a4 = a5
            a5 = a6
            a6 = a7
            a7 = ""
        ElseIf a2 = "" Then
            a2 = a3
            a3 = a4
            a4 = a5
            a5 = a6
            a6 = a7
            a7 = ""
        ElseIf a3 = "" Then
            a3 = a4
            a4 = a5
            a5 = a6
            a6 = a7
            a7 = ""
        ElseIf a4 = "" Then
            a4 = a5
            a5 = a6
            a6 = a7
            a7 = ""
        ElseIf a5 = "" Then
            a5 = a6
            a6 = a7
            a7 = ""
        ElseIf a6 = "" Then
            a6 = a7
            a7 = ""
        ElseIf a7 = "" Then
            a7 = ""
        End If
        If b1 = "" Then
            b1 = b2
            b2 = b3
            b3 = b4
            b4 = b5
            b5 = b6
            b6 = b7
            b7 = ""
        ElseIf b2 = "" Then
            b2 = b3
            b3 = b4
            b4 = b5
            b5 = b6
            b6 = b7
            b7 = ""
        ElseIf b3 = "" Then
            b3 = b4
            b4 = b5
            b5 = b6
            b6 = b7
            b7 = ""
        ElseIf b4 = "" Then
            b4 = b5
            b5 = b6
            b6 = b7
            b7 = ""
        ElseIf b5 = "" Then
            b5 = b6
            b6 = b7
            b7 = ""
        ElseIf b6 = "" Then
            b6 = b7
            b7 = ""
        ElseIf b7 = "" Then
            b7 = ""
        End If
    End Sub

    '描画変更
    Sub G()
        'Circle
        C1A.Hide()
        C1B.Hide()
        C1C.Hide()
        C2A.Hide()
        C2B.Hide()
        C2C.Hide()
        C3A.Hide()
        C3B.Hide()
        C3C.Hide()
        'In
        If f1a = "" Then
            PB1A.Image = Nothing
        ElseIf f1a = "1g" Then
            PB1A.Image = My.Resources._1g
        ElseIf f1a = "1hh" Then
            PB1A.Image = My.Resources._1hh
        ElseIf f1a = "1hs" Then
            PB1A.Image = My.Resources._1hs
        ElseIf f1a = "1k" Then
            PB1A.Image = My.Resources._1k
        ElseIf f1a = "1kg" Then
            PB1A.Image = My.Resources._1kg
        ElseIf f1a = "1km" Then
            PB1A.Image = My.Resources._1km
        ElseIf f1a = "1ks" Then
            PB1A.Image = My.Resources._1ks
        ElseIf f1a = "1ng" Then
            PB1A.Image = My.Resources._1ng
        ElseIf f1a = "1nk" Then
            PB1A.Image = My.Resources._1nk
        ElseIf f1a = "1nky" Then
            PB1A.Image = My.Resources._1nky
        ElseIf f1a = "1o" Then
            PB1A.Image = My.Resources._1o
        ElseIf f1a = "1rm" Then
            PB1A.Image = My.Resources._1rm
        ElseIf f1a = "1ro" Then
            PB1A.Image = My.Resources._1ro
        ElseIf f1a = "1tk" Then
            PB1A.Image = My.Resources._1tk
        ElseIf f1a = "2g" Then
            PB1A.Image = My.Resources._2g
        ElseIf f1a = "2hh" Then
            PB1A.Image = My.Resources._2hh
        ElseIf f1a = "2hs" Then
            PB1A.Image = My.Resources._2hs
        ElseIf f1a = "2k" Then
            PB1A.Image = My.Resources._2k
        ElseIf f1a = "2kg" Then
            PB1A.Image = My.Resources._2kg
        ElseIf f1a = "2km" Then
            PB1A.Image = My.Resources._2km
        ElseIf f1a = "2ks" Then
            PB1A.Image = My.Resources._2ks
        ElseIf f1a = "2ng" Then
            PB1A.Image = My.Resources._2ng
        ElseIf f1a = "2nk" Then
            PB1A.Image = My.Resources._2nk
        ElseIf f1a = "2nky" Then
            PB1A.Image = My.Resources._2nky
        ElseIf f1a = "2o" Then
            PB1A.Image = My.Resources._2o
        ElseIf f1a = "2rm" Then
            PB1A.Image = My.Resources._2rm
        ElseIf f1a = "2ro" Then
            PB1A.Image = My.Resources._2ro
        ElseIf f1a = "2tk" Then
            PB1A.Image = My.Resources._2tk
        End If
        If f1b = "" Then
            PB1B.Image = Nothing
        ElseIf f1b = "1g" Then
            PB1B.Image = My.Resources._1g
        ElseIf f1b = "1hh" Then
            PB1B.Image = My.Resources._1hh
        ElseIf f1b = "1hs" Then
            PB1B.Image = My.Resources._1hs
        ElseIf f1b = "1k" Then
            PB1B.Image = My.Resources._1k
        ElseIf f1b = "1kg" Then
            PB1B.Image = My.Resources._1kg
        ElseIf f1b = "1km" Then
            PB1B.Image = My.Resources._1km
        ElseIf f1b = "1ks" Then
            PB1B.Image = My.Resources._1ks
        ElseIf f1b = "1ng" Then
            PB1B.Image = My.Resources._1ng
        ElseIf f1b = "1nk" Then
            PB1B.Image = My.Resources._1nk
        ElseIf f1b = "1nky" Then
            PB1B.Image = My.Resources._1nky
        ElseIf f1b = "1o" Then
            PB1B.Image = My.Resources._1o
        ElseIf f1b = "1rm" Then
            PB1B.Image = My.Resources._1rm
        ElseIf f1b = "1ro" Then
            PB1B.Image = My.Resources._1ro
        ElseIf f1b = "1tk" Then
            PB1B.Image = My.Resources._1tk
        ElseIf f1b = "2g" Then
            PB1B.Image = My.Resources._2g
        ElseIf f1b = "2hh" Then
            PB1B.Image = My.Resources._2hh
        ElseIf f1b = "2hs" Then
            PB1B.Image = My.Resources._2hs
        ElseIf f1b = "2k" Then
            PB1B.Image = My.Resources._2k
        ElseIf f1b = "2kg" Then
            PB1B.Image = My.Resources._2kg
        ElseIf f1b = "2km" Then
            PB1B.Image = My.Resources._2km
        ElseIf f1b = "2ks" Then
            PB1B.Image = My.Resources._2ks
        ElseIf f1b = "2ng" Then
            PB1B.Image = My.Resources._2ng
        ElseIf f1b = "2nk" Then
            PB1B.Image = My.Resources._2nk
        ElseIf f1b = "2nky" Then
            PB1B.Image = My.Resources._2nky
        ElseIf f1b = "2o" Then
            PB1B.Image = My.Resources._2o
        ElseIf f1b = "2rm" Then
            PB1B.Image = My.Resources._2rm
        ElseIf f1b = "2ro" Then
            PB1B.Image = My.Resources._2ro
        ElseIf f1b = "2tk" Then
            PB1B.Image = My.Resources._2tk
        End If
        If f1c = "" Then
            PB1C.Image = Nothing
        ElseIf f1c = "1g" Then
            PB1C.Image = My.Resources._1g
        ElseIf f1c = "1hh" Then
            PB1C.Image = My.Resources._1hh
        ElseIf f1c = "1hs" Then
            PB1C.Image = My.Resources._1hs
        ElseIf f1c = "1k" Then
            PB1C.Image = My.Resources._1k
        ElseIf f1c = "1kg" Then
            PB1C.Image = My.Resources._1kg
        ElseIf f1c = "1km" Then
            PB1C.Image = My.Resources._1km
        ElseIf f1c = "1ks" Then
            PB1C.Image = My.Resources._1ks
        ElseIf f1c = "1ng" Then
            PB1C.Image = My.Resources._1ng
        ElseIf f1c = "1nk" Then
            PB1C.Image = My.Resources._1nk
        ElseIf f1c = "1nky" Then
            PB1C.Image = My.Resources._1nky
        ElseIf f1c = "1o" Then
            PB1C.Image = My.Resources._1o
        ElseIf f1c = "1rm" Then
            PB1C.Image = My.Resources._1rm
        ElseIf f1c = "1ro" Then
            PB1C.Image = My.Resources._1ro
        ElseIf f1c = "1tk" Then
            PB1C.Image = My.Resources._1tk
        ElseIf f1c = "2g" Then
            PB1C.Image = My.Resources._2g
        ElseIf f1c = "2hh" Then
            PB1C.Image = My.Resources._2hh
        ElseIf f1c = "2hs" Then
            PB1C.Image = My.Resources._2hs
        ElseIf f1c = "2k" Then
            PB1C.Image = My.Resources._2k
        ElseIf f1c = "2kg" Then
            PB1C.Image = My.Resources._2kg
        ElseIf f1c = "2km" Then
            PB1C.Image = My.Resources._2km
        ElseIf f1c = "2ks" Then
            PB1C.Image = My.Resources._2ks
        ElseIf f1c = "2ng" Then
            PB1C.Image = My.Resources._2ng
        ElseIf f1c = "2nk" Then
            PB1C.Image = My.Resources._2nk
        ElseIf f1c = "2nky" Then
            PB1C.Image = My.Resources._2nky
        ElseIf f1c = "2o" Then
            PB1C.Image = My.Resources._2o
        ElseIf f1c = "2rm" Then
            PB1C.Image = My.Resources._2rm
        ElseIf f1c = "2ro" Then
            PB1C.Image = My.Resources._2ro
        ElseIf f1c = "2tk" Then
            PB1C.Image = My.Resources._2tk
        End If
        If f2a = "" Then
            PB2A.Image = Nothing
        ElseIf f2a = "1g" Then
            PB2A.Image = My.Resources._1g
        ElseIf f2a = "1hh" Then
            PB2A.Image = My.Resources._1hh
        ElseIf f2a = "1hs" Then
            PB2A.Image = My.Resources._1hs
        ElseIf f2a = "1k" Then
            PB2A.Image = My.Resources._1k
        ElseIf f2a = "1kg" Then
            PB2A.Image = My.Resources._1kg
        ElseIf f2a = "1km" Then
            PB2A.Image = My.Resources._1km
        ElseIf f2a = "1ks" Then
            PB2A.Image = My.Resources._1ks
        ElseIf f2a = "1ng" Then
            PB2A.Image = My.Resources._1ng
        ElseIf f2a = "1nk" Then
            PB2A.Image = My.Resources._1nk
        ElseIf f2a = "1nky" Then
            PB2A.Image = My.Resources._1nky
        ElseIf f2a = "1o" Then
            PB2A.Image = My.Resources._1o
        ElseIf f2a = "1rm" Then
            PB2A.Image = My.Resources._1rm
        ElseIf f2a = "1ro" Then
            PB2A.Image = My.Resources._1ro
        ElseIf f2a = "1tk" Then
            PB2A.Image = My.Resources._1tk
        ElseIf f2a = "2g" Then
            PB2A.Image = My.Resources._2g
        ElseIf f2a = "2hh" Then
            PB2A.Image = My.Resources._2hh
        ElseIf f2a = "2hs" Then
            PB2A.Image = My.Resources._2hs
        ElseIf f2a = "2k" Then
            PB2A.Image = My.Resources._2k
        ElseIf f2a = "2kg" Then
            PB2A.Image = My.Resources._2kg
        ElseIf f2a = "2km" Then
            PB2A.Image = My.Resources._2km
        ElseIf f2a = "2ks" Then
            PB2A.Image = My.Resources._2ks
        ElseIf f2a = "2ng" Then
            PB2A.Image = My.Resources._2ng
        ElseIf f2a = "2nk" Then
            PB2A.Image = My.Resources._2nk
        ElseIf f2a = "2nky" Then
            PB2A.Image = My.Resources._2nky
        ElseIf f2a = "2o" Then
            PB2A.Image = My.Resources._2o
        ElseIf f2a = "2rm" Then
            PB2A.Image = My.Resources._2rm
        ElseIf f2a = "2ro" Then
            PB2A.Image = My.Resources._2ro
        ElseIf f2a = "2tk" Then
            PB2A.Image = My.Resources._2tk
        End If
        If f2b = "" Then
            PB2B.Image = Nothing
        ElseIf f2b = "1g" Then
            PB2B.Image = My.Resources._1g
        ElseIf f2b = "1hh" Then
            PB2B.Image = My.Resources._1hh
        ElseIf f2b = "1hs" Then
            PB2B.Image = My.Resources._1hs
        ElseIf f2b = "1k" Then
            PB2B.Image = My.Resources._1k
        ElseIf f2b = "1kg" Then
            PB2B.Image = My.Resources._1kg
        ElseIf f2b = "1km" Then
            PB2B.Image = My.Resources._1km
        ElseIf f2b = "1ks" Then
            PB2B.Image = My.Resources._1ks
        ElseIf f2b = "1ng" Then
            PB2B.Image = My.Resources._1ng
        ElseIf f2b = "1nk" Then
            PB2B.Image = My.Resources._1nk
        ElseIf f2b = "1nky" Then
            PB2B.Image = My.Resources._1nky
        ElseIf f2b = "1o" Then
            PB2B.Image = My.Resources._1o
        ElseIf f2b = "1rm" Then
            PB2B.Image = My.Resources._1rm
        ElseIf f2b = "1ro" Then
            PB2B.Image = My.Resources._1ro
        ElseIf f2b = "1tk" Then
            PB2B.Image = My.Resources._1tk
        ElseIf f2b = "2g" Then
            PB2B.Image = My.Resources._2g
        ElseIf f2b = "2hh" Then
            PB2B.Image = My.Resources._2hh
        ElseIf f2b = "2hs" Then
            PB2B.Image = My.Resources._2hs
        ElseIf f2b = "2k" Then
            PB2B.Image = My.Resources._2k
        ElseIf f2b = "2kg" Then
            PB2B.Image = My.Resources._2kg
        ElseIf f2b = "2km" Then
            PB2B.Image = My.Resources._2km
        ElseIf f2b = "2ks" Then
            PB2B.Image = My.Resources._2ks
        ElseIf f2b = "2ng" Then
            PB2B.Image = My.Resources._2ng
        ElseIf f2b = "2nk" Then
            PB2B.Image = My.Resources._2nk
        ElseIf f2b = "2nky" Then
            PB2B.Image = My.Resources._2nky
        ElseIf f2b = "2o" Then
            PB2B.Image = My.Resources._2o
        ElseIf f2b = "2rm" Then
            PB2B.Image = My.Resources._2rm
        ElseIf f2b = "2ro" Then
            PB2B.Image = My.Resources._2ro
        ElseIf f2b = "2tk" Then
            PB2B.Image = My.Resources._2tk
        End If
        If f2c = "" Then
            PB2C.Image = Nothing
        ElseIf f2c = "1g" Then
            PB2C.Image = My.Resources._1g
        ElseIf f2c = "1hh" Then
            PB2C.Image = My.Resources._1hh
        ElseIf f2c = "1hs" Then
            PB2C.Image = My.Resources._1hs
        ElseIf f2c = "1k" Then
            PB2C.Image = My.Resources._1k
        ElseIf f2c = "1kg" Then
            PB2C.Image = My.Resources._1kg
        ElseIf f2c = "1km" Then
            PB2C.Image = My.Resources._1km
        ElseIf f2c = "1ks" Then
            PB2C.Image = My.Resources._1ks
        ElseIf f2c = "1ng" Then
            PB2C.Image = My.Resources._1ng
        ElseIf f2c = "1nk" Then
            PB2C.Image = My.Resources._1nk
        ElseIf f2c = "1nky" Then
            PB2C.Image = My.Resources._1nky
        ElseIf f2c = "1o" Then
            PB2C.Image = My.Resources._1o
        ElseIf f2c = "1rm" Then
            PB2C.Image = My.Resources._1rm
        ElseIf f2c = "1ro" Then
            PB2C.Image = My.Resources._1ro
        ElseIf f2c = "1tk" Then
            PB2C.Image = My.Resources._1tk
        ElseIf f2c = "2g" Then
            PB2C.Image = My.Resources._2g
        ElseIf f2c = "2hh" Then
            PB2C.Image = My.Resources._2hh
        ElseIf f2c = "2hs" Then
            PB2C.Image = My.Resources._2hs
        ElseIf f2c = "2k" Then
            PB2C.Image = My.Resources._2k
        ElseIf f2c = "2kg" Then
            PB2C.Image = My.Resources._2kg
        ElseIf f2c = "2km" Then
            PB2C.Image = My.Resources._2km
        ElseIf f2c = "2ks" Then
            PB2C.Image = My.Resources._2ks
        ElseIf f2c = "2ng" Then
            PB2C.Image = My.Resources._2ng
        ElseIf f2c = "2nk" Then
            PB2C.Image = My.Resources._2nk
        ElseIf f2c = "2nky" Then
            PB2C.Image = My.Resources._2nky
        ElseIf f2c = "2o" Then
            PB2C.Image = My.Resources._2o
        ElseIf f2c = "2rm" Then
            PB2C.Image = My.Resources._2rm
        ElseIf f2c = "2ro" Then
            PB2C.Image = My.Resources._2ro
        ElseIf f2c = "2tk" Then
            PB2C.Image = My.Resources._2tk
        End If
        If f3a = "" Then
            PB3A.Image = Nothing
        ElseIf f3a = "1g" Then
            PB3A.Image = My.Resources._1g
        ElseIf f3a = "1hh" Then
            PB3A.Image = My.Resources._1hh
        ElseIf f3a = "1hs" Then
            PB3A.Image = My.Resources._1hs
        ElseIf f3a = "1k" Then
            PB3A.Image = My.Resources._1k
        ElseIf f3a = "1kg" Then
            PB3A.Image = My.Resources._1kg
        ElseIf f3a = "1km" Then
            PB3A.Image = My.Resources._1km
        ElseIf f3a = "1ks" Then
            PB3A.Image = My.Resources._1ks
        ElseIf f3a = "1ng" Then
            PB3A.Image = My.Resources._1ng
        ElseIf f3a = "1nk" Then
            PB3A.Image = My.Resources._1nk
        ElseIf f3a = "1nky" Then
            PB3A.Image = My.Resources._1nky
        ElseIf f3a = "1o" Then
            PB3A.Image = My.Resources._1o
        ElseIf f3a = "1rm" Then
            PB3A.Image = My.Resources._1rm
        ElseIf f3a = "1ro" Then
            PB3A.Image = My.Resources._1ro
        ElseIf f3a = "1tk" Then
            PB3A.Image = My.Resources._1tk
        ElseIf f3a = "2g" Then
            PB3A.Image = My.Resources._2g
        ElseIf f3a = "2hh" Then
            PB3A.Image = My.Resources._2hh
        ElseIf f3a = "2hs" Then
            PB3A.Image = My.Resources._2hs
        ElseIf f3a = "2k" Then
            PB3A.Image = My.Resources._2k
        ElseIf f3a = "2kg" Then
            PB3A.Image = My.Resources._2kg
        ElseIf f3a = "2km" Then
            PB3A.Image = My.Resources._2km
        ElseIf f3a = "2ks" Then
            PB3A.Image = My.Resources._2ks
        ElseIf f3a = "2ng" Then
            PB3A.Image = My.Resources._2ng
        ElseIf f3a = "2nk" Then
            PB3A.Image = My.Resources._2nk
        ElseIf f3a = "2nky" Then
            PB3A.Image = My.Resources._2nky
        ElseIf f3a = "2o" Then
            PB3A.Image = My.Resources._2o
        ElseIf f3a = "2rm" Then
            PB3A.Image = My.Resources._2rm
        ElseIf f3a = "2ro" Then
            PB3A.Image = My.Resources._2ro
        ElseIf f3a = "2tk" Then
            PB3A.Image = My.Resources._2tk
        End If
        If f3b = "" Then
            PB3B.Image = Nothing
        ElseIf f3b = "1g" Then
            PB3B.Image = My.Resources._1g
        ElseIf f3b = "1hh" Then
            PB3B.Image = My.Resources._1hh
        ElseIf f3b = "1hs" Then
            PB3B.Image = My.Resources._1hs
        ElseIf f3b = "1k" Then
            PB3B.Image = My.Resources._1k
        ElseIf f3b = "1kg" Then
            PB3B.Image = My.Resources._1kg
        ElseIf f3b = "1km" Then
            PB3B.Image = My.Resources._1km
        ElseIf f3b = "1ks" Then
            PB3B.Image = My.Resources._1ks
        ElseIf f3b = "1ng" Then
            PB3B.Image = My.Resources._1ng
        ElseIf f3b = "1nk" Then
            PB3B.Image = My.Resources._1nk
        ElseIf f3b = "1nky" Then
            PB3B.Image = My.Resources._1nky
        ElseIf f3b = "1o" Then
            PB3B.Image = My.Resources._1o
        ElseIf f3b = "1rm" Then
            PB3B.Image = My.Resources._1rm
        ElseIf f3b = "1ro" Then
            PB3B.Image = My.Resources._1ro
        ElseIf f3b = "1tk" Then
            PB3B.Image = My.Resources._1tk
        ElseIf f3b = "2g" Then
            PB3B.Image = My.Resources._2g
        ElseIf f3b = "2hh" Then
            PB3B.Image = My.Resources._2hh
        ElseIf f3b = "2hs" Then
            PB3B.Image = My.Resources._2hs
        ElseIf f3b = "2k" Then
            PB3B.Image = My.Resources._2k
        ElseIf f3b = "2kg" Then
            PB3B.Image = My.Resources._2kg
        ElseIf f3b = "2km" Then
            PB3B.Image = My.Resources._2km
        ElseIf f3b = "2ks" Then
            PB3B.Image = My.Resources._2ks
        ElseIf f3b = "2ng" Then
            PB3B.Image = My.Resources._2ng
        ElseIf f3b = "2nk" Then
            PB3B.Image = My.Resources._2nk
        ElseIf f3b = "2nky" Then
            PB3B.Image = My.Resources._2nky
        ElseIf f3b = "2o" Then
            PB3B.Image = My.Resources._2o
        ElseIf f3b = "2rm" Then
            PB3B.Image = My.Resources._2rm
        ElseIf f3b = "2ro" Then
            PB3B.Image = My.Resources._2ro
        ElseIf f3b = "2tk" Then
            PB3B.Image = My.Resources._2tk
        End If
        If f3c = "" Then
            PB3C.Image = Nothing
        ElseIf f3c = "1g" Then
            PB3C.Image = My.Resources._1g
        ElseIf f3c = "1hh" Then
            PB3C.Image = My.Resources._1hh
        ElseIf f3c = "1hs" Then
            PB3C.Image = My.Resources._1hs
        ElseIf f3c = "1k" Then
            PB3C.Image = My.Resources._1k
        ElseIf f3c = "1kg" Then
            PB3C.Image = My.Resources._1kg
        ElseIf f3c = "1km" Then
            PB3C.Image = My.Resources._1km
        ElseIf f3c = "1ks" Then
            PB3C.Image = My.Resources._1ks
        ElseIf f3c = "1ng" Then
            PB3C.Image = My.Resources._1ng
        ElseIf f3c = "1nk" Then
            PB3C.Image = My.Resources._1nk
        ElseIf f3c = "1nky" Then
            PB3C.Image = My.Resources._1nky
        ElseIf f3c = "1o" Then
            PB3C.Image = My.Resources._1o
        ElseIf f3c = "1rm" Then
            PB3C.Image = My.Resources._1rm
        ElseIf f3c = "1ro" Then
            PB3C.Image = My.Resources._1ro
        ElseIf f3c = "1tk" Then
            PB3C.Image = My.Resources._1tk
        ElseIf f3c = "2g" Then
            PB3C.Image = My.Resources._2g
        ElseIf f3c = "2hh" Then
            PB3C.Image = My.Resources._2hh
        ElseIf f3c = "2hs" Then
            PB3C.Image = My.Resources._2hs
        ElseIf f3c = "2k" Then
            PB3C.Image = My.Resources._2k
        ElseIf f3c = "2kg" Then
            PB3C.Image = My.Resources._2kg
        ElseIf f3c = "2km" Then
            PB3C.Image = My.Resources._2km
        ElseIf f3c = "2ks" Then
            PB3C.Image = My.Resources._2ks
        ElseIf f3c = "2ng" Then
            PB3C.Image = My.Resources._2ng
        ElseIf f3c = "2nk" Then
            PB3C.Image = My.Resources._2nk
        ElseIf f3c = "2nky" Then
            PB3C.Image = My.Resources._2nky
        ElseIf f3c = "2o" Then
            PB3C.Image = My.Resources._2o
        ElseIf f3c = "2rm" Then
            PB3C.Image = My.Resources._2rm
        ElseIf f3c = "2ro" Then
            PB3C.Image = My.Resources._2ro
        ElseIf f3c = "2tk" Then
            PB3C.Image = My.Resources._2tk
        End If
        'Out
        If a1 = "" Then
            P11.Text = ""
        ElseIf a1 = "1g" Then
            P11.Text = "銀将"
        ElseIf a1 = "1hh" Then
            P11.Text = "歩兵"
        ElseIf a1 = "1hs" Then
            P11.Text = "飛車"
        ElseIf a1 = "1k" Then
            P11.Text = "金将"
        ElseIf a1 = "1kg" Then
            P11.Text = "角行"
        ElseIf a1 = "1km" Then
            P11.Text = "桂馬"
        ElseIf a1 = "1ks" Then
            P11.Text = "香車"
        ElseIf a1 = "1ng" Then
            P11.Text = "成銀"
        ElseIf a1 = "1nk" Then
            P11.Text = "成桂"
        ElseIf a1 = "1nky" Then
            P11.Text = "成香"
        ElseIf a1 = "1o" Then
            P11.Text = "王将"
        ElseIf a1 = "1rm" Then
            P11.Text = "竜馬"
        ElseIf a1 = "1ro" Then
            P11.Text = "竜王"
        ElseIf a1 = "1tk" Then
            P11.Text = "と金"
        End If
        If a2 = "" Then
            P12.Text = ""
        ElseIf a2 = "1g" Then
            P12.Text = "銀将"
        ElseIf a2 = "1hh" Then
            P12.Text = "歩兵"
        ElseIf a2 = "1hs" Then
            P12.Text = "飛車"
        ElseIf a2 = "1k" Then
            P12.Text = "金将"
        ElseIf a2 = "1kg" Then
            P12.Text = "角行"
        ElseIf a2 = "1km" Then
            P12.Text = "桂馬"
        ElseIf a2 = "1ks" Then
            P12.Text = "香車"
        ElseIf a2 = "1ng" Then
            P12.Text = "成銀"
        ElseIf a2 = "1nk" Then
            P12.Text = "成桂"
        ElseIf a2 = "1nky" Then
            P12.Text = "成香"
        ElseIf a2 = "1o" Then
            P12.Text = "王将"
        ElseIf a2 = "1rm" Then
            P12.Text = "竜馬"
        ElseIf a2 = "1ro" Then
            P12.Text = "竜王"
        ElseIf a2 = "1tk" Then
            P12.Text = "と金"
        End If
        If a3 = "" Then
            P13.Text = ""
        ElseIf a3 = "1g" Then
            P13.Text = "銀将"
        ElseIf a3 = "1hh" Then
            P13.Text = "歩兵"
        ElseIf a3 = "1hs" Then
            P13.Text = "飛車"
        ElseIf a3 = "1k" Then
            P13.Text = "金将"
        ElseIf a3 = "1kg" Then
            P13.Text = "角行"
        ElseIf a3 = "1km" Then
            P13.Text = "桂馬"
        ElseIf a3 = "1ks" Then
            P13.Text = "香車"
        ElseIf a3 = "1ng" Then
            P13.Text = "成銀"
        ElseIf a3 = "1nk" Then
            P13.Text = "成桂"
        ElseIf a3 = "1nky" Then
            P13.Text = "成香"
        ElseIf a3 = "1o" Then
            P13.Text = "王将"
        ElseIf a3 = "1rm" Then
            P13.Text = "竜馬"
        ElseIf a3 = "1ro" Then
            P13.Text = "竜王"
        ElseIf a3 = "1tk" Then
            P13.Text = "と金"
        End If
        If a4 = "" Then
            P14.Text = ""
        ElseIf a4 = "1g" Then
            P14.Text = "銀将"
        ElseIf a4 = "1hh" Then
            P14.Text = "歩兵"
        ElseIf a4 = "1hs" Then
            P14.Text = "飛車"
        ElseIf a4 = "1k" Then
            P14.Text = "金将"
        ElseIf a4 = "1kg" Then
            P14.Text = "角行"
        ElseIf a4 = "1km" Then
            P14.Text = "桂馬"
        ElseIf a4 = "1ks" Then
            P14.Text = "香車"
        ElseIf a4 = "1ng" Then
            P14.Text = "成銀"
        ElseIf a4 = "1nk" Then
            P14.Text = "成桂"
        ElseIf a4 = "1nky" Then
            P14.Text = "成香"
        ElseIf a4 = "1o" Then
            P14.Text = "王将"
        ElseIf a4 = "1rm" Then
            P14.Text = "竜馬"
        ElseIf a4 = "1ro" Then
            P14.Text = "竜王"
        ElseIf a4 = "1tk" Then
            P14.Text = "と金"
        End If
        If a5 = "" Then
            P15.Text = ""
        ElseIf a5 = "1g" Then
            P15.Text = "銀将"
        ElseIf a5 = "1hh" Then
            P15.Text = "歩兵"
        ElseIf a5 = "1hs" Then
            P15.Text = "飛車"
        ElseIf a5 = "1k" Then
            P15.Text = "金将"
        ElseIf a5 = "1kg" Then
            P15.Text = "角行"
        ElseIf a5 = "1km" Then
            P15.Text = "桂馬"
        ElseIf a5 = "1ks" Then
            P15.Text = "香車"
        ElseIf a5 = "1ng" Then
            P15.Text = "成銀"
        ElseIf a5 = "1nk" Then
            P15.Text = "成桂"
        ElseIf a5 = "1nky" Then
            P15.Text = "成香"
        ElseIf a5 = "1o" Then
            P15.Text = "王将"
        ElseIf a5 = "1rm" Then
            P15.Text = "竜馬"
        ElseIf a5 = "1ro" Then
            P15.Text = "竜王"
        ElseIf a5 = "1tk" Then
            P15.Text = "と金"
        End If
        If a6 = "" Then
            P16.Text = ""
        ElseIf a6 = "1g" Then
            P16.Text = "銀将"
        ElseIf a6 = "1hh" Then
            P16.Text = "歩兵"
        ElseIf a6 = "1hs" Then
            P16.Text = "飛車"
        ElseIf a6 = "1k" Then
            P16.Text = "金将"
        ElseIf a6 = "1kg" Then
            P16.Text = "角行"
        ElseIf a6 = "1km" Then
            P16.Text = "桂馬"
        ElseIf a6 = "1ks" Then
            P16.Text = "香車"
        ElseIf a6 = "1ng" Then
            P16.Text = "成銀"
        ElseIf a6 = "1nk" Then
            P16.Text = "成桂"
        ElseIf a6 = "1nky" Then
            P16.Text = "成香"
        ElseIf a6 = "1o" Then
            P16.Text = "王将"
        ElseIf a6 = "1rm" Then
            P16.Text = "竜馬"
        ElseIf a6 = "1ro" Then
            P16.Text = "竜王"
        ElseIf a6 = "1tk" Then
            P16.Text = "と金"
        End If
        If a7 = "" Then
            P17.Text = ""
        ElseIf a7 = "1g" Then
            P17.Text = "銀将"
        ElseIf a7 = "1hh" Then
            P17.Text = "歩兵"
        ElseIf a7 = "1hs" Then
            P17.Text = "飛車"
        ElseIf a7 = "1k" Then
            P17.Text = "金将"
        ElseIf a7 = "1kg" Then
            P17.Text = "角行"
        ElseIf a7 = "1km" Then
            P17.Text = "桂馬"
        ElseIf a7 = "1ks" Then
            P17.Text = "香車"
        ElseIf a7 = "1ng" Then
            P17.Text = "成銀"
        ElseIf a7 = "1nk" Then
            P17.Text = "成桂"
        ElseIf a7 = "1nky" Then
            P17.Text = "成香"
        ElseIf a7 = "1o" Then
            P17.Text = "王将"
        ElseIf a7 = "1rm" Then
            P17.Text = "竜馬"
        ElseIf a7 = "1ro" Then
            P17.Text = "竜王"
        ElseIf a7 = "1tk" Then
            P17.Text = "と金"
        End If
        If b1 = "" Then
            P21.Text = ""
        ElseIf b1 = "2g" Then
            P21.Text = "銀将"
        ElseIf b1 = "2hh" Then
            P21.Text = "歩兵"
        ElseIf b1 = "2hs" Then
            P21.Text = "飛車"
        ElseIf b1 = "2k" Then
            P21.Text = "金将"
        ElseIf b1 = "2kg" Then
            P21.Text = "角行"
        ElseIf b1 = "2km" Then
            P21.Text = "桂馬"
        ElseIf b1 = "2ks" Then
            P21.Text = "香車"
        ElseIf b1 = "2ng" Then
            P21.Text = "成銀"
        ElseIf b1 = "2nk" Then
            P21.Text = "成桂"
        ElseIf b1 = "2nky" Then
            P21.Text = "成香"
        ElseIf b1 = "2o" Then
            P21.Text = "王将"
        ElseIf b1 = "2rm" Then
            P21.Text = "竜馬"
        ElseIf b1 = "2ro" Then
            P21.Text = "竜王"
        ElseIf b1 = "2tk" Then
            P21.Text = "と金"
        End If
        If b2 = "" Then
            P22.Text = ""
        ElseIf b2 = "2g" Then
            P22.Text = "銀将"
        ElseIf b2 = "2hh" Then
            P22.Text = "歩兵"
        ElseIf b2 = "2hs" Then
            P22.Text = "飛車"
        ElseIf b2 = "2k" Then
            P22.Text = "金将"
        ElseIf b2 = "2kg" Then
            P22.Text = "角行"
        ElseIf b2 = "2km" Then
            P22.Text = "桂馬"
        ElseIf b2 = "2ks" Then
            P22.Text = "香車"
        ElseIf b2 = "2ng" Then
            P22.Text = "成銀"
        ElseIf b2 = "2nk" Then
            P22.Text = "成桂"
        ElseIf b2 = "2nky" Then
            P22.Text = "成香"
        ElseIf b2 = "2o" Then
            P22.Text = "王将"
        ElseIf b2 = "2rm" Then
            P22.Text = "竜馬"
        ElseIf b2 = "2ro" Then
            P22.Text = "竜王"
        ElseIf b2 = "2tk" Then
            P22.Text = "と金"
        End If
        If b3 = "" Then
            P23.Text = ""
        ElseIf b3 = "2g" Then
            P23.Text = "銀将"
        ElseIf b3 = "2hh" Then
            P23.Text = "歩兵"
        ElseIf b3 = "2hs" Then
            P23.Text = "飛車"
        ElseIf b3 = "2k" Then
            P23.Text = "金将"
        ElseIf b3 = "2kg" Then
            P23.Text = "角行"
        ElseIf b3 = "2km" Then
            P23.Text = "桂馬"
        ElseIf b3 = "2ks" Then
            P23.Text = "香車"
        ElseIf b3 = "2ng" Then
            P23.Text = "成銀"
        ElseIf b3 = "2nk" Then
            P23.Text = "成桂"
        ElseIf b3 = "2nky" Then
            P23.Text = "成香"
        ElseIf b3 = "2o" Then
            P23.Text = "王将"
        ElseIf b3 = "2rm" Then
            P23.Text = "竜馬"
        ElseIf b3 = "2ro" Then
            P23.Text = "竜王"
        ElseIf b3 = "2tk" Then
            P23.Text = "と金"
        End If
        If b4 = "" Then
            P24.Text = ""
        ElseIf b4 = "2g" Then
            P24.Text = "銀将"
        ElseIf b4 = "2hh" Then
            P24.Text = "歩兵"
        ElseIf b4 = "2hs" Then
            P24.Text = "飛車"
        ElseIf b4 = "2k" Then
            P24.Text = "金将"
        ElseIf b4 = "2kg" Then
            P24.Text = "角行"
        ElseIf b4 = "2km" Then
            P24.Text = "桂馬"
        ElseIf b4 = "2ks" Then
            P24.Text = "香車"
        ElseIf b4 = "2ng" Then
            P24.Text = "成銀"
        ElseIf b4 = "2nk" Then
            P24.Text = "成桂"
        ElseIf b4 = "2nky" Then
            P24.Text = "成香"
        ElseIf b4 = "2o" Then
            P24.Text = "王将"
        ElseIf b4 = "2rm" Then
            P24.Text = "竜馬"
        ElseIf b4 = "2ro" Then
            P24.Text = "竜王"
        ElseIf b4 = "2tk" Then
            P24.Text = "と金"
        End If
        If b5 = "" Then
            P25.Text = ""
        ElseIf b5 = "2g" Then
            P25.Text = "銀将"
        ElseIf b5 = "2hh" Then
            P25.Text = "歩兵"
        ElseIf b5 = "2hs" Then
            P25.Text = "飛車"
        ElseIf b5 = "2k" Then
            P25.Text = "金将"
        ElseIf b5 = "2kg" Then
            P25.Text = "角行"
        ElseIf b5 = "2km" Then
            P25.Text = "桂馬"
        ElseIf b5 = "2ks" Then
            P25.Text = "香車"
        ElseIf b5 = "2ng" Then
            P25.Text = "成銀"
        ElseIf b5 = "2nk" Then
            P25.Text = "成桂"
        ElseIf b5 = "2nky" Then
            P25.Text = "成香"
        ElseIf b5 = "2o" Then
            P25.Text = "王将"
        ElseIf b5 = "2rm" Then
            P25.Text = "竜馬"
        ElseIf b5 = "2ro" Then
            P25.Text = "竜王"
        ElseIf b5 = "2tk" Then
            P25.Text = "と金"
        End If
        If b6 = "" Then
            P26.Text = ""
        ElseIf b6 = "2g" Then
            P26.Text = "銀将"
        ElseIf b6 = "2hh" Then
            P26.Text = "歩兵"
        ElseIf b6 = "2hs" Then
            P26.Text = "飛車"
        ElseIf b6 = "2k" Then
            P26.Text = "金将"
        ElseIf b6 = "2kg" Then
            P26.Text = "角行"
        ElseIf b6 = "2km" Then
            P26.Text = "桂馬"
        ElseIf b6 = "2ks" Then
            P26.Text = "香車"
        ElseIf b6 = "2ng" Then
            P26.Text = "成銀"
        ElseIf b6 = "2nk" Then
            P26.Text = "成桂"
        ElseIf b6 = "2nky" Then
            P26.Text = "成香"
        ElseIf b6 = "2o" Then
            P26.Text = "王将"
        ElseIf b6 = "2rm" Then
            P26.Text = "竜馬"
        ElseIf b6 = "2ro" Then
            P26.Text = "竜王"
        ElseIf b6 = "2tk" Then
            P26.Text = "と金"
        End If
        If b7 = "" Then
            P27.Text = ""
        ElseIf b7 = "2g" Then
            P27.Text = "銀将"
        ElseIf b7 = "2hh" Then
            P27.Text = "歩兵"
        ElseIf b7 = "2hs" Then
            P27.Text = "飛車"
        ElseIf b7 = "2k" Then
            P27.Text = "金将"
        ElseIf b7 = "2kg" Then
            P27.Text = "角行"
        ElseIf b7 = "2km" Then
            P27.Text = "桂馬"
        ElseIf b7 = "2ks" Then
            P27.Text = "香車"
        ElseIf b7 = "2ng" Then
            P27.Text = "成銀"
        ElseIf b7 = "2nk" Then
            P27.Text = "成桂"
        ElseIf b7 = "2nky" Then
            P27.Text = "成香"
        ElseIf b7 = "2o" Then
            P27.Text = "王将"
        ElseIf b7 = "2rm" Then
            P27.Text = "竜馬"
        ElseIf b7 = "2ro" Then
            P27.Text = "竜王"
        ElseIf b7 = "2tk" Then
            P27.Text = "と金"
        End If
    End Sub

    Private Sub PB1A_Click(sender As Object, e As EventArgs) Handles PB1A.Click
        If ss = 0 Then
            f.tp = "1a"
            f.PN.Text = "1a"
        ElseIf ss = 1 Then
            ss = 2
            sp = "1a"
            tr = f1a
            A1A()
        Else
            '再選択
            If t = 1 Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                    ss = 2
                    sp = "1a"
                    tr = f1a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1A()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                    ss = 2
                    sp = "1a"
                    tr = f1a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1A()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        If f1a = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1a = "2g" Or f1a = "2ng" Then
                            sc = "1g"
                        End If
                        If f1a = "2hh" Or f1a = "2tk" Then
                            sc = "1hh"
                        End If
                        If f1a = "2hs" Or f1a = "2ro" Then
                            sc = "1hs"
                        End If
                        If f1a = "2k" Then
                            sc = "1k"
                        End If
                        If f1a = "2kg" Or f1a = "2rm" Then
                            sc = "1kg"
                        End If
                        If f1a = "2km" Or f1a = "2nk" Then
                            sc = "1km"
                        End If
                        If f1a = "2ks" Or f1a = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        If f1a = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1a = "1g" Or f1a = "1ng" Then
                            sc = "2g"
                        End If
                        If f1a = "1hh" Or f1a = "1tk" Then
                            sc = "2hh"
                        End If
                        If f1a = "1hs" Or f1a = "1ro" Then
                            sc = "2hs"
                        End If
                        If f1a = "1k" Then
                            sc = "2k"
                        End If
                        If f1a = "1kg" Or f1a = "1rm" Then
                            sc = "2kg"
                        End If
                        If f1a = "1km" Or f1a = "1nk" Then
                            sc = "2km"
                        End If
                        If f1a = "1ks" Or f1a = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If tr = "2hh" Then
                        tr = "2tk"
                    End If
                    If tr = "2ks" Then
                        tr = "2nky"
                    End If
                    If tr = "2km" Then
                        tr = "2nk"
                    End If
                    If tr = "2g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ng"
                        End If
                    End If
                    If tr = "2hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ro"
                        End If
                    End If
                    If tr = "2kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2rm"
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f1a = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A1A()
        If t = 1 Then
            If f1a = "1o" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "1km" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f1a = "1g" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "1k" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1tk" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "1hh" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "1ks" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        Else
                            If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f1a = "1hs" Or f1a = "1ro" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                        If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        Else
                            If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        Else
                            If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "1ro" Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f1a = "1kg" Or f1a = "1rm" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        Else
                            If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "1rm" Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f1a = "2o" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "2km" Then
            ElseIf f1a = "2g" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1a = "2k" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2tk" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1a = "2hh" Then
            ElseIf f1a = "2ks" Then
            ElseIf f1a = "2hs" Or f1a = "2ro" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                        If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        Else
                            If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        Else
                            If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "2ro" Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f1a = "2kg" Or f1a = "2rm" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        Else
                            If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "2rm" Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB1B_Click(sender As Object, e As EventArgs) Handles PB1B.Click
        If ss = 0 Then
            f.tp = "1b"
            f.PN.Text = "1b"
        ElseIf ss = 1 Then
            ss = 2
            sp = "1b"
            tr = f1b
            A1B()
        Else
            '再選択
            If t = 1 Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    ss = 2
                    sp = "1b"
                    tr = f1b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1B()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    ss = 2
                    sp = "1b"
                    tr = f1b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1B()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        If f1b = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1b = "2g" Or f1b = "2ng" Then
                            sc = "1g"
                        End If
                        If f1b = "2hh" Or f1b = "2tk" Then
                            sc = "1hh"
                        End If
                        If f1b = "2hs" Or f1b = "2ro" Then
                            sc = "1hs"
                        End If
                        If f1b = "2k" Then
                            sc = "1k"
                        End If
                        If f1b = "2kg" Or f1b = "2rm" Then
                            sc = "1kg"
                        End If
                        If f1b = "2km" Or f1b = "2nk" Then
                            sc = "1km"
                        End If
                        If f1b = "2ks" Or f1b = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        If f1b = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1b = "1g" Or f1b = "1ng" Then
                            sc = "2g"
                        End If
                        If f1b = "1hh" Or f1b = "1tk" Then
                            sc = "2hh"
                        End If
                        If f1b = "1hs" Or f1b = "1ro" Then
                            sc = "2hs"
                        End If
                        If f1b = "1k" Then
                            sc = "2k"
                        End If
                        If f1b = "1kg" Or f1b = "1rm" Then
                            sc = "2kg"
                        End If
                        If f1b = "1km" Or f1b = "1nk" Then
                            sc = "2km"
                        End If
                        If f1b = "1ks" Or f1b = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If tr = "2hh" Then
                        tr = "2tk"
                    End If
                    If tr = "2ks" Then
                        tr = "2nky"
                    End If
                    If tr = "2km" Then
                        tr = "2nk"
                    End If
                    If tr = "2g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ng"
                        End If
                    End If
                    If tr = "2hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ro"
                        End If
                    End If
                    If tr = "2kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2rm"
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f1b = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A1B()
        If t = 1 Then
            If f1b = "1o" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1b = "1km" Then
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f1b = "1g" Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1b = "1k" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1tk" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1b = "1hh" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1b = "1ks" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        Else
                            If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                                PB3B.Enabled = True
                                C3B.Show()
                            Else
                                PB3B.Enabled = True
                                C3B.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f1b = "1hs" Or f1b = "1ro" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        Else
                            If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                                PB3B.Enabled = True
                                C3B.Show()
                            Else
                                PB3B.Enabled = True
                                C3B.Show()
                            End If
                        End If
                    End If
                End If
                If f1b = "1ro" Then
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf f1b = "1kg" Or f1b = "1rm" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f1b = "1rm" Then
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f1b = "2o" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1b = "2km" Then
            ElseIf f1b = "2g" Then
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f1b = "2k" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2tk" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1b = "2hh" Then
            ElseIf f1b = "2ks" Then
            ElseIf f1b = "2hs" Or f1b = "2ro" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        Else
                            If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                                PB3B.Enabled = True
                                C3B.Show()
                            Else
                                PB3B.Enabled = True
                                C3B.Show()
                            End If
                        End If
                    End If
                End If
                If f1b = "2ro" Then
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf f1b = "2kg" Or f1b = "2rm" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f1b = "2rm" Then
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB1C_Click(sender As Object, e As EventArgs) Handles PB1C.Click
        If ss = 0 Then
            f.tp = "1c"
            f.PN.Text = "1c"
        ElseIf ss = 1 Then
            ss = 2
            sp = "1c"
            tr = f1c
            A1C()
        Else
            '再選択
            If t = 1 Then
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                    ss = 2
                    sp = "1c"
                    tr = f1c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1C()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                    ss = 2
                    sp = "1c"
                    tr = f1c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A1C()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        If f1c = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1c = "2g" Or f1c = "2ng" Then
                            sc = "1g"
                        End If
                        If f1c = "2hh" Or f1c = "2tk" Then
                            sc = "1hh"
                        End If
                        If f1c = "2hs" Or f1c = "2ro" Then
                            sc = "1hs"
                        End If
                        If f1c = "2k" Then
                            sc = "1k"
                        End If
                        If f1c = "2kg" Or f1c = "2rm" Then
                            sc = "1kg"
                        End If
                        If f1c = "2km" Or f1c = "2nk" Then
                            sc = "1km"
                        End If
                        If f1c = "2ks" Or f1c = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        If f1c = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f1c = "1g" Or f1c = "1ng" Then
                            sc = "2g"
                        End If
                        If f1c = "1hh" Or f1c = "1tk" Then
                            sc = "2hh"
                        End If
                        If f1c = "1hs" Or f1c = "1ro" Then
                            sc = "2hs"
                        End If
                        If f1c = "1k" Then
                            sc = "2k"
                        End If
                        If f1c = "1kg" Or f1c = "1rm" Then
                            sc = "2kg"
                        End If
                        If f1c = "1km" Or f1c = "1nk" Then
                            sc = "2km"
                        End If
                        If f1c = "1ks" Or f1c = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If tr = "2hh" Then
                        tr = "2tk"
                    End If
                    If tr = "2ks" Then
                        tr = "2nky"
                    End If
                    If tr = "2km" Then
                        tr = "2nk"
                    End If
                    If tr = "2g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ng"
                        End If
                    End If
                    If tr = "2hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2ro"
                        End If
                    End If
                    If tr = "2kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "2rm"
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f1c = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A1C()
        If t = 1 Then
            If f1c = "1o" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1c = "1km" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f1c = "1g" Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1c = "1k" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1tk" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1c = "1hh" Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f1c = "1ks" Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        Else
                            If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f1c = "1hs" Or f1c = "1ro" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                        If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        Else
                            If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        Else
                            If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "1ro" Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f1c = "1kg" Or f1c = "1rm" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        Else
                            If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "1rm" Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f1c = "2o" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1c = "2km" Then
            ElseIf f1c = "2g" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f1c = "2k" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2tk" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f1c = "2hh" Then
            ElseIf f1c = "2ks" Then
            ElseIf f1c = "2hs" Or f1c = "2ro" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                        If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        Else
                            If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        Else
                            If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "2ro" Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f1c = "2kg" Or f1c = "2rm" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        Else
                            If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "2rm" Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB2A_Click(sender As Object, e As EventArgs) Handles PB2A.Click
        If ss = 0 Then
            f.tp = "2a"
            f.PN.Text = "2a"
        ElseIf ss = 1 Then
            ss = 2
            sp = "2a"
            tr = f2a
            A2A()
        Else
            '再選択
            If t = 1 Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    ss = 2
                    sp = "2a"
                    tr = f2a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2A()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    ss = 2
                    sp = "2a"
                    tr = f2a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2A()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        If f2a = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2a = "2g" Or f2a = "2ng" Then
                            sc = "1g"
                        End If
                        If f2a = "2hh" Or f2a = "2tk" Then
                            sc = "1hh"
                        End If
                        If f2a = "2hs" Or f2a = "2ro" Then
                            sc = "1hs"
                        End If
                        If f2a = "2k" Then
                            sc = "1k"
                        End If
                        If f2a = "2kg" Or f2a = "2rm" Then
                            sc = "1kg"
                        End If
                        If f2a = "2km" Or f2a = "2nk" Then
                            sc = "1km"
                        End If
                        If f2a = "2ks" Or f2a = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        If f2a = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2a = "1g" Or f2a = "1ng" Then
                            sc = "2g"
                        End If
                        If f2a = "1hh" Or f2a = "1tk" Then
                            sc = "2hh"
                        End If
                        If f2a = "1hs" Or f2a = "1ro" Then
                            sc = "2hs"
                        End If
                        If f2a = "1k" Then
                            sc = "2k"
                        End If
                        If f2a = "1kg" Or f2a = "1rm" Then
                            sc = "2kg"
                        End If
                        If f2a = "1km" Or f2a = "1nk" Then
                            sc = "2km"
                        End If
                        If f2a = "1ks" Or f2a = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f2a = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A2A()
        If t = 1 Then
            If f2a = "1o" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "1km" Then
            ElseIf f2a = "1g" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "1k" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1tk" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "1hh" Then
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "1ks" Then
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
            ElseIf f2a = "1hs" Or f2a = "1ro" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        Else
                            If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                                PB2C.Enabled = True
                                C2C.Show()
                            Else
                                PB2C.Enabled = True
                                C2C.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f2a = "1ro" Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            ElseIf f2a = "1kg" Or f2a = "1rm" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2a = "1rm" Then
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f2a = "2o" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "2km" Then
            ElseIf f2a = "2g" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f2a = "2k" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2tk" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
            ElseIf f2a = "2hh" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
            ElseIf f2a = "2ks" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
            ElseIf f2a = "2hs" Or f2a = "2ro" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        Else
                            If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                                PB2C.Enabled = True
                                C2C.Show()
                            Else
                                PB2C.Enabled = True
                                C2C.Show()
                            End If
                        End If
                    End If
                End If
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f2a = "2ro" Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            ElseIf f2a = "2kg" Or f2a = "2rm" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2a = "2rm" Then
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB2B_Click(sender As Object, e As EventArgs) Handles PB2B.Click
        If ss = 0 Then
            f.tp = "2b"
            f.PN.Text = "2b"
        ElseIf ss = 1 Then
            ss = 2
            sp = "2b"
            tr = f2b
            A2B()
        Else
            '再選択
            If t = 1 Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    ss = 2
                    sp = "2b"
                    tr = f2b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2B()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    ss = 2
                    sp = "2b"
                    tr = f2b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2B()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        If f2b = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2b = "2g" Or f2b = "2ng" Then
                            sc = "1g"
                        End If
                        If f2b = "2hh" Or f2b = "2tk" Then
                            sc = "1hh"
                        End If
                        If f2b = "2hs" Or f2b = "2ro" Then
                            sc = "1hs"
                        End If
                        If f2b = "2k" Then
                            sc = "1k"
                        End If
                        If f2b = "2kg" Or f2b = "2rm" Then
                            sc = "1kg"
                        End If
                        If f2b = "2km" Or f2b = "2nk" Then
                            sc = "1km"
                        End If
                        If f2b = "2ks" Or f2b = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        If f2b = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2b = "1g" Or f2b = "1ng" Then
                            sc = "2g"
                        End If
                        If f2b = "1hh" Or f2b = "1tk" Then
                            sc = "2hh"
                        End If
                        If f2b = "1hs" Or f2b = "1ro" Then
                            sc = "2hs"
                        End If
                        If f2b = "1k" Then
                            sc = "2k"
                        End If
                        If f2b = "1kg" Or f2b = "1rm" Then
                            sc = "2kg"
                        End If
                        If f2b = "1km" Or f2b = "1nk" Then
                            sc = "2km"
                        End If
                        If f2b = "1ks" Or f2b = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f2b = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A2B()
        If t = 1 Then
            If f2b = "1o" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2b = "1km" Then
            ElseIf f2b = "1g" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2b = "1k" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1tk" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2b = "1hh" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f2b = "1ks" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            ElseIf f2b = "1hs" Or f2b = "1ro" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2b = "1ro" Then
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf f2b = "1kg" Or f2b = "1rm" Then
                If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                Else
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2b = "1rm" Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f2b = "2o" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2b = "2km" Then
            ElseIf f2b = "2g" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2b = "2k" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2tk" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f2b = "2hh" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
            ElseIf f2b = "2ks" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
            ElseIf f2b = "2hs" Or f2b = "2ro" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2b = "2ro" Then
                    If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf f2b = "2kg" Or f2b = "2rm" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    Else
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2b = "2rm" Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB2C_Click(sender As Object, e As EventArgs) Handles PB2C.Click
        If ss = 0 Then
            f.tp = "2c"
            f.PN.Text = "2c"
        ElseIf ss = 1 Then
            ss = 2
            sp = "2c"
            tr = f2c
            A2C()
        Else
            '再選択
            If t = 1 Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    ss = 2
                    sp = "2c"
                    tr = f2c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2C()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    ss = 2
                    sp = "2c"
                    tr = f2c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A2C()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        If f2c = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2c = "2g" Or f2c = "2ng" Then
                            sc = "1g"
                        End If
                        If f2c = "2hh" Or f2c = "2tk" Then
                            sc = "1hh"
                        End If
                        If f2c = "2hs" Or f2c = "2ro" Then
                            sc = "1hs"
                        End If
                        If f2c = "2k" Then
                            sc = "1k"
                        End If
                        If f2c = "2kg" Or f2c = "2rm" Then
                            sc = "1kg"
                        End If
                        If f2c = "2km" Or f2c = "2nk" Then
                            sc = "1km"
                        End If
                        If f2c = "2ks" Or f2c = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        If f2c = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f2c = "1g" Or f2c = "1ng" Then
                            sc = "2g"
                        End If
                        If f2c = "1hh" Or f2c = "1tk" Then
                            sc = "2hh"
                        End If
                        If f2c = "1hs" Or f2c = "1ro" Then
                            sc = "2hs"
                        End If
                        If f2c = "1k" Then
                            sc = "2k"
                        End If
                        If f2c = "1kg" Or f2c = "1rm" Then
                            sc = "2kg"
                        End If
                        If f2c = "1km" Or f2c = "1nk" Then
                            sc = "2km"
                        End If
                        If f2c = "1ks" Or f2c = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If sp = "3a" Or sp = "3b" Or sp = "3c" Then
                        If tr = "1hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1tk"
                            End If
                        End If
                        If tr = "1ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nky"
                            End If
                        End If
                        If tr = "1km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1nk"
                            End If
                        End If
                        If tr = "1g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ng"
                            End If
                        End If
                        If tr = "1hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1ro"
                            End If
                        End If
                        If tr = "1kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                                "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "1rm"
                            End If
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f2c = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A2C()
        If t = 1 Then
            If f2c = "1o" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "1km" Then
            ElseIf f2c = "1g" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "1k" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1tk" Then
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "1hh" Then
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "1ks" Then
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf f2c = "1hs" Or f2c = "1ro" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        Else
                            If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                                PB2A.Enabled = True
                                C2A.Show()
                            Else
                                PB2A.Enabled = True
                                C2A.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                Else
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2c = "1ro" Then
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            ElseIf f2c = "1kg" Or f2c = "1rm" Then
                If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                Else
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2c = "1rm" Then
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f2c = "2o" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "2km" Then
            ElseIf f2c = "2g" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f2c = "2k" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2tk" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f2c = "2hh" Then
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            ElseIf f2c = "2ks" Then
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
            ElseIf f2c = "2hs" Or f2c = "2ro" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        Else
                            If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                                PB2A.Enabled = True
                                C2A.Show()
                            Else
                                PB2A.Enabled = True
                                C2A.Show()
                            End If
                        End If
                    End If
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2c = "2ro" Then
                    If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            ElseIf f2c = "2kg" Or f2c = "2rm" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    Else
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f2c = "2rm" Then
                    If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                    Else
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB3A_Click(sender As Object, e As EventArgs) Handles PB3A.Click
        If ss = 0 Then
            f.tp = "3a"
            f.PN.Text = "3a"
        ElseIf ss = 1 Then
            ss = 2
            sp = "3a"
            tr = f3a
            A3A()
        Else
            '再選択
            If t = 1 Then
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                    ss = 2
                    sp = "3a"
                    tr = f3a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3A()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                    ss = 2
                    sp = "3a"
                    tr = f3a
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3A()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        If f3a = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3a = "2g" Or f3a = "2ng" Then
                            sc = "1g"
                        End If
                        If f3a = "2hh" Or f3a = "2tk" Then
                            sc = "1hh"
                        End If
                        If f3a = "2hs" Or f3a = "2ro" Then
                            sc = "1hs"
                        End If
                        If f3a = "2k" Then
                            sc = "1k"
                        End If
                        If f3a = "2kg" Or f3a = "2rm" Then
                            sc = "1kg"
                        End If
                        If f3a = "2km" Or f3a = "2nk" Then
                            sc = "1km"
                        End If
                        If f3a = "2ks" Or f3a = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        If f3a = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3a = "1g" Or f3a = "1ng" Then
                            sc = "2g"
                        End If
                        If f3a = "1hh" Or f3a = "1tk" Then
                            sc = "2hh"
                        End If
                        If f3a = "1hs" Or f3a = "1ro" Then
                            sc = "2hs"
                        End If
                        If f3a = "1k" Then
                            sc = "2k"
                        End If
                        If f3a = "1kg" Or f3a = "1rm" Then
                            sc = "2kg"
                        End If
                        If f3a = "1km" Or f3a = "1nk" Then
                            sc = "2km"
                        End If
                        If f3a = "1ks" Or f3a = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If tr = "1hh" Then
                        tr = "1tk"
                    End If
                    If tr = "1ks" Then
                        tr = "1nky"
                    End If
                    If tr = "1km" Then
                        tr = "1nk"
                    End If
                    If tr = "1g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ng"
                        End If
                    End If
                    If tr = "1hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ro"
                        End If
                    End If
                    If tr = "1kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1rm"
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f3a = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A3A()
        If t = 1 Then
            If f3a = "1o" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3a = "1km" Then
            ElseIf f3a = "1g" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f3a = "1k" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1tk" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3a = "1hh" Then
            ElseIf f3a = "1ks" Then
            ElseIf f3a = "1hs" Or f3a = "1ro" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                        If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        Else
                            If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        Else
                            If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f3a = "1ro" Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f3a = "1kg" Or f3a = "1rm" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        Else
                            If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f3a = "1rm" Then
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f3a = "2o" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3a = "2km" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
            ElseIf f3a = "2g" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f3a = "2k" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2tk" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3a = "2hh" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
            ElseIf f3a = "2ks" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        Else
                            If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f3a = "2hs" Or f3a = "2ro" Then
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                        If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        Else
                            If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                                PB3C.Enabled = True
                                C3C.Show()
                            Else
                                PB3C.Enabled = True
                                C3C.Show()
                            End If
                        End If
                    End If
                End If
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                        If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        Else
                            If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f3a = "2ro" Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f3a = "2kg" Or f3a = "2rm" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        Else
                            If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f3a = "2rm" Then
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB3B_Click(sender As Object, e As EventArgs) Handles PB3B.Click
        If ss = 0 Then
            f.tp = "3b"
            f.PN.Text = "3b"
        ElseIf ss = 1 Then
            ss = 2
            sp = "3b"
            tr = f3b
            A3B()
        Else
            '再選択
            If t = 1 Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    ss = 2
                    sp = "3b"
                    tr = f3b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3B()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    ss = 2
                    sp = "3b"
                    tr = f3b
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3B()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        If f3b = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3b = "2g" Or f3b = "2ng" Then
                            sc = "1g"
                        End If
                        If f3b = "2hh" Or f3b = "2tk" Then
                            sc = "1hh"
                        End If
                        If f3b = "2hs" Or f3b = "2ro" Then
                            sc = "1hs"
                        End If
                        If f3b = "2k" Then
                            sc = "1k"
                        End If
                        If f3b = "2kg" Or f3b = "2rm" Then
                            sc = "1kg"
                        End If
                        If f3b = "2km" Or f3b = "2nk" Then
                            sc = "1km"
                        End If
                        If f3b = "2ks" Or f3b = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        If f3b = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3b = "1g" Or f3b = "1ng" Then
                            sc = "2g"
                        End If
                        If f3b = "1hh" Or f3b = "1tk" Then
                            sc = "2hh"
                        End If
                        If f3b = "1hs" Or f3b = "1ro" Then
                            sc = "2hs"
                        End If
                        If f3b = "1k" Then
                            sc = "2k"
                        End If
                        If f3b = "1kg" Or f3b = "1rm" Then
                            sc = "2kg"
                        End If
                        If f3b = "1km" Or f3b = "1nk" Then
                            sc = "2km"
                        End If
                        If f3b = "1ks" Or f3b = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If tr = "1hh" Then
                        tr = "1tk"
                    End If
                    If tr = "1ks" Then
                        tr = "1nky"
                    End If
                    If tr = "1km" Then
                        tr = "1nk"
                    End If
                    If tr = "1g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ng"
                        End If
                    End If
                    If tr = "1hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ro"
                        End If
                    End If
                    If tr = "1kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1rm"
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f3b = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A3B()
        If t = 1 Then
            If f3b = "1o" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f3b = "1km" Then
            ElseIf f3b = "1g" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f3b = "1k" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1tk" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f3b = "1hh" Then
            ElseIf f3b = "1ks" Then
            ElseIf f3b = "1hs" Or f3b = "1ro" Then
                If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                Else
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                Else
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                        Else
                            If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                                PB1B.Enabled = True
                                C1B.Show()
                            Else
                                PB1B.Enabled = True
                                C1B.Show()
                            End If
                        End If
                    End If
                End If
                If f3b = "1ro" Then
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf f3b = "1kg" Or f3b = "1rm" Then
                If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                Else
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f3b = "1rm" Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f3b = "2o" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f3b = "2km" Then
                If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                Else
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                Else
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            ElseIf f3b = "2g" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f3b = "2k" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2tk" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf f3b = "2hh" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f3b = "2ks" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        Else
                            If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                                PB1B.Enabled = True
                                C1B.Show()
                            Else
                                PB1B.Enabled = True
                                C1B.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f3b = "2hs" Or f3b = "2ro" Then
                If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                Else
                    If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                Else
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                        Else
                            If f1b = "1g" Or f1b = "1hh" Or f1b = "1hs" Or f1b = "1k" Or f1b = "1kg" Or f1b = "1km" Or f1b = "1ks" Or f1b = "1ng" Or f1b = "1nk" Or f1b = "1nky" Or f1b = "1o" Or f1b = "1rm" Or f1b = "1ro" Or f1b = "1tk" Then
                                PB1B.Enabled = True
                                C1B.Show()
                            Else
                                PB1B.Enabled = True
                                C1B.Show()
                            End If
                        End If
                    End If
                End If
                If f3b = "2ro" Then
                    If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf f3b = "2kg" Or f3b = "2rm" Then
                If f2a = "2g" Or f2a = "2hh" Or f2a = "2hs" Or f2a = "2k" Or f2a = "2kg" Or f2a = "2km" Or f2a = "2ks" Or f2a = "2ng" Or f2a = "2nk" Or f2a = "2nky" Or f2a = "2o" Or f2a = "2rm" Or f2a = "2ro" Or f2a = "2tk" Then
                Else
                    If f2a = "1g" Or f2a = "1hh" Or f2a = "1hs" Or f2a = "1k" Or f2a = "1kg" Or f2a = "1km" Or f2a = "1ks" Or f2a = "1ng" Or f2a = "1nk" Or f2a = "1nky" Or f2a = "1o" Or f2a = "1rm" Or f2a = "1ro" Or f2a = "1tk" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    Else
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
                If f3b = "2rm" Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                    Else
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                    Else
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PB3C_Click(sender As Object, e As EventArgs) Handles PB3C.Click
        If ss = 0 Then
            f.tp = "3c"
            f.PN.Text = "3c"
        ElseIf ss = 1 Then
            ss = 2
            sp = "3c"
            tr = f3c
            A3C()
        Else
            '再選択
            If t = 1 Then
                If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                    ss = 2
                    sp = "3c"
                    tr = f3c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3C()
                    Exit Sub
                End If
            ElseIf t = 2 Then
                If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                    ss = 2
                    sp = "3c"
                    tr = f3c
                    G()
                    S1()
                    If t = 2 Then
                        t = 1
                    ElseIf t = 1 Then
                        t = 2
                    End If
                    S2()
                    A3C()
                    Exit Sub
                End If
            End If
            If ss = 2 Then
                '持ち駒追加
                If t = 1 Then
                    If f3c = "2g" Or f3c = "2hh" Or f3c = "2hs" Or f3c = "2k" Or f3c = "2kg" Or f3c = "2km" Or f3c = "2ks" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2o" Or f3c = "2rm" Or f3c = "2ro" Or f3c = "2tk" Then
                        If f3c = "2o" Then
                            Dim f As New Result
                            f.LR.Text = "先手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3c = "2g" Or f3c = "2ng" Then
                            sc = "1g"
                        End If
                        If f3c = "2hh" Or f3c = "2tk" Then
                            sc = "1hh"
                        End If
                        If f3c = "2hs" Or f3c = "2ro" Then
                            sc = "1hs"
                        End If
                        If f3c = "2k" Then
                            sc = "1k"
                        End If
                        If f3c = "2kg" Or f3c = "2rm" Then
                            sc = "1kg"
                        End If
                        If f3c = "2km" Or f3c = "2nk" Then
                            sc = "1km"
                        End If
                        If f3c = "2ks" Or f3c = "2nky" Then
                            sc = "1ks"
                        End If
                    End If
                    If a1 = "" Then
                        a1 = sc
                    ElseIf a2 = "" Then
                        a2 = sc
                    ElseIf a3 = "" Then
                        a3 = sc
                    ElseIf a4 = "" Then
                        a4 = sc
                    ElseIf a5 = "" Then
                        a5 = sc
                    ElseIf a6 = "" Then
                        a6 = sc
                    ElseIf a7 = "" Then
                        a7 = sc
                    End If
                ElseIf t = 2 Then
                    If f3c = "1g" Or f3c = "1hh" Or f3c = "1hs" Or f3c = "1k" Or f3c = "1kg" Or f3c = "1km" Or f3c = "1ks" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1o" Or f3c = "1rm" Or f3c = "1ro" Or f3c = "1tk" Then
                        If f3c = "1o" Then
                            Dim f As New Result
                            f.LR.Text = "後手"
                            'f.showdialog(Me)
                            f.Dispose()
                            w = 1
                            'Close()
                        End If
                        If f3c = "1g" Or f3c = "1ng" Then
                            sc = "2g"
                        End If
                        If f3c = "1hh" Or f3c = "1tk" Then
                            sc = "2hh"
                        End If
                        If f3c = "1hs" Or f3c = "1ro" Then
                            sc = "2hs"
                        End If
                        If f3c = "1k" Then
                            sc = "2k"
                        End If
                        If f3c = "1kg" Or f3c = "1rm" Then
                            sc = "2kg"
                        End If
                        If f3c = "1km" Or f3c = "1nk" Then
                            sc = "2km"
                        End If
                        If f3c = "1ks" Or f3c = "1nky" Then
                            sc = "2ks"
                        End If
                    End If
                    If b1 = "" Then
                        b1 = sc
                    ElseIf b2 = "" Then
                        b2 = sc
                    ElseIf b3 = "" Then
                        b3 = sc
                    ElseIf b4 = "" Then
                        b4 = sc
                    ElseIf b5 = "" Then
                        b5 = sc
                    ElseIf b6 = "" Then
                        b6 = sc
                    ElseIf b7 = "" Then
                        b7 = sc
                    End If
                End If
                '成確認
                If t = 1 Then
                    If tr = "1hh" Then
                        tr = "1tk"
                    End If
                    If tr = "1ks" Then
                        tr = "1nky"
                    End If
                    If tr = "1km" Then
                        tr = "1nk"
                    End If
                    If tr = "1g" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ng"
                        End If
                    End If
                    If tr = "1hs" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1ro"
                        End If
                    End If
                    If tr = "1kg" Then
                        Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        If q = DialogResult.Yes Then
                            tr = "1rm"
                        End If
                    End If
                ElseIf t = 2 Then
                    If sp = "1a" Or sp = "1b" Or sp = "1c" Then
                        If tr = "2hh" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2tk"
                            End If
                        End If
                        If tr = "2ks" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nky"
                            End If
                        End If
                        If tr = "2km" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2nk"
                            End If
                        End If
                        If tr = "2g" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ng"
                            End If
                        End If
                        If tr = "2hs" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2ro"
                            End If
                        End If
                        If tr = "2kg" Then
                            Dim q As DialogResult = MessageBox.Show("成りますか？",
                            "将棋", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                            If q = DialogResult.Yes Then
                                tr = "2rm"
                            End If
                        End If
                    End If
                End If
            End If
            ss = 1
            '置き換え
            f3c = tr
            'In
            If sp = "1a" Then
                f1a = ""
            ElseIf sp = "1b" Then
                f1b = ""
            ElseIf sp = "1c" Then
                f1c = ""
            ElseIf sp = "2a" Then
                f2a = ""
            ElseIf sp = "2b" Then
                f2b = ""
            ElseIf sp = "2c" Then
                f2c = ""
            ElseIf sp = "3a" Then
                f3a = ""
            ElseIf sp = "3b" Then
                f3b = ""
            ElseIf sp = "3c" Then
                f3c = ""
            End If
            'Out
            If sp = "a1" Then
                a1 = ""
            ElseIf sp = "a2" Then
                a2 = ""
            ElseIf sp = "a3" Then
                a3 = ""
            ElseIf sp = "a4" Then
                a4 = ""
            ElseIf sp = "a5" Then
                a5 = ""
            ElseIf sp = "a6" Then
                a6 = ""
            ElseIf sp = "a7" Then
                a7 = ""
            ElseIf sp = "b1" Then
                b1 = ""
            ElseIf sp = "b2" Then
                b2 = ""
            ElseIf sp = "b3" Then
                b3 = ""
            ElseIf sp = "b4" Then
                b4 = ""
            ElseIf sp = "b5" Then
                b5 = ""
            ElseIf sp = "b6" Then
                b6 = ""
            ElseIf sp = "b7" Then
                b7 = ""
            End If
            M()
            G()
            S1()
            S2()
        End If
    End Sub

    Sub A3C()
        If t = 1 Then
            If f3c = "1o" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3c = "1km" Then
            ElseIf f3c = "1g" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
            ElseIf f3c = "1k" Or f3c = "1ng" Or f3c = "1nk" Or f3c = "1nky" Or f3c = "1tk" Then
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3c = "1hh" Then
            ElseIf f3c = "1ks" Then
            ElseIf f3c = "1hs" Or f3c = "1ro" Then
                If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                Else
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                        If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                        Else
                            If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                Else
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                        Else
                            If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f3c = "1ro" Then
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f3c = "1kg" Or f3c = "1rm" Then
                If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                Else
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                        Else
                            If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f3c = "1rm" Then
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        ElseIf t = 2 Then
            If f3c = "2o" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3c = "2km" Then
                If f1b = "2g" Or f1b = "2hh" Or f1b = "2hs" Or f1b = "2k" Or f1b = "2kg" Or f1b = "2km" Or f1b = "2ks" Or f1b = "2ng" Or f1b = "2nk" Or f1b = "2nky" Or f1b = "2o" Or f1b = "2rm" Or f1b = "2ro" Or f1b = "2tk" Then
                Else
                    PB1B.Enabled = True
                    C1B.Show()
                End If
            ElseIf f3c = "2g" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f3c = "2k" Or f3c = "2ng" Or f3c = "2nk" Or f3c = "2nky" Or f3c = "2tk" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    PB3B.Enabled = True
                    C3B.Show()
                End If
            ElseIf f3c = "2hh" Then
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf f3c = "2ks" Then
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        Else
                            If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
            ElseIf f3c = "2hs" Or f3c = "2ro" Then
                If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                Else
                    If f3b = "1g" Or f3b = "1hh" Or f3b = "1hs" Or f3b = "1k" Or f3b = "1kg" Or f3b = "1km" Or f3b = "1ks" Or f3b = "1ng" Or f3b = "1nk" Or f3b = "1nky" Or f3b = "1o" Or f3b = "1rm" Or f3b = "1ro" Or f3b = "1tk" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                        If f3a = "2g" Or f3a = "2hh" Or f3a = "2hs" Or f3a = "2k" Or f3a = "2kg" Or f3a = "2km" Or f3a = "2ks" Or f3a = "2ng" Or f3a = "2nk" Or f3a = "2nky" Or f3a = "2o" Or f3a = "2rm" Or f3a = "2ro" Or f3a = "2tk" Then
                        Else
                            If f3a = "1g" Or f3a = "1hh" Or f3a = "1hs" Or f3a = "1k" Or f3a = "1kg" Or f3a = "1km" Or f3a = "1ks" Or f3a = "1ng" Or f3a = "1nk" Or f3a = "1nky" Or f3a = "1o" Or f3a = "1rm" Or f3a = "1ro" Or f3a = "1tk" Then
                                PB3A.Enabled = True
                                C3A.Show()
                            Else
                                PB3A.Enabled = True
                                C3A.Show()
                            End If
                        End If
                    End If
                End If
                If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                Else
                    If f2c = "1g" Or f2c = "1hh" Or f2c = "1hs" Or f2c = "1k" Or f2c = "1kg" Or f2c = "1km" Or f2c = "1ks" Or f2c = "1ng" Or f2c = "1nk" Or f2c = "1nky" Or f2c = "1o" Or f2c = "1rm" Or f2c = "1ro" Or f2c = "1tk" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                        If f1c = "2g" Or f1c = "2hh" Or f1c = "2hs" Or f1c = "2k" Or f1c = "2kg" Or f1c = "2km" Or f1c = "2ks" Or f1c = "2ng" Or f1c = "2nk" Or f1c = "2nky" Or f1c = "2o" Or f1c = "2rm" Or f1c = "2ro" Or f1c = "2tk" Then
                        Else
                            If f1c = "1g" Or f1c = "1hh" Or f1c = "1hs" Or f1c = "1k" Or f1c = "1kg" Or f1c = "1km" Or f1c = "1ks" Or f1c = "1ng" Or f1c = "1nk" Or f1c = "1nky" Or f1c = "1o" Or f1c = "1rm" Or f1c = "1ro" Or f1c = "1tk" Then
                                PB1C.Enabled = True
                                C1C.Show()
                            Else
                                PB1C.Enabled = True
                                C1C.Show()
                            End If
                        End If
                    End If
                End If
                If f3c = "2ro" Then
                    If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
            ElseIf f3c = "2kg" Or f3c = "2rm" Then
                If f2b = "2g" Or f2b = "2hh" Or f2b = "2hs" Or f2b = "2k" Or f2b = "2kg" Or f2b = "2km" Or f2b = "2ks" Or f2b = "2ng" Or f2b = "2nk" Or f2b = "2nky" Or f2b = "2o" Or f2b = "2rm" Or f2b = "2ro" Or f2b = "2tk" Then
                Else
                    If f2b = "1g" Or f2b = "1hh" Or f2b = "1hs" Or f2b = "1k" Or f2b = "1kg" Or f2b = "1km" Or f2b = "1ks" Or f2b = "1ng" Or f2b = "1nk" Or f2b = "1nky" Or f2b = "1o" Or f2b = "1rm" Or f2b = "1ro" Or f2b = "1tk" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    Else
                        PB2B.Enabled = True
                        C2B.Show()
                        If f1a = "2g" Or f1a = "2hh" Or f1a = "2hs" Or f1a = "2k" Or f1a = "2kg" Or f1a = "2km" Or f1a = "2ks" Or f1a = "2ng" Or f1a = "2nk" Or f1a = "2nky" Or f1a = "2o" Or f1a = "2rm" Or f1a = "2ro" Or f1a = "2tk" Then
                        Else
                            If f1a = "1g" Or f1a = "1hh" Or f1a = "1hs" Or f1a = "1k" Or f1a = "1kg" Or f1a = "1km" Or f1a = "1ks" Or f1a = "1ng" Or f1a = "1nk" Or f1a = "1nky" Or f1a = "1o" Or f1a = "1rm" Or f1a = "1ro" Or f1a = "1tk" Then
                                PB1A.Enabled = True
                                C1A.Show()
                            Else
                                PB1A.Enabled = True
                                C1A.Show()
                            End If
                        End If
                    End If
                End If
                If f3c = "2rm" Then
                    If f2c = "2g" Or f2c = "2hh" Or f2c = "2hs" Or f2c = "2k" Or f2c = "2kg" Or f2c = "2km" Or f2c = "2ks" Or f2c = "2ng" Or f2c = "2nk" Or f2c = "2nky" Or f2c = "2o" Or f2c = "2rm" Or f2c = "2ro" Or f2c = "2tk" Then
                    Else
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3b = "2g" Or f3b = "2hh" Or f3b = "2hs" Or f3b = "2k" Or f3b = "2kg" Or f3b = "2km" Or f3b = "2ks" Or f3b = "2ng" Or f3b = "2nk" Or f3b = "2nky" Or f3b = "2o" Or f3b = "2rm" Or f3b = "2ro" Or f3b = "2tk" Then
                    Else
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub P11_Click(sender As Object, e As EventArgs) Handles P11.Click
        If ss = 0 Then
            f.tp = "a1"
            f.PN.Text = "a1"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a1"
            If a1 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a1 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a1 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a1 = "1g" Then
                    tr = "1g"
                ElseIf a1 = "1hs" Then
                    tr = "1hs"
                ElseIf a1 = "1k" Then
                    tr = "1k"
                ElseIf a1 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a1"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a1 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a1 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a1 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a1 = "1g" Then
                    tr = "1g"
                ElseIf a1 = "1hs" Then
                    tr = "1hs"
                ElseIf a1 = "1k" Then
                    tr = "1k"
                ElseIf a1 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P12_Click(sender As Object, e As EventArgs) Handles P12.Click
        If ss = 0 Then
            f.tp = "a2"
            f.PN.Text = "a2"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a2"
            If a2 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a2 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a2 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a2 = "1g" Then
                    tr = "1g"
                ElseIf a2 = "1hs" Then
                    tr = "1hs"
                ElseIf a2 = "1k" Then
                    tr = "1k"
                ElseIf a2 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a2"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a2 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a2 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a2 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a2 = "1g" Then
                    tr = "1g"
                ElseIf a2 = "1hs" Then
                    tr = "1hs"
                ElseIf a2 = "1k" Then
                    tr = "1k"
                ElseIf a2 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P13_Click(sender As Object, e As EventArgs) Handles P13.Click
        If ss = 0 Then
            f.tp = "a3"
            f.PN.Text = "a3"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a3"
            If a3 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a3 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a3 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a3 = "1g" Then
                    tr = "1g"
                ElseIf a3 = "1hs" Then
                    tr = "1hs"
                ElseIf a3 = "1k" Then
                    tr = "1k"
                ElseIf a3 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a3"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a3 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a3 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a3 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a3 = "1g" Then
                    tr = "1g"
                ElseIf a3 = "1hs" Then
                    tr = "1hs"
                ElseIf a3 = "1k" Then
                    tr = "1k"
                ElseIf a3 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P14_Click(sender As Object, e As EventArgs) Handles P14.Click
        If ss = 0 Then
            f.tp = "a4"
            f.PN.Text = "a4"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a4"
            If a4 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a4 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a4 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a4 = "1g" Then
                    tr = "1g"
                ElseIf a4 = "1hs" Then
                    tr = "1hs"
                ElseIf a4 = "1k" Then
                    tr = "1k"
                ElseIf a4 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a4"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a4 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a4 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a4 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a4 = "1g" Then
                    tr = "1g"
                ElseIf a4 = "1hs" Then
                    tr = "1hs"
                ElseIf a4 = "1k" Then
                    tr = "1k"
                ElseIf a4 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P15_Click(sender As Object, e As EventArgs) Handles P15.Click
        If ss = 0 Then
            f.tp = "a5"
            f.PN.Text = "a5"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a5"
            If a5 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a5 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a5 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a5 = "1g" Then
                    tr = "1g"
                ElseIf a5 = "1hs" Then
                    tr = "1hs"
                ElseIf a5 = "1k" Then
                    tr = "1k"
                ElseIf a5 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a5"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a5 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a5 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a5 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a5 = "1g" Then
                    tr = "1g"
                ElseIf a5 = "1hs" Then
                    tr = "1hs"
                ElseIf a5 = "1k" Then
                    tr = "1k"
                ElseIf a5 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P16_Click(sender As Object, e As EventArgs) Handles P16.Click
        If ss = 0 Then
            f.tp = "a6"
            f.PN.Text = "a6"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a6"
            If a6 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a6 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a6 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a6 = "1g" Then
                    tr = "1g"
                ElseIf a6 = "1hs" Then
                    tr = "1hs"
                ElseIf a6 = "1k" Then
                    tr = "1k"
                ElseIf a6 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a6"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a6 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a6 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a6 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a6 = "1g" Then
                    tr = "1g"
                ElseIf a6 = "1hs" Then
                    tr = "1hs"
                ElseIf a6 = "1k" Then
                    tr = "1k"
                ElseIf a6 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P17_Click(sender As Object, e As EventArgs) Handles P17.Click
        If ss = 0 Then
            f.tp = "a7"
            f.PN.Text = "a7"
        ElseIf ss = 1 Then
            ss = 3
            sp = "a7"
            If a7 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a7 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a7 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a7 = "1g" Then
                    tr = "1g"
                ElseIf a7 = "1hs" Then
                    tr = "1hs"
                ElseIf a7 = "1k" Then
                    tr = "1k"
                ElseIf a7 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "a7"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If a7 = "1hh" Then
                tr = "1hh"
                If f1a = "1hh" Or f2a = "1hh" Or f3a = "1hh" Then
                Else
                    If f1a = "" Then
                        PB1A.Enabled = True
                        C1A.Show()
                    End If
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                End If
                If f1b = "1hh" Or f2b = "1hh" Or f3b = "1hh" Then
                Else
                    If f1b = "" Then
                        PB1B.Enabled = True
                        C1B.Show()
                    End If
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                End If
                If f1c = "1hh" Or f2c = "1hh" Or f3c = "1hh" Then
                Else
                    If f1c = "" Then
                        PB1C.Enabled = True
                        C1C.Show()
                    End If
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                End If
            ElseIf a7 = "1ks" Then
                tr = "1ks"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
            ElseIf a7 = "1km" Then
                tr = "1km"
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
            Else
                If a7 = "1g" Then
                    tr = "1g"
                ElseIf a7 = "1hs" Then
                    tr = "1hs"
                ElseIf a7 = "1k" Then
                    tr = "1k"
                ElseIf a7 = "1kg" Then
                    tr = "1kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P21_Click(sender As Object, e As EventArgs) Handles P21.Click
        If ss = 0 Then
            f.tp = "b1"
            f.PN.Text = "b1"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b1"
            If b1 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b1 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b1 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b1 = "2g" Then
                    tr = "2g"
                ElseIf b1 = "2hs" Then
                    tr = "2hs"
                ElseIf b1 = "2k" Then
                    tr = "2k"
                ElseIf b1 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b1"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b1 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b1 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b1 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b1 = "2g" Then
                    tr = "2g"
                ElseIf b1 = "2hs" Then
                    tr = "2hs"
                ElseIf b1 = "2k" Then
                    tr = "2k"
                ElseIf b1 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P22_Click(sender As Object, e As EventArgs) Handles P22.Click
        If ss = 0 Then
            f.tp = "b2"
            f.PN.Text = "b2"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b2"
            If b2 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b2 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b2 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b2 = "2g" Then
                    tr = "2g"
                ElseIf b2 = "2hs" Then
                    tr = "2hs"
                ElseIf b2 = "2k" Then
                    tr = "2k"
                ElseIf b2 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b2"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b2 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b2 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b2 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b2 = "2g" Then
                    tr = "2g"
                ElseIf b2 = "2hs" Then
                    tr = "2hs"
                ElseIf b2 = "2k" Then
                    tr = "2k"
                ElseIf b2 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P23_Click(sender As Object, e As EventArgs) Handles P23.Click
        If ss = 0 Then
            f.tp = "b3"
            f.PN.Text = "b3"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b3"
            If b3 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b3 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b3 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b3 = "2g" Then
                    tr = "2g"
                ElseIf b3 = "2hs" Then
                    tr = "2hs"
                ElseIf b3 = "2k" Then
                    tr = "2k"
                ElseIf b3 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b3"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b3 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b3 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b3 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b3 = "2g" Then
                    tr = "2g"
                ElseIf b3 = "2hs" Then
                    tr = "2hs"
                ElseIf b3 = "2k" Then
                    tr = "2k"
                ElseIf b3 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P24_Click(sender As Object, e As EventArgs) Handles P24.Click
        If ss = 0 Then
            f.tp = "b4"
            f.PN.Text = "b4"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b4"
            If b4 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b4 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b4 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b4 = "2g" Then
                    tr = "2g"
                ElseIf b4 = "2hs" Then
                    tr = "2hs"
                ElseIf b4 = "2k" Then
                    tr = "2k"
                ElseIf b4 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b4"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b4 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b4 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b4 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b4 = "2g" Then
                    tr = "2g"
                ElseIf b4 = "2hs" Then
                    tr = "2hs"
                ElseIf b4 = "2k" Then
                    tr = "2k"
                ElseIf b4 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P25_Click(sender As Object, e As EventArgs) Handles P25.Click
        If ss = 0 Then
            f.tp = "b5"
            f.PN.Text = "b5"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b5"
            If b5 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b5 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b5 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b5 = "2g" Then
                    tr = "2g"
                ElseIf b5 = "2hs" Then
                    tr = "2hs"
                ElseIf b5 = "2k" Then
                    tr = "2k"
                ElseIf b5 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b5"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b5 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b5 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b5 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b5 = "2g" Then
                    tr = "2g"
                ElseIf b5 = "2hs" Then
                    tr = "2hs"
                ElseIf b5 = "2k" Then
                    tr = "2k"
                ElseIf b5 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P26_Click(sender As Object, e As EventArgs) Handles P26.Click
        If ss = 0 Then
            f.tp = "b6"
            f.PN.Text = "b6"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b6"
            If b6 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b6 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b6 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b6 = "2g" Then
                    tr = "2g"
                ElseIf b6 = "2hs" Then
                    tr = "2hs"
                ElseIf b6 = "2k" Then
                    tr = "2k"
                ElseIf b6 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b6"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b6 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b6 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b6 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b6 = "2g" Then
                    tr = "2g"
                ElseIf b6 = "2hs" Then
                    tr = "2hs"
                ElseIf b6 = "2k" Then
                    tr = "2k"
                ElseIf b6 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P27_Click(sender As Object, e As EventArgs) Handles P27.Click
        If ss = 0 Then
            f.tp = "b7"
            f.PN.Text = "b7"
        ElseIf ss = 1 Then
            ss = 3
            sp = "b7"
            If b7 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b7 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b7 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b7 = "2g" Then
                    tr = "2g"
                ElseIf b7 = "2hs" Then
                    tr = "2hs"
                ElseIf b7 = "2k" Then
                    tr = "2k"
                ElseIf b7 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        ElseIf ss >= 2 Then
            ss = 3
            sp = "b7"
            G()
            S1()
            If t = 2 Then
                t = 1
            ElseIf t = 1 Then
                t = 2
            End If
            S2()
            If b7 = "2hh" Then
                tr = "2hh"
                If f1a = "2hh" Or f2a = "2hh" Or f3a = "2hh" Then
                Else
                    If f2a = "" Then
                        PB2A.Enabled = True
                        C2A.Show()
                    End If
                    If f3a = "" Then
                        PB3A.Enabled = True
                        C3A.Show()
                    End If
                End If
                If f1b = "2hh" Or f2b = "2hh" Or f3b = "2hh" Then
                Else
                    If f2b = "" Then
                        PB2B.Enabled = True
                        C2B.Show()
                    End If
                    If f3b = "" Then
                        PB3B.Enabled = True
                        C3B.Show()
                    End If
                End If
                If f1c = "2hh" Or f2c = "2hh" Or f3c = "2hh" Then
                Else
                    If f2c = "" Then
                        PB2C.Enabled = True
                        C2C.Show()
                    End If
                    If f3c = "" Then
                        PB3C.Enabled = True
                        C3C.Show()
                    End If
                End If
            ElseIf b7 = "2ks" Then
                tr = "2ks"
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            ElseIf b7 = "2km" Then
                tr = "2km"
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            Else
                If b7 = "2g" Then
                    tr = "2g"
                ElseIf b7 = "2hs" Then
                    tr = "2hs"
                ElseIf b7 = "2k" Then
                    tr = "2k"
                ElseIf b7 = "2kg" Then
                    tr = "2kg"
                End If
                If f1a = "" Then
                    PB1A.Enabled = True
                    C1A.Show()
                End If
                If f1b = "" Then
                    PB1B.Enabled = True
                    C1B.Show()
                End If
                If f1c = "" Then
                    PB1C.Enabled = True
                    C1C.Show()
                End If
                If f2a = "" Then
                    PB2A.Enabled = True
                    C2A.Show()
                End If
                If f2b = "" Then
                    PB2B.Enabled = True
                    C2B.Show()
                End If
                If f2c = "" Then
                    PB2C.Enabled = True
                    C2C.Show()
                End If
                If f3a = "" Then
                    PB3A.Enabled = True
                    C3A.Show()
                End If
                If f3b = "" Then
                    PB3B.Enabled = True
                    C3B.Show()
                End If
                If f3c = "" Then
                    PB3C.Enabled = True
                    C3C.Show()
                End If
            End If
        End If
    End Sub

    Private Sub P1L_Click(sender As Object, e As EventArgs) Handles P1L.Click
        Dim f As New Result
        f.LR.Text = "後手"
        f.ShowDialog(Me)
        f.Dispose()
        w = 1
        Close()
    End Sub

    Private Sub P2L_Click(sender As Object, e As EventArgs) Handles P2L.Click
        Dim f As New Result
        f.LR.Text = "先手"
        f.ShowDialog(Me)
        f.Dispose()
        w = 1
        Close()
    End Sub

    Private Sub P1O_Click(sender As Object, e As EventArgs) Handles P1O.Click
        If ok = 0 Then
            ok = 1
            P1O.Hide()
        ElseIf ok = 1 Then
            P1O.Hide()
            f.Hide()
            GS()
        End If
    End Sub

    Private Sub P2O_Click(sender As Object, e As EventArgs) Handles P2O.Click
        If ok = 0 Then
            ok = 1
            P2O.Hide()
        ElseIf ok = 1 Then
            P2O.Hide()
            f.Hide()
            GS()
        End If
    End Sub

    Private Sub Game_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If ss > 0 Then
            If w = 0 Then
                Dim Answer As MsgBoxResult
                Answer = MsgBox("対戦を終了または中断しますか？", MsgBoxStyle.YesNo, "確認")
                If Answer = MsgBoxResult.No Then
                    e.Cancel = True
                ElseIf Answer = MsgBoxResult.Yes Then
                    Answer = MsgBox("対戦の中断を保存しますか？", MsgBoxStyle.YesNo, "確認")
                    If Answer = MsgBoxResult.No Then
                        e.Cancel = False
                    ElseIf Answer = MsgBoxResult.Yes Then
                        Dim d1, d2, d3, d4, d5, d6, da As String
                        d1 = System.DateTime.Now.Year
                        d2 = System.DateTime.Now.Month
                        If d2 < 10 Then
                            d2 = "0" & d2
                        End If
                        d3 = System.DateTime.Now.Day
                        If d3 < 10 Then
                            d3 = "0" & d3
                        End If
                        d4 = System.DateTime.Now.Hour
                        If d4 < 10 Then
                            d4 = "0" & d4
                        End If
                        d5 = System.DateTime.Now.Minute
                        If d5 < 10 Then
                            d5 = "0" & d5
                        End If
                        d6 = System.DateTime.Now.Second
                        If d6 < 10 Then
                            d6 = "0" & d6
                        End If
                        da = d1 & d2 & d3 & d4 & d5 & d6
                        Dim sw As New System.IO.StreamWriter(da & ".sty", False, System.Text.Encoding.GetEncoding("shift_jis"))
                        sw.WriteLine("2")
                        sw.WriteLine(t)
                        sw.WriteLine(f1a)
                        sw.WriteLine(f2a)
                        sw.WriteLine(f3a)
                        sw.WriteLine(f1b)
                        sw.WriteLine(f2b)
                        sw.WriteLine(f3b)
                        sw.WriteLine(f1c)
                        sw.WriteLine(f2c)
                        sw.WriteLine(f3c)
                        sw.WriteLine(a1)
                        sw.WriteLine(a2)
                        sw.WriteLine(a3)
                        sw.WriteLine(a4)
                        sw.WriteLine(a5)
                        sw.WriteLine(a6)
                        sw.WriteLine(a7)
                        sw.WriteLine(b1)
                        sw.WriteLine(b2)
                        sw.WriteLine(b3)
                        sw.WriteLine(b4)
                        sw.WriteLine(b5)
                        sw.WriteLine(b6)
                        sw.WriteLine(b7)
                        sw.Close()
                        MsgBox("対戦中断記録の保存が終了しました。", MsgBoxStyle.OkOnly, "完了")
                        e.Cancel = False
                    End If
                End If
            End If
        End If
    End Sub
End Class