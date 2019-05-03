using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Percistence
{
    public class EmpresaDAL : Conection
    {
        public void Create(Empresa e)
        {
            try
            {
                OpenConection();
                Cmd = new SqlCommand("Insert into empresas (uf, nomeFantasia, cnpj, removido) values (@v1,@v2,@v3, 0);", Con);

                Cmd.Parameters.AddWithValue("@v1", e.uf);
                Cmd.Parameters.AddWithValue("@v2", e.nomeFantasia);
                Cmd.Parameters.AddWithValue("@v3", e.cnpj);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar empresa..." + ex.Message);
            }
            finally
            {
                CloseConection();
            }
        }

        public void Update(Empresa e)
        {
            try
            {
                OpenConection();
                Cmd = new SqlCommand("Update empresas set uf = @v1, nomeFantasia = @v2, cnpj = @v3 where id = @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", e.uf);
                Cmd.Parameters.AddWithValue("@v2", e.nomeFantasia);
                Cmd.Parameters.AddWithValue("@v3", e.cnpj);
                Cmd.Parameters.AddWithValue("@v4", e.id);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar empresa..." + ex.Message);
            }
            finally
            {
                CloseConection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                OpenConection();
                Cmd = new SqlCommand("Delete from empresas where id = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", id);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception ("Erro ao excluir empresa..." + ex.Message);
            }
            finally
            {
                CloseConection();
            }
        }

        public Empresa SelectById(int id)
        {
            try
            {
                OpenConection();
                Cmd = new SqlCommand("Select uf, nomeFantasia, cnpj, removido from empresas where id = @v1 and removido = 0" , Con);
                Cmd.Parameters.AddWithValue("@v1", id);
                Cmd.ExecuteNonQuery();

                Empresa e = null;

                if (Dr.Read())
                {
                    e = new Empresa();
                    e.id = Convert.ToInt32(Dr["id"]);
                    e.uf = Convert.ToString(Dr["uf"]);
                    e.nomeFantasia = Convert.ToString(Dr["nomeFantasia"]);
                    e.removido = Convert.ToBoolean(Dr["removido"]);
                }

                return e;
            }
            catch (Exception ex)
            {

                throw new Exception ("Erro ao selecionar empresa..." + ex.Message);
            }
            finally
            {
                CloseConection();
            }            
        }

        public List<Empresa> SelectAll()
        {
            try
            {
                OpenConection();
                Cmd = new SqlCommand("Select uf, nomeFantasia, cnpj, removido from empresas where removido = 0", Con);
                Dr = Cmd.ExecuteReader();

                List<Empresa> empresas = new List<Empresa>();

                while(Dr.Read())
                {
                    Empresa e = new Empresa();
                    e.id = Convert.ToInt32(Dr["id"]);
                    e.uf = Convert.ToString(Dr["uf"]);
                    e.nomeFantasia = Convert.ToString(Dr["nomeFantasia"]);
                    e.removido = Convert.ToBoolean(Dr["removido"]);

                    empresas.Add(e);
                }

                return empresas;
            }
            catch (Exception ex)
            {

                throw new Exception ("Erro ao listar empresas..." + ex.Message);
            }
            finally
            {
                CloseConection();
            }
        }
    }
}
