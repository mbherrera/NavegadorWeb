Imports System.IO 'Para la lectura de archivos.
Imports System.Configuration 'Para importar el fichero de configuracion de la aplicación
Imports System.Collections.Specialized
Imports System.Xml
Imports System.Windows.Forms

Public Class confsts
    Private configXml As New XmlDocument
    Private ficConfig As String = Application.StartupPath + "\sts.xml"

    Public Sub New()
        Try
            configXml.Load(ficConfig)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Throw
        End Try
    End Sub
    'Retorna los sitios
    Public Function Sitios() As ArrayList
        Dim sit As New ArrayList
        Try
            Dim nodelist As XmlNodeList
            Dim node As XmlNode
            nodelist = configXml.SelectNodes("/sitios/sit")
            For Each node In nodelist
                Dim codigo As String = Desencriptar(node.Attributes.GetNamedItem("codigo").Value.ToString)
                Dim nombre As String = Desencriptar(node.Attributes.GetNamedItem("nombre").Value.ToString)
                Dim direccion As String = Desencriptar(node.Attributes.GetNamedItem("direccion").Value.ToString)

                Dim sitio As New sitios
                sitio.Cod = codigo
                sitio.Nomb = nombre
                sitio.Dir = direccion
                sit.Add(sitio)
            Next
            Return sit
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Throw
        End Try
    End Function
    'Actualiza los sitios
    Public Function Actualizar(ByVal lista As ArrayList) As Boolean
        Dim res As Boolean
        Try
            Dim sitio As sitios
            Dim i As Int16 = 1
            Dim cont As Int16 = lista.Count()
            Dim oXML1 As XmlTextWriter
            oXML1 = New XmlTextWriter(ficConfig, System.Text.Encoding.UTF8)
            oXML1.WriteStartElement("sitios")
            For Each sitio In lista
                oXML1.WriteStartElement("sit")
                oXML1.WriteAttributeString("codigo", Encriptar(i.ToString))
                oXML1.WriteAttributeString("nombre", Encriptar(sitio.Nomb))
                oXML1.WriteAttributeString("direccion", Encriptar(sitio.Dir))
                oXML1.WriteEndElement()
                i += 1
            Next
            oXML1.WriteEndElement()
            oXML1.Flush()
            oXML1.Close()
            res = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            res = False
        End Try
        Return res
    End Function
End Class
