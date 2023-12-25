using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blood_Bank.Data.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonationsList",
                columns: table => new
                {
                    idDonation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSick = table.Column<int>(type: "int", nullable: false),
                    idDonor = table.Column<int>(type: "int", nullable: false),
                    statusDonation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationsList", x => x.idDonation);
                });

            migrationBuilder.CreateTable(
                name: "DonorsList",
                columns: table => new
                {
                    idDonor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeBloodDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pelephoneDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusDonor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorsList", x => x.idDonor);
                });

            migrationBuilder.CreateTable(
                name: "SicksList",
                columns: table => new
                {
                    idSick = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fNameSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lNameSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeBloodSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pelephoneSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusSick = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SicksList", x => x.idSick);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonationsList");

            migrationBuilder.DropTable(
                name: "DonorsList");

            migrationBuilder.DropTable(
                name: "SicksList");
        }
    }
}
