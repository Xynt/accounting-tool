# Setting up the sqlite database

1. Create database save location secret (recommended location: ```/accounting-tool/database```)
   1. Command: ```dotnet user-secrets set "sqliteConnectionString:string" "Data Source=<<Absolute Location>>;"```
   2. Example: ```dotnet user-secrets set "sqliteConnectionString:string" "Data Source=C:\\Users\\xaro\\RiderProjects\\accounting-tool\\database\\apptool.db;"```
2. Update Database
   1. Command: ```dotnet ef database update``` (you might have to run ```dotnet tool install --global dotnet-ef``` first)
   
## Modifying the database

The database should be created at the specified file path. Just deleting the .db object will delete the database. Running ```dotnet ef database update``` will create a new one or update the existing one if new migrations have been created.
