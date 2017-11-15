docker stop sqlserver
docker rm sqlserver
docker run --name sqlserver -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=^t#db78fO08' -e 'MSSQL_PID=Express' -v ${PWD}\data:/var/opt/mssql/data -p 1433:1433 -d microsoft/mssql-server-linux:latest