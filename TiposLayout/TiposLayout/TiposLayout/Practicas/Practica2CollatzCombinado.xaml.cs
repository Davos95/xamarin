using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposLayout.Practicas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Practica2CollatzCombinado : ContentPage
	{
		public Practica2CollatzCombinado ()
		{
			InitializeComponent ();
            this.btnComenzar.Clicked += (sender, args) => RandomButtons();
		}


        private void RandomButtons()
        {
            this.layoutButtons.Children.Clear();
            Random random = new Random();
            Random random2 = new Random();
            int num = random.Next(1, 100);
            for (int i = 0; i < num; i++)
            {
                Button button = new Button() {
                    Text = random2.Next(1, 100).ToString()
                };
                button.Clicked += (sender, args) => Collatz(int.Parse(button.Text));
                this.layoutButtons.Children.Add(button);
            }
            
        }

        private void Collatz(int num)
        {
            this.layoutResult.Children.Clear();

            while (num != 1)
            {
                Label label = new Label()
                {
                    Text = num.ToString()
                };
                this.layoutResult.Children.Add(label);
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
            }

            Label label1 = new Label()
            {
                Text = "1"
            };
            this.layoutResult.Children.Add(label1);
        }
    }
}