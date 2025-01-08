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
