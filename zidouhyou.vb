Imports System.Text.RegularExpressions

Public Class zidouhyou

    Private encsjis As System.Text.Encoding

    Private Sub zidouhyou_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")
    End Sub

    Private Sub ChildTB1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameTB1.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.NameTB1.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.NameTB1.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(NameTB1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            NameTB1.Text = NameTB1.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub NicknameTB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NicknameTB.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.NicknameTB.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.NicknameTB.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(NicknameTB.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            NicknameTB.Text = NicknameTB.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub TEL1TB_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL2TB_KeyPress(sender As Object, _
      e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL3TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL4TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL5TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL6TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL7TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL8TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TEL9TB_KeyPress(sender As Object, _
     e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub ChildTB2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            ChildTB2.Text = ChildTB2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB3.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB3.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            ChildTB3.Text = ChildTB3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB4.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB4.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB4.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            ChildTB4.Text = ChildTB4.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB5.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB5.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB5.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            ChildTB5.Text = ChildTB5.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB6.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB6.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB6.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            ChildTB6.Text = ChildTB6.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB7.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB7.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB7.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            ChildTB7.Text = ChildTB7.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub ChildTB8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.ChildTB8.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.ChildTB7.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(ChildTB8.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            ChildTB8.Text = ChildTB8.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox1.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox1.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox1.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox1.Text = relationshipTextBox1.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox2.Text = relationshipTextBox2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox3.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox3.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox3.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox3.Text = relationshipTextBox3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox4.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox4.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox4.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox4.Text = relationshipTextBox4.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox5.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox5.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox5.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox5.Text = relationshipTextBox5.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox6.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox6.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox6.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox6.Text = relationshipTextBox3.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub relationshipTextBox7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim z As String = String.Empty
        For Each s As String In Me.relationshipTextBox7.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.relationshipTextBox7.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(relationshipTextBox7.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            relationshipTextBox7.Text = relationshipTextBox7.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub OldTB1_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub OldTB2_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub OldTB3_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub OldTB4_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub OldTB5_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TsuuenTimeTextBox1_KeyPress(sender As Object, _
        e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub TsuuenTimeTextBox2_KeyPress(sender As Object, _
            e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    Private Sub FuriganaTB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FuriganaTB.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.FuriganaTB.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.FuriganaTB.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(FuriganaTB.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文を半角に変換したもの
            FuriganaTB.Text = FuriganaTB.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While

    End Sub

    Private Sub AVGbodytempTB_KeyPress(sender As Object, _
            e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub

End Class
