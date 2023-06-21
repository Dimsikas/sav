using sav.NewFolder1;
using System.Linq;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class DirectorBodyTho : Page
    {
        public DirectorBodyTho()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            MainList.ItemsSource = AppConectClass.DB.Orders.ToList();
        }
    }
}
