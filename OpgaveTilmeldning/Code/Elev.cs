namespace OpgaveTilmeldning.Code
{
    internal sealed class Elev : Person
    {

        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag) : base(fornavn, efternavn, fødselsdag)
        {
            string defaultInfo = ShowAllInfo2();
        }

        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

    }
}