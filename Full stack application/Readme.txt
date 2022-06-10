1- First you have to extract the file.

2- Open file with visual studio 2019(Must have SQL server also 2014 or above version).

3- Change the server name in "appsettings.json".

4- Goto Tools > Nuget Package Manager > Package Manager Console

5- Then run the "enable-migration" command in "Package Manager Console".

6- Then run "add-migration" command in "Package Manager Console".

7- Enter the migration name in "Package Manager Console".

8- Then run "update-database" command in "Package Manager Console".

9- Run the project by clicking "IIS Express".