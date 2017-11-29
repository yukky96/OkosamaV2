Imports System.Text.RegularExpressions

Public Class ChildInfoAdd

    Private encsjis As System.Text.Encoding

    Private Sub zidouhyou_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")
    End Sub

    Private Sub txt_ChildName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.txt_ChildName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_ChildName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(NameTB1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txt_ChildName.Text = txt_ChildName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_NickName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.txt_NickName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_NickName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_NickName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txt_NickName.Text = txt_NickName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_BirthYear_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_BirthMonth_KeyPress(sender As Object, _
      e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_BirthDay_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ChildAge_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ChildAgeMonth_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PostalCode1_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PostalCode2_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Tempereture_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ChildTEL1_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ChildNameKana_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_ChildNameKana.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_ChildNameKana.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_ChildNameKana.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txt_ChildNameKana.Text = txt_ChildNameKana.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_Address_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_Address.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_Address.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_Address.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txt_Address.Text = txt_Address.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_MailLocal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_MailLocal.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_MailLocal.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_MailLocal.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txt_MailLocal.Text = txt_MailLocal.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_MailDomain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_MailDomain.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_MailDomain.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_MailDomain.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_MailDomain.Text = txt_MailDomain.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_DoctorName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_DoctorName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_DoctorName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_DoctorName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_DoctorName.Text = txt_DoctorName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_FamilyName1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_FamilyName1.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_FamilyName1.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_FamilyName1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_FamilyName1.Text = txt_FamilyName1.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_RelationFamily1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_RelationFamily1.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_RelationFamily1.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_RelationFamily1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_RelationFamily1.Text = txt_RelationFamily1.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_WorkPlace1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_WorkPlace1.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_WorkPlace1.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_WorkPlace1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_WorkPlace1.Text = txt_WorkPlace1.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_FamilyName2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_FamilyName2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_FamilyName2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_FamilyName2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_FamilyName2.Text = txt_FamilyName2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_RelationFamily2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_RelationFamily2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_RelationFamily2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_RelationFamily2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_RelationFamily2.Text = txt_RelationFamily2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_WorkPlace2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_WorkPlace2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_WorkPlace2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_WorkPlace2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_WorkPlace2.Text = txt_WorkPlace2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_FamilyName3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_FamilyName3.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_FamilyName3.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_FamilyName3.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_FamilyName3.Text = txt_FamilyName3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_RelationFamily3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_RelationFamily3.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_RelationFamily3.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_RelationFamily3.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_RelationFamily3.Text = txt_RelationFamily3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_WorkPlace3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.txt_WorkPlace3.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_WorkPlace3.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_WorkPlace3.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_WorkPlace3.Text = txt_WorkPlace3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_ChildTEL2_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ChildTEL3_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_DoctorTEL1_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_DoctorTEL2_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_DoctorTEL3_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_FamilyAge1_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_FamilyTEL1_1_KeyPress(sender As Object, _
            e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub txt_FamilyName4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.txt_FamilyName4.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.txt_FamilyName4.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txt_FamilyName4.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            txt_FamilyName4.Text = txt_FamilyName4.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub txt_FamilyTEL1_2_KeyPress(sender As Object, _
            e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub
End Class
