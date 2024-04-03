using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MugiwaraMusic
{
    internal class DataIO
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\MugiwaraMusic\\MugiwaraMusic\\Audio.mdf\";Integrated Security=True");

        public bool checkPlaylist(string playlistName) 
        {
            string Select = "SELECT playlist_name FROM tbl_Playlist WHERE playlist_name = '" + playlistName + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Select,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0) 
            { 
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public bool checkAudio(string Audio)
        {
            string Select = "SELECT audio_Name FROM tbl_Audio WHERE audio_Name = '" + Audio + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkPlaylistAudio(int audioid, int playlistid) 
        {
            string Select = "SELECT * FROM tbl_PlaylistAudios WHERE audio_ID = '" + audioid + "' AND playlist_ID = '" + playlistid + "'";
            SqlDataAdapter adapter = new SqlDataAdapter( Select, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0) 
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public void SaveAudio(string Name, string path) 
        {
            string Insert = "INSERT INTO tbl_Audio(audio_Name, audio_FilePath) VALUES(@name, @path)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@path", path);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SavePlaylist(string Name, byte[] img) 
        {
            string Insert = "INSERT INTO tbl_Playlist(playlist_name, playlist_img) VALUES(@name, @pic)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@pic", img);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SavePlaylistAudio(int audioID, int playlistID) 
        {
            string Insert = "INSERT INTO tbl_PlaylistAudios(audio_ID, playlist_ID) VALUES(@id1, @id2)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@id1", audioID);
            cmd.Parameters.AddWithValue("@id2", playlistID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getPlaylists() 
        {
            string select = "SELECT * FROM tbl_Playlist";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable(); 
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getPlaylistAudios(string ID)
        {
            string select = "SELECT * FROM tbl_PlaylistAudios JOIN tbl_Playlist ON tbl_Playlist.playlist_ID = tbl_PlaylistAudios.playlist_ID JOIN tbl_Audio ON tbl_Audio.audio_ID = tbl_PlaylistAudios.audio_ID WHERE tbl_PlaylistAudios.playlist_ID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getAudios() 
        {
            string select = "SELECT * FROM tbl_Audio";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getSearchedPlaylistAudios(string ID, string name)
        {
            string select = "SELECT * FROM tbl_PlaylistAudios JOIN tbl_Playlist ON tbl_Playlist.playlist_ID = tbl_PlaylistAudios.playlist_ID JOIN tbl_Audio ON tbl_Audio.audio_ID = tbl_PlaylistAudios.audio_ID WHERE tbl_Audio.audio_Name LIKE '" + name + "%' AND tbl_PlaylistAudios.playlist_ID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getSearchedPlaylist(string name)
        {
            string select = "SELECT * FROM tbl_Playlist WHERE playlist_Name LIKE '"+name+"%'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getSearchedAudios(string name)
        {
            string select = "SELECT * FROM tbl_Audio WHERE audio_Name LIKE '%"+name+"%'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void DeletePlaylist(int ID) 
        {
            string DELETE = "DELETE FROM tbl_Playlist WHERE playlist_ID = '" + ID + "'; DELETE FROM tbl_PlaylistAudios WHERE playlist_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted.");
        }

        public void DeleteAudio(int playID, int audID) 
        {
            string DELETE = "DELETE FROM tbl_PlaylistAudios WHERE playlist_ID = '" + playID + "' AND audio_ID = '"+audID+"'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
