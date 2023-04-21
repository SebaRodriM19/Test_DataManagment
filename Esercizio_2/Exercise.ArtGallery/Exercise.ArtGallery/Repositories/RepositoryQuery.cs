using Exercise.ArtGallery.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Exercise.ArtGallery.Constants;

namespace Exercise.ArtGallery.Repositories
{

    public class RepositoryQuery
    {

        public void QueryOne()
        {
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(queryOne, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);

                while (reader?.Read() == true)
                {
                    var res = new
                    {
                        MuseumName = reader.GetString("MuseumName"),
                        IdArtwork = reader.GetInt16("Id_Artwork"),
                        NameArtwork = reader.GetString("NameArtwork"),
                        NameArtist = reader.GetString("NameArtist")
                    };

                    Console.WriteLine(JsonSerializer.Serialize(res));

                }
                cn.Close();
            }
            catch(SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        public void QueryTwo()
        {
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(queryTwo, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);

                while (reader?.Read() == true)
                {
                    var res = new
                    {
                        NameArtist = reader.GetString("NameArtist")
                    };
                    Console.WriteLine(JsonSerializer.Serialize(res));
                }

                cn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void QueryThree()
        {
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(queryTwo, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);
                Console.WriteLine("Flora is in: ");
                while (reader?.Read() == true)
                {
                    var res = new
                    {
                        City = reader.GetString("City")
                    };

                    Console.WriteLine(JsonSerializer.Serialize(res));
                }
                cn.Close();
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

    }
}
