using System;
using System.Collections.Generic;

namespace Ejemplo1.Models;

public partial class Blog
{
    public int BlogId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
