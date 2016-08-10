using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalAssignment.ViewModels;
using Caliburn.Micro;

namespace FinalAssignment.ViewModels
{
    class NewOrderViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public NewOrderViewModel()
        {
            this.DisplayName = "Inventory Application";
        }
        protected override void OnActivate()
        {
            base.OnActivate();
            Orders();
        }
        public void Orders()
        {
            var ordersVM = IoC.Get<OrdersViewModel>();
            //IoC.Get<OrdersViewModel>();
            //OnActivate(ordersVM);
        }
    }
}
