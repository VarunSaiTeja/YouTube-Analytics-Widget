<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class widget
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(widget))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResizeorRelocateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Channel_logo = New System.Windows.Forms.PictureBox()
        Me.statistics_updater = New System.Windows.Forms.Timer(Me.components)
        Me.channel_name = New System.Windows.Forms.Label()
        Me.videos_count = New System.Windows.Forms.Label()
        Me.view_count = New System.Windows.Forms.Label()
        Me.sub_count = New System.Windows.Forms.Label()
        Me.videos = New System.Windows.Forms.Label()
        Me.views = New System.Windows.Forms.Label()
        Me.subscribers = New System.Windows.Forms.Label()
        Me.check_update = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Channel_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResizeorRelocateToolStripMenuItem, Me.UpdateNowToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 92)
        '
        'ResizeorRelocateToolStripMenuItem
        '
        Me.ResizeorRelocateToolStripMenuItem.CheckOnClick = True
        Me.ResizeorRelocateToolStripMenuItem.Name = "ResizeorRelocateToolStripMenuItem"
        Me.ResizeorRelocateToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ResizeorRelocateToolStripMenuItem.Text = "Resize or Relocate"
        '
        'UpdateNowToolStripMenuItem
        '
        Me.UpdateNowToolStripMenuItem.Name = "UpdateNowToolStripMenuItem"
        Me.UpdateNowToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UpdateNowToolStripMenuItem.Text = "Update Now"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Channel_logo
        '
        Me.Channel_logo.Location = New System.Drawing.Point(12, 34)
        Me.Channel_logo.Name = "Channel_logo"
        Me.Channel_logo.Size = New System.Drawing.Size(85, 85)
        Me.Channel_logo.TabIndex = 1
        Me.Channel_logo.TabStop = False
        '
        'statistics_updater
        '
        '
        'channel_name
        '
        Me.channel_name.AutoSize = True
        Me.channel_name.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.channel_name.Location = New System.Drawing.Point(8, 9)
        Me.channel_name.Name = "channel_name"
        Me.channel_name.Size = New System.Drawing.Size(62, 19)
        Me.channel_name.TabIndex = 2
        Me.channel_name.Text = "Channel"
        '
        'videos_count
        '
        Me.videos_count.AutoSize = True
        Me.videos_count.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videos_count.Location = New System.Drawing.Point(187, 93)
        Me.videos_count.Name = "videos_count"
        Me.videos_count.Size = New System.Drawing.Size(15, 17)
        Me.videos_count.TabIndex = 13
        Me.videos_count.Text = "0"
        '
        'view_count
        '
        Me.view_count.AutoSize = True
        Me.view_count.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_count.Location = New System.Drawing.Point(187, 67)
        Me.view_count.Name = "view_count"
        Me.view_count.Size = New System.Drawing.Size(15, 17)
        Me.view_count.TabIndex = 12
        Me.view_count.Text = "0"
        '
        'sub_count
        '
        Me.sub_count.AutoSize = True
        Me.sub_count.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_count.Location = New System.Drawing.Point(187, 40)
        Me.sub_count.Name = "sub_count"
        Me.sub_count.Size = New System.Drawing.Size(15, 17)
        Me.sub_count.TabIndex = 11
        Me.sub_count.Text = "0"
        '
        'videos
        '
        Me.videos.AutoSize = True
        Me.videos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videos.Location = New System.Drawing.Point(132, 93)
        Me.videos.Name = "videos"
        Me.videos.Size = New System.Drawing.Size(55, 17)
        Me.videos.TabIndex = 10
        Me.videos.Text = "Videos :"
        '
        'views
        '
        Me.views.AutoSize = True
        Me.views.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.views.Location = New System.Drawing.Point(138, 67)
        Me.views.Name = "views"
        Me.views.Size = New System.Drawing.Size(49, 17)
        Me.views.TabIndex = 9
        Me.views.Text = "Views :"
        '
        'subscribers
        '
        Me.subscribers.AutoSize = True
        Me.subscribers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subscribers.Location = New System.Drawing.Point(103, 40)
        Me.subscribers.Name = "subscribers"
        Me.subscribers.Size = New System.Drawing.Size(84, 17)
        Me.subscribers.TabIndex = 8
        Me.subscribers.Text = "Subscribers :"
        '
        'check_update
        '
        Me.check_update.Interval = 10000
        '
        'widget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(250, 130)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.videos_count)
        Me.Controls.Add(Me.view_count)
        Me.Controls.Add(Me.sub_count)
        Me.Controls.Add(Me.videos)
        Me.Controls.Add(Me.views)
        Me.Controls.Add(Me.subscribers)
        Me.Controls.Add(Me.channel_name)
        Me.Controls.Add(Me.Channel_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "widget"
        Me.ShowInTaskbar = False
        Me.Text = "YouTube Analytics Widget"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Channel_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ResizeorRelocateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Channel_logo As PictureBox
    Friend WithEvents statistics_updater As Timer
    Friend WithEvents channel_name As Label
    Friend WithEvents videos_count As Label
    Friend WithEvents view_count As Label
    Friend WithEvents sub_count As Label
    Friend WithEvents videos As Label
    Friend WithEvents views As Label
    Friend WithEvents subscribers As Label
    Friend WithEvents UpdateNowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents check_update As Timer
End Class
