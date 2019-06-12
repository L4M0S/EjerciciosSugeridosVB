Imports MySql.Data.MySqlClient

Public Class Menu1

    Friend conexion As MySqlConnection

    Public Sub pasar(ByVal cadena)


        Me.Label2.Text = cadena

    End Sub


    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=localhost; user id=root; password=5266"
            conexion.Open()
            MessageBox.Show("Conectado al servidor")

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim tipo As Integer
        tipo = CheckBox1.CheckState
        'MessageBox.Show(tipo)

        Dim stm As String = "select u_permiso from usuarios where u_nombre='" & Label2.Text & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, conexion)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Dim autorizado As Boolean

        reader.Read()


        If reader.GetString(0) = 1 Then
            autorizado = True
        Else
            autorizado = False
        End If
        reader.Close()

        Dim val As Integer

        val = Convert.ToInt32(TextBox3.Text())

        Dim command As New MySqlCommand("insert into usuarios (u_nombre, u_pass, u_tipo, u_permiso) values ('" & TextBox1.Text & "','" & Encriptar(TextBox2.Text, "12345") & "','" & tipo & "','" & val & "')", conexion)

        If command.ExecuteNonQuery() = 1 And autorizado = True Then

            MessageBox.Show("Data inserter")

        Else

            MessageBox.Show("ERROR")

        End If
        conexion.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=localhost; user id=root; password=5266"
            conexion.Open()
            MessageBox.Show("Conectado al servidor")

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim tipo As Integer
        tipo = CheckBox1.CheckState
        'MessageBox.Show(tipo)

        Dim stm As String = "select u_permiso from usuarios where u_nombre='" & Label2.Text & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, conexion)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Dim autorizado As Boolean

        reader.Read()
        If reader.GetString(0) <= 3 Then
            autorizado = True
        Else

        End If
        reader.Close()


        Dim command As New MySqlCommand("delete from usuarios where u_nombre='" & TextBox1.Text & "'", conexion)

        If command.ExecuteNonQuery() = 1 And autorizado = True Then

            MessageBox.Show("Data delete")

        Else

            MessageBox.Show("ERROR")

        End If
        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=localhost; user id=root; password=5266"
            conexion.Open()
            MessageBox.Show("Conectado al servidor")

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim tipo As Integer
        tipo = CheckBox1.CheckState
        'MessageBox.Show(tipo)
        Dim val As Integer

        val = Convert.ToInt32(TextBox3.Text())

        Dim stm As String = "select u_permiso from usuarios where u_nombre='" & Label2.Text & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, conexion)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Dim autorizado As Boolean

        reader.Read()
        If reader.GetString(0) <= 2 Then
            autorizado = True
        Else

        End If
        reader.Close()


        Dim command As New MySqlCommand("update usuarios set u_tipo='" & tipo & "'where u_nombre='" & TextBox1.Text & "'", conexion)
        Dim command2 As New MySqlCommand("update usuarios set u_permiso='" & val & "'where u_nombre='" & TextBox1.Text & "'", conexion)

        If command.ExecuteNonQuery() = 1 And autorizado = True And command2.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data modified")

        Else

            MessageBox.Show("ERROR")

        End If
        conexion.Close()
    End Sub
End Class