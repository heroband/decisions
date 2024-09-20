using System.Configuration.Assemblies;
using System.Text;
using lab3;


ISqlQueryBuilder postgreSqlBuilder = new PostgreSqlQueryBuilder();
ISqlQueryBuilder mySqlBuilder = new MySqlQueryBuilder();

Director director = new Director(postgreSqlBuilder);
Console.WriteLine(director.BuildQuery("*", "age < 18", 5));
director.SetBuilder(mySqlBuilder);
Console.WriteLine(director.BuildQuery("Name, Age", "Age < 18", 5));



