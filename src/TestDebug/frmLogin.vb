Imports CdMLMS.modLogin

Public Class frmLogin

    Sub Init() Handles Me.Load

    End Sub


    Sub ListEverything() Handles btnShow.Click

        If txtUser.Text = "secret" Then
            MessageBox.Show("Hey, you! You found my secret treasure?!", "Oh! Hey!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MessageBox.Show("Hehehe. That's okay." + vbLf + _
                            "I guess this is the time you should know about" + vbLf + _
                            "the development of this system", "Oh! I see...", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show("Man, making this system alone is very hard!" + vbLf + _
                            "Not only I designed the UI, I also need to program it," + vbLf + _
                            "top with a large dose of headache in making documentation.")

            MessageBox.Show("Overall, I still feel like this system will unlikely be finished" + vbLf + "and that makes me sad. :(")

            MessageBox.Show("Why, you said?" + vbLf + "A lot of things happened: conflicting schedules, headache-inducing groupmates, and whatnot.")

            MessageBox.Show("Still..." + vbLf + "*sigh*")

            MessageBox.Show("I wish the definition of 'groupings' won't completely blurred." + vbLf + "Because, I feel like...")

            MessageBox.Show("I'm just doing the things myself in the future, without depending with others...")

            MessageBox.Show("I think that's all. HAHAHAHA!" + vbLf + _
                "Thanks for hanging out with me, even for a short time" + vbLf + _
                "Welp, see you next time! Bye", "I...", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show("C, B S." + vbLf + "August 4, 2022 | 11:26a")
            Exit Sub
        End If


        If CheckAccount(txtUser.Text.ToString, txtPass.Text.ToString) = True Then
            Me.Hide()
            frmMain.Show()
        Else
            Exit Sub
        End If
    End Sub

    Sub Hold() Handles btnLook.MouseDown
        txtPass.UseSystemPasswordChar = False
    End Sub

    Sub Release() Handles btnLook.MouseUp
        txtPass.UseSystemPasswordChar = True
    End Sub

End Class
