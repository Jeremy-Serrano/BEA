using Microsoft.Win32;
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

namespace WPF_BEA
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        C_COORDINATION La_Coordination;
        
        public MainWindow()
        {
            La_Coordination =  C_COORDINATION.Get_Instance();
            InitializeComponent();
            La_Coordination.Charger_Fichier("test.json");
            DataContext = La_Coordination;
        }

        private void Item_Nouveau_Click(object sender, RoutedEventArgs e)
        {
            La_Coordination.Creation_Nouvel_Audit();
        }

        private void Item_Ouvrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Boite_ouvrir = new OpenFileDialog();
            Boite_ouvrir.Filter = "Fichier Json(*.json)|*.json";

            if (Boite_ouvrir.ShowDialog() == true)
            {
                La_Coordination.Charger_Fichier(Boite_ouvrir.FileName);
            }
        }

        private void Item_Sauver_Click(object sender, RoutedEventArgs e)
        {
            bool OK = true;

            if (La_Coordination.Nom_Fichier_Courant == null)
            {
                SaveFileDialog Boite_sauver = new SaveFileDialog();
                Boite_sauver.Filter = "Fichier Json(*.json)|*.json";

                if (Boite_sauver.ShowDialog() == true)
                {
                    La_Coordination.Nom_Fichier_Courant = Boite_sauver.FileName;

                }
                else OK = false;
            }
            if (OK) La_Coordination.sauver_fichier();
            

            
        }

        private void Item_Quitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_AJOUT_Click(object sender, RoutedEventArgs e)
        {
            La_Coordination.Ajoute_Metrique();
        }

        private void ListView_SelectionChanged()
        {

        }

    }
}
