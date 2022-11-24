docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=p@ssw0rd" -p 1433:1433 -d --name mssql2019 mcr.microsoft.com/mssql/server:2019-latest
docker cp create-workshop-database.sql mssql2019:/opt/create-workshop-database.sql
docker exec -it mssql2019 ^
	/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P p@ssw0rd ^
	-i /opt/create-workshop-database.sql