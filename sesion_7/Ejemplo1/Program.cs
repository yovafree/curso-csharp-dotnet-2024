using Ejemplo1.Context;
using Ejemplo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo1 {
    class Program
    {
        static BlogDbContext db = new BlogDbContext();
        static void Main(string[] args)
        {
            // Creación de Objetos (Registros) a nivel de base de datos
            // Blog blog = new Blog { Url = "http://facebook.com", Title = "Facebook" };

            // db.Blogs.Add(blog);
            // db.SaveChanges();

            // Obtener o listar registros
            IEnumerable<Blog> blogs = db.Blogs.ToList();

            foreach (Blog blog in blogs)
            {
                Console.WriteLine($"Titulo: {blog.Title} URL: {blog.Url}");
            }

            // var blog1 = db.Blogs.Where(b => b.BlogId == 1).FirstOrDefault();
            // blog1.Title = "Blog de Prueba";
            // db.Entry(blog1).State = EntityState.Modified;
            // db.SaveChanges();

            // Modificar registros
            var blog1 = db.Blogs.Where(b => b.BlogId == 2).FirstOrDefault();
            blog1.Title = "Entity Framework";
            db.Entry(blog1).State = EntityState.Modified;
            db.SaveChanges();

            // Eliminar registros
            var blog3 = db.Blogs.Where(b => b.BlogId == 3).FirstOrDefault();
            if (blog3 != null){
                db.Entry(blog3).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}