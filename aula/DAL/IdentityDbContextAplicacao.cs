using Microsoft.AspNet.Identity.EntityFramework;
using aula.Areas.Seguranca.Models;
using System.Data.Entity;
namespace aula.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDB3")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(
            new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }
    }
    public class IdentityDbInit : DropCreateDatabaseIfModelChanges <IdentityDbContextAplicacao>
    {
    }
}