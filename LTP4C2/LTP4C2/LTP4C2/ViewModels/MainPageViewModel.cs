using LTP4C2.Models;
using LTP4C2.Repository;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTP4C2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
       private readonly IProdutoRepository _ref;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Lista";
        }
    }
}
