using Identity.Doman.Models.Enum;
using Identity.Doman.Models.Interface;

namespace Identity.Doman.Models
{
    public class Usuario : IUsuario
    {
        public Usuario() { }
        public string Usiario { get; set; }

        public string Senha { get; set; }
        public string SenhaConf { get; set; }
        public PerfilEnum PerfilEnum { get; set; }

        public bool CriarUsuario()
        {
            return true;
        }
    }
}