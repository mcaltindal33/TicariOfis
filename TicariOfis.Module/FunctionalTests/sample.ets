;#DropDB TicariOfisEasyTest

#Application TicariOfis.Win
#Application TicariOfis.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef TicariOfis.Win

*Action About...
 
*Action OK

#EndIf

#IfDef TicariOfis.Web
*Action Navigation(My Details)
#EndIf
