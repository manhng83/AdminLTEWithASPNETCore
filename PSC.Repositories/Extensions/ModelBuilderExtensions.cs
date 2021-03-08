﻿using Microsoft.EntityFrameworkCore;
using PSC.Domain.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Repositories.Extensions
{
    /// <summary>
    /// Class ModelBuilderExtensions.
    /// </summary>
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Seeds the specified model builder.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { IDCountry = 1, Name = "Afghanistan" },
                new Country { IDCountry = 2, Name = "Albania" },
                new Country { IDCountry = 3, Name = "Algeria" },
                new Country { IDCountry = 4, Name = "Andorra" },
                new Country { IDCountry = 5, Name = "Angola" },
                new Country { IDCountry = 6, Name = "Antigua and Barbuda" },
                new Country { IDCountry = 7, Name = "Argentina" },
                new Country { IDCountry = 8, Name = "Armenia" },
                new Country { IDCountry = 9, Name = "Australia" },
                new Country { IDCountry = 10, Name = "Austria" },
                new Country { IDCountry = 11, Name = "Azerbaijan" },
                new Country { IDCountry = 12, Name = "The Bahamas" },
                new Country { IDCountry = 13, Name = "Bahrain" },
                new Country { IDCountry = 14, Name = "Bangladesh" },
                new Country { IDCountry = 15, Name = "Barbados" },
                new Country { IDCountry = 16, Name = "Belarus" },
                new Country { IDCountry = 17, Name = "Belgium" },
                new Country { IDCountry = 18, Name = "Belize" },
                new Country { IDCountry = 19, Name = "Benin" },
                new Country { IDCountry = 20, Name = "Bhutan" },
                new Country { IDCountry = 21, Name = "Bolivia" },
                new Country { IDCountry = 22, Name = "Bosnia and Herzegovina" },
                new Country { IDCountry = 23, Name = "Botswana" },
                new Country { IDCountry = 24, Name = "Brazil" },
                new Country { IDCountry = 25, Name = "Brunei" },
                new Country { IDCountry = 26, Name = "Bulgaria" },
                new Country { IDCountry = 27, Name = "Burkina Faso" },
                new Country { IDCountry = 28, Name = "Burundi" },
                new Country { IDCountry = 29, Name = "Cambodia" },
                new Country { IDCountry = 30, Name = "Cameroon" },
                new Country { IDCountry = 31, Name = "Canada" },
                new Country { IDCountry = 32, Name = "Cape Verde" },
                new Country { IDCountry = 33, Name = "Central African Republic" },
                new Country { IDCountry = 34, Name = "Chad" },
                new Country { IDCountry = 35, Name = "Chile" },
                new Country { IDCountry = 36, Name = "China" },
                new Country { IDCountry = 37, Name = "Colombia" },
                new Country { IDCountry = 38, Name = "Comoros" },
                new Country { IDCountry = 39, Name = "Congo, Republic of the" },
                new Country { IDCountry = 40, Name = "Congo, Democratic Republic of the" },
                new Country { IDCountry = 41, Name = "Costa Rica" },
                new Country { IDCountry = 42, Name = "Cote d'Ivoire" },
                new Country { IDCountry = 43, Name = "Croatia" },
                new Country { IDCountry = 44, Name = "Cuba" },
                new Country { IDCountry = 45, Name = "Cyprus" },
                new Country { IDCountry = 46, Name = "Czech Republic" },
                new Country { IDCountry = 47, Name = "Denmark" },
                new Country { IDCountry = 48, Name = "Djibouti" },
                new Country { IDCountry = 49, Name = "Dominica" },
                new Country { IDCountry = 50, Name = "Dominican Republic" },
                new Country { IDCountry = 51, Name = "East Timor (Timor-Leste)" },
                new Country { IDCountry = 52, Name = "Ecuador" },
                new Country { IDCountry = 53, Name = "Egypt" },
                new Country { IDCountry = 54, Name = "El Salvador" },
                new Country { IDCountry = 55, Name = "Equatorial Guinea" },
                new Country { IDCountry = 56, Name = "Eritrea" },
                new Country { IDCountry = 57, Name = "Estonia" },
                new Country { IDCountry = 58, Name = "Ethiopia" },
                new Country { IDCountry = 59, Name = "Fiji" },
                new Country { IDCountry = 60, Name = "Finland" },
                new Country { IDCountry = 61, Name = "France" },
                new Country { IDCountry = 62, Name = "Gabon" },
                new Country { IDCountry = 63, Name = "The Gambia" },
                new Country { IDCountry = 64, Name = "Georgia" },
                new Country { IDCountry = 65, Name = "Germany" },
                new Country { IDCountry = 66, Name = "Ghana" },
                new Country { IDCountry = 67, Name = "Greece" },
                new Country { IDCountry = 68, Name = "Grenada" },
                new Country { IDCountry = 69, Name = "Guatemala" },
                new Country { IDCountry = 70, Name = "Guinea" },
                new Country { IDCountry = 71, Name = "Guinea-Bissau" },
                new Country { IDCountry = 72, Name = "Guyana" },
                new Country { IDCountry = 73, Name = "Haiti" },
                new Country { IDCountry = 74, Name = "Honduras" },
                new Country { IDCountry = 75, Name = "Hungary" },
                new Country { IDCountry = 76, Name = "Iceland" },
                new Country { IDCountry = 77, Name = "India" },
                new Country { IDCountry = 78, Name = "Indonesia" },
                new Country { IDCountry = 79, Name = "Iran" },
                new Country { IDCountry = 80, Name = "Iraq" },
                new Country { IDCountry = 81, Name = "Ireland" },
                new Country { IDCountry = 82, Name = "Israel" },
                new Country { IDCountry = 83, Name = "Italy" },
                new Country { IDCountry = 84, Name = "Jamaica" },
                new Country { IDCountry = 85, Name = "Japan" },
                new Country { IDCountry = 86, Name = "Jordan" },
                new Country { IDCountry = 87, Name = "Kazakhstan" },
                new Country { IDCountry = 88, Name = "Kenya" },
                new Country { IDCountry = 89, Name = "Kiribati" },
                new Country { IDCountry = 90, Name = "Korea, North" },
                new Country { IDCountry = 91, Name = "Korea, South" },
                new Country { IDCountry = 92, Name = "Kosovo" },
                new Country { IDCountry = 93, Name = "Kuwait" },
                new Country { IDCountry = 94, Name = "Kyrgyzstan" },
                new Country { IDCountry = 95, Name = "Laos" },
                new Country { IDCountry = 96, Name = "Latvia" },
                new Country { IDCountry = 97, Name = "Lebanon" },
                new Country { IDCountry = 98, Name = "Lesotho" },
                new Country { IDCountry = 99, Name = "Liberia" },
                new Country { IDCountry = 100, Name = "Libya" },
                new Country { IDCountry = 101, Name = "Liechtenstein" },
                new Country { IDCountry = 102, Name = "Lithuania" },
                new Country { IDCountry = 103, Name = "Luxembourg" },
                new Country { IDCountry = 104, Name = "Macedonia" },
                new Country { IDCountry = 105, Name = "Madagascar" },
                new Country { IDCountry = 106, Name = "Malawi" },
                new Country { IDCountry = 107, Name = "Malaysia" },
                new Country { IDCountry = 108, Name = "Maldives" },
                new Country { IDCountry = 109, Name = "Mali" },
                new Country { IDCountry = 110, Name = "Malta" },
                new Country { IDCountry = 111, Name = "Marshall Islands" },
                new Country { IDCountry = 112, Name = "Mauritania" },
                new Country { IDCountry = 113, Name = "Mauritius" },
                new Country { IDCountry = 114, Name = "Mexico" },
                new Country { IDCountry = 115, Name = "Micronesia, Federated States of" },
                new Country { IDCountry = 116, Name = "Moldova" },
                new Country { IDCountry = 117, Name = "Monaco" },
                new Country { IDCountry = 118, Name = "Mongolia" },
                new Country { IDCountry = 119, Name = "Montenegro" },
                new Country { IDCountry = 120, Name = "Morocco" },
                new Country { IDCountry = 121, Name = "Mozambique" },
                new Country { IDCountry = 122, Name = "Myanmar (Burma)" },
                new Country { IDCountry = 123, Name = "Namibia" },
                new Country { IDCountry = 124, Name = "Nauru" },
                new Country { IDCountry = 125, Name = "Nepal" },
                new Country { IDCountry = 126, Name = "Netherlands" },
                new Country { IDCountry = 127, Name = "New Zealand" },
                new Country { IDCountry = 128, Name = "Nicaragua" },
                new Country { IDCountry = 129, Name = "Niger" },
                new Country { IDCountry = 130, Name = "Nigeria" },
                new Country { IDCountry = 131, Name = "Norway" },
                new Country { IDCountry = 132, Name = "Oman" },
                new Country { IDCountry = 133, Name = "Pakistan" },
                new Country { IDCountry = 134, Name = "Palau" },
                new Country { IDCountry = 135, Name = "Panama" },
                new Country { IDCountry = 136, Name = "Papua New Guinea" },
                new Country { IDCountry = 137, Name = "Paraguay" },
                new Country { IDCountry = 138, Name = "Peru" },
                new Country { IDCountry = 139, Name = "Philippines" },
                new Country { IDCountry = 140, Name = "Poland" },
                new Country { IDCountry = 141, Name = "Portugal" },
                new Country { IDCountry = 142, Name = "Qatar" },
                new Country { IDCountry = 143, Name = "Romania" },
                new Country { IDCountry = 144, Name = "Russia" },
                new Country { IDCountry = 145, Name = "Rwanda" },
                new Country { IDCountry = 146, Name = "Saint Kitts and Nevis" },
                new Country { IDCountry = 147, Name = "Saint Lucia" },
                new Country { IDCountry = 148, Name = "Saint Vincent and the Grenadines" },
                new Country { IDCountry = 149, Name = "Samoa" },
                new Country { IDCountry = 150, Name = "San Marino" },
                new Country { IDCountry = 151, Name = "Sao Tome and Principe" },
                new Country { IDCountry = 152, Name = "Saudi Arabia" },
                new Country { IDCountry = 153, Name = "Senegal" },
                new Country { IDCountry = 154, Name = "Serbia" },
                new Country { IDCountry = 155, Name = "Seychelles" },
                new Country { IDCountry = 156, Name = "Sierra Leone" },
                new Country { IDCountry = 157, Name = "Singapore" },
                new Country { IDCountry = 158, Name = "Slovakia" },
                new Country { IDCountry = 159, Name = "Slovenia" },
                new Country { IDCountry = 160, Name = "Solomon Islands" },
                new Country { IDCountry = 161, Name = "Somalia" },
                new Country { IDCountry = 162, Name = "South Africa" },
                new Country { IDCountry = 163, Name = "South Sudan" },
                new Country { IDCountry = 164, Name = "Spain" },
                new Country { IDCountry = 165, Name = "Sri Lanka" },
                new Country { IDCountry = 166, Name = "Sudan" },
                new Country { IDCountry = 167, Name = "Suriname" },
                new Country { IDCountry = 168, Name = "Swaziland" },
                new Country { IDCountry = 169, Name = "Sweden" },
                new Country { IDCountry = 170, Name = "Switzerland" },
                new Country { IDCountry = 171, Name = "Syria" },
                new Country { IDCountry = 172, Name = "Taiwan" },
                new Country { IDCountry = 173, Name = "Tajikistan" },
                new Country { IDCountry = 174, Name = "Tanzania" },
                new Country { IDCountry = 175, Name = "Thailand" },
                new Country { IDCountry = 176, Name = "Togo" },
                new Country { IDCountry = 177, Name = "Tonga" },
                new Country { IDCountry = 178, Name = "Trinidad and Tobago" },
                new Country { IDCountry = 179, Name = "Tunisia" },
                new Country { IDCountry = 180, Name = "Turkey" },
                new Country { IDCountry = 181, Name = "Turkmenistan" },
                new Country { IDCountry = 182, Name = "Tuvalu" },
                new Country { IDCountry = 183, Name = "Uganda" },
                new Country { IDCountry = 184, Name = "Ukraine" },
                new Country { IDCountry = 185, Name = "United Arab Emirates" },
                new Country { IDCountry = 186, Name = "United Kingdom", Order = 1 },
                new Country { IDCountry = 187, Name = "United States of America", Order = 1 },
                new Country { IDCountry = 188, Name = "Uruguay" },
                new Country { IDCountry = 189, Name = "Uzbekistan" },
                new Country { IDCountry = 190, Name = "Vanuatu" },
                new Country { IDCountry = 191, Name = "Vatican City (Holy See)" },
                new Country { IDCountry = 192, Name = "Venezuela" },
                new Country { IDCountry = 193, Name = "Vietnam" },
                new Country { IDCountry = 194, Name = "Yemen" },
                new Country { IDCountry = 195, Name = "Zambia" },
                new Country { IDCountry = 196, Name = "Zimbabwe" }
            );
        }
    }
}