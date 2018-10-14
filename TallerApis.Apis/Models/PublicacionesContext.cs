using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    public class PublicacionesContext : DbContext
    {
        public PublicacionesContext() : base("PublicacionesConnection")

        {

        }

        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}