using SysSeguridadG05.EN;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2G05.Data
{
    public class RolDTO
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }

        List<Usuario> usuarios { get; set; }
    }
}
