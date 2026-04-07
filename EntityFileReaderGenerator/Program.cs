// See https://aka.ms/new-console-template for more information
using EntityFileReaderGenerator;

string directory = Path.GetFullPath("../../../../GeneratedEntityReaderClasses");
Console.WriteLine("Generating into " + directory);
SchemaFileClassGenerator generator = new SchemaFileClassGenerator();
generator.Load("c8ecfb341d22516067569b04563bff9c", directory);
StaticObjectTypesGenerator.Generate(directory + "/Classes/");