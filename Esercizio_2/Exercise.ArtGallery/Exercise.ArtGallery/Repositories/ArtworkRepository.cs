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
    public interface IArtworkRepository
    {
        Artwork GetArtwork();
    }
    public class ArtworkRepository : IArtworkRepository
    {
        //will be change the contract with a list entity as type return
        public Artwork GetArtwork()
        {
            var command = "SELECT * FROM Artwork ";
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(command, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);
                //it will be changed with a while loop to add entity on list
                if (reader?.Read() == true)
                {
                    return new Artwork()
                    {
                        IdArtwork= reader.GetInt16("Id_Artwork"),
                        Name = reader.GetString("Name"),
                        IdMuseum = new Museum { IdMuseum = reader.GetInt16("Id_Museum") },
                        IdArtist = new Artist { IdArtist = reader.GetInt16("Id_Artist") },
                        IdCharacter = new Character { IdCharachter = reader.GetInt16("Id_Character")}
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

