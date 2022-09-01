using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
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
using Microsoft.Win32;
using Newtonsoft.Json;

namespace laba6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Collection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = new CultureInfo("en-US");

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
            Collection = new ObservableCollection<Item>();
            Data.DataContext = Collection;
            Data2.DataContext = Collection;
        }

        private void SaveToJsons(object sender, RoutedEventArgs e)
        {
            //save Collection to file named "items.json"
            var json = JsonConvert.SerializeObject(Collection);
            File.WriteAllText("items.json", json);
        }

        private void LoadJson(object sender, RoutedEventArgs e)
        {
            //load Collection from file named "items.json"
            var json = File.ReadAllText("items.json");
            Collection = JsonConvert.DeserializeObject<ObservableCollection<Item>>(json);
            Data.DataContext = Collection;
            Data2.DataContext = Collection;
        }

        private void ChangePicture(object sender, RoutedEventArgs e)
        {
            var selected = Data2.SelectedCells;
            if (!selected.Any()) return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var item = selected[0].Item as Item;
                item.PathToImage = (openFileDialog.FileName);
            }
        }

        private void ChangeDescription(object sender, RoutedEventArgs e)
        {
            var selected = Data2.SelectedCells;
            if (!selected.Any()) return;
            var item = selected[0].Item as Item;
            item.Description = NewDescrptionBox.Text;
        }

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            var selected = Data2.SelectedCells;
            if (!selected.Any()) return;
            var item = selected[0].Item as Item;
            Collection.Remove(item);
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
    }
}