﻿using System;
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
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01());
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
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeCarrosel.Carrosel());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeAba.Abas());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Modal.Conteudo01());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.PilhaLeiaute.Pilha());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.GradeLeiaute.Grade());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.AbsolutoLeiaute.Absoluto());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbirRelativeLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.RelativoLeiaute.Relativo());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.FlexivelLeiaute.Flexivel());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.BarraDeRolagemLeiaute.BarraDeRolagem());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirContentView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.ControleLeiaute.Controle());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Leiautes.QuadradoLeiaute.Quadrado());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;  
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaControle.Caixa());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.RotuloControle.Rotulo());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoControle.Botao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoImagemControle.BotaoImagem());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirImage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ImagemControle.Imagem());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEntry(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaSimplesControle.CampoDeEntradaSimples());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEditor(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaMultilineControle.CampoDeControleMultiline());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCheckBox(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaDeMarcacaoControle.CaixaDeMarcacao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRadioButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaDeRadioControle.CaixaDeRadio());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwitch(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.InterruptorControle.Interruptor());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStepper(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.PassadorControle.Passador());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSlider(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.DeslizanteControle.Deslizante());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPicked(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.SelecaoControle.Selecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirDatePicker(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.DataSelecaoControle.DataSelecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTimePicker(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.TempoSelecaoControle.TempoSelecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirActivityIndicator(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.IndicadorDeAtividadeControle.IndicadorDeAtividade());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirProgressBar(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BarraDeProgressoControle.BarraDeProgresso());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSearchBar(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BarraDePesquisaControle.BarraDePesquisa());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRefreshView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.AtualizarControle.Atualizar());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwipeView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ArrastaControle.Arrasta());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirWebView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.NavegadorControle.Navegador());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMediaElement(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.MediaControle.Media());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirExpander(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ExpansorControle.Expansor());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbirTableView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.TabelaControle.Tabela());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirListView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ListaControle.Lista());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCollectionView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ColecaoControle.Colecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CarrosselControle.Carrossel());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}