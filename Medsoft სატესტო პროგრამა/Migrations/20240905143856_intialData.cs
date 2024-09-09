using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Medsoft_სატესტო_პროგრამა.Migrations
{
	/// <inheritdoc />
	public partial class intialData : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "gender",
				columns: table => new
				{
					genderID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					gender_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_gender", x => x.genderID);
				});

			migrationBuilder.CreateTable(
				name: "patient",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					full_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
					Dob = table.Column<DateOnly>(type: "date", nullable: false),
					genderID = table.Column<int>(type: "int", nullable: false),
					phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
					address = table.Column<string>(type: "nvarchar(500)", unicode: false, maxLength: 500, nullable: true),
					patient_id = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
					email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_patient", x => x.ID);
					table.ForeignKey(
						name: "FK_patient_gender",
						column: x => x.genderID,
						principalTable: "gender",
						principalColumn: "genderID");
				});

			migrationBuilder.InsertData(
				table: "gender",
				columns: new[] { "genderID", "gender_name" },
				values: new object[,]
				{
					{ 1, "მამრობითი" },
					{ 2, "მდედრობითი" }
				});

			migrationBuilder.InsertData(
				table: "patient",
				columns: new[] { "ID", "address", "Dob", "email", "full_name", "genderID", "patient_id", "phone" },
				values: new object[,]
				{
					{ 1, "22/24 Ioane Shavteli St", new DateOnly(1987, 1, 21), "luka123@gmail.com", "ლუკა არჯევანიძე", 1, "3157747508", "599123456" },
					{ 2, "7 Apolon Kutateladze Street", new DateOnly(1992, 11, 4), "qeti321@gmail.com", "ქეთი ბოკერია", 2, "0509342681", "598654321" },
					{ 3, "36 Giorgi Maruashvili St", new DateOnly(1998, 12, 17), "leqsogogichadze1998@gmail.com", "ლექსო გოგიჩაძე", 1, "6006784558", "577162534" },
					{ 4, "23a/23b Grigol Robakidze Ave", new DateOnly(2006, 4, 29), "hakim@gmail.com", "რევაზ თოდრაძე", 1, "4562856692", "555112233" },
					{ 5, "32 Kiketi Street", new DateOnly(1989, 5, 20), "bcglobal@gmail.com", "გიორგი ისაკაძე", 1, "4846641520", "599181818" },
					{ 6, "6 Somkheti St", new DateOnly(2002, 3, 3), "hahiss@gmail.com", "ლევან მახათაძე", 1, "123123", "595471298" },
					{ 7, "47a Vazha Pshavela Ave", new DateOnly(1993, 10, 9), "user14215@gmail.com", "ანა კუპრაძე", 2, "9144403714", "595876492" },
					{ 8, "27 Vakhtang Chikovani St", new DateOnly(1997, 7, 5), "mariammariam@gmail.com", "მარიამ ყაზარაშვილი", 2, "2453063596", "571422312" }
				});

			migrationBuilder.CreateIndex(
				name: "IX_patient_genderID",
				table: "patient",
				column: "genderID");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "patient");

			migrationBuilder.DropTable(
				name: "gender");
		}
	}
}
