Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.IO

Module globales

    Public bqo As Int16

#Region "Encriptacion y Desencriptacion"
    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "MEfeb11" 'Clave secreta(puede alterarse)
#End Region

    Public Function Filtro(ByVal link As String) As Boolean
        Dim res As Boolean = False
        If BuscarTexto("youtube", link) = True Then
            res = True
        ElseIf BuscarTexto("facebook", link) = True Then
            res = True
        ElseIf BuscarTexto("twitter", link) = True Then
            res = True
        ElseIf BuscarTexto("hotmail", link) = True Then
            res = True
        ElseIf BuscarTexto("msn", link) = True Then
            res = True
        ElseIf BuscarTexto("gmail", link) = True Then
            res = True
        ElseIf BuscarTexto("yahoo", link) = True Then
            res = True
        ElseIf BuscarTexto("flickr", link) = True Then
            res = True
        ElseIf BuscarTexto("google", link) = True Then
            res = True
        ElseIf BuscarTexto("instagram", link) = True Then
            res = True
        ElseIf BuscarTexto("tumblr", link) = True Then
            res = True
        ElseIf BuscarTexto("badoo", link) = True Then
            res = True
        ElseIf BuscarTexto("linkedin", link) = True Then
            res = True
        ElseIf BuscarTexto("pinterest", link) = True Then
            res = True
        ElseIf BuscarTexto("myspace", link) = True Then
            res = True
        ElseIf BuscarTexto("soundcloud", link) = True Then
            res = True
        ElseIf BuscarTexto("getglue", link) = True Then
            res = True
        ElseIf BuscarTexto("foursquare", link) = True Then
            res = True
        ElseIf BuscarTexto("friendster", link) = True Then
            res = True
        ElseIf BuscarTexto("sonico", link) = True Then
            res = True
        ElseIf BuscarTexto("habbo", link) = True Then
            res = True
        ElseIf BuscarTexto("taringa", link) = True Then
            res = True
        ElseIf BuscarTexto("warez", link) = True Then
            res = True
        ElseIf BuscarTexto("ask", link) = True Then
            res = True
        ElseIf BuscarTexto("babylon", link) = True Then
            res = True
        ElseIf BuscarTexto("fileserve", link) = True Then
            res = True
        ElseIf BuscarTexto("jaidefinichon", link) = True Then
            res = True
        ElseIf BuscarTexto("porlaputa", link) = True Then
            res = True
        ElseIf BuscarTexto("portalnet", link) = True Then
            res = True
        ElseIf BuscarTexto("softonic", link) = True Then
            res = True
        ElseIf BuscarTexto("hi5", link) = True Then
            res = True
        ElseIf BuscarTexto("tv.htm", link) = True Then
            res = True
        ElseIf BuscarTexto("futubandera", link) = True Then
            res = True
        ElseIf BuscarTexto("bientcm", link) = True Then
            res = True
        End If
        Return res
    End Function
    'Funcion para el Encriptado de Cadenas de Texto
    Public Function Encriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function
    'Funcion para el Desencriptado de Cadenas de Texto
    Public Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function
    'Buscar palabra dentro de un texto
    Public Function BuscarTexto(palabra As String, Busqueda As String) As Boolean
        Dim i As Int16
        i = Busqueda.IndexOf(palabra) 'Si la palabra se encuentra dentro del link entonces retornara el valor de la posicion.
        If i > -1 Then 'Si la encuentra,entonces el valor sera mayor a 0 y devolvera True.
            BuscarTexto = True
        Else 'Si no sera igual a 0 y devolvera false.
            BuscarTexto = False
        End If
        Return BuscarTexto
    End Function
End Module
