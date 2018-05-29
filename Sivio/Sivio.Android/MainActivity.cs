using System;

using Android.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android.Content.PM;
using Android;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Gms.Common;

namespace Sivio.Droid
{
    [Activity(Label = "Sivio", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        const int RequestAccessFineLocation = 1;
        bool wasInitialized = false;

        protected override void OnCreate(Bundle bundle)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //await TryToGetPermissions();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsMaps.Init(this, bundle);

            var permissionCheck = ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation);
            if (permissionCheck.Equals(Permission.Granted))
            {
                // the permission was granted in the past
                InitApp();
            }
            else
            {
                // there is no granted permission to ACCESS_FINE_LOCATION. Requesting it in runtime
                if (ActivityCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.AccessFineLocation))
                {
                    //set alert for executing the task
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetTitle("Permissão necessária");
                    alert.SetMessage("O aplicativo precisa da permissão \"Localização\" para mostrar o mapa da UFMA");
                    alert.SetPositiveButton("Solicitar permissão", (senderAlert, args) =>
                    {
                        ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.AccessFineLocation }, RequestAccessFineLocation);
                    });

                    alert.SetNegativeButton("Cancelar", (senderAlert, args) =>
                    {
                        Toast.MakeText(this, "Cancelado!", ToastLength.Long).Show();
                        Finish();
                    });

                    Dialog dialog = alert.Create();
                    dialog.Show();
                    return;
                }
            }
            ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.AccessFineLocation }, RequestAccessFineLocation);
            //LoadApplication(new App());

            //LoadApplication(new App());
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            if (requestCode != RequestAccessFineLocation) return;

            // If request is cancelled, the result arrays are empty.
            if (grantResults.Length > 0 && grantResults[0] == Permission.Granted)
            {
                // permission was granted
                // Start app
                wasInitialized = true;
                InitApp();
            }
            else
            {
                // permission denied
                // close app
                Finish();
            }
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            return wasInitialized && base.OnPrepareOptionsMenu(menu);
        }

        private void InitApp()
        {
            if (IsGooglePlayServicesInstalled())
            {
                LoadApplication(new App());
            }
            else
            {
                Toast.MakeText(this, "Google Play Service is not installed", ToastLength.Long).Show();
            }
        }

        private bool IsGooglePlayServicesInstalled()
        {
            var googleApiAvailability = GoogleApiAvailability.Instance;
            var status = googleApiAvailability.IsGooglePlayServicesAvailable(this);
            return status == ConnectionResult.Success;
        }




    /*
    #region RuntimePermissions

    async Task TryToGetPermissions()
    {
        if ((int)Build.VERSION.SdkInt >= 23)
        {
            await GetPermissionsAsync();
            return;
        }


    }
    const int RequestLocationId = 0;

    readonly string[] PermissionsGroupLocation =
        {
                        //TODO add more permissions
                        Manifest.Permission.AccessCoarseLocation,
                        Manifest.Permission.AccessFineLocation,
            };
    async Task GetPermissionsAsync()
    {
        const string permission = Manifest.Permission.AccessFineLocation;

        if (CheckSelfPermission(permission) == (int)Android.Content.PM.Permission.Granted)
        {
            //TODO change the message to show the permissions name
            Toast.MakeText(this, "Special permissions granted", ToastLength.Short).Show();
            return;
        }

        if (ShouldShowRequestPermissionRationale(permission))
        {
            //set alert for executing the task
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Permissions Needed");
            alert.SetMessage("The application need special permissions to continue");
            alert.SetPositiveButton("Request Permissions", (senderAlert, args) =>
            {
                RequestPermissions(PermissionsGroupLocation, RequestLocationId);
            });

            alert.SetNegativeButton("Cancel", (senderAlert, args) =>
            {
                Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
            });

            Dialog dialog = alert.Create();
            dialog.Show();


            return;
        }

        RequestPermissions(PermissionsGroupLocation, RequestLocationId);

    }

    public override async void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
        switch (requestCode)
        {
            case RequestLocationId:
                {
                    if (grantResults[0] == (int)Android.Content.PM.Permission.Granted)
                    {
                        Toast.MakeText(this, "Special permissions granted", ToastLength.Short).Show();

                    }
                    else
                    {
                        //Permission Denied :(
                        Toast.MakeText(this, "Special permissions denied", ToastLength.Short).Show();

                    }
                }
                break;
        }
        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }

    #endregion
   */

}

}

