using System.Windows;

namespace singleResponsibility
{
    public class Notify
    {
        public void SendRegistrationNotification()
        {
            MessageBox.Show("Kargonuz başarıyla eklendi(BİLDİRİM)", "İşlem tamamlandı", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void SendDeletionNotification()
        {
            MessageBox.Show("Kargonuz başarıyla sistemden silindi (BİLDİRİM)", "İşlem tamamlandı", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
