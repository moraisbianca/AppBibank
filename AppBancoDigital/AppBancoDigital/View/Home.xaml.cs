﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
			btn_menu.Source = ImageSource.FromResource("AppBancoDigital.Images.trespontos.png");
            btn_extrato.Source = ImageSource.FromResource("AppBancoDigital.Images.extrato-bancario.png");
            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.Images.icon-pix-512.png");
            btn_transferencias.Source = ImageSource.FromResource("AppBancoDigital.Images.transferencia.png");
            //btn_cartao.Source = ImageSource.FromResource("AppBancoDigital.Images.cartao-de-credito.png");

            string[] resultsArray = explode(" ", App.DadosCorrentista.Nome);

            txt_correntista.Text = resultsArray[0];
            txt_saldo.Text = "";
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void ver_saldo(object sender, EventArgs e)
        {
            /*if (txt_saldo = "")
            {
                txt_saldo.Text = App.DadosConta.Saldo;
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {

                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }*/
        }

        private void btn_menu_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_extrato_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_transferencias_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_pix_Clicked(object sender, EventArgs e)
        {

        }
    }
}