using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            /* Define o conteúdo a ser exibido (Detail)*/
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            /* Define a visibilidade do menu*/
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrosel.Carrosel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAba.Abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.PilhaLeiaute.Pilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.GradeLeiaute.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}