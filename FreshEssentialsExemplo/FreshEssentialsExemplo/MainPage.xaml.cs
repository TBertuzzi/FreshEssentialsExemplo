using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreshEssentialsExemplo
{
    public partial class MainPage : ContentPage
    {
        int _index;
        public int SelectIndex
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                OnPropertyChanged("SelectIndex");
            }
        }



        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
