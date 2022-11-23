<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.S9 = New System.Windows.Forms.Button()
        Me.S3 = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'S9
        '
        Me.S9.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.S9.Location = New System.Drawing.Point(12, 12)
        Me.S9.Name = "S9"
        Me.S9.Size = New System.Drawing.Size(216, 72)
        Me.S9.TabIndex = 0
        Me.S9.Text = "9 × 9"
        Me.S9.UseVisualStyleBackColor = True
        '
        'S3
        '
        Me.S3.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.S3.Location = New System.Drawing.Point(234, 12)
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(216, 72)
        Me.S3.TabIndex = 1
        Me.S3.Text = "3 × 3"
        Me.S3.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 3000
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(464, 100)
        Me.Controls.Add(Me.S3)
        Me.Controls.Add(Me.S9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents S9 As Button
    Friend WithEvents S3 As Button
    Friend WithEvents Timer As Timer
End Class
