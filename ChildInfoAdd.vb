Imports System.Text.RegularExpressions

Public Class ChildInfoAdd

    Private encsjis As System.Text.Encoding

    ' 全角文字しか入力できないように制限する関数。
    Private Sub EmInput(ByVal txtcontrol As Object)
        Dim z As String = String.Empty
        For Each s As String In txtcontrol.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        txtcontrol.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txtcontrol.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txtcontrol.Text = txtcontrol.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    ' 数字しか入力できないように制限する関数。
    Private Sub NumInput(ByRef e As Object)
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub ChildInfoAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")
    End Sub

    Private Sub cmb_Author_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Author.TextChanged
        EmInput(cmb_Author)
    End Sub

    Private Sub txt_ChildName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.TextChanged
        EmInput(txt_ChildName)
    End Sub

    Private Sub txt_NickName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.TextChanged
        EmInput(txt_NickName)
    End Sub

    Private Sub txt_ChildNameKana_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildNameKana.TextChanged
        EmInput(txt_ChildNameKana)
    End Sub

    Private Sub txt_Address_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Address.TextChanged
        EmInput(txt_Address)
    End Sub

    Private Sub txt_DoctorName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DoctorName.TextChanged
        EmInput(txt_DoctorName)
    End Sub

    Private Sub txt_FamilyName1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName1.TextChanged
        EmInput(txt_FamilyName1)
    End Sub

    Private Sub txt_RelationFamily1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily1.TextChanged
        EmInput(txt_RelationFamily1)
    End Sub

    Private Sub txt_WorkPlace1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace1.TextChanged
        EmInput(txt_WorkPlace1)
    End Sub

    Private Sub txt_FamilyName2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName2.TextChanged
        EmInput(txt_FamilyName2)
    End Sub

    Private Sub txt_RelationFamily2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily2.TextChanged
        EmInput(txt_RelationFamily2)
    End Sub

    Private Sub txt_WorkPlace2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace2.TextChanged
        EmInput(txt_WorkPlace2)
    End Sub

    Private Sub txt_FamilyName3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName3.TextChanged
        EmInput(txt_FamilyName3)
    End Sub

    Private Sub txt_RelationFamily3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily3.TextChanged
        EmInput(txt_RelationFamily3)
    End Sub

    Private Sub txt_WorkPlace3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace3.TextChanged
        EmInput(txt_WorkPlace3)
    End Sub

    Private Sub txt_FamilyName4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.TextChanged
        EmInput(txt_FamilyName4)
    End Sub

    Private Sub txt_RelationFamily4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily4.TextChanged
        EmInput(txt_RelationFamily4)
    End Sub

    Private Sub txt_WorkPlace4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace4.TextChanged
        EmInput(txt_WorkPlace4)
    End Sub

    Private Sub txt_FamilyName5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName5.TextChanged
        EmInput(txt_FamilyName5)
    End Sub

    Private Sub txt_RelationFamily5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily5.TextChanged
        EmInput(txt_RelationFamily5)
    End Sub

    Private Sub txt_WorkPlace5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace5.TextChanged
        EmInput(txt_WorkPlace5)
    End Sub

    Private Sub txt_FamilyName6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName6.TextChanged
        EmInput(txt_FamilyName6)
    End Sub

    Private Sub txt_RelationFamily6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily6.TextChanged
        EmInput(txt_RelationFamily6)
    End Sub

    Private Sub txt_WorkPlace6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace6.TextChanged
        EmInput(txt_WorkPlace6)
    End Sub

    Private Sub txt_FamilyName7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName7.TextChanged
        EmInput(txt_FamilyName7)
    End Sub

    Private Sub txt_RelationFamily7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily7.TextChanged
        EmInput(txt_RelationFamily7)
    End Sub

    Private Sub txt_WorkPlace7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace7.TextChanged
        EmInput(txt_WorkPlace7)
    End Sub

    Private Sub txt_FamilyName8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName8.TextChanged
        EmInput(txt_FamilyName8)
    End Sub

    Private Sub txt_RelationFamily8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily8.TextChanged
        EmInput(txt_RelationFamily8)
    End Sub

    Private Sub txt_WorkPlace8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace8.TextChanged
        EmInput(txt_WorkPlace8)
    End Sub

    Private Sub txt_FamilyName9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName9.TextChanged
        EmInput(txt_FamilyName9)
    End Sub

    Private Sub txt_RelationFamily9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily9.TextChanged
        EmInput(txt_RelationFamily9)
    End Sub

    Private Sub txt_WorkPlace9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_WorkPlace9.TextChanged
        EmInput(txt_WorkPlace9)
    End Sub

    Private Sub txt_EmergencyName1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName1.TextChanged
        EmInput(txt_EmergencyName1)
    End Sub

    Private Sub txt_EmergencyName2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName2.TextChanged
        EmInput(txt_EmergencyName2)
    End Sub

    Private Sub txt_RelationEmergency1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency1.TextChanged
        EmInput(txt_RelationEmergency1)
    End Sub

    Private Sub txt_RelationEmergency2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency2.TextChanged
        EmInput(txt_RelationEmergency2)
    End Sub

    Private Sub rtb_CommutingMethod_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_CommutingMethod.TextChanged
        EmInput(rtb_CommutingMethod)
    End Sub

    Private Sub txt_AllergyDetails_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AllergyDetails.TextChanged
        EmInput(txt_AllergyDetails)
    End Sub

    Private Sub txt_IllnessEtc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IllnessEtc.TextChanged
        EmInput(txt_IllnessEtc)
    End Sub

    Private Sub txt_Operation_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Operation.TextChanged
        EmInput(txt_Operation)
    End Sub

    Private Sub txt_SusceptibleIllness_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SusceptibleIllness.TextChanged
        EmInput(txt_SusceptibleIllness)
    End Sub

    Private Sub rtb_AnxietyAndAttention_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_AnxietyAndAttention.TextChanged
        EmInput(rtb_AnxietyAndAttention)
    End Sub

    Private Sub txt_BirthYear_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BirthYear.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_BirthMonth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BirthMonth.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_BirthDay_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BirthDay.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildAge_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildAge.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildAgeMonth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildAgeMonth.KeyPress
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
End Class
