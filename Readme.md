<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/LoadDocumentFromStream/Form1.cs) (VB: [Form1.vb](./VB/LoadDocumentFromStream/Form1.vb))
<!-- default file list end -->
# How to load a PDF document from a stream 


The following example illustrates how to load a document into the PDF Viewer from a Stream.


<h3>Description</h3>

To do this:<br>- Add the <strong>Demo.pdf</strong> file to the application assembly as an embedded resource.<br>- Get a <strong>Stream</strong> object representing this file.<br>- Call the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPdfViewerPdfViewer_LoadDocumenttopic(zbF5Nw)">PdfViewer.LoadDocument</a>&nbsp;method with&nbsp;a&nbsp;stream object passed as a parameter.<br><br>Note that when you load a document, the <a href="http://larix/ReferenceBrowserMain_15_1/LoadItem.aspx?Member=P%3aDevExpress.XtraPdfViewer.PdfViewer.DetachStreamAfterLoadComplete&amp;Template=MemberPropertyTopic">PdfViewer.DetachStreamAfterLoadComplete</a>&nbsp;property (set to <strong>false</strong> by default)&nbsp;prohibits closing input stream&nbsp;before the control finishes using a document. This allows the PDF Viewer to render a large PDF quickly.

<br/>


