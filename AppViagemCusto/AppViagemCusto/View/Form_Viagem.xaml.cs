using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViagemCusto.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Form_Viagem : ContentPage
    {
        public Form_Viagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Pedagio(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Lista_Viagem());
            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok");
            }
        }

        private void ToolbarItem_Somar(object sender, EventArgs e)
        {

        }
    }
}