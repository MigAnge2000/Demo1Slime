using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace SlideDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SonPage : PopupPage
    {
        public SonPage()
        {
            InitializeComponent();
        }
        public double Verticaltransition { get; set; }


        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 0)
                    {
                        await gridprincipal.TranslateTo(0, e.TotalY);
                        Verticaltransition = e.TotalY;
                    }
                    break;
                    case GestureStatus.Completed:
                    if (Verticaltransition > 100)
                    {
                        await gridprincipal.TranslateTo(0,200);
                       if(PopupNavigation.Instance.PopupStack.Any())
                        {
                            await PopupNavigation.Instance.PopAsync();
                        }
                    }
                    else
                    {
                        await gridprincipal.TranslateTo(0, e.TotalY);
                    }
                    break;

            }
            lblY.Text = e.TotalY.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}