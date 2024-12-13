using System;
using System.Collections.Generic;

namespace Ejemplo1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }
}
