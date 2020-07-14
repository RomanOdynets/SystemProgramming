using System.IO; // Input Output - work with file system
using System.Reflection; // 
using System.Runtime.InteropServices; // WinAPI packages
using System.Text; // text management
using System.Threading.Tasks; // async packages

namespace IniWork_Extended
{
    public class Ini
    {
        private string path;
        private string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public Ini(string IniPath = null) => path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        
        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, path);
            return RetVal.ToString();
        }

        public async Task<string> ReadAsync(string Key, string Section = null)
        {
            return await Task.Run(() => Read(Key, Section));
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, path);
        }

        public async void WriteAsync(string Key, string Value, string Section = null)
        {
            await Task.Run(() => Write(Key, Value, Section));
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public async void DeleteSectionAsync(string Section = null)
        {
            await Task.Run(() => DeleteSection(Section));
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

        public async Task<bool> KeyExistsAsync(string Key, string Section = null)
        {
            return await Task.Run(() => KeyExists(Key, Section));
        }
    }
}
