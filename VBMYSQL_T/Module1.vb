Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public strConnect = "server=archiecaragay.cloudaccess.host; username=cozxtapo; password=0f8KE5N)t)jhA7; database=cozxtapo;"

    Sub OpenCon()
        con.ConnectionString = strConnect
        con.Open()
    End Sub
End Module
