# Piral.Blazor.Server.Samples.Tractor

Repository for the famous tractor micro frontend sample using Piral.Blazor.Server.

## Structure of the Sample

This sample repository consists of the following sub-directories, which could be easily moved into their own repositories. They are only together for convenience.

- [TractorStore](./TractorStore) - the app shell; runs the server and produces the emulator (more on that later)
- [Red](./Red) - the red micro frontend; comes with the product page
- [Green](./Green) - the green micro frontend; comes with recommendations for a product
- [Blue](./Blue) - the blue micro forntend; comes with a basket and buy button
- [All](./All) - not a real micro frontend; contains a solution that references all available micro frontends to show joint debugging

## Emulator

An emulator is a NuGet package that contains the app shell. It is packaged in a way that the SDK understands. This way, you can just run your micro frontends locally without needing to set up or configure the app shell or a dedicated environment.

The emulator of the tractor sample could also be referenced locally. As this would require an absolute path (which would only work on my machine) I've decided to publish the emulator on NuGet. This way, you can also use this emulator in your micro frontends - allowing you to play around without having to set up your own emulator or app shell.

## Joint Debugging

The way that joint debugging in Piral.Blazor.Server works is that all referenced micro frontends are detected and automatically included.

Consider the following project definition:

```xml
<Project Sdk="Piral.Blazor.Sdk/0.4.0">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Version>0.1.0</Version>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <AppShell>Piral.Blazor.Server.Samples.Tractor.Emulator/1.0.0</AppShell>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Piral.Blazor.Server.Samples.Tractor.Emulator" Version="1.0.0" PrivateAssets="all" />
  </ItemGroup>

  <ItemGroup Condition="'$(Configuration)' == 'Debug'">
    <ProjectReference Include="..\..\Blue\Blue\Blue.csproj" />
    <ProjectReference Include="..\..\Green\Green\Green.csproj" />
    <ProjectReference Include="..\..\Red\Red\Red.csproj" />
  </ItemGroup>
</Project>
```

This references the other micro frontends via their project files. To avoid having their files copied in to the released micro frontend we'll place the references in an `ItemGroup` with a `Condition`. Note that this is only to have the right idea for your project - in this special case we'd not publish this micro frontend anyway.

When you start this all the referenced micro frontends are loaded.
