<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.buttonUserData = New System.Windows.Forms.Button()
        Me.buttonRegistration = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.buttonScanPort = New System.Windows.Forms.Button()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelDepartment = New System.Windows.Forms.Label()
        Me.TextBoxDep = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.TextBoxVille = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.TextBoxadresse = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.Label()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelRegistrationandEditUserData = New System.Windows.Forms.Panel()
        Me.PanelReadingTagProcess = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonCloseReadingTag = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelGetID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonScanID = New System.Windows.Forms.Button()
        Me.buttonClearForm = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.TextBoxDep2 = New System.Windows.Forms.TextBox()
        Me.TextBoxVille2 = New System.Windows.Forms.TextBox()
        Me.TextBoxadresse2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNom2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBoxSttusConnect = New System.Windows.Forms.PictureBox()
        Me.buttonConnection = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffacerSelectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConnection.SuspendLayout()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegistrationandEditUserData.SuspendLayout()
        Me.PanelReadingTagProcess.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxSttusConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBoxSelect)
        Me.PanelMenu.Controls.Add(Me.buttonUserData)
        Me.PanelMenu.Controls.Add(Me.buttonRegistration)
        Me.PanelMenu.Controls.Add(Me.PictureBoxLogo)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(432, 713)
        Me.PanelMenu.TabIndex = 0
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_arrow138_216456
        Me.PictureBoxSelect.Location = New System.Drawing.Point(0, 238)
        Me.PictureBoxSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(24, 44)
        Me.PictureBoxSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSelect.TabIndex = 2
        Me.PictureBoxSelect.TabStop = False
        '
        'buttonUserData
        '
        Me.buttonUserData.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.buttonUserData.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.buttonUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonUserData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonUserData.Location = New System.Drawing.Point(29, 304)
        Me.buttonUserData.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonUserData.Name = "buttonUserData"
        Me.buttonUserData.Size = New System.Drawing.Size(403, 44)
        Me.buttonUserData.TabIndex = 2
        Me.buttonUserData.Text = "Données Utilisateur"
        Me.buttonUserData.UseVisualStyleBackColor = False
        '
        'buttonRegistration
        '
        Me.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.buttonRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonRegistration.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_document_text_edit_103514
        Me.buttonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonRegistration.Location = New System.Drawing.Point(29, 377)
        Me.buttonRegistration.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRegistration.Name = "buttonRegistration"
        Me.buttonRegistration.Size = New System.Drawing.Size(403, 44)
        Me.buttonRegistration.TabIndex = 3
        Me.buttonRegistration.Text = "Enregistrer / Editer Utilisateur"
        Me.buttonRegistration.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.arduino_RFID_UI.My.Resources.Resources.user
        Me.PictureBoxLogo.Location = New System.Drawing.Point(83, 31)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(267, 175)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(440, 5)
        Me.LabelConnectionStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(209, 17)
        Me.LabelConnectionStatus.TabIndex = 2
        Me.LabelConnectionStatus.Text = "Etat de connexion : Déconnecté"
        '
        'LabelDateTime
        '
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(920, 5)
        Me.LabelDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(283, 17)
        Me.LabelDateTime.TabIndex = 4
        Me.LabelDateTime.Text = "Time 00:00:00 Date 00 mmm; 0000"
        '
        'PanelConnection
        '
        Me.PanelConnection.Controls.Add(Me.Panel1)
        Me.PanelConnection.Controls.Add(Me.buttonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.Label1)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.buttonScanPort)
        Me.PanelConnection.Controls.Add(Me.PanelUserData)
        Me.PanelConnection.Location = New System.Drawing.Point(464, 26)
        Me.PanelConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(784, 672)
        Me.PanelConnection.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 6)
        Me.Panel1.TabIndex = 0
        '
        'buttonConnect
        '
        Me.buttonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonConnect.Enabled = False
        Me.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonConnect.Location = New System.Drawing.Point(41, 65)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New System.Drawing.Size(555, 30)
        Me.buttonConnect.TabIndex = 6
        Me.buttonConnect.Text = "Connecté"
        Me.buttonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600 ", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(603, 24)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(90, 24)
        Me.ComboBoxBaudRate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Andalus", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "vitesse de transmission :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(133, 20)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(265, 24)
        Me.ComboBoxPort.TabIndex = 2
        '
        'buttonScanPort
        '
        Me.buttonScanPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonScanPort.Enabled = False
        Me.buttonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonScanPort.Location = New System.Drawing.Point(14, 20)
        Me.buttonScanPort.Name = "buttonScanPort"
        Me.buttonScanPort.Size = New System.Drawing.Size(113, 27)
        Me.buttonScanPort.TabIndex = 1
        Me.buttonScanPort.Text = "Scanner le port"
        Me.buttonScanPort.UseVisualStyleBackColor = False
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.Controls.Add(Me.GroupBox)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Controls.Add(Me.Panel3)
        Me.PanelUserData.Location = New System.Drawing.Point(4, 14)
        Me.PanelUserData.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(784, 672)
        Me.PanelUserData.TabIndex = 7
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.LabelDepartment)
        Me.GroupBox.Controls.Add(Me.TextBoxDep)
        Me.GroupBox.Controls.Add(Me.LabelCity)
        Me.GroupBox.Controls.Add(Me.TextBoxVille)
        Me.GroupBox.Controls.Add(Me.LabelAddress)
        Me.GroupBox.Controls.Add(Me.buttonClear)
        Me.GroupBox.Controls.Add(Me.TextBoxadresse)
        Me.GroupBox.Controls.Add(Me.LabelName)
        Me.GroupBox.Controls.Add(Me.TextBoxNom)
        Me.GroupBox.Location = New System.Drawing.Point(26, 304)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(709, 323)
        Me.GroupBox.TabIndex = 2
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Detail Données"
        '
        'LabelDepartment
        '
        Me.LabelDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDepartment.Location = New System.Drawing.Point(129, 233)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(86, 19)
        Me.LabelDepartment.TabIndex = 8
        Me.LabelDepartment.Text = "Patientez..."
        '
        'TextBoxDep
        '
        Me.TextBoxDep.AutoSize = True
        Me.TextBoxDep.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDep.Location = New System.Drawing.Point(6, 233)
        Me.TextBoxDep.Name = "TextBoxDep"
        Me.TextBoxDep.Size = New System.Drawing.Size(110, 19)
        Me.TextBoxDep.TabIndex = 7
        Me.TextBoxDep.Text = "Departement :"
        '
        'LabelCity
        '
        Me.LabelCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.Location = New System.Drawing.Point(130, 168)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(86, 19)
        Me.LabelCity.TabIndex = 6
        Me.LabelCity.Text = "Patientez..."
        '
        'TextBoxVille
        '
        Me.TextBoxVille.AutoSize = True
        Me.TextBoxVille.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVille.Location = New System.Drawing.Point(7, 168)
        Me.TextBoxVille.Name = "TextBoxVille"
        Me.TextBoxVille.Size = New System.Drawing.Size(47, 19)
        Me.TextBoxVille.TabIndex = 5
        Me.TextBoxVille.Text = "Ville :"
        '
        'LabelAddress
        '
        Me.LabelAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(129, 103)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(86, 19)
        Me.LabelAddress.TabIndex = 4
        Me.LabelAddress.Text = "Patientez..."
        '
        'buttonClear
        '
        Me.buttonClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClear.Location = New System.Drawing.Point(477, 229)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(78, 23)
        Me.buttonClear.TabIndex = 3
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'TextBoxadresse
        '
        Me.TextBoxadresse.AutoSize = True
        Me.TextBoxadresse.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxadresse.Location = New System.Drawing.Point(6, 103)
        Me.TextBoxadresse.Name = "TextBoxadresse"
        Me.TextBoxadresse.Size = New System.Drawing.Size(74, 19)
        Me.TextBoxadresse.TabIndex = 2
        Me.TextBoxadresse.Text = "Address :"
        '
        'LabelName
        '
        Me.LabelName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(129, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(86, 19)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Patientez..."
        '
        'TextBoxNom
        '
        Me.TextBoxNom.AutoSize = True
        Me.TextBoxNom.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.Location = New System.Drawing.Point(6, 28)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(54, 19)
        Me.TextBoxNom.TabIndex = 0
        Me.TextBoxNom.Text = "NOM :"
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelID)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Location = New System.Drawing.Point(503, 19)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(220, 245)
        Me.GroupBoxImage.TabIndex = 1
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Image and ID"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(24, 201)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(129, 17)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "ID : ____________"
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(18, 24)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxUserImage.TabIndex = 0
        Me.PictureBoxUserImage.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 6)
        Me.Panel3.TabIndex = 0
        '
        'PanelRegistrationandEditUserData
        '
        Me.PanelRegistrationandEditUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.PanelReadingTagProcess)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox1)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.buttonClearForm)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.buttonSave)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxDep2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxVille2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxadresse2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxNom2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label5)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label7)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label9)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Panel4)
        Me.PanelRegistrationandEditUserData.Location = New System.Drawing.Point(460, 28)
        Me.PanelRegistrationandEditUserData.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegistrationandEditUserData.Name = "PanelRegistrationandEditUserData"
        Me.PanelRegistrationandEditUserData.Size = New System.Drawing.Size(784, 672)
        Me.PanelRegistrationandEditUserData.TabIndex = 8
        '
        'PanelReadingTagProcess
        '
        Me.PanelReadingTagProcess.Controls.Add(Me.PictureBox1)
        Me.PanelReadingTagProcess.Controls.Add(Me.buttonCloseReadingTag)
        Me.PanelReadingTagProcess.Controls.Add(Me.Label6)
        Me.PanelReadingTagProcess.Location = New System.Drawing.Point(505, 15)
        Me.PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        Me.PanelReadingTagProcess.Size = New System.Drawing.Size(264, 165)
        Me.PanelReadingTagProcess.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.arduino_RFID_UI.My.Resources.Resources._762
        Me.PictureBox1.Location = New System.Drawing.Point(62, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'buttonCloseReadingTag
        '
        Me.buttonCloseReadingTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.buttonCloseReadingTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonCloseReadingTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCloseReadingTag.Location = New System.Drawing.Point(236, 5)
        Me.buttonCloseReadingTag.Name = "buttonCloseReadingTag"
        Me.buttonCloseReadingTag.Size = New System.Drawing.Size(25, 37)
        Me.buttonCloseReadingTag.TabIndex = 1
        Me.buttonCloseReadingTag.Text = "X"
        Me.buttonCloseReadingTag.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Lecture de la carte..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox3.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(759, 381)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enregistrements"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(606, 122)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(124, 138)
        Me.PictureBoxImagePreview.TabIndex = 5
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 81)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(555, 263)
        Me.DataGridView1.TabIndex = 4
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(581, 40)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(130, 21)
        Me.CheckBoxByID.TabIndex = 3
        Me.CheckBoxByID.Text = "Chercher par ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Location = New System.Drawing.Point(412, 40)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(144, 21)
        Me.CheckBoxByName.TabIndex = 2
        Me.CheckBoxByName.Text = "Chercher par nom"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(146, 38)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(243, 22)
        Me.TextBoxSearch.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rechercher ici"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 208)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "photo"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(27, 32)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(151, 149)
        Me.PictureBoxImageInput.TabIndex = 24
        Me.PictureBoxImageInput.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelGetID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buttonScanID)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 135)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recuperer ID"
        '
        'LabelGetID
        '
        Me.LabelGetID.AutoSize = True
        Me.LabelGetID.Location = New System.Drawing.Point(33, 103)
        Me.LabelGetID.Name = "LabelGetID"
        Me.LabelGetID.Size = New System.Drawing.Size(108, 17)
        Me.LabelGetID.TabIndex = 25
        Me.LabelGetID.Text = ".____________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ID"
        '
        'buttonScanID
        '
        Me.buttonScanID.Location = New System.Drawing.Point(33, 40)
        Me.buttonScanID.Name = "buttonScanID"
        Me.buttonScanID.Size = New System.Drawing.Size(108, 23)
        Me.buttonScanID.TabIndex = 23
        Me.buttonScanID.Text = "Scanner"
        Me.buttonScanID.UseVisualStyleBackColor = True
        '
        'buttonClearForm
        '
        Me.buttonClearForm.Location = New System.Drawing.Point(156, 206)
        Me.buttonClearForm.Name = "buttonClearForm"
        Me.buttonClearForm.Size = New System.Drawing.Size(132, 31)
        Me.buttonClearForm.TabIndex = 21
        Me.buttonClearForm.Text = "Effacer"
        Me.buttonClearForm.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Location = New System.Drawing.Point(11, 206)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(132, 31)
        Me.buttonSave.TabIndex = 20
        Me.buttonSave.Text = "Enregistrer"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'TextBoxDep2
        '
        Me.TextBoxDep2.Location = New System.Drawing.Point(156, 129)
        Me.TextBoxDep2.Name = "TextBoxDep2"
        Me.TextBoxDep2.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxDep2.TabIndex = 19
        '
        'TextBoxVille2
        '
        Me.TextBoxVille2.Location = New System.Drawing.Point(156, 87)
        Me.TextBoxVille2.Name = "TextBoxVille2"
        Me.TextBoxVille2.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxVille2.TabIndex = 18
        '
        'TextBoxadresse2
        '
        Me.TextBoxadresse2.Location = New System.Drawing.Point(156, 56)
        Me.TextBoxadresse2.Name = "TextBoxadresse2"
        Me.TextBoxadresse2.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxadresse2.TabIndex = 17
        '
        'TextBoxNom2
        '
        Me.TextBoxNom2.Location = New System.Drawing.Point(155, 20)
        Me.TextBoxNom2.Name = "TextBoxNom2"
        Me.TextBoxNom2.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxNom2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Departement :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ville :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "NOM :"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 6)
        Me.Panel4.TabIndex = 0
        '
        'PictureBoxSttusConnect
        '
        Me.PictureBoxSttusConnect.Image = Global.arduino_RFID_UI.My.Resources.Resources.Disconnect
        Me.PictureBoxSttusConnect.Location = New System.Drawing.Point(687, 5)
        Me.PictureBoxSttusConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxSttusConnect.Name = "PictureBoxSttusConnect"
        Me.PictureBoxSttusConnect.Size = New System.Drawing.Size(16, 15)
        Me.PictureBoxSttusConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSttusConnect.TabIndex = 3
        Me.PictureBoxSttusConnect.TabStop = False
        Me.PictureBoxSttusConnect.UseWaitCursor = True
        '
        'buttonConnection
        '
        Me.buttonConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.buttonConnection.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonConnection.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_Computer__Computer_Hardware_USB_Port_Connection_4064143_1_
        Me.buttonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonConnection.Location = New System.Drawing.Point(29, 238)
        Me.buttonConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonConnection.Name = "buttonConnection"
        Me.buttonConnection.Size = New System.Drawing.Size(403, 44)
        Me.buttonConnection.TabIndex = 1
        Me.buttonConnection.Text = "Connexion"
        Me.buttonConnection.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.SelectToutToolStripMenuItem, Me.EffacerSelectionsToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.RefreshToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 114)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_Bin_2202256
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.SupprimerToolStripMenuItem.Text = "supprimer"
        '
        'SelectToutToolStripMenuItem
        '
        Me.SelectToutToolStripMenuItem.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_icon_27_one_finger_click_315298
        Me.SelectToutToolStripMenuItem.Name = "SelectToutToolStripMenuItem"
        Me.SelectToutToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.SelectToutToolStripMenuItem.Text = "selectionner tout"
        '
        'EffacerSelectionsToolStripMenuItem
        '
        Me.EffacerSelectionsToolStripMenuItem.Image = Global.arduino_RFID_UI.My.Resources.Resources.iconfinder_check_circle_outline_326568
        Me.EffacerSelectionsToolStripMenuItem.Name = "EffacerSelectionsToolStripMenuItem"
        Me.EffacerSelectionsToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.EffacerSelectionsToolStripMenuItem.Text = "effacer selections"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(194, 6)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = Global.arduino_RFID_UI.My.Resources.Resources._822
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(197, 26)
        Me.RefreshToolStripMenuItem1.Text = "refresh"
        '
        'TimerSerialIn
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 711)
        Me.Controls.Add(Me.PanelRegistrationandEditUserData)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.PictureBoxSttusConnect)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.buttonConnection)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelConnection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "ArduinoUID"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegistrationandEditUserData.ResumeLayout(False)
        Me.PanelRegistrationandEditUserData.PerformLayout()
        Me.PanelReadingTagProcess.ResumeLayout(False)
        Me.PanelReadingTagProcess.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxSttusConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents buttonConnection As Button
    Friend WithEvents buttonUserData As Button
    Friend WithEvents buttonRegistration As Button
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents LabelConnectionStatus As Label
    Friend WithEvents PictureBoxSttusConnect As PictureBox
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents buttonScanPort As Button
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents TextBoxDep As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents TextBoxVille As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents buttonClear As Button
    Friend WithEvents TextBoxadresse As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TextBoxNom As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents PanelRegistrationandEditUserData As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelGetID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonScanID As Button
    Friend WithEvents buttonClearForm As Button
    Friend WithEvents buttonSave As Button
    Friend WithEvents TextBoxDep2 As TextBox
    Friend WithEvents TextBoxVille2 As TextBox
    Friend WithEvents TextBoxadresse2 As TextBox
    Friend WithEvents TextBoxNom2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffacerSelectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonCloseReadingTag As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
