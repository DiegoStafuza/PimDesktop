using System;
using System.Windows;

namespace EstudoWPF
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

            // Ajuste o tamanho da janela mantendo a proporção desejada (por exemplo, 16:9)
            double desiredAspectRatio = 16.0 / 9.0;

            if (width / height > desiredAspectRatio)
            {
                // Ajuste a altura para corresponder à proporção
                this.Width = height * desiredAspectRatio;
            }
            else
            {
                // Ajuste a largura para corresponder à proporção
                this.Height = width / desiredAspectRatio;
            }
        }

    }
}
