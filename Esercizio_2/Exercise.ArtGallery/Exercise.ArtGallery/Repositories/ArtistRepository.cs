using Exercise.ArtGallery.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise.ArtGallery.Constants;

namespace Exercise.ArtGallery.Repositories
{
    public interface IArtistRepository
    {
        //will be change the contract with a list entity as type return
        Artist GetArtist();
    }
    public class ArtistRepository : IArtistRepository
    {
        public Artist GetArtist()
        {
            var command = "SELECT * FROM Artist ";
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(command, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);
                //it will be changed with a while loop to add entity on list
                if (reader?.Read() == true)
                {
                    return new Artist()
                    {
                        IdArtist = reader.GetInt16("Id_Artist"),
                        Name = reader.GetString("Name"),
                        Country = reader.GetString("Country")
                    };
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }
    }
    
}
