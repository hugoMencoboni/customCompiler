namespace Core
{
    public sealed class Commande
    {
        private readonly string _rawContent;

        public Commande(string rawContent)
        {
            _rawContent = rawContent;
        }

        public string Execute()
        {
            return "Fake result";
        }
    }
}