using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace Pear_Inc
{
    class Helper
    {
        public static string MsgBoxTitulo, MsgBoxSubTitulo, MsgBoxBoton, MsgBoxLoad, UsuActual, TipoUsuActual = "";
        public static double Salario = 0, ISR = 0, AFP = 0, ISSS = 0, Total = 0, SalarioNetoFinal = 0, TotalRetenciones = 0;
        public static int Resultado = 0;
        public static object Dato = null;
        public static OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Jet OLEDB:Database Password=prototype");
        public static OleDbCommand Comando;        
        private static byte[] clave = { 1, 22, 19, 111, 24, 26, 
           85, 45, 114, 184, 27, 111, 37, 112, 100, 200, 241,
           24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 
           131, 236, 53, 209 };

        private static byte[] vector = { 146, 64, 191, 104, 123, 
       3, 2, 1, 231, 121, 221, 112, 79, 32, 114, 1 };

        private ICryptoTransform enc, dec;
        private UTF8Encoding utf8;

        public Helper()
        {
            RijndaelManaged rm = new RijndaelManaged();
            enc = rm.CreateEncryptor(clave, vector);
            dec = rm.CreateDecryptor(clave, vector);
            utf8 = new UTF8Encoding();
        }

        public string Encriptar(string valor)
        {
            byte[] buffer = Transformar(utf8.GetBytes(valor), enc);
            return Convert.ToBase64String(buffer);
        }

        public string Desencriptar(string valor)
        {
            byte[] buffer = Convert.FromBase64String(valor);
            buffer = Transformar(buffer, dec);
            return utf8.GetString(buffer);
        }

        private byte[] Transformar(byte[] buffer, ICryptoTransform ict)
        {
            MemoryStream stream = new MemoryStream();
            using (var cs = new CryptoStream(stream, ict, CryptoStreamMode.Write))
            {
                cs.Write(buffer, 0, buffer.Length);
            }
            return stream.ToArray();
        }

        public static int Execute(string Consulta)
        {
            try
            {
                Conexion.Open();
                Comando = new OleDbCommand(Consulta, Conexion);
                Resultado = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            Comando.Dispose();
            Conexion.Close();
            return Resultado;
        }

        public static Object ObtenerDato(string Consulta)
        {            
            try
            {
                Conexion.Open();
                Comando = new OleDbCommand(Consulta, Conexion);
                Dato = Comando.ExecuteScalar();
                Comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Conexion.Close();
            return Dato;
        }


        public static DataTable Cargar(string Consulta)
        {
            DataTable datos = new DataTable();

            try
            {
                Conexion.Open();

                OleDbCommand sql = new OleDbCommand(Consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();

                datos.Load(lector);

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(""+mensaje);
            }
            Conexion.Close();
            return (datos);
        }

        public static string MsgBox(string titulo, string subtitulo, string accion, string load)
        {
            var msgbox = new frmMessageBox();
            Helper.MsgBoxTitulo = titulo;
            Helper.MsgBoxSubTitulo = subtitulo;
            Helper.MsgBoxBoton = accion;
            Helper.MsgBoxLoad = load;
            msgbox.ShowDialog();
            return null;
        }

        public static double RetencionISSS(double salario)
        {
            double ISSS = 0;
            double retencionissss = 0;
            ISSS = Convert.ToDouble(salario);
            if (ISSS >= 233.10 && ISSS <= 685.71)
            {

                retencionissss = ISSS * 0.0325;
            }
            else if (ISSS > 685.71)
            {
                retencionissss = 20.57;
            }

            return retencionissss;
        }

        public static double RetencionAFP(double salario)
        {

            double AFP = 0;
            double retencionafp = 0;
            AFP = Convert.ToDouble(salario);
            if (AFP >= 233.10)
            {
                retencionafp = AFP * 0.0625;
            }
            return retencionafp;
        }

        public static double RetencionISR(double AFP, double salario)
        {
            double ISR = 0;
            ISR = Convert.ToDouble(salario - AFP);
            double retencionisr = 0;
            double totalretencionisr = 0;
            double salario2 = 0;
            if (ISR >= 233.10 && ISR < 487.60)
            {
                totalretencionisr = 0;
            }
            else if (ISR >= 487.60 && ISR < 642.85)
            {
                salario2 = ISR - 487.60;
                retencionisr = salario2 * 0.10;
                totalretencionisr = retencionisr + 17.48;
            }
            else if (ISR >= 642.85 && ISR < 915.81)
            {
                salario2 = ISR - 642.85;
                retencionisr = salario * 0.10;
                totalretencionisr = retencionisr + 32.70;
            }
            else if (ISR >= 915.81 && ISR < 2058.68)
            {
                salario2 = ISR - 915.81;
                retencionisr = salario * 0.20;
                totalretencionisr = retencionisr + 60.00;
            }
            else if (ISR >= 2058.68)
            {
                salario2 = ISR - 2058.68;
                retencionisr = salario * 0.30;
                totalretencionisr = retencionisr + 288.57;
            }
            else
            {
                Helper.MsgBox("Error", "Salario no valido.", "", "Aceptar");
            }
            return totalretencionisr;
        }

        public static double Totalretenciones(double ISSS, double AFP, double ISR)
        {
            double retISSS, retAFP, retISR;
            retISSS = Convert.ToDouble(ISSS);
            retAFP = Convert.ToDouble(AFP);
            retISR = Convert.ToDouble(ISR);
            Helper.TotalRetenciones = retISSS + retAFP + retISR;
            return Helper.TotalRetenciones;
        }

        public static double SalarioNeto()
        {
            double salnetfin = Helper.Salario - Helper.TotalRetenciones;
            return salnetfin;
        }

        public static void solonumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        public static void sololetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        public static bool comprobarEmail(String email)//Se vrea el metodo email_bien_escrito que devuelve un valor tipo texto
        {
            String expresion;//Se declara la variable "expresion"
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";//La variable "Expresion" va a ser igual a una serie de carracteres que llevaran el orden de un correo verdadero
            if (Regex.IsMatch(email, expresion))// la clase Regex para utilizar expresiones regulares
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            /*
             Dicho método recibe una cadena de texto (un objeto de tipo String) y nos va a devolver verdadero o falso si la dirección pasada al método está bien escrita o no respectivamente.
             */
        }

    }
}
