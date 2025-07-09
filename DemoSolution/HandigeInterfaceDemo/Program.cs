namespace HandigeInterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagina = new MijnWebPagina();
            pagina._service = new AzureOpslagService();
            pagina.SlaOp();

        }
    }
}
