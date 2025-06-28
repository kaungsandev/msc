using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplicationTest
{
    public class FileController
    {
        public static bool UploadImage(HttpPostedFile file)
        {
            // Check if the file is null
            if (file == null || file.ContentLength == 0)
            {
                return false;
            }

            // Validate file size, limiting to 5MB
            if (file.ContentLength > 1024 * 1024 * 5)
            {
                return false;
            }

            // Validate file extension
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png", ".gif" };
            var extension = Path.GetExtension(file.FileName).ToLower();
            if (!allowedExtensions.Contains(extension))
            {
                return false;
            }

            // Generate a new unique file name
            var fileName = Guid.NewGuid().ToString() + extension;

            // Ensure the uploads folder exists
            var uploadsPath = HttpContext.Current.Server.MapPath("~/uploads");
            if (!Directory.Exists(uploadsPath))
            {
                Directory.CreateDirectory(uploadsPath);
            }

            var path = Path.Combine(uploadsPath, fileName);

            try
            {
                file.SaveAs(path);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("File upload error: " + ex.Message);
                return false;
            }
        }

    }
}