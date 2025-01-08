# Mi Coleccion URL

 Este proyecto realiza la conexion con sitios web y luego 
 a traves de un MsgBox muestra la lista de sitios visitados
 por el usuario con informacion especifica de las visitas.

# Descripcion

 Este proyecto consiste en una aplicacion que presenta un vinculo
 web en un TextBox, adicionalmente se importa el espacio de nombres
 System.Diagnostics que diagnostica una url e inicia el metodo 
 process.start para conectarla la url a internet. Se declara una 
 nueva y personalizada coleccion: URLVisitados que almacenara cada
 sitio visitado y posteriormente a traves de un For Each se recorrera
 cada elemento de la coleccion para mostrarlo con un MsgBox con 
 informacion detallada de cada sitio visitado en la web.
 
 # Actualizacion: 08/01/2025
 # Hora: 06:19

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# My URL Collection

This project makes the connection with websites and then
through a MsgBox shows the list of sites visited by the user
with specific information about the visits.

# Description

This project consists of an application that presents a web link
in a TextBox, additionally the System.Diagnostics namespace is 
imported that diagnoses a URL and starts the process.start method 
to connect the URL to the Internet. A new and personalized collection 
is declared: URLVisited that will store each site visited and later 
through a For Each each element of the collection will be
traversed to show it with a MsgBox with detailed information about
each site visited on the web.

# Update: 01/08/2025
# Time: 06:19

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/ff5b4601-808b-40e9-bb3d-336112fa0b01)

Code of the Project:

Imports System.Diagnostics
'Espacio de nombres que diagnostica una url e inicia 
'el metodo process.start para conectarla la url a internet
Public Class Form1

    Dim URLVisitados As New Collection()
    'Se crea una nueva collecion personalizada disponible 
    'para todos los procedimientos de eventos 
    Private Sub btnVisitar_Click(sender As Object, e As EventArgs) Handles btnVisitar.Click
        URLVisitados.Add(txtUrl.Text)
        Process.Start(txtUrl.Text)

        'Agrega cada sitio escrito en el TextBox a la coleccion 
        'para luego iniciar el proceso de conectar cada sitio a la web
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim NombreURL As String = "", TodoslosURL As String = ""
        For Each NombreURL In URLVisitados
            TodoslosURL = TodoslosURL & NombreURL & vbCrLf
        Next NombreURL

        MsgBox(TodoslosURL, MsgBoxStyle.Information, "Sitios Web Visitados")

        'lista todos los url visitados por el usuario
        'los muestra por pantalla con un msgBox con detalles de las visitas
    End Sub

End Class

