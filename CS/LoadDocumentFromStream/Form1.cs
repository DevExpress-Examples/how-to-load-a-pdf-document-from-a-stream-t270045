using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace LoadDocumentFromStream {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Stream stream = GetResourceStream("LoadDocumentFromStream.Demo.pdf");
            pdfViewer1.LoadDocument(stream);
        }

        static Stream GetResourceStream(string resourceName) {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }
    }
}



