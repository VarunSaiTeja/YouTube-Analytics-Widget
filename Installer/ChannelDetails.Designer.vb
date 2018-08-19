<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChannelDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChannelDetails))
        Me.title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nextform = New System.Windows.Forms.Button()
        Me.id_set = New System.Windows.Forms.Button()
        Me.sub_count = New System.Windows.Forms.Label()
        Me.view_count = New System.Windows.Forms.Label()
        Me.videos_count = New System.Windows.Forms.Label()
        Me.videos = New System.Windows.Forms.Label()
        Me.views = New System.Windows.Forms.Label()
        Me.subscribers = New System.Windows.Forms.Label()
        Me.gbox = New System.Windows.Forms.GroupBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.gbox.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.title.Location = New System.Drawing.Point(143, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(144, 25)
        Me.title.TabIndex = 0
        Me.title.Text = "Channel Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Channel ID"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(105, 43)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(217, 20)
        Me.id.TabIndex = 2
        '
        'nextform
        '
        Me.nextform.Location = New System.Drawing.Point(176, 221)
        Me.nextform.Name = "nextform"
        Me.nextform.Size = New System.Drawing.Size(75, 23)
        Me.nextform.TabIndex = 3
        Me.nextform.Text = "Next"
        Me.nextform.UseVisualStyleBackColor = True
        Me.nextform.Visible = False
        '
        'id_set
        '
        Me.id_set.Location = New System.Drawing.Point(328, 41)
        Me.id_set.Name = "id_set"
        Me.id_set.Size = New System.Drawing.Size(57, 23)
        Me.id_set.TabIndex = 4
        Me.id_set.Text = "Set"
        Me.id_set.UseVisualStyleBackColor = True
        '
        'sub_count
        '
        Me.sub_count.AutoSize = True
        Me.sub_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_count.Location = New System.Drawing.Point(230, 36)
        Me.sub_count.Name = "sub_count"
        Me.sub_count.Size = New System.Drawing.Size(15, 17)
        Me.sub_count.TabIndex = 12
        Me.sub_count.Text = "0"
        '
        'view_count
        '
        Me.view_count.AutoSize = True
        Me.view_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_count.Location = New System.Drawing.Point(230, 63)
        Me.view_count.Name = "view_count"
        Me.view_count.Size = New System.Drawing.Size(15, 17)
        Me.view_count.TabIndex = 13
        Me.view_count.Text = "0"
        '
        'videos_count
        '
        Me.videos_count.AutoSize = True
        Me.videos_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videos_count.Location = New System.Drawing.Point(230, 89)
        Me.videos_count.Name = "videos_count"
        Me.videos_count.Size = New System.Drawing.Size(15, 17)
        Me.videos_count.TabIndex = 14
        Me.videos_count.Text = "0"
        '
        'videos
        '
        Me.videos.AutoSize = True
        Me.videos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videos.Location = New System.Drawing.Point(169, 89)
        Me.videos.Name = "videos"
        Me.videos.Size = New System.Drawing.Size(55, 17)
        Me.videos.TabIndex = 17
        Me.videos.Text = "Videos :"
        '
        'views
        '
        Me.views.AutoSize = True
        Me.views.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.views.Location = New System.Drawing.Point(174, 63)
        Me.views.Name = "views"
        Me.views.Size = New System.Drawing.Size(48, 17)
        Me.views.TabIndex = 16
        Me.views.Text = "Views :"
        '
        'subscribers
        '
        Me.subscribers.AutoSize = True
        Me.subscribers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subscribers.Location = New System.Drawing.Point(139, 36)
        Me.subscribers.Name = "subscribers"
        Me.subscribers.Size = New System.Drawing.Size(83, 17)
        Me.subscribers.TabIndex = 15
        Me.subscribers.Text = "Subscribers :"
        '
        'gbox
        '
        Me.gbox.Controls.Add(Me.logo)
        Me.gbox.Controls.Add(Me.videos)
        Me.gbox.Controls.Add(Me.subscribers)
        Me.gbox.Controls.Add(Me.views)
        Me.gbox.Controls.Add(Me.sub_count)
        Me.gbox.Controls.Add(Me.view_count)
        Me.gbox.Controls.Add(Me.videos_count)
        Me.gbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbox.Location = New System.Drawing.Point(52, 80)
        Me.gbox.Name = "gbox"
        Me.gbox.Size = New System.Drawing.Size(321, 135)
        Me.gbox.TabIndex = 18
        Me.gbox.TabStop = False
        Me.gbox.Text = "Channel Name"
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(15, 24)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(96, 96)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'ChannelDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 256)
        Me.Controls.Add(Me.gbox)
        Me.Controls.Add(Me.id_set)
        Me.Controls.Add(Me.nextform)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChannelDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Analytics Widget Installer"
        Me.gbox.ResumeLayout(False)
        Me.gbox.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents nextform As Button
    Friend WithEvents id_set As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents sub_count As Label
    Friend WithEvents view_count As Label
    Friend WithEvents videos_count As Label
    Friend WithEvents videos As Label
    Friend WithEvents views As Label
    Friend WithEvents subscribers As Label
    Friend WithEvents gbox As GroupBox
End Class
