using System;
using System.Windows;

namespace singleResponsibility
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        Cargo cargo = new Cargo();
        CargoIssues cargoIssues = new CargoIssues();
        Notify notify = new Notify();

        private void AddButon_Click(object sender, RoutedEventArgs e)
        {
            cargo.CargoNumber = Int32.Parse(txtCargoNumber.Text);
            cargo.ReceiverName = txtReceiverName.Text;
            cargo.ReceiverSurname = txtReceiverSurname.Text;
            cargo.Destination = txtDestination.Text;
            cargoIssues.Registration(cargo);
            notify.SendRegistrationNotification();
        }

        private void DeleteButon_Click(object sender, RoutedEventArgs e)
        {
            cargo.CargoNumber = Int32.Parse(txtCargoNumber.Text);
            cargo.ReceiverName = txtReceiverName.Text;
            cargo.ReceiverSurname = txtReceiverSurname.Text;
            cargo.Destination = txtDestination.Text;
            cargoIssues.Deletion(cargo);
            notify.SendDeletionNotification();
        }
    }
}
