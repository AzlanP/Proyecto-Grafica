﻿Public Class CEServicios
    Private _IDservicio As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Cantidad As Integer

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property IDServicio As Integer
        Get
            Return _IDservicio
        End Get
        Set(ByVal value As Integer)
            _IDservicio = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
End Class
