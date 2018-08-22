Option Explicit On
Imports System.IO 'Para la lectura de archivos.
Imports System.Configuration  'Para importar el fichero de configuracion de la aplicación
Imports System.Collections.Specialized
Imports System.Xml
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Imports System.Collections

Public Class Configexp
    Private configXml As New XmlDocument
    Private ficConfig As String = Application.ExecutablePath + ".config"

    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "MEfeb11" 'Clave secreta(puede alterarse)

    Public Sub New()
        configXml.Load(ficConfig)
    End Sub
    'Retorna las variables guardadas para la configuracion
    Public Function ConfApp() As String()
        Dim cadena(4) As String
        Try
            cadena(0) = Desencriptar(ConfigurationManager.AppSettings("habilitado"))
            cadena(1) = Desencriptar(ConfigurationManager.AppSettings("entrada1"))
            cadena(2) = Desencriptar(ConfigurationManager.AppSettings("salida1"))
            cadena(3) = Desencriptar(ConfigurationManager.AppSettings("entrada2"))
            cadena(4) = Desencriptar(ConfigurationManager.AppSettings("salida2"))
            Return cadena
        Catch ex As Exception
            Throw
        End Try
    End Function
    'Actualiza los datos de configuracion
    Public Function Actualizar(ByVal hb As String, ByVal e1 As String, ByVal s1 As String, ByVal e2 As String, ByVal s2 As String) As Boolean
        Dim res, aux As Boolean
        Dim sec As String = "configuration/appSettings"
        Try
            aux = cfgSetValue(sec, "habilitado", hb)
            If Not aux = True Then
                res = False
                Exit Try
            End If
            aux = cfgSetValue(sec, "entrada1", e1)
            If Not aux = True Then
                res = False
                Exit Try
            End If
            aux = cfgSetValue(sec, "salida1", s1)
            If Not aux = True Then
                res = False
                Exit Try
            End If
            aux = cfgSetValue(sec, "entrada2", e2)
            If Not aux = True Then
                res = False
                Exit Try
            End If
            aux = cfgSetValue(sec, "salida2", s2)
            If Not aux = True Then
                res = False
                Exit Try
            End If

            configXml.Save(ficConfig)
            res = True
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function
    'Retorna la contraseña.
    Public Function passwd() As String
        Dim var As String
        Try
            var = Desencriptar(ConfigurationManager.AppSettings("pswd"))
            Return var
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    'Actualiza la contraseña
    Public Function UpPwd(ByVal pass As String) As Boolean
        Dim res As Boolean
        Dim sec As String = "configuration/appSettings"
        Try
            res = cfgSetValue(sec, "pswd", pass)
            configXml.Save(ficConfig)
            Return res
        Catch ex As Exception
            Return False
        End Try
    End Function
    'Retorna la pagina de inicio.
    Public Function paginicio() As String
        Dim var As String
        Try
            var = Desencriptar(ConfigurationManager.AppSettings("pagini"))
            Return var
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    'Actualiza la pagina de inicio.
    Public Function Uppaginicio(ByVal pagina As String) As Boolean
        Dim res As Boolean
        Dim sec As String = "configuration/appSettings"
        Try
            res = cfgSetValue(sec, "pagini", pagina)
            configXml.Save(ficConfig)
            Return res
        Catch ex As Exception
            Return False
        End Try
    End Function
    ' El método para guardar los valores
    Private Function cfgSetValue(ByVal seccion As String, ByVal clave As String, ByVal valor As String) As Boolean
        Try
            Dim x As Boolean
            Dim elem As XmlElement = configXml.SelectSingleNode(seccion & "/add[@key='" & clave & "']")
            If elem Is Nothing Then
                x = False
            Else
                ' reemplazas el valor del atributo "value"
                elem.Attributes("value").Value = Encriptar(valor)
                x = True
            End If
            Return x
        Catch ex As Exception
            Return False
        End Try
    End Function
    'Funcion para el Encriptado de Cadenas de Texto
    Private Function Encriptar(ByVal texto As String) As String
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
    Private Function Desencriptar(ByVal texto As String) As String
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
End Class
