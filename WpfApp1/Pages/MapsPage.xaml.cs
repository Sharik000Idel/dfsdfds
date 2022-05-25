using GMap.NET;
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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MapsPage.xaml
    /// </summary>
    public partial class MapsPage : Page
    {
        public MapsPage()
        {
            InitializeComponent();
        }

        private void map_load(object sender, RoutedEventArgs e)
        {
            map.Bearing = 0;
            map.CanDragMap = true;

            map.MaxZoom = 18;
            map.MinZoom = 2;
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            map.ShowTileGridLines = false;
            map.Zoom = 15;

            map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Position = new PointLatLng(55.75393, 37.620795);
        }

    }
}
