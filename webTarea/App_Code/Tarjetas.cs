using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using Seguridad.EAS256;
using Seguridad.Hash;

/// <summary>
/// Summary description for Tarjetas
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Tarjetas : System.Web.Services.WebService
{

    public Tarjetas()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string NumeroTarjetaValido(string NumeroTarjeta)
    {
        Regex ValidaFormato = new Regex(@"[0-9]{16}");
        string Respuesta = "";
        if (ValidaFormato.IsMatch(NumeroTarjeta))
            Respuesta = "*************" + NumeroTarjeta.Substring(13, 3);
        return Respuesta;
    }

    [WebMethod]
    public ResponseObtenerLLave ObtenerLlaveIV()
    {
        llave LlaveNueva = new llave();
        ResponseObtenerLLave Respuesta = new ResponseObtenerLLave();
        LlaveNueva = EAS256.CrearLlave();
        Respuesta.Key = LlaveNueva.Key;
        Respuesta.IV = LlaveNueva.IV;
        return Respuesta;
    }


    [WebMethod]
    public byte[] Hashing(string NumeroTarjeta)
    {
        return Hash.Genera(NumeroTarjeta); ;
    }

    [WebMethod]
    public byte[] EncriptarTarjeta(string Tarjeta,byte[] llave,byte[] IV)
    {
       return EAS256.Encriptar(Tarjeta, llave, IV);
    }

    [WebMethod]
    public string DesencriptarTarjeta(byte[] Tarjeta, byte[] llave, byte[] IV)
    {
        return EAS256.Desencriptar(Tarjeta, llave, IV);
    }


    public class ResponseObtenerLLave
    {
        public byte[] Key { set; get; }
        public byte[] IV { set; get; }
    } 

}

