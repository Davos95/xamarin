using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class FlexLayoutPage : ContentPage
	{
		public FlexLayoutPage ()
		{
            StackLayout stack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };
            Label label = new Label()
            {
                Text = "Flex Layout",
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            stack.Children.Add(label);

            FlexLayout flex = new FlexLayout()
            {
                Direction = FlexDirection.Column,
                AlignItems = FlexAlignItems.Center,
                JustifyContent = FlexJustify.Start
            };
            Label lbl1 = new Label()
            {
                Text = "control 1"
            };
            Entry entry = new Entry()
            {
                Text = "entry 1"
            };
            Image image = new Image()
            {
                Source = "http://3.bp.blogspot.com/-6cp7sIgYkkw/VfOdE1EdyUI/AAAAAAAACH0/J2E7zxFYJZw/s1600/120439-durarara-durarara-poster.jpg",
                WidthRequest = 100,
                HeightRequest = 150
            };
            Button button = new Button()
            {
                Text = "boton1"
            };
            flex.Children.Add(lbl1);
            flex.Children.Add(entry);
            flex.Children.Add(image);
            flex.Children.Add(button);
            stack.Children.Add(flex);
            this.Content = stack;
		}
	}
}