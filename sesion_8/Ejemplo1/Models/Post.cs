using System;
using System.Collections.Generic;

namespace Ejemplo1.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public string Author { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public int BlogId { get; set; }

    public virtual Blog Blog { get; set; } = null!;
}
