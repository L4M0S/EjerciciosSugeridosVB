Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Friend conexion As MySqlConnection
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try

            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=localhost; user id=root; password=5266"
            conexion.Open()
            MessageBox.Show("Conectado al servidor")

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try

        Dim command2 As New MySqlCommand("use usuarios;", conexion)
        command2.ExecuteNonQuery()

        'Dim command3 As New MySqlCommand("select u_nombre from usuarios where u_nombre='" & UsernameTextBox.Text & "' and u_pass='" & DesEncriptar(PasswordTextBox.Text, "12345") & "'", conexion)
        'Dim command3 As New MySqlCommand("select u_nombre from usuarios where u_nombre='" & UsernameTextBox.Text & "'", conexion)

        'Dim query As String = "select u_nombre from usuarios where u_nombre='" & UsernameTextBox.Text & "' and u_pass='" & DesEncriptar(PasswordTextBox.Text, "12345")
        Dim da As New MySqlDataAdapter("select u_nombre from usuarios where u_nombre='" & UsernameTextBox.Text & "'", conexion)
        Dim ds As New DataSet()
        Dim contrasena As String
        contrasena = Encriptar(PasswordTextBox.Text, "12345")

        Dim de As New MySqlDataAdapter("select u_pass from usuarios where u_pass='" & contrasena & "'", conexion)
        Dim dr As New DataSet()

        Dim tipo As New MySqlDataAdapter("select u_tipo from usuarios where u_nombre='" & UsernameTextBox.Text & "'", conexion)
        Dim tipodata As New DataSet()



        'MessageBox.Show(reader.GetString(0))


        If da.Fill(ds) > 0 And de.Fill(dr) > 0 Then
            'DataGridView1.DataSource = ds.Tables(0)


            MessageBox.Show("Data selected")
            Me.Hide()

            Dim stm As String = "select u_tipo from usuarios where u_nombre='" & UsernameTextBox.Text & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conexion)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            reader.Read()
            If reader.GetString(0) = 1 Then
                Menu1.Show()
                Menu1.pasar(UsernameTextBox.Text)

            Else
                AboutBox1.Show()

                AboutBox1.pasar(UsernameTextBox.Text)
            End If
            reader.Close()

        ElseIf da.Fill(ds) > 0 And de.Fill(dr) = 0 Then

            MessageBox.Show("incorrect password")

        Else
            Dim command As New MySqlCommand("insert into usuarios (u_nombre, u_pass, u_tipo, u_permiso) values ('" & UsernameTextBox.Text & "','" & Encriptar(PasswordTextBox.Text, "12345") & "',1,1)", conexion)

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Data inserter")
                Me.Hide()
                AboutBox1.Show()

                AboutBox1.pasar(UsernameTextBox.Text)

            Else

                MessageBox.Show("ERROR")

            End If

        End If

        conexion.Close()




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
