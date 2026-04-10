// See https://aka.ms/new-console-template for more information
using EntityFileReaderGenerator;

string directory = Path.GetFullPath("../../../../GeneratedEntityReaderClasses");
Console.WriteLine("Generating into " + directory);
//SchemaFileStats stats = new SchemaFileStats();
//stats.Load("c8ecfb341d22516067569b04563bff9c", directory, new CSharpLanguage());
//return;
SchemaFileClassGenerator generator = new SchemaFileClassGenerator();
generator.Load("c8ecfb341d22516067569b04563bff9c", directory, new CSharpLanguage());
StaticObjectTypesGenerator.Generate(directory + "/Classes/", new CSharpLanguage());