using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_BEA.COORDINATION
{
    public class C_NOTIFIABLE : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void signal_changement([CallerMemberName] string P_nom = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(P_nom));
        }
    }
}
