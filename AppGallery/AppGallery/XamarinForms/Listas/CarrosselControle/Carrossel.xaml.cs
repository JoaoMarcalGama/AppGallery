using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CarrosselControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : ContentPage
    {
        public Carrossel()
        {
            InitializeComponent();

            Carrossel01.ItemsSource = GetColaboradores();
        }
        private List<Colaborador> GetColaboradores()
        {
            return new List<Colaborador>()
            {
                new Colaborador(){Nome = "João Ribeiro", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX"},
                new Colaborador(){Nome = "Felipe Rodrigues", Cargo ="Programador", Descricao = "Sou Programador desde 2010. Trabalhei com JSF, JSP, Java EE, HTML e CSS"},
                new Colaborador(){Nome = "Felipe Ribeiro", Cargo = "Programador Web", Descricao = "Sou Programador Web desde 2000. COnheço PHP, Frameworks como Laravel, Codeingnite e Zend Framework"},

            };
        }
    }
    public class Colaborador 
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }

    }
}