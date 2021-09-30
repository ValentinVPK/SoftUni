using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace _1.InitialSetup
{
    public class Program
    {
        const string connectionString = "Server=.;Database=MinionsDB;Integrated Security=true";
        public static void Main(string[] args)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            // InitialSetup(connection); // 1st task

            // VillainNames(connection); // 2nd task

            //MinionNames(connection); // 3d task

            //AddMinion(connection); // 4th task

            // ChangeTownNamesCasing(connection); //5th task
            RemoveVillain(connection);
        }

        private static void RemoveVillain(SqlConnection connection)
        {
            int value = int.Parse(Console.ReadLine());

            string villainNameQuery = "SELECT Name FROM Villains WHERE Id = @villainId";
            using var sqlCommand = new SqlCommand(villainNameQuery, connection);
            sqlCommand.Parameters.AddWithValue("@villainId", value);

            var name = (string)sqlCommand.ExecuteScalar();

            if (name == null)
            {
                Console.WriteLine("No such villain found.");
                return;
            }

            var deleteMinionsVillainsQuery = "DELETE FROM MinionsVillains WHERE VillainId = @villainId";
            using var deleteMVCommand = new SqlCommand(deleteMinionsVillainsQuery, connection);
            sqlCommand.Parameters.AddWithValue("@villainId", value);

            var affectdRows = deleteMVCommand.ExecuteNonQuery();


            var deleteVillainQuery = "DELETE FROM Villains WHERE Id = @villainId";
            using var deleteVCommand = new SqlCommand(deleteVillainQuery, connection);
            sqlCommand.Parameters.AddWithValue("@villainId", value);

            deleteVCommand.ExecuteNonQuery();

            Console.WriteLine($"{name} was deleted.");
            Console.WriteLine($"{affectdRows} minions were released");
        }

        private static void ChangeTownNamesCasing(SqlConnection connection)
        {
            string countryName = Console.ReadLine();

            string updateTownNamesQuery = "UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @CountryName)";

            string selectTownNamesQuery = "SELECT t.Name FROM Towns AS t JOIN Countries AS c ON c.Id = t.CountryCode WHERE c.Name = @countryName";

            using (var updateCommand = new SqlCommand(updateTownNamesQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@countryName", countryName);
                var affectedRows = updateCommand.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    Console.WriteLine($"{affectedRows} town names were affected.");

                    using (var selectCommand = new SqlCommand(selectTownNamesQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@countryName", countryName);

                        using (var reader = selectCommand.ExecuteReader())
                        {
                            var towns = new List<string>();
                            while (reader.Read())
                            {
                                towns.Add((string)reader[0]);
                            }

                            Console.WriteLine($"[{string.Join(", ", towns)}]");
                        }
                    }
                }
            }
        }

        private static void AddMinion(SqlConnection connection)
        {
            string[] minionInfo = Console.ReadLine()
                                .Split();

            string[] villainInfo = Console.ReadLine().Split();

            string minionName = minionInfo[1];
            int age = int.Parse(minionInfo[2]);
            string town = minionInfo[3];

            int? townId = GetTownId(connection, town);

            if (townId == null)
            {
                string createTownQuery = $"INSERT INTO Towns (Name) VALUES (@name)";
                using (var command = new SqlCommand(createTownQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", town);
                    command.ExecuteNonQuery();
                    townId = GetTownId(connection, town);
                    Console.WriteLine($"Town {town} was added to the database.");
                }
            }

            string villainName = villainInfo[1];

            int? villainId = GetVillainId(connection, villainName);

            if (villainId == null)
            {
                string createVillainQuery = "INSERT INTO Villains (Name, EvilnessFactor) VALUES (@name, 4)";

                using (var command = new SqlCommand(createVillainQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", villainName);
                    command.ExecuteNonQuery();
                    villainId = GetVillainId(connection, villainName);
                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }
            }

            CreateMinion(connection, minionName, age, townId);
            var minionId = GetMinionId(connection, minionName);
            InsertMinionVillain(connection, villainId, minionId);
            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
        }

        private static void InsertMinionVillain(SqlConnection connection, int? villainId, int? minionId)
        {
            var insertIntoMinVilQuery = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

            using (var command = new SqlCommand(insertIntoMinVilQuery, connection))
            {
                command.Parameters.AddWithValue("@villainId", villainId);
                command.Parameters.AddWithValue("@minionId", minionId);
                command.ExecuteNonQuery();
            }
        }

        private static int? GetMinionId(SqlConnection connection, string minionName)
        {
            var minionIdQuery = "SELECT Id FROM Minions WHERE Name = @Name";
            using (var command = new SqlCommand(minionIdQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", minionName);
                var minionId = command.ExecuteScalar();
                return (int?)minionId;
            }
        }

        private static void CreateMinion(SqlConnection connection, string minionName, int age, int? townId)
        {
            string createMinionQuery = "INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";

            using (var command = new SqlCommand(createMinionQuery, connection))
            {
                command.Parameters.AddWithValue("@name", minionName);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@townId", townId);
                command.ExecuteNonQuery();
            }
        }

        private static int? GetVillainId(SqlConnection connection, string villainName)
        {
            string query = "SELECT Id FROM Villains WHERE Name = @Name";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", villainName);
                var villainId = command.ExecuteScalar();

                return (int?)villainId;
            }
        }

        private static int? GetTownId(SqlConnection connection, string town)
        {
            string townIdQuery = "SELECT Id FROM Towns WHERE Name = @townName";

            using (var sqlCommand = new SqlCommand(townIdQuery, connection))
            {
                sqlCommand.Parameters.AddWithValue("@townName", town);
                var townId = sqlCommand.ExecuteScalar();

                return (int?)townId;
            }
        }

        private static void MinionNames(SqlConnection connection)
        {
            int id = int.Parse(Console.ReadLine());

            string villainNameQuery = "SELECT Name FROM Villains WHERE Id = @Id";

            using (var command = new SqlCommand(villainNameQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                var result = command.ExecuteScalar();

                string minionsQuery = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
					m.Name,
					m.Age
			FROM MinionsVillains AS mv
			JOIN Minions AS m ON m.Id = mv.MinionId
			WHERE mv.VillainId = @Id
		ORDER BY m.Name";

                if (result == null)
                {
                    Console.WriteLine($"No villain with ID {id} exists in the database.");
                }
                else
                {
                    Console.WriteLine($"Villain {result}");

                    using (var minionCommand = new SqlCommand(minionsQuery, connection))
                    {
                        minionCommand.Parameters.AddWithValue("@Id", id);
                        using (var reader = minionCommand.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("(no minions)");
                            }
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader[0]}. {reader[1]} " +
                                    $"{reader[2]}");
                            }
                        }
                    }
                }

            }
        }

        private static void VillainNames(SqlConnection connection)
        {
            string query = @"SELECT v.Name, COUNT(mv.MinionId)
	FROM Villains AS v
	JOIN MinionsVillains AS mv ON mv.VillainId = v.Id
  GROUP BY mv.MinionId, v.Name";

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader[0];
                        var count = reader[1];

                        Console.WriteLine($"{name} - {count}");
                    }
                }
            }
        }

        private static void InitialSetup(SqlConnection connection)
        {
            //create database
            string createDatabase = "CREATE DATABASE MinionsDB";

            ExecuteNonQuery(connection, createDatabase);

            //create tables

            var createTableStatements = GetCreateTableStatements();

            foreach (var query in createTableStatements)
            {
                ExecuteNonQuery(connection, query);
            }

            //insert values

            var insertStatements = GetInsertTableStatementes();

            foreach (var query in insertStatements)
            {
                ExecuteNonQuery(connection, query);
            }
        }

        private static void ExecuteNonQuery(SqlConnection connection, string query)
        {
            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static string[] GetInsertTableStatementes()
        {
            var result = new string[]
            {
                "INSERT INTO Countries (Id,Name) VALUES (1,'Bulgaria'), (2,'Norway'), (3,'Cyprus'), (4, 'Greece'), (5,'UK')",
                "INSERT INTO Towns (Id,Name,CountryCode)	VALUES (1, 'Plovdiv', 1), (2, 'Oslo',2), (3, 'Larnaca',3), (4, 'Athens',4), (5, 'London',5)",
                "INSERT INTO Minions (Id, Name, Age, TownId) VALUES (1, 'Stoyan', 12, 1), (2, 'George', 22, 2), (3, 'Ivan', 25, 3), (4, 'Kiro', 35, 4), (5, 'Niki', 25, 5)",
                "INSERT INTO EvilnessFactors (Id, Name) VALUES (1, 'super good'), (2, 'good'), (3, 'bad'), (4, 'evil'), (5, 'super evil')",
                "INSERT INTO Villains (Id, Name, EvilnessFactorId) VALUES (1, 'Gru', 1), (2, 'Ivo', 2), (3, 'Teo', 3), (4, 'Sto', 4), (5, 'Pro', 5)",
                "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (1,1), (2,2), (3,3), (4,4), (5,5)"
            };

            return result;
        }

        private static string[] GetCreateTableStatements()
        {
            var result = new string[]
            {
                "CREATE TABLE Countries(Id INT PRIMARY KEY,Name VARCHAR(50))",
                "CREATE TABLE Towns(Id INT PRIMARY KEY,Name VARCHAR(50),CountryCode INT FOREIGN KEY REFERENCES Countries(Id))",
                "CREATE TABLE Minions(Id INT PRIMARY KEY,Name VARCHAR(50),Age INT,TownId INT FOREIGN KEY REFERENCES Towns(Id))",
                "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY,Name VARCHAR(50))",
                "CREATE TABLE Villains(Id INT PRIMARY KEY,Name VARCHAR(50),EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))",
                "CREATE TABLE MinionsVillains(MinionId INT FOREIGN KEY REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId))"
            };

            return result;
        }
    }
}
