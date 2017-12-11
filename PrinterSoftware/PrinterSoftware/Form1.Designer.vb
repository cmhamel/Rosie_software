<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ImportedGcode = New System.Windows.Forms.TextBox()
        Me.ImportGcode = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolSelections = New System.Windows.Forms.CheckedListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Optomec_x_offset = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.OffsetsAndOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.Robot1_dwell_time = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.Robot1_printing_speed = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.FDMRight_dwell_time = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.FDMRight_printing_speed = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.FDMLeft_dwell_time = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.FDMLeft_printing_speed = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.DIWRight_dwell_time = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.DIWRight_printing_speed = New System.Windows.Forms.TextBox()
        Me.UVCureSpeed = New System.Windows.Forms.TextBox()
        Me.DIWLeft_dwell_time = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.DIWLeft_printing_speed = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Optomec_dwell_time = New System.Windows.Forms.TextBox()
        Me.NonPrintingSpeed = New System.Windows.Forms.TextBox()
        Me.Optomec_printing_speed = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Robot1_y_offset = New System.Windows.Forms.TextBox()
        Me.Robot1_x_offset = New System.Windows.Forms.TextBox()
        Me.FDMRight_y_offset = New System.Windows.Forms.TextBox()
        Me.FDMRight_x_offset = New System.Windows.Forms.TextBox()
        Me.FDMLeft_y_offset = New System.Windows.Forms.TextBox()
        Me.FDMLeft_x_offset = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.DIWRight_y_offset = New System.Windows.Forms.TextBox()
        Me.DIWRight_x_offset = New System.Windows.Forms.TextBox()
        Me.ZZ3_offset = New System.Windows.Forms.TextBox()
        Me.DIWLeft_y_offset = New System.Windows.Forms.TextBox()
        Me.DIWLeft_x_offset = New System.Windows.Forms.TextBox()
        Me.Optomec_z_offset = New System.Windows.Forms.TextBox()
        Me.Optomec_y_offset = New System.Windows.Forms.TextBox()
        Me.ProcessGcode = New System.Windows.Forms.Button()
        Me.ProcessedGcode = New System.Windows.Forms.TextBox()
        Me.ExportGCode = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FDMLeft_stepper_extruder = New System.Windows.Forms.TextBox()
        Me.FDMLeft_retraction_steps = New System.Windows.Forms.TextBox()
        Me.FDMRight_retraction_steps = New System.Windows.Forms.TextBox()
        Me.FDMRight_stepper_extruder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Inkjet_layer_thickness = New System.Windows.Forms.TextBox()
        Me.Inkjet_layers_per_pass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StartingZHeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StartInkjet = New System.Windows.Forms.Button()
        Me.KillInkjet = New System.Windows.Forms.Button()
        Me.ExportRobotArmCode = New System.Windows.Forms.Button()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.ConnectController = New System.Windows.Forms.Button()
        Me.HomeX = New System.Windows.Forms.Button()
        Me.MoveXLeft = New System.Windows.Forms.Button()
        Me.MoveXRight = New System.Windows.Forms.Button()
        Me.HomeYAxis = New System.Windows.Forms.Button()
        Me.MoveYForward = New System.Windows.Forms.Button()
        Me.MoveYBack = New System.Windows.Forms.Button()
        Me.HomeOptomecAxis = New System.Windows.Forms.Button()
        Me.MoveOptomecDown = New System.Windows.Forms.Button()
        Me.MoveOptomecUp = New System.Windows.Forms.Button()
        Me.EnableXAxis = New System.Windows.Forms.Button()
        Me.EnableYAxis = New System.Windows.Forms.Button()
        Me.EnableOptomec = New System.Windows.Forms.Button()
        Me.EnableExtrusion = New System.Windows.Forms.Button()
        Me.HomeExtrusion = New System.Windows.Forms.Button()
        Me.MoveExtrusionUp = New System.Windows.Forms.Button()
        Me.MoveExtrusionDown = New System.Windows.Forms.Button()
        Me.EnableInkjet = New System.Windows.Forms.Button()
        Me.HomeInkjet = New System.Windows.Forms.Button()
        Me.MoveInkjetUp = New System.Windows.Forms.Button()
        Me.MoveInkjetDown = New System.Windows.Forms.Button()
        Me.RobotWindow_Button = New System.Windows.Forms.Button()
        Me.OffsetsAndOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImportedGcode
        '
        Me.ImportedGcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ImportedGcode.Location = New System.Drawing.Point(16, 50)
        Me.ImportedGcode.Margin = New System.Windows.Forms.Padding(4)
        Me.ImportedGcode.Multiline = True
        Me.ImportedGcode.Name = "ImportedGcode"
        Me.ImportedGcode.ReadOnly = True
        Me.ImportedGcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ImportedGcode.Size = New System.Drawing.Size(399, 155)
        Me.ImportedGcode.TabIndex = 0
        '
        'ImportGcode
        '
        Me.ImportGcode.Location = New System.Drawing.Point(16, 15)
        Me.ImportGcode.Margin = New System.Windows.Forms.Padding(4)
        Me.ImportGcode.Name = "ImportGcode"
        Me.ImportGcode.Size = New System.Drawing.Size(400, 30)
        Me.ImportGcode.TabIndex = 1
        Me.ImportGcode.Text = "Import Gcode"
        Me.ImportGcode.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolSelections
        '
        Me.ToolSelections.CheckOnClick = True
        Me.ToolSelections.FormattingEnabled = True
        Me.ToolSelections.Items.AddRange(New Object() {"Optomec", "Photonic Cure", "FDM Left", "FDM Right", "DIW Left", "DIW Left UV Cure?", "DIW Right", "DIW Right UV Cure?", "Inkjet", "6 Axis Arm"})
        Me.ToolSelections.Location = New System.Drawing.Point(16, 220)
        Me.ToolSelections.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolSelections.Name = "ToolSelections"
        Me.ToolSelections.Size = New System.Drawing.Size(399, 242)
        Me.ToolSelections.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(893, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1033, 280)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(199, 4)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(113, 22)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = "Y Offset"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(86, 4)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 22)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "X Offset"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(4, 4)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 22)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Tool"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(328, 4)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(108, 22)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.Text = "Z Offset"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(4, 48)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(74, 22)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = "Optomec"
        '
        'Optomec_x_offset
        '
        Me.Optomec_x_offset.Enabled = False
        Me.Optomec_x_offset.Location = New System.Drawing.Point(86, 48)
        Me.Optomec_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Optomec_x_offset.Name = "Optomec_x_offset"
        Me.Optomec_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.Optomec_x_offset.TabIndex = 5
        Me.Optomec_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(4, 91)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(74, 22)
        Me.TextBox10.TabIndex = 8
        Me.TextBox10.Text = "DIW Left"
        '
        'TextBox14
        '
        Me.TextBox14.Enabled = False
        Me.TextBox14.Location = New System.Drawing.Point(4, 130)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(74, 22)
        Me.TextBox14.TabIndex = 12
        Me.TextBox14.Text = "DIW Right"
        '
        'TextBox18
        '
        Me.TextBox18.Enabled = False
        Me.TextBox18.Location = New System.Drawing.Point(4, 169)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(74, 22)
        Me.TextBox18.TabIndex = 16
        Me.TextBox18.Text = "FDM Left"
        '
        'TextBox22
        '
        Me.TextBox22.Enabled = False
        Me.TextBox22.Location = New System.Drawing.Point(4, 207)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(74, 22)
        Me.TextBox22.TabIndex = 20
        Me.TextBox22.Text = "FDM Right"
        '
        'TextBox26
        '
        Me.TextBox26.Enabled = False
        Me.TextBox26.Location = New System.Drawing.Point(4, 245)
        Me.TextBox26.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(74, 22)
        Me.TextBox26.TabIndex = 24
        Me.TextBox26.Text = "6 Axis Arm"
        '
        'OffsetsAndOptions
        '
        Me.OffsetsAndOptions.ColumnCount = 8
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.28571!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.71429!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.OffsetsAndOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox58, 7, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.Robot1_dwell_time, 6, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox56, 5, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.Robot1_printing_speed, 4, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox54, 7, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMRight_dwell_time, 6, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox52, 5, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMRight_printing_speed, 4, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox50, 7, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMLeft_dwell_time, 6, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox48, 5, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMLeft_printing_speed, 4, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox46, 7, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWRight_dwell_time, 6, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox44, 5, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWRight_printing_speed, 4, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.UVCureSpeed, 7, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWLeft_dwell_time, 6, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox40, 5, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWLeft_printing_speed, 4, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox38, 7, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.Optomec_dwell_time, 6, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.NonPrintingSpeed, 5, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.Optomec_printing_speed, 4, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox34, 7, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox33, 6, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox32, 5, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox31, 4, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox29, 3, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox25, 3, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox21, 3, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.Robot1_y_offset, 2, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.Robot1_x_offset, 1, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMRight_y_offset, 2, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMRight_x_offset, 1, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMLeft_y_offset, 2, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.FDMLeft_x_offset, 1, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox17, 3, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWRight_y_offset, 2, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWRight_x_offset, 1, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.ZZ3_offset, 3, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWLeft_y_offset, 2, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.DIWLeft_x_offset, 1, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.Optomec_z_offset, 3, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.Optomec_y_offset, 2, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox26, 0, 6)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox22, 0, 5)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox18, 0, 4)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox14, 0, 3)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox10, 0, 2)
        Me.OffsetsAndOptions.Controls.Add(Me.Optomec_x_offset, 1, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox6, 0, 1)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox5, 3, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox2, 0, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox3, 1, 0)
        Me.OffsetsAndOptions.Controls.Add(Me.TextBox4, 2, 0)
        Me.OffsetsAndOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.OffsetsAndOptions.Location = New System.Drawing.Point(893, 15)
        Me.OffsetsAndOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.OffsetsAndOptions.Name = "OffsetsAndOptions"
        Me.OffsetsAndOptions.RowCount = 7
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.OffsetsAndOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.OffsetsAndOptions.Size = New System.Drawing.Size(1035, 281)
        Me.OffsetsAndOptions.TabIndex = 5
        '
        'TextBox58
        '
        Me.TextBox58.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox58.Enabled = False
        Me.TextBox58.Location = New System.Drawing.Point(857, 245)
        Me.TextBox58.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(133, 22)
        Me.TextBox58.TabIndex = 71
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Robot1_dwell_time
        '
        Me.Robot1_dwell_time.Enabled = False
        Me.Robot1_dwell_time.Location = New System.Drawing.Point(716, 245)
        Me.Robot1_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.Robot1_dwell_time.Name = "Robot1_dwell_time"
        Me.Robot1_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.Robot1_dwell_time.TabIndex = 70
        Me.Robot1_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox56
        '
        Me.TextBox56.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox56.Enabled = False
        Me.TextBox56.Location = New System.Drawing.Point(572, 245)
        Me.TextBox56.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(133, 22)
        Me.TextBox56.TabIndex = 69
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Robot1_printing_speed
        '
        Me.Robot1_printing_speed.Enabled = False
        Me.Robot1_printing_speed.Location = New System.Drawing.Point(452, 245)
        Me.Robot1_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.Robot1_printing_speed.Name = "Robot1_printing_speed"
        Me.Robot1_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.Robot1_printing_speed.TabIndex = 68
        Me.Robot1_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox54
        '
        Me.TextBox54.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox54.Enabled = False
        Me.TextBox54.Location = New System.Drawing.Point(857, 207)
        Me.TextBox54.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(133, 22)
        Me.TextBox54.TabIndex = 67
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_dwell_time
        '
        Me.FDMRight_dwell_time.Enabled = False
        Me.FDMRight_dwell_time.Location = New System.Drawing.Point(716, 207)
        Me.FDMRight_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_dwell_time.Name = "FDMRight_dwell_time"
        Me.FDMRight_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.FDMRight_dwell_time.TabIndex = 66
        Me.FDMRight_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox52
        '
        Me.TextBox52.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox52.Enabled = False
        Me.TextBox52.Location = New System.Drawing.Point(572, 207)
        Me.TextBox52.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(133, 22)
        Me.TextBox52.TabIndex = 65
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_printing_speed
        '
        Me.FDMRight_printing_speed.Enabled = False
        Me.FDMRight_printing_speed.Location = New System.Drawing.Point(452, 207)
        Me.FDMRight_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_printing_speed.Name = "FDMRight_printing_speed"
        Me.FDMRight_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.FDMRight_printing_speed.TabIndex = 64
        Me.FDMRight_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox50
        '
        Me.TextBox50.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox50.Enabled = False
        Me.TextBox50.Location = New System.Drawing.Point(857, 169)
        Me.TextBox50.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(133, 22)
        Me.TextBox50.TabIndex = 63
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMLeft_dwell_time
        '
        Me.FDMLeft_dwell_time.Enabled = False
        Me.FDMLeft_dwell_time.Location = New System.Drawing.Point(716, 169)
        Me.FDMLeft_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_dwell_time.Name = "FDMLeft_dwell_time"
        Me.FDMLeft_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.FDMLeft_dwell_time.TabIndex = 62
        Me.FDMLeft_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox48
        '
        Me.TextBox48.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox48.Enabled = False
        Me.TextBox48.Location = New System.Drawing.Point(572, 169)
        Me.TextBox48.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(133, 22)
        Me.TextBox48.TabIndex = 61
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMLeft_printing_speed
        '
        Me.FDMLeft_printing_speed.Enabled = False
        Me.FDMLeft_printing_speed.Location = New System.Drawing.Point(452, 169)
        Me.FDMLeft_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_printing_speed.Name = "FDMLeft_printing_speed"
        Me.FDMLeft_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.FDMLeft_printing_speed.TabIndex = 60
        Me.FDMLeft_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox46
        '
        Me.TextBox46.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox46.Enabled = False
        Me.TextBox46.Location = New System.Drawing.Point(857, 130)
        Me.TextBox46.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(133, 22)
        Me.TextBox46.TabIndex = 59
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWRight_dwell_time
        '
        Me.DIWRight_dwell_time.Enabled = False
        Me.DIWRight_dwell_time.Location = New System.Drawing.Point(716, 130)
        Me.DIWRight_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWRight_dwell_time.Name = "DIWRight_dwell_time"
        Me.DIWRight_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.DIWRight_dwell_time.TabIndex = 58
        Me.DIWRight_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox44
        '
        Me.TextBox44.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox44.Enabled = False
        Me.TextBox44.Location = New System.Drawing.Point(572, 130)
        Me.TextBox44.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(133, 22)
        Me.TextBox44.TabIndex = 57
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWRight_printing_speed
        '
        Me.DIWRight_printing_speed.Enabled = False
        Me.DIWRight_printing_speed.Location = New System.Drawing.Point(452, 130)
        Me.DIWRight_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWRight_printing_speed.Name = "DIWRight_printing_speed"
        Me.DIWRight_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.DIWRight_printing_speed.TabIndex = 56
        Me.DIWRight_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UVCureSpeed
        '
        Me.UVCureSpeed.Enabled = False
        Me.UVCureSpeed.Location = New System.Drawing.Point(857, 91)
        Me.UVCureSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.UVCureSpeed.Name = "UVCureSpeed"
        Me.UVCureSpeed.Size = New System.Drawing.Size(133, 22)
        Me.UVCureSpeed.TabIndex = 55
        Me.UVCureSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWLeft_dwell_time
        '
        Me.DIWLeft_dwell_time.Enabled = False
        Me.DIWLeft_dwell_time.Location = New System.Drawing.Point(716, 91)
        Me.DIWLeft_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWLeft_dwell_time.Name = "DIWLeft_dwell_time"
        Me.DIWLeft_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.DIWLeft_dwell_time.TabIndex = 54
        Me.DIWLeft_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox40
        '
        Me.TextBox40.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox40.Enabled = False
        Me.TextBox40.Location = New System.Drawing.Point(572, 91)
        Me.TextBox40.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(133, 22)
        Me.TextBox40.TabIndex = 53
        Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWLeft_printing_speed
        '
        Me.DIWLeft_printing_speed.Enabled = False
        Me.DIWLeft_printing_speed.Location = New System.Drawing.Point(452, 91)
        Me.DIWLeft_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWLeft_printing_speed.Name = "DIWLeft_printing_speed"
        Me.DIWLeft_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.DIWLeft_printing_speed.TabIndex = 52
        Me.DIWLeft_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox38
        '
        Me.TextBox38.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox38.Enabled = False
        Me.TextBox38.Location = New System.Drawing.Point(857, 48)
        Me.TextBox38.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(133, 22)
        Me.TextBox38.TabIndex = 51
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Optomec_dwell_time
        '
        Me.Optomec_dwell_time.Enabled = False
        Me.Optomec_dwell_time.Location = New System.Drawing.Point(716, 48)
        Me.Optomec_dwell_time.Margin = New System.Windows.Forms.Padding(4)
        Me.Optomec_dwell_time.Name = "Optomec_dwell_time"
        Me.Optomec_dwell_time.Size = New System.Drawing.Size(132, 22)
        Me.Optomec_dwell_time.TabIndex = 50
        Me.Optomec_dwell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NonPrintingSpeed
        '
        Me.NonPrintingSpeed.Location = New System.Drawing.Point(572, 48)
        Me.NonPrintingSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.NonPrintingSpeed.Name = "NonPrintingSpeed"
        Me.NonPrintingSpeed.Size = New System.Drawing.Size(133, 22)
        Me.NonPrintingSpeed.TabIndex = 49
        Me.NonPrintingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Optomec_printing_speed
        '
        Me.Optomec_printing_speed.Enabled = False
        Me.Optomec_printing_speed.Location = New System.Drawing.Point(452, 48)
        Me.Optomec_printing_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.Optomec_printing_speed.Name = "Optomec_printing_speed"
        Me.Optomec_printing_speed.Size = New System.Drawing.Size(108, 22)
        Me.Optomec_printing_speed.TabIndex = 48
        Me.Optomec_printing_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.Enabled = False
        Me.TextBox34.Location = New System.Drawing.Point(857, 4)
        Me.TextBox34.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(132, 22)
        Me.TextBox34.TabIndex = 47
        Me.TextBox34.Text = "UV Cure Speed"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.Enabled = False
        Me.TextBox33.Location = New System.Drawing.Point(716, 4)
        Me.TextBox33.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(132, 22)
        Me.TextBox33.TabIndex = 46
        Me.TextBox33.Text = "Dwell Time"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.Enabled = False
        Me.TextBox32.Location = New System.Drawing.Point(572, 4)
        Me.TextBox32.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(133, 22)
        Me.TextBox32.TabIndex = 45
        Me.TextBox32.Text = "Non-Printing Speed"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.Enabled = False
        Me.TextBox31.Location = New System.Drawing.Point(452, 4)
        Me.TextBox31.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(108, 22)
        Me.TextBox31.TabIndex = 44
        Me.TextBox31.Text = "Printing Speed"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox29.Enabled = False
        Me.TextBox29.Location = New System.Drawing.Point(328, 245)
        Me.TextBox29.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(108, 22)
        Me.TextBox29.TabIndex = 43
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox25.Enabled = False
        Me.TextBox25.Location = New System.Drawing.Point(328, 207)
        Me.TextBox25.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(108, 22)
        Me.TextBox25.TabIndex = 42
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox21.Enabled = False
        Me.TextBox21.Location = New System.Drawing.Point(328, 169)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(108, 22)
        Me.TextBox21.TabIndex = 41
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Robot1_y_offset
        '
        Me.Robot1_y_offset.Enabled = False
        Me.Robot1_y_offset.Location = New System.Drawing.Point(199, 245)
        Me.Robot1_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Robot1_y_offset.Name = "Robot1_y_offset"
        Me.Robot1_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.Robot1_y_offset.TabIndex = 40
        Me.Robot1_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Robot1_x_offset
        '
        Me.Robot1_x_offset.Enabled = False
        Me.Robot1_x_offset.Location = New System.Drawing.Point(86, 245)
        Me.Robot1_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Robot1_x_offset.Name = "Robot1_x_offset"
        Me.Robot1_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.Robot1_x_offset.TabIndex = 39
        Me.Robot1_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_y_offset
        '
        Me.FDMRight_y_offset.Enabled = False
        Me.FDMRight_y_offset.Location = New System.Drawing.Point(199, 207)
        Me.FDMRight_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_y_offset.Name = "FDMRight_y_offset"
        Me.FDMRight_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.FDMRight_y_offset.TabIndex = 37
        Me.FDMRight_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_x_offset
        '
        Me.FDMRight_x_offset.Enabled = False
        Me.FDMRight_x_offset.Location = New System.Drawing.Point(86, 207)
        Me.FDMRight_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_x_offset.Name = "FDMRight_x_offset"
        Me.FDMRight_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.FDMRight_x_offset.TabIndex = 36
        Me.FDMRight_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMLeft_y_offset
        '
        Me.FDMLeft_y_offset.Enabled = False
        Me.FDMLeft_y_offset.Location = New System.Drawing.Point(199, 169)
        Me.FDMLeft_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_y_offset.Name = "FDMLeft_y_offset"
        Me.FDMLeft_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.FDMLeft_y_offset.TabIndex = 34
        Me.FDMLeft_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMLeft_x_offset
        '
        Me.FDMLeft_x_offset.Enabled = False
        Me.FDMLeft_x_offset.Location = New System.Drawing.Point(86, 169)
        Me.FDMLeft_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_x_offset.Name = "FDMLeft_x_offset"
        Me.FDMLeft_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.FDMLeft_x_offset.TabIndex = 33
        Me.FDMLeft_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox17.Enabled = False
        Me.TextBox17.Location = New System.Drawing.Point(328, 130)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(108, 22)
        Me.TextBox17.TabIndex = 32
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWRight_y_offset
        '
        Me.DIWRight_y_offset.Enabled = False
        Me.DIWRight_y_offset.Location = New System.Drawing.Point(199, 130)
        Me.DIWRight_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWRight_y_offset.Name = "DIWRight_y_offset"
        Me.DIWRight_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.DIWRight_y_offset.TabIndex = 31
        Me.DIWRight_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWRight_x_offset
        '
        Me.DIWRight_x_offset.Enabled = False
        Me.DIWRight_x_offset.Location = New System.Drawing.Point(86, 130)
        Me.DIWRight_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWRight_x_offset.Name = "DIWRight_x_offset"
        Me.DIWRight_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.DIWRight_x_offset.TabIndex = 30
        Me.DIWRight_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZZ3_offset
        '
        Me.ZZ3_offset.Enabled = False
        Me.ZZ3_offset.Location = New System.Drawing.Point(328, 91)
        Me.ZZ3_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.ZZ3_offset.Name = "ZZ3_offset"
        Me.ZZ3_offset.Size = New System.Drawing.Size(108, 22)
        Me.ZZ3_offset.TabIndex = 29
        Me.ZZ3_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWLeft_y_offset
        '
        Me.DIWLeft_y_offset.Enabled = False
        Me.DIWLeft_y_offset.Location = New System.Drawing.Point(199, 91)
        Me.DIWLeft_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWLeft_y_offset.Name = "DIWLeft_y_offset"
        Me.DIWLeft_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.DIWLeft_y_offset.TabIndex = 28
        Me.DIWLeft_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIWLeft_x_offset
        '
        Me.DIWLeft_x_offset.Enabled = False
        Me.DIWLeft_x_offset.Location = New System.Drawing.Point(86, 91)
        Me.DIWLeft_x_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.DIWLeft_x_offset.Name = "DIWLeft_x_offset"
        Me.DIWLeft_x_offset.Size = New System.Drawing.Size(104, 22)
        Me.DIWLeft_x_offset.TabIndex = 27
        Me.DIWLeft_x_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Optomec_z_offset
        '
        Me.Optomec_z_offset.Enabled = False
        Me.Optomec_z_offset.Location = New System.Drawing.Point(328, 48)
        Me.Optomec_z_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Optomec_z_offset.Name = "Optomec_z_offset"
        Me.Optomec_z_offset.Size = New System.Drawing.Size(108, 22)
        Me.Optomec_z_offset.TabIndex = 26
        Me.Optomec_z_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Optomec_y_offset
        '
        Me.Optomec_y_offset.Enabled = False
        Me.Optomec_y_offset.Location = New System.Drawing.Point(199, 48)
        Me.Optomec_y_offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Optomec_y_offset.Name = "Optomec_y_offset"
        Me.Optomec_y_offset.Size = New System.Drawing.Size(113, 22)
        Me.Optomec_y_offset.TabIndex = 25
        Me.Optomec_y_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProcessGcode
        '
        Me.ProcessGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ProcessGcode.Location = New System.Drawing.Point(1936, 14)
        Me.ProcessGcode.Margin = New System.Windows.Forms.Padding(4)
        Me.ProcessGcode.Name = "ProcessGcode"
        Me.ProcessGcode.Size = New System.Drawing.Size(479, 282)
        Me.ProcessGcode.TabIndex = 10
        Me.ProcessGcode.Text = "Process Gcode"
        Me.ProcessGcode.UseVisualStyleBackColor = True
        '
        'ProcessedGcode
        '
        Me.ProcessedGcode.Location = New System.Drawing.Point(1916, 340)
        Me.ProcessedGcode.Margin = New System.Windows.Forms.Padding(4)
        Me.ProcessedGcode.Multiline = True
        Me.ProcessedGcode.Name = "ProcessedGcode"
        Me.ProcessedGcode.ReadOnly = True
        Me.ProcessedGcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ProcessedGcode.Size = New System.Drawing.Size(501, 422)
        Me.ProcessedGcode.TabIndex = 11
        '
        'ExportGCode
        '
        Me.ExportGCode.Location = New System.Drawing.Point(1405, 303)
        Me.ExportGCode.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportGCode.Name = "ExportGCode"
        Me.ExportGCode.Size = New System.Drawing.Size(503, 30)
        Me.ExportGCode.TabIndex = 12
        Me.ExportGCode.Text = "Export Gcode"
        Me.ExportGCode.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(897, 634)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(432, 292)
        Me.TextBox7.TabIndex = 13
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(897, 306)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(432, 292)
        Me.TextBox8.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(911, 645)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "FDM Left Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(911, 782)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "FDM Right Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(915, 318)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Inkjet Options"
        '
        'FDMLeft_stepper_extruder
        '
        Me.FDMLeft_stepper_extruder.Enabled = False
        Me.FDMLeft_stepper_extruder.Location = New System.Drawing.Point(915, 705)
        Me.FDMLeft_stepper_extruder.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_stepper_extruder.Name = "FDMLeft_stepper_extruder"
        Me.FDMLeft_stepper_extruder.Size = New System.Drawing.Size(145, 22)
        Me.FDMLeft_stepper_extruder.TabIndex = 18
        Me.FDMLeft_stepper_extruder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMLeft_retraction_steps
        '
        Me.FDMLeft_retraction_steps.Enabled = False
        Me.FDMLeft_retraction_steps.Location = New System.Drawing.Point(1117, 705)
        Me.FDMLeft_retraction_steps.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMLeft_retraction_steps.Name = "FDMLeft_retraction_steps"
        Me.FDMLeft_retraction_steps.Size = New System.Drawing.Size(145, 22)
        Me.FDMLeft_retraction_steps.TabIndex = 19
        Me.FDMLeft_retraction_steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_retraction_steps
        '
        Me.FDMRight_retraction_steps.Enabled = False
        Me.FDMRight_retraction_steps.Location = New System.Drawing.Point(1117, 839)
        Me.FDMRight_retraction_steps.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_retraction_steps.Name = "FDMRight_retraction_steps"
        Me.FDMRight_retraction_steps.Size = New System.Drawing.Size(145, 22)
        Me.FDMRight_retraction_steps.TabIndex = 21
        Me.FDMRight_retraction_steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDMRight_stepper_extruder
        '
        Me.FDMRight_stepper_extruder.Enabled = False
        Me.FDMRight_stepper_extruder.Location = New System.Drawing.Point(915, 839)
        Me.FDMRight_stepper_extruder.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMRight_stepper_extruder.Name = "FDMRight_stepper_extruder"
        Me.FDMRight_stepper_extruder.Size = New System.Drawing.Size(145, 22)
        Me.FDMRight_stepper_extruder.TabIndex = 20
        Me.FDMRight_stepper_extruder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(911, 673)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Stepper Extruder (mm/s)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1113, 673)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Total Retraction Steps"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1113, 809)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total Retraction Steps"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(911, 809)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Stepper Extruder (mm/s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1124, 346)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Layer Thickness"
        '
        'Inkjet_layer_thickness
        '
        Me.Inkjet_layer_thickness.Enabled = False
        Me.Inkjet_layer_thickness.Location = New System.Drawing.Point(1128, 378)
        Me.Inkjet_layer_thickness.Margin = New System.Windows.Forms.Padding(4)
        Me.Inkjet_layer_thickness.Name = "Inkjet_layer_thickness"
        Me.Inkjet_layer_thickness.Size = New System.Drawing.Size(112, 22)
        Me.Inkjet_layer_thickness.TabIndex = 27
        Me.Inkjet_layer_thickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Inkjet_layers_per_pass
        '
        Me.Inkjet_layers_per_pass.Enabled = False
        Me.Inkjet_layers_per_pass.Location = New System.Drawing.Point(919, 378)
        Me.Inkjet_layers_per_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.Inkjet_layers_per_pass.Name = "Inkjet_layers_per_pass"
        Me.Inkjet_layers_per_pass.Size = New System.Drawing.Size(112, 22)
        Me.Inkjet_layers_per_pass.TabIndex = 29
        Me.Inkjet_layers_per_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(915, 346)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Layers Per Pass"
        '
        'SaveFileDialog1
        '
        '
        'StartingZHeight
        '
        Me.StartingZHeight.Enabled = False
        Me.StartingZHeight.Location = New System.Drawing.Point(919, 492)
        Me.StartingZHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.StartingZHeight.Name = "StartingZHeight"
        Me.StartingZHeight.Size = New System.Drawing.Size(112, 22)
        Me.StartingZHeight.TabIndex = 31
        Me.StartingZHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(915, 460)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Starting Zheight"
        '
        'StartInkjet
        '
        Me.StartInkjet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.StartInkjet.Location = New System.Drawing.Point(1125, 455)
        Me.StartInkjet.Margin = New System.Windows.Forms.Padding(4)
        Me.StartInkjet.Name = "StartInkjet"
        Me.StartInkjet.Size = New System.Drawing.Size(180, 60)
        Me.StartInkjet.TabIndex = 32
        Me.StartInkjet.Text = "Start Inkjet"
        Me.StartInkjet.UseVisualStyleBackColor = True
        '
        'KillInkjet
        '
        Me.KillInkjet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.KillInkjet.Location = New System.Drawing.Point(1128, 539)
        Me.KillInkjet.Margin = New System.Windows.Forms.Padding(4)
        Me.KillInkjet.Name = "KillInkjet"
        Me.KillInkjet.Size = New System.Drawing.Size(180, 60)
        Me.KillInkjet.TabIndex = 33
        Me.KillInkjet.Text = "Kill Inkjet"
        Me.KillInkjet.UseVisualStyleBackColor = True
        '
        'ExportRobotArmCode
        '
        Me.ExportRobotArmCode.Location = New System.Drawing.Point(1916, 303)
        Me.ExportRobotArmCode.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportRobotArmCode.Name = "ExportRobotArmCode"
        Me.ExportRobotArmCode.Size = New System.Drawing.Size(503, 30)
        Me.ExportRobotArmCode.TabIndex = 37
        Me.ExportRobotArmCode.Text = "Export Robot Arm Code"
        Me.ExportRobotArmCode.UseVisualStyleBackColor = True
        '
        'SaveFileDialog2
        '
        '
        'ConnectController
        '
        Me.ConnectController.Location = New System.Drawing.Point(436, 15)
        Me.ConnectController.Margin = New System.Windows.Forms.Padding(4)
        Me.ConnectController.Name = "ConnectController"
        Me.ConnectController.Size = New System.Drawing.Size(205, 42)
        Me.ConnectController.TabIndex = 38
        Me.ConnectController.Text = "Connect"
        Me.ConnectController.UseVisualStyleBackColor = True
        '
        'HomeX
        '
        Me.HomeX.Location = New System.Drawing.Point(436, 113)
        Me.HomeX.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeX.Name = "HomeX"
        Me.HomeX.Size = New System.Drawing.Size(77, 42)
        Me.HomeX.TabIndex = 39
        Me.HomeX.Text = "Home X Axis"
        Me.HomeX.UseVisualStyleBackColor = True
        '
        'MoveXLeft
        '
        Me.MoveXLeft.Location = New System.Drawing.Point(488, 220)
        Me.MoveXLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveXLeft.Name = "MoveXLeft"
        Me.MoveXLeft.Size = New System.Drawing.Size(105, 42)
        Me.MoveXLeft.TabIndex = 40
        Me.MoveXLeft.Text = "Left"
        Me.MoveXLeft.UseVisualStyleBackColor = True
        '
        'MoveXRight
        '
        Me.MoveXRight.Location = New System.Drawing.Point(693, 220)
        Me.MoveXRight.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveXRight.Name = "MoveXRight"
        Me.MoveXRight.Size = New System.Drawing.Size(105, 42)
        Me.MoveXRight.TabIndex = 41
        Me.MoveXRight.Text = "Right"
        Me.MoveXRight.UseVisualStyleBackColor = True
        '
        'HomeYAxis
        '
        Me.HomeYAxis.Location = New System.Drawing.Point(521, 113)
        Me.HomeYAxis.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeYAxis.Name = "HomeYAxis"
        Me.HomeYAxis.Size = New System.Drawing.Size(77, 42)
        Me.HomeYAxis.TabIndex = 42
        Me.HomeYAxis.Text = "Home Y Axis"
        Me.HomeYAxis.UseVisualStyleBackColor = True
        '
        'MoveYForward
        '
        Me.MoveYForward.Location = New System.Drawing.Point(592, 258)
        Me.MoveYForward.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveYForward.Name = "MoveYForward"
        Me.MoveYForward.Size = New System.Drawing.Size(105, 42)
        Me.MoveYForward.TabIndex = 44
        Me.MoveYForward.Text = "Forward"
        Me.MoveYForward.UseVisualStyleBackColor = True
        '
        'MoveYBack
        '
        Me.MoveYBack.Location = New System.Drawing.Point(592, 172)
        Me.MoveYBack.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveYBack.Name = "MoveYBack"
        Me.MoveYBack.Size = New System.Drawing.Size(105, 42)
        Me.MoveYBack.TabIndex = 43
        Me.MoveYBack.Text = "Back"
        Me.MoveYBack.UseVisualStyleBackColor = True
        '
        'HomeOptomecAxis
        '
        Me.HomeOptomecAxis.Location = New System.Drawing.Point(605, 113)
        Me.HomeOptomecAxis.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeOptomecAxis.Name = "HomeOptomecAxis"
        Me.HomeOptomecAxis.Size = New System.Drawing.Size(80, 42)
        Me.HomeOptomecAxis.TabIndex = 45
        Me.HomeOptomecAxis.Text = "Home Optomec Axis"
        Me.HomeOptomecAxis.UseVisualStyleBackColor = True
        '
        'MoveOptomecDown
        '
        Me.MoveOptomecDown.Location = New System.Drawing.Point(693, 330)
        Me.MoveOptomecDown.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveOptomecDown.Name = "MoveOptomecDown"
        Me.MoveOptomecDown.Size = New System.Drawing.Size(105, 42)
        Me.MoveOptomecDown.TabIndex = 47
        Me.MoveOptomecDown.Text = "Optomec Down"
        Me.MoveOptomecDown.UseVisualStyleBackColor = True
        '
        'MoveOptomecUp
        '
        Me.MoveOptomecUp.Location = New System.Drawing.Point(488, 330)
        Me.MoveOptomecUp.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveOptomecUp.Name = "MoveOptomecUp"
        Me.MoveOptomecUp.Size = New System.Drawing.Size(105, 42)
        Me.MoveOptomecUp.TabIndex = 46
        Me.MoveOptomecUp.Text = "Optomec Up"
        Me.MoveOptomecUp.UseVisualStyleBackColor = True
        '
        'EnableXAxis
        '
        Me.EnableXAxis.Location = New System.Drawing.Point(436, 64)
        Me.EnableXAxis.Margin = New System.Windows.Forms.Padding(4)
        Me.EnableXAxis.Name = "EnableXAxis"
        Me.EnableXAxis.Size = New System.Drawing.Size(77, 42)
        Me.EnableXAxis.TabIndex = 48
        Me.EnableXAxis.Text = "Enable X Axis"
        Me.EnableXAxis.UseVisualStyleBackColor = True
        '
        'EnableYAxis
        '
        Me.EnableYAxis.Location = New System.Drawing.Point(521, 64)
        Me.EnableYAxis.Margin = New System.Windows.Forms.Padding(4)
        Me.EnableYAxis.Name = "EnableYAxis"
        Me.EnableYAxis.Size = New System.Drawing.Size(77, 42)
        Me.EnableYAxis.TabIndex = 49
        Me.EnableYAxis.Text = "Enable Y Axis"
        Me.EnableYAxis.UseVisualStyleBackColor = True
        '
        'EnableOptomec
        '
        Me.EnableOptomec.Location = New System.Drawing.Point(607, 64)
        Me.EnableOptomec.Margin = New System.Windows.Forms.Padding(4)
        Me.EnableOptomec.Name = "EnableOptomec"
        Me.EnableOptomec.Size = New System.Drawing.Size(79, 42)
        Me.EnableOptomec.TabIndex = 50
        Me.EnableOptomec.Text = "Enable Optomec"
        Me.EnableOptomec.UseVisualStyleBackColor = True
        '
        'EnableExtrusion
        '
        Me.EnableExtrusion.Location = New System.Drawing.Point(693, 64)
        Me.EnableExtrusion.Margin = New System.Windows.Forms.Padding(4)
        Me.EnableExtrusion.Name = "EnableExtrusion"
        Me.EnableExtrusion.Size = New System.Drawing.Size(80, 42)
        Me.EnableExtrusion.TabIndex = 51
        Me.EnableExtrusion.Text = "Enable Extrusion"
        Me.EnableExtrusion.UseVisualStyleBackColor = True
        '
        'HomeExtrusion
        '
        Me.HomeExtrusion.Location = New System.Drawing.Point(693, 113)
        Me.HomeExtrusion.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeExtrusion.Name = "HomeExtrusion"
        Me.HomeExtrusion.Size = New System.Drawing.Size(80, 42)
        Me.HomeExtrusion.TabIndex = 52
        Me.HomeExtrusion.Text = "Home Extrusion Axis"
        Me.HomeExtrusion.UseVisualStyleBackColor = True
        '
        'MoveExtrusionUp
        '
        Me.MoveExtrusionUp.Location = New System.Drawing.Point(488, 379)
        Me.MoveExtrusionUp.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveExtrusionUp.Name = "MoveExtrusionUp"
        Me.MoveExtrusionUp.Size = New System.Drawing.Size(105, 42)
        Me.MoveExtrusionUp.TabIndex = 53
        Me.MoveExtrusionUp.Text = "Extrusion Up"
        Me.MoveExtrusionUp.UseVisualStyleBackColor = True
        '
        'MoveExtrusionDown
        '
        Me.MoveExtrusionDown.Location = New System.Drawing.Point(693, 379)
        Me.MoveExtrusionDown.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveExtrusionDown.Name = "MoveExtrusionDown"
        Me.MoveExtrusionDown.Size = New System.Drawing.Size(105, 42)
        Me.MoveExtrusionDown.TabIndex = 54
        Me.MoveExtrusionDown.Text = "Extrusion Down"
        Me.MoveExtrusionDown.UseVisualStyleBackColor = True
        '
        'EnableInkjet
        '
        Me.EnableInkjet.Location = New System.Drawing.Point(781, 64)
        Me.EnableInkjet.Margin = New System.Windows.Forms.Padding(4)
        Me.EnableInkjet.Name = "EnableInkjet"
        Me.EnableInkjet.Size = New System.Drawing.Size(80, 42)
        Me.EnableInkjet.TabIndex = 55
        Me.EnableInkjet.Text = "Enable Inkjet"
        Me.EnableInkjet.UseVisualStyleBackColor = True
        '
        'HomeInkjet
        '
        Me.HomeInkjet.Location = New System.Drawing.Point(781, 113)
        Me.HomeInkjet.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeInkjet.Name = "HomeInkjet"
        Me.HomeInkjet.Size = New System.Drawing.Size(80, 42)
        Me.HomeInkjet.TabIndex = 56
        Me.HomeInkjet.Text = "Home Inkjet Axis"
        Me.HomeInkjet.UseVisualStyleBackColor = True
        '
        'MoveInkjetUp
        '
        Me.MoveInkjetUp.Location = New System.Drawing.Point(488, 428)
        Me.MoveInkjetUp.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveInkjetUp.Name = "MoveInkjetUp"
        Me.MoveInkjetUp.Size = New System.Drawing.Size(105, 42)
        Me.MoveInkjetUp.TabIndex = 57
        Me.MoveInkjetUp.Text = "Inkjet Up"
        Me.MoveInkjetUp.UseVisualStyleBackColor = True
        '
        'MoveInkjetDown
        '
        Me.MoveInkjetDown.Location = New System.Drawing.Point(693, 428)
        Me.MoveInkjetDown.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveInkjetDown.Name = "MoveInkjetDown"
        Me.MoveInkjetDown.Size = New System.Drawing.Size(105, 42)
        Me.MoveInkjetDown.TabIndex = 58
        Me.MoveInkjetDown.Text = "Inkjet Down"
        Me.MoveInkjetDown.UseVisualStyleBackColor = True
        '
        'RobotWindow_Button
        '
        Me.RobotWindow_Button.Location = New System.Drawing.Point(1405, 340)
        Me.RobotWindow_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.RobotWindow_Button.Name = "RobotWindow_Button"
        Me.RobotWindow_Button.Size = New System.Drawing.Size(503, 30)
        Me.RobotWindow_Button.TabIndex = 59
        Me.RobotWindow_Button.Text = "Open Robot Window"
        Me.RobotWindow_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1014)
        Me.Controls.Add(Me.RobotWindow_Button)
        Me.Controls.Add(Me.MoveInkjetDown)
        Me.Controls.Add(Me.MoveInkjetUp)
        Me.Controls.Add(Me.HomeInkjet)
        Me.Controls.Add(Me.EnableInkjet)
        Me.Controls.Add(Me.MoveExtrusionDown)
        Me.Controls.Add(Me.MoveExtrusionUp)
        Me.Controls.Add(Me.HomeExtrusion)
        Me.Controls.Add(Me.EnableExtrusion)
        Me.Controls.Add(Me.EnableOptomec)
        Me.Controls.Add(Me.EnableYAxis)
        Me.Controls.Add(Me.EnableXAxis)
        Me.Controls.Add(Me.MoveOptomecDown)
        Me.Controls.Add(Me.MoveOptomecUp)
        Me.Controls.Add(Me.HomeOptomecAxis)
        Me.Controls.Add(Me.MoveYForward)
        Me.Controls.Add(Me.MoveYBack)
        Me.Controls.Add(Me.HomeYAxis)
        Me.Controls.Add(Me.MoveXRight)
        Me.Controls.Add(Me.MoveXLeft)
        Me.Controls.Add(Me.HomeX)
        Me.Controls.Add(Me.ConnectController)
        Me.Controls.Add(Me.ExportRobotArmCode)
        Me.Controls.Add(Me.KillInkjet)
        Me.Controls.Add(Me.StartInkjet)
        Me.Controls.Add(Me.StartingZHeight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Inkjet_layers_per_pass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Inkjet_layer_thickness)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FDMRight_retraction_steps)
        Me.Controls.Add(Me.FDMRight_stepper_extruder)
        Me.Controls.Add(Me.FDMLeft_retraction_steps)
        Me.Controls.Add(Me.FDMLeft_stepper_extruder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ExportGCode)
        Me.Controls.Add(Me.ProcessedGcode)
        Me.Controls.Add(Me.ProcessGcode)
        Me.Controls.Add(Me.OffsetsAndOptions)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolSelections)
        Me.Controls.Add(Me.ImportGcode)
        Me.Controls.Add(Me.ImportedGcode)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Printer Software"
        Me.OffsetsAndOptions.ResumeLayout(False)
        Me.OffsetsAndOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportedGcode As TextBox
    Friend WithEvents ImportGcode As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolSelections As CheckedListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Optomec_x_offset As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents OffsetsAndOptions As TableLayoutPanel
    Friend WithEvents Robot1_y_offset As TextBox
    Friend WithEvents Robot1_x_offset As TextBox
    Friend WithEvents FDMRight_y_offset As TextBox
    Friend WithEvents FDMRight_x_offset As TextBox
    Friend WithEvents FDMLeft_y_offset As TextBox
    Friend WithEvents FDMLeft_x_offset As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents DIWRight_y_offset As TextBox
    Friend WithEvents DIWRight_x_offset As TextBox
    Friend WithEvents ZZ3_offset As TextBox
    Friend WithEvents DIWLeft_y_offset As TextBox
    Friend WithEvents DIWLeft_x_offset As TextBox
    Friend WithEvents Optomec_z_offset As TextBox
    Friend WithEvents Optomec_y_offset As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents ProcessGcode As Button
    Friend WithEvents ProcessedGcode As TextBox
    Friend WithEvents ExportGCode As Button
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox58 As TextBox
    Friend WithEvents Robot1_dwell_time As TextBox
    Friend WithEvents TextBox56 As TextBox
    Friend WithEvents Robot1_printing_speed As TextBox
    Friend WithEvents TextBox54 As TextBox
    Friend WithEvents FDMRight_dwell_time As TextBox
    Friend WithEvents TextBox52 As TextBox
    Friend WithEvents FDMRight_printing_speed As TextBox
    Friend WithEvents TextBox50 As TextBox
    Friend WithEvents FDMLeft_dwell_time As TextBox
    Friend WithEvents TextBox48 As TextBox
    Friend WithEvents FDMLeft_printing_speed As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents DIWRight_dwell_time As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents DIWRight_printing_speed As TextBox
    Friend WithEvents UVCureSpeed As TextBox
    Friend WithEvents DIWLeft_dwell_time As TextBox
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents DIWLeft_printing_speed As TextBox
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents Optomec_dwell_time As TextBox
    Friend WithEvents NonPrintingSpeed As TextBox
    Friend WithEvents Optomec_printing_speed As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FDMLeft_stepper_extruder As TextBox
    Friend WithEvents FDMLeft_retraction_steps As TextBox
    Friend WithEvents FDMRight_retraction_steps As TextBox
    Friend WithEvents FDMRight_stepper_extruder As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Inkjet_layer_thickness As TextBox
    Friend WithEvents Inkjet_layers_per_pass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents StartingZHeight As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StartInkjet As Button
    Friend WithEvents KillInkjet As Button
    Friend WithEvents ExportRobotArmCode As Button
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents ConnectController As Button
    Friend WithEvents HomeX As Button
    Friend WithEvents MoveXLeft As Button
    Friend WithEvents MoveXRight As Button
    Friend WithEvents HomeYAxis As Button
    Friend WithEvents MoveYForward As Button
    Friend WithEvents MoveYBack As Button
    Friend WithEvents HomeOptomecAxis As Button
    Friend WithEvents MoveOptomecDown As Button
    Friend WithEvents MoveOptomecUp As Button
    Friend WithEvents EnableXAxis As Button
    Friend WithEvents EnableYAxis As Button
    Friend WithEvents EnableOptomec As Button
    Friend WithEvents EnableExtrusion As Button
    Friend WithEvents HomeExtrusion As Button
    Friend WithEvents MoveExtrusionUp As Button
    Friend WithEvents MoveExtrusionDown As Button
    Friend WithEvents EnableInkjet As Button
    Friend WithEvents HomeInkjet As Button
    Friend WithEvents MoveInkjetUp As Button
    Friend WithEvents MoveInkjetDown As Button
    Friend WithEvents RobotWindow_Button As Button
End Class
