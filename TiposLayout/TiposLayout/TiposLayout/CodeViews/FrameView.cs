using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class FrameView : ContentPage
	{
        public FrameView()
        {
            StackLayout stack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };
            Label header = new Label()
            {
                Text = "Frame View",
                TextColor = Color.Red,
                FontSize = 40,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            stack.Children.Add(header);
            Frame frame = new Frame()
            {
                BorderColor = Color.Fuchsia,
                HasShadow = true
            };
            stack.Children.Add(frame);
            Label lbl = new Label()
            {
                Text = "label de frame",
                TextColor = Color.Red
            };
            frame.Content = lbl;
            this.Content = stack;
		}
	}
}