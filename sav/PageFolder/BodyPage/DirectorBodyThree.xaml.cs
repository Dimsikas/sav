using sav.NewFolder1;
using System.Linq;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class DirectorBodyThree : Page
    {
        public DirectorBodyThree()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            MainList.ItemsSource = AppConectClass.DB.Employee.ToList();
        }
    }
}
