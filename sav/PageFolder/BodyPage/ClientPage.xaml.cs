using sav.NewFolder1;
using System.Linq;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            MainList.ItemsSource = AppConectClass.DB.Clients.ToList();
        }
    }
}
