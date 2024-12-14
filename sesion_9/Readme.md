
## Generar modelos por medio de Database First
```
dotnet ef dbcontext scaffold "Server=172.210.62.93;Port=5432;Database=db_test;User Id=postgres;Password=Passw0rd1234;" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
```