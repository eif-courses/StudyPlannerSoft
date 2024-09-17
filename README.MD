### For .NET 9-RC.1 you need install EF TOOLS MANUALLY

```
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0-rc.1.24451.1
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0-rc.1.24451.1
```

```
dotnet tool install --global dotnet-ef --version 9.0.0-rc.1.24451.1
```

### USING COMMAND LINE CREATE MIGRATIONS
```
dotnet ef migrations add Initial 
```
### AND UPDATE
```
dotnet ef database update
```
