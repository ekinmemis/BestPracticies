using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PublishSubscribe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CStok cstok = new CStok("Buzdolabı", 13);

        public MainWindow()
        {
            InitializeComponent();
            this.Background = new LinearGradientBrush(Colors.AliceBlue, Colors.Blue, 10);

            txtUrun.Text = cstok.Urun;
            txtAdet.Text = cstok.Adet.ToString();

            cstok.PropertyChanged += new PropertyChangedEventHandler(stok_PropertyChanged);
        }

        void stok_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Urun":
                    txtUrun.Text = cstok.Urun;
                    break;
                case "Adet":
                    txtAdet.Text = cstok.Adet.ToString();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cstok.Adet += 1;
        }
    }
}
