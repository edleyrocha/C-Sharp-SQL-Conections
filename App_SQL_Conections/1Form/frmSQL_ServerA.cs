using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_SQL_Conections
{
    public partial class frmSQL_ServerA : Form
    {
        ConnectionDataBase c = new ConnectionDataBase();




        /// <summary>
        /// Metodo Contrutor Form Principal
        /// </summary>
        public frmSQL_ServerA()
        {
            InitializeComponent();

            FU1_Limpar_TextBOX();
            FU3_AdicionarItens_comboBoxTimes();
            FU2_BotaoAuthentication_ON_OFF();

        }

        #region ---(Lista de FUNCORES)---
        /// <summary>
        /// Limpar todoas os componentes
        /// </summary>
        private void FU1_Limpar_TextBOX()
        {
            textBoxBanco.Clear();
            textBoxSever.Clear();
            textBoxUser.Clear();
            textBoxPassword.Clear();
            comboBoxTime.Items.Clear();
            richTextBox_Comentatatios.Clear();

        }

        /// <summary>
        /// Mudar Status botao ON OFF e Componentes Label e Combobox
        /// </summary>
        private void FU2_BotaoAuthentication_ON_OFF()
        {
            /// ENABLE
            comboBoxTime.Enabled =! comboBoxTime.Enabled;
            labelTimeOut.Enabled =! labelTimeOut.Enabled;
       
            if (btn__Authentication_ON_OFF.Text == ("OFF"))
            {
                btn__Authentication_ON_OFF.Text = "ON";
            }
            else if (btn__Authentication_ON_OFF.Text == ("ON"))
            {
                btn__Authentication_ON_OFF.Text = "OFF";
            }
        }
      
        /// <summary>
        /// ADD itens Itens ao ComboVBOX TimeOut
        /// </summary>
        private void FU3_AdicionarItens_comboBoxTimes()
        {
            for (int i = 0; i <= 999; i++)
            {
                comboBoxTime.Items.Add(Convert.ToString(i));
            }
            comboBoxTime.Text = Convert.ToString(comboBoxTime.Items[30].ToString());
        }
       
        /// <summary>
        /// Mudar Componente Password;
        /// </summary>
        private void FU4_MudarCharPasswordNormal()
        {
            if (textBoxPassword.PasswordChar == ('*'))
            {
                //textBoxPassword.PasswordChar = '\0';    //1 AS DUAS FORMA FUNCIONA
                textBoxPassword.PasswordChar = ((Char)0); //2
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
        private void FU5_EnableDisableComponentes()
        {
            labelUser.Enabled =! (labelUser.Enabled);
            labelPassword.Enabled = !(labelPassword.Enabled);
            textBoxUser.Enabled = !(textBoxUser.Enabled);
            textBoxPassword.Enabled = !(textBoxPassword.Enabled);
            btnShow.Enabled = !(btnShow.Enabled);
         
        }
        /// <summary>
        /// Enviar strigns dos campos para montar Conexao;
        /// </summary>
        public void FU4_EnviarDadosConectionStringSQLServer()
        {
            
            c.SQLServer_GetSqlConnectionSQLServer(false);
            c.SQLServer_Endereco_Servidor = textBoxSever.Text; ///1
            c.SQLServer_Nome_BancoDeDados = textBoxBanco.Text; ///2

            if (rb_Authentication_SQL_Server.Checked)
            {
                c.SQLServer_Tipo_Seguranca = (false); ///3
                c.SQLServer_Usuario_Login = textBoxUser.Text; ///4
                c.SQLServer_Senha_Login = textBoxPassword.Text; ///5
            }
            else if (rb_Authentication_Windows.Checked)
            {
                c.SQLServer_Tipo_Seguranca = (true); ///3
            }

            if ((comboBoxTime.SelectedItem != null) && (comboBoxTime.Enabled != false))
            {
                c.SQLServer_TimeOutConexao = (int.Parse(comboBoxTime.Text));///6
            }
        }

        /// <summary>
        /// Abrir ou Fechar Banco de Dados Somente
        /// </summary>
        /// <param name="AbrirTrue_FechaFalse"></param>
        private void FU5_AbrirFecharConexaoSQLServer(Boolean AbrirTrue_FechaFalse)
        {
            try
            {
            
               
                switch (AbrirTrue_FechaFalse)
                {
                    case (true):
                        {
                           
                          //  c.SQLServer_Connection.Open();
                            break;
                        }
                    case (false):
                        {
                           
                           // c.SQLServer_Connection.Close();
                            break;
                        }
                    default:
                        {
                            break;
                        }
               }
            }
            catch (Exception erroAbrirFecharConexaoSQLServer)
            {
                richTextBox_Comentatatios.AppendText("Erro:" + (erroAbrirFecharConexaoSQLServer) + ("\r \n"));
            }
        }

      


        #endregion


        private void btn__Authentication_ON_OFF_Click(object sender, EventArgs e)
        {
            FU2_BotaoAuthentication_ON_OFF();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            richTextBox_Comentatatios.Clear();
            FU4_EnviarDadosConectionStringSQLServer();
            richTextBox_Comentatatios.AppendText("Status ---> " + (c.SQLServer_GetSqlConnectionSQLServer(true).State.ToString()) + ("\n"));
            richTextBox_Comentatatios.AppendText("Using  ---> " + (c.SQLServer_GetSqlConnectionSQLServer(true).ToString()) + ("\n"));
            richTextBox_Comentatatios.AppendText("String  ---> " + (c.SQLServer_GetSqlConnectionSQLServer(true).ConnectionString.ToString()) + ("\n"));
        }

        private void rb_Authentication_Windows_CheckedChanged(object sender, EventArgs e)
        {
            FU5_EnableDisableComponentes();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            //FU4_EnviarDadosConectionStringSQLServer();
            //c.FU1_MontarRetornarConexaoSQLServer(); 
            //FU5_AbrirFecharConexaoSQLServer(true);
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //FU4_EnviarDadosConectionStringSQLServer();
            //FU5_AbrirFecharConexaoSQLServer(false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            FU4_MudarCharPasswordNormal();
        }

     
 

    }
}
