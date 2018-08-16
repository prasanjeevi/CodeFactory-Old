using System;
using static System.Console;
using Microsoft.CodeAnalysis.CSharp;


using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis
              .CSharp.Syntax;
namespace ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sourceCode = @"
using System;
using System.IO;
class Person
{
    ArrayList personList = new ArrayList();
    public void AddPerson (String name)
    {
        personList.Add(name);
    }
}

class Employee
{
    ArrayList EmployeeList;
    Person employee;
    public Employee()
    {    
        employee = new Person();
        
    }  
    public String  EmployeeName {get;set;}
    public int EmployeeAge {get;set;}
    public void AddEmployee(String name, int age)
    {
        EmployeeName = name;
        EmployeeAge = age;      
    }
    public String GetEmployee()
    {
        return EmployeeName+"" "" + EmployeeAge.ToString();
    }
}

";
            Console.WriteLine("Hello World!");
            //Get the Syntax Tree of the source code
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(sourceCode);
            //Get the root node
            CompilationUnitSyntax root = syntaxTree.GetCompilationUnitRoot();

            Console.WriteLine($"The tree is a {root.Kind()} node.");
            //Get the total number of members in the root
            Console.WriteLine($"The tree has {root.Members.Count} elements in it.");
            //Get the total number of using statements
            Console.WriteLine($"The tree has {root.Usings.Count} using statements. They are:");
            //Iterate and get the list of namespaces defined
            foreach (UsingDirectiveSyntax element in root.Usings)
                Console.WriteLine($"\t{element.Name}");

            //Lopp through the members in the root
            Console.WriteLine("Hello World!");
            foreach (var rootMember in root.Members)
            {
                if (rootMember.GetType().ToString() == "Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax")
                {
                    //var programDeclaration = (ClassDeclarationSyntax)root.Members[0];
                    var programDeclaration = (ClassDeclarationSyntax)rootMember;
                    Console.WriteLine("There are " + programDeclaration.Members.Count + " members declared in " + programDeclaration.Identifier + " class");
                    int fieldCount = 0;
                    int methodCount = 0;
                    foreach (var member in programDeclaration.Members)
                    {
                        /*if (member.Equals(typeof(FieldDeclarationSyntax))) fieldCount++;
                        if (member.Equals(typeof(BaseMethodDeclarationSyntax))) methodCount++;*/

                        if (member.GetType().ToString() == "Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax")
                        {
                            FieldDeclarationSyntax field = (FieldDeclarationSyntax)member;
                            Console.WriteLine(field.Declaration.Type.ToString());
                            Console.WriteLine(field.Declaration.Variables.ToString());
                            fieldCount++;
                            //Console.WriteLine(member.

                        }
                        if (member.GetType().ToString() == "Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax") 
                        {
                            methodCount++;
                            var methodDeclaration = (MethodDeclarationSyntax)member;
                            foreach (ParameterSyntax item in methodDeclaration.ParameterList.Parameters)
                            {
                                Console.WriteLine("Parameter Type is " + item.Type + " and identifier is " + item.Identifier);
                            }
                            Console.WriteLine(methodDeclaration.Body.ToString());

                        }
                    }
                    Console.WriteLine("There are " + methodCount + " methods and " + fieldCount + " field declarations");
                }
            }
        }
    }
}
