using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;

namespace Utilities.Helpers;

public static class FileContentTools
{
    public static class MimeTypes
    {
        public const string AppPdf = "application/pdf";
        public const string AppZip = "application/zip";
        public const string AppJson = "application/json";
        public const string AppProbAndJson = "application/problem+json";
        public const string AppBson = "application/bson";
        public const string AppXml = "application/xml";
        public const string AppUnknown = "application/unknown";
        public const string ImageTiff = "image/tiff";
        public const string ImageJpeg = "image/jpeg";
        public const string ImagePng = "image/png";
        public const string ImageGif = "image/gif";
        public const string ImageBmp = "image/bmp";
        public const string MessageRfc822 = "message/rfc822";
        public const string TextPlain = "text/plain";
        public const string TextHtml = "text/html";
        public const string FormUrlEncoded = "application/x-www-form-urlencoded";
        public const string FormData = "multipart/form-data";
        public const string AllTypes = "*/*";
    }

    private const string ContentTypeRegKeyValue = "Content Type";
    private static ConcurrentDictionary<string, string> mimeTypes = new ConcurrentDictionary<string, string>();
    private static string[] sizeSuffix = { "B", "KB", "MB", "GB", "TB" };

    public static string? GetMimeType(string fileName)
    {
        string? mimeType;
        string fileExtension = Path.GetExtension(fileName).ToLower();
        if (!mimeTypes.TryGetValue(fileExtension, out mimeType))
        {
#pragma warning disable CA1416 // Validate platform compatibility
            Microsoft.Win32.RegistryKey? regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(fileExtension);
            if (regKey != null && regKey.GetValue(ContentTypeRegKeyValue) != null)
            {
                mimeType = regKey.GetValue(ContentTypeRegKeyValue)?.ToString();
            }
            else
            {
                switch (fileExtension)
                {
                    case ".avi":
                        mimeType = "video/x-msvideo";
                        break;

                    case ".bmp":
                        mimeType = FileContentTools.MimeTypes.ImageBmp;
                        break;

                    case ".rtf":
                    case ".dot":
                    case ".doc":
                    case ".docx":
                        mimeType = "application/msword";
                        break;

                    case ".xlm":
                    case ".xls":
                    case ".xlsx":
                        mimeType = "application/vnd.ms-excel";
                        break;

                    case ".ppt":
                    case ".pptx":
                        mimeType = "application/vnd.ms-powerpoint";
                        break;

                    case ".msg":
                        mimeType = "application/vnd.ms-outlook";
                        break;

                    case ".png":
                        mimeType = FileContentTools.MimeTypes.ImagePng;
                        break;

                    case ".pdf":
                        mimeType = FileContentTools.MimeTypes.AppPdf;
                        break;

                    case ".jpe":
                    case ".jpg":
                    case ".jpeg":
                        mimeType = FileContentTools.MimeTypes.ImageJpeg;
                        break;

                    case ".tif":
                    case ".tiff":
                        mimeType = FileContentTools.MimeTypes.ImageTiff;
                        break;

                    case ".gif":
                        mimeType = FileContentTools.MimeTypes.ImageGif;
                        break;

                    case ".zip":
                        mimeType = FileContentTools.MimeTypes.AppZip;
                        break;

                    case ".eml":
                        mimeType = FileContentTools.MimeTypes.MessageRfc822;
                        break;

                    case ".html":
                    case ".htm":
                        mimeType = FileContentTools.MimeTypes.TextHtml;
                        break;

                    case ".txt":
                        mimeType = FileContentTools.MimeTypes.TextPlain;
                        break;

                    case ".xml":
                        mimeType = FileContentTools.MimeTypes.AppXml;
                        break;

                    case ".json.txt":
                    case ".json":
                        mimeType = FileContentTools.MimeTypes.AppJson;
                        break;

                    case ".bson.bin":
                    case ".bson":
                        mimeType = FileContentTools.MimeTypes.AppBson;
                        break;

                    default:
                        mimeType = FileContentTools.MimeTypes.AppUnknown;
                        break;
                }
            }

            if (null != mimeType)
            {
                mimeTypes.TryAdd(fileExtension, mimeType);
            }

#pragma warning restore CA1416 // Validate platform compatibility
        }

        return mimeType;
    }

    public static string GetFileExtensionFromMimeType(string mimeType)
    {
        switch (mimeType)
        {
            case FileContentTools.MimeTypes.AppPdf:
                return ".pdf";

            case FileContentTools.MimeTypes.AppZip:
                return ".zip";

            case FileContentTools.MimeTypes.ImageTiff:
                return ".tif";

            case FileContentTools.MimeTypes.ImagePng:
                return ".png";

            case FileContentTools.MimeTypes.ImageJpeg:
                return ".jpg";

            case FileContentTools.MimeTypes.ImageGif:
                return ".gif";

            case FileContentTools.MimeTypes.ImageBmp:
                return ".bmp";

            case FileContentTools.MimeTypes.TextPlain:
                return ".txt";

            case FileContentTools.MimeTypes.TextHtml:
                return ".html";

            case FileContentTools.MimeTypes.AppJson:
                return ".json";

            case FileContentTools.MimeTypes.AppBson:
                return ".bson";
                // TODO: need to support other formats
        }

        // default
        return ".bin";
    }

    public static string GetImageFormatMimeContentType(byte[] bytes)
    {
        // see http://www.mikekunz.com/image_file_header.html
        byte[] bmp = Encoding.ASCII.GetBytes("BM");         // BMP
        byte[] gif = Encoding.ASCII.GetBytes("GIF");        // GIF
        byte[] png = new byte[] { 137, 80, 78, 71 };        // PNG
        byte[] tiff = new byte[] { 73, 73, 42 };            // TIFF
        byte[] tiff2 = new byte[] { 77, 77, 42 };           // TIFF
        byte[] jpeg = new byte[] { 255, 216, 255, 224 };    // jpeg
        byte[] jpeg2 = new byte[] { 255, 216, 255, 225 };   // jpeg canon

        if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)) ||
            jpeg2.SequenceEqual(bytes.Take(jpeg2.Length)))
        {
            return FileContentTools.MimeTypes.ImageJpeg;
        }

        if (png.SequenceEqual(bytes.Take(png.Length)))
        {
            return FileContentTools.MimeTypes.ImagePng;
        }

        if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
        {
            return FileContentTools.MimeTypes.ImageBmp;
        }

        if (gif.SequenceEqual(bytes.Take(gif.Length)))
        {
            return FileContentTools.MimeTypes.ImageGif;
        }

        if (tiff.SequenceEqual(bytes.Take(tiff.Length)) ||
            tiff2.SequenceEqual(bytes.Take(tiff2.Length)))
        {
            return FileContentTools.MimeTypes.ImageTiff;
        }

        return FileContentTools.MimeTypes.AppUnknown;
    }

    public static bool CompareFileStreams(Stream s1, Stream s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        long s1Position = s1.Position;
        long s2Position = s2.Position;

        s1.Position = s2.Position = 0;
        try
        {
            const int chunkSize = sizeof(Int64);
            int iterations = (int)Math.Ceiling((double)s1.Length / chunkSize);
            byte[] one = new byte[chunkSize];
            byte[] two = new byte[chunkSize];
            for (int i = 0; i < iterations; i++)
            {
                s1.Read(one, 0, chunkSize);
                s2.Read(two, 0, chunkSize);
                if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                {
                    return false;
                }
            }
        }
        finally
        {
            s1.Position = s1Position;
            s2.Position = s2Position;
        }

        // Everything matched, the streams have the exact same data
        return true;
    }

    public static string GetFileBytesMd5Hash(byte[] dataBytes)
    {
        MD5 md5 = MD5.Create();
        byte[] hashBytes = md5.ComputeHash(dataBytes);
        string hashString = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLowerInvariant();

        return hashString;
    }

    public static string GetFileSizeLabel(long fileSizeInBytes)
    {
        long bytes = Math.Abs(fileSizeInBytes);
        int place = bytes > 0 ? Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024))) : 0;
        double num = Math.Round(bytes / Math.Pow(1024, place), 1);

        if (place >= sizeSuffix.Length)
        {
            throw new ArgumentOutOfRangeException();
        }

        return string.Format("{0} {1}", Math.Sign(fileSizeInBytes) * num, sizeSuffix[place]);
    }
}