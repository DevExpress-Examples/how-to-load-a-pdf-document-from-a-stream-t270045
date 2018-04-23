Imports System.IO
Imports System.Windows.Forms

Namespace LoadDocumentFromStream
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a document from the stream.
            Dim stream As New FileStream("..\..\Demo.pdf", FileMode.Open)
            pdfViewer1.LoadDocument(stream)
        End Sub
    End Class
End Namespace



