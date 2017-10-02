Public Class Form1
    '
    ' This snippet of code handles the import gcode button
    ' it opens a dialog box to find a file 
    '
    '
    ' form load function for setting defaults for all of the settings
    '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' this handles any initial setup and setting of defaults for the software
        '
        Dim reader As New IO.StreamReader(My.Computer.FileSystem.CurrentDirectory + "\PrintSettings.txt")
        ' first set default optomec settings
        '
        Optomec_x_offset.Text = reader.ReadLine()
        Optomec_y_offset.Text = reader.ReadLine()
        Optomec_z_offset.Text = reader.ReadLine()
        '
        Optomec_printing_speed.Text = reader.ReadLine()
        '
        NonPrintingSpeed.Text = reader.ReadLine()
        '
        Optomec_dwell_time.Text = reader.ReadLine()
        '
        ' Now for DIW Left
        '
        DIWLeft_x_offset.Text = reader.ReadLine()
        DIWLeft_y_offset.Text = reader.ReadLine()
        ZZ3_offset.Text = reader.ReadLine()
        '
        DIWLeft_printing_speed.Text = reader.ReadLine()
        '
        DIWLeft_dwell_time.Text = reader.ReadLine()
        '
        UVCureSpeed.Text = reader.ReadLine()
        '
        ' Now for DIW Right
        '
        DIWRight_x_offset.Text = reader.ReadLine()
        DIWRight_y_offset.Text = reader.ReadLine()
        '
        DIWRight_printing_speed.Text = reader.ReadLine()
        '
        DIWRight_dwell_time.Text = reader.ReadLine()
        '
        ' Now for FDM Left
        '
        FDMLeft_x_offset.Text = reader.ReadLine()
        FDMLeft_y_offset.Text = reader.ReadLine()
        '
        FDMLeft_printing_speed.Text = reader.ReadLine()
        '
        FDMLeft_stepper_extruder.Text = reader.ReadLine()
        FDMLeft_retraction_steps.Text = reader.ReadLine()
        '
        FDMLeft_dwell_time.Text = reader.ReadLine()
        '
        ' Now for FDM Right
        '
        FDMRight_x_offset.Text = reader.ReadLine()
        FDMRight_y_offset.Text = reader.ReadLine()
        '
        FDMRight_printing_speed.Text = reader.ReadLine()
        '
        FDMRight_stepper_extruder.Text = reader.ReadLine()
        FDMRight_retraction_steps.Text = reader.ReadLine()
        '
        FDMRight_dwell_time.Text = reader.ReadLine()
        '
        ' Default non printing speed for all other motions
        '
        'NonPrintingSpeed.Text = "30"
        '
        ' Inkjet defaults
        '
        Inkjet_layers_per_pass.Text = reader.ReadLine()
        Inkjet_layer_thickness.Text = reader.ReadLine()
        StartingZHeight.Text = reader.ReadLine()
        '
        ' UV cure speed
        '
        'UVCureSpeed.Text = "20"
        UVCureSpeed.Enabled = True
        '
        ' more to come
        '
        reader.Close()
    End Sub
    '
    ' Export gcode button
    '
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExportGCode.Click
        '
        ' used to save the gcode after processing
        '
        SaveFileDialog1.ShowDialog()
    End Sub
    '
    ' save gcode to .src file button for save dialog
    '
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(ProcessedGcode.Text)
        writer.Close()
    End Sub
    '
    ' end of class
    Private Sub ImportGcode_Click(sender As Object, e As EventArgs) Handles ImportGcode.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    '
    ' This code handles the event that ok is clicked in the openfiledialog box
    '
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        '
        ' imports gcode line by line and displays in the box
        '
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        ImportedGcode.Text = reader.ReadToEnd
        reader.Close()
    End Sub
    '
    ' Check list box for tools selection
    '
    Private Sub ToolSelections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolSelections.SelectedIndexChanged
        '
        Dim ToolChecked As Object
        Dim ToolString As String
        Dim CheckedState As String
        '
        ' begin loop over possible tool selections
        '
        For Each ToolChecked In ToolSelections.Items
            '
            '
            '
            ToolString = ToolChecked.ToString
            '
            ' 
            '
            CheckedState = ToolSelections.GetItemCheckState(ToolSelections.Items.IndexOf(ToolChecked)).ToString
            '
            ' Check Optomec Selection
            '
            If ToolString = "Optomec" Then
                If CheckedState = "Checked" Then
                    Optomec_x_offset.Enabled = True
                    Optomec_y_offset.Enabled = True
                    Optomec_z_offset.Enabled = True
                    '
                    Optomec_printing_speed.Enabled = True
                    '
                    Optomec_dwell_time.Enabled = True
                    '
                Else
                    Optomec_x_offset.Enabled = False
                    Optomec_y_offset.Enabled = False
                    Optomec_z_offset.Enabled = False
                    '
                    Optomec_printing_speed.Enabled = False
                    '
                    Optomec_dwell_time.Enabled = False
                    '
                End If
            End If
            '
            ' Set up ZZ3 offset if necessary
            '
            If (ToolString = "DIW Left" Or ToolString = "DIW Right" Or
                ToolString = "FDM Left" Or ToolString = "FDM Right") And
                CheckedState = "Checked" Then
                '
                ' set Z offset box to be enabled if necessary
                '
                ZZ3_offset.Enabled = True
            End If
            '
            ' Enable DIWLeft if necessary
            '
            If ToolString = "DIW Left" Then
                If CheckedState = "Checked" Then
                    DIWLeft_x_offset.Enabled = True
                    DIWLeft_y_offset.Enabled = True
                    '
                    DIWLeft_printing_speed.Enabled = True
                    '
                    DIWLeft_dwell_time.Enabled = True
                Else
                    DIWLeft_x_offset.Enabled = False
                    DIWLeft_y_offset.Enabled = False
                    '
                    DIWLeft_printing_speed.Enabled = False
                    '
                    DIWLeft_dwell_time.Enabled = False
                    '
                End If
            End If
            '
            ' Enable DIWRight if necessary
            '
            If ToolString = "DIW Right" Then
                If CheckedState = "Checked" Then
                    DIWRight_x_offset.Enabled = True
                    DIWRight_y_offset.Enabled = True
                    '
                    DIWRight_printing_speed.Enabled = True
                    '
                    DIWRight_dwell_time.Enabled = True
                    '
                Else
                    DIWRight_x_offset.Enabled = False
                    DIWRight_y_offset.Enabled = False
                    '
                    DIWRight_printing_speed.Enabled = False
                    '
                    DIWRight_dwell_time.Enabled = False
                    '
                End If
            End If
            '
            ' Enable FDMLeft if necessary
            '
            If ToolString = "FDM Left" Then
                If CheckedState = "Checked" Then
                    FDMLeft_x_offset.Enabled = True
                    FDMLeft_y_offset.Enabled = True
                    '
                    FDMLeft_printing_speed.Enabled = True
                    '
                    FDMLeft_dwell_time.Enabled = True
                    '
                    FDMLeft_stepper_extruder.Enabled = True
                    '
                    FDMLeft_retraction_steps.Enabled = True
                Else
                    FDMLeft_x_offset.Enabled = False
                    FDMLeft_y_offset.Enabled = False
                    '
                    FDMLeft_printing_speed.Enabled = False
                    '
                    FDMLeft_dwell_time.Enabled = False
                    '
                    FDMLeft_stepper_extruder.Enabled = False
                    '
                    FDMLeft_retraction_steps.Enabled = False
                End If
            End If
            '
            ' Enable FDMRight if necessary
            '
            If ToolString = "FDM Right" Then
                If CheckedState = "Checked" Then
                    FDMRight_x_offset.Enabled = True
                    FDMRight_y_offset.Enabled = True
                    '
                    FDMRight_printing_speed.Enabled = True
                    '
                    FDMRight_dwell_time.Enabled = True
                    '
                    FDMRight_stepper_extruder.Enabled = True
                    '
                    FDMRight_retraction_steps.Enabled = True
                Else
                    FDMRight_x_offset.Enabled = False
                    FDMRight_y_offset.Enabled = False
                    '
                    FDMRight_printing_speed.Enabled = False
                    '
                    FDMRight_dwell_time.Enabled = False
                    '
                    FDMRight_stepper_extruder.Enabled = False
                    '
                    FDMRight_retraction_steps.Enabled = False
                End If
            End If
            '
            ' Enable Inkjet if necessary
            '
            If ToolString = "Inkjet" Then
                If CheckedState = "Checked" Then
                    Inkjet_layer_thickness.Enabled = True
                    '
                    Inkjet_layers_per_pass.Enabled = True
                    '
                    StartingZHeight.Enabled = True
                Else
                    Inkjet_layer_thickness.Enabled = False
                    '
                    Inkjet_layers_per_pass.Enabled = False
                    '
                    StartingZHeight.Enabled = False
                End If
            End If
            '
            ' Check for UV cure
            '

        Next
        '
        '
        '
    End Sub
    '
    ' Process the gcode here
    '
    Private Sub ProcessGcode_Click(sender As Object, e As EventArgs) Handles ProcessGcode.Click
        '
        ' post is where the g code lines are written to
        '
        Dim post As New List(Of String)
        '
        ' first check if the ink jet is active in the settings
        ' if so post the necessary lines to define layer height, etc.
        '
        Dim ToolChecked As Object
        '
        Dim ZZ1 As Boolean = False
        Dim ZZ2 As Boolean = False
        Dim ZZ3 As Boolean = False
        Dim ZZ4 As Boolean = False
        '
        Dim FDM_Left As Boolean = False
        Dim FDM_Right As Boolean = False
        '
        Dim DIW_Left As Boolean = False
        Dim DIW_Right As Boolean = False
        '
        Dim DIW_UV_Cure As Boolean = False
        '
        Dim Inkjet As Boolean = False
        '
        Dim PnP As Boolean = False
        '
        ' look for the motors that need to be enabled based 
        ' the tools that were selectec by the user
        '
        For Each ToolChecked In ToolSelections.CheckedItems
            '
            ' First check for Optomec
            '
            If ToolChecked.ToString = "Optomec" Then
                ZZ1 = True
            End If
            '
            ' Put Photonic Cure Here later
            ' for now just set ZZ2 to False
            '
            ZZ2 = False
            '
            ' Check for ZZ3 with either FDM or DIW
            '
            If ToolChecked.ToString = "FDM Left" Or
               ToolChecked.ToString = "FDM Right" Or
               ToolChecked.ToString = "DIW Left" Or
               ToolChecked.ToString = "DIW Right" Then
                '
                ZZ3 = True
            End If
            '
            ' check for UV light or Inkjet
            '
            If ToolChecked.ToString = "Inkjet" Or
               ToolChecked.ToString = "DIW Left UV Cure?" Or
               ToolChecked.ToString = "DIW Right UV Cure?" Then
                '
                ZZ4 = True
                '
            End If
            '
            ' set boolean variables for selected tools
            '
            If ToolChecked.ToString = "FDM Left" Then
                '
                FDM_Left = True
            End If
            '
            If ToolChecked.ToString = "FDM Right" Then
                '
                FDM_Right = True
            End If
            '
            If ToolChecked.ToString = "DIW Left" Then
                '
                DIW_Left = True
            End If
            '
            If ToolChecked.ToString = "DIW Right" Then
                '
                DIW_Right = True
            End If
            '
            If ToolChecked.ToString = "DIW Left UV Cure?" Or
               ToolChecked.ToString = "DIW Right UV Cure?" Then
                '
                ' set DIW Uv cure as true
                '
                DIW_UV_Cure = True
                '
            End If
            '
            If ToolChecked.ToString = "Inkjet" Then
                Inkjet = True
            End If
        Next
        '
        ' Add setup up lines based on tools and motors enabled
        '
        If ZZ4 Then
            '
            ' setup up variables for inkjet
            '
            post.Add("'")
            post.Add("' Define inkjet/UV cure variables")
            post.Add("'")
            '
            '
            '
            post.Add("#define Layers " + Inkjet_layers_per_pass.Text + "
            #define lThick " + Inkjet_layer_thickness.Text + " 
            DVAR $Counter1
            DVAR $precure 
            DVAR $Counter2 
            DVAR $Zheight = " + StartingZHeight.Text + "
            $Counter2 = 0")
        End If
        '
        ' Enable necessary motors
        '
        Dim EnableString As String = "ENABLE X Y "
        '
        If ZZ1 Then
            EnableString = EnableString + "ZZ1 "
        End If
        '
        If ZZ2 Then
            EnableString = EnableString + "ZZ2 "
        End If
        '
        If ZZ3 Then
            EnableString = EnableString + "ZZ3 "
        End If
        '
        If ZZ4 Then
            EnableString = EnableString + "ZZ4 "
        End If
        '
        '
        '
        post.Add("'")
        post.Add("' Enable Necessary Motors")
        post.Add("'")
        post.Add(EnableString)      'Enable motors for motion
        post.Add("'")
        post.Add("' Setup Parameters")            'Setup Parameters; look over help file for more information on each
        post.Add("'")
        post.Add("G1") 'Motion Mode - Linear Interpolation
        post.Add("G63") 'Acceleration Profile Mode- Sinusoidal
        post.Add("G68") 'Acceleration Ramp Mode- Rate Based Acceleration
        post.Add("G71") 'Distance Units Mode - Primary units
        post.Add("G76") 'Velocity Units Mode- Distance units per second
        post.Add("G90") 'Target Programing Mode - Absolute  (G91- Incremental)
        post.Add("G109") 'Velocity Profile Mode- No deceleration to zero velocity
        post.Add("G359") 'Motion Wait Mode - No Wait
        post.Add("G40") 'Cutter Compensation Mode- Disabled
        post.Add("G45") 'Polar/Cylindtical Trans. - Disabled
        post.Add("G100") 'Spindle Shutdown - Disable
        post.Add("'")
        post.Add("' Non-printing speed")
        post.Add("'")
        post.Add("F " + NonPrintingSpeed.Text.ToString)
        '
        ' Enable Optomec if necessary
        '
        If ZZ1 Then
            post.Add("'")
            post.Add("' Enable Optomec pin")
            post.Add("'")
            post.Add("$DO[8].X = 0")
        End If
        '
        ' check for FDM and Enable necessary pins
        '
        If FDM_Left Then
            post.Add("'")
            post.Add("' Enable FDM Left pin")
            post.Add("'")
            post.Add("$DO[12].X = 0")
        End If
        '
        If FDM_Right Then
            post.Add("'")
            post.Add("' Enable FDM Right pin")
            post.Add("'")
            post.Add("$DO[13].X = 0")
        End If
        '
        ' continuous
        '
        If FDM_Left Or FDM_Right Then
            post.Add("PSOCONTROL X RESET")
            post.Add("PSOPULSE X TIME " + Convert.ToString(FDMLeft_stepper_extruder.Text) + ", " + Convert.ToString(CInt(FDMLeft_stepper_extruder.Text / 2.0)))
            post.Add("PSOOUTPUT X PULSE")
            post.Add("PSOCONTROL X OFF")
        End If
        '
        ' split up gcode into lines
        '
        Dim lines As String() = ImportedGcode.Text.Split(vbCrLf)
        '
        Dim pState As Int16 = 0
        '
        Dim xoff As Double
        Dim yoff As Double
        Dim zoff As Double
        '
        Dim printing_speed As String = "15"
        '
        Dim dwell_time As String = ".5"
        '
        ' temporarily make this fixed for all tools
        '
        Dim non_printing_speed As String = NonPrintingSpeed.Text.ToString
        '
        Dim dig0 As String = "8"
        Dim ZAxis As String = "ZZ1"
        '
        Dim Ts As Short
        '
        ' begin loop over all lines
        '
        For Each item In lines
            If item.Contains("'") Or item.Contains(";") Or item.Contains("G92") Or item.Contains("M107") Or item.Contains("M104") Then
                '
                ' do nothing here
                '
            ElseIf item.IndexOf("T") = 1 Then
                '
                ' this denotes a tool change
                '
                If item.Contains("T7") Then
                    '
                    ' this is optomec tool change
                    '
                    If pState = 5 Then
                        post.Add("$DO[8].X = 0")
                    End If
                    '
                    xoff = Convert.ToDouble(Optomec_x_offset.Text)
                    yoff = Convert.ToDouble(Optomec_y_offset.Text)
                    zoff = Convert.ToDouble(Optomec_z_offset.Text)
                    '
                    printing_speed = Optomec_printing_speed.Text
                    '
                    dwell_time = Optomec_dwell_time.Text
                    '
                    Ts = 0
                    '
                    dig0 = "8"
                    '
                    ZAxis = "ZZ1"
                    '
                ElseIf item.Contains("T1") Then
                    ' 
                    ' DIW Left tool change
                    '
                    xoff = Convert.ToDouble(DIWLeft_x_offset.Text)
                    yoff = Convert.ToDouble(DIWLeft_y_offset.Text)
                    zoff = Convert.ToDouble(ZZ3_offset.Text)
                    '
                    printing_speed = DIWLeft_printing_speed.Text
                    '
                    dwell_time = DIWLeft_dwell_time.Text
                    '
                    post.Add("'")
                    post.Add("' Switching tool to Left syringe")
                    post.Add("'")
                    post.Add("$DO[0].X = 1")
                    post.Add("$DO[1].X = 0")
                    post.Add("'")
                    post.Add("' Begin Pause")
                    post.Add("'")
                    post.Add("PROGRAM PAUSE ")
                    post.Add("DWELL 2")
                    post.Add("'")
                    post.Add("' End Pause")
                    post.Add("'")
                    '
                    Ts = 1
                    '
                    dig0 = "9"
                    '
                    ZAxis = "ZZ3"
                    '
                ElseIf item.Contains("T2") Then
                    '
                    ' DIW Right tool change
                    '
                    xoff = Convert.ToDouble(DIWRight_x_offset.Text)
                    yoff = Convert.ToDouble(DIWRight_y_offset.Text)
                    zoff = Convert.ToDouble(ZZ3_offset.Text)
                    '
                    printing_speed = DIWRight_printing_speed.Text
                    '
                    dwell_time = DIWRight_dwell_time.Text
                    '
                    post.Add("'")
                    post.Add("' Switching tool to Right syringe")
                    post.Add("'")
                    post.Add("$DO[0].X = 0")
                    post.Add("$DO[1].X = 1")
                    post.Add("'")
                    post.Add("' Begin Pause")
                    post.Add("'")
                    post.Add("PROGRAM PAUSE ")
                    post.Add("DWELL 2")
                    post.Add("'")
                    post.Add("' End Pause")
                    post.Add("'")
                    '
                    Ts = 2
                    '
                    dig0 = "9"
                    '
                    ZAxis = "ZZ3"
                    '
                ElseIf item.Contains("T3") Then
                    '
                    ' FDM Left tool change
                    '
                    xoff = Convert.ToDouble(FDMLeft_x_offset.Text)
                    yoff = Convert.ToDouble(FDMLeft_y_offset.Text)
                    zoff = Convert.ToDouble(ZZ3_offset.Text)
                    '
                    printing_speed = FDMLeft_printing_speed.Text
                    '
                    dwell_time = FDMLeft_dwell_time.Text
                    '
                    Ts = 3
                    '
                    ZAxis = "ZZ3"
                    '
                ElseIf item.Contains("T4") Then
                    '
                    ' FDM Right tool change
                    '
                    xoff = Convert.ToDouble(FDMRight_x_offset.Text)
                    yoff = Convert.ToDouble(FDMRight_y_offset.Text)
                    zoff = Convert.ToDouble(ZZ3_offset.Text)
                    '
                    printing_speed = FDMRight_printing_speed.Text
                    '
                    dwell_time = FDMRight_dwell_time.Text
                    '
                    Ts = 4
                    '
                    ZAxis = "ZZ3"
                    '
                ElseIf item.Contains("T5") Then
                    '
                    ' Pick and Place tool change
                    '

                    Ts = 5
                    '
                ElseIf item.Contains("T6") Then
                    '
                    ' Inkjet tool change
                    '
                    ' nothing needs to be done here it will all be handled by the inkjet software
                    '
                End If
                '
            ElseIf item.Contains("X") Or
                   item.Contains("Y") Or
                   item.Contains("Z") Then
                '
                ' this denotes a tool path
                '
                If item.Contains("X") Then
                    '
                    ' Convert X coordinates to Aerotech printer
                    '
                    Dim preX As String =
                        item.Substring(item.IndexOf("X") + 1,
                                       item.IndexOf(" ", item.IndexOf("X")) - item.IndexOf("X"))
                    '
                    Dim preXnum As Double
                    preXnum = Convert.ToDouble(preX)

                    item = item.Replace("X" + preX, "X" + Convert.ToString(preXnum + xoff) + " ")
                End If
                '
                If item.Contains("Y") Then
                    '
                    ' Convert Y coordinates to Aerotech printer
                    '
                    Dim preY As String =
                        item.Substring(item.IndexOf("Y") + 1,
                                       item.IndexOf(" ", item.IndexOf("Y")) - item.IndexOf("Y"))
                    Dim preYnum As Double
                    preYnum = Convert.ToDouble(preY)

                    item = item.Replace("Y" + preY, "Y" + Convert.ToString(yoff + preYnum) + " ")
                End If
                '
                If item.Contains("Z") Then
                    '
                    'Convert Z coordinates to Aerotech Printer
                    '
                    Dim preZ As String =
                        item.Substring(item.IndexOf("Z") + 1,
                                       item.IndexOf(" ", item.IndexOf("Z")) - item.IndexOf("Z"))
                    Dim preZnum As Double
                    preZnum = Convert.ToDouble(preZ)
                    Dim new_zOff As Double = Convert.ToDouble(zoff)
                    item = item.Replace(preZ, Convert.ToString(new_zOff - preZnum) + " ")
                End If
                '
                If item.Contains("F") Then
                    Dim start As Integer = item.IndexOf("F") - 1
                    item = item.Remove(start)
                End If
                '
                If item.Contains("E") Then
                    '
                    If pState < 2 Then
                        post.Add("F " + printing_speed)
                        post.Add("$DO[" + dig0 + "].X = 1")
                        post.Add("DWELL " + dwell_time)
                        pState = 5
                        '
                    End If

                    Dim start As Integer = item.IndexOf("E") - 1
                    item = item.Remove(start)
                Else
                    If pState > 2 Then
                        '
                        post.Add("$DO[" + dig0 + "].X = 0")
                        pState = 0
                        post.Add("F " + non_printing_speed)
                    End If
                    '
                End If
                '
                item = item.Replace("Z", ZAxis)

                post.Add(item)
            End If
            '
            ' check for layer change
            '
            ' this needs a lot of fixing
            '
            ' first check whether zz4 is enabled
            '
            ' then check to see if it is for inkjet, uv cure of diw or both.
            '
            If item.Contains(";layer") And ZZ4 Then
                '
                ' check for UV cure
                '
                If DIW_UV_Cure Then
                    '
                    ' Put the necessary pass of the UV light for curing the layer
                    ' based on the UV cure speed and max and min Y distances to optimize
                    '
                    post.Add("'")
                    post.Add("' Begin UV Cure")
                    post.Add("'")
                    post.Add("F 50
                    G1 X795 Y220
                    F 2
                    $Zheight = $Zheight - Layers*lThick
                    G1 ZZ4$Zheight
                        '
                        ' Cure Previous DIW Layer
                        '
                        $DO[10].X = 1
                        F " + UVCureSpeed.Text.ToString + "
                        G1 X795 Y480
                        G1 X795 Y220
                        $DO[10].X = 0")
                    post.Add("'")
                    post.Add("' End UV Cure")
                    post.Add("'")
                    post.Add("F " + non_printing_speed)
                End If
                '
                ' check for Inkjet
                '
                If Inkjet Then
                    '
                    ' Put the necessary inkjet passes
                    '
                    post.Add("F 50
                          G1 X795 Y70
                          F 2
                          $Zheight = $Zheight-Layers*lThick
                          G1 ZZ4$Zheight
 
                          F 75
                        MSGDISPLAY 1, $Zheight
                            FOR $Counter1 = 1 TO Layers STEP 1
	                            G1 X795 Y70
                                $DO[10].X = 1
	                            DWELL .25
	                            $DO[11].X = 1
	                            G1 X795 Y499
	                            DWELL .5
	                            $DO[11].X = 0 
	                            G1 ZZ4$Zheight-$Counter1*lThick
                            NEXT $Counter1           
                            $DO[10].X = 0
                            $Counter2 = $Counter2 +Layers
                            G1 ZZ4$Zheight-5")
                    post.Add("F " + non_printing_speed.ToString)
                End If
                '
                ' this is a transition to the next layer
                '
            End If
        Next
        '
        ' post process Gcode for return and saving
        '
        Dim message = String.Join(Environment.NewLine, post.ToArray())
        ProcessedGcode.Text = message
        '
        ' save offsets to text file
        '
        saveSettings()
    End Sub
    '
    ' function for writing offsets and other settings
    '
    Public Function saveSettings()
        Dim FileName As String = My.Computer.FileSystem.CurrentDirectory + "\PrintSettings.txt"
        Dim objWriter As New System.IO.StreamWriter(FileName, False)
        '
        ' optomec settings
        '
        objWriter.WriteLine(Optomec_x_offset.Text.ToString)
        objWriter.WriteLine(Optomec_y_offset.Text.ToString)
        objWriter.WriteLine(Optomec_z_offset.Text.ToString)
        objWriter.WriteLine(Optomec_printing_speed.Text.ToString)
        '
        objWriter.WriteLine(NonPrintingSpeed.Text.ToString)
        objWriter.WriteLine(Optomec_dwell_time.Text.ToString)
        '
        ' DIW Left setting
        '
        objWriter.WriteLine(DIWLeft_x_offset.Text.ToString)
        objWriter.WriteLine(DIWLeft_y_offset.Text.ToString)
        objWriter.WriteLine(ZZ3_offset.Text.ToString)
        objWriter.WriteLine(DIWLeft_printing_speed.Text.ToString)
        objWriter.WriteLine(DIWLeft_dwell_time.Text.ToString)
        objWriter.WriteLine(UVCureSpeed.Text.ToString)
        '
        ' DIW Right setting
        '
        objWriter.WriteLine(DIWRight_x_offset.Text.ToString)
        objWriter.WriteLine(DIWRight_y_offset.Text.ToString)
        objWriter.WriteLine(DIWRight_printing_speed.Text.ToString)
        objWriter.WriteLine(DIWRight_dwell_time.Text.ToString)
        '
        ' FDM Left settings
        '
        objWriter.WriteLine(FDMLeft_x_offset.Text.ToString)
        objWriter.WriteLine(FDMLeft_y_offset.Text.ToString)
        objWriter.WriteLine(FDMLeft_printing_speed.Text.ToString)
        objWriter.WriteLine(FDMLeft_stepper_extruder.Text.ToString)
        objWriter.WriteLine(FDMLeft_retraction_steps.Text.ToString)
        objWriter.WriteLine(FDMLeft_dwell_time.Text.ToString)
        '
        ' FDM Right settings
        '
        objWriter.WriteLine(FDMRight_x_offset.Text.ToString)
        objWriter.WriteLine(FDMRight_y_offset.Text.ToString)
        objWriter.WriteLine(FDMRight_printing_speed.Text.ToString)
        objWriter.WriteLine(FDMRight_stepper_extruder.Text.ToString)
        objWriter.WriteLine(FDMRight_retraction_steps.Text.ToString)
        objWriter.WriteLine(FDMRight_dwell_time.Text.ToString)
        '
        ' Inkjet settings
        '
        objWriter.WriteLine(Inkjet_layers_per_pass.Text.ToString)
        objWriter.WriteLine(Inkjet_layer_thickness.Text.ToString)
        objWriter.WriteLine(StartingZHeight.Text.ToString)
        '
        ' close the writer
        '
        objWriter.Close()
    End Function
End Class
