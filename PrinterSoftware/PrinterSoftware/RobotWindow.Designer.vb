<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RobotWindow
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
        Me.ProgramStart_Button = New System.Windows.Forms.Button()
        Me.ProgramPause_Button = New System.Windows.Forms.Button()
        Me.ProgramStop_Button = New System.Windows.Forms.Button()
        Me.ProgramContinue_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Function_SPEL_ComboBox = New System.Windows.Forms.ComboBox()
        Me.RobotManager_Button = New System.Windows.Forms.Button()
        Me.IOMonitor_Button = New System.Windows.Forms.Button()
        Me.TaskManager_Button = New System.Windows.Forms.Button()
        Me.Simulator_Button = New System.Windows.Forms.Button()
        Me.ControllerTools_Button = New System.Windows.Forms.Button()
        Me.ProgramMode_Button = New System.Windows.Forms.Button()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.TeachPoint_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LayerAdd_Button = New System.Windows.Forms.Button()
        Me.Layer_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ControlType_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Function_Print_Label = New System.Windows.Forms.Label()
        Me.Function_Print_ComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgramStart_Button
        '
        Me.ProgramStart_Button.Location = New System.Drawing.Point(9, 54)
        Me.ProgramStart_Button.Name = "ProgramStart_Button"
        Me.ProgramStart_Button.Size = New System.Drawing.Size(160, 30)
        Me.ProgramStart_Button.TabIndex = 0
        Me.ProgramStart_Button.Text = "Start"
        Me.ProgramStart_Button.UseVisualStyleBackColor = True
        '
        'ProgramPause_Button
        '
        Me.ProgramPause_Button.Location = New System.Drawing.Point(175, 54)
        Me.ProgramPause_Button.Name = "ProgramPause_Button"
        Me.ProgramPause_Button.Size = New System.Drawing.Size(160, 30)
        Me.ProgramPause_Button.TabIndex = 1
        Me.ProgramPause_Button.Text = "Pause"
        Me.ProgramPause_Button.UseVisualStyleBackColor = True
        '
        'ProgramStop_Button
        '
        Me.ProgramStop_Button.Location = New System.Drawing.Point(9, 90)
        Me.ProgramStop_Button.Name = "ProgramStop_Button"
        Me.ProgramStop_Button.Size = New System.Drawing.Size(160, 30)
        Me.ProgramStop_Button.TabIndex = 2
        Me.ProgramStop_Button.Text = "Stop"
        Me.ProgramStop_Button.UseVisualStyleBackColor = True
        '
        'ProgramContinue_Button
        '
        Me.ProgramContinue_Button.Location = New System.Drawing.Point(175, 90)
        Me.ProgramContinue_Button.Name = "ProgramContinue_Button"
        Me.ProgramContinue_Button.Size = New System.Drawing.Size(160, 30)
        Me.ProgramContinue_Button.TabIndex = 3
        Me.ProgramContinue_Button.Text = "Continue"
        Me.ProgramContinue_Button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Function_SPEL_ComboBox)
        Me.GroupBox1.Controls.Add(Me.ProgramStart_Button)
        Me.GroupBox1.Controls.Add(Me.ProgramContinue_Button)
        Me.GroupBox1.Controls.Add(Me.ProgramPause_Button)
        Me.GroupBox1.Controls.Add(Me.ProgramStop_Button)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 201)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SPEL Program Controls"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Function to start: "
        '
        'Function_SPEL_ComboBox
        '
        Me.Function_SPEL_ComboBox.FormattingEnabled = True
        Me.Function_SPEL_ComboBox.Items.AddRange(New Object() {"main"})
        Me.Function_SPEL_ComboBox.Location = New System.Drawing.Point(130, 24)
        Me.Function_SPEL_ComboBox.Name = "Function_SPEL_ComboBox"
        Me.Function_SPEL_ComboBox.Size = New System.Drawing.Size(153, 24)
        Me.Function_SPEL_ComboBox.TabIndex = 4
        '
        'RobotManager_Button
        '
        Me.RobotManager_Button.Location = New System.Drawing.Point(474, 15)
        Me.RobotManager_Button.Name = "RobotManager_Button"
        Me.RobotManager_Button.Size = New System.Drawing.Size(160, 30)
        Me.RobotManager_Button.TabIndex = 6
        Me.RobotManager_Button.Text = "Robot Manager"
        Me.RobotManager_Button.UseVisualStyleBackColor = True
        '
        'IOMonitor_Button
        '
        Me.IOMonitor_Button.Location = New System.Drawing.Point(474, 64)
        Me.IOMonitor_Button.Name = "IOMonitor_Button"
        Me.IOMonitor_Button.Size = New System.Drawing.Size(160, 30)
        Me.IOMonitor_Button.TabIndex = 7
        Me.IOMonitor_Button.Text = "I/O Monitor"
        Me.IOMonitor_Button.UseVisualStyleBackColor = True
        '
        'TaskManager_Button
        '
        Me.TaskManager_Button.Location = New System.Drawing.Point(474, 113)
        Me.TaskManager_Button.Name = "TaskManager_Button"
        Me.TaskManager_Button.Size = New System.Drawing.Size(160, 30)
        Me.TaskManager_Button.TabIndex = 8
        Me.TaskManager_Button.Text = "Task Manager"
        Me.TaskManager_Button.UseVisualStyleBackColor = True
        '
        'Simulator_Button
        '
        Me.Simulator_Button.Location = New System.Drawing.Point(474, 162)
        Me.Simulator_Button.Name = "Simulator_Button"
        Me.Simulator_Button.Size = New System.Drawing.Size(160, 30)
        Me.Simulator_Button.TabIndex = 9
        Me.Simulator_Button.Text = "Simulator"
        Me.Simulator_Button.UseVisualStyleBackColor = True
        '
        'ControllerTools_Button
        '
        Me.ControllerTools_Button.Location = New System.Drawing.Point(474, 211)
        Me.ControllerTools_Button.Name = "ControllerTools_Button"
        Me.ControllerTools_Button.Size = New System.Drawing.Size(160, 30)
        Me.ControllerTools_Button.TabIndex = 10
        Me.ControllerTools_Button.Text = "Controller Tools"
        Me.ControllerTools_Button.UseVisualStyleBackColor = True
        '
        'ProgramMode_Button
        '
        Me.ProgramMode_Button.Location = New System.Drawing.Point(474, 260)
        Me.ProgramMode_Button.Name = "ProgramMode_Button"
        Me.ProgramMode_Button.Size = New System.Drawing.Size(160, 30)
        Me.ProgramMode_Button.TabIndex = 11
        Me.ProgramMode_Button.Text = "Program Mode"
        Me.ProgramMode_Button.UseVisualStyleBackColor = True
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(474, 309)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(160, 30)
        Me.Reset_Button.TabIndex = 12
        Me.Reset_Button.Text = "Reset"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'TeachPoint_Button
        '
        Me.TeachPoint_Button.Location = New System.Drawing.Point(474, 358)
        Me.TeachPoint_Button.Name = "TeachPoint_Button"
        Me.TeachPoint_Button.Size = New System.Drawing.Size(160, 30)
        Me.TeachPoint_Button.TabIndex = 13
        Me.TeachPoint_Button.Text = "Teach Point"
        Me.TeachPoint_Button.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Function_Print_ComboBox)
        Me.GroupBox2.Controls.Add(Me.Function_Print_Label)
        Me.GroupBox2.Controls.Add(Me.ControlType_ComboBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LayerAdd_Button)
        Me.GroupBox2.Controls.Add(Me.Layer_TextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 283)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Printer Interaction"
        '
        'LayerAdd_Button
        '
        Me.LayerAdd_Button.Location = New System.Drawing.Point(9, 122)
        Me.LayerAdd_Button.Name = "LayerAdd_Button"
        Me.LayerAdd_Button.Size = New System.Drawing.Size(238, 30)
        Me.LayerAdd_Button.TabIndex = 2
        Me.LayerAdd_Button.Text = "Add"
        Me.LayerAdd_Button.UseVisualStyleBackColor = True
        '
        'Layer_TextBox
        '
        Me.Layer_TextBox.Location = New System.Drawing.Point(147, 34)
        Me.Layer_TextBox.Name = "Layer_TextBox"
        Me.Layer_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Layer_TextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add pause at layer: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Robot control type:"
        '
        'ControlType_ComboBox
        '
        Me.ControlType_ComboBox.FormattingEnabled = True
        Me.ControlType_ComboBox.Items.AddRange(New Object() {"Jog", "Function"})
        Me.ControlType_ComboBox.Location = New System.Drawing.Point(147, 62)
        Me.ControlType_ComboBox.Name = "ControlType_ComboBox"
        Me.ControlType_ComboBox.Size = New System.Drawing.Size(100, 24)
        Me.ControlType_ComboBox.TabIndex = 5
        '
        'Function_Print_Label
        '
        Me.Function_Print_Label.AutoSize = True
        Me.Function_Print_Label.Location = New System.Drawing.Point(6, 95)
        Me.Function_Print_Label.Name = "Function_Print_Label"
        Me.Function_Print_Label.Size = New System.Drawing.Size(111, 17)
        Me.Function_Print_Label.TabIndex = 6
        Me.Function_Print_Label.Text = "Function to run: "
        '
        'Function_Print_ComboBox
        '
        Me.Function_Print_ComboBox.FormattingEnabled = True
        Me.Function_Print_ComboBox.Items.AddRange(New Object() {"main"})
        Me.Function_Print_ComboBox.Location = New System.Drawing.Point(147, 92)
        Me.Function_Print_ComboBox.Name = "Function_Print_ComboBox"
        Me.Function_Print_ComboBox.Size = New System.Drawing.Size(100, 24)
        Me.Function_Print_ComboBox.TabIndex = 7
        '
        'RobotWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 573)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TeachPoint_Button)
        Me.Controls.Add(Me.Reset_Button)
        Me.Controls.Add(Me.ProgramMode_Button)
        Me.Controls.Add(Me.ControllerTools_Button)
        Me.Controls.Add(Me.Simulator_Button)
        Me.Controls.Add(Me.TaskManager_Button)
        Me.Controls.Add(Me.IOMonitor_Button)
        Me.Controls.Add(Me.RobotManager_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RobotWindow"
        Me.Text = "RobotWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgramStart_Button As Button
    Friend WithEvents ProgramPause_Button As Button
    Friend WithEvents ProgramStop_Button As Button
    Friend WithEvents ProgramContinue_Button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Function_SPEL_ComboBox As ComboBox
    Friend WithEvents RobotManager_Button As Button
    Friend WithEvents IOMonitor_Button As Button
    Friend WithEvents TaskManager_Button As Button
    Friend WithEvents Simulator_Button As Button
    Friend WithEvents ControllerTools_Button As Button
    Friend WithEvents ProgramMode_Button As Button
    Friend WithEvents Reset_Button As Button
    Friend WithEvents TeachPoint_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LayerAdd_Button As Button
    Friend WithEvents Layer_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ControlType_ComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Function_Print_ComboBox As ComboBox
    Friend WithEvents Function_Print_Label As Label
End Class
