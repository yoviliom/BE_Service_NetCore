Build started...
Build succeeded.
The EF Core tools version '3.1.4' is older than that of the runtime '3.1.5'. Update the tools for the latest features and bug fixes.
System.InvalidOperationException: To change the IDENTITY property of a column, the column needs to be dropped and recreated.
   at Microsoft.EntityFrameworkCore.Migrations.SqlServerMigrationsSqlGenerator.Generate(AlterColumnOperation operation, IModel model, MigrationCommandListBuilder builder)
   at Microsoft.EntityFrameworkCore.Migrations.MigrationsSqlGenerator.<>c.<.cctor>b__71_4(MigrationsSqlGenerator g, MigrationOperation o, IModel m, MigrationCommandListBuilder b)
   at Microsoft.EntityFrameworkCore.Migrations.MigrationsSqlGenerator.Generate(MigrationOperation operation, IModel model, MigrationCommandListBuilder builder)
   at Microsoft.EntityFrameworkCore.Migrations.SqlServerMigrationsSqlGenerator.Generate(MigrationOperation operation, IModel model, MigrationCommandListBuilder builder)
   at Microsoft.EntityFrameworkCore.Migrations.MigrationsSqlGenerator.Generate(IReadOnlyList`1 operations, IModel model)
   at Microsoft.EntityFrameworkCore.Migrations.SqlServerMigrationsSqlGenerator.Generate(IReadOnlyList`1 operations, IModel model)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.GenerateUpSql(Migration migration)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.GenerateScript(String fromMigration, String toMigration, Boolean idempotent)
   at Microsoft.EntityFrameworkCore.Design.Internal.MigrationsOperations.ScriptMigration(String fromMigration, String toMigration, Boolean idempotent, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.ScriptMigrationImpl(String fromMigration, String toMigration, Boolean idempotent, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.ScriptMigration.<>c__DisplayClass0_0.<.ctor>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.<>c__DisplayClass3_0`1.<Execute>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.Execute(Action action)
To change the IDENTITY property of a column, the column needs to be dropped and recreated.
