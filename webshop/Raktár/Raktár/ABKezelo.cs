using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Raktár
{
    static class ABKezelo
    {
        static MySqlConnection conn;
        static MySqlCommand comm;
        static ABKezelo()
        {
            string connString = "Server = "+Beallitas.szerver+"; Database = "+Beallitas.db+"; Uid = "+Beallitas.felh+"; Pwd ="+Beallitas.jel+";SslMode=none";
            conn=new MySqlConnection(connString);
            comm=conn.CreateCommand();
            comm.Connection=conn;
            conn.Open();
        }

        internal static List<Szallitando> SzallitandoLekerdez()
        {
            try
            {
                comm.CommandText = "SELECT * FROM szallitas";
                List<Szallitando>szLista=new List<Szallitando>();   
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        int id = (int)olvas["id"];
                        int vid = (int)olvas["vid"];
                        int rid = (int)olvas["rid"];
                        int tid = (int)olvas["tid"];

                        Szallitando sz = new Szallitando(id, vid, rid, tid);
                        szLista.Add(sz);
                    }
                    olvas.Close();
                }
                return szLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void TermekHozzaAd(Aru a)
        {
            try
            {
                comm.Parameters.Clear();
                comm.CommandText = "INSERT INTO termek (cikkszam,kategoria,nev,darabar,darab,kep) VALUES (@c,@k,@n,@dba,@db,@kep)";
                comm.Parameters.AddWithValue("@c", a.Cikkszam);
                comm.Parameters.AddWithValue("@k", Convert.ToInt32(a.TermekKategoria));
                comm.Parameters.AddWithValue("@n", a.Nev);
                comm.Parameters.AddWithValue("@dba", a.Darabar);
                comm.Parameters.AddWithValue("@db", a.Darab);
                comm.Parameters.AddWithValue("@kep", a.Kephely);
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Aru> TermekBetolt()
        {
            try
            {
                List<Aru> aLista = new List<Aru>();
                comm.CommandText = "SELECT * FROM termek";
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        int id = Convert.ToInt32(olvas["id"]);
                        string cikkszam = olvas["cikkszam"].ToString();
                        TKategoria kategoria = (TKategoria)(Convert.ToInt32(olvas["kategoria"]));
                        string nev = olvas["nev"].ToString();
                        int darabar = Convert.ToInt32(olvas["darabar"]);
                        int darab = Convert.ToInt32(olvas["darab"]);
                        string kep=olvas["kep"].ToString();
                        Aru a = new Aru(id, cikkszam, kategoria, nev, darabar, darab, kep);
                        aLista.Add(a);
                    }
                    return aLista;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void TermekModosit(Aru a, bool kepvalt)
        {
            try
            {
                comm.Parameters.Clear();
                
                if (kepvalt)
                {
                    comm.CommandText = "UPDATE termek SET cikkszam=@c,kategoria=@k,nev=@n,darabar=@dba,darab=@db,kep=@kep WHERE Id=@id";

                }
                else
                {
                    comm.CommandText = "UPDATE termek SET cikkszam=@c,kategoria=@k,nev=@n,darabar=@dba,darab=@db WHERE Id=@id";
                }
                comm.Parameters.AddWithValue("@c", a.Cikkszam);
                comm.Parameters.AddWithValue("@k", Convert.ToInt32(a.TermekKategoria));
                comm.Parameters.AddWithValue("@n", a.Nev);
                comm.Parameters.AddWithValue("@dba", a.Darabar);
                comm.Parameters.AddWithValue("@db", a.Darab);
                if (kepvalt)
                {
                    comm.Parameters.AddWithValue("@kep", a.Kephely);
                }
              
                comm.Parameters.AddWithValue("@id", a.Id);
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void KepTorol(int id)
        {
            try
            {
                comm.CommandText = "UPDATE termek SET kep=\"\" WHERE Id=" + id;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static void ElinditottHozzaad(int szallitasId, int futarId, int rendId)
        {
            try
            {
                comm.CommandText = "INSERT INTO elinditott (szallitasid, futarid) VALUES (@szid,@fid)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@szid",szallitasId);
                comm.Parameters.AddWithValue("fid", futarId);
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                
            }
        }

        public static List<Elinditott> ElinditottBetolt()
        {
            try
            {
                List<Elinditott> eLista = new List<Elinditott>();
                comm.CommandText = "SELECT * FROM elinditott";
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        Elinditott e = new Elinditott((int)(olvas["id"]),(int)olvas["szallitasid"],(int)olvas["futarid"]);
                        eLista.Add(e);
                    }
                    olvas.Close();
                    return eLista;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ElinditottTorol(int szallitasId) 
        {
            try
            {
                comm.CommandText = "DELETE FROM elinditott WHERE szallitasid=" + szallitasId;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
       

        public static void TermekTorol(int id)
        {
            try
            {
                comm.CommandText = "DELETE FROM termek WHERE Id=" + id;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //rendelés

       public static List<Rendeles> RendelesBetolt()
        {
            try
            {
                List<Rendeles> rLista=  new List<Rendeles>();
                comm.CommandText = "SELECT * FROM rendeles";
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        rLista.Add(new Rendeles((int)olvas["id"], (int)olvas["darab"], (int)olvas["ar"], (int)olvas["termekid"], (int)olvas["vevoid"], (FutarNevek)(int)olvas["futarceg"]));
                    }
                    olvas.Close();
                }
                return rLista;  

            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static void SzallitandoTorol(Szallitando sz)
        {
            try
            {
                comm.CommandText = "DELETE FROM szallitas WHERE id=" + sz.Id;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Vevo RendelesVevoLekerdez(int vevoid)
        {
            try
            {
                comm.Parameters.Clear();
                comm.CommandText = "SELECT * FROM vevo WHERE id=" + vevoid;
                Vevo v = null;
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        int id = (int)olvas["id"];
                        string ado = olvas["adoszam"].ToString();
                        string vevonev = olvas["Vevonev"].ToString();
                        int irsz = (int)olvas["irsz"];
                        string helyseg = olvas["helyseg"].ToString();
                        string utca = olvas["utca"].ToString();
                        int hsz = (int)olvas["hsz"];
                        string telefon = olvas["telefon"].ToString();
                        string email = olvas["email"].ToString();
                        if (ado != "")
                        {
                            v = new Vevo(id, vevonev, irsz, helyseg, utca, hsz, telefon, email, ado);
                        }
                        else
                        {
                            v = new Vevo(id, vevonev, irsz, helyseg, utca, hsz, telefon, email);
                        }
                    }
                    
                    olvas.Close();
                }
                return v;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Aru RendelesTermekLekerdez(int termekid)
        {
            comm.Parameters.Clear();
            comm.CommandText = "SELECT * FROM termek WHERE id=" + termekid;
            Aru t = null;
            using (MySqlDataReader olvas = comm.ExecuteReader())
            {
                while (olvas.Read())
                {
                    int id = (int)olvas["Id"];
                    string cikkszam = olvas["cikkszam"].ToString();
                    TKategoria kategoria = (TKategoria)(int)olvas["kategoria"];
                    string nev = olvas["nev"].ToString();
                    int darabar = (int)olvas["darabar"];
                    int darab = (int)olvas["darab"];
                    string kep = olvas["kep"].ToString();
                    t = new Aru(id, cikkszam, kategoria, nev, darabar, darab, kep);
                }
                
                
                olvas.Close();
            }
            return t;
        }

        public static void RendelesTorol(int rendelesId)
        {
            try
            {

                comm.CommandText = "DELETE FROM rendeles WHERE id=" + rendelesId;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SzallitandoHozzaad(Szallitando elem)
        {
            try
            {
                
                comm.CommandText = "INSERT INTO Szallitas (vid,rid,tid) VALUES (@vid,@rid,@tid)";
                
               
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@vid", elem.Vid);
                    comm.Parameters.AddWithValue("@rid", elem.Rid);
                    comm.Parameters.AddWithValue("@tid", elem.Tid);
                    comm.ExecuteNonQuery();
                
                
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SzallitandoTorol(int rendelesId)
        {
            try
            {
                comm.CommandText = "DELETE FROM szallitas WHERE rid=" + rendelesId;
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<Futar> FutarLekerdez()
        {
            try
            {
                List<Futar>fLista=new List<Futar>();
                comm.CommandText = "SELECT * FROM futar";
                using (MySqlDataReader olvas=comm.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        fLista.Add(new Futar((int)olvas["id"], olvas["futarnev"].ToString(), olvas["telefon"].ToString(), olvas["email"].ToString(), (FutarNevek)(int)olvas["futarceg"]));
                    }
                    olvas.Close();
                }
                return fLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void FutarHozaad(Futar f)
        {
            try
            {
                comm.Parameters.Clear();
                int futarnevek = 0;
                switch (f.Fnev)
                {
                    case FutarNevek.FOXPOST:
                        futarnevek = 0;
                        break;
                    case FutarNevek.GLS:
                        futarnevek= 1;
                        break;
                    case FutarNevek.DPD:
                        futarnevek = 2;
                        break;
                }
                comm.CommandText = "INSERT INTO futar (futarnev,futarceg,telefon,email) VALUES (@fnev,@ceg,@tel,@email)";
                comm.Parameters.AddWithValue("@fnev", f.Futarnev);
                comm.Parameters.AddWithValue("@ceg", futarnevek);
                comm.Parameters.AddWithValue("@tel",f.Telefon);
                comm.Parameters.AddWithValue("@email",f.Email);
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
