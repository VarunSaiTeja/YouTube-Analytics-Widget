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
        Me.id_textbox = New System.Windows.Forms.TextBox()
        Me.channel_id = New System.Windows.Forms.Label()
        Me.update_id = New System.Windows.Forms.Button()
        Me.update_interval = New System.Windows.Forms.Label()
        Me.Duration = New System.Windows.Forms.ComboBox()
        Me.count_view = New System.Windows.Forms.Label()
        Me.formatting = New System.Windows.Forms.ComboBox()
        Me.startup = New System.Windows.Forms.CheckBox()
        Me.title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'id_textbox
        '
        Me.id_textbox.Location = New System.Drawing.Point(141, 48)
        Me.id_textbox.Name = "id_textbox"
        Me.id_textbox.Size = New System.Drawing.Size(184, 20)
        Me.id_textbox.TabIndex = 0
        '
        'channel_id
        '
        Me.channel_id.AutoSize = True
        Me.channel_id.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.channel_id.Location = New System.Drawing.Point(29, 53)
        Me.channel_id.Name = "channel_id"
        Me.channel_id.Size = New System.Drawing.Size(65, 15)
        Me.channel_id.TabIndex = 1
        Me.channel_id.Text = "Channel ID"
        '
        'update_id
        '
        Me.update_id.Location = New System.Drawing.Point(149, 206)
        Me.update_id.Name = "update_id"
        Me.update_id.Size = New System.Drawing.Size(87, 23)
        Me.update_id.TabIndex = 2
        Me.update_id.Text = "Update"
        Me.update_id.UseVisualStyleBackColor = True
        '
        'update_interval
        '
        Me.update_interval.AutoSize = True
        Me.update_interval.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_interval.Location = New System.Drawing.Point(29, 131)
        Me.update_interval.Name = "update_interval"
        Me.update_interval.Size = New System.Drawing.Size(87, 15)
        Me.update_interval.TabIndex = 3
        Me.update_interval.Text = "Update Interval"
        '
        'Duration
        '
        Me.Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Duration.FormattingEnabled = True
        Me.Duration.Items.AddRange(New Object() {"1 Hour", "3 Hours", "6 Hours", "12 Hours", "1 Day"})
        Me.Duration.Location = New System.Drawing.Point(141, 129)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(87, 21)
        Me.Duration.TabIndex = 4
        '
        'count_view
        '
        Me.count_view.AutoSize = True
        Me.count_view.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_view.Location = New System.Drawing.Point(29, 90)
        Me.count_view.Name = "count_view"
        Me.count_view.Size = New System.Drawing.Size(68, 15)
        Me.count_view.TabIndex = 5
        Me.count_view.Text = "Count View"
        '
        'formatting
        '
        Me.formatting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formatting.FormattingEnabled = True
        Me.formatting.Items.AddRange(New Object() {"Numbers with comma", "Shortcuts B/M/K"})
        Me.formatting.Location = New System.Drawing.Point(141, 90)
        Me.formatting.Name = "formatting"
        Me.formatting.Size = New System.Drawing.Size(137, 21)
        Me.formatting.TabIndex = 6
        '
        'startup
        '
        Me.startup.AutoSize = True
        Me.startup.Checked = True
        Me.startup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.startup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startup.Location = New System.Drawing.Point(141, 169)
        Me.startup.Name = "startup"
        Me.startup.Size = New System.Drawing.Size(137, 21)
        Me.startup.TabIndex = 17
        Me.startup.Text = "Auto Start On Boot"
        Me.startup.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(144, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(84, 25)
        Me.title.TabIndex = 18
        Me.title.Text = "Settings"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 243)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.startup)
        Me.Controls.Add(Me.formatting)
        Me.Controls.Add(Me.count_view)
        Me.Controls.Add(Me.Duration)
        Me.Controls.Add(Me.update_interval)
        Me.Controls.Add(Me.update_id)
        Me.Controls.Add(Me.channel_id)
        Me.Controls.Add(Me.id_textbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.Text = "YouTube Analytics Widget"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id_textbox As TextBox
    Friend WithEvents channel_id As Label
    Friend WithEvents update_id As Button
    Friend WithEvents update_interval As Label
    Friend WithEvents Duration As ComboBox
    Friend WithEvents count_view As Label
    Friend WithEvents formatting As ComboBox
    Friend WithEvents startup As CheckBox
    Friend WithEvents title As Label
End Class
