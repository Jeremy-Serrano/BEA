using System;

namespace lib_base
{
    public class C_METRIQUE
    {
        public string NomMetrique { get; set; }
        public String Description { get; set; }
        public double valeur { get; set; }
        public string NomLiaison { get; set; }

        public override string ToString()
        {
            return $"--> {NomMetrique} {Description} : {valeur}";
        }
    }
}
