holidays? no problem... HOLIDAY SLUG.


**docker-sqlserver**

in order to create the dockerfied db locally you need to use the docker-compose file by execing this in terminal:

`docker-compose up -d`

this will pull the sqlserver imge from docker hub and spin up the container.

you can connect to it via localhost on any ssms type software.

**create the db from latest migration**

run this in terminal `dotnet ef database update `  

this will get the latest migration and create the database.