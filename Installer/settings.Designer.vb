<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.nextform = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.startup = New System.Windows.Forms.CheckBox()
        Me.formatting = New System.Windows.Forms.ComboBox()
        Me.count_view = New System.Windows.Forms.Label()
        Me.Duration = New System.Windows.Forms.ComboBox()
        Me.update_interval = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nextform
        '
        Me.nextform.Location = New System.Drawing.Point(167, 195)
        Me.nextform.Name = "nextform"
        Me.nextform.Size = New System.Drawing.Size(75, 23)
        Me.nextform.TabIndex = 11
        Me.nextform.Text = "Install"
        Me.nextform.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.startup)
        Me.GroupBox1.Controls.Add(Me.formatting)
        Me.GroupBox1.Controls.Add(Me.count_view)
        Me.GroupBox1.Controls.Add(Me.Duration)
        Me.GroupBox1.Controls.Add(Me.update_interval)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 139)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'startup
        '
        Me.startup.AutoSize = True
        Me.startup.Checked = True
        Me.startup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.startup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startup.Location = New System.Drawing.Point(182, 97)
        Me.startup.Name = "startup"
        Me.startup.Size = New System.Drawing.Size(137, 21)
        Me.startup.TabIndex = 16
        Me.startup.Text = "Auto Start On Boot"
        Me.startup.UseVisualStyleBackColor = True
        '
        'formatting
        '
        Me.formatting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formatting.FormattingEnabled = True
        Me.formatting.Items.AddRange(New Object() {"Numbers with comma", "Shortcuts B/M/K"})
        Me.formatting.Location = New System.Drawing.Point(182, 22)
        Me.formatting.Name = "formatting"
        Me.formatting.Size = New System.Drawing.Size(137, 21)
        Me.formatting.TabIndex = 14
        '
        'count_view
        '
        Me.count_view.AutoSize = True
        Me.count_view.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.count_view.Location = New System.Drawing.Point(70, 28)
        Me.count_view.Name = "count_view"
        Me.count_view.Size = New System.Drawing.Size(80, 19)
        Me.count_view.TabIndex = 13
        Me.count_view.Text = "Count View"
        '
        'Duration
        '
        Me.Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Duration.FormattingEnabled = True
        Me.Duration.Items.AddRange(New Object() {"1 Hour", "3 Hours", "6 Hours", "12 Hours", "1 Day"})
        Me.Duration.Location = New System.Drawing.Point(182, 60)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(87, 21)
        Me.Duration.TabIndex = 12
        '
        'update_interval
        '
        Me.update_interval.AutoSize = True
        Me.update_interval.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.update_interval.Location = New System.Drawing.Point(58, 62)
        Me.update_interval.Name = "update_interval"
        Me.update_interval.Size = New System.Drawing.Size(104, 19)
        Me.update_interval.TabIndex = 11
        Me.update_interval.Text = "Update Interval"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 239)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nextform)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Analytics Widget Installer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextform As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents formatting As ComboBox
    Friend WithEvents count_view As Label
    Friend WithEvents Duration As ComboBox
    Friend WithEvents update_interval As Label
    Friend WithEvents startup As CheckBox
End Class
