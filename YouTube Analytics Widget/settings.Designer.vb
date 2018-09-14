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
        Me.task_on_logo = New System.Windows.Forms.Label()
        Me.logo_task = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsappToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelegramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaytmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayPalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Cust_font_color = New System.Windows.Forms.Button()
        Me.Cust_back_color = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'id_textbox
        '
        Me.id_textbox.BackColor = System.Drawing.Color.White
        Me.id_textbox.Location = New System.Drawing.Point(131, 74)
        Me.id_textbox.Name = "id_textbox"
        Me.id_textbox.Size = New System.Drawing.Size(214, 22)
        Me.id_textbox.TabIndex = 0
        '
        'channel_id
        '
        Me.channel_id.AutoSize = True
        Me.channel_id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.channel_id.ForeColor = System.Drawing.Color.White
        Me.channel_id.Location = New System.Drawing.Point(21, 77)
        Me.channel_id.Name = "channel_id"
        Me.channel_id.Size = New System.Drawing.Size(64, 13)
        Me.channel_id.TabIndex = 1
        Me.channel_id.Text = "Channel ID"
        '
        'update_id
        '
        Me.update_id.BackColor = System.Drawing.Color.Crimson
        Me.update_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_id.ForeColor = System.Drawing.Color.White
        Me.update_id.Location = New System.Drawing.Point(351, 74)
        Me.update_id.Name = "update_id"
        Me.update_id.Size = New System.Drawing.Size(48, 22)
        Me.update_id.TabIndex = 2
        Me.update_id.Text = "Set"
        Me.update_id.UseVisualStyleBackColor = False
        '
        'update_interval
        '
        Me.update_interval.AutoSize = True
        Me.update_interval.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_interval.ForeColor = System.Drawing.Color.White
        Me.update_interval.Location = New System.Drawing.Point(21, 156)
        Me.update_interval.Name = "update_interval"
        Me.update_interval.Size = New System.Drawing.Size(87, 13)
        Me.update_interval.TabIndex = 3
        Me.update_interval.Text = "Update Interval"
        '
        'Duration
        '
        Me.Duration.BackColor = System.Drawing.Color.White
        Me.Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Duration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Duration.FormattingEnabled = True
        Me.Duration.Items.AddRange(New Object() {"1 Hour", "3 Hours", "6 Hours", "12 Hours", "1 Day"})
        Me.Duration.Location = New System.Drawing.Point(131, 153)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(101, 21)
        Me.Duration.TabIndex = 4
        '
        'count_view
        '
        Me.count_view.AutoSize = True
        Me.count_view.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_view.ForeColor = System.Drawing.Color.White
        Me.count_view.Location = New System.Drawing.Point(21, 117)
        Me.count_view.Name = "count_view"
        Me.count_view.Size = New System.Drawing.Size(67, 13)
        Me.count_view.TabIndex = 5
        Me.count_view.Text = "Count View"
        '
        'formatting
        '
        Me.formatting.BackColor = System.Drawing.Color.White
        Me.formatting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.formatting.FormattingEnabled = True
        Me.formatting.Items.AddRange(New Object() {"Numbers with comma", "Shortcuts B/M/K"})
        Me.formatting.Location = New System.Drawing.Point(131, 114)
        Me.formatting.Name = "formatting"
        Me.formatting.Size = New System.Drawing.Size(181, 21)
        Me.formatting.TabIndex = 6
        '
        'startup
        '
        Me.startup.AutoSize = True
        Me.startup.Checked = True
        Me.startup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.startup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startup.ForeColor = System.Drawing.Color.White
        Me.startup.Location = New System.Drawing.Point(131, 319)
        Me.startup.Name = "startup"
        Me.startup.Size = New System.Drawing.Size(125, 17)
        Me.startup.TabIndex = 17
        Me.startup.Text = "Auto Start On Boot"
        Me.startup.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(175, 35)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(84, 25)
        Me.title.TabIndex = 18
        Me.title.Text = "Settings"
        '
        'task_on_logo
        '
        Me.task_on_logo.AutoSize = True
        Me.task_on_logo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task_on_logo.ForeColor = System.Drawing.Color.White
        Me.task_on_logo.Location = New System.Drawing.Point(21, 195)
        Me.task_on_logo.Name = "task_on_logo"
        Me.task_on_logo.Size = New System.Drawing.Size(89, 13)
        Me.task_on_logo.TabIndex = 19
        Me.task_on_logo.Text = "Click on logo to"
        '
        'logo_task
        '
        Me.logo_task.BackColor = System.Drawing.Color.White
        Me.logo_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.logo_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logo_task.FormattingEnabled = True
        Me.logo_task.Items.AddRange(New Object() {"Nothing", "Update Analytics", "Open Analytics", "Open Creator Studio", "Open Channel"})
        Me.logo_task.Location = New System.Drawing.Point(131, 192)
        Me.logo_task.Name = "logo_task"
        Me.logo_task.Size = New System.Drawing.Size(181, 21)
        Me.logo_task.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsappToolStripMenuItem, Me.TelegramToolStripMenuItem, Me.YouTubeToolStripMenuItem})
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'WhatsappToolStripMenuItem
        '
        Me.WhatsappToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.whatsapp
        Me.WhatsappToolStripMenuItem.Name = "WhatsappToolStripMenuItem"
        Me.WhatsappToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.WhatsappToolStripMenuItem.Text = "Whatsapp"
        '
        'TelegramToolStripMenuItem
        '
        Me.TelegramToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.telegram
        Me.TelegramToolStripMenuItem.Name = "TelegramToolStripMenuItem"
        Me.TelegramToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TelegramToolStripMenuItem.Text = "Telegram"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.youtube
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaytmToolStripMenuItem, Me.UPIToolStripMenuItem, Me.PayPalToolStripMenuItem})
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'PaytmToolStripMenuItem
        '
        Me.PaytmToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.paytm
        Me.PaytmToolStripMenuItem.Name = "PaytmToolStripMenuItem"
        Me.PaytmToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PaytmToolStripMenuItem.Text = "Paytm"
        '
        'UPIToolStripMenuItem
        '
        Me.UPIToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.upi
        Me.UPIToolStripMenuItem.Name = "UPIToolStripMenuItem"
        Me.UPIToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.UPIToolStripMenuItem.Text = "UPI"
        '
        'PayPalToolStripMenuItem
        '
        Me.PayPalToolStripMenuItem.Image = Global.YouTube_Analytics_Widget.My.Resources.Resources.paypal
        Me.PayPalToolStripMenuItem.Name = "PayPalToolStripMenuItem"
        Me.PayPalToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PayPalToolStripMenuItem.Text = "PayPal"
        '
        'Cust_font_color
        '
        Me.Cust_font_color.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cust_font_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cust_font_color.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_font_color.ForeColor = System.Drawing.Color.White
        Me.Cust_font_color.Location = New System.Drawing.Point(131, 275)
        Me.Cust_font_color.Name = "Cust_font_color"
        Me.Cust_font_color.Size = New System.Drawing.Size(121, 26)
        Me.Cust_font_color.TabIndex = 30
        Me.Cust_font_color.Text = "Font Color"
        Me.Cust_font_color.UseVisualStyleBackColor = True
        '
        'Cust_back_color
        '
        Me.Cust_back_color.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cust_back_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cust_back_color.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_back_color.ForeColor = System.Drawing.Color.White
        Me.Cust_back_color.Location = New System.Drawing.Point(131, 231)
        Me.Cust_back_color.Name = "Cust_back_color"
        Me.Cust_back_color.Size = New System.Drawing.Size(121, 26)
        Me.Cust_back_color.TabIndex = 29
        Me.Cust_back_color.Text = "Background Color"
        Me.Cust_back_color.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(422, 353)
        Me.Controls.Add(Me.Cust_font_color)
        Me.Controls.Add(Me.Cust_back_color)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.logo_task)
        Me.Controls.Add(Me.task_on_logo)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.startup)
        Me.Controls.Add(Me.formatting)
        Me.Controls.Add(Me.count_view)
        Me.Controls.Add(Me.Duration)
        Me.Controls.Add(Me.update_interval)
        Me.Controls.Add(Me.update_id)
        Me.Controls.Add(Me.channel_id)
        Me.Controls.Add(Me.id_textbox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Analytics Widget"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents task_on_logo As Label
    Friend WithEvents logo_task As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatsappToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TelegramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaytmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayPalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewColorDialog As ColorDialog
    Friend WithEvents Cust_font_color As Button
    Friend WithEvents Cust_back_color As Button
End Class
