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
using WPF_BEA.COORDINATION;

namespace WPF_BEA.PRESENTATION
{
    /// <summary>
    /// Logique d'interaction pour UI_Metrique.xaml
    /// </summary>
    public partial class UI_Metrique : UserControl
    {
        public UI_Metrique()
        {
            InitializeComponent();
            
        }

        private void BTN_Update_Click(object sender, RoutedEventArgs e)
        {
            var La_coordination = C_COORDINATION.Get_Instance();
            La_coordination.Metrique_Selectionnee = (lib_base.C_METRIQUE)DataContext;
            La_coordination.MAJ_Illustrator_Metrique();
            La_coordination.MAJ_Illustrator_Metrique_Text();
        }
    }
}
