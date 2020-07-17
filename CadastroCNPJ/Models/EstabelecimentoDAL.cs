using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCNPJ.Models
{
    public class EstabelecimentoDAL : IEstabelecimento
    {
        private readonly FitcardTesteContext _context;
        public EstabelecimentoDAL(FitcardTesteContext fitcardTesteContext)
        {
            _context = fitcardTesteContext;
        }
        public void AddEstabelecimento(Estabelecimento estabelecimento)
        {
            _context.Estabelecimento.Add(estabelecimento);
            //using (SqlConnection con = new SqlConnection(_context.))
            //{
            //    string comandoSQL = "Insert into Estabelecimento (RazaoSocial,NomeFantasia,Telefone,Email) Values(@RazaoSocial, @NomeFantasia, @Telefone, @Email)";
            //    SqlCommand cmd = new SqlCommand(comandoSQL, con);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@Razaosocial", estabelecimento.Razaosocial);
            //    cmd.Parameters.AddWithValue("@NomeFantasia", estabelecimento.NomeFantasia);
            //    cmd.Parameters.AddWithValue("@Telefone", estabelecimento.Telefone);
            //    cmd.Parameters.AddWithValue("@Email", estabelecimento.Email);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
        }

        public void DeleteEstabelecimento(int? id)
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                string comandoSQL = "Delete from Estabelecimento where IdEstabelecimento = @IdEstabelecimento";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEstabelecimento", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Estabelecimento> GetAllEstabelecimento()
        {
            
            List<Estabelecimento> lstEstab = new List<Estabelecimento>();
            using (SqlConnection con = new SqlConnection(""))
            {
                SqlCommand cmd = new SqlCommand("SELECT IdEstabelecimento, RazaoSocial, IdCidade from Estabelecimento", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Estabelecimento estabelecimento = new Estabelecimento();
                    //estabelecimento.IdEstabelecimento = rdr["IdEstabelecimento"].ToString();
                    estabelecimento.Razaosocial = rdr["RazaoSocial"].ToString();
                    estabelecimento.IdCidade = Convert.ToInt32(rdr["Cidade"]);
                    lstEstab.Add(estabelecimento);
                }
                con.Close();
            }
            return lstEstab;
        }

        public Estabelecimento GetEstabelecimento(int? id)
        {
            Estabelecimento estabelecimento = new Estabelecimento();
            using (SqlConnection con = new SqlConnection(""))
            {
                string sqlQuery = "SELECT * FROM Estabelecimento WHERE IdEstabelecimento= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   // estabelecimento.IdEstabelecimento = Convert.ToInt32(rdr["IdEstabelecimento"]);
                    estabelecimento.Razaosocial = rdr["Razaosocial"].ToString();
                    estabelecimento.NomeFantasia = rdr["NomeFantasia"].ToString();
                    estabelecimento.Telefone = rdr["Telefone"].ToString();
                    estabelecimento.Email = rdr["Email"].ToString();
                }
            }
            return estabelecimento;
        }

        public void UpdateEstabelecimento(Estabelecimento estabelecimento)
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                string comandoSQL = "Update Funcionarios set Razaosocial = @Razaosocial, NomeFantasia = @NomeFantasia, Telefone = @Telefone, Email = @Email where IdEstabelecimento = @IdEstabelecimento";
                 SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEstabelecimento", estabelecimento.IdEstabelecimento);
                cmd.Parameters.AddWithValue("@Razaosocial", estabelecimento.Razaosocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", estabelecimento.NomeFantasia);
                cmd.Parameters.AddWithValue("@Telefone", estabelecimento.Telefone);
                cmd.Parameters.AddWithValue("@Email", estabelecimento.Email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
