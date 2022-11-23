<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.LT = New System.Windows.Forms.Label()
        Me.LR = New System.Windows.Forms.Label()
        Me.BO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Font = New System.Drawing.Font("MS UI Gothic", 40.0!)
        Me.LT.Location = New System.Drawing.Point(12, 9)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(163, 67)
        Me.LT.TabIndex = 0
        Me.LT.Text = "勝者"
        '
        'LR
        '
        Me.LR.AutoSize = True
        Me.LR.Font = New System.Drawing.Font("MS UI Gothic", 40.0!)
        Me.LR.Location = New System.Drawing.Point(221, 9)
        Me.LR.Name = "LR"
        Me.LR.Size = New System.Drawing.Size(0, 67)
        Me.LR.TabIndex = 1
        '
        'BO
        '
        Me.BO.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.BO.Location = New System.Drawing.Point(12, 94)
        Me.BO.Name = "BO"
        Me.BO.Size = New System.Drawing.Size(373, 57)
        Me.BO.TabIndex = 2
        Me.BO.Text = "OK"
        Me.BO.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 163)
        Me.Controls.Add(Me.BO)
        Me.Controls.Add(Me.LR)
        Me.Controls.Add(Me.LT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Result"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents LR As Label
    Friend WithEvents BO As Button
End Class
