using GoogleBooks.Common;
using GoogleBooks.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace GoogleBooks.Model
{
    public class Favorite : Conn
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string thumbnail { get; set; }
        public string smallThumbnail { get; set; }

        public Favorite(string id, string title, string description, string thumbnail, string smallThumbnail) 
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.thumbnail = thumbnail;
            this.smallThumbnail = smallThumbnail;
        }
        public static bool insert(Favorite obj)
        {
            try
            {
                using (var cmd = dbConn().CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Favoritos (id, title, description, thumbnail, small_thumbnail) values (@id, @title, @description, @thumbnail, @small_thumbnail)";
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@title", obj.title);
                    cmd.Parameters.AddWithValue("@description", obj.description);
                    cmd.Parameters.AddWithValue("@thumbnail", obj.thumbnail);
                    cmd.Parameters.AddWithValue("@small_thumbnail", obj.smallThumbnail);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool delete(string id)
        {
            try
            {
                using (var cmd = dbConn().CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM Favoritos where id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static IEnumerable<string> getAllId()
        {
            try
            {
                using (var cmd = dbConn().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Favoritos";

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<string> favs = new List<string>();
                        while (reader.Read())
                        {
                            favs.Add(reader.GetString(0));
                        }

                        return favs;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new List<string>();
        }

        public static IEnumerable<Favorite> getAll()
        {
            try
            {
                using (var cmd = dbConn().CreateCommand())
                {
                    cmd.CommandText = "SELECT id, title, description, thumbnail, small_thumbnail FROM Favoritos";

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<Favorite> favs = new List<Favorite>();
                        while (reader.Read())
                        {
                            IDataRecord row = ((IDataRecord)reader);
                            favs.Add(new Favorite(
                                id: Funcs.toString(row[0]),
                                title: Funcs.toString(row[1]),
                                description: Funcs.toString(row[2]),
                                thumbnail: Funcs.toString(row[3]),
                                smallThumbnail: Funcs.toString(row[4])
                                ));
                        }

                        return favs;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new List<Favorite>();
        }
    }
}
