using System.Windows;
using System.Windows.Controls;

namespace laba6_7;

public class Item : DependencyObject
{
    public static readonly DependencyProperty ShortnameProperty;
    public static readonly DependencyProperty LongNameProperty;
    public static readonly DependencyProperty DescriptionProperty;
    public static readonly DependencyProperty PriceProperty;
    public static readonly DependencyProperty CountProperty;
    public static readonly DependencyProperty PathToImageProperty;

    static Item()
    {
        ShortnameProperty = DependencyProperty.Register("Shortname", typeof(string), typeof(Item));
        LongNameProperty = DependencyProperty.Register("LongName", typeof(string), typeof(Item));
        DescriptionProperty = DependencyProperty.Register("Description", typeof(string), typeof(Item));
        PriceProperty = DependencyProperty.Register("Price", typeof(double), typeof(Item));
        CountProperty = DependencyProperty.Register("Count", typeof(int), typeof(Item));
        PathToImageProperty = DependencyProperty.Register("PathToImage", typeof(string), typeof(Item));
    }

    public string Shortname
    {
        get { return (string)GetValue(ShortnameProperty); }
        set { SetValue(ShortnameProperty, value); }
    }

    public string LongName
    {
        get { return (string)GetValue(LongNameProperty); }
        set { SetValue(LongNameProperty, value); }
    }

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }

    public double Price
    {
        get { return (double)GetValue(PriceProperty); }
        set { SetValue(PriceProperty, value); }
    }

    public int Count
    {
        get { return (int)GetValue(CountProperty); }
        set { SetValue(CountProperty, value); }
    }

    public string PathToImage
    {
        get { return (string)GetValue(PathToImageProperty); }
        set { SetValue(PathToImageProperty, value); }
    }
}