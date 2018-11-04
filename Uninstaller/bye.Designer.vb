<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bye
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bye))
        Me.title = New System.Windows.Forms.Label()
        Me.button = New System.Windows.Forms.Button()
        Me.tip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(180, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(145, 21)
        Me.title.TabIndex = 0
        Me.title.Text = "Confirm Uninstall"
        '
        'button
        '
        Me.button.Location = New System.Drawing.Point(210, 151)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(79, 28)
        Me.button.TabIndex = 1
        Me.button.Text = "Uninstall"
        Me.button.UseVisualStyleBackColor = True
        '
        'tip
        '
        Me.tip.AutoSize = True
        Me.tip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tip.Location = New System.Drawing.Point(55, 61)
        Me.tip.Name = "tip"
        Me.tip.Size = New System.Drawing.Size(378, 63)
        Me.tip.TabIndex = 2
        Me.tip.Text = "                      After uninstalling this software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         My YouTube Chann" &
    "el will open in your browser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Subscribe to my channel and support me litt" &
    "le bit"
        '
        'bye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 191)
        Me.Controls.Add(Me.tip)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bye"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Analytics Widget Uninstaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents button As Button
    Friend WithEvents tip As Label
End Class
