using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRental.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAlpha3CodeAsKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryOfOriginMovie_CountriesOfOrigin_CountriesOfOriginId",
                table: "CountryOfOriginMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryOfOriginMovie",
                table: "CountryOfOriginMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountriesOfOrigin",
                table: "CountriesOfOrigin");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyColumnType: "integer",
                keyValue: 249);

            migrationBuilder.DropColumn(
                name: "CountriesOfOriginId",
                table: "CountryOfOriginMovie");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CountriesOfOrigin");

            migrationBuilder.AddColumn<string>(
                name: "CountriesOfOriginNameAlpha3Code",
                table: "CountryOfOriginMovie",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NameAlpha3Code",
                table: "CountriesOfOrigin",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(3)",
                oldMaxLength: 3);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryOfOriginMovie",
                table: "CountryOfOriginMovie",
                columns: new[] { "CountriesOfOriginNameAlpha3Code", "MoviesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountriesOfOrigin",
                table: "CountriesOfOrigin",
                column: "NameAlpha3Code");

            migrationBuilder.InsertData(
                table: "CountriesOfOrigin",
                columns: new[] { "NameAlpha3Code", "CommonName" },
                values: new object[,]
                {
                    { "ABW", "Aruba" },
                    { "AFG", "Afghanistan" },
                    { "AGO", "Angola" },
                    { "AIA", "Anguilla" },
                    { "ALA", "Åland Islands" },
                    { "ALB", "Albania" },
                    { "AND", "Andorra" },
                    { "ARE", "United Arab Emirates" },
                    { "ARG", "Argentina" },
                    { "ARM", "Armenia" },
                    { "ASM", "American Samoa" },
                    { "ATA", "Antarctica" },
                    { "ATF", "French Southern and Antarctic Lands" },
                    { "ATG", "Antigua and Barbuda" },
                    { "AUS", "Australia" },
                    { "AUT", "Austria" },
                    { "AZE", "Azerbaijan" },
                    { "BDI", "Burundi" },
                    { "BEL", "Belgium" },
                    { "BEN", "Benin" },
                    { "BES", "Caribbean Netherlands" },
                    { "BFA", "Burkina Faso" },
                    { "BGD", "Bangladesh" },
                    { "BGR", "Bulgaria" },
                    { "BHR", "Bahrain" },
                    { "BHS", "Bahamas" },
                    { "BIH", "Bosnia and Herzegovina" },
                    { "BLM", "Saint Barthélemy" },
                    { "BLR", "Belarus" },
                    { "BLZ", "Belize" },
                    { "BMU", "Bermuda" },
                    { "BOL", "Bolivia" },
                    { "BRA", "Brazil" },
                    { "BRB", "Barbados" },
                    { "BRN", "Brunei" },
                    { "BTN", "Bhutan" },
                    { "BVT", "Bouvet Island" },
                    { "BWA", "Botswana" },
                    { "CAF", "Central African Republic" },
                    { "CAN", "Canada" },
                    { "CCK", "Cocos (Keeling) Islands" },
                    { "CHE", "Switzerland" },
                    { "CHL", "Chile" },
                    { "CHN", "China" },
                    { "CIV", "Ivory Coast" },
                    { "CMR", "Cameroon" },
                    { "COD", "DR Congo" },
                    { "COG", "Republic of the Congo" },
                    { "COK", "Cook Islands" },
                    { "COL", "Colombia" },
                    { "COM", "Comoros" },
                    { "CPV", "Cape Verde" },
                    { "CRI", "Costa Rica" },
                    { "CUB", "Cuba" },
                    { "CUW", "Curaçao" },
                    { "CXR", "Christmas Island" },
                    { "CYM", "Cayman Islands" },
                    { "CYP", "Cyprus" },
                    { "CZE", "Czechia" },
                    { "DEU", "Germany" },
                    { "DJI", "Djibouti" },
                    { "DMA", "Dominica" },
                    { "DNK", "Denmark" },
                    { "DOM", "Dominican Republic" },
                    { "DZA", "Algeria" },
                    { "ECU", "Ecuador" },
                    { "EGY", "Egypt" },
                    { "ERI", "Eritrea" },
                    { "ESH", "Western Sahara" },
                    { "ESP", "Spain" },
                    { "EST", "Estonia" },
                    { "ETH", "Ethiopia" },
                    { "FIN", "Finland" },
                    { "FJI", "Fiji" },
                    { "FLK", "Falkland Islands" },
                    { "FRA", "France" },
                    { "FRO", "Faroe Islands" },
                    { "FSM", "Micronesia" },
                    { "GAB", "Gabon" },
                    { "GBR", "United Kingdom" },
                    { "GEO", "Georgia" },
                    { "GGY", "Guernsey" },
                    { "GHA", "Ghana" },
                    { "GIB", "Gibraltar" },
                    { "GIN", "Guinea" },
                    { "GLP", "Guadeloupe" },
                    { "GMB", "Gambia" },
                    { "GNB", "Guinea-Bissau" },
                    { "GNQ", "Equatorial Guinea" },
                    { "GRC", "Greece" },
                    { "GRD", "Grenada" },
                    { "GRL", "Greenland" },
                    { "GTM", "Guatemala" },
                    { "GUF", "French Guiana" },
                    { "GUM", "Guam" },
                    { "GUY", "Guyana" },
                    { "HKG", "Hong Kong" },
                    { "HMD", "Heard Island and McDonald Islands" },
                    { "HND", "Honduras" },
                    { "HRV", "Croatia" },
                    { "HTI", "Haiti" },
                    { "HUN", "Hungary" },
                    { "IDN", "Indonesia" },
                    { "IMN", "Isle of Man" },
                    { "IND", "India" },
                    { "IOT", "British Indian Ocean Territory" },
                    { "IRL", "Ireland" },
                    { "IRN", "Iran" },
                    { "IRQ", "Iraq" },
                    { "ISL", "Iceland" },
                    { "ISR", "Israel" },
                    { "ITA", "Italy" },
                    { "JAM", "Jamaica" },
                    { "JEY", "Jersey" },
                    { "JOR", "Jordan" },
                    { "JPN", "Japan" },
                    { "KAZ", "Kazakhstan" },
                    { "KEN", "Kenya" },
                    { "KGZ", "Kyrgyzstan" },
                    { "KHM", "Cambodia" },
                    { "KIR", "Kiribati" },
                    { "KNA", "Saint Kitts and Nevis" },
                    { "KOR", "South Korea" },
                    { "KWT", "Kuwait" },
                    { "LAO", "Laos" },
                    { "LBN", "Lebanon" },
                    { "LBR", "Liberia" },
                    { "LBY", "Libya" },
                    { "LCA", "Saint Lucia" },
                    { "LIE", "Liechtenstein" },
                    { "LKA", "Sri Lanka" },
                    { "LSO", "Lesotho" },
                    { "LTU", "Lithuania" },
                    { "LUX", "Luxembourg" },
                    { "LVA", "Latvia" },
                    { "MAC", "Macau" },
                    { "MAF", "Saint Martin" },
                    { "MAR", "Morocco" },
                    { "MCO", "Monaco" },
                    { "MDA", "Moldova" },
                    { "MDG", "Madagascar" },
                    { "MDV", "Maldives" },
                    { "MEX", "Mexico" },
                    { "MHL", "Marshall Islands" },
                    { "MKD", "North Macedonia" },
                    { "MLI", "Mali" },
                    { "MLT", "Malta" },
                    { "MMR", "Myanmar" },
                    { "MNE", "Montenegro" },
                    { "MNG", "Mongolia" },
                    { "MNP", "Northern Mariana Islands" },
                    { "MOZ", "Mozambique" },
                    { "MRT", "Mauritania" },
                    { "MSR", "Montserrat" },
                    { "MTQ", "Martinique" },
                    { "MUS", "Mauritius" },
                    { "MWI", "Malawi" },
                    { "MYS", "Malaysia" },
                    { "MYT", "Mayotte" },
                    { "NAM", "Namibia" },
                    { "NCL", "New Caledonia" },
                    { "NER", "Niger" },
                    { "NFK", "Norfolk Island" },
                    { "NGA", "Nigeria" },
                    { "NIC", "Nicaragua" },
                    { "NIU", "Niue" },
                    { "NLD", "Netherlands" },
                    { "NOR", "Norway" },
                    { "NPL", "Nepal" },
                    { "NRU", "Nauru" },
                    { "NZL", "New Zealand" },
                    { "OMN", "Oman" },
                    { "PAK", "Pakistan" },
                    { "PAN", "Panama" },
                    { "PCN", "Pitcairn Islands" },
                    { "PER", "Peru" },
                    { "PHL", "Philippines" },
                    { "PLW", "Palau" },
                    { "PNG", "Papua New Guinea" },
                    { "POL", "Poland" },
                    { "PRI", "Puerto Rico" },
                    { "PRK", "North Korea" },
                    { "PRT", "Portugal" },
                    { "PRY", "Paraguay" },
                    { "PSE", "Palestine" },
                    { "PYF", "French Polynesia" },
                    { "QAT", "Qatar" },
                    { "REU", "Réunion" },
                    { "ROU", "Romania" },
                    { "RUS", "Russia" },
                    { "RWA", "Rwanda" },
                    { "SAU", "Saudi Arabia" },
                    { "SDN", "Sudan" },
                    { "SEN", "Senegal" },
                    { "SGP", "Singapore" },
                    { "SGS", "South Georgia" },
                    { "SHN", "Saint Helena, Ascension and Tristan da Cunha" },
                    { "SJM", "Svalbard and Jan Mayen" },
                    { "SLB", "Solomon Islands" },
                    { "SLE", "Sierra Leone" },
                    { "SLV", "El Salvador" },
                    { "SMR", "San Marino" },
                    { "SOM", "Somalia" },
                    { "SPM", "Saint Pierre and Miquelon" },
                    { "SRB", "Serbia" },
                    { "SSD", "South Sudan" },
                    { "STP", "São Tomé and Príncipe" },
                    { "SUR", "Suriname" },
                    { "SVK", "Slovakia" },
                    { "SVN", "Slovenia" },
                    { "SWE", "Sweden" },
                    { "SWZ", "Eswatini" },
                    { "SXM", "Sint Maarten" },
                    { "SYC", "Seychelles" },
                    { "SYR", "Syria" },
                    { "TCA", "Turks and Caicos Islands" },
                    { "TCD", "Chad" },
                    { "TGO", "Togo" },
                    { "THA", "Thailand" },
                    { "TJK", "Tajikistan" },
                    { "TKL", "Tokelau" },
                    { "TKM", "Turkmenistan" },
                    { "TLS", "Timor-Leste" },
                    { "TON", "Tonga" },
                    { "TTO", "Trinidad and Tobago" },
                    { "TUN", "Tunisia" },
                    { "TUR", "Turkey" },
                    { "TUV", "Tuvalu" },
                    { "TWN", "Taiwan" },
                    { "TZA", "Tanzania" },
                    { "UGA", "Uganda" },
                    { "UKR", "Ukraine" },
                    { "UMI", "United States Minor Outlying Islands" },
                    { "URY", "Uruguay" },
                    { "USA", "United States" },
                    { "UZB", "Uzbekistan" },
                    { "VAT", "Vatican City" },
                    { "VCT", "Saint Vincent and the Grenadines" },
                    { "VEN", "Venezuela" },
                    { "VGB", "British Virgin Islands" },
                    { "VIR", "United States Virgin Islands" },
                    { "VNM", "Vietnam" },
                    { "VUT", "Vanuatu" },
                    { "WLF", "Wallis and Futuna" },
                    { "WSM", "Samoa" },
                    { "YEM", "Yemen" },
                    { "ZAF", "South Africa" },
                    { "ZMB", "Zambia" },
                    { "ZWE", "Zimbabwe" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CountryOfOriginMovie_CountriesOfOrigin_CountriesOfOriginNam~",
                table: "CountryOfOriginMovie",
                column: "CountriesOfOriginNameAlpha3Code",
                principalTable: "CountriesOfOrigin",
                principalColumn: "NameAlpha3Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryOfOriginMovie_CountriesOfOrigin_CountriesOfOriginNam~",
                table: "CountryOfOriginMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryOfOriginMovie",
                table: "CountryOfOriginMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountriesOfOrigin",
                table: "CountriesOfOrigin");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ABW");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AFG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AGO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AIA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ALA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ALB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AND");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ARE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ARG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ARM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ASM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ATA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ATF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ATG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AUS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AUT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "AZE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BDI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BEL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BEN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BES");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BFA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BGD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BGR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BHR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BHS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BIH");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BLM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BLR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BLZ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BMU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BOL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BRA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BRB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BRN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BTN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BVT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "BWA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CAF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CAN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CCK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CHE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CHL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CHN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CIV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CMR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "COD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "COG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "COK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "COL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "COM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CPV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CRI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CUB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CUW");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CXR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CYM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CYP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "CZE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DEU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DJI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DMA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DNK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DOM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "DZA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ECU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "EGY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ERI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ESH");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ESP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "EST");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ETH");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FIN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FJI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FLK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FRA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FRO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "FSM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GAB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GBR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GEO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GGY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GHA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GIB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GIN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GLP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GMB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GNB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GNQ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GRC");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GRD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GRL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GTM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GUF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GUM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "GUY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HKG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HMD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HND");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HRV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HTI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "HUN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IDN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IMN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IND");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IOT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IRL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IRN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "IRQ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ISL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ISR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ITA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "JAM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "JEY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "JOR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "JPN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KAZ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KEN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KGZ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KHM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KIR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KNA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KOR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "KWT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LAO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LBN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LBR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LBY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LCA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LIE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LKA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LSO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LTU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LUX");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "LVA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MAC");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MAF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MAR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MCO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MDA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MDG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MDV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MEX");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MHL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MKD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MLI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MLT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MMR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MNE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MNG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MNP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MOZ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MRT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MSR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MTQ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MUS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MWI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MYS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "MYT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NAM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NCL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NER");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NFK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NGA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NIC");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NIU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NLD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NOR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NPL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NRU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "NZL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "OMN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PAK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PAN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PCN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PER");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PHL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PLW");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PNG");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "POL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PRI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PRK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PRT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PRY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PSE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "PYF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "QAT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "REU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ROU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "RUS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "RWA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SAU");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SDN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SEN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SGP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SGS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SHN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SJM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SLB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SLE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SLV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SMR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SOM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SPM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SRB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SSD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "STP");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SUR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SVK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SVN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SWE");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SWZ");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SXM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SYC");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "SYR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TCA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TCD");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TGO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "THA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TJK");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TKL");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TKM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TLS");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TON");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TTO");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TUN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TUR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TUV");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TWN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "TZA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "UGA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "UKR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "UMI");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "URY");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "USA");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "UZB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VAT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VCT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VEN");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VGB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VIR");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VNM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "VUT");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "WLF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "WSM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "YEM");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ZAF");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ZMB");

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "NameAlpha3Code",
                keyValue: "ZWE");

            migrationBuilder.DropColumn(
                name: "CountriesOfOriginNameAlpha3Code",
                table: "CountryOfOriginMovie");

            migrationBuilder.AddColumn<int>(
                name: "CountriesOfOriginId",
                table: "CountryOfOriginMovie",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "NameAlpha3Code",
                table: "CountriesOfOrigin",
                type: "character varying(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CountriesOfOrigin",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryOfOriginMovie",
                table: "CountryOfOriginMovie",
                columns: new[] { "CountriesOfOriginId", "MoviesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountriesOfOrigin",
                table: "CountriesOfOrigin",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CountriesOfOrigin",
                columns: new[] { "Id", "CommonName", "NameAlpha3Code" },
                values: new object[,]
                {
                    { 1, "Afghanistan", "AFG" },
                    { 2, "Åland Islands", "ALA" },
                    { 3, "Albania", "ALB" },
                    { 4, "Algeria", "DZA" },
                    { 5, "American Samoa", "ASM" },
                    { 6, "Andorra", "AND" },
                    { 7, "Angola", "AGO" },
                    { 8, "Anguilla", "AIA" },
                    { 9, "Antarctica", "ATA" },
                    { 10, "Antigua and Barbuda", "ATG" },
                    { 11, "Argentina", "ARG" },
                    { 12, "Armenia", "ARM" },
                    { 13, "Aruba", "ABW" },
                    { 14, "Australia", "AUS" },
                    { 15, "Austria", "AUT" },
                    { 16, "Azerbaijan", "AZE" },
                    { 17, "Bahamas", "BHS" },
                    { 18, "Bahrain", "BHR" },
                    { 19, "Bangladesh", "BGD" },
                    { 20, "Barbados", "BRB" },
                    { 21, "Belarus", "BLR" },
                    { 22, "Belgium", "BEL" },
                    { 23, "Belize", "BLZ" },
                    { 24, "Benin", "BEN" },
                    { 25, "Bermuda", "BMU" },
                    { 26, "Bhutan", "BTN" },
                    { 27, "Bolivia", "BOL" },
                    { 28, "Bosnia and Herzegovina", "BIH" },
                    { 29, "Botswana", "BWA" },
                    { 30, "Bouvet Island", "BVT" },
                    { 31, "Brazil", "BRA" },
                    { 32, "British Indian Ocean Territory", "IOT" },
                    { 33, "British Virgin Islands", "VGB" },
                    { 34, "Brunei", "BRN" },
                    { 35, "Bulgaria", "BGR" },
                    { 36, "Burkina Faso", "BFA" },
                    { 37, "Burundi", "BDI" },
                    { 38, "Cambodia", "KHM" },
                    { 39, "Cameroon", "CMR" },
                    { 40, "Canada", "CAN" },
                    { 41, "Cape Verde", "CPV" },
                    { 42, "Caribbean Netherlands", "BES" },
                    { 43, "Cayman Islands", "CYM" },
                    { 44, "Central African Republic", "CAF" },
                    { 45, "Chad", "TCD" },
                    { 46, "Chile", "CHL" },
                    { 47, "China", "CHN" },
                    { 48, "Christmas Island", "CXR" },
                    { 49, "Cocos (Keeling) Islands", "CCK" },
                    { 50, "Colombia", "COL" },
                    { 51, "Comoros", "COM" },
                    { 52, "DR Congo", "COD" },
                    { 53, "Cook Islands", "COK" },
                    { 54, "Costa Rica", "CRI" },
                    { 55, "Croatia", "HRV" },
                    { 56, "Cuba", "CUB" },
                    { 57, "Curaçao", "CUW" },
                    { 58, "Cyprus", "CYP" },
                    { 59, "Czechia", "CZE" },
                    { 60, "Denmark", "DNK" },
                    { 61, "Djibouti", "DJI" },
                    { 62, "Dominica", "DMA" },
                    { 63, "Dominican Republic", "DOM" },
                    { 64, "Ecuador", "ECU" },
                    { 65, "Egypt", "EGY" },
                    { 66, "El Salvador", "SLV" },
                    { 67, "Equatorial Guinea", "GNQ" },
                    { 68, "Eritrea", "ERI" },
                    { 69, "Estonia", "EST" },
                    { 70, "Ethiopia", "ETH" },
                    { 71, "Falkland Islands", "FLK" },
                    { 72, "Faroe Islands", "FRO" },
                    { 73, "Fiji", "FJI" },
                    { 74, "Finland", "FIN" },
                    { 75, "France", "FRA" },
                    { 76, "French Guiana", "GUF" },
                    { 77, "French Polynesia", "PYF" },
                    { 78, "French Southern and Antarctic Lands", "ATF" },
                    { 79, "Gabon", "GAB" },
                    { 80, "Gambia", "GMB" },
                    { 81, "Georgia", "GEO" },
                    { 82, "Germany", "DEU" },
                    { 83, "Ghana", "GHA" },
                    { 84, "Gibraltar", "GIB" },
                    { 85, "Greece", "GRC" },
                    { 86, "Greenland", "GRL" },
                    { 87, "Grenada", "GRD" },
                    { 88, "Guadeloupe", "GLP" },
                    { 89, "Guam", "GUM" },
                    { 90, "Guatemala", "GTM" },
                    { 91, "Guernsey", "GGY" },
                    { 92, "Guinea-Bissau", "GNB" },
                    { 93, "Guinea", "GIN" },
                    { 94, "Guyana", "GUY" },
                    { 95, "Haiti", "HTI" },
                    { 96, "Heard Island and McDonald Islands", "HMD" },
                    { 97, "Honduras", "HND" },
                    { 98, "Hong Kong", "HKG" },
                    { 99, "Hungary", "HUN" },
                    { 100, "Iceland", "ISL" },
                    { 101, "India", "IND" },
                    { 102, "Indonesia", "IDN" },
                    { 103, "Iran", "IRN" },
                    { 104, "Iraq", "IRQ" },
                    { 105, "Ireland", "IRL" },
                    { 106, "Isle of Man", "IMN" },
                    { 107, "Israel", "ISR" },
                    { 108, "Italy", "ITA" },
                    { 109, "Ivory Coast", "CIV" },
                    { 110, "Jamaica", "JAM" },
                    { 111, "Japan", "JPN" },
                    { 112, "Jersey", "JEY" },
                    { 113, "Jordan", "JOR" },
                    { 114, "Kazakhstan", "KAZ" },
                    { 115, "Kenya", "KEN" },
                    { 116, "Kiribati", "KIR" },
                    { 117, "Kuwait", "KWT" },
                    { 118, "Kyrgyzstan", "KGZ" },
                    { 119, "Laos", "LAO" },
                    { 120, "Latvia", "LVA" },
                    { 121, "Lebanon", "LBN" },
                    { 122, "Lesotho", "LSO" },
                    { 123, "Liberia", "LBR" },
                    { 124, "Libya", "LBY" },
                    { 125, "Liechtenstein", "LIE" },
                    { 126, "Lithuania", "LTU" },
                    { 127, "Luxembourg", "LUX" },
                    { 128, "Macau", "MAC" },
                    { 129, "Madagascar", "MDG" },
                    { 130, "Malawi", "MWI" },
                    { 131, "Malaysia", "MYS" },
                    { 132, "Maldives", "MDV" },
                    { 133, "Mali", "MLI" },
                    { 134, "Malta", "MLT" },
                    { 135, "Marshall Islands", "MHL" },
                    { 136, "Martinique", "MTQ" },
                    { 137, "Mauritania", "MRT" },
                    { 138, "Mauritius", "MUS" },
                    { 139, "Mayotte", "MYT" },
                    { 140, "Mexico", "MEX" },
                    { 141, "Micronesia", "FSM" },
                    { 142, "Moldova", "MDA" },
                    { 143, "Monaco", "MCO" },
                    { 144, "Mongolia", "MNG" },
                    { 145, "Montenegro", "MNE" },
                    { 146, "Montserrat", "MSR" },
                    { 147, "Morocco", "MAR" },
                    { 148, "Mozambique", "MOZ" },
                    { 149, "Myanmar", "MMR" },
                    { 150, "Namibia", "NAM" },
                    { 151, "Nauru", "NRU" },
                    { 152, "Nepal", "NPL" },
                    { 153, "Netherlands", "NLD" },
                    { 154, "New Caledonia", "NCL" },
                    { 155, "New Zealand", "NZL" },
                    { 156, "Nicaragua", "NIC" },
                    { 157, "Nigeria", "NGA" },
                    { 158, "Niger", "NER" },
                    { 159, "Niue", "NIU" },
                    { 160, "Norfolk Island", "NFK" },
                    { 161, "Northern Mariana Islands", "MNP" },
                    { 162, "North Korea", "PRK" },
                    { 163, "North Macedonia", "MKD" },
                    { 164, "Norway", "NOR" },
                    { 165, "Oman", "OMN" },
                    { 166, "Pakistan", "PAK" },
                    { 167, "Palau", "PLW" },
                    { 168, "Palestine", "PSE" },
                    { 169, "Panama", "PAN" },
                    { 170, "Papua New Guinea", "PNG" },
                    { 171, "Paraguay", "PRY" },
                    { 172, "Peru", "PER" },
                    { 173, "Philippines", "PHL" },
                    { 174, "Pitcairn Islands", "PCN" },
                    { 175, "Poland", "POL" },
                    { 176, "Portugal", "PRT" },
                    { 177, "Puerto Rico", "PRI" },
                    { 178, "Qatar", "QAT" },
                    { 179, "Republic of the Congo", "COG" },
                    { 180, "Réunion", "REU" },
                    { 181, "Romania", "ROU" },
                    { 182, "Russia", "RUS" },
                    { 183, "Rwanda", "RWA" },
                    { 184, "Saint Barthélemy", "BLM" },
                    { 185, "Saint Helena, Ascension and Tristan da Cunha", "SHN" },
                    { 186, "Saint Kitts and Nevis", "KNA" },
                    { 187, "Saint Lucia", "LCA" },
                    { 188, "Saint Martin", "MAF" },
                    { 189, "Saint Pierre and Miquelon", "SPM" },
                    { 190, "Saint Vincent and the Grenadines", "VCT" },
                    { 191, "Samoa", "WSM" },
                    { 192, "San Marino", "SMR" },
                    { 193, "São Tomé and Príncipe", "STP" },
                    { 194, "Saudi Arabia", "SAU" },
                    { 195, "Senegal", "SEN" },
                    { 196, "Serbia", "SRB" },
                    { 197, "Seychelles", "SYC" },
                    { 198, "Sierra Leone", "SLE" },
                    { 199, "Singapore", "SGP" },
                    { 200, "Sint Maarten", "SXM" },
                    { 201, "Slovakia", "SVK" },
                    { 202, "Slovenia", "SVN" },
                    { 203, "Solomon Islands", "SLB" },
                    { 204, "Somalia", "SOM" },
                    { 205, "South Africa", "ZAF" },
                    { 206, "South Georgia", "SGS" },
                    { 207, "South Korea", "KOR" },
                    { 208, "South Sudan", "SSD" },
                    { 209, "Spain", "ESP" },
                    { 210, "Sri Lanka", "LKA" },
                    { 211, "Sudan", "SDN" },
                    { 212, "Suriname", "SUR" },
                    { 213, "Svalbard and Jan Mayen", "SJM" },
                    { 214, "Eswatini", "SWZ" },
                    { 215, "Sweden", "SWE" },
                    { 216, "Switzerland", "CHE" },
                    { 217, "Syria", "SYR" },
                    { 218, "Taiwan", "TWN" },
                    { 219, "Tajikistan", "TJK" },
                    { 220, "Tanzania", "TZA" },
                    { 221, "Thailand", "THA" },
                    { 222, "Timor-Leste", "TLS" },
                    { 223, "Togo", "TGO" },
                    { 224, "Tokelau", "TKL" },
                    { 225, "Tonga", "TON" },
                    { 226, "Trinidad and Tobago", "TTO" },
                    { 227, "Tunisia", "TUN" },
                    { 228, "Turkey", "TUR" },
                    { 229, "Turkmenistan", "TKM" },
                    { 230, "Turks and Caicos Islands", "TCA" },
                    { 231, "Tuvalu", "TUV" },
                    { 232, "Uganda", "UGA" },
                    { 233, "Ukraine", "UKR" },
                    { 234, "United Arab Emirates", "ARE" },
                    { 235, "United Kingdom", "GBR" },
                    { 236, "United States", "USA" },
                    { 237, "United States Minor Outlying Islands", "UMI" },
                    { 238, "United States Virgin Islands", "VIR" },
                    { 239, "Uruguay", "URY" },
                    { 240, "Uzbekistan", "UZB" },
                    { 241, "Vanuatu", "VUT" },
                    { 242, "Vatican City", "VAT" },
                    { 243, "Venezuela", "VEN" },
                    { 244, "Vietnam", "VNM" },
                    { 245, "Wallis and Futuna", "WLF" },
                    { 246, "Western Sahara", "ESH" },
                    { 247, "Yemen", "YEM" },
                    { 248, "Zambia", "ZMB" },
                    { 249, "Zimbabwe", "ZWE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CountryOfOriginMovie_CountriesOfOrigin_CountriesOfOriginId",
                table: "CountryOfOriginMovie",
                column: "CountriesOfOriginId",
                principalTable: "CountriesOfOrigin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
