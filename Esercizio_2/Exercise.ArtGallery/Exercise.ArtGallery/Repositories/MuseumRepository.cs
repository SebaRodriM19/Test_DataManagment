using Microsoft.Data.SqlClient;
using static Exercise.ArtGallery.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.ArtGallery.Models;

namespace Exercise.ArtGallery.Repositories
{
    public interface IMuseumRepository
    {
        Museum GetMusem();
    }
    public class MuseumRepository : IMuseumRepository
    {
        //will be change the contract with a list entity as type return
        public Museum GetMusem()
        {

            var command = "SELECT * FROM Museum ";
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(command, cn);
                cn.Open();
                using var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleRow);
                //it will be changed with a while loop to add entity on list
                if (reader?.Read() == true)
                {
                    return new Museum()
                    {
                        IdMuseum = reader.GetInt16("Id_Museum"),
                        MuseumName = reader.GetString("MuseumName"),
                        City = reader.GetString("City")
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

