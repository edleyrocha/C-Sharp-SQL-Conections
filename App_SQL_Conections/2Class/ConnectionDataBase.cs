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
       /// <summary>
       /// Formador de Strings SQL --- GET Somente String e SET somente a String
       /// </summary>

       private SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();
       private string SQLServer_StringBuilder ///1
       {
           get { return stringBuilderSQL.ConnectionString.ToString(); }
           set { stringBuilderSQL.ConnectionString = value; }
       }

       /// <summary>
       ///  STRING - Endereço Servidor Banco de Dados
       ///  O nome ou endereço de rede de instância de SQL Server a qual se conectar.
       ///  O número da porta pode ser especificado após o nome do servidor: (server=tcp:servername, portnumber)
       /// </summary>
       public string SQLServer_Endereco_Servidor ///2
       {
           private get { return stringBuilderSQL.DataSource; }
           set { stringBuilderSQL.DataSource = value; }
       }

       /// <summary>
       ///  STRING - Nome Banco de Dados
       ///  O nome de base de dados pode ser caracteres 128 ou menos.
       /// </summary>
       public string SQLServer_Nome_BancoDeDados ///3
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

       public bool SQLServer_Tipo_Seguranca ///4
       {
           private get { return stringBuilderSQL.IntegratedSecurity; }
           set { stringBuilderSQL.IntegratedSecurity = value; }
       }

       /// <summary>
       ///  STRING - Usuario Banco de Dados -
       ///  A conta de logon de SQL Server .
       ///  O identificação de usuário deve ser 128 caracteres ou menos.
       /// </summary>
       public string SQLServer_Usuario_Login   ///5
       {
           private get { return stringBuilderSQL.UserID; }
           set { stringBuilderSQL.UserID = value; }
       }

       /// <summary>
       ///  STRING - Senha Banco de Dados
       ///  A senha da conta de abertura de SQL Server. 
       ///  A senha deve ser 128 caracteres ou menos.
       /// </summary>
       public string SQLServer_Senha_Login ///6
       {
           private get { return stringBuilderSQL.Password; }
           set { stringBuilderSQL.Password = value; }
       }

       /// <summary>
       ///  STRING - Senha Banco de Dados
       ///  A senha da conta de abertura de SQL Server. 
       ///  A senha deve ser 128 caracteres ou menos.
       /// </summary>
       public int SQLServer_TimeOutConexao ///7
       {
           private get { return stringBuilderSQL.ConnectTimeout; }
           set { stringBuilderSQL.ConnectTimeout = value; }
       }
        ///
        #endregion 

       #region ---(..........SQL_Connection..........)---
       /// <summary>
       /// STRING - SQL Conexao para Banco de Dados
       /// </summary>
       private SqlConnection sqlServer_Connection = new SqlConnection();
       private SqlConnection SQLServer_Connection
       {
            get { return sqlServer_Connection; }
            set { sqlServer_Connection = value; }
       }
        ///
        #endregion

       #region ---(..........Lista de Funçoes..........)---

       /// <summary>
        /// Retorna Conexao SQL Server com Strings pronto para conectar
        /// </summary>
        /// <returns></returns>
       public SqlConnection SQLServer_GetSqlConnectionSQLServer( Boolean GetTrue_CleanFalse)
       {
           switch (GetTrue_CleanFalse)
           {
               case (true):
                   {
                       SQLServer_Connection.ConnectionString = stringBuilderSQL.ConnectionString;
                       return SQLServer_Connection;
                   }
               default:
                   {
                       SQLServer_StringBuilder = String.Empty;
                       return SQLServer_Connection;
                   }

           }
       }
       
       #endregion

   } /*FIM CLASS - ConnectionDataBase*/
}/*FIM NAMESPACE - App_SQL_Conections*/
