using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRental.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCountriesOrigin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CountriesOfOrigin",
                keyColumn: "Id",
                keyValue: 249);
        }
    }
}
