using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoTarea
{
    public partial class frmTarea : Form
    {
        public frmTarea()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string TarjetaSanitizada = SanitizarEntrada();
            wsTarjeta.ResponseObtenerLLave RespuestaLLave;
            byte[] hash1=null;
            byte[] hash2 = null; 
            byte[] TarjetaEncriptada;
            string TarjetaDesencriptada="" ;
            bool CompararHashing = false;

            txtLog.Text = "Entrada Sanitizada :" + TarjetaSanitizada + Environment.NewLine; 
            wsTarjeta.TarjetasSoapClient Ejecuta = new wsTarjeta.TarjetasSoapClient();
            if (!string.IsNullOrEmpty(Ejecuta.NumeroTarjetaValido(TarjetaSanitizada)))
            {
                RespuestaLLave = Ejecuta.ObtenerLlaveIV();
                if (RespuestaLLave.Key != null)
                {
                    txtLog.Text = txtLog.Text + "Llave :" + Convert.ToBase64String(RespuestaLLave.Key)+ Environment.NewLine;
                    txtLog.Text = txtLog.Text + "Reinicio IV:" + Convert.ToBase64String(RespuestaLLave.IV) + Environment.NewLine;
                    hash1 = Ejecuta.Hashing(TarjetaSanitizada);
                    txtLog.Text = txtLog.Text + "Hash :" + Convert.ToBase64String(hash1) + Environment.NewLine;
                    TarjetaEncriptada = Ejecuta.EncriptarTarjeta(TarjetaSanitizada, RespuestaLLave.Key, RespuestaLLave.IV);
                    txtLog.Text = txtLog.Text + "Encriptación :" + Convert.ToBase64String(TarjetaEncriptada) + Environment.NewLine;
                    TarjetaDesencriptada = Ejecuta.DesencriptarTarjeta(TarjetaEncriptada, RespuestaLLave.Key, RespuestaLLave.IV);
                    txtLog.Text = txtLog.Text + "Desencriptación :" + TarjetaDesencriptada  + Environment.NewLine;
                    CompararHashing = true;
                }
                else
                {
                    txtLog.Text = txtLog.Text + "Error al Obtener LLave y Matriz de Reinicio." + Environment.NewLine;
                }
            }
            else
            {
                txtLog.Text = txtLog.Text + "No cumple la validacion de Numero de Tarjeta." + Environment.NewLine;
            }

            if (CompararHashing == true)
            {
                hash2 = Ejecuta.Hashing(TarjetaDesencriptada);
                txtLog.Text = txtLog.Text + "Comparacion de Hashing :" + Environment.NewLine;
                txtLog.Text = txtLog.Text + "Hashing Antes de Encriptar:" + Convert.ToBase64String(hash1) + Environment.NewLine;
                txtLog.Text = txtLog.Text + "Hashing Despues de Encriptar:" + Convert.ToBase64String(hash2) + Environment.NewLine;
                if (Convert.ToBase64String(hash1) == Convert.ToBase64String(hash2))
                {
                    txtLog.Text = txtLog.Text + "SON IGUALES" + Environment.NewLine;
                }
                else
                {
                    txtLog.Text = txtLog.Text + "NO SON IGUALES" + Environment.NewLine;
                }
            }
        }


        private string SanitizarEntrada()
        {
            return  Regex.Replace(txtTarjeta.Text, @"[^\w\s.!@$%^&*()\-\/]+", "");
        }
    }
}
