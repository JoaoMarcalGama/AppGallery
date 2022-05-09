using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            /*
                var pagina = new NavigationPage(
                    new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            */
            /*
             *  var pagina = new XamarinForms.Paginas.Modal.Conteudo
             */

            /* Página Carrosel */
            /*     
            var pagina = new CarouselPage();
            
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo03());

            pagina.CurrentPage = pagina.Children[1];
            MainPage = pagina;
            */

            /*
            MainPage = new XamarinForms.Paginas.PaginaDeCarrosel.Carrosel();
            */
            /*
            var pagina = new TabbedPage();

            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo03());

            MainPage = new XamarinForms.Paginas.PaginaDeAba.Abas();
            */

            /*
            var pagina = new MasterDetailPage();
            //Menu
            pagina.Master = ;
            //Conteudo
            pagina.Detail = ;
            */




            MainPage = new AppBase.Menu();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
