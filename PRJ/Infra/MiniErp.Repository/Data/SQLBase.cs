﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using MiniErp.Service.BaseApp;

namespace MiniErp.Repository.Data
{
    public class SQLBase
    {
        string cnStringDes = Ambiente.GetCNStringDes();
        string cnStringPrd = Ambiente.GetCNStringPrd();
        string ambiente = Ambiente.GetModoAmbiente();
        bool histAtivo = Ambiente.GetHistoricoAtivo();
        bool erroAtivo = Ambiente.GetErroAtivo();
        bool logAtivo = Ambiente.GetLogAtivo();

        SqlConnection cn;
        SqlCommand cmd;

        /// <summary>
        /// conecta Banco de dados
        /// </summary>
        public void Conectar()
        {
            string cnString = string.Empty;

            if (ambiente == "desenvolvimento")
            {
                cnString = cnStringDes;
            }
            else
            {
                cnString = cnStringPrd;
            }

            cn = new SqlConnection(cnString);
            cn.Open();
        }

        /// <summary>
        /// Desconecta banco de dados se conectado
        /// </summary>
        public void Desconectar()
        {

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

        }

        /// <summary>
        /// Contagem de linhas
        /// </summary>
        /// <param name="comando">Comando SQl a ser executado</param>
        /// <returns>Quantidade de linhas</returns>
        public int ContarLinhas(string comando)
        {

            int retorno = 0;

            SqlCommand cmd = new SqlCommand(comando, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    retorno++;
                }
            }

            dr.Dispose();

            return retorno;

        }

        /// <summary>
        /// Metodo de Busca Generico, Devolve uma entidade do tipo
        /// passado na classe carregada com os dados.
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public List<T> Busca<T>(string comando)
        {

            Conectar();

            // lista para devolver os dados
            List<T> lista = new List<T>();

            // descobrindo o tipo da lista
            Type t = typeof(T);

            // consultando os dados
            SqlCommand cmd = new SqlCommand(comando, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // instanciando o objeto que ira transportar os dados 
                    // para a lista
                    object o = Activator.CreateInstance(t);

                    // descobre as propriedades do objeto.
                    PropertyInfo[] arrP = o.GetType().GetProperties();

                    // carrega o objeto
                    foreach (PropertyInfo p in arrP)
                    {
                        if (dr[p.Name] != System.DBNull.Value)
                        {
                            o.GetType().GetProperty(p.Name).SetValue(o, Convert.ChangeType(dr[p.Name], p.PropertyType, System.Globalization.CultureInfo.CurrentCulture), null);
                        }
                    }

                    // adiciona o objeto a lista
                    lista.Add((T)o);
                }
            }

            Desconectar();

            // devolve a lista carregada
            return lista;
        }

        /// <summary>
        /// Busca dados conforme comando informado
        /// </summary>
        /// <param name="comando">Comando a ser executado</param>
        /// <returns>DataReader com os dados</returns>
        public SqlDataReader GeraReader(string comando)
        {

            SqlCommand cmd = new SqlCommand(comando, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        /// <summary>
        /// Busca dados conforme comando informado
        /// </summary>
        /// <param name="comando">Comando a ser executado</param>
        /// <returns>DataReader com os dados</returns>
        public SqlDataReader GeraReaderProcedure(string comando, List<SqlParameter> paramList)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            foreach (var parametro in paramList)
            {
                cmd.Parameters.Add(parametro);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        /// <summary>
        /// Gera e devolve data reader
        /// </summary>
        /// <param name="comando">Comando a ser executado</param>
        /// <param name="tipo">tipo de comando a ser executado</param>
        /// <param name="paramList">Lista de Parametros</param>
        /// <returns></returns>
        public SqlDataReader GeraReader(string comando, CommandType tipo, List<SqlParameter> paramList)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.CommandType = tipo;
            cmd.Connection = cn;

            foreach (var parametro in paramList)
            {
                cmd.Parameters.Add(parametro);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        /// <summary>
        /// Executa um comando sem retorno de informacoes
        /// </summary>
        /// <returns>True caso sucesso.</returns>
        public string ExecutaProcedure(string procedure, List<SqlParameter> paramList, int tempo = 20)
        {
            string retorno = "";
            Int32 contaLinhasAfetadas = 0;

            try
            {

                Conectar();

                cmd = new SqlCommand(procedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = tempo;

                foreach (var parametro in paramList)
                {
                    cmd.Parameters.Add(parametro);
                }

                retorno = "sucesso";

                contaLinhasAfetadas = cmd.ExecuteNonQuery();

                Desconectar();

            }
            catch (Exception ex)
            {
                retorno = $"Erro:{ex.Message.ToString()}";
            }
            finally
            {
                cmd.Dispose();
            }

            return retorno;

        }

        /// <summary>
        /// Executa comando sem retorno
        /// </summary>
        /// <param name="comando">Comando ou procedure a ser executados</param>
        /// <param name="tipoComando">Tipo de comando a ser executado</param>
        /// <param name="paramList">Lista de parametros</param>
        /// <param name="msgLog">opcional de msg para log</param>
        /// <param name="tempo">Tempo para execução do comando default 20</param>
        /// <returns></returns>
        public string ExecutaComandoSemRetorno(string comando, CommandType tipoComando, List<SqlParameter> paramList, int tempo = 20)
        {
            string retorno = "";
            Int32 contaLinhasAfetadas = 0;

            try
            {
                Conectar();

                cmd = new SqlCommand(comando, cn);
                cmd.CommandType = tipoComando;
                cmd.CommandTimeout = tempo;

                foreach (var parametro in paramList)
                {
                    cmd.Parameters.Add(parametro);
                }

                retorno = "sucesso";

                contaLinhasAfetadas = cmd.ExecuteNonQuery();

                Desconectar();

            }
            catch (Exception ex)
            {
                retorno = $"Erro:{ex.Message.ToString()}";
            }
            finally
            {
                cmd.Dispose();
            }

            return retorno;

        }

        /// <summary>
        /// Método que retorna o resultado da consulta sql em um dataset.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet GeraDataSet(string comando)
        {
            //Instância o sqlcommand com a query sql que será executada e a conexão.
            SqlCommand cmd = new SqlCommand(comando, cn);

            //Instância o sqldataAdapter.
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //Instância o dataSet de retorno.
            DataSet dataSet = new DataSet();

            //Atualiza o dataSet
            adapter.Fill(dataSet);

            //Retorna o dataSet com o resultado da query sql.
            return dataSet;
        }
    }
}