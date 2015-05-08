
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Views.Animations;

namespace PantallaSplash
{
	//Actividad Principal sin historial.
	[Activity (Label = "Splash", MainLauncher = true, NoHistory = true)]			
	public class Splash : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Splash);

			MainActivity main = new MainActivity ();
			CuentaAtras cuentaAtras = new CuentaAtras (5000, 5000, this, main);
			cuentaAtras.Start ();

			iniciarAnimacion ();
		}

		public void iniciarAnimacion()
		{
			Animation animacion = AnimationUtils.LoadAnimation (this, Resource.Animation.AnimacionAlpha);
			animacion.Reset ();

			LinearLayout layout = FindViewById<LinearLayout> (Resource.Id.layout);
			layout.ClearAnimation ();
			layout.StartAnimation (animacion);

			animacion = AnimationUtils.LoadAnimation (this, Resource.Animation.AnimacionTranslate);
			animacion.Reset ();

			ImageView img = FindViewById<ImageView> (Resource.Id.imageView);
			img.ClearAnimation ();
			img.StartAnimation (animacion);
		
		}
	}
}

