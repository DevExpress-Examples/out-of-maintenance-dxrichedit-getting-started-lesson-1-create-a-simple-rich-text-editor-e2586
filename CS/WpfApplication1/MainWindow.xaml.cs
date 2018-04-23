using System.Windows;
using DevExpress.XtraRichEdit;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void NewDocumentButton_Click(object sender, RoutedEventArgs e) {
            richEditControl1.CreateNewDocument();
        }

        private void SaveDocumentButton_Click(object sender, RoutedEventArgs e) {
            richEditControl1.SaveDocument(@"C:\Temp\SavedDocument.rtf", DocumentFormat.Rtf);
        }

        private void LoadDocumentButton_Click(object sender, RoutedEventArgs e) {
            richEditControl1.LoadDocument(@"C:\Temp\SavedDocument.rtf", DocumentFormat.Rtf);
        }
    }
}
