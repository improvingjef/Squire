using System;
using NUnit.Framework;
using Squire.Framework;

namespace Squire
{
    [TestFixture]
    public class SqlKihon : SqlKihonBase
    {
        /* Given SQL Tables defined as:
         * ----------------------------
         * CREATE TABLE Person
           (
             PersonId int not null PRIMARY KEY, 
             FirstName varchar(50),
             LastName varchar(50),
             Age int
           )
         * 
         * CREATE TABLE Address
           (
             AddressId int not null PRIMARY KEY, 
             PersonId int,
             Line1 varchar(50),
             Line2 varchar(50),
             City varchar(50),
             State varchar(50),
             Zip varchar(9)
           )
         */
        protected override string Select_All_Fields_And_Rows_From_Person()
        {
            return "SELECT * FROM Person";
        }

        protected override string Select_All_Fields_From_Person_Joined_To_Address()
        {
            return @"SELECT * FROM Person
                    JOIN Address on Person.PersonId = Address.PersonId";

            return @"SELECT * FROM Person P
                    JOIN Address A on P.PersonId = A.PersonId";
        }

        protected override string Select_FirstName_From_Person_Where_LastName_Equals_Rayburn()
        {
            return "SELECT FirstName FROM Person WHERE LastName = 'Rayburn'";
        }

        protected override string Select_All_Fields_From_Person_Left_Outer_Joined_To_Address()
        {
            return @"SELECT * FROM Person
                LEFT OUTER JOIN Address on Person.PersonId = Address.PersonId";

            return @"SELECT * FROM Person P
                LEFT OUTER JOIN Address A on P.PersonId = A.PersonId";
        }

        protected override string Insert_PersonId_4_Named_Mike_Johnson_Age_5_To_Person()
        {
            return @"INSERT INTO Person (PersonId, FirstName, LastName, Age) VALUES (4, 'Mike', 'Johnson', 5)";
        }

        protected override string Update_All_LastNames_Rayburn_To_Johnson_In_Person()
        {
            return "UPDATE Person SET LastName = 'Johnson' WHERE LastName = 'Rayburn'";
        }
    }
}
