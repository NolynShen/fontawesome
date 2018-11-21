using System;
using System.Collections.Generic;
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

namespace fontawesome.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //更换资源字典
            foreach (string item in Application.Current.Resources.MergedDictionaries[0].MergedDictionaries[2].Keys)
            {
                Components.FontBooth fontBooth = new Components.FontBooth() {};
                fontBooth.des.Text = item;
                fontBooth.glyphicon.Data = Application.Current.Resources[item] as StreamGeometry;
                panel.Children.Add(fontBooth);
            }
        }
    }
}
