Public Class S
    Public tp As String
    Public g1, hs1, k1, kg1, km1, ks1, o1 As Byte
    Public g2, hs2, k2, kg2, km2, ks2, o2 As Byte
    Public a As SByte
    Dim o As GV2
    Private Sub S_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o = CType(Me.Owner, GV2)
        Left = o.Left + o.Width
        Top = o.Top
    End Sub

    Private Sub K1g_Click(sender As Object, e As EventArgs) Handles K1g.Click
        IB()
        g1 = g1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1g"
        ElseIf tp = "1b" Then
            o.f1b = "1g"
        ElseIf tp = "1c" Then
            o.f1c = "1g"
        ElseIf tp = "2a" Then
            o.f2a = "1g"
        ElseIf tp = "2b" Then
            o.f2b = "1g"
        ElseIf tp = "2c" Then
            o.f2c = "1g"
        ElseIf tp = "3a" Then
            o.f3a = "1g"
        ElseIf tp = "3b" Then
            o.f3b = "1g"
        ElseIf tp = "3c" Then
            o.f3c = "1g"
        ElseIf tp = "a1" Then
            o.a1 = "1g"
        ElseIf tp = "a2" Then
            o.a2 = "1g"
        ElseIf tp = "a3" Then
            o.a3 = "1g"
        ElseIf tp = "a4" Then
            o.a4 = "1g"
        ElseIf tp = "a5" Then
            o.a5 = "1g"
        ElseIf tp = "a6" Then
            o.a6 = "1g"
        ElseIf tp = "a7" Then
            o.a7 = "1g"
        ElseIf tp = "b1" Then
            o.b1 = "1g"
        ElseIf tp = "b2" Then
            o.b2 = "1g"
        ElseIf tp = "b3" Then
            o.b3 = "1g"
        ElseIf tp = "b4" Then
            o.b4 = "1g"
        ElseIf tp = "b5" Then
            o.b5 = "1g"
        ElseIf tp = "b6" Then
            o.b6 = "1g"
        ElseIf tp = "b7" Then
            o.b7 = "1g"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1hh_Click(sender As Object, e As EventArgs) Handles K1hh.Click
        IB()
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1hh"
        ElseIf tp = "1b" Then
            o.f1b = "1hh"
        ElseIf tp = "1c" Then
            o.f1c = "1hh"
        ElseIf tp = "2a" Then
            o.f2a = "1hh"
        ElseIf tp = "2b" Then
            o.f2b = "1hh"
        ElseIf tp = "2c" Then
            o.f2c = "1hh"
        ElseIf tp = "3a" Then
            o.f3a = "1hh"
        ElseIf tp = "3b" Then
            o.f3b = "1hh"
        ElseIf tp = "3c" Then
            o.f3c = "1hh"
        ElseIf tp = "a1" Then
            o.a1 = "1hh"
        ElseIf tp = "a2" Then
            o.a2 = "1hh"
        ElseIf tp = "a3" Then
            o.a3 = "1hh"
        ElseIf tp = "a4" Then
            o.a4 = "1hh"
        ElseIf tp = "a5" Then
            o.a5 = "1hh"
        ElseIf tp = "a6" Then
            o.a6 = "1hh"
        ElseIf tp = "a7" Then
            o.a7 = "1hh"
        ElseIf tp = "b1" Then
            o.b1 = "1hh"
        ElseIf tp = "b2" Then
            o.b2 = "1hh"
        ElseIf tp = "b3" Then
            o.b3 = "1hh"
        ElseIf tp = "b4" Then
            o.b4 = "1hh"
        ElseIf tp = "b5" Then
            o.b5 = "1hh"
        ElseIf tp = "b6" Then
            o.b6 = "1hh"
        ElseIf tp = "b7" Then
            o.b7 = "1hh"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1hs_Click(sender As Object, e As EventArgs) Handles K1hs.Click
        IB()
        hs1 = hs1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1hs"
        ElseIf tp = "1b" Then
            o.f1b = "1hs"
        ElseIf tp = "1c" Then
            o.f1c = "1hs"
        ElseIf tp = "2a" Then
            o.f2a = "1hs"
        ElseIf tp = "2b" Then
            o.f2b = "1hs"
        ElseIf tp = "2c" Then
            o.f2c = "1hs"
        ElseIf tp = "3a" Then
            o.f3a = "1hs"
        ElseIf tp = "3b" Then
            o.f3b = "1hs"
        ElseIf tp = "3c" Then
            o.f3c = "1hs"
        ElseIf tp = "a1" Then
            o.a1 = "1hs"
        ElseIf tp = "a2" Then
            o.a2 = "1hs"
        ElseIf tp = "a3" Then
            o.a3 = "1hs"
        ElseIf tp = "a4" Then
            o.a4 = "1hs"
        ElseIf tp = "a5" Then
            o.a5 = "1hs"
        ElseIf tp = "a6" Then
            o.a6 = "1hs"
        ElseIf tp = "a7" Then
            o.a7 = "1hs"
        ElseIf tp = "b1" Then
            o.b1 = "1hs"
        ElseIf tp = "b2" Then
            o.b2 = "1hs"
        ElseIf tp = "b3" Then
            o.b3 = "1hs"
        ElseIf tp = "b4" Then
            o.b4 = "1hs"
        ElseIf tp = "b5" Then
            o.b5 = "1hs"
        ElseIf tp = "b6" Then
            o.b6 = "1hs"
        ElseIf tp = "b7" Then
            o.b7 = "1hs"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1kg_Click(sender As Object, e As EventArgs) Handles K1kg.Click
        IB()
        kg1 = kg1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1kg"
        ElseIf tp = "1b" Then
            o.f1b = "1kg"
        ElseIf tp = "1c" Then
            o.f1c = "1kg"
        ElseIf tp = "2a" Then
            o.f2a = "1kg"
        ElseIf tp = "2b" Then
            o.f2b = "1kg"
        ElseIf tp = "2c" Then
            o.f2c = "1kg"
        ElseIf tp = "3a" Then
            o.f3a = "1kg"
        ElseIf tp = "3b" Then
            o.f3b = "1kg"
        ElseIf tp = "3c" Then
            o.f3c = "1kg"
        ElseIf tp = "a1" Then
            o.a1 = "1kg"
        ElseIf tp = "a2" Then
            o.a2 = "1kg"
        ElseIf tp = "a3" Then
            o.a3 = "1kg"
        ElseIf tp = "a4" Then
            o.a4 = "1kg"
        ElseIf tp = "a5" Then
            o.a5 = "1kg"
        ElseIf tp = "a6" Then
            o.a6 = "1kg"
        ElseIf tp = "a7" Then
            o.a7 = "1kg"
        ElseIf tp = "b1" Then
            o.b1 = "1kg"
        ElseIf tp = "b2" Then
            o.b2 = "1kg"
        ElseIf tp = "b3" Then
            o.b3 = "1kg"
        ElseIf tp = "b4" Then
            o.b4 = "1kg"
        ElseIf tp = "b5" Then
            o.b5 = "1kg"
        ElseIf tp = "b6" Then
            o.b6 = "1kg"
        ElseIf tp = "b7" Then
            o.b7 = "1kg"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1km_Click(sender As Object, e As EventArgs) Handles K1km.Click
        IB()
        km1 = km1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1km"
        ElseIf tp = "1b" Then
            o.f1b = "1km"
        ElseIf tp = "1c" Then
            o.f1c = "1km"
        ElseIf tp = "2a" Then
            o.f2a = "1km"
        ElseIf tp = "2b" Then
            o.f2b = "1km"
        ElseIf tp = "2c" Then
            o.f2c = "1km"
        ElseIf tp = "3a" Then
            o.f3a = "1km"
        ElseIf tp = "3b" Then
            o.f3b = "1km"
        ElseIf tp = "3c" Then
            o.f3c = "1km"
        ElseIf tp = "a1" Then
            o.a1 = "1km"
        ElseIf tp = "a2" Then
            o.a2 = "1km"
        ElseIf tp = "a3" Then
            o.a3 = "1km"
        ElseIf tp = "a4" Then
            o.a4 = "1km"
        ElseIf tp = "a5" Then
            o.a5 = "1km"
        ElseIf tp = "a6" Then
            o.a6 = "1km"
        ElseIf tp = "a7" Then
            o.a7 = "1km"
        ElseIf tp = "b1" Then
            o.b1 = "1km"
        ElseIf tp = "b2" Then
            o.b2 = "1km"
        ElseIf tp = "b3" Then
            o.b3 = "1km"
        ElseIf tp = "b4" Then
            o.b4 = "1km"
        ElseIf tp = "b5" Then
            o.b5 = "1km"
        ElseIf tp = "b6" Then
            o.b6 = "1km"
        ElseIf tp = "b7" Then
            o.b7 = "1km"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1ks_Click(sender As Object, e As EventArgs) Handles K1ks.Click
        IB()
        ks1 = ks1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1ks"
        ElseIf tp = "1b" Then
            o.f1b = "1ks"
        ElseIf tp = "1c" Then
            o.f1c = "1ks"
        ElseIf tp = "2a" Then
            o.f2a = "1ks"
        ElseIf tp = "2b" Then
            o.f2b = "1ks"
        ElseIf tp = "2c" Then
            o.f2c = "1ks"
        ElseIf tp = "3a" Then
            o.f3a = "1ks"
        ElseIf tp = "3b" Then
            o.f3b = "1ks"
        ElseIf tp = "3c" Then
            o.f3c = "1ks"
        ElseIf tp = "a1" Then
            o.a1 = "1ks"
        ElseIf tp = "a2" Then
            o.a2 = "1ks"
        ElseIf tp = "a3" Then
            o.a3 = "1ks"
        ElseIf tp = "a4" Then
            o.a4 = "1ks"
        ElseIf tp = "a5" Then
            o.a5 = "1ks"
        ElseIf tp = "a6" Then
            o.a6 = "1ks"
        ElseIf tp = "a7" Then
            o.a7 = "1ks"
        ElseIf tp = "b1" Then
            o.b1 = "1ks"
        ElseIf tp = "b2" Then
            o.b2 = "1ks"
        ElseIf tp = "b3" Then
            o.b3 = "1ks"
        ElseIf tp = "b4" Then
            o.b4 = "1ks"
        ElseIf tp = "b5" Then
            o.b5 = "1ks"
        ElseIf tp = "b6" Then
            o.b6 = "1ks"
        ElseIf tp = "b7" Then
            o.b7 = "1ks"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1k_Click(sender As Object, e As EventArgs) Handles K1k.Click
        IB()
        k1 = k1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1k"
        ElseIf tp = "1b" Then
            o.f1b = "1k"
        ElseIf tp = "1c" Then
            o.f1c = "1k"
        ElseIf tp = "2a" Then
            o.f2a = "1k"
        ElseIf tp = "2b" Then
            o.f2b = "1k"
        ElseIf tp = "2c" Then
            o.f2c = "1k"
        ElseIf tp = "3a" Then
            o.f3a = "1k"
        ElseIf tp = "3b" Then
            o.f3b = "1k"
        ElseIf tp = "3c" Then
            o.f3c = "1k"
        ElseIf tp = "a1" Then
            o.a1 = "1k"
        ElseIf tp = "a2" Then
            o.a2 = "1k"
        ElseIf tp = "a3" Then
            o.a3 = "1k"
        ElseIf tp = "a4" Then
            o.a4 = "1k"
        ElseIf tp = "a5" Then
            o.a5 = "1k"
        ElseIf tp = "a6" Then
            o.a6 = "1k"
        ElseIf tp = "a7" Then
            o.a7 = "1k"
        ElseIf tp = "b1" Then
            o.b1 = "1k"
        ElseIf tp = "b2" Then
            o.b2 = "1k"
        ElseIf tp = "b3" Then
            o.b3 = "1k"
        ElseIf tp = "b4" Then
            o.b4 = "1k"
        ElseIf tp = "b5" Then
            o.b5 = "1k"
        ElseIf tp = "b6" Then
            o.b6 = "1k"
        ElseIf tp = "b7" Then
            o.b7 = "1k"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K1o_Click(sender As Object, e As EventArgs) Handles K1o.Click
        IB()
        o1 = o1 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "1o"
        ElseIf tp = "1b" Then
            o.f1b = "1o"
        ElseIf tp = "1c" Then
            o.f1c = "1o"
        ElseIf tp = "2a" Then
            o.f2a = "1o"
        ElseIf tp = "2b" Then
            o.f2b = "1o"
        ElseIf tp = "2c" Then
            o.f2c = "1o"
        ElseIf tp = "3a" Then
            o.f3a = "1o"
        ElseIf tp = "3b" Then
            o.f3b = "1o"
        ElseIf tp = "3c" Then
            o.f3c = "1o"
        ElseIf tp = "a1" Then
            o.a1 = "1o"
        ElseIf tp = "a2" Then
            o.a2 = "1o"
        ElseIf tp = "a3" Then
            o.a3 = "1o"
        ElseIf tp = "a4" Then
            o.a4 = "1o"
        ElseIf tp = "a5" Then
            o.a5 = "1o"
        ElseIf tp = "a6" Then
            o.a6 = "1o"
        ElseIf tp = "a7" Then
            o.a7 = "1o"
        ElseIf tp = "b1" Then
            o.b1 = "1o"
        ElseIf tp = "b2" Then
            o.b2 = "1o"
        ElseIf tp = "b3" Then
            o.b3 = "1o"
        ElseIf tp = "b4" Then
            o.b4 = "1o"
        ElseIf tp = "b5" Then
            o.b5 = "1o"
        ElseIf tp = "b6" Then
            o.b6 = "1o"
        ElseIf tp = "b7" Then
            o.b7 = "1o"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2g_Click(sender As Object, e As EventArgs) Handles K2g.Click
        IB()
        g2 = g2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2g"
        ElseIf tp = "1b" Then
            o.f1b = "2g"
        ElseIf tp = "1c" Then
            o.f1c = "2g"
        ElseIf tp = "2a" Then
            o.f2a = "2g"
        ElseIf tp = "2b" Then
            o.f2b = "2g"
        ElseIf tp = "2c" Then
            o.f2c = "2g"
        ElseIf tp = "3a" Then
            o.f3a = "2g"
        ElseIf tp = "3b" Then
            o.f3b = "2g"
        ElseIf tp = "3c" Then
            o.f3c = "2g"
        ElseIf tp = "a1" Then
            o.a1 = "2g"
        ElseIf tp = "a2" Then
            o.a2 = "2g"
        ElseIf tp = "a3" Then
            o.a3 = "2g"
        ElseIf tp = "a4" Then
            o.a4 = "2g"
        ElseIf tp = "a5" Then
            o.a5 = "2g"
        ElseIf tp = "a6" Then
            o.a6 = "2g"
        ElseIf tp = "a7" Then
            o.a7 = "2g"
        ElseIf tp = "b1" Then
            o.b1 = "2g"
        ElseIf tp = "b2" Then
            o.b2 = "2g"
        ElseIf tp = "b3" Then
            o.b3 = "2g"
        ElseIf tp = "b4" Then
            o.b4 = "2g"
        ElseIf tp = "b5" Then
            o.b5 = "2g"
        ElseIf tp = "b6" Then
            o.b6 = "2g"
        ElseIf tp = "b7" Then
            o.b7 = "2g"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2hh_Click(sender As Object, e As EventArgs) Handles K2hh.Click
        IB()
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2hh"
        ElseIf tp = "1b" Then
            o.f1b = "2hh"
        ElseIf tp = "1c" Then
            o.f1c = "2hh"
        ElseIf tp = "2a" Then
            o.f2a = "2hh"
        ElseIf tp = "2b" Then
            o.f2b = "2hh"
        ElseIf tp = "2c" Then
            o.f2c = "2hh"
        ElseIf tp = "3a" Then
            o.f3a = "2hh"
        ElseIf tp = "3b" Then
            o.f3b = "2hh"
        ElseIf tp = "3c" Then
            o.f3c = "2hh"
        ElseIf tp = "a1" Then
            o.a1 = "2hh"
        ElseIf tp = "a2" Then
            o.a2 = "2hh"
        ElseIf tp = "a3" Then
            o.a3 = "2hh"
        ElseIf tp = "a4" Then
            o.a4 = "2hh"
        ElseIf tp = "a5" Then
            o.a5 = "2hh"
        ElseIf tp = "a6" Then
            o.a6 = "2hh"
        ElseIf tp = "a7" Then
            o.a7 = "2hh"
        ElseIf tp = "b1" Then
            o.b1 = "2hh"
        ElseIf tp = "b2" Then
            o.b2 = "2hh"
        ElseIf tp = "b3" Then
            o.b3 = "2hh"
        ElseIf tp = "b4" Then
            o.b4 = "2hh"
        ElseIf tp = "b5" Then
            o.b5 = "2hh"
        ElseIf tp = "b6" Then
            o.b6 = "2hh"
        ElseIf tp = "b7" Then
            o.b7 = "2hh"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2hs_Click(sender As Object, e As EventArgs) Handles K2hs.Click
        IB()
        hs2 = hs2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2hs"
        ElseIf tp = "1b" Then
            o.f1b = "2hs"
        ElseIf tp = "1c" Then
            o.f1c = "2hs"
        ElseIf tp = "2a" Then
            o.f2a = "2hs"
        ElseIf tp = "2b" Then
            o.f2b = "2hs"
        ElseIf tp = "2c" Then
            o.f2c = "2hs"
        ElseIf tp = "3a" Then
            o.f3a = "2hs"
        ElseIf tp = "3b" Then
            o.f3b = "2hs"
        ElseIf tp = "3c" Then
            o.f3c = "2hs"
        ElseIf tp = "a1" Then
            o.a1 = "2hs"
        ElseIf tp = "a2" Then
            o.a2 = "2hs"
        ElseIf tp = "a3" Then
            o.a3 = "2hs"
        ElseIf tp = "a4" Then
            o.a4 = "2hs"
        ElseIf tp = "a5" Then
            o.a5 = "2hs"
        ElseIf tp = "a6" Then
            o.a6 = "2hs"
        ElseIf tp = "a7" Then
            o.a7 = "2hs"
        ElseIf tp = "b1" Then
            o.b1 = "2hs"
        ElseIf tp = "b2" Then
            o.b2 = "2hs"
        ElseIf tp = "b3" Then
            o.b3 = "2hs"
        ElseIf tp = "b4" Then
            o.b4 = "2hs"
        ElseIf tp = "b5" Then
            o.b5 = "2hs"
        ElseIf tp = "b6" Then
            o.b6 = "2hs"
        ElseIf tp = "b7" Then
            o.b7 = "2hs"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2kg_Click(sender As Object, e As EventArgs) Handles K2kg.Click
        IB()
        kg2 = kg2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2kg"
        ElseIf tp = "1b" Then
            o.f1b = "2kg"
        ElseIf tp = "1c" Then
            o.f1c = "2kg"
        ElseIf tp = "2a" Then
            o.f2a = "2kg"
        ElseIf tp = "2b" Then
            o.f2b = "2kg"
        ElseIf tp = "2c" Then
            o.f2c = "2kg"
        ElseIf tp = "3a" Then
            o.f3a = "2kg"
        ElseIf tp = "3b" Then
            o.f3b = "2kg"
        ElseIf tp = "3c" Then
            o.f3c = "2kg"
        ElseIf tp = "a1" Then
            o.a1 = "2kg"
        ElseIf tp = "a2" Then
            o.a2 = "2kg"
        ElseIf tp = "a3" Then
            o.a3 = "2kg"
        ElseIf tp = "a4" Then
            o.a4 = "2kg"
        ElseIf tp = "a5" Then
            o.a5 = "2kg"
        ElseIf tp = "a6" Then
            o.a6 = "2kg"
        ElseIf tp = "a7" Then
            o.a7 = "2kg"
        ElseIf tp = "b1" Then
            o.b1 = "2kg"
        ElseIf tp = "b2" Then
            o.b2 = "2kg"
        ElseIf tp = "b3" Then
            o.b3 = "2kg"
        ElseIf tp = "b4" Then
            o.b4 = "2kg"
        ElseIf tp = "b5" Then
            o.b5 = "2kg"
        ElseIf tp = "b6" Then
            o.b6 = "2kg"
        ElseIf tp = "b7" Then
            o.b7 = "2kg"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2km_Click(sender As Object, e As EventArgs) Handles K2km.Click
        IB()
        km2 = km2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2km"
        ElseIf tp = "1b" Then
            o.f1b = "2km"
        ElseIf tp = "1c" Then
            o.f1c = "2km"
        ElseIf tp = "2a" Then
            o.f2a = "2km"
        ElseIf tp = "2b" Then
            o.f2b = "2km"
        ElseIf tp = "2c" Then
            o.f2c = "2km"
        ElseIf tp = "3a" Then
            o.f3a = "2km"
        ElseIf tp = "3b" Then
            o.f3b = "2km"
        ElseIf tp = "3c" Then
            o.f3c = "2km"
        ElseIf tp = "a1" Then
            o.a1 = "2km"
        ElseIf tp = "a2" Then
            o.a2 = "2km"
        ElseIf tp = "a3" Then
            o.a3 = "2km"
        ElseIf tp = "a4" Then
            o.a4 = "2km"
        ElseIf tp = "a5" Then
            o.a5 = "2km"
        ElseIf tp = "a6" Then
            o.a6 = "2km"
        ElseIf tp = "a7" Then
            o.a7 = "2km"
        ElseIf tp = "b1" Then
            o.b1 = "2km"
        ElseIf tp = "b2" Then
            o.b2 = "2km"
        ElseIf tp = "b3" Then
            o.b3 = "2km"
        ElseIf tp = "b4" Then
            o.b4 = "2km"
        ElseIf tp = "b5" Then
            o.b5 = "2km"
        ElseIf tp = "b6" Then
            o.b6 = "2km"
        ElseIf tp = "b7" Then
            o.b7 = "2km"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2ks_Click(sender As Object, e As EventArgs) Handles K2ks.Click
        IB()
        ks2 = ks2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2ks"
        ElseIf tp = "1b" Then
            o.f1b = "2ks"
        ElseIf tp = "1c" Then
            o.f1c = "2ks"
        ElseIf tp = "2a" Then
            o.f2a = "2ks"
        ElseIf tp = "2b" Then
            o.f2b = "2ks"
        ElseIf tp = "2c" Then
            o.f2c = "2ks"
        ElseIf tp = "3a" Then
            o.f3a = "2ks"
        ElseIf tp = "3b" Then
            o.f3b = "2ks"
        ElseIf tp = "3c" Then
            o.f3c = "2ks"
        ElseIf tp = "a1" Then
            o.a1 = "2ks"
        ElseIf tp = "a2" Then
            o.a2 = "2ks"
        ElseIf tp = "a3" Then
            o.a3 = "2ks"
        ElseIf tp = "a4" Then
            o.a4 = "2ks"
        ElseIf tp = "a5" Then
            o.a5 = "2ks"
        ElseIf tp = "a6" Then
            o.a6 = "2ks"
        ElseIf tp = "a7" Then
            o.a7 = "2ks"
        ElseIf tp = "b1" Then
            o.b1 = "2ks"
        ElseIf tp = "b2" Then
            o.b2 = "2ks"
        ElseIf tp = "b3" Then
            o.b3 = "2ks"
        ElseIf tp = "b4" Then
            o.b4 = "2ks"
        ElseIf tp = "b5" Then
            o.b5 = "2ks"
        ElseIf tp = "b6" Then
            o.b6 = "2ks"
        ElseIf tp = "b7" Then
            o.b7 = "2ks"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2k_Click(sender As Object, e As EventArgs) Handles K2k.Click
        IB()
        k2 = k2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2k"
        ElseIf tp = "1b" Then
            o.f1b = "2k"
        ElseIf tp = "1c" Then
            o.f1c = "2k"
        ElseIf tp = "2a" Then
            o.f2a = "2k"
        ElseIf tp = "2b" Then
            o.f2b = "2k"
        ElseIf tp = "2c" Then
            o.f2c = "2k"
        ElseIf tp = "3a" Then
            o.f3a = "2k"
        ElseIf tp = "3b" Then
            o.f3b = "2k"
        ElseIf tp = "3c" Then
            o.f3c = "2k"
        ElseIf tp = "a1" Then
            o.a1 = "2k"
        ElseIf tp = "a2" Then
            o.a2 = "2k"
        ElseIf tp = "a3" Then
            o.a3 = "2k"
        ElseIf tp = "a4" Then
            o.a4 = "2k"
        ElseIf tp = "a5" Then
            o.a5 = "2k"
        ElseIf tp = "a6" Then
            o.a6 = "2k"
        ElseIf tp = "a7" Then
            o.a7 = "2k"
        ElseIf tp = "b1" Then
            o.b1 = "2k"
        ElseIf tp = "b2" Then
            o.b2 = "2k"
        ElseIf tp = "b3" Then
            o.b3 = "2k"
        ElseIf tp = "b4" Then
            o.b4 = "2k"
        ElseIf tp = "b5" Then
            o.b5 = "2k"
        ElseIf tp = "b6" Then
            o.b6 = "2k"
        ElseIf tp = "b7" Then
            o.b7 = "2k"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub K2o_Click(sender As Object, e As EventArgs) Handles K2o.Click
        IB()
        o2 = o2 + 1
        a = a + 1
        If tp = "1a" Then
            o.f1a = "2o"
        ElseIf tp = "1b" Then
            o.f1b = "2o"
        ElseIf tp = "1c" Then
            o.f1c = "2o"
        ElseIf tp = "2a" Then
            o.f2a = "2o"
        ElseIf tp = "2b" Then
            o.f2b = "2o"
        ElseIf tp = "2c" Then
            o.f2c = "2o"
        ElseIf tp = "3a" Then
            o.f3a = "2o"
        ElseIf tp = "3b" Then
            o.f3b = "2o"
        ElseIf tp = "3c" Then
            o.f3c = "2o"
        ElseIf tp = "a1" Then
            o.a1 = "2o"
        ElseIf tp = "a2" Then
            o.a2 = "2o"
        ElseIf tp = "a3" Then
            o.a3 = "2o"
        ElseIf tp = "a4" Then
            o.a4 = "2o"
        ElseIf tp = "a5" Then
            o.a5 = "2o"
        ElseIf tp = "a6" Then
            o.a6 = "2o"
        ElseIf tp = "a7" Then
            o.a7 = "2o"
        ElseIf tp = "b1" Then
            o.b1 = "2o"
        ElseIf tp = "b2" Then
            o.b2 = "2o"
        ElseIf tp = "b3" Then
            o.b3 = "2o"
        ElseIf tp = "b4" Then
            o.b4 = "2o"
        ElseIf tp = "b5" Then
            o.b5 = "2o"
        ElseIf tp = "b6" Then
            o.b6 = "2o"
        ElseIf tp = "b7" Then
            o.b7 = "2o"
        End If
        TC()
        IA()
        GC()
    End Sub

    Private Sub BN_Click(sender As Object, e As EventArgs) Handles BN.Click
        IB()
        If tp = "1a" Then
            o.f1a = ""
        ElseIf tp = "1b" Then
            o.f1b = ""
        ElseIf tp = "1c" Then
            o.f1c = ""
        ElseIf tp = "2a" Then
            o.f2a = ""
        ElseIf tp = "2b" Then
            o.f2b = ""
        ElseIf tp = "2c" Then
            o.f2c = ""
        ElseIf tp = "3a" Then
            o.f3a = ""
        ElseIf tp = "3b" Then
            o.f3b = ""
        ElseIf tp = "3c" Then
            o.f3c = ""
        ElseIf tp = "a1" Then
            o.a1 = ""
        ElseIf tp = "a2" Then
            o.a2 = ""
        ElseIf tp = "a3" Then
            o.a3 = ""
        ElseIf tp = "a4" Then
            o.a4 = ""
        ElseIf tp = "a5" Then
            o.a5 = ""
        ElseIf tp = "a6" Then
            o.a6 = ""
        ElseIf tp = "a7" Then
            o.a7 = ""
        ElseIf tp = "b1" Then
            o.b1 = ""
        ElseIf tp = "b2" Then
            o.b2 = ""
        ElseIf tp = "b3" Then
            o.b3 = ""
        ElseIf tp = "b4" Then
            o.b4 = ""
        ElseIf tp = "b5" Then
            o.b5 = ""
        ElseIf tp = "b6" Then
            o.b6 = ""
        ElseIf tp = "b7" Then
            o.b7 = ""
        End If
        TC()
        IA()
        GC()
    End Sub

    Public Sub Game_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If o.ss = 0 Then
            e.Cancel = True
        End If
    End Sub

    Sub IB() 'If Before
        If tp = "1a" Then
            If o.f1a = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f1a = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f1a = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f1a = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f1a = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f1a = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f1a = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f1a = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f1a = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f1a = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f1a = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f1a = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f1a = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f1a = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "1b" Then
            If o.f1b = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f1b = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f1b = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f1b = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f1b = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f1b = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f1b = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f1b = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f1b = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f1b = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f1b = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f1b = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f1b = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f1b = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "1c" Then
            If o.f1c = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f1c = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f1c = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f1c = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f1c = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f1c = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f1c = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f1c = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f1c = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f1c = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f1c = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f1c = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f1c = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f1c = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "2a" Then
            If o.f2a = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f2a = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f2a = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f2a = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f2a = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f2a = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f2a = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f2a = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f2a = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f2a = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f2a = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f2a = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f2a = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f2a = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "2b" Then
            If o.f2b = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f2b = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f2b = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f2b = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f2b = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f2b = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f2b = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f2b = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f2b = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f2b = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f2b = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f2b = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f2b = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f2b = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "2c" Then
            If o.f2c = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f2c = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f2c = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f2c = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f2c = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f2c = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f2c = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f2c = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f2c = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f2c = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f2c = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f2c = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f2c = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f2c = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "3a" Then
            If o.f3a = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f3a = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f3a = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f3a = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f3a = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f3a = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f3a = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f3a = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f3a = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f3a = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f3a = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f3a = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f3a = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f3a = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "3b" Then
            If o.f3b = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f3b = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f3b = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f3b = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f3b = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f3b = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f3b = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f3b = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f3b = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f3b = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f3b = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f3b = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f3b = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f3b = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "3c" Then
            If o.f3c = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.f3c = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.f3c = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.f3c = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.f3c = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.f3c = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.f3c = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.f3c = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.f3c = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.f3c = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.f3c = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.f3c = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.f3c = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.f3c = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a1" Then
            If o.a1 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a1 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a1 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a1 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a1 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a1 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a1 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a1 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a1 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a1 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a1 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a1 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a1 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a1 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a2" Then
            If o.a2 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a2 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a2 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a2 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a2 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a2 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a2 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a2 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a2 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a2 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a2 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a2 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a2 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a2 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a3" Then
            If o.a3 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a3 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a3 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a3 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a3 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a3 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a3 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a3 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a3 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a3 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a3 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a3 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a3 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a3 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a4" Then
            If o.a4 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a4 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a4 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a4 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a4 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a4 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a4 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a4 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a4 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a4 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a4 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a4 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a4 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a4 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a5" Then
            If o.a5 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a5 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a5 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a5 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a5 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a5 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a5 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a5 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a5 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a5 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a5 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a5 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a5 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a5 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a6" Then
            If o.a6 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a6 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a6 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a6 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a6 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a6 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a6 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a6 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a6 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a6 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a6 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a6 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a6 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a6 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "a7" Then
            If o.a7 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.a7 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.a7 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.a7 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.a7 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.a7 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.a7 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.a7 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.a7 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.a7 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.a7 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.a7 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.a7 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.a7 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b1" Then
            If o.b1 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b1 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b1 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b1 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b1 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b1 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b1 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b1 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b1 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b1 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b1 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b1 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b1 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b1 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b2" Then
            If o.b2 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b2 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b2 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b2 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b2 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b2 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b2 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b2 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b2 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b2 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b2 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b2 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b2 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b2 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b3" Then
            If o.b3 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b3 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b3 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b3 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b3 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b3 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b3 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b3 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b3 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b3 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b3 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b3 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b3 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b3 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b4" Then
            If o.b4 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b4 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b4 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b4 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b4 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b4 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b4 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b4 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b4 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b4 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b4 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b4 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b4 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b4 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b5" Then
            If o.b5 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b5 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b5 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b5 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b5 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b5 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b5 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b5 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b5 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b5 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b5 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b5 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b5 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b5 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b6" Then
            If o.b6 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b6 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b6 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b6 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b6 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b6 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b6 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b6 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b6 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b6 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b6 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b6 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b6 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b6 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        ElseIf tp = "b7" Then
            If o.b7 = "1g" Then
                a = a - 1
                g1 = g1 - 1
            ElseIf o.b7 = "1hs" Then
                a = a - 1
                hs1 = hs1 - 1
            ElseIf o.b7 = "1kg" Then
                a = a - 1
                kg1 = kg1 - 1
            ElseIf o.b7 = "1km" Then
                a = a - 1
                km1 = km1 - 1
            ElseIf o.b7 = "1ks" Then
                a = a - 1
                ks1 = ks1 = -1
            ElseIf o.b7 = "1k" Then
                a = a - 1
                k1 = k1 = -1
            ElseIf o.b7 = "1o" Then
                a = a - 1
                o1 = o1 - 1
            ElseIf o.b7 = "2g" Then
                a = a - 1
                g2 = g2 - 1
            ElseIf o.b7 = "2hs" Then
                a = a - 1
                hs2 = hs2 - 1
            ElseIf o.b7 = "2kg" Then
                a = a - 1
                kg2 = kg2 - 1
            ElseIf o.b7 = "2km" Then
                a = a - 1
                km2 = km2 - 1
            ElseIf o.b7 = "2ks" Then
                a = a - 1
                ks2 = ks2 = -1
            ElseIf o.b7 = "2k" Then
                a = a - 1
                k2 = k2 = -1
            ElseIf o.b7 = "2o" Then
                a = a - 1
                o2 = o2 - 1
            End If
        End If
    End Sub

    Sub IA() 'If After
        If g1 = 2 Then
            K1g.Hide()
        End If
        If hs1 = 2 Then
            K1hs.Hide()
        End If
        If kg1 = 2 Then
            K1kg.Hide()
        End If
        If km1 = 2 Then
            K1km.Hide()
        End If
        If ks1 = 2 Then
            K1ks.Hide()
        End If
        If k1 = 2 Then
            K1k.Hide()
        End If
        If o1 = 1 Then
            K1o.Hide()
        End If
        If g2 = 2 Then
            K2g.Hide()
        End If
        If hs2 = 2 Then
            K2hs.Hide()
        End If
        If kg2 = 2 Then
            K2kg.Hide()
        End If
        If km2 = 2 Then
            K2km.Hide()
        End If
        If ks2 = 2 Then
            K2ks.Hide()
        End If
        If k2 = 2 Then
            K2k.Hide()
        End If
        If o2 = 1 Then
            K2o.Hide()
        End If
        If a = 9 Then
            If tp = "1a" And o.f1a = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "1b" And o.f1b = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "1c" And o.f1c = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "2a" And o.f2a = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "2b" And o.f2b = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "2c" And o.f2c = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "3a" And o.f3a = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "3b" And o.f3b = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "3c" And o.f3c = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a1" And o.a1 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a2" And o.a2 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a3" And o.a3 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a4" And o.a4 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a5" And o.a5 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a6" And o.a6 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "a7" And o.a7 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b1" And o.b1 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b2" And o.b2 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b3" And o.b3 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b4" And o.b4 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b5" And o.b5 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b6" And o.b6 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
            If tp = "b7" And o.b7 = "" Then
                K1g.Hide()
                K1hh.Hide()
                K1hs.Hide()
                K1kg.Hide()
                K1km.Hide()
                K1ks.Hide()
                K1k.Hide()
                K1o.Hide()
                K2g.Hide()
                K2hh.Hide()
                K2hs.Hide()
                K2kg.Hide()
                K2km.Hide()
                K2ks.Hide()
                K2k.Hide()
                K2o.Hide()
            End If
        End If
    End Sub

    Sub GC()
        'Set1
        If o.a1 = "" Then
            o.a1 = o.a2
            o.a2 = o.a3
            o.a3 = o.a4
            o.a4 = o.a5
            o.a5 = o.a6
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a2 = "" Then
            o.a2 = o.a3
            o.a3 = o.a4
            o.a4 = o.a5
            o.a5 = o.a6
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a3 = "" Then
            o.a3 = o.a4
            o.a4 = o.a5
            o.a5 = o.a6
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a4 = "" Then
            o.a4 = o.a5
            o.a5 = o.a6
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a5 = "" Then
            o.a5 = o.a6
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a6 = "" Then
            o.a6 = o.a7
            o.a7 = ""
        ElseIf o.a7 = "" Then
            o.a7 = ""
        End If
        If o.b1 = "" Then
            o.b1 = o.b2
            o.b2 = o.b3
            o.b3 = o.b4
            o.b4 = o.b5
            o.b5 = o.b6
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b2 = "" Then
            o.b2 = o.b3
            o.b3 = o.b4
            o.b4 = o.b5
            o.b5 = o.b6
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b3 = "" Then
            o.b3 = o.b4
            o.b4 = o.b5
            o.b5 = o.b6
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b4 = "" Then
            o.b4 = o.b5
            o.b5 = o.b6
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b5 = "" Then
            o.b5 = o.b6
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b6 = "" Then
            o.b6 = o.b7
            o.b7 = ""
        ElseIf o.b7 = "" Then
            o.b7 = ""
        End If
        'In
        If o.f1a = "" Then
            o.PB1A.Image = Nothing
        ElseIf o.f1a = "1g" Then
            o.PB1A.Image = My.Resources._1g
        ElseIf o.f1a = "1hh" Then
            o.PB1A.Image = My.Resources._1hh
        ElseIf o.f1a = "1hs" Then
            o.PB1A.Image = My.Resources._1hs
        ElseIf o.f1a = "1k" Then
            o.PB1A.Image = My.Resources._1k
        ElseIf o.f1a = "1kg" Then
            o.PB1A.Image = My.Resources._1kg
        ElseIf o.f1a = "1km" Then
            o.PB1A.Image = My.Resources._1km
        ElseIf o.f1a = "1ks" Then
            o.PB1A.Image = My.Resources._1ks
        ElseIf o.f1a = "1ng" Then
            o.PB1A.Image = My.Resources._1ng
        ElseIf o.f1a = "1nk" Then
            o.PB1A.Image = My.Resources._1nk
        ElseIf o.f1a = "1nky" Then
            o.PB1A.Image = My.Resources._1nky
        ElseIf o.f1a = "1o" Then
            o.PB1A.Image = My.Resources._1o
        ElseIf o.f1a = "1rm" Then
            o.PB1A.Image = My.Resources._1rm
        ElseIf o.f1a = "1ro" Then
            o.PB1A.Image = My.Resources._1ro
        ElseIf o.f1a = "1tk" Then
            o.PB1A.Image = My.Resources._1tk
        ElseIf o.f1a = "2g" Then
            o.PB1A.Image = My.Resources._2g
        ElseIf o.f1a = "2hh" Then
            o.PB1A.Image = My.Resources._2hh
        ElseIf o.f1a = "2hs" Then
            o.PB1A.Image = My.Resources._2hs
        ElseIf o.f1a = "2k" Then
            o.PB1A.Image = My.Resources._2k
        ElseIf o.f1a = "2kg" Then
            o.PB1A.Image = My.Resources._2kg
        ElseIf o.f1a = "2km" Then
            o.PB1A.Image = My.Resources._2km
        ElseIf o.f1a = "2ks" Then
            o.PB1A.Image = My.Resources._2ks
        ElseIf o.f1a = "2ng" Then
            o.PB1A.Image = My.Resources._2ng
        ElseIf o.f1a = "2nk" Then
            o.PB1A.Image = My.Resources._2nk
        ElseIf o.f1a = "2nky" Then
            o.PB1A.Image = My.Resources._2nky
        ElseIf o.f1a = "2o" Then
            o.PB1A.Image = My.Resources._2o
        ElseIf o.f1a = "2rm" Then
            o.PB1A.Image = My.Resources._2rm
        ElseIf o.f1a = "2ro" Then
            o.PB1A.Image = My.Resources._2ro
        ElseIf o.f1a = "2tk" Then
            o.PB1A.Image = My.Resources._2tk
        End If
        If o.f1b = "" Then
            o.PB1B.Image = Nothing
        ElseIf o.f1b = "1g" Then
            o.PB1B.Image = My.Resources._1g
        ElseIf o.f1b = "1hh" Then
            o.PB1B.Image = My.Resources._1hh
        ElseIf o.f1b = "1hs" Then
            o.PB1B.Image = My.Resources._1hs
        ElseIf o.f1b = "1k" Then
            o.PB1B.Image = My.Resources._1k
        ElseIf o.f1b = "1kg" Then
            o.PB1B.Image = My.Resources._1kg
        ElseIf o.f1b = "1km" Then
            o.PB1B.Image = My.Resources._1km
        ElseIf o.f1b = "1ks" Then
            o.PB1B.Image = My.Resources._1ks
        ElseIf o.f1b = "1ng" Then
            o.PB1B.Image = My.Resources._1ng
        ElseIf o.f1b = "1nk" Then
            o.PB1B.Image = My.Resources._1nk
        ElseIf o.f1b = "1nky" Then
            o.PB1B.Image = My.Resources._1nky
        ElseIf o.f1b = "1o" Then
            o.PB1B.Image = My.Resources._1o
        ElseIf o.f1b = "1rm" Then
            o.PB1B.Image = My.Resources._1rm
        ElseIf o.f1b = "1ro" Then
            o.PB1B.Image = My.Resources._1ro
        ElseIf o.f1b = "1tk" Then
            o.PB1B.Image = My.Resources._1tk
        ElseIf o.f1b = "2g" Then
            o.PB1B.Image = My.Resources._2g
        ElseIf o.f1b = "2hh" Then
            o.PB1B.Image = My.Resources._2hh
        ElseIf o.f1b = "2hs" Then
            o.PB1B.Image = My.Resources._2hs
        ElseIf o.f1b = "2k" Then
            o.PB1B.Image = My.Resources._2k
        ElseIf o.f1b = "2kg" Then
            o.PB1B.Image = My.Resources._2kg
        ElseIf o.f1b = "2km" Then
            o.PB1B.Image = My.Resources._2km
        ElseIf o.f1b = "2ks" Then
            o.PB1B.Image = My.Resources._2ks
        ElseIf o.f1b = "2ng" Then
            o.PB1B.Image = My.Resources._2ng
        ElseIf o.f1b = "2nk" Then
            o.PB1B.Image = My.Resources._2nk
        ElseIf o.f1b = "2nky" Then
            o.PB1B.Image = My.Resources._2nky
        ElseIf o.f1b = "2o" Then
            o.PB1B.Image = My.Resources._2o
        ElseIf o.f1b = "2rm" Then
            o.PB1B.Image = My.Resources._2rm
        ElseIf o.f1b = "2ro" Then
            o.PB1B.Image = My.Resources._2ro
        ElseIf o.f1b = "2tk" Then
            o.PB1B.Image = My.Resources._2tk
        End If
        If o.f1c = "" Then
            o.PB1C.Image = Nothing
        ElseIf o.f1c = "1g" Then
            o.PB1C.Image = My.Resources._1g
        ElseIf o.f1c = "1hh" Then
            o.PB1C.Image = My.Resources._1hh
        ElseIf o.f1c = "1hs" Then
            o.PB1C.Image = My.Resources._1hs
        ElseIf o.f1c = "1k" Then
            o.PB1C.Image = My.Resources._1k
        ElseIf o.f1c = "1kg" Then
            o.PB1C.Image = My.Resources._1kg
        ElseIf o.f1c = "1km" Then
            o.PB1C.Image = My.Resources._1km
        ElseIf o.f1c = "1ks" Then
            o.PB1C.Image = My.Resources._1ks
        ElseIf o.f1c = "1ng" Then
            o.PB1C.Image = My.Resources._1ng
        ElseIf o.f1c = "1nk" Then
            o.PB1C.Image = My.Resources._1nk
        ElseIf o.f1c = "1nky" Then
            o.PB1C.Image = My.Resources._1nky
        ElseIf o.f1c = "1o" Then
            o.PB1C.Image = My.Resources._1o
        ElseIf o.f1c = "1rm" Then
            o.PB1C.Image = My.Resources._1rm
        ElseIf o.f1c = "1ro" Then
            o.PB1C.Image = My.Resources._1ro
        ElseIf o.f1c = "1tk" Then
            o.PB1C.Image = My.Resources._1tk
        ElseIf o.f1c = "2g" Then
            o.PB1C.Image = My.Resources._2g
        ElseIf o.f1c = "2hh" Then
            o.PB1C.Image = My.Resources._2hh
        ElseIf o.f1c = "2hs" Then
            o.PB1C.Image = My.Resources._2hs
        ElseIf o.f1c = "2k" Then
            o.PB1C.Image = My.Resources._2k
        ElseIf o.f1c = "2kg" Then
            o.PB1C.Image = My.Resources._2kg
        ElseIf o.f1c = "2km" Then
            o.PB1C.Image = My.Resources._2km
        ElseIf o.f1c = "2ks" Then
            o.PB1C.Image = My.Resources._2ks
        ElseIf o.f1c = "2ng" Then
            o.PB1C.Image = My.Resources._2ng
        ElseIf o.f1c = "2nk" Then
            o.PB1C.Image = My.Resources._2nk
        ElseIf o.f1c = "2nky" Then
            o.PB1C.Image = My.Resources._2nky
        ElseIf o.f1c = "2o" Then
            o.PB1C.Image = My.Resources._2o
        ElseIf o.f1c = "2rm" Then
            o.PB1C.Image = My.Resources._2rm
        ElseIf o.f1c = "2ro" Then
            o.PB1C.Image = My.Resources._2ro
        ElseIf o.f1c = "2tk" Then
            o.PB1C.Image = My.Resources._2tk
        End If
        If o.f2a = "" Then
            o.PB2A.Image = Nothing
        ElseIf o.f2a = "1g" Then
            o.PB2A.Image = My.Resources._1g
        ElseIf o.f2a = "1hh" Then
            o.PB2A.Image = My.Resources._1hh
        ElseIf o.f2a = "1hs" Then
            o.PB2A.Image = My.Resources._1hs
        ElseIf o.f2a = "1k" Then
            o.PB2A.Image = My.Resources._1k
        ElseIf o.f2a = "1kg" Then
            o.PB2A.Image = My.Resources._1kg
        ElseIf o.f2a = "1km" Then
            o.PB2A.Image = My.Resources._1km
        ElseIf o.f2a = "1ks" Then
            o.PB2A.Image = My.Resources._1ks
        ElseIf o.f2a = "1ng" Then
            o.PB2A.Image = My.Resources._1ng
        ElseIf o.f2a = "1nk" Then
            o.PB2A.Image = My.Resources._1nk
        ElseIf o.f2a = "1nky" Then
            o.PB2A.Image = My.Resources._1nky
        ElseIf o.f2a = "1o" Then
            o.PB2A.Image = My.Resources._1o
        ElseIf o.f2a = "1rm" Then
            o.PB2A.Image = My.Resources._1rm
        ElseIf o.f2a = "1ro" Then
            o.PB2A.Image = My.Resources._1ro
        ElseIf o.f2a = "1tk" Then
            o.PB2A.Image = My.Resources._1tk
        ElseIf o.f2a = "2g" Then
            o.PB2A.Image = My.Resources._2g
        ElseIf o.f2a = "2hh" Then
            o.PB2A.Image = My.Resources._2hh
        ElseIf o.f2a = "2hs" Then
            o.PB2A.Image = My.Resources._2hs
        ElseIf o.f2a = "2k" Then
            o.PB2A.Image = My.Resources._2k
        ElseIf o.f2a = "2kg" Then
            o.PB2A.Image = My.Resources._2kg
        ElseIf o.f2a = "2km" Then
            o.PB2A.Image = My.Resources._2km
        ElseIf o.f2a = "2ks" Then
            o.PB2A.Image = My.Resources._2ks
        ElseIf o.f2a = "2ng" Then
            o.PB2A.Image = My.Resources._2ng
        ElseIf o.f2a = "2nk" Then
            o.PB2A.Image = My.Resources._2nk
        ElseIf o.f2a = "2nky" Then
            o.PB2A.Image = My.Resources._2nky
        ElseIf o.f2a = "2o" Then
            o.PB2A.Image = My.Resources._2o
        ElseIf o.f2a = "2rm" Then
            o.PB2A.Image = My.Resources._2rm
        ElseIf o.f2a = "2ro" Then
            o.PB2A.Image = My.Resources._2ro
        ElseIf o.f2a = "2tk" Then
            o.PB2A.Image = My.Resources._2tk
        End If
        If o.f2b = "" Then
            o.PB2B.Image = Nothing
        ElseIf o.f2b = "1g" Then
            o.PB2B.Image = My.Resources._1g
        ElseIf o.f2b = "1hh" Then
            o.PB2B.Image = My.Resources._1hh
        ElseIf o.f2b = "1hs" Then
            o.PB2B.Image = My.Resources._1hs
        ElseIf o.f2b = "1k" Then
            o.PB2B.Image = My.Resources._1k
        ElseIf o.f2b = "1kg" Then
            o.PB2B.Image = My.Resources._1kg
        ElseIf o.f2b = "1km" Then
            o.PB2B.Image = My.Resources._1km
        ElseIf o.f2b = "1ks" Then
            o.PB2B.Image = My.Resources._1ks
        ElseIf o.f2b = "1ng" Then
            o.PB2B.Image = My.Resources._1ng
        ElseIf o.f2b = "1nk" Then
            o.PB2B.Image = My.Resources._1nk
        ElseIf o.f2b = "1nky" Then
            o.PB2B.Image = My.Resources._1nky
        ElseIf o.f2b = "1o" Then
            o.PB2B.Image = My.Resources._1o
        ElseIf o.f2b = "1rm" Then
            o.PB2B.Image = My.Resources._1rm
        ElseIf o.f2b = "1ro" Then
            o.PB2B.Image = My.Resources._1ro
        ElseIf o.f2b = "1tk" Then
            o.PB2B.Image = My.Resources._1tk
        ElseIf o.f2b = "2g" Then
            o.PB2B.Image = My.Resources._2g
        ElseIf o.f2b = "2hh" Then
            o.PB2B.Image = My.Resources._2hh
        ElseIf o.f2b = "2hs" Then
            o.PB2B.Image = My.Resources._2hs
        ElseIf o.f2b = "2k" Then
            o.PB2B.Image = My.Resources._2k
        ElseIf o.f2b = "2kg" Then
            o.PB2B.Image = My.Resources._2kg
        ElseIf o.f2b = "2km" Then
            o.PB2B.Image = My.Resources._2km
        ElseIf o.f2b = "2ks" Then
            o.PB2B.Image = My.Resources._2ks
        ElseIf o.f2b = "2ng" Then
            o.PB2B.Image = My.Resources._2ng
        ElseIf o.f2b = "2nk" Then
            o.PB2B.Image = My.Resources._2nk
        ElseIf o.f2b = "2nky" Then
            o.PB2B.Image = My.Resources._2nky
        ElseIf o.f2b = "2o" Then
            o.PB2B.Image = My.Resources._2o
        ElseIf o.f2b = "2rm" Then
            o.PB2B.Image = My.Resources._2rm
        ElseIf o.f2b = "2ro" Then
            o.PB2B.Image = My.Resources._2ro
        ElseIf o.f2b = "2tk" Then
            o.PB2B.Image = My.Resources._2tk
        End If
        If o.f2c = "" Then
            o.PB2C.Image = Nothing
        ElseIf o.f2c = "1g" Then
            o.PB2C.Image = My.Resources._1g
        ElseIf o.f2c = "1hh" Then
            o.PB2C.Image = My.Resources._1hh
        ElseIf o.f2c = "1hs" Then
            o.PB2C.Image = My.Resources._1hs
        ElseIf o.f2c = "1k" Then
            o.PB2C.Image = My.Resources._1k
        ElseIf o.f2c = "1kg" Then
            o.PB2C.Image = My.Resources._1kg
        ElseIf o.f2c = "1km" Then
            o.PB2C.Image = My.Resources._1km
        ElseIf o.f2c = "1ks" Then
            o.PB2C.Image = My.Resources._1ks
        ElseIf o.f2c = "1ng" Then
            o.PB2C.Image = My.Resources._1ng
        ElseIf o.f2c = "1nk" Then
            o.PB2C.Image = My.Resources._1nk
        ElseIf o.f2c = "1nky" Then
            o.PB2C.Image = My.Resources._1nky
        ElseIf o.f2c = "1o" Then
            o.PB2C.Image = My.Resources._1o
        ElseIf o.f2c = "1rm" Then
            o.PB2C.Image = My.Resources._1rm
        ElseIf o.f2c = "1ro" Then
            o.PB2C.Image = My.Resources._1ro
        ElseIf o.f2c = "1tk" Then
            o.PB2C.Image = My.Resources._1tk
        ElseIf o.f2c = "2g" Then
            o.PB2C.Image = My.Resources._2g
        ElseIf o.f2c = "2hh" Then
            o.PB2C.Image = My.Resources._2hh
        ElseIf o.f2c = "2hs" Then
            o.PB2C.Image = My.Resources._2hs
        ElseIf o.f2c = "2k" Then
            o.PB2C.Image = My.Resources._2k
        ElseIf o.f2c = "2kg" Then
            o.PB2C.Image = My.Resources._2kg
        ElseIf o.f2c = "2km" Then
            o.PB2C.Image = My.Resources._2km
        ElseIf o.f2c = "2ks" Then
            o.PB2C.Image = My.Resources._2ks
        ElseIf o.f2c = "2ng" Then
            o.PB2C.Image = My.Resources._2ng
        ElseIf o.f2c = "2nk" Then
            o.PB2C.Image = My.Resources._2nk
        ElseIf o.f2c = "2nky" Then
            o.PB2C.Image = My.Resources._2nky
        ElseIf o.f2c = "2o" Then
            o.PB2C.Image = My.Resources._2o
        ElseIf o.f2c = "2rm" Then
            o.PB2C.Image = My.Resources._2rm
        ElseIf o.f2c = "2ro" Then
            o.PB2C.Image = My.Resources._2ro
        ElseIf o.f2c = "2tk" Then
            o.PB2C.Image = My.Resources._2tk
        End If
        If o.f3a = "" Then
            o.PB3A.Image = Nothing
        ElseIf o.f3a = "1g" Then
            o.PB3A.Image = My.Resources._1g
        ElseIf o.f3a = "1hh" Then
            o.PB3A.Image = My.Resources._1hh
        ElseIf o.f3a = "1hs" Then
            o.PB3A.Image = My.Resources._1hs
        ElseIf o.f3a = "1k" Then
            o.PB3A.Image = My.Resources._1k
        ElseIf o.f3a = "1kg" Then
            o.PB3A.Image = My.Resources._1kg
        ElseIf o.f3a = "1km" Then
            o.PB3A.Image = My.Resources._1km
        ElseIf o.f3a = "1ks" Then
            o.PB3A.Image = My.Resources._1ks
        ElseIf o.f3a = "1ng" Then
            o.PB3A.Image = My.Resources._1ng
        ElseIf o.f3a = "1nk" Then
            o.PB3A.Image = My.Resources._1nk
        ElseIf o.f3a = "1nky" Then
            o.PB3A.Image = My.Resources._1nky
        ElseIf o.f3a = "1o" Then
            o.PB3A.Image = My.Resources._1o
        ElseIf o.f3a = "1rm" Then
            o.PB3A.Image = My.Resources._1rm
        ElseIf o.f3a = "1ro" Then
            o.PB3A.Image = My.Resources._1ro
        ElseIf o.f3a = "1tk" Then
            o.PB3A.Image = My.Resources._1tk
        ElseIf o.f3a = "2g" Then
            o.PB3A.Image = My.Resources._2g
        ElseIf o.f3a = "2hh" Then
            o.PB3A.Image = My.Resources._2hh
        ElseIf o.f3a = "2hs" Then
            o.PB3A.Image = My.Resources._2hs
        ElseIf o.f3a = "2k" Then
            o.PB3A.Image = My.Resources._2k
        ElseIf o.f3a = "2kg" Then
            o.PB3A.Image = My.Resources._2kg
        ElseIf o.f3a = "2km" Then
            o.PB3A.Image = My.Resources._2km
        ElseIf o.f3a = "2ks" Then
            o.PB3A.Image = My.Resources._2ks
        ElseIf o.f3a = "2ng" Then
            o.PB3A.Image = My.Resources._2ng
        ElseIf o.f3a = "2nk" Then
            o.PB3A.Image = My.Resources._2nk
        ElseIf o.f3a = "2nky" Then
            o.PB3A.Image = My.Resources._2nky
        ElseIf o.f3a = "2o" Then
            o.PB3A.Image = My.Resources._2o
        ElseIf o.f3a = "2rm" Then
            o.PB3A.Image = My.Resources._2rm
        ElseIf o.f3a = "2ro" Then
            o.PB3A.Image = My.Resources._2ro
        ElseIf o.f3a = "2tk" Then
            o.PB3A.Image = My.Resources._2tk
        End If
        If o.f3b = "" Then
            o.PB3B.Image = Nothing
        ElseIf o.f3b = "1g" Then
            o.PB3B.Image = My.Resources._1g
        ElseIf o.f3b = "1hh" Then
            o.PB3B.Image = My.Resources._1hh
        ElseIf o.f3b = "1hs" Then
            o.PB3B.Image = My.Resources._1hs
        ElseIf o.f3b = "1k" Then
            o.PB3B.Image = My.Resources._1k
        ElseIf o.f3b = "1kg" Then
            o.PB3B.Image = My.Resources._1kg
        ElseIf o.f3b = "1km" Then
            o.PB3B.Image = My.Resources._1km
        ElseIf o.f3b = "1ks" Then
            o.PB3B.Image = My.Resources._1ks
        ElseIf o.f3b = "1ng" Then
            o.PB3B.Image = My.Resources._1ng
        ElseIf o.f3b = "1nk" Then
            o.PB3B.Image = My.Resources._1nk
        ElseIf o.f3b = "1nky" Then
            o.PB3B.Image = My.Resources._1nky
        ElseIf o.f3b = "1o" Then
            o.PB3B.Image = My.Resources._1o
        ElseIf o.f3b = "1rm" Then
            o.PB3B.Image = My.Resources._1rm
        ElseIf o.f3b = "1ro" Then
            o.PB3B.Image = My.Resources._1ro
        ElseIf o.f3b = "1tk" Then
            o.PB3B.Image = My.Resources._1tk
        ElseIf o.f3b = "2g" Then
            o.PB3B.Image = My.Resources._2g
        ElseIf o.f3b = "2hh" Then
            o.PB3B.Image = My.Resources._2hh
        ElseIf o.f3b = "2hs" Then
            o.PB3B.Image = My.Resources._2hs
        ElseIf o.f3b = "2k" Then
            o.PB3B.Image = My.Resources._2k
        ElseIf o.f3b = "2kg" Then
            o.PB3B.Image = My.Resources._2kg
        ElseIf o.f3b = "2km" Then
            o.PB3B.Image = My.Resources._2km
        ElseIf o.f3b = "2ks" Then
            o.PB3B.Image = My.Resources._2ks
        ElseIf o.f3b = "2ng" Then
            o.PB3B.Image = My.Resources._2ng
        ElseIf o.f3b = "2nk" Then
            o.PB3B.Image = My.Resources._2nk
        ElseIf o.f3b = "2nky" Then
            o.PB3B.Image = My.Resources._2nky
        ElseIf o.f3b = "2o" Then
            o.PB3B.Image = My.Resources._2o
        ElseIf o.f3b = "2rm" Then
            o.PB3B.Image = My.Resources._2rm
        ElseIf o.f3b = "2ro" Then
            o.PB3B.Image = My.Resources._2ro
        ElseIf o.f3b = "2tk" Then
            o.PB3B.Image = My.Resources._2tk
        End If
        If o.f3c = "" Then
            o.PB3C.Image = Nothing
        ElseIf o.f3c = "1g" Then
            o.PB3C.Image = My.Resources._1g
        ElseIf o.f3c = "1hh" Then
            o.PB3C.Image = My.Resources._1hh
        ElseIf o.f3c = "1hs" Then
            o.PB3C.Image = My.Resources._1hs
        ElseIf o.f3c = "1k" Then
            o.PB3C.Image = My.Resources._1k
        ElseIf o.f3c = "1kg" Then
            o.PB3C.Image = My.Resources._1kg
        ElseIf o.f3c = "1km" Then
            o.PB3C.Image = My.Resources._1km
        ElseIf o.f3c = "1ks" Then
            o.PB3C.Image = My.Resources._1ks
        ElseIf o.f3c = "1ng" Then
            o.PB3C.Image = My.Resources._1ng
        ElseIf o.f3c = "1nk" Then
            o.PB3C.Image = My.Resources._1nk
        ElseIf o.f3c = "1nky" Then
            o.PB3C.Image = My.Resources._1nky
        ElseIf o.f3c = "1o" Then
            o.PB3C.Image = My.Resources._1o
        ElseIf o.f3c = "1rm" Then
            o.PB3C.Image = My.Resources._1rm
        ElseIf o.f3c = "1ro" Then
            o.PB3C.Image = My.Resources._1ro
        ElseIf o.f3c = "1tk" Then
            o.PB3C.Image = My.Resources._1tk
        ElseIf o.f3c = "2g" Then
            o.PB3C.Image = My.Resources._2g
        ElseIf o.f3c = "2hh" Then
            o.PB3C.Image = My.Resources._2hh
        ElseIf o.f3c = "2hs" Then
            o.PB3C.Image = My.Resources._2hs
        ElseIf o.f3c = "2k" Then
            o.PB3C.Image = My.Resources._2k
        ElseIf o.f3c = "2kg" Then
            o.PB3C.Image = My.Resources._2kg
        ElseIf o.f3c = "2km" Then
            o.PB3C.Image = My.Resources._2km
        ElseIf o.f3c = "2ks" Then
            o.PB3C.Image = My.Resources._2ks
        ElseIf o.f3c = "2ng" Then
            o.PB3C.Image = My.Resources._2ng
        ElseIf o.f3c = "2nk" Then
            o.PB3C.Image = My.Resources._2nk
        ElseIf o.f3c = "2nky" Then
            o.PB3C.Image = My.Resources._2nky
        ElseIf o.f3c = "2o" Then
            o.PB3C.Image = My.Resources._2o
        ElseIf o.f3c = "2rm" Then
            o.PB3C.Image = My.Resources._2rm
        ElseIf o.f3c = "2ro" Then
            o.PB3C.Image = My.Resources._2ro
        ElseIf o.f3c = "2tk" Then
            o.PB3C.Image = My.Resources._2tk
        End If
        'Out
        If o.a1 = "" Then
            o.P11.Text = ""
        ElseIf o.a1 = "1g" Then
            o.P11.Text = "銀将"
        ElseIf o.a1 = "1hh" Then
            o.P11.Text = "歩兵"
        ElseIf o.a1 = "1hs" Then
            o.P11.Text = "飛車"
        ElseIf o.a1 = "1k" Then
            o.P11.Text = "金将"
        ElseIf o.a1 = "1kg" Then
            o.P11.Text = "角行"
        ElseIf o.a1 = "1km" Then
            o.P11.Text = "桂馬"
        ElseIf o.a1 = "1ks" Then
            o.P11.Text = "香車"
        ElseIf o.a1 = "1ng" Then
            o.P11.Text = "成銀"
        ElseIf o.a1 = "1nk" Then
            o.P11.Text = "成桂"
        ElseIf o.a1 = "1nky" Then
            o.P11.Text = "成香"
        ElseIf o.a1 = "1o" Then
            o.P11.Text = "王将"
        ElseIf o.a1 = "1rm" Then
            o.P11.Text = "竜馬"
        ElseIf o.a1 = "1ro" Then
            o.P11.Text = "竜王"
        ElseIf o.a1 = "1tk" Then
            o.P11.Text = "と金"
        End If
        If o.a2 = "" Then
            o.P12.Text = ""
        ElseIf o.a2 = "1g" Then
            o.P12.Text = "銀将"
        ElseIf o.a2 = "1hh" Then
            o.P12.Text = "歩兵"
        ElseIf o.a2 = "1hs" Then
            o.P12.Text = "飛車"
        ElseIf o.a2 = "1k" Then
            o.P12.Text = "金将"
        ElseIf o.a2 = "1kg" Then
            o.P12.Text = "角行"
        ElseIf o.a2 = "1km" Then
            o.P12.Text = "桂馬"
        ElseIf o.a2 = "1ks" Then
            o.P12.Text = "香車"
        ElseIf o.a2 = "1ng" Then
            o.P12.Text = "成銀"
        ElseIf o.a2 = "1nk" Then
            o.P12.Text = "成桂"
        ElseIf o.a2 = "1nky" Then
            o.P12.Text = "成香"
        ElseIf o.a2 = "1o" Then
            o.P12.Text = "王将"
        ElseIf o.a2 = "1rm" Then
            o.P12.Text = "竜馬"
        ElseIf o.a2 = "1ro" Then
            o.P12.Text = "竜王"
        ElseIf o.a2 = "1tk" Then
            o.P12.Text = "と金"
        End If
        If o.a3 = "" Then
            o.P13.Text = ""
        ElseIf o.a3 = "1g" Then
            o.P13.Text = "銀将"
        ElseIf o.a3 = "1hh" Then
            o.P13.Text = "歩兵"
        ElseIf o.a3 = "1hs" Then
            o.P13.Text = "飛車"
        ElseIf o.a3 = "1k" Then
            o.P13.Text = "金将"
        ElseIf o.a3 = "1kg" Then
            o.P13.Text = "角行"
        ElseIf o.a3 = "1km" Then
            o.P13.Text = "桂馬"
        ElseIf o.a3 = "1ks" Then
            o.P13.Text = "香車"
        ElseIf o.a3 = "1ng" Then
            o.P13.Text = "成銀"
        ElseIf o.a3 = "1nk" Then
            o.P13.Text = "成桂"
        ElseIf o.a3 = "1nky" Then
            o.P13.Text = "成香"
        ElseIf o.a3 = "1o" Then
            o.P13.Text = "王将"
        ElseIf o.a3 = "1rm" Then
            o.P13.Text = "竜馬"
        ElseIf o.a3 = "1ro" Then
            o.P13.Text = "竜王"
        ElseIf o.a3 = "1tk" Then
            o.P13.Text = "と金"
        End If
        If o.a4 = "" Then
            o.P14.Text = ""
        ElseIf o.a4 = "1g" Then
            o.P14.Text = "銀将"
        ElseIf o.a4 = "1hh" Then
            o.P14.Text = "歩兵"
        ElseIf o.a4 = "1hs" Then
            o.P14.Text = "飛車"
        ElseIf o.a4 = "1k" Then
            o.P14.Text = "金将"
        ElseIf o.a4 = "1kg" Then
            o.P14.Text = "角行"
        ElseIf o.a4 = "1km" Then
            o.P14.Text = "桂馬"
        ElseIf o.a4 = "1ks" Then
            o.P14.Text = "香車"
        ElseIf o.a4 = "1ng" Then
            o.P14.Text = "成銀"
        ElseIf o.a4 = "1nk" Then
            o.P14.Text = "成桂"
        ElseIf o.a4 = "1nky" Then
            o.P14.Text = "成香"
        ElseIf o.a4 = "1o" Then
            o.P14.Text = "王将"
        ElseIf o.a4 = "1rm" Then
            o.P14.Text = "竜馬"
        ElseIf o.a4 = "1ro" Then
            o.P14.Text = "竜王"
        ElseIf o.a4 = "1tk" Then
            o.P14.Text = "と金"
        End If
        If o.a5 = "" Then
            o.P15.Text = ""
        ElseIf o.a5 = "1g" Then
            o.P15.Text = "銀将"
        ElseIf o.a5 = "1hh" Then
            o.P15.Text = "歩兵"
        ElseIf o.a5 = "1hs" Then
            o.P15.Text = "飛車"
        ElseIf o.a5 = "1k" Then
            o.P15.Text = "金将"
        ElseIf o.a5 = "1kg" Then
            o.P15.Text = "角行"
        ElseIf o.a5 = "1km" Then
            o.P15.Text = "桂馬"
        ElseIf o.a5 = "1ks" Then
            o.P15.Text = "香車"
        ElseIf o.a5 = "1ng" Then
            o.P15.Text = "成銀"
        ElseIf o.a5 = "1nk" Then
            o.P15.Text = "成桂"
        ElseIf o.a5 = "1nky" Then
            o.P15.Text = "成香"
        ElseIf o.a5 = "1o" Then
            o.P15.Text = "王将"
        ElseIf o.a5 = "1rm" Then
            o.P15.Text = "竜馬"
        ElseIf o.a5 = "1ro" Then
            o.P15.Text = "竜王"
        ElseIf o.a5 = "1tk" Then
            o.P15.Text = "と金"
        End If
        If o.a6 = "" Then
            o.P16.Text = ""
        ElseIf o.a6 = "1g" Then
            o.P16.Text = "銀将"
        ElseIf o.a6 = "1hh" Then
            o.P16.Text = "歩兵"
        ElseIf o.a6 = "1hs" Then
            o.P16.Text = "飛車"
        ElseIf o.a6 = "1k" Then
            o.P16.Text = "金将"
        ElseIf o.a6 = "1kg" Then
            o.P16.Text = "角行"
        ElseIf o.a6 = "1km" Then
            o.P16.Text = "桂馬"
        ElseIf o.a6 = "1ks" Then
            o.P16.Text = "香車"
        ElseIf o.a6 = "1ng" Then
            o.P16.Text = "成銀"
        ElseIf o.a6 = "1nk" Then
            o.P16.Text = "成桂"
        ElseIf o.a6 = "1nky" Then
            o.P16.Text = "成香"
        ElseIf o.a6 = "1o" Then
            o.P16.Text = "王将"
        ElseIf o.a6 = "1rm" Then
            o.P16.Text = "竜馬"
        ElseIf o.a6 = "1ro" Then
            o.P16.Text = "竜王"
        ElseIf o.a6 = "1tk" Then
            o.P16.Text = "と金"
        End If
        If o.a7 = "" Then
            o.P17.Text = ""
        ElseIf o.a7 = "1g" Then
            o.P17.Text = "銀将"
        ElseIf o.a7 = "1hh" Then
            o.P17.Text = "歩兵"
        ElseIf o.a7 = "1hs" Then
            o.P17.Text = "飛車"
        ElseIf o.a7 = "1k" Then
            o.P17.Text = "金将"
        ElseIf o.a7 = "1kg" Then
            o.P17.Text = "角行"
        ElseIf o.a7 = "1km" Then
            o.P17.Text = "桂馬"
        ElseIf o.a7 = "1ks" Then
            o.P17.Text = "香車"
        ElseIf o.a7 = "1ng" Then
            o.P17.Text = "成銀"
        ElseIf o.a7 = "1nk" Then
            o.P17.Text = "成桂"
        ElseIf o.a7 = "1nky" Then
            o.P17.Text = "成香"
        ElseIf o.a7 = "1o" Then
            o.P17.Text = "王将"
        ElseIf o.a7 = "1rm" Then
            o.P17.Text = "竜馬"
        ElseIf o.a7 = "1ro" Then
            o.P17.Text = "竜王"
        ElseIf o.a7 = "1tk" Then
            o.P17.Text = "と金"
        End If
        If o.b1 = "" Then
            o.P21.Text = ""
        ElseIf o.b1 = "2g" Then
            o.P21.Text = "銀将"
        ElseIf o.b1 = "2hh" Then
            o.P21.Text = "歩兵"
        ElseIf o.b1 = "2hs" Then
            o.P21.Text = "飛車"
        ElseIf o.b1 = "2k" Then
            o.P21.Text = "金将"
        ElseIf o.b1 = "2kg" Then
            o.P21.Text = "角行"
        ElseIf o.b1 = "2km" Then
            o.P21.Text = "桂馬"
        ElseIf o.b1 = "2ks" Then
            o.P21.Text = "香車"
        ElseIf o.b1 = "2ng" Then
            o.P21.Text = "成銀"
        ElseIf o.b1 = "2nk" Then
            o.P21.Text = "成桂"
        ElseIf o.b1 = "2nky" Then
            o.P21.Text = "成香"
        ElseIf o.b1 = "2o" Then
            o.P21.Text = "王将"
        ElseIf o.b1 = "2rm" Then
            o.P21.Text = "竜馬"
        ElseIf o.b1 = "2ro" Then
            o.P21.Text = "竜王"
        ElseIf o.b1 = "2tk" Then
            o.P21.Text = "と金"
        End If
        If o.b2 = "" Then
            o.P22.Text = ""
        ElseIf o.b2 = "2g" Then
            o.P22.Text = "銀将"
        ElseIf o.b2 = "2hh" Then
            o.P22.Text = "歩兵"
        ElseIf o.b2 = "2hs" Then
            o.P22.Text = "飛車"
        ElseIf o.b2 = "2k" Then
            o.P22.Text = "金将"
        ElseIf o.b2 = "2kg" Then
            o.P22.Text = "角行"
        ElseIf o.b2 = "2km" Then
            o.P22.Text = "桂馬"
        ElseIf o.b2 = "2ks" Then
            o.P22.Text = "香車"
        ElseIf o.b2 = "2ng" Then
            o.P22.Text = "成銀"
        ElseIf o.b2 = "2nk" Then
            o.P22.Text = "成桂"
        ElseIf o.b2 = "2nky" Then
            o.P22.Text = "成香"
        ElseIf o.b2 = "2o" Then
            o.P22.Text = "王将"
        ElseIf o.b2 = "2rm" Then
            o.P22.Text = "竜馬"
        ElseIf o.b2 = "2ro" Then
            o.P22.Text = "竜王"
        ElseIf o.b2 = "2tk" Then
            o.P22.Text = "と金"
        End If
        If o.b3 = "" Then
            o.P23.Text = ""
        ElseIf o.b3 = "2g" Then
            o.P23.Text = "銀将"
        ElseIf o.b3 = "2hh" Then
            o.P23.Text = "歩兵"
        ElseIf o.b3 = "2hs" Then
            o.P23.Text = "飛車"
        ElseIf o.b3 = "2k" Then
            o.P23.Text = "金将"
        ElseIf o.b3 = "2kg" Then
            o.P23.Text = "角行"
        ElseIf o.b3 = "2km" Then
            o.P23.Text = "桂馬"
        ElseIf o.b3 = "2ks" Then
            o.P23.Text = "香車"
        ElseIf o.b3 = "2ng" Then
            o.P23.Text = "成銀"
        ElseIf o.b3 = "2nk" Then
            o.P23.Text = "成桂"
        ElseIf o.b3 = "2nky" Then
            o.P23.Text = "成香"
        ElseIf o.b3 = "2o" Then
            o.P23.Text = "王将"
        ElseIf o.b3 = "2rm" Then
            o.P23.Text = "竜馬"
        ElseIf o.b3 = "2ro" Then
            o.P23.Text = "竜王"
        ElseIf o.b3 = "2tk" Then
            o.P23.Text = "と金"
        End If
        If o.b4 = "" Then
            o.P24.Text = ""
        ElseIf o.b4 = "2g" Then
            o.P24.Text = "銀将"
        ElseIf o.b4 = "2hh" Then
            o.P24.Text = "歩兵"
        ElseIf o.b4 = "2hs" Then
            o.P24.Text = "飛車"
        ElseIf o.b4 = "2k" Then
            o.P24.Text = "金将"
        ElseIf o.b4 = "2kg" Then
            o.P24.Text = "角行"
        ElseIf o.b4 = "2km" Then
            o.P24.Text = "桂馬"
        ElseIf o.b4 = "2ks" Then
            o.P24.Text = "香車"
        ElseIf o.b4 = "2ng" Then
            o.P24.Text = "成銀"
        ElseIf o.b4 = "2nk" Then
            o.P24.Text = "成桂"
        ElseIf o.b4 = "2nky" Then
            o.P24.Text = "成香"
        ElseIf o.b4 = "2o" Then
            o.P24.Text = "王将"
        ElseIf o.b4 = "2rm" Then
            o.P24.Text = "竜馬"
        ElseIf o.b4 = "2ro" Then
            o.P24.Text = "竜王"
        ElseIf o.b4 = "2tk" Then
            o.P24.Text = "と金"
        End If
        If o.b5 = "" Then
            o.P25.Text = ""
        ElseIf o.b5 = "2g" Then
            o.P25.Text = "銀将"
        ElseIf o.b5 = "2hh" Then
            o.P25.Text = "歩兵"
        ElseIf o.b5 = "2hs" Then
            o.P25.Text = "飛車"
        ElseIf o.b5 = "2k" Then
            o.P25.Text = "金将"
        ElseIf o.b5 = "2kg" Then
            o.P25.Text = "角行"
        ElseIf o.b5 = "2km" Then
            o.P25.Text = "桂馬"
        ElseIf o.b5 = "2ks" Then
            o.P25.Text = "香車"
        ElseIf o.b5 = "2ng" Then
            o.P25.Text = "成銀"
        ElseIf o.b5 = "2nk" Then
            o.P25.Text = "成桂"
        ElseIf o.b5 = "2nky" Then
            o.P25.Text = "成香"
        ElseIf o.b5 = "2o" Then
            o.P25.Text = "王将"
        ElseIf o.b5 = "2rm" Then
            o.P25.Text = "竜馬"
        ElseIf o.b5 = "2ro" Then
            o.P25.Text = "竜王"
        ElseIf o.b5 = "2tk" Then
            o.P25.Text = "と金"
        End If
        If o.b6 = "" Then
            o.P26.Text = ""
        ElseIf o.b6 = "2g" Then
            o.P26.Text = "銀将"
        ElseIf o.b6 = "2hh" Then
            o.P26.Text = "歩兵"
        ElseIf o.b6 = "2hs" Then
            o.P26.Text = "飛車"
        ElseIf o.b6 = "2k" Then
            o.P26.Text = "金将"
        ElseIf o.b6 = "2kg" Then
            o.P26.Text = "角行"
        ElseIf o.b6 = "2km" Then
            o.P26.Text = "桂馬"
        ElseIf o.b6 = "2ks" Then
            o.P26.Text = "香車"
        ElseIf o.b6 = "2ng" Then
            o.P26.Text = "成銀"
        ElseIf o.b6 = "2nk" Then
            o.P26.Text = "成桂"
        ElseIf o.b6 = "2nky" Then
            o.P26.Text = "成香"
        ElseIf o.b6 = "2o" Then
            o.P26.Text = "王将"
        ElseIf o.b6 = "2rm" Then
            o.P26.Text = "竜馬"
        ElseIf o.b6 = "2ro" Then
            o.P26.Text = "竜王"
        ElseIf o.b6 = "2tk" Then
            o.P26.Text = "と金"
        End If
        If o.b7 = "" Then
            o.P27.Text = ""
        ElseIf o.b7 = "2g" Then
            o.P27.Text = "銀将"
        ElseIf o.b7 = "2hh" Then
            o.P27.Text = "歩兵"
        ElseIf o.b7 = "2hs" Then
            o.P27.Text = "飛車"
        ElseIf o.b7 = "2k" Then
            o.P27.Text = "金将"
        ElseIf o.b7 = "2kg" Then
            o.P27.Text = "角行"
        ElseIf o.b7 = "2km" Then
            o.P27.Text = "桂馬"
        ElseIf o.b7 = "2ks" Then
            o.P27.Text = "香車"
        ElseIf o.b7 = "2ng" Then
            o.P27.Text = "成銀"
        ElseIf o.b7 = "2nk" Then
            o.P27.Text = "成桂"
        ElseIf o.b7 = "2nky" Then
            o.P27.Text = "成香"
        ElseIf o.b7 = "2o" Then
            o.P27.Text = "王将"
        ElseIf o.b7 = "2rm" Then
            o.P27.Text = "竜馬"
        ElseIf o.b7 = "2ro" Then
            o.P27.Text = "竜王"
        ElseIf o.b7 = "2tk" Then
            o.P27.Text = "と金"
        End If
        'Set2
        o.P11.Show()
        o.P12.Show()
        o.P13.Show()
        o.P14.Show()
        o.P15.Show()
        o.P16.Show()
        o.P17.Show()
        o.P21.Show()
        o.P22.Show()
        o.P23.Show()
        o.P24.Show()
        o.P25.Show()
        o.P26.Show()
        o.P27.Show()
        If o.a1 = "" Then
            o.P12.Hide()
            o.P13.Hide()
            o.P14.Hide()
            o.P15.Hide()
            o.P16.Hide()
            o.P17.Hide()
        ElseIf o.a2 = "" Then
            o.P13.Hide()
            o.P14.Hide()
            o.P15.Hide()
            o.P16.Hide()
            o.P17.Hide()
        ElseIf o.a3 = "" Then
            o.P14.Hide()
            o.P15.Hide()
            o.P16.Hide()
            o.P17.Hide()
        ElseIf o.a4 = "" Then
            o.P15.Hide()
            o.P16.Hide()
            o.P17.Hide()
        ElseIf o.a5 = "" Then
            o.P16.Hide()
            o.P17.Hide()
        ElseIf o.a6 = "" Then
            o.P17.Hide()
        ElseIf o.a7 = "" Then
        End If
        If o.b1 = "" Then
            o.P22.Hide()
            o.P23.Hide()
            o.P24.Hide()
            o.P25.Hide()
            o.P26.Hide()
            o.P27.Hide()
        ElseIf o.b2 = "" Then
            o.P23.Hide()
            o.P24.Hide()
            o.P25.Hide()
            o.P26.Hide()
            o.P27.Hide()
        ElseIf o.b3 = "" Then
            o.P24.Hide()
            o.P25.Hide()
            o.P26.Hide()
            o.P27.Hide()
        ElseIf o.b4 = "" Then
            o.P25.Hide()
            o.P26.Hide()
            o.P27.Hide()
        ElseIf o.b5 = "" Then
            o.P26.Hide()
            o.P27.Hide()
        ElseIf o.b6 = "" Then
            o.P27.Hide()
        ElseIf o.b7 = "" Then
        End If
        If o1 = 1 And o2 = 1 Then
            o.P1O.Show()
            o.P2O.Show()
        Else
            o.P1O.Hide()
            o.P2O.Hide()
            o.ok = 0
        End If
    End Sub

    Sub TC()
        If tp = "1a" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Show()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Hide()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Hide()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "1b" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Show()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Hide()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Hide()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "1c" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Show()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Hide()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Hide()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "2a" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "2b" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "2c" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Show()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Hide()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "3a" Then
            K1g.Show()
            K1hh.Hide()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Hide()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Show()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "3b" Then
            K1g.Show()
            K1hh.Hide()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Hide()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Show()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "3c" Then
            K1g.Show()
            K1hh.Hide()
            K1hs.Show()
            K1kg.Show()
            K1km.Hide()
            K1ks.Hide()
            K1k.Show()
            K1o.Show()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Show()
            K2ks.Show()
            K2k.Show()
            K2o.Show()
        ElseIf tp = "a1" Or tp = "a2" Or tp = "a3" Or tp = "a4" Or tp = "a5" Or tp = "a6" Or tp = "a7" Then
            K1g.Show()
            K1hh.Show()
            K1hs.Show()
            K1kg.Show()
            K1km.Show()
            K1ks.Show()
            K1k.Show()
            K1o.Hide()
            K2g.Hide()
            K2hh.Hide()
            K2hs.Hide()
            K2kg.Hide()
            K2km.Hide()
            K2ks.Hide()
            K2k.Hide()
            K2o.Hide()
        ElseIf tp = "b1" Or tp = "b2" Or tp = "b3" Or tp = "b4" Or tp = "b5" Or tp = "b6" Or tp = "b7" Then
            K1g.Hide()
            K1hh.Hide()
            K1hs.Hide()
            K1kg.Hide()
            K1km.Hide()
            K1ks.Hide()
            K1k.Hide()
            K1o.Hide()
            K2g.Show()
            K2hh.Show()
            K2hs.Show()
            K2kg.Show()
            K2km.Show()
            K2ks.Show()
            K2k.Show()
            K2o.Hide()
        Else
            K1g.Hide()
            K1hh.Hide()
            K1hs.Hide()
            K1kg.Hide()
            K1km.Hide()
            K1ks.Hide()
            K1k.Hide()
            K1o.Hide()
            K2g.Hide()
            K2hh.Hide()
            K2hs.Hide()
            K2kg.Hide()
            K2km.Hide()
            K2ks.Hide()
            K2k.Hide()
            K2o.Hide()
            BN.Hide()
        End If
    End Sub

    Public Sub PN_TextChanged(sender As Object, e As EventArgs) Handles PN.TextChanged
        BN.Show()
        TC()
        IA()
        If PN.Text = "1a" Then
            RN.Text = "(左から一番目・上から一番目)"
        ElseIf PN.Text = "1b" Then
            RN.Text = "(左から二番目・上から一番目)"
        ElseIf PN.Text = "1c" Then
            RN.Text = "(左から三番目・上から一番目)"
        ElseIf PN.Text = "2a" Then
            RN.Text = "(左から一番目・上から二番目)"
        ElseIf PN.Text = "2b" Then
            RN.Text = "(左から二番目・上から二番目)"
        ElseIf PN.Text = "2c" Then
            RN.Text = "(左から三番目・上から二番目)"
        ElseIf PN.Text = "3a" Then
            RN.Text = "(左から一番目・上から三番目)"
        ElseIf PN.Text = "3b" Then
            RN.Text = "(左から二番目・上から三番目)"
        ElseIf PN.Text = "3c" Then
            RN.Text = "(左から三番目・上から三番目)"
        ElseIf PN.Text = "a1" Or PN.Text = "a2" Or PN.Text = "a3" Or PN.Text = "a4" Or PN.Text = "a5" Or PN.Text = "a6" Or PN.Text = "a7" Then
            RN.Text = "(先攻の持ち駒)"
        ElseIf PN.Text = "b1" Or PN.Text = "b2" Or PN.Text = "b3" Or PN.Text = "b4" Or PN.Text = "b5" Or PN.Text = "b6" Or PN.Text = "b7" Then
            RN.Text = "(後攻の持ち駒)"
        End If
    End Sub
End Class