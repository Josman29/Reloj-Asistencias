﻿'Importamos las funciones sqlClient
Imports System.Data.SqlClient
Imports Entidades
Public Class clsEMP
    'Heredamos la clase conexion para utilizar sus metodos
    Inherits clsConexion
    'Creamos un sqlCommand para conectarnos a los procedimientos de sql
    Dim cmd As New SqlCommand

    Public Function GetNombreApellido(empleado As EEMP) As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_GET_NAME")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@emp_id", empleado.EMP_ID)
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
End Class
