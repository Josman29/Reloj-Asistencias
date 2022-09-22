'Importamos las funciones sqlClient
Imports System.Data.SqlClient
Public Class clsUSR
    'Heredamos la clase conexion para utilizar sus metodos
    Inherits clsConexion
    'Creamos un sqlCommand para conectarnos a los procedimientos de sql
    Dim cmd As New SqlCommand

    'Funcion GetLogin nos permite realizar el proceso de validacion de usuario
    Public Function GetLogin(usu As String, pas As String) As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_USU_GET_LOG")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@USR_NIC", usu)
            cmd.Parameters.AddWithValue("@USR_PAS", pas)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function GetUsuarios() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_USU_LIST")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function
    Public Function GetEliminados() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_USU_LIST_ELI")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function DelUsu(id As Integer, id_eliminador As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_USU_DEL")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@USR_ID", id)
            cmd.Parameters.AddWithValue("@USR_BAJ_ID", id_eliminador)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function
    Public Function RecUsu(id As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_USU_REC")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@USR_ID", id)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function
End Class
