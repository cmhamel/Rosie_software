Public Class RobotWindow

    Private Sub RobotSelect_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RobotSelect_ComboBox.SelectedIndexChanged
        If (RobotSelect_ComboBox.SelectedIndex.Equals(0)) Then
            'Console.WriteLine("Robot 1 Selected")
            Robot2_Group.Visible = False
            Robot1_GroupBox.Visible = True
        ElseIf (RobotSelect_ComboBox.SelectedIndex.Equals(1)) Then 'Robot 2 selected
            'Console.WriteLine("Robot 2 Selected")
            Robot1_GroupBox.Visible = False
            Robot2_Group.Visible = True
        End If
    End Sub

    Private Sub RobotAction_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RobotAction_ComboBox.SelectedIndexChanged
        If (RobotAction_ComboBox.SelectedIndex.Equals(0)) Then
            'change all other action boxes' visibility to false
            'change jog action box's visibility to true
        ElseIf (RobotAction_ComboBox.SelectedIndex.Equals(1)) Then
            'change all other action boxes' visibility to false
            'change add movements action box's visibility to true
        End If
    End Sub

    '***** ROBOT 1 *****

    'Robot 1 Jog Control Combo Boxes
    Private Sub R1_JogType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R1_JogType_ComboBox.SelectedIndexChanged
        If (R1_JogType_ComboBox.SelectedIndex.Equals(0)) Then
            R1_JogTool_Group.Visible = False
            R1_JogJoint_Group.Visible = True
        ElseIf (R1_JogType_ComboBox.SelectedIndex.Equals(1)) Then
            R1_JogJoint_Group.Visible = False
            R1_JogTool_Group.Visible = True
        End If
    End Sub

    Private Sub R1_JogSpeed_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R1_JogSpeed_ComboBox.SelectedIndexChanged
        'TODO: add api code
    End Sub

    'Robot 1 Jogging by Joint Controls
    Private Sub R1_J1P_Button_Click(sender As Object, e As EventArgs) Handles R1_J1P_Button.Click
        Console.WriteLine("Robot 1 Joint 1+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J1N_Button_Click(sender As Object, e As EventArgs) Handles R1_J1N_Button.Click
        Console.WriteLine("Robot 1 Joint 1-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J2P_Button_Click(sender As Object, e As EventArgs) Handles R1_J2P_Button.Click
        Console.WriteLine("Robot 1 Joint 2+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J2N_Button_Click(sender As Object, e As EventArgs) Handles R1_J2N_Button.Click
        Console.WriteLine("Robot 1 Joint 2-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J3P_Button_Click(sender As Object, e As EventArgs) Handles R1_J3P_Button.Click
        Console.WriteLine("Robot 1 Joint 3+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J3N_Button_Click(sender As Object, e As EventArgs) Handles R1_J3N_Button.Click
        Console.WriteLine("Robot 1 Joint 3-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J4P_Button_Click(sender As Object, e As EventArgs) Handles R1_J4P_Button.Click
        Console.WriteLine("Robot 1 Joint 4+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J4N_Button_Click(sender As Object, e As EventArgs) Handles R1_J4N_Button.Click
        Console.WriteLine("Robot 1 Joint 4-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J5P_Button_Click(sender As Object, e As EventArgs) Handles R1_J5P_Button.Click
        Console.WriteLine("Robot 1 Joint 5+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J5N_Button_Click(sender As Object, e As EventArgs) Handles R1_J5N_Button.Click
        Console.WriteLine("Robot 1 Joint 5-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J6P_Button_Click(sender As Object, e As EventArgs) Handles R1_J6P_Button.Click
        Console.WriteLine("Robot 1 Joint 6+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_J6N_Button_Click(sender As Object, e As EventArgs) Handles R1_J6N_Button.Click
        Console.WriteLine("Robot 1 Joint 6-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    'Robot 1 Jogging by Tool Controls
    Private Sub R1_XP_Button_Click(sender As Object, e As EventArgs) Handles R1_XP_Button.Click
        Console.WriteLine("Robot 1 Tool X+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_XN_Button_Click(sender As Object, e As EventArgs) Handles R1_XN_Button.Click
        Console.WriteLine("Robot 1 Position X-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_YP_Button_Click(sender As Object, e As EventArgs) Handles R1_YP_Button.Click
        Console.WriteLine("Robot 1 Position Y+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_YN_Button_Click(sender As Object, e As EventArgs) Handles R1_YN_Button.Click
        Console.WriteLine("Robot 1 Position Y-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_ZP_Button_Click(sender As Object, e As EventArgs) Handles R1_ZP_Button.Click
        Console.WriteLine("Robot 1 Position Z+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_ZN_Button_Click(sender As Object, e As EventArgs) Handles R1_ZN_Button.Click
        Console.WriteLine("Robot 1 Position Z-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_UP_Button_Click(sender As Object, e As EventArgs) Handles R1_UP_Button.Click
        Console.WriteLine("Robot 1 Position U+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_UN_Button_Click(sender As Object, e As EventArgs) Handles R1_UN_Button.Click
        Console.WriteLine("Robot 1 Position U-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_VP_Button_Click(sender As Object, e As EventArgs) Handles R1_VP_Button.Click
        Console.WriteLine("Robot 1 Position V+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_VN_Button_Click(sender As Object, e As EventArgs) Handles R1_VN_Button.Click
        Console.WriteLine("Robot 1 Position V-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_WP_Button_Click(sender As Object, e As EventArgs) Handles R1_WP_Button.Click
        Console.WriteLine("Robot 1 Position W+")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    Private Sub R1_WN_Button_Click(sender As Object, e As EventArgs) Handles R1_WN_Button.Click
        Console.WriteLine("Robot 1 Position W-")

        Dim jogX As Double
        Dim jogY As Double
        Dim jogZ As Double
        Dim jogU As Double
        Dim jogV As Double
        Dim jogW As Double

        If (R1_Continuous_RadioButton.Checked.Equals(False)) Then
            Console.WriteLine("Do not read Jog Distance Values")
        Else
            Console.WriteLine("Read Jog Distance Values")
            jogX = Convert.ToDouble(R1_JogX_TextBox.Text)
            jogY = Convert.ToDouble(R1_JogY_TextBox.Text)
            jogZ = Convert.ToDouble(R1_JogZ_TextBox.Text)
            jogU = Convert.ToDouble(R1_JogU_TextBox.Text)
            jogV = Convert.ToDouble(R1_JogV_TextBox.Text)
            jogW = Convert.ToDouble(R1_JogW_TextBox.Text)
        End If

        'TODO: add API code
    End Sub

    'Robot 1 Jog Distance Text Boxes
    Private Sub R1_JogX_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogX_TextBox.TextChanged

    End Sub

    Private Sub R1_JogY_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogY_TextBox.TextChanged

    End Sub

    Private Sub R1_JogZ_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogZ_TextBox.TextChanged

    End Sub

    Private Sub R1_JogU_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogU_TextBox.TextChanged

    End Sub

    Private Sub R1_JogV_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogV_TextBox.TextChanged

    End Sub

    Private Sub R1_JogW_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R1_JogW_TextBox.TextChanged

    End Sub

    'Robot 1 Jogging Radio Buttons
    Private Sub R1_World_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_World_RadioButton.CheckedChanged
        R1_CurrentPosJoint_Group.Visible = False
        R1_CurrentPosWorld_Group.Visible = True

        'get position values from API
    End Sub

    Private Sub R1_Joint_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_Joint_RadioButton.CheckedChanged
        R1_CurrentPosWorld_Group.Visible = False
        R1_CurrentPosJoint_Group.Visible = True

        'get position values from API
    End Sub

    Private Sub R1_Continuous_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_Continuous_RadioButton.CheckedChanged
        R1_JogX_TextBox.Text = ""
        R1_JogY_TextBox.Text = ""
        R1_JogZ_TextBox.Text = ""
        R1_JogU_TextBox.Text = ""
        R1_JogV_TextBox.Text = ""
        R1_JogW_TextBox.Text = ""
    End Sub

    Private Sub R1_Long_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_Long_RadioButton.CheckedChanged
        R1_JogX_TextBox.Text = "10.000"
        R1_JogY_TextBox.Text = "10.000"
        R1_JogZ_TextBox.Text = "10.000"
        R1_JogU_TextBox.Text = "10.000"
        R1_JogV_TextBox.Text = "10.000"
        R1_JogW_TextBox.Text = "10.000"
    End Sub

    Private Sub R1_Medium_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_Medium_RadioButton.CheckedChanged
        R1_JogX_TextBox.Text = "1.000"
        R1_JogY_TextBox.Text = "1.000"
        R1_JogZ_TextBox.Text = "1.000"
        R1_JogU_TextBox.Text = "1.000"
        R1_JogV_TextBox.Text = "1.000"
        R1_JogW_TextBox.Text = "1.000"
    End Sub

    Private Sub R1_Short_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R1_Short_RadioButton.CheckedChanged
        R1_JogX_TextBox.Text = "0.100"
        R1_JogY_TextBox.Text = "0.100"
        R1_JogZ_TextBox.Text = "0.100"
        R1_JogU_TextBox.Text = "0.100"
        R1_JogV_TextBox.Text = "0.100"
        R1_JogW_TextBox.Text = "0.100"
    End Sub

    '***** ROBOT 2 *****
    'Robot 2 Jog Control Combo Boxes
    Private Sub R2_JogType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R2_JogType_ComboBox.SelectedIndexChanged
        If (R2_JogType_ComboBox.SelectedIndex.Equals(0)) Then
            R2_JogTool_Group.Visible = False
            R2_JogJoint_Group.Visible = True
        ElseIf (R2_JogType_ComboBox.SelectedIndex.Equals(1)) Then
            R2_JogJoint_Group.Visible = False
            R2_JogTool_Group.Visible = True
        End If
    End Sub

    Private Sub R2_JogSpeed_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R2_JogSpeed_ComboBox.SelectedIndexChanged

    End Sub

    'Robot 2 Jogging by Joint Controls
    Private Sub R2_J1P_Button_Click(sender As Object, e As EventArgs) Handles R2_J1P_Button.Click

    End Sub

    Private Sub R2_J1N_Button_Click(sender As Object, e As EventArgs) Handles R2_J1N_Button.Click

    End Sub

    Private Sub R2_J2P_Button_Click(sender As Object, e As EventArgs) Handles R2_J2P_Button.Click

    End Sub

    Private Sub R2_J2N_Button_Click(sender As Object, e As EventArgs) Handles R2_J2N_Button.Click

    End Sub

    Private Sub R2_J3P_Button_Click(sender As Object, e As EventArgs) Handles R2_J3P_Button.Click

    End Sub

    Private Sub R2_J3N_Button_Click(sender As Object, e As EventArgs) Handles R2_J3N_Button.Click

    End Sub

    Private Sub R2_J4P_Button_Click(sender As Object, e As EventArgs) Handles R2_J4P_Button.Click

    End Sub

    Private Sub R2_J4N_Button_Click(sender As Object, e As EventArgs) Handles R2_J4N_Button.Click

    End Sub

    'Robot 2 Jogging by Tool Controls
    Private Sub R2_XP_Button_Click(sender As Object, e As EventArgs) Handles R2_XP_Button.Click

    End Sub

    Private Sub R2_XN_Button_Click(sender As Object, e As EventArgs) Handles R2_XN_Button.Click

    End Sub

    Private Sub R2_YP_Button_Click(sender As Object, e As EventArgs) Handles R2_YP_Button.Click

    End Sub

    Private Sub R2_YN_Button_Click(sender As Object, e As EventArgs) Handles R2_YN_Button.Click

    End Sub

    Private Sub R2_ZP_Button_Click(sender As Object, e As EventArgs) Handles R2_ZP_Button.Click

    End Sub

    Private Sub R2_ZN_Button_Click(sender As Object, e As EventArgs) Handles R2_ZN_Button.Click

    End Sub

    Private Sub R2_UP_Button_Click(sender As Object, e As EventArgs) Handles R2_UP_Button.Click

    End Sub

    Private Sub R2_UN_Button_Click(sender As Object, e As EventArgs) Handles R2_UN_Button.Click

    End Sub

    'Robot 2 Jog Distance Text Boxes
    Private Sub R2_JogX_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R2_JogX_TextBox.TextChanged

    End Sub

    Private Sub R2_JogY_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R2_JogY_TextBox.TextChanged

    End Sub

    Private Sub R2_JogZ_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R2_JogZ_TextBox.TextChanged

    End Sub

    Private Sub R2_JogU_TextBox_TextChanged(sender As Object, e As EventArgs) Handles R2_JogU_TextBox.TextChanged

    End Sub

    'Jogging Radio Buttons
    Private Sub R2_World_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_World_RadioButton.CheckedChanged

    End Sub

    Private Sub R2_Joint_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_Joint_RadioButton.CheckedChanged

    End Sub

    Private Sub R2_Continuous_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_Continuous_RadioButton.CheckedChanged

    End Sub

    Private Sub R2_Long_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_Long_RadioButton.CheckedChanged

    End Sub

    Private Sub R2_Medium_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_Medium_RadioButton.CheckedChanged

    End Sub

    Private Sub R2_Short_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles R2_Short_RadioButton.CheckedChanged

    End Sub
End Class