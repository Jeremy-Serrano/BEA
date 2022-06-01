namespace lib_base
{
    public class C_ENTREPRISE
    {
        public string NomEntreprise { get; set; }
        public string SIRET { get; set; }
        public override string ToString()
        {
            return $"Entreprise : {NomEntreprise}  {SIRET}";
        }
    }
}
