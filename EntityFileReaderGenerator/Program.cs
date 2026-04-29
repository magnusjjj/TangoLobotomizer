// See https://aka.ms/new-console-template for more information
using EntityFileReaderGenerator;
using EntityFileReaderGenerator.CSharpGenerator;
using EntityFileReaderGenerator.Generators;

string directory = Path.GetFullPath("../../../../GeneratedEntityReaderClasses");
Console.WriteLine("Generating into " + directory);
//SchemaFileStats stats = new SchemaFileStats();
//stats.Load("c8ecfb341d22516067569b04563bff9c", directory, new CSharpLanguage());
//return;
SchemaFileClassGenerator generator = new SchemaFileClassGenerator();
generator.Load("c8ecfb341d22516067569b04563bff9c", directory, new CSharpLanguage());
StaticObjectTypesGenerator.Generate(directory + "/Classes/", new CSharpLanguage());

CSharpLanguage.GenerateFactory(directory + "/GeneratedClassFinder.cs", "GeneratedClassFinder");
CSharpLanguage.GenerateJsonSerializer(directory + "/GeneratedJsonSerializer.cs");
CSharpLanguage.GenerateComponentBase(directory + "/NoitaComponentBase.cs");

string pythondirectory = Path.GetFullPath("../../../../GeneratedEntityReaderClassesPython/GeneratedClasses");
Directory.CreateDirectory(pythondirectory);
PythonGenerator pg = new PythonGenerator();
generator.Load("c8ecfb341d22516067569b04563bff9c", pythondirectory, pg);
StaticObjectTypesGenerator.Generate(pythondirectory, pg);
PythonGenerator.GenerateFactory("../../../../GeneratedEntityReaderClassesPython/GeneratedClasses/GeneratedClassFinder.py", "GeneratedClassFinder");
