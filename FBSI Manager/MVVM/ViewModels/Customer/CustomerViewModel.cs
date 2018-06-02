using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    /// <summary>
    /// Main model containing all the information about a customer
    /// </summary>
    public class CustomerViewModel : ObservableObject
    {
        private Customer customer;
        public ObservableCollection<NameViewModel> Names { get => (ObservableCollection<NameViewModel>)customer.names.Select(name => new NameViewModel(name)); }
        public ObservableCollection<AddressViewModel> Addresses { get => (ObservableCollection<AddressViewModel>)customer.addresses.Select(address => new AddressViewModel(address)); }
        public ObservableCollection<PhoneViewModel> Phones { get => (ObservableCollection<PhoneViewModel>)customer.phones.Select(phone => new PhoneViewModel(phone)); }
        public ObservableCollection<EmailViewModel> Emails { get => (ObservableCollection<EmailViewModel>)customer.emails.Select(email => new EmailViewModel(email)); }

        public CustomerViewModel(Customer customer = null)
        {
            //allowing for a default of null always for the check in the ctor and can give the user a choice between a fresh model or an existing model
            //the same method has been applied to all the viewmodels of similar format
            this.customer = customer ?? new Customer();
        }//end ctor
    }//end class
}