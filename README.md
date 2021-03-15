# AES Encryption App using F#

This app can be used to encrypt or decrypt text contents of a file.
It also serves as an example of a solution based project layout for F# applications with unit tests.


## Project Initialization Reference

The following commands can be used to generate any solution based F# project.

1. Create solution
```shell
mkdir FSEncryption
dotnet new sln
```

2. Create app project
```shell
dotnet new console -o EncryptionApp -lang F#
```
Can also initialize as many `classlib` projects similarly.

3. Create unit test project using xUnit
```shell
dotnet new xunit -o EncryptionAppTests -lang F#
```

4. Add all projects to the solution
```shell
dotnet sln .\FSEncryption.sln add .\EncryptionApp\EncryptionApp.fsproj
dotnet sln .\FSEncryption.sln add .\EncryptionAppTests\EncryptionAppTests.fsproj
```

5. Add reference of projects to the unit test project
```shell
cd .\EncryptionAppTests\
dotnet add reference ..\EncryptionApp\EncryptionApp.fsproj
```

6. Open the soltion in vs code
```shell
code . -r
```