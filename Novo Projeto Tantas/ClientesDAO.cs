using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

using System.Net;

namespace Novo_Projeto_Tantas
{
    public class ClientesDAO
    {
        public int InserirLembrete(DateTime data, int codigo, string lembrete, List<string> ListaLembretes, Boolean CriaLista,DateTime Horario)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            int resultado = 0;
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return -1;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return -1;
            }
            // Primeiro verifia se registro ainda não existe na base

            MySqlTransaction tran = conn.BeginTransaction();
            try
            {
                if (CriaLista == true)
                {
                    int contador = ListaLembretes.Count, i = 0;
                    while (i < contador)
                    {
                        cmd = new MySqlCommand("INSERT INTO LEMBRETES (IdCliente,Lembrete,Alerta,FlagDesabilitarLembrete,horariocompromisso)values(@IdCliente, @Lembrete, @alerta,@Flag,@horario)", conn, tran);
                        cmd.Parameters.AddWithValue("@IdCliente", codigo);
                        cmd.Parameters.AddWithValue("@Alerta", Convert.ToDateTime(ListaLembretes[i]));
                        i++;
                        cmd.Parameters.AddWithValue("@Lembrete", ListaLembretes[i]);
                        i++;
                        DateTime HoraCompromisso = Convert.ToDateTime(ListaLembretes[i]);
                        cmd.Parameters.AddWithValue("@horario", HoraCompromisso);
                        cmd.Parameters.AddWithValue("@Flag", "1");
                        i++;
                        resultado = cmd.ExecuteNonQuery();
                    }

                    cmd = new MySqlCommand("INSERT INTO LEMBRETES (IdCliente,Lembrete,Alerta,FlagDesabilitarLembrete,horariocompromisso)values(@IdCliente, @Lembrete, @alerta,@Flag,@horario)", conn, tran);
                    cmd.Parameters.AddWithValue("@IdCliente", codigo);
                    cmd.Parameters.AddWithValue("@Lembrete", lembrete);
                    cmd.Parameters.AddWithValue("@alerta", data);
                    cmd.Parameters.AddWithValue("@Flag", "1");
                    cmd.Parameters.AddWithValue("@horario", Horario);


                    resultado = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO LEMBRETES (IdCliente,Lembrete,Alerta,FlagDesabilitarLembrete,horariocompromisso)values(@IdCliente, @Lembrete, @alerta,@Flag,@horario)", conn, tran);


                    cmd.Parameters.AddWithValue("@IdCliente", codigo);
                    cmd.Parameters.AddWithValue("@Lembrete", lembrete);
                    cmd.Parameters.AddWithValue("@alerta", data);
                    cmd.Parameters.AddWithValue("@Flag", "1");
                    cmd.Parameters.AddWithValue("@horario", Horario);
                    resultado = cmd.ExecuteNonQuery();
                }
                if (resultado < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {
                    if (resultado > 0)
                    {
                        tran.Commit();
                        MessageBox.Show("Lembrete cadastrado com sucesso !");
                    }
                    else
                    {
                        tran.Rollback();
                    }
                }
                return 0;
            }
            catch (Exception eConn)
            {
                tran.Rollback();

                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o usuario solicitado!");
                return -1;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public int AlterarLembrete(int idLembrete, string Lembrete, int flag,DateTime horario)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            int resultado = 0;
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return -1;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return -1;
            }
            // Primeiro verifia se registro ainda não existe na base

            MySqlTransaction tran = conn.BeginTransaction();
            try
            {
                if (flag == 1)
                {
                    cmd = new MySqlCommand("UPDATE LEMBRETES SET LEMBRETE = @lembrete, flagDesabilitarLembrete = @flag, horariocompromisso=@horario where idlembrete = " + idLembrete + "", conn);
                    cmd.Parameters.AddWithValue("@lembrete", Lembrete);
                    cmd.Parameters.AddWithValue("@idLembrete", idLembrete);
                    cmd.Parameters.AddWithValue("@Flag", flag);
                    cmd.Parameters.AddWithValue("@horario", horario);

                    resultado = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new MySqlCommand("UPDATE LEMBRETES SET  flagDesabilitarLembrete = @flag where idlembrete = " + idLembrete + "", conn);
                    cmd.Parameters.AddWithValue("@Flag", flag);         
                    resultado = cmd.ExecuteNonQuery();
                }
                if (resultado < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {
                    if (resultado > 0)
                    {
                        tran.Commit();
                        MessageBox.Show("Lembrete alterado com sucesso !");
                    }
                    else
                    {
                        tran.Rollback();
                    }
                }
                return 0;
            }
            catch (Exception eConn)
            {
                tran.Rollback();

                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o usuario solicitado!");
                return -1;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public ClientesVO inserirCliente(ClientesVO cli)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader LerCodCLI = null;
            cli.TipoOperacao = "Inserir";
            int resultado = 0, codCli;
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }
            // Primeiro verifia se registro ainda não existe na base
            ClientesVO novoCli = new ClientesVO();
            novoCli.Razao = cli.Razao;

            if (this.consultarCadastroCli(cli) != null)
            {
                if (alterarCliente(cli) == true) ;
                else return null;
            }
            else
            {
                MySqlTransaction tran = conn.BeginTransaction();
                try
                {
                    DateTime data = DateTime.Now;
                    // Se não existir então insere2
                    cmd = new MySqlCommand("INSERT INTO CLIENTES (RazaoSocial, Email, webSite, Contato, Telefone, Ativo)values " +
                                           "(@Razao, @Email, @webSite, @Contato, @Telefone, 1)", conn, tran);


                    cmd.Parameters.AddWithValue("@Razao", cli.Razao);
                    cmd.Parameters.AddWithValue("@Email", cli.Email);
                    cmd.Parameters.AddWithValue("@Website", cli.webSite);
                    cmd.Parameters.AddWithValue("@Contato", cli.Contato);
                    cmd.Parameters.AddWithValue("@Telefone", cli.Telefone);
             
                    resultado = cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT MAX(IdCliente) FROM Clientes", conn, tran);
                    LerCodCLI = cmd.ExecuteReader();
                    LerCodCLI.Read();
                    codCli = int.Parse(LerCodCLI[0].ToString());
                    LerCodCLI.Close();
                    cli.Clientealterado = codCli;
 
                    cmd = new MySqlCommand("INSERT INTO Enderecos(IdCliente, Endereco, Numero,Cidade)values (@IdCliente, @Endereco, @Numero, @Cidade)", conn, tran);
                    cmd.Parameters.AddWithValue("@IdCliente", codCli);
                    cmd.Parameters.AddWithValue("@Endereco", cli.Enderco);
                    cmd.Parameters.AddWithValue("@Numero", cli.Numero);
                    cmd.Parameters.AddWithValue("@Cidade", cli.Cidade);


                    resultado = cmd.ExecuteNonQuery();

                    if (cli.Historico != "")
                    {
                        cmd = new MySqlCommand("INSERT INTO historico(IdCliente, Historico, DataContato)values (@IdCliente, @Historico, @Data)", conn, tran);
                        cmd.Parameters.AddWithValue("@IdCliente", codCli);
                        cmd.Parameters.AddWithValue("@Historico", cli.Historico);
                        cmd.Parameters.AddWithValue("@Data", data);
                        resultado = cmd.ExecuteNonQuery();
                    }
                    if (cli.ListaGrid.Count > 0)
                    {
                        cmd = new MySqlCommand("INSERT INTO historico(IdCliente, Historico, DataContato)values (@IdCliente, @Historico, @Data)", conn, tran);
                        cmd.Parameters.AddWithValue("@IdCliente", codCli);
                        cmd.Parameters.AddWithValue("@Historico", cli.ListaGrid[1]);
                        cmd.Parameters.AddWithValue("@Data",Convert.ToDateTime(cli.ListaGrid[0]));
                        resultado = cmd.ExecuteNonQuery();
                    }
                    if (resultado < 0)
                    {
                        MessageBox.Show("Erro ao gravar os dados tente novamente!");
                        return null;
                    }
                    else
                    {
                        if (resultado > 0)
                        {
                            tran.Commit();
                            MessageBox.Show("Cadastro realizado com sucesso !");
                        }
                        else
                        {
                            tran.Rollback();
                        }
                    }
                 //   return cli;

                }
                catch (Exception eConn)
                {
                    tran.Rollback();

                    MessageBox.Show(eConn.Message);
                    MessageBox.Show("Não foi possível inserir o usuario solicitado!");
                    return null;
                }

                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            return cli;
        }
        public LinkedList<ClientesVO> pesquisarListaClientes(ClientesVO cliVO)
        {
            LinkedList<ClientesVO> listaCli = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }
            //Monta cláusula SQL
            if ((cliVO.Razao != ""))
            {
                sql = "SELECT C.idCliente,C.RazaoSocial,C.Contato,C.EMAIL,C.Telefone,C.Celular,C.Website,E.Endereco,E.Numero,E.Cidade,H.Historico,H.IdHistorico,H.DataContato,H.obs FROM clientes C " +
                      "LEFT JOIN enderecos E ON E.IdCliente = C.idCliente " +
                      "LEFT JOIN historico H ON H.IdCliente = C.IdCliente ";

                if (cliVO.controle != 1)
                {
                    sql += "WHERE C.RazaoSocial LIKE '%" + cliVO.Razao + "%' and Ativo = 1 ORDER BY H.DataContato DESC";
                }
                else
                {
                    sql += "WHERE C.RazaoSocial ='" + cliVO.Razao + "' and ativo = 1 ORDER BY H.DataContato DESC";
                }
                try
                {
                    // Executa a cosulta
                    cmd = new MySqlCommand(sql, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        cliVO = new ClientesVO();
                        cliVO.codigo = Convert.ToInt32(rdr["idCliente"]);
                        cliVO.IdHistorico = rdr["IdHistorico"].ToString();
                        cliVO.Razao = rdr["RazaoSocial"].ToString();
                        cliVO.Contato = rdr["Contato"].ToString();
                        cliVO.Email = rdr["EMAIL"].ToString();
                        cliVO.Telefone = rdr["Telefone"].ToString();
                        cliVO.Celular = rdr["Celular"].ToString();
                        cliVO.Historico = rdr["Historico"].ToString();
                        cliVO.Enderco = rdr["Endereco"].ToString();
                        cliVO.Numero = rdr["Numero"].ToString();
                        cliVO.Historico = rdr["Historico"].ToString();
                        cliVO.Cidade = rdr["Cidade"].ToString();
                        cliVO.data = rdr["DataContato"].ToString();
                        cliVO.webSite = rdr["Website"].ToString();

                        listaCli.AddLast(cliVO);

                    }
                    return listaCli;
                }

                catch (Exception exConn)
                {
                    MessageBox.Show(exConn.Message);
                    MessageBox.Show("Não foi possível encontrar o usuário!");
                    return null;
                }
            }
            //Carrega consulta default quando o sistema é carregado
            else
            {
                sql = "SELECT C.idCliente,C.RazaoSocial,C.Contato,C.EMAIL,C.Telefone,C.Celular,C.Website,E.Endereco,E.Numero,E.Cidade,H.Historico,H.DataContato,H.Obs FROM clientes C " +
                      "INNER JOIN enderecos E ON E.IdCliente = C.idCliente " +
                      "INNER JOIN historico H ON H.IdCliente = C.IdCliente " +
                      "where ativo = 1 ORDER BY C.RazaoSocial,H.DataContato";
            }
            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliVO = new ClientesVO();
                    cliVO.codigo = Convert.ToInt32(rdr["idCliente"]);
                    cliVO.Razao = rdr["RazaoSocial"].ToString();
                    cliVO.Contato = rdr["Contato"].ToString();
                    cliVO.Email = rdr["EMAIL"].ToString();
                    cliVO.Telefone = rdr["Telefone"].ToString();
                    cliVO.Celular = rdr["Celular"].ToString();
                    cliVO.Historico = rdr["Historico"].ToString();
                    cliVO.Enderco = rdr["Endereco"].ToString();
                    cliVO.Numero = rdr["Numero"].ToString();
                    cliVO.Historico = rdr["Historico"].ToString();
                    cliVO.Cidade = rdr["Cidade"].ToString();
                    cliVO.data = rdr["DataContato"].ToString();
                    cliVO.webSite = rdr["Website"].ToString();
                    listaCli.AddLast(cliVO);
                }
                return listaCli;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível encontrar o usuário!");
                return null;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public LinkedList<ClientesVO> pesquisarCliente(ClientesVO cli)
        {
            LinkedList<ClientesVO> listaCli = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;

            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }
            //Monta cláusula SQL
            sql = "SELECT C.RazaoSocial,C.IdCliente FROM CLIENTES C  WHERE ATIVO = 1 ";
            //Pesquisa por data    
            if (cli.ParametrodePesquisa == "2")
            {
                sql = "";
                sql = "SELECT C.RazaoSocial,C.IdCliente FROM CLIENTES C";
                string dataini = Convert.ToDateTime(cli.inicio).ToString("yyyy-MM-dd");
                string datafim = Convert.ToDateTime(cli.fim).ToString("yyyy-MM-dd");
               
                sql += " INNER JOIN  Historico H ON H.IdCliente = C.IdCliente " +
                       " WHERE CAST(FLOOR(CAST(h.DataContato AS DateTime)) AS datetime)  BETWEEN '" + dataini + "' AND '" + datafim + "' AND ATIVO = 1 ";
            }
            //Pesquisa pelo evento KeyUp
            else if (cli.BuscaTXT == 1)
            {
                sql = "SELECT C.RazaoSocial,C.IdCliente FROM CLIENTES C ";
                sql += "WHERE C.RazaoSocial like '" + cli.Razao + "%' AND ATIVO = 1 ";
            }
            //Pesquisa por nome pelo clique do botão buscar
            else if (cli.BuscaTXT != 1 && cli.Razao != null)
            {
                sql = "SELECT C.RazaoSocial,C.IdCliente FROM CLIENTES C ";
                sql += "WHERE C.RazaoSocial ='" + cli.Razao + "' AND ATIVO = 1 ";
            }
            sql += "ORDER BY C.RazaoSocial";
            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.codigo = Convert.ToInt32(rdr["idCliente"]);
                    cli.Razao = rdr["RazaoSocial"].ToString();

                    listaCli.AddLast(cli);

                }
                return listaCli;
            }

            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível encontrar o usuário!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public ClientesVO consultarCadastroCli(ClientesVO cli)
        {
            MySqlConnection conn = null;
            string sql;
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
                sql = "SELECT idCliente,RazaoSocial FROM Clientes WHERE RazaoSocial = '" + cli.Razao + "' and ativo = 1";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }

            try
            {
                DataTable consultacli = new DataTable();
                MySqlDataAdapter da_consulta = new MySqlDataAdapter(sql, conn);
                da_consulta.Fill(consultacli);
                conn.Close();

                if (consultacli.Rows.Count == 0)
                {
                    cli = null;
                }
                else cli.codigo = Convert.ToInt32(consultacli.Rows[0]["idCliente"]);
                return cli;
            }


            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public string pesquisaUltimoCliente()
        {
            MySqlConnection conn = null;
            string sql;
            ClientesVO  cli = new ClientesVO();
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
                sql = "SELECT RAZAOSOCIAL FROM CLIENTES WHERE IDCLIENTE IN (SELECT MAX(IDCLIENTE) FROM CLIENTES)";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }

            try
            {
                DataTable consultacli = new DataTable();
                MySqlDataAdapter da_consulta = new MySqlDataAdapter(sql, conn);
                da_consulta.Fill(consultacli);
                conn.Close();

                if (consultacli.Rows.Count == 0)
                {
                    cli.Razao = null;
                }
                else  cli.Razao = consultacli.Rows[0]["RazaoSocial"].ToString();
                return cli.Razao;
            }


            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public Boolean alterarCliente(ClientesVO cli)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            cli.TipoOperacao = "Alterar";
            int resultado = 0, codigo = cli.codigo;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return false;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return false;
            }
            MySqlTransaction tran = conn.BeginTransaction();

            try
            {
                //Altera dados da tabela de Cliente
                cmd = new MySqlCommand("UPDATE  Clientes Set  Email=@email, Website=@website, Contato=@contato, Celular=@celular, Telefone=@telefone WHERE IdCliente = " + codigo + "", conn, tran);
                cmd.Parameters.AddWithValue("@email", cli.Email);
                cmd.Parameters.AddWithValue("@website", cli.webSite);
                cmd.Parameters.AddWithValue("@contato", cli.Contato);
                cmd.Parameters.AddWithValue("@celular", cli.Celular);
                cmd.Parameters.AddWithValue("@telefone", cli.Telefone);
             
                cmd.ExecuteNonQuery();

                //Altera dados da tabela Endereco
                cmd = new MySqlCommand("UPDATE  Enderecos Set Endereco=@endereco, numero=@numero, Cidade=@cidade WHERE IdCliente = " + codigo + "", conn, tran);
                cmd.Parameters.AddWithValue("@endereco", cli.Enderco);
                cmd.Parameters.AddWithValue("@numero", cli.Numero);
                cmd.Parameters.AddWithValue("@cidade", cli.Cidade);

                cmd.ExecuteNonQuery();

                if (cli.Historico != "")
                {
                    cmd = new MySqlCommand("Insert into Historico(IdCliente,Historico,DataContato)values(@IdCliente,@historico,@dataAtual)", conn, tran);
                    cmd.Parameters.AddWithValue("@IdCliente", cli.codigo);
                    cmd.Parameters.AddWithValue("@historico", cli.Historico);
                    cmd.Parameters.AddWithValue("@dataAtual", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                if (cli.ListaGrid.Count != 0)
                {
                    string idHistorico = "";
                    DataTable consulta = new DataTable();
                    if (cli.ListaGrid.Count < 3) idHistorico = "0";
                    else idHistorico = cli.ListaGrid[2]; ;

                                      
                    string consultaHistorico = "Select IdHistorico,Historico from historico where idHistorico = " + idHistorico + "";
                    MySqlDataAdapter da_consultaHistorico = new MySqlDataAdapter(consultaHistorico, conn);
                    da_consultaHistorico.Fill(consulta);
                    if (consulta.Rows.Count != 0)
                    {
                        if (cli.ListaGrid[1] != "")
                        {
                            cmd = new MySqlCommand("UPDATE Historico Set Historico=@historico,  DataContato = @dataAtual WHERE IdCliente = " + codigo + " and idhistorico = " + cli.ListaGrid[2] + "", conn, tran);
                            cmd.Parameters.AddWithValue("@historico", cli.ListaGrid[1]);
                            cmd.Parameters.AddWithValue("@dataAtual", Convert.ToDateTime(cli.ListaGrid[0]));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        cmd = new MySqlCommand("Insert into Historico(IdCliente,Historico,DataContato)values(@IdCliente,@historico,@dataAtual)", conn, tran);
                        cmd.Parameters.AddWithValue("@IdCliente", cli.codigo);
                        cmd.Parameters.AddWithValue("@historico", cli.ListaGrid[1]);
                        cmd.Parameters.AddWithValue("@dataAtual", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (resultado < 0)
                {
                    tran.Rollback();
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro do cliente!");
                    return false;
                }
                else tran.Commit();
                return true;
            }
            catch (Exception eConn)
            {
                tran.Rollback();
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o usuario solicitado!");
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public LinkedList<ClientesVO> pesquisarCompromisso(ClientesVO cli)
        {
            LinkedList<ClientesVO> ListaCompromisso = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;

            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }
            //if (cli.ControleAvisos == "1" && cli.BuscaCompromissos != "")
            //{
            //    string data = Convert.ToDateTime(cli.DataCompromisso).ToString("yyyy-MM-dd");

            //    sql = "SELECT l.IdLembrete,l.Alerta,l.Lembrete,l.FlagDesabilitarLembrete FROM Lembretes l" +
            //            "WHERE l.idCliente = " + cli.codigo + " AND l.Alerta = '" + data + "' and l.flagdesabilitarlembrete = 1 ";
            //}
            //Monta cláusula SQL
            if (cli.BuscaCompromissos != "")
            {
                string data = Convert.ToDateTime(cli.DataCompromisso).ToString("yyyy-MM-dd");
                sql = "SELECT l.IdLembrete,l.Alerta,l.Lembrete,l.FlagDesabilitarLembrete FROM Lembretes l" +
                      " inner join clientes c on c.idcliente = l.idcliente "+
                       "WHERE l.idCliente = " + cli.codigo + " AND l.Alerta = '" + data + "' and l.flagdesabilitarlembrete = 1 and c.ativo = 1";
            }
            else
            {
                sql = "SELECT l.IdLembrete,l.Alerta,l.Lembrete,l.FlagDesabilitarLembrete  FROM Lembretes l" +
                      " inner join clientes c on c.idcliente = l.idcliente "+
                      " WHERE l.idCliente = " + cli.codigo + " and l.flagdesabilitarlembrete = 1 and c.ativo = 1";
            }
            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.IdLembrete = Convert.ToInt32(rdr["IdLembrete"]);
                    cli.lembrete = rdr["Lembrete"].ToString();
                    cli.NovoContato = Convert.ToDateTime(rdr["Alerta"]);
                    cli.Flag = Convert.ToInt32(rdr["FlagDesabilitarLembrete"]);

                    ListaCompromisso.AddLast(cli);

                }
                return ListaCompromisso;
            }

            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum  registro encontrado!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public LinkedList<ClientesVO> pesquisarCompromissoPessoal(ClientesVO cli)
        {
            LinkedList<ClientesVO> ListaCompromissoPessoal = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }

            //Monta cláusula SQL
            if (cli.BuscaCompromissos != "")
            {
                string data = Convert.ToDateTime(cli.DataCompromisso).ToString("yyyy-MM-dd");
                sql = "SELECT IdLembrete,Alerta,Lembrete,FlagDesabilitarLembrete FROM Lembretes WHERE idCliente = 0 AND Alerta = '" + data + "'and flagdesabilitarlembrete = 1 ";
            }
            else
            {
                sql = "SELECT IdLembrete,Alerta,Lembrete,FlagDesabilitarLembrete  FROM Lembretes WHERE idCliente = 0 and FlagDesabilitarLembrete = 1";
            }
            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.IdLembrete = Convert.ToInt32(rdr["IdLembrete"]);
                    cli.lembrete = rdr["Lembrete"].ToString();
                    cli.NovoContato = Convert.ToDateTime(rdr["Alerta"]);
                    cli.Flag = Convert.ToInt32(rdr["FlagDesabilitarLembrete"]);

                    ListaCompromissoPessoal.AddLast(cli);

                }
                return ListaCompromissoPessoal;
            }

            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum  registro encontrado!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public LinkedList<ClientesVO> pesquisarCompromissoExc(ClientesVO cli)
        {
            LinkedList<ClientesVO> ListaCompromissoExc = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;

            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }

            //Monta cláusula SQL
            string data = Convert.ToDateTime(cli.DataCompromisso).ToString("yyyy-MM-dd");
            sql = "SELECT IdLembrete,Alerta,Lembrete FROM Lembretes WHERE idCliente = " + cli.codigo + " AND Alerta = '" + data + "'";

            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.IdLembrete = Convert.ToInt32(rdr["IdLembrete"]);
                    cli.lembrete = rdr["Lembrete"].ToString();
                    cli.NovoContato = Convert.ToDateTime(rdr["Alerta"]);

                    ListaCompromissoExc.AddLast(cli);

                }
                return ListaCompromissoExc;
            }

            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum  registro encontrado!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public LinkedList<ClientesVO> pesquisarHistExc(ClientesVO cli)
        {
            LinkedList<ClientesVO> ListaHistoricoExc = new LinkedList<ClientesVO>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;

            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }

            //Monta cláusula SQL
            sql = "SELECT H.IdHistorico,H.IdCliente,C.RazaoSocial,H.Historico,H.DataContato FROM Historico H " +
                   "Inner Join Clientes C on C.IdCliente = H.IdCliente " +
                   "WHERE H.idCliente = " + cli.codigo + " ";

            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.IdHistorico = rdr["IdHistorico"].ToString();
                    cli.Razao = rdr["RazaoSocial"].ToString();
                    cli.Historico = rdr["Historico"].ToString();
                    cli.data = rdr["DataContato"].ToString();

                    ListaHistoricoExc.AddLast(cli);

                }
                return ListaHistoricoExc;
            }

            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum  registro encontrado!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public ClientesVO pesquisaRazao(int Codigo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            ClientesVO cli = null;
            string sql;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }

            //Monta cláusula SQL          
            sql = "SELECT RazaoSocial from clientes WHERE idCliente = " + Codigo + "";
            try
            {
                // Executa a cosulta
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new ClientesVO();
                    cli.Razao = rdr["RazaoSocial"].ToString();
                }
                return cli;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum  registro encontrado!");
                return null;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public Boolean ExcluirLembrete(int IdLembrete)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            
            int resultado = 0;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return false;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return false;
            }

            //Monta cláusula SQL          
            cmd = new MySqlCommand("DELETE FROM LEMBRETES WHERE IdLembrete = " + IdLembrete + "", conn);
            resultado = cmd.ExecuteNonQuery();
            try
            {
                if (resultado > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível remover o cadastro solicitado!");
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }
        public Boolean ExcluirVariosLembrete(string IdLembrete)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            int resultado = 0;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return false;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return false;
            }

            //Monta cláusula SQL          
            cmd = new MySqlCommand("DELETE FROM LEMBRETES WHERE IdLembrete in (" + IdLembrete + ")", conn);
            resultado = cmd.ExecuteNonQuery();
            try
            {
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível remover o cadastro solicitado!");
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }        

        public int DesativarCliente(int codigo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            ClientesVO cli= new ClientesVO();

            int resultado = 0;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return -1;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return -1;
            }

            //Monta cláusula SQL          
            cmd = new MySqlCommand("Update  Clientes set  Ativo = 0  WHERE IdCliente = " + codigo + "", conn);
            resultado = cmd.ExecuteNonQuery();
            try
            {
                if (resultado > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso");
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível remover o cadastro solicitado!");
                return -1;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }
        public string ExcluirHistoricoIndividual(string IdHist)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            string[] historico = IdHist.Split(','); 
            int resultado = 0;

            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }

            //Monta cláusula SQL
            foreach (var HST in historico)
            {
                cmd = new MySqlCommand("DELETE FROM Historico WHERE IdHistorico = " + HST + "", conn);
                resultado = cmd.ExecuteNonQuery();
            }
            try
            {
                if (resultado >= 0)
                {
                    MessageBox.Show("Exclusão realizada com sucesso");
                    return "OK";
                }
                else
                {
                    return null;
                }
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível excluir o registro solicitado!");
                return null;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }
    }  
}

