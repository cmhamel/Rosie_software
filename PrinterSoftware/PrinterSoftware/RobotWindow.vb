Imports RCAPINet
Public Class RobotWindow
    Private WithEvents m_spel As New Spel

    Public robot_action_layers As New List(Of Integer)
    Public robot_control_types As New List(Of String)

    Private Sub RobotWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            m_spel.Initialize()
            m_spel.Project = "c:\EpsonRC70\Projects\Printer_Project\Printer_Project.sprj"
            m_spel.EnableEvent(SpelEvents.AllTasksStopped, True)
            m_spel.ResetAbortEnabled = False

            ProgramPause_Button.Enabled = False
            ProgramContinue_Button.Enabled = False
            ProgramStop_Button.Enabled = False
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    '****** SPEL Program Controls ******'
    Private Sub ProgramSelect_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Function_SPEL_ComboBox.SelectedIndexChanged

    End Sub

    Private Sub ProgramStart_Button_Click(sender As Object, e As EventArgs) Handles ProgramStart_Button.Click
        Try
            If (Function_SPEL_ComboBox.SelectedIndex > -1) Then
                Function_SPEL_ComboBox.SelectedIndex = 0
            End If
            m_spel.Start(Function_SPEL_ComboBox.SelectedIndex)
            ProgramStart_Button.Enabled = False
            ProgramPause_Button.Enabled = True
            ProgramStop_Button.Enabled = True
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramPause_Button_Click(sender As Object, e As EventArgs) Handles ProgramPause_Button.Click
        Try
            m_spel.Pause()
            ProgramPause_Button.Enabled = False
            ProgramContinue_Button.Enabled = True
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramStop_Button_Click(sender As Object, e As EventArgs) Handles ProgramStop_Button.Click
        Try
            m_spel.Stop()
            ProgramStop_Button.Enabled = False
            ProgramStart_Button.Enabled = True
            ProgramPause_Button.Enabled = False
            ProgramContinue_Button.Enabled = False
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramContinue_Button_Click(sender As Object, e As EventArgs) Handles ProgramContinue_Button.Click
        Try
            m_spel.Continue()
            ProgramContinue_Button.Enabled = False
            ProgramPause_Button.Enabled = True
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    '****** Epson RC Interaction Buttons ******'
    Private Sub RobotManager_Button_Click(sender As Object, e As EventArgs) Handles RobotManager_Button.Click
        Try
            m_spel.RunDialog(SpelDialogs.RobotManager, Me)
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IOMonitor_Button_Click(sender As Object, e As EventArgs) Handles IOMonitor_Button.Click
        Try
            m_spel.ShowWindow(SpelWindows.IOMonitor, Me)
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TaskManager_Button_Click(sender As Object, e As EventArgs) Handles TaskManager_Button.Click
        Try
            m_spel.ShowWindow(SpelWindows.TaskManager, Me)
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Simulator_Button_Click(sender As Object, e As EventArgs) Handles Simulator_Button.Click
        'maybe add code later
        Console.WriteLine("Simulator button pressed")
    End Sub

    Private Sub ControllerTools_Button_Click(sender As Object, e As EventArgs) Handles ControllerTools_Button.Click
        Try
            m_spel.RunDialog(SpelDialogs.ControllerTools, Me)
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramMode_Button_Click(sender As Object, e As EventArgs) Handles ProgramMode_Button.Click
        Try
            m_spel.OperationMode = SpelOperationMode.Program
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        Try
            m_spel.Reset()
        Catch ex As SpelException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TeachPoint_Button_Click(sender As Object, e As EventArgs) Handles TeachPoint_Button.Click
        'maybe add code later
        Console.WriteLine("Teach Point button pressed")
    End Sub

    '****** Printer Interaction ******'
    Private Sub LayerAdd_Button_Click(sender As Object, e As EventArgs) Handles LayerAdd_Button.Click
        Dim layer As Integer
        Dim control_type As String

        layer = Layer_TextBox.Text
        robot_action_layers.Add(layer)

        control_type = ControlType_ComboBox.SelectedItem.ToString
        robot_control_types.Add(control_type)
        Console.WriteLine(control_type)
    End Sub

    Private Sub ControlType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ControlType_ComboBox.SelectedIndexChanged

        If (ControlType_ComboBox.SelectedIndex = 0) Then
            Function_Print_Label.ForeColor = Color.Gray
            Function_Print_ComboBox.Enabled = False
        Else
            Function_Print_Label.ForeColor = Color.Black
            Function_Print_ComboBox.Enabled = True
        End If

    End Sub

End Class