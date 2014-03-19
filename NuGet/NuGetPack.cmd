SET NUGET=..\src\.nuget\nuget
%NUGET% pack SimpleStack.OrmLite.Sqlite.Mono\SimpleStack.ormlite.sqlite.mono.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.Sqlite32\SimpleStack.ormlite.sqlite32.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.Sqlite64\SimpleStack.ormlite.sqlite64.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.SqlServer\SimpleStack.ormlite.sqlserver.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.MySql\SimpleStack.ormlite.mysql.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.PostgreSQL\SimpleStack.ormlite.postgresql.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.Oracle\SimpleStack.ormlite.oracle.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.Firebird\SimpleStack.ormlite.firebird.nuspec -symbols
%NUGET% pack SimpleStack.OrmLite.T4\SimpleStack.ormlite.t4.nuspec -symbols

