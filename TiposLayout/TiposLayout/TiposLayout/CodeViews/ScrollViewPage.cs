using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class ScrollViewPage : ContentPage
	{
		public ScrollViewPage ()
		{
            StackLayout stack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };
            Label header = new Label()
            {
                Text = "Scroll botoner",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Blue
            };
            stack.Children.Add(header);
            //CREAMOS EL SCROLLVIEW
            ScrollView scroll = new ScrollView();
            scroll.Orientation = ScrollOrientation.Vertical;
            //AÑADIMOS EL SCROLL AL LAYOUT PRINCIPAL
            stack.Children.Add(scroll);
            //DENTRO DEL SCROLL SOLAMENTE PODEMOS TENER UN CONTROL
            //CREAMOS UN LAYOUT QUE CONTENDRA TODOS LOS BOTONES
            StackLayout contenedor = new StackLayout();
            contenedor.BackgroundColor = Color.YellowGreen;
            contenedor.VerticalOptions = LayoutOptions.FillAndExpand;
            //GENERAMOS CONTROLES DINAMICAMENTE SOBRE EL LAYOUT
            for (int i = 0; i <= 30; i++)
            {
                Button button = new Button()
                {
                    Text = "Button" + i.ToString(),
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };
                //INCLUIMOS AL CONTENEDOR CADA BOTON
                contenedor.Children.Add(button);
            }
            //INDICAMOS AL SCROLLVIEW QUE OBJETO TENDRÁ EN SU INTERIOR (SOLO UNO)
            scroll.Content = contenedor;
            //INDICAMOS A LA PAGINA EL CONTENEDOR PRINCIPAL
            this.Content = stack;
        }
	}
}