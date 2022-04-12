# Setting up the sqlite database

1. Create database save location secret (recommended location: ```/accounting-tool/database```)
   1. Command: ```dotnet user-secrets set "sqliteConnectionString:string" "Data Source=<<Absolute Location>>;"```
2. Run ```dotnet ef database update```