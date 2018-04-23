Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace LoadDocumentFromStream
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            Dim stream As Stream = GetResourceStream("LoadDocumentFromStream.Demo.pdf")
            pdfViewer1.LoadDocument(stream)
        End Sub

        Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
            Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
        End Function
    End Class
End Namespace



