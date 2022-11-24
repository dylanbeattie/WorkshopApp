using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workshop.Data.Migrations {
    /// <inheritdoc />
    public partial class InitialCreate : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });
            migrationBuilder.Sql(@"
                INSERT INTO Artists(Name) VALUES('Actionscript');
                INSERT INTO Artists(Name) VALUES('Ban Java');
                INSERT INTO Artists(Name) VALUES('CI/CD');
                INSERT INTO Artists(Name) VALUES('Docker');
                INSERT INTO Artists(Name) VALUES('Erlang');
                INSERT INTO Artists(Name) VALUES('Python');
                INSERT INTO Artists(Name) VALUES('Metadata');
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
