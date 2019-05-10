using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GaleriaImagenes.Dependencies;
using GaleriaImagenes.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidImplementation))]
namespace GaleriaImagenes.Droid
{
    public class AndroidImplementation : IGaleriaImagenes
    {
        public Task<Stream> GetFotoAsync()
        {
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity activity = Forms.Context as MainActivity;

            activity.StartActivityForResult(Intent.CreateChooser(intent, "Select Picture"), MainActivity.PickImageId);

            activity.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}