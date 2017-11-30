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

    Private Sub txt_ChildName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.TextChanged
        EmInput(txt_ChildName)
    End Sub

    Private Sub txt_NickName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.TextChanged
        EmInput(txt_NickName)
    End Sub

    Private Sub txt_ChildNameKana_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_ChildNameKana)
    End Sub

    Private Sub txt_Address_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_Address)
    End Sub

    Private Sub txt_DoctorName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_DoctorName)
    End Sub

    Private Sub txt_FamilyName1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_FamilyName1)
    End Sub

    Private Sub txt_RelationFamily1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_RelationFamily1)
    End Sub

    Private Sub txt_WorkPlace1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_WorkPlace1)
    End Sub

    Private Sub txt_FamilyName2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_FamilyName2)
    End Sub

    Private Sub txt_RelationFamily2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_RelationFamily2)
    End Sub

    Private Sub txt_WorkPlace2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_WorkPlace2)
    End Sub

    Private Sub txt_FamilyName3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_FamilyName3)
    End Sub

    Private Sub txt_RelationFamily3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_RelationFamily3)
    End Sub

    Private Sub txt_WorkPlace3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EmInput(txt_WorkPlace3)
    End Sub

    Private Sub txt_FamilyName4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.TextChanged
        EmInput(txt_FamilyName4)
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

    Private Sub txt_FamilyTEL1_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_2.KeyPress
        NumInput(e)
    End Sub
End Class
