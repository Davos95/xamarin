using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PostImagenes.Dependencies;
using PostImagenes.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidImplementation))]
namespace PostImagenes.Droid
{
    public class AndroidImplementation : IGaleriaImagenes
    {
        public Task<Stream> GetFotoAsync()
        {
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity activity = Forms.Context as MainActivity;

            activity.StartActivityForResult(Intent.CreateChooser(intent, "Selecciona una Imagen"), MainActivity.PickImageId);

            activity.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            return activity.PickImageTaskCompletionSource.Task;
        }
        
    }
}