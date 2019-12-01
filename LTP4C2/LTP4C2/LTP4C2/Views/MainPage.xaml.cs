using LTP4C2.Repository;
using Xamarin.Forms;

namespace LTP4C2.Views
{
    public partial class MainPage : ContentPage
    {
        private static readonly IProdutoRepository _ref;
        public MainPage()
        {
            InitializeComponent();
            Produto.ItemsSource = _ref.Lista();
        }
        
    }
}