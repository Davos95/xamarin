using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.Practicas
{
	public class Practica1Collatz : ContentPage
	{
		public Practica1Collatz ()
		{
            StackLayout stack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };

            Label header = new Label()
            {
                Text = "Practica Collatz en C#",
                FontSize = 30,
                TextColor = Color.Blue
            };
            stack.Children.Add(header);

            Entry txtNum = new Entry()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 30
                
            };

            stack.Children.Add(txtNum);
            Button calcular = new Button() {
                Text = "Calcular"
            };

            ScrollView scroll = new ScrollView()
            {
               Orientation = ScrollOrientation.Vertical
            };

            calcular.Clicked += (sender,args) => Collatz(int.Parse(txtNum.Text), scroll);
            stack.Children.Add(calcular);
            stack.Children.Add(scroll);
            this.Content = stack;
		}


        private void Collatz(int num, ScrollView layout)
        {
            StackLayout stack = new StackLayout();

            while(num != 1)
            {
                Label label = new Label()
                {
                    Text = num.ToString()
                };
                stack.Children.Add(label);
                if(num%2 == 0)
                {
                    num = num / 2;
                } else
                {
                    num = num * 3 + 1;
                }
            }

            layout.Content = stack;
        }
	}
}