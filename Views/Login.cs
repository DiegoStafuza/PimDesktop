using System;
using System.Windows;

namespace PimDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SizeChanged += MainWindow_SizeChanged; // Adicione o manipulador de eventos SizeChanged
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Mantenha a proporção da janela
            double width = e.NewSize.Width;
            double height = e.NewSize.Height;

            // Ajuste do tamanho da janela mantendo a proporção desejada (por exemplo, 16:9)
            double desiredAspectRatio = 16.0 / 9.0;

            if (width / height > desiredAspectRatio)
            {
                // Ajuste da altura para corresponder à proporção
                this.Width = height * desiredAspectRatio;
            }
            else
            {
                // Ajuste da largura para corresponder à proporção
                this.Height = width / desiredAspectRatio;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
        }
    }
}
