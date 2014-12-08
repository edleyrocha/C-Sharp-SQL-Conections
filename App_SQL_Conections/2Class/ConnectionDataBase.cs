using System;
using System.Collections.Generic;
using System.Text;


#region ---(Using Adicionais)
/// <summary>
/// SQL Using
/// </summary>
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
///
#endregion

namespace App_SQL_Conections
{
    class ConnectionDataBase
    {

       #region ---(..........Metodo Contrutor..........)---
     
        /// <summary>
        /// Metodo Contrutor Conexao SQL Base
        /// </summary>
        public ConnectionDataBase()
        {

        }
        ///
       #endregion

       #region ---(..........MSQL_StringBuilde..........)---

       private static SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();
      
        /// <summary>
       /// Formador de Strings SQL --- GET Somente String e SET somente a String
       /// </summary>
       public static string SQLServer_1_StringBuilder ///1
       {
           get { return stringBuilderSQL.ConnectionString; }
           set { stringBuilderSQL.ConnectionString = value; }
       }

       /// <summary>
       ///  STRING - Endereço Servidor Banco de Dados
       ///  O nome ou endereço de rede de instância de SQL Server a qual se conectar.
       ///  O número da porta pode ser especificado após o nome do servidor: (server=tcp:servername, portnumber)
       /// </summary>
       public static string SQLServer_2_EnderecoServidor ///2
       {
           private get { return stringBuilderSQL.DataSource; }
           set { stringBuilderSQL.DataSource = value; }
       }

       /// <summary>
       ///  STRING - Nome Banco de Dados
       ///  O nome de base de dados pode ser caracteres 128 ou menos.
       /// </summary>
       public static string SQLServer_3_NomeBancoDeDados ///3
       {
           private get { return stringBuilderSQL.InitialCatalog; }
           set { stringBuilderSQL.InitialCatalog = value; }
       }

       /// <summary>
       ///  STRING - Tipo de Login Conexao Banco de Dados   
       ///  (Segurança integrada - ou - Trusted_Connection)
       ///  Quando false, a identificação de usuário e a senha são especificadas na conexão.    (false --> SQL Server)
       ///  Quando true, as credenciais atual da conta do Windows é usado para autenticação.    (true  --> Windows)
       /// </summary>
       public static bool SQLServer_4_TipoSeguranca ///4
       {
           private get { return stringBuilderSQL.IntegratedSecurity; }
           set { stringBuilderSQL.IntegratedSecurity = value; }
       }

       /// <summary>
       ///  STRING - Usuario Banco de Dados -
       ///  A conta de logon de SQL Server .
       ///  O identificação de usuário deve ser 128 caracteres ou menos.
       /// </summary>
       public static string SQLServer_5_LoginUsuario   ///5
       {
           private get { return stringBuilderSQL.UserID; }
           set { stringBuilderSQL.UserID = value; }
       }

       /// <summary>
       ///  STRING - Senha Banco de Dados
       ///  A senha da conta de abertura de SQL Server. 
       ///  A senha deve ser 128 caracteres ou menos.
       /// </summary>
       public static string SQLServer_6_LoginSenha ///6
       {
           private get { return stringBuilderSQL.Password; }
           set { stringBuilderSQL.Password = value; }
       }

       /// <summary>
       ///  STRING - Senha Banco de Dados
       ///  A senha da conta de abertura de SQL Server. 
       ///  A senha deve ser 128 caracteres ou menos.
       /// </summary>
       public static int SQLServer_7_TimeOutConexao ///7
       {
           private get { return stringBuilderSQL.ConnectTimeout; }
           set { stringBuilderSQL.ConnectTimeout = value; }
       }
        ///
        #endregion 

       #region ---(..........SQL_Connection..........)---

       private static SqlConnection sqlServer_Connection = new SqlConnection();
       /// <summary>
       /// SqlConnection - SQL Conexao para Banco de Dados
       /// </summary>
       private static SqlConnection SQLServer_8_Connection
       {
            get { return sqlServer_Connection; }
            set { sqlServer_Connection = value; }
       }
        ///
        #endregion

       #region ---(..........Lista de Funçoes..........)---

       /// <summary>
       /// Funcao para Abrir Fechar e Outros
       /// </summary>
       /// <param name="Open_Close_Status"></param>
       /// <returns></returns>
       public static SqlConnection SQLServer_FU_Connection(String Open_Close_OUTROS)
       {
           switch (Open_Close_OUTROS)
           {
            case ("Open"):
                {
                    SQLServer_8_Connection.ConnectionString = SQLServer_1_StringBuilder;
                    SQLServer_8_Connection.Open();
                    return SQLServer_8_Connection;
                }
            case ("Close"):
                {
                    SQLServer_8_Connection.Close();
                    SQLServer_8_Connection.ConnectionString = String.Empty;
                    return SQLServer_8_Connection;
                }
            default :
                {
                    return SQLServer_8_Connection;
                }
           }
       }
       ///
       #endregion

   }  /*FIM CLASS - ConnectionDataBase*/
}     /*FIM NAMESPACE - App_SQL_Conections*/
