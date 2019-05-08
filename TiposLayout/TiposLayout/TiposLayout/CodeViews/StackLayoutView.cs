using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class StackLayoutView : ContentPage
	{
		public StackLayoutView ()
		{
            StackLayout stackPrincipal = new StackLayout();
            stackPrincipal.Margin = new Thickness(0, 40, 0, 0);
            Label header = new Label()
            {
                FontSize = 40,
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text= "texto de ejemplo"
            };
            stackPrincipal.Children.Add(header);
            Button button = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                BorderWidth = 2,
                BorderColor = Color.Red,
                Text = "ejemplo"
            };
            stackPrincipal.Children.Add(button);
            Image img = new Image()
            {
                Source = "http://3.bp.blogspot.com/-6cp7sIgYkkw/VfOdE1EdyUI/AAAAAAAACH0/J2E7zxFYJZw/s1600/120439-durarara-durarara-poster.jpg",
                WidthRequest = 100,
                HeightRequest = 150
            };
            stackPrincipal.Children.Add(img);
            //INDICAMOS EL CONTENIDO DE LA CLASE CONTENTPAGE
            this.Content = stackPrincipal;
		}
	}
}