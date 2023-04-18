using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    internal class ClsDatabase
    {

        public static SqlConnection cn = new SqlConnection(Properties.Settings.Default.Ruta);
       public static DataSet Ds;

        public static DataTable mostar()
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Agenda"),cn);
            Ds = new DataSet();
            try{
               cn.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(Ds, "Agenda");
                cn.Close();
            }
            catch(Exception ex) {
                throw;
                    }
            finally { cn.Close(); }
            return Ds.Tables["Agenda"];

        }

        public static void insertar(persona p)
        {
            SqlCommand cmd = new SqlCommand(string.Format
                ("insert into Agenda(Nombre, Apellido, Fecha_Nacimiento,Direccion, Genero, Estado_Civil, Movil, Telefono, Correo_Electronico)values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}', '{8}')", p.Nombre, p.Apellido, p.Fecha_nacimiento1, p.Direccion, p.Genero,p.Estado_civil,p.Movil,p.Telefono,p.Correo_electronico), cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrado");
                cn.Close(); 
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
           

        }

        public static void Eliminar(persona p)
        {
            SqlCommand cmd = new SqlCommand(string.Format
                ("Delete from Agenda where Id='{0}'", p.Id), cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminado");
                cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }


        }

        public static void Modificar(persona p)
        {
            SqlCommand cmd = new SqlCommand(string.Format
                ("Update Agenda set Nombre='{0}',Apellido='{1}',Fecha_Nacimiento='{2}',Direccion='{3}',Genero='{4}',Estado_Civil='{5}',Movil='{6}',Telefono='{7}', Correo_Electronico='{8}' where ID='{9}'", p.Nombre, p.Apellido, p.Fecha_nacimiento1, p.Direccion, p.Genero, p.Estado_civil, p.Movil,p.Telefono,p.Correo_electronico ,p.Id), cn);
            try
            {
                cn.Open();   
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificado");
                cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }


        }

        public static DataTable Buscar(persona p)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Agenda where Nombre LIKE '%{0}%'", p.Nombre), cn);
            try
            {
                cn.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                DA.Fill(Ds, "Agenda");
                cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
            return Ds.Tables["Agenda"]; 


        }
    }
}
