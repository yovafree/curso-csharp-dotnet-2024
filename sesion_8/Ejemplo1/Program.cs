using Ejemplo1.Models;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Blog y asignarle valores a sus propiedades
            var db = new DbTestContext();

            Blog blog = new Blog();
            blog.Title = "Sesión #10";
            blog.CreationDate = DateTime.Now;
            blog.Description = "Este es el contenido de mi blog";

            Post post1 = new Post(){Title = "Post 1", Content = "Contenido del post 1", Author = "Autor", CreationDate = DateTime.Now};
            Post post2 = new Post(){Title = "Post 2", Content = "Contenido del post 2", Author = "Autor", CreationDate = DateTime.Now};
            Post post3 = new Post(){Title = "Post 3", Content = "Contenido del post 3", Author = "Autor", CreationDate = DateTime.Now};

            blog.Posts.Add(post1);
            blog.Posts.Add(post2);
            blog.Posts.Add(post3);

            // Agregar el objeto blog a la tabla Blogs
            db.Blogs.Add(blog);
            db.SaveChanges();

        }
    }
}