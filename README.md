# SolutionConfigurationsExample
This .NET / C# project exemplifies a fairly simple use case of setting up a client application to reference a class library that needs to be configurable for running in multiple environments. By using environment-specific client configuration files, and by editing the client .csproj file to dynamically change between which config file’s settings are provided to the class library, the client application can operate in both test and production environments by just switching the client’s solution configuration between Debug and Release.

Please see this article (http://pilotprogrammer.com/archive/2016/06/programmers-simple-use-case-for-leveraging-visual-studio-solution-configurations) for further details.

