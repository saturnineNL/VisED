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

namespace VisED
{
    /// <summary>
    /// Interaction logic for MarketDisplay.xaml
    /// </summary>
    public partial class MarketDisplay : UserControl
    {
        public MarketDisplay()
        {
            InitializeComponent();

            BuildDisplay();
        }

        public void BuildDisplay()
        {
            Grid commodityMarketGrid = new Grid();
            Grid marketContentGrid = new Grid();

            commodityMarketGrid.Width = 1186;
            commodityMarketGrid.Height =792;

            marketContentGrid.Width = 1186;
            marketContentGrid.Height = 720;

            double[] rowSize = { 1,10 };
            double[] columnSize= {360,90,90,90,145,30,145,30,175};

            RowDefinitionCollection contentRowDefCollection = marketContentGrid.RowDefinitions;
            ColumnDefinitionCollection contentColDefCollection = marketContentGrid.ColumnDefinitions;

            RowDefinitionCollection marketRowDefCollection = commodityMarketGrid.RowDefinitions;
            ColumnDefinitionCollection marketColDefCollection = commodityMarketGrid.ColumnDefinitions;

            Rectangle[] backFill = new Rectangle[18];

            TextBox[] commodityName = new TextBox[18];
            TextBox[] sellPrice = new TextBox[18];
            TextBox[] buyPrice = new TextBox[18];
            TextBox[] amount = new TextBox[18];
            TextBox[] demand = new TextBox[18];
            TextBox[] supply = new TextBox[18];

            TextBox commodityNameTitle=new TextBox();
            TextBox sellTitle = new TextBox();
            TextBox buyTitle = new TextBox();
            TextBox amountTitle = new TextBox();
            TextBox demandTitle = new TextBox();
            TextBox supplyTitle = new TextBox();
            TextBox dropTitle = new TextBox();

            TextBox commodityItem = new TextBox();
            TextBox commodityGroup = new TextBox();

            TextBox sellToMarket = new TextBox();
            TextBox buyFromMarket = new TextBox();

            TextBox sellDisplay = new TextBox();
            TextBox buyDisplay = new TextBox();

            TextBox time = new TextBox();
            TextBox date = new TextBox();

            commodityNameTitle.Height = 70;
            commodityNameTitle.Width = 360;
            commodityNameTitle.Margin = new Thickness(0,0,0,0);
            commodityNameTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            commodityNameTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            commodityNameTitle.Padding = new Thickness(2, 0, 0, 0);
            commodityNameTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            commodityNameTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            commodityNameTitle.BorderThickness = new Thickness(0);
            commodityNameTitle.IsReadOnly = true;
            commodityNameTitle.Focusable = false;

            commodityNameTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            commodityNameTitle.FontWeight=FontWeights.Bold;
            commodityNameTitle.FontSize = 18.75;

            commodityNameTitle.Text = "GOODS";
            
            stage.Children.Add(commodityNameTitle);

            sellTitle.Height = 70;
            sellTitle.Width = 90;
            sellTitle.Margin = new Thickness(370, 0, 0, 0);
            sellTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            sellTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            sellTitle.Padding = new Thickness(2, 0, 0, 0);
            sellTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            sellTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            sellTitle.BorderThickness = new Thickness(0);
            sellTitle.IsReadOnly = true;
            sellTitle.Focusable = false;

            sellTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            sellTitle.FontWeight = FontWeights.Bold;
            sellTitle.FontSize = 18.75;

            sellTitle.Text = "SELL";

            Line gridline = new Line(); 
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 370;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);
            stage.Children.Add(sellTitle);
           
            buyTitle.Height = 70;
            buyTitle.Width = 90;
            buyTitle.Margin = new Thickness(465, 0, 0, 0);
            buyTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            buyTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            buyTitle.Padding = new Thickness(2, 0, 0, 0);
            buyTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            buyTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            buyTitle.BorderThickness = new Thickness(0);
            buyTitle.IsReadOnly = true;
            buyTitle.Focusable = false;

            buyTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            buyTitle.FontWeight = FontWeights.Bold;
            buyTitle.FontSize = 18.75;

            buyTitle.Text = "BUY";

            gridline = new Line();
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 465;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);
            stage.Children.Add(buyTitle);

            amountTitle.Height = 70;
            amountTitle.Width = 90;
            amountTitle.Margin = new Thickness(555, 0, 0, 0);
            amountTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            amountTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            amountTitle.Padding = new Thickness(2, 0, 0, 0);
            amountTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            amountTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            amountTitle.BorderThickness = new Thickness(0);
            amountTitle.IsReadOnly = true;
            amountTitle.Focusable = false;

            amountTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            amountTitle.FontWeight = FontWeights.Bold;
            amountTitle.FontSize = 18.75;

            amountTitle.Text = "CARGO";

            gridline = new Line();
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 555;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);
            stage.Children.Add(amountTitle);

            demandTitle.Height = 70;
            demandTitle.Width = 90;
            demandTitle.Margin = new Thickness(650, 0, 0, 0);
            demandTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            demandTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            demandTitle.Padding = new Thickness(2, 0, 0, 0);
            demandTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            demandTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            demandTitle.BorderThickness = new Thickness(0);
            demandTitle.IsReadOnly = true;
            demandTitle.Focusable = false;

            demandTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            demandTitle.FontWeight = FontWeights.Bold;
            demandTitle.FontSize = 18.75;

            demandTitle.Text = "DEMAND";

            gridline = new Line();
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 650;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);
            stage.Children.Add(demandTitle);

            supplyTitle.Height = 70;
            supplyTitle.Width = 90;
            supplyTitle.Margin = new Thickness(830, 0, 0, 0);
            supplyTitle.VerticalContentAlignment = VerticalAlignment.Bottom;
            supplyTitle.HorizontalContentAlignment = HorizontalAlignment.Left;
            supplyTitle.Padding = new Thickness(2, 0, 0, 0);
            supplyTitle.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            supplyTitle.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            supplyTitle.BorderThickness = new Thickness(0);
            supplyTitle.IsReadOnly = true;
            supplyTitle.Focusable = false;

            supplyTitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            supplyTitle.FontWeight = FontWeights.Bold;
            supplyTitle.FontSize = 18.75;

            supplyTitle.Text = "supply";

            gridline = new Line();
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 830;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);
            stage.Children.Add(supplyTitle);

            gridline = new Line();
            gridline.StrokeThickness = 1;
            gridline.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0x7E, 0x2F, 0x0B));

            gridline.X1 = gridline.X2 = 1010;
            gridline.Y1 = 70;
            gridline.Y2 = 796;

            stage.Children.Add(gridline);

            for (int column = 0; column < columnSize.Length; column++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width=new GridLength(columnSize[column],GridUnitType.Star);

                contentColDefCollection.Add(columnDefinition);

            }
            
            for (int row = 0; row < 18; row++)
            {
              
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(1.0, GridUnitType.Star);

                contentRowDefCollection.Add(rowDefinition);

                commodityName[row]=new TextBox();
                sellPrice[row]=new TextBox();
                buyPrice[row] = new TextBox();
                amount[row]=new TextBox();
                demand[row] = new TextBox();
                supply[row]=new TextBox();

                backFill[row] = new Rectangle();
                backFill[row].Fill = new SolidColorBrush(Color.FromArgb(0x7F, 0x4F, 0x1A, 0x0B));
                backFill[row].Height = 30;

                Grid.SetRow(backFill[row], row);
                Grid.SetColumnSpan(backFill[row], 9);

                marketContentGrid.Children.Add(backFill[row]);

                commodityName[row].Height = 30;
                commodityName[row].Width = 370;

                commodityName[row].VerticalContentAlignment=VerticalAlignment.Center;
                commodityName[row].Padding=new Thickness(45,0,0,0);

                commodityName[row].FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                commodityName[row].FontSize = 20.75;

                commodityName[row].Foreground=new SolidColorBrush(Color.FromArgb(0xFF,0xF4,0x6B,0x0B));
                commodityName[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                commodityName[row].BorderThickness = new Thickness(0);
                commodityName[row].IsReadOnly = true;
                commodityName[row].Focusable = false;
                commodityName[row].Text = "commodity name";

                Grid.SetRow(commodityName[row],row);
                Grid.SetColumn(commodityName[row],0);
                
                marketContentGrid.Children.Add(commodityName[row]);

                sellPrice[row].Height = 30;
                sellPrice[row].Width = 90;

                sellPrice[row].VerticalContentAlignment=VerticalAlignment.Center;
                sellPrice[row].HorizontalContentAlignment=HorizontalAlignment.Right;
                sellPrice[row].Padding=new Thickness(0,0,5,0);

                sellPrice[row].FontFamily= new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                sellPrice[row].FontSize = 20.75;

                sellPrice[row].Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                sellPrice[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                sellPrice[row].BorderThickness=new Thickness(0);
                sellPrice[row].IsReadOnly = true;
                sellPrice[row].Focusable = false;
                sellPrice[row].Text = "000";

                Grid.SetRow(sellPrice[row],row);
                Grid.SetColumn(sellPrice[row],1);

                marketContentGrid.Children.Add(sellPrice[row]);

                buyPrice[row].Height = 30;
                buyPrice[row].Width = 90;

                buyPrice[row].VerticalContentAlignment = VerticalAlignment.Center;
                buyPrice[row].HorizontalContentAlignment = HorizontalAlignment.Right;
                buyPrice[row].Padding = new Thickness(0, 0, 5, 0);

                buyPrice[row].FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                buyPrice[row].FontSize = 20.75;

                buyPrice[row].Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                buyPrice[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                buyPrice[row].BorderThickness = new Thickness(0);
                buyPrice[row].IsReadOnly = true;
                buyPrice[row].Focusable = false;
                buyPrice[row].Text = "000";

                Grid.SetRow(buyPrice[row], row);
                Grid.SetColumn(buyPrice[row], 2);

                marketContentGrid.Children.Add(buyPrice[row]);

                amount[row].Height = 30;
                amount[row].Width = 90;

                amount[row].VerticalContentAlignment = VerticalAlignment.Center;
                amount[row].HorizontalContentAlignment = HorizontalAlignment.Right;
                amount[row].Padding = new Thickness(0, 0, 5, 0);

                amount[row].FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                amount[row].FontSize = 20.75;

                amount[row].Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                amount[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                amount[row].BorderThickness = new Thickness(0);
                amount[row].IsReadOnly = true;
                amount[row].Focusable = false;
                amount[row].Text = "-";

                Grid.SetRow(amount[row], row);
                Grid.SetColumn(amount[row], 3);

                marketContentGrid.Children.Add(amount[row]);

                demand[row].Height = 30;
                demand[row].Width = 145;

                demand[row].VerticalContentAlignment = VerticalAlignment.Center;
                demand[row].HorizontalContentAlignment = HorizontalAlignment.Right;
                demand[row].Padding = new Thickness(0, 0, 5, 0);

                demand[row].FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                demand[row].FontSize = 20.75;

                demand[row].Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                demand[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                demand[row].BorderThickness = new Thickness(0);
                demand[row].IsReadOnly = true;
                demand[row].Focusable = false;
                demand[row].Text = "000,000";

                Grid.SetRow(demand[row], row);
                Grid.SetColumn(demand[row], 4);

                marketContentGrid.Children.Add(demand[row]);

                Rectangle RecD1 = new Rectangle();
                Rectangle RecD2 = new Rectangle();
                Rectangle RecD3 = new Rectangle();

                RecD1.Width = RecD2.Width = RecD3.Width = 20;
                RecD1.Height = RecD2.Height = RecD3.Height = 6;

                RecD1.Margin = new Thickness(0, 0, 5, 18);
                RecD2.Margin = new Thickness(0, 0, 5, 0);
                RecD3.Margin = new Thickness(0, 18, 5, 0);

                RecD1.Stroke = RecD2.Stroke = RecD3.Stroke=new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                RecD1.Fill = RecD2.Fill=RecD3.Fill = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                Grid.SetRow(RecD1, row);
                Grid.SetColumn(RecD1, 5);

                Grid.SetRow(RecD2, row);
                Grid.SetColumn(RecD2, 5);

                Grid.SetRow(RecD3, row);
                Grid.SetColumn(RecD3, 5);

                marketContentGrid.Children.Add(RecD1);
                marketContentGrid.Children.Add(RecD2);
                marketContentGrid.Children.Add(RecD3);

                supply[row].Height = 30;
                supply[row].Width = 145;

                supply[row].VerticalContentAlignment = VerticalAlignment.Center;
                supply[row].HorizontalContentAlignment = HorizontalAlignment.Right;
                supply[row].Padding = new Thickness(0, 0, 5, 0);

                supply[row].FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
                supply[row].FontSize = 20.75;

                supply[row].Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                supply[row].Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
                supply[row].BorderThickness = new Thickness(0);
                supply[row].IsReadOnly = true;
                supply[row].Focusable = false;
                supply[row].Text = "000,000";

                Grid.SetRow(supply[row], row);
                Grid.SetColumn(supply[row], 6);

                marketContentGrid.Children.Add(supply[row]);

                Rectangle RecS1 = new Rectangle();
                Rectangle RecS2 = new Rectangle();
                Rectangle RecS3 = new Rectangle();

                RecS1.Width = RecS2.Width = RecS3.Width = 20;
                RecS1.Height = RecS2.Height = RecS3.Height = 6;

                RecS1.Margin = new Thickness(0, 0, 5, 18);
                RecS2.Margin = new Thickness(0, 0, 5, 0);
                RecS3.Margin = new Thickness(0, 18, 5, 0);

                RecS1.StrokeThickness = RecS2.StrokeThickness = RecS3.StrokeThickness = 0.5;
                RecS1.Stroke = RecS2.Stroke = RecS3.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
                RecS1.Fill = RecS2.Fill = RecS3.Fill = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));

                Grid.SetRow(RecS1, row);
                Grid.SetColumn(RecS1, 7);

                Grid.SetRow(RecS2, row);
                Grid.SetColumn(RecS2, 7);

                Grid.SetRow(RecS3, row);
                Grid.SetColumn(RecS3, 7);

                marketContentGrid.Children.Add(RecS1);
                marketContentGrid.Children.Add(RecS2);
                marketContentGrid.Children.Add(RecS3);
            }


            commodityItem.Height = 45;
            commodityItem.Width = 400;

            commodityItem.VerticalContentAlignment = VerticalAlignment.Center;
            commodityItem.Padding = new Thickness(5, 0, 0, 0);
            commodityItem.Margin=new Thickness(1320,0,0,0);
            commodityItem.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            commodityItem.FontSize = 32.75;

            commodityItem.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            commodityItem.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            commodityItem.BorderThickness = new Thickness(0);
            commodityItem.FontWeight = FontWeights.Bold;
            commodityItem.IsReadOnly = true;
            commodityItem.Focusable = false;
            commodityItem.Text = "commodities Item";

            stage.Children.Add(commodityItem);

            commodityGroup.Height = 45;
            commodityGroup.Width = 400;

            commodityGroup.VerticalContentAlignment = VerticalAlignment.Center;
            commodityGroup.Padding = new Thickness(5, 0, 0, 0);
            commodityGroup.Margin = new Thickness(1320, 35, 0, 0);
            commodityGroup.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            commodityGroup.FontSize = 21.5;

            commodityGroup.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));
            commodityGroup.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            commodityGroup.BorderThickness = new Thickness(0);
            commodityGroup.IsReadOnly = true;
            commodityGroup.Focusable = false;
            commodityGroup.Text = "industrial materials";

            stage.Children.Add(commodityGroup);

            sellToMarket.Height = 45;
            sellToMarket.Width = 400;

            sellToMarket.VerticalContentAlignment = VerticalAlignment.Center;
            sellToMarket.Padding = new Thickness(5, 0, 0, 0);
            sellToMarket.Margin = new Thickness(1265, 85, 0, 0);
            sellToMarket.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            sellToMarket.FontSize = 21.5;

            sellToMarket.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x66, 0x2A, 0x0B));
            sellToMarket.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            sellToMarket.BorderThickness = new Thickness(0);
            sellToMarket.IsReadOnly = true;
            sellToMarket.Focusable = false;
            sellToMarket.Text = "sell to market";

            stage.Children.Add(sellToMarket);

            sellDisplay.Height = 45;
            sellDisplay.Width = 215;

            sellDisplay.VerticalContentAlignment = VerticalAlignment.Center;
            sellDisplay.HorizontalContentAlignment = HorizontalAlignment.Right;

            sellDisplay.Padding = new Thickness(0, 0, 0, 0);
            sellDisplay.Margin = new Thickness(1260, 120, 0, 0);
            sellDisplay.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            sellDisplay.FontSize = 32.75;

            sellDisplay.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x4F, 0x4F, 0x4F));
            sellDisplay.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            sellDisplay.BorderThickness = new Thickness(0);
            sellDisplay.FontWeight = FontWeights.Bold;
            sellDisplay.IsReadOnly = true;
            sellDisplay.Focusable = false;
            sellDisplay.Text = "000,000 cr";

            stage.Children.Add(sellDisplay);

            buyFromMarket.Height = 45;
            buyFromMarket.Width = 400;

            buyFromMarket.VerticalContentAlignment = VerticalAlignment.Center;
            buyFromMarket.Padding = new Thickness(5, 0, 0, 0);
            buyFromMarket.Margin = new Thickness(1500, 85, 0, 0);
            buyFromMarket.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            buyFromMarket.FontSize = 21.5;

            buyFromMarket.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x66, 0x2A, 0x0B));
            buyFromMarket.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            buyFromMarket.BorderThickness = new Thickness(0);
            buyFromMarket.IsReadOnly = true;
            buyFromMarket.Focusable = false;
            buyFromMarket.Text = "buy from market";

            stage.Children.Add(buyFromMarket);

            buyDisplay.Height = 45;
            buyDisplay.Width = 215;

            buyDisplay.VerticalContentAlignment = VerticalAlignment.Center;
            buyDisplay.HorizontalContentAlignment = HorizontalAlignment.Right;

            buyDisplay.Padding = new Thickness(0, 0, 0, 0);
            buyDisplay.Margin = new Thickness(1500, 120, 0, 0);
            buyDisplay.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Euro Caps");
            buyDisplay.FontSize = 32.75;

            buyDisplay.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x4F, 0x4F, 0x4F));
            buyDisplay.Background = new SolidColorBrush(Color.FromArgb(0x00, 0x00, 0x00, 0x00));
            buyDisplay.BorderThickness = new Thickness(0);
            buyDisplay.FontWeight = FontWeights.Bold;
            buyDisplay.IsReadOnly = true;
            buyDisplay.Focusable = false;
            buyDisplay.Text = "000,000 cr";

            stage.Children.Add(buyDisplay);

            Line topLine = new Line();
            Line bottomLine = new Line();

            topLine.X1 = 0;
            topLine.Y1 = 0;

            topLine.Y2 = topLine.Y1;
            topLine.X2 = 1184;

            topLine.StrokeThickness = 2;

            topLine.Stroke=new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));

            bottomLine.X1 = 0;
            bottomLine.Y1 = 70;

            bottomLine.Y2 = bottomLine.Y1;
            bottomLine.X2 = 1184;

            bottomLine.StrokeThickness = 2;

            bottomLine.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x6B, 0x0B));

            Line panelTopLine = new Line();

            panelTopLine.X1 = 1250;
            panelTopLine.X2 = 1730;

            panelTopLine.Y1 = panelTopLine.Y2 = 0;
            panelTopLine.Stroke = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0x76, 0x10));
            panelTopLine.StrokeThickness = 2;

            stage.Children.Add(panelTopLine);
          
            stage.Children.Add(topLine);
            stage.Children.Add(bottomLine);
            
            Grid.SetRow(marketContentGrid,1);

            MasterGrid.Children.Add(marketContentGrid);

        }
    }
}
