Imports System.Text.RegularExpressions

Public Class ChildInfoAdd

    Private encsjis As System.Text.Encoding

    ' 全角文字しか入力できないように制限する関数。
    Private Sub EmInput(ByVal Str As Object)
        Static Encode_JIS As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim Str_Count As Integer = Str.Text.Length
        Dim ByteCount = Encode_JIS.GetByteCount(Str.Text)

        If Str_Count * 2 <> ByteCount Then
            MsgBox("全角文字で入力してください。", MsgBoxStyle.Critical, String.Empty)
            Str.Text = String.Empty
            Str.Focus()
        End If
    End Sub

    ' 数字しか入力できないように制限する関数。
    Private Sub NumInput(ByRef e As Object)
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateDecision()
        'Parse関数でInteger型に変換して格納。
        If cmb_BirthYear.Text <> String.Empty Or cmb_BirthMonth.Text <> String.Empty Then
            Dim year As Integer = Integer.Parse(cmb_BirthYear.Text)
            Dim month As Integer = Integer.Parse(cmb_BirthMonth.Text)
            Dim nowYear As Integer = Integer.Parse(DateTime.Today.Year)
            Dim nowMonth As Integer = Integer.Parse(DateTime.Today.Month)

            If (year >= 1950 And year <= 2200) Then
                If (month >= 1 And month <= 12) Then
                    If (year < nowYear) Then
                        Select Case month
                            Case 1, 3, 5, 7, 8, 10, 12
                                DayAdd(30)
                            Case 4, 6, 9, 11
                                DayAdd(29)
                            Case Else
                                If DateTime.IsLeapYear(year) = False Then
                                    DayAdd(27)
                                Else
                                    DayAdd(28)
                                End If
                        End Select
                    ElseIf (year = nowYear) Then
                        If (month < nowMonth) Then
                            Select Case month
                                Case 1, 3, 5, 7, 8, 10, 12
                                    DayAdd(30)
                                Case 4, 6, 9, 11
                                    DayAdd(29)
                                Case Else
                                    If DateTime.IsLeapYear(year) = False Then
                                        DayAdd(27)
                                    Else
                                        DayAdd(28)
                                    End If
                            End Select
                        Else
                            MsgBox("今月までの数字を入力してください。", MsgBoxStyle.Critical, "")
                            cmb_BirthMonth.Text = String.Empty
                            cmb_BirthMonth.Focus()
                        End If
                    Else
                        MsgBox("今年までの数字を入力してください。", MsgBoxStyle.Critical, String.Empty)
                        cmb_BirthYear.Text = String.Empty
                        cmb_BirthYear.Focus()
                    End If
                Else
                    MsgBox("1～12の数字を入力してください。", MsgBoxStyle.Critical, "")
                    cmb_BirthMonth.Text = String.Empty
                    cmb_BirthMonth.Focus()
                End If
            Else
                MsgBox("1950～2200の数字を入力してください。", MsgBoxStyle.Critical, String.Empty)
                cmb_BirthYear.Text = String.Empty
                cmb_BirthYear.Focus()
            End If
        End If
    End Sub

    Private Sub DayAdd(ByVal day_count As Integer)
        Dim day_array(day_count) As System.Object

        cmb_BirthDay.Items.Clear()

        Dim i As Integer
        For i = 0 To day_count
            day_array(i) = i + 1
        Next i

        cmb_BirthDay.Items.AddRange(day_array)

        If cmb_BirthDay.Text <> String.Empty Then
            Dim day As Integer = Integer.Parse(cmb_BirthDay.Text)

            If day < 1 Or day > day_count + 1 Then
                MsgBox("1～" + day_count + 1 + "の数字を入力してください。", MsgBoxStyle.Critical, String.Empty)
                cmb_BirthDay.Text = String.Empty
                cmb_BirthDay.Focus()
            End If
        End If
    End Sub

    Private Sub GetAge()
        If cmb_BirthYear.Text <> "" And cmb_BirthMonth.Text <> "" And cmb_BirthDay.Text <> "" Then
            Dim today As DateTime = DateTime.Today
            Dim year As Integer = Integer.Parse(cmb_BirthYear.Text)
            Dim month As Integer = Integer.Parse(cmb_BirthMonth.Text)
            Dim day As Integer = Integer.Parse(cmb_BirthDay.Text)

            Dim ageDouble As Double = ((today.Year * 10000 + today.Month * 100 + today.Day) - _
                    (year * 10000 + month * 100 + day)) / 10000
            Dim age As Double = CType(Math.Truncate(ageDouble), Integer)

            Dim ageMonthDouble As Double = (ageDouble - CType(age, Double)) * 100
            Dim ageMonth As Integer = CType(Math.Truncate(ageMonthDouble), Integer)

            lbl_Age.Text = age.ToString
            lbl_AgeMonth.Text = ageMonth
        End If
    End Sub

    Private Sub ChildInfoAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_BirthYear.Text = Format(Now, "yyyy")
    End Sub

    Private Sub cmb_Author_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Author.LostFocus
        EmInput(cmb_Author)
    End Sub

    Private Sub txt_ChildName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.LostFocus
        EmInput(txt_ChildName)
    End Sub

    Private Sub txt_NickName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.LostFocus
        EmInput(txt_NickName)
    End Sub

    Private Sub txt_ChildNameKana_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildNameKana.LostFocus
        EmInput(txt_ChildNameKana)
    End Sub

    Private Sub txt_Address_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Address.LostFocus
        EmInput(txt_Address)
    End Sub

    Private Sub txt_DoctorName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DoctorName.LostFocus
        EmInput(txt_DoctorName)
    End Sub

    Private Sub txt_FamilyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName1.LostFocus
        EmInput(txt_FamilyName1)
    End Sub

    Private Sub txt_RelationFamily1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily1.LostFocus
        EmInput(txt_RelationFamily1)
    End Sub

    Private Sub txt_WorkPlace1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace1.LostFocus
        EmInput(txt_WorkPlace1)
    End Sub

    Private Sub txt_FamilyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName2.LostFocus
        EmInput(txt_FamilyName2)
    End Sub

    Private Sub txt_RelationFamily2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily2.LostFocus
        EmInput(txt_RelationFamily2)
    End Sub

    Private Sub txt_WorkPlace2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace2.LostFocus
        EmInput(txt_WorkPlace2)
    End Sub

    Private Sub txt_FamilyName3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName3.LostFocus
        EmInput(txt_FamilyName3)
    End Sub

    Private Sub txt_RelationFamily3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily3.LostFocus
        EmInput(txt_RelationFamily3)
    End Sub

    Private Sub txt_WorkPlace3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace3.LostFocus
        EmInput(txt_WorkPlace3)
    End Sub

    Private Sub txt_FamilyName4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.LostFocus
        EmInput(txt_FamilyName4)
    End Sub

    Private Sub txt_RelationFamily4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily4.LostFocus
        EmInput(txt_RelationFamily4)
    End Sub

    Private Sub txt_WorkPlace4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace4.LostFocus
        EmInput(txt_WorkPlace4)
    End Sub

    Private Sub txt_FamilyName5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName5.LostFocus
        EmInput(txt_FamilyName5)
    End Sub

    Private Sub txt_RelationFamily5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily5.LostFocus
        EmInput(txt_RelationFamily5)
    End Sub

    Private Sub txt_WorkPlace5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace5.LostFocus
        EmInput(txt_WorkPlace5)
    End Sub

    Private Sub txt_FamilyName6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName6.LostFocus
        EmInput(txt_FamilyName6)
    End Sub

    Private Sub txt_RelationFamily6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily6.LostFocus
        EmInput(txt_RelationFamily6)
    End Sub

    Private Sub txt_WorkPlace6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace6.LostFocus
        EmInput(txt_WorkPlace6)
    End Sub

    Private Sub txt_FamilyName7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName7.LostFocus
        EmInput(txt_FamilyName7)
    End Sub

    Private Sub txt_RelationFamily7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily7.LostFocus
        EmInput(txt_RelationFamily7)
    End Sub

    Private Sub txt_WorkPlace7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace7.LostFocus
        EmInput(txt_WorkPlace7)
    End Sub

    Private Sub txt_FamilyName8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName8.LostFocus
        EmInput(txt_FamilyName8)
    End Sub

    Private Sub txt_RelationFamily8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily8.LostFocus
        EmInput(txt_RelationFamily8)
    End Sub

    Private Sub txt_WorkPlace8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace8.LostFocus
        EmInput(txt_WorkPlace8)
    End Sub

    Private Sub txt_FamilyName9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName9.LostFocus
        EmInput(txt_FamilyName9)
    End Sub

    Private Sub txt_RelationFamily9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily9.LostFocus
        EmInput(txt_RelationFamily9)
    End Sub

    Private Sub txt_WorkPlace9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace9.LostFocus
        EmInput(txt_WorkPlace9)
    End Sub

    Private Sub txt_EmergencyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName1.LostFocus
        EmInput(txt_EmergencyName1)
    End Sub

    Private Sub txt_EmergencyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName2.LostFocus
        EmInput(txt_EmergencyName2)
    End Sub

    Private Sub txt_RelationEmergency1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency1.LostFocus
        EmInput(txt_RelationEmergency1)
    End Sub

    Private Sub txt_RelationEmergency2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency2.LostFocus
        EmInput(txt_RelationEmergency2)
    End Sub

    Private Sub rtb_CommutingMethod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_CommutingMethod.LostFocus
        EmInput(rtb_CommutingMethod)
    End Sub

    Private Sub txt_AllergyDetails_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AllergyDetails.LostFocus
        EmInput(txt_AllergyDetails)
    End Sub

    Private Sub txt_IllnessEtc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IllnessEtc.LostFocus
        EmInput(txt_IllnessEtc)
    End Sub

    Private Sub txt_Operation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Operation.LostFocus
        EmInput(txt_Operation)
    End Sub

    Private Sub txt_SusceptibleIllness_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SusceptibleIllness.LostFocus
        EmInput(txt_SusceptibleIllness)
    End Sub

    Private Sub rtb_AnxietyAndAttention_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_AnxietyAndAttention.LostFocus
        EmInput(rtb_AnxietyAndAttention)
    End Sub

    Private Sub cmb_BirthYear_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthYear.KeyPress
        NumInput(e)
    End Sub

    Private Sub cmb_BirthMonth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthMonth.KeyPress
        NumInput(e)
    End Sub

    Private Sub cmb_BirthDay_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthDay.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_PostalCode1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PostalCode1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_PostalCode2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PostalCode2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_Tempereture_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Temperature.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge4.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge5.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge6.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge7.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge8_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge8.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge9_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge9.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_CommutingHour_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CommutingHour.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_CommutingMin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CommutingMin.KeyPress
        NumInput(e)
    End Sub

    Private Sub cmb_BirthYear_LostFocus(sender As Object, e As EventArgs) Handles cmb_BirthYear.LostFocus, cmb_BirthMonth.LostFocus
        DateDecision()
    End Sub

    Private Sub cmb_BirthYear_TextChanged(sender As Object, e As EventArgs) Handles cmb_BirthYear.TextChanged, cmb_BirthMonth.TextChanged
        If cmb_BirthYear.Text <> String.Empty And cmb_BirthMonth.Text <> String.Empty Then
            cmb_BirthDay.Enabled = True
        Else
            cmb_BirthDay.Enabled = False
        End If

        lbl_Age.Text = String.Empty
        lbl_AgeMonth.Text = String.Empty
        GetAge()
    End Sub

    Private Sub cmb_BirthDay_TextChanged(sender As Object, e As EventArgs) Handles cmb_BirthDay.TextChanged
        lbl_Age.Text = String.Empty
        lbl_AgeMonth.Text = String.Empty
        GetAge()
    End Sub
End Class
