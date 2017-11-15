# Playing around with mssql on linux

run the follwowing command to start a mssql server express (this also mounts a the data folder of sqlserver in your current dir):

    docker run --name sqlserver -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=^t#db78fO08' -e 'MSSQL_PID=Express' -v ${PWD}\data:/var/opt/mssql/data -p 1433:1433 -d microsoft/mssql-server-linux:latest

stop it:

    docker stop sqlserver


connect to the sql server and execute commands:

    docker exec -it sqlserver /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P ^t#db78fO08

Or of course you can connect with e.g. Management Studio for free if you want a UI: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms