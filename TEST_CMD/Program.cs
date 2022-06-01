using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using lib_base;

namespace TEST_CMD
{
    class Program
    {
       
        static void Main(string[] args)
        {
            C_BASE La_Base = new C_BASE();

            //La_Base.Initialisation_Demo();
            ////La_Base.Audit.affiche_toi();

            //La_Base.Sauvegarde("test.json");
            La_Base.Chargement("test.json");
            La_Base.Audit.affiche_toi();


            Console.WriteLine();
        }
    }
}
