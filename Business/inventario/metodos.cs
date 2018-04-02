using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Business.inventario
{
    public static class metodos
    {


        public static string ImageToBase64(Image image,
          System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }



        public static Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image;
                if (base64String != "")
                    image = Image.FromStream(ms, true);
                else image = null;
                return image;
            }
        }

        public static int getid(producto p)
        {
            string cmd = "select id from producto" +
                "where" +
                "modelo = '" + p.modelo + "' and marca = '" + p.marca + "' and descripcion = '" + p.descripcion + "'";
            DataTable dt = dataAccess.inventario.select.recoge(cmd);
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
