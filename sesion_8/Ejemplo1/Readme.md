
## Generar modelos por medio de Database First
```
dotnet ef dbcontext scaffold "Server=127.0.0.1;Port=5435;Database=db_test;User Id=postgres;Password=Passw0rd1234;" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
```