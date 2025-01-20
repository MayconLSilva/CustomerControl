namespace APICustomerControl.Util
{
    public class Utilidade
    {
        private static readonly IConfiguration _configuration;

        public Utilidade(IConfiguration configuration, IConfiguration _configuration)
        {
            _configuration = configuration;
        }

        public static ModelConfiguration readConfiguration()
        {
            var configuracoes = new ModelConfiguration()
            {
                email = _configuration.GetSection("GeneralSettings").GetSection("Email").Value
                //email = _configuration.GetSection("GeneralSettings").GetSection("Email").Value,
                //senha = _configuration.GetSection("GeneralSettings").GetSection("Senha").Value,
                //porta = _configuration.GetSection("GeneralSettings").GetSection("Porta").Value,
                //smtp = _configuration.GetSection("GeneralSettings").GetSection("SMTP").Value
            };

            return configuracoes;
        }

       
    }
}
