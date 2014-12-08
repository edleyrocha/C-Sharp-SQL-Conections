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
      
        /// <summary>
        /// Metodo Contrutor Form Principal
        /// </summary>
        public frmSQL_ServerA()
        {
            InitializeComponent();
            FU1_Limpar_BOX();
            FU2_BotaoAuthentication_ON_OFF();
            FU3_AdicionarItens_comboBoxTimes();
        }

        #region ---(Lista de FUNCORES)---
     
        
        /// <summary>
        /// Limpar todos os componentes
        /// </summary>
        private void FU1_Limpar_BOX()
        {
            this.textBoxBanco.Clear();
            this.textBoxSever.Clear();
            this.textBoxUser.Clear();
            this.textBoxPassword.Clear();
            this.comboBoxTime.Items.Clear();
            this.richTextBox_Comentatatios.Clear();
        }

        /// <summary>
        /// Mudar Status botao ON OFF e Componentes Label e Combobox
        /// </summary>
        private void FU2_BotaoAuthentication_ON_OFF()
        {
            /// ENABLE
            comboBoxTime.Enabled =! comboBoxTime.Enabled;
            labelTimeOut.Enabled =! labelTimeOut.Enabled;
            /// IF ON OFF
            /// 
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

            if ((btnShow.Text == ("Show")) && (textBoxPassword.UseSystemPasswordChar == (true)))
            {
                btnShow.Text = "No Show";
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else if ((btnShow.Text == ("No Show")) && (textBoxPassword.UseSystemPasswordChar == (false)))
            {
                btnShow.Text = "Show";
                textBoxPassword.UseSystemPasswordChar = true;
                
            }
        }

        /// <summary>
        /// Disable Enable componentes
        /// </summary>
        private void FU5_EnableDisableComponentes()
        {
            labelUser.Enabled =! (labelUser.Enabled);
            labelPassword.Enabled = !(labelPassword.Enabled);
            textBoxUser.Enabled = !(textBoxUser.Enabled);
            textBoxPassword.Enabled = !(textBoxPassword.Enabled);
            btnShow.Enabled = !(btnShow.Enabled);
         
        }

        /// <summary>
        /// Enviar Strings dos campos para montar Conexao;
        /// </summary>
        public void FU6_Montar_StringBuilder_SQLConnection()
        {
            ConnectionDataBase.SQLServer_1_StringBuilder = string.Empty;
            ConnectionDataBase.SQLServer_2_EnderecoServidor = textBoxSever.Text; ///1
            ConnectionDataBase.SQLServer_3_NomeBancoDeDados = textBoxBanco.Text; ///2

            if (rb_Authentication_SQL_Server.Checked)
            {
                ConnectionDataBase.SQLServer_4_TipoSeguranca = (false); ///3
                ConnectionDataBase.SQLServer_5_LoginUsuario = textBoxUser.Text; ///4
                ConnectionDataBase.SQLServer_6_LoginSenha = textBoxPassword.Text; ///5
            }
            else if (rb_Authentication_Windows.Checked)
            {
                ConnectionDataBase.SQLServer_4_TipoSeguranca = (true); ///3
            }

            if ((comboBoxTime.SelectedItem != null) && (comboBoxTime.Enabled != false))
            {
                ConnectionDataBase.SQLServer_7_TimeOutConexao = (int.Parse(comboBoxTime.Text));///6
            }
        }

        /// <summary>
        /// Abrir ou Fechar Banco de Dados Somente
        /// </summary>
        /// <param name="AbrirTrue_FechaFalse"></param>
        private void FU7_ConectarDesconectar(string ConectarDesconectar)
        {
            try
            {
                switch (ConectarDesconectar)
                {
                    case ("Conectar"):
                        {
       
                            ConnectionDataBase.SQLServer_FU_Connection("Open");
                            btnConectarDesconectar.Text = ("Desconectar");
                            break;
                        }
                    case ("Desconectar"):
                        {

                            ConnectionDataBase.SQLServer_FU_Connection("Close");
                            btnConectarDesconectar.Text = ("Conectar");
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
            FU6_Montar_StringBuilder_SQLConnection();
            richTextBox_Comentatatios.Clear();
            richTextBox_Comentatatios.AppendText("StringBuilder ---> " + (ConnectionDataBase.SQLServer_1_StringBuilder) + ("\n"));
            richTextBox_Comentatatios.AppendText("\r");
            richTextBox_Comentatatios.AppendText("SQL_String   ---> " + (ConnectionDataBase.SQLServer_FU_Connection("Status").ConnectionString.ToString()) + ("\n"));
            richTextBox_Comentatatios.AppendText("\r");
            richTextBox_Comentatatios.AppendText("SQL_Status  ---> " + (ConnectionDataBase.SQLServer_FU_Connection("Status").State.ToString()) + ("\n"));
         }

        private void rb_Authentication_Windows_CheckedChanged(object sender, EventArgs e)
        {
            FU5_EnableDisableComponentes();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FU4_MudarCharPasswordNormal();
        }

        private void btnConectarDesconectar_Click(object sender, EventArgs e)
        {
            FU6_Montar_StringBuilder_SQLConnection();
            FU7_ConectarDesconectar(btnConectarDesconectar.Text.ToString());
        }

    }
}
