namespace lib_base
{
    public class C_AUDITEUR
    {
        public string Nom { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"Auditeur : {Nom}  {Mail}";
        }
    }
}
