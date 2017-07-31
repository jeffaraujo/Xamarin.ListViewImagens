using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.ListViewImagens
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            var lstElementos = new List<Model>();

            for (var i = 0; i < 10; i++)
            {
                lstElementos.Add(new Model() {Texto = $"texto{i+1}" , Detalhe = $"imagem{i+1}", Imagem = "imagem"});
            }

            ListViewTexto.ItemsSource = new ObservableCollection<Model>(lstElementos);
            ListViewImagem.ItemsSource = new ObservableCollection<Model>(lstElementos);
        }
    }
}
