using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace FinalAssignment.ViewModels
{
    class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public MainViewModel() {
            this.DisplayName = "Inventory Application";
        }
        protected override void OnActivate() {
            base.OnActivate();
            Orders();
        }
        public void Orders() {
            var ordersVM = IoC.Get<OrdersViewModel>();
            //IoC.Get<OrdersViewModel>();
            OnActivate(ordersVM);
        }
    }
}
