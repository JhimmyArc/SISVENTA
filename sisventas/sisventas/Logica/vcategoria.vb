﻿Public Class vcategoria
    Dim idcategoria As Integer
    Dim nombre_categoria As String




    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property



    Public Property gnombre_categoria
        Get
            Return nombre_categoria
        End Get
        Set(ByVal value)
            nombre_categoria = value
        End Set
    End Property

    Public Property vproducto As vproducto
        Get
            Return Nothing
        End Get
        Set(value As vproducto)
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idccategoria As Integer, ByVal nombre_categoria As String)

        gidcategoria = idcategoria
        gnombre_categoria = nombre_categoria


    End Sub

End Class
