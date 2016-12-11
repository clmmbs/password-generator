module module1
        sub main
                dim posschar As String = "89plokm0ijnuhb7ygv6tfc5rdx4esz3waq12QWERTYUIOPLAKSJDHFGMZNXBCV[]{};:/?.,<>!@#$%^&*()-=_+",myPass=""
                dim achar As New random()
                for i = 1 To 8
                        myPass &= posschar(achar.next(posschar.length()))
                next
                console.write("Your password is :" & vbnewline & myPass)
        end Sub
end Module
