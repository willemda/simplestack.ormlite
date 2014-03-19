REM SET BUILD=Debug
SET BUILD=Release
SET MSBUILD=C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe 

MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite32\lib\
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite32\lib\net35
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite32\lib\net40
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite64\lib\net35
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite64\lib\net40
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.SqlServer\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net35
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net40
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.MySql\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.PostgreSQL\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Oracle\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Firebird\lib
MD ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.T4\content

COPY ..\src\SimpleStack.OrmLite.Sqlite32\bin\%BUILD%\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite32\lib\net35
COPY ..\src\SimpleStack.OrmLite.Sqlite32\bin\x86\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite32\lib\net40
COPY ..\src\SimpleStack.OrmLite.Sqlite64\bin\%BUILD%\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite64\lib\net35
COPY ..\src\SimpleStack.OrmLite.Sqlite64\bin\x64\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite64\lib\net40
COPY ..\src\SimpleStack.OrmLite.SqlServer\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.SqlServer\lib

COPY ..\lib\Mono.Data.Sqlite.dll  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net35
COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\%BUILD%\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net35
COPY ..\lib\Mono.Data.Sqlite.dll  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net40
COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\x86\SimpleStack.OrmLite.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Sqlite.Mono\lib\net40

COPY ..\src\T4\*.*  ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.T4\content


COPY ..\src\SimpleStack.OrmLite.MySql\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.MySql\lib
COPY ..\src\SimpleStack.OrmLite.PostgreSQL\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.PostgreSQL\lib
COPY ..\src\SimpleStack.OrmLite.Oracle\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Oracle\lib
COPY ..\src\SimpleStack.OrmLite.Firebird\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Firebird\lib
COPY ..\src\SimpleStack.OrmLite.Firebird\bin\%BUILD%\FirebirdSql.Data.FirebirdClient.dll ..\..\SimpleStack.OrmLite\NuGet\SimpleStack.OrmLite.Firebird\lib

COPY ..\src\SimpleStack.OrmLite.SqlServer\bin\%BUILD%\*.* ..\..\SimpleStack\release\latest\SimpleStack.OrmLite
COPY ..\src\SimpleStack.OrmLite.Sqlite32\bin\%BUILD%\SimpleStack.OrmLite.SqliteNET.*  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x32
COPY ..\src\SimpleStack.OrmLite.Sqlite64\bin\%BUILD%\SimpleStack.OrmLite.SqliteNET.*  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x64
COPY ..\lib\x32\net35\System.Data.SQLite.dll  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x32\net35
COPY ..\lib\x32\net40\System.Data.SQLite.dll  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x32\net40
COPY ..\lib\x64\net35\System.Data.SQLite.dll  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x64\net35
COPY ..\lib\x64\net40\System.Data.SQLite.dll  ..\..\SimpleStack\release\latest\SimpleStack.OrmLite\x64\net40

COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\x86\SimpleStack.OrmLite.* ..\..\SimpleStack\lib
COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\x86\sqlite3.dll ..\..\SimpleStack\lib
COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\x86\Mono.Data.Sqlite.dll ..\..\SimpleStack\lib
COPY ..\src\SimpleStack.OrmLite.Sqlite32\bin\x86\SimpleStack.OrmLite.Sqlite* ..\..\SimpleStack\lib\x86
COPY ..\src\SimpleStack.OrmLite.Sqlite64\bin\x64\SimpleStack.OrmLite.Sqlite* ..\..\SimpleStack\lib\x64
COPY ..\src\SimpleStack.OrmLite.SqlServer\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack\lib

COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.Examples\lib
COPY ..\src\SimpleStack.OrmLite.Sqlite\bin\%BUILD%\SimpleStack.OrmLite.* ..\..\SimpleStack.Contrib\lib
