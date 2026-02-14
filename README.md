# Repro steps

Run `dotnet build` on a solution (or on `ReproTests/ReproTests.csproj`) and observe
```
warning AD0001: Analyzer 'Xunit.Analyzers.MemberDataShouldReferenceValidMember' threw an exception of type 'System.InvalidOperationException' with message 'Sequence contains no elements'.
```