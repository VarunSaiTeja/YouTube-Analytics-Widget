<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotifySettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotifySettings))
        Me.title = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsappToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelegramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaytmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayPalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update_Notification_Checkbox = New System.Windows.Forms.CheckBox()
        Me.nc_text = New System.Windows.Forms.Label()
        Me.Notification_click_combobox = New System.Windows.Forms.ComboBox()
        Me.Videos_checkbox = New System.Windows.Forms.CheckBox()
        Me.Views_checkbox = New System.Windows.Forms.CheckBox()
        Me.Subs_checkbox = New System.Windows.Forms.CheckBox()
        Me.in_notify = New System.Windows.Forms.GroupBox()
        Me.dc_text = New System.Windows.Forms.Label()
        Me.Icon_click_combobox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.in_notify.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(150, 34)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(145, 25)
        Me.title.TabIndex = 19
        Me.title.Text = "Notify Settings"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 22
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
        'Update_Notification_Checkbox
        '
        Me.Update_Notification_Checkbox.AutoSize = True
        Me.Update_Notification_Checkbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Notification_Checkbox.ForeColor = System.Drawing.Color.White
        Me.Update_Notification_Checkbox.Location = New System.Drawing.Point(155, 153)
        Me.Update_Notification_Checkbox.Name = "Update_Notification_Checkbox"
        Me.Update_Notification_Checkbox.Size = New System.Drawing.Size(179, 17)
        Me.Update_Notification_Checkbox.TabIndex = 26
        Me.Update_Notification_Checkbox.Text = "Analytics Update Notification"
        Me.Update_Notification_Checkbox.UseVisualStyleBackColor = True
        '
        'nc_text
        '
        Me.nc_text.AutoSize = True
        Me.nc_text.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nc_text.ForeColor = System.Drawing.Color.White
        Me.nc_text.Location = New System.Drawing.Point(30, 113)
        Me.nc_text.Name = "nc_text"
        Me.nc_text.Size = New System.Drawing.Size(94, 13)
        Me.nc_text.TabIndex = 27
        Me.nc_text.Text = "Notification click"
        '
        'Notification_click_combobox
        '
        Me.Notification_click_combobox.BackColor = System.Drawing.Color.White
        Me.Notification_click_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Notification_click_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Notification_click_combobox.FormattingEnabled = True
        Me.Notification_click_combobox.Items.AddRange(New Object() {"Nothing", "Open Analytics", "Open Creator Studio", "Open Channel"})
        Me.Notification_click_combobox.Location = New System.Drawing.Point(155, 113)
        Me.Notification_click_combobox.Name = "Notification_click_combobox"
        Me.Notification_click_combobox.Size = New System.Drawing.Size(179, 21)
        Me.Notification_click_combobox.TabIndex = 28
        '
        'Videos_checkbox
        '
        Me.Videos_checkbox.AutoSize = True
        Me.Videos_checkbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Videos_checkbox.ForeColor = System.Drawing.Color.White
        Me.Videos_checkbox.Location = New System.Drawing.Point(17, 63)
        Me.Videos_checkbox.Name = "Videos_checkbox"
        Me.Videos_checkbox.Size = New System.Drawing.Size(61, 17)
        Me.Videos_checkbox.TabIndex = 39
        Me.Videos_checkbox.Text = "Videos"
        Me.Videos_checkbox.UseVisualStyleBackColor = True
        '
        'Views_checkbox
        '
        Me.Views_checkbox.AutoSize = True
        Me.Views_checkbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Views_checkbox.ForeColor = System.Drawing.Color.White
        Me.Views_checkbox.Location = New System.Drawing.Point(17, 42)
        Me.Views_checkbox.Name = "Views_checkbox"
        Me.Views_checkbox.Size = New System.Drawing.Size(56, 17)
        Me.Views_checkbox.TabIndex = 38
        Me.Views_checkbox.Text = "Views"
        Me.Views_checkbox.UseVisualStyleBackColor = True
        '
        'Subs_checkbox
        '
        Me.Subs_checkbox.AutoSize = True
        Me.Subs_checkbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subs_checkbox.ForeColor = System.Drawing.Color.White
        Me.Subs_checkbox.Location = New System.Drawing.Point(17, 21)
        Me.Subs_checkbox.Name = "Subs_checkbox"
        Me.Subs_checkbox.Size = New System.Drawing.Size(85, 17)
        Me.Subs_checkbox.TabIndex = 37
        Me.Subs_checkbox.Text = "Subscribers"
        Me.Subs_checkbox.UseVisualStyleBackColor = True
        '
        'in_notify
        '
        Me.in_notify.Controls.Add(Me.Subs_checkbox)
        Me.in_notify.Controls.Add(Me.Videos_checkbox)
        Me.in_notify.Controls.Add(Me.Views_checkbox)
        Me.in_notify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.in_notify.ForeColor = System.Drawing.Color.White
        Me.in_notify.Location = New System.Drawing.Point(155, 176)
        Me.in_notify.Name = "in_notify"
        Me.in_notify.Size = New System.Drawing.Size(179, 87)
        Me.in_notify.TabIndex = 30
        Me.in_notify.TabStop = False
        Me.in_notify.Text = "In Notification Show"
        Me.in_notify.Visible = False
        '
        'dc_text
        '
        Me.dc_text.AutoSize = True
        Me.dc_text.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dc_text.ForeColor = System.Drawing.Color.White
        Me.dc_text.Location = New System.Drawing.Point(30, 79)
        Me.dc_text.Name = "dc_text"
        Me.dc_text.Size = New System.Drawing.Size(90, 13)
        Me.dc_text.TabIndex = 23
        Me.dc_text.Text = "Notify icon click"
        '
        'Icon_click_combobox
        '
        Me.Icon_click_combobox.BackColor = System.Drawing.Color.White
        Me.Icon_click_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Icon_click_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_click_combobox.FormattingEnabled = True
        Me.Icon_click_combobox.Items.AddRange(New Object() {"Update Analytics", "Show Settings", "Show  Notify Settings", "Nothing"})
        Me.Icon_click_combobox.Location = New System.Drawing.Point(155, 76)
        Me.Icon_click_combobox.Name = "Icon_click_combobox"
        Me.Icon_click_combobox.Size = New System.Drawing.Size(179, 21)
        Me.Icon_click_combobox.TabIndex = 25
        '
        'NotifySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(387, 276)
        Me.Controls.Add(Me.in_notify)
        Me.Controls.Add(Me.Notification_click_combobox)
        Me.Controls.Add(Me.nc_text)
        Me.Controls.Add(Me.Update_Notification_Checkbox)
        Me.Controls.Add(Me.Icon_click_combobox)
        Me.Controls.Add(Me.dc_text)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotifySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notify Settings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.in_notify.ResumeLayout(False)
        Me.in_notify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatsappToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TelegramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaytmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayPalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Update_Notification_Checkbox As CheckBox
    Friend WithEvents nc_text As Label
    Friend WithEvents Notification_click_combobox As ComboBox
    Friend WithEvents Videos_checkbox As CheckBox
    Friend WithEvents Views_checkbox As CheckBox
    Friend WithEvents Subs_checkbox As CheckBox
    Friend WithEvents in_notify As GroupBox
    Friend WithEvents dc_text As Label
    Friend WithEvents Icon_click_combobox As ComboBox
End Class
