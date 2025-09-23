Partial Class HomeForm

    Inherits System.Windows.Forms.Form

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents logoBox As PictureBox
    Friend WithEvents flowCards As FlowLayoutPanel

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        lblUserName = New Label()
        BtnNewHouse = New Button()
        btnLogout = New Button()
        flowCards = New FlowLayoutPanel()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.MediumSlateBlue
        PanelHeader.Controls.Add(lblUserName)
        PanelHeader.Controls.Add(BtnNewHouse)
        PanelHeader.Controls.Add(btnLogout)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(984, 60)
        PanelHeader.TabIndex = 0
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserName.ForeColor = SystemColors.ButtonHighlight
        lblUserName.Location = New Point(12, 15)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(0, 32)
        lblUserName.TabIndex = 4
        ' 
        ' BtnNewHouse
        ' 
        BtnNewHouse.Anchor = AnchorStyles.Right
        BtnNewHouse.BackColor = Color.White
        BtnNewHouse.FlatStyle = FlatStyle.Flat
        BtnNewHouse.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnNewHouse.Location = New Point(739, 15)
        BtnNewHouse.Name = "BtnNewHouse"
        BtnNewHouse.Size = New Size(170, 30)
        BtnNewHouse.TabIndex = 3
        BtnNewHouse.Text = "Cadastrar Nova Residencia"
        BtnNewHouse.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Right
        btnLogout.BackColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Location = New Point(915, 15)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(57, 30)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' flowCards
        ' 
        flowCards.AutoScroll = True
        flowCards.BackColor = Color.WhiteSmoke
        flowCards.Dock = DockStyle.Fill
        flowCards.Location = New Point(0, 60)
        flowCards.Name = "flowCards"
        flowCards.Padding = New Padding(20)
        flowCards.Size = New Size(984, 501)
        flowCards.TabIndex = 1
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 561)
        Controls.Add(flowCards)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "HomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rent Wise - Home"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents BtnNewHouse As Button


End Class
