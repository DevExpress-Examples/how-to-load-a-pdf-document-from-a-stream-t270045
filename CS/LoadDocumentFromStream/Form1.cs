using System.IO;
using System.Windows.Forms;

namespace LoadDocumentFromStream {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a document from the stream.
            FileStream stream = new FileStream("..\\..\\Demo.pdf", FileMode.Open);
            pdfViewer1.LoadDocument(stream);
        }
    }
}



