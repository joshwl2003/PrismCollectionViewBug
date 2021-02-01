using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismBugTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailsPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailsPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailsPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailsPageMasterViewModel : INotifyPropertyChanged
        {
            //public ObservableCollection<MasterDetailsPageMenuItem> MenuItems { get; set; }

            public MasterDetailsPageMasterViewModel()
            {
               /* MenuItems = new ObservableCollection<MasterDetailsPageMenuItem>(new[]
                {
                    new MasterDetailsPageMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailsPageMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailsPageMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailsPageMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailsPageMenuItem { Id = 4, Title = "Page 5" },
                });*/
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
