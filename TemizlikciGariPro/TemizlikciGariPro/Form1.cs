/* 
       * █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
       * █  T E M İ Z L İ K Ç İ   G A R İ  █
       * █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
       * █■ Developer: Efekan Efendioğlu   █
       * █■ Version: 2.5                  █
       * █■ Release Date: 2025            █
       * ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
       */

using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace TemizlikciGariPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDurum.Text = "Hazır";
        }

        private async void btnTemizle_Click(object sender, EventArgs e)
        {
            btnTemizle.Enabled = false;
            lblDurum.Text = "Temizlik yapılıyor...";

            try
            {
                await Task.Run(() => {
                    // Temel temizlik klasörleri
                    string[] folders = {
                        Path.GetTempPath(),
                        Environment.GetFolderPath(Environment.SpecialFolder.InternetCache),
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"),
                        @"C:\Windows\Temp",
                        @"C:\Windows\Prefetch"
                    };

                    foreach (var folder in folders)
                    {
                        if (Directory.Exists(folder))
                        {
                            CleanFolder(folder);
                        }
                    }

                    if (IsRunningAsAdmin())
                    {
                        EmptyRecycleBin();
                    }
                });

                lblDurum.Text = "Temizlik tamamlandı!";
            }
            catch (Exception ex)
            {
                lblDurum.Text = "Hata: " + ex.Message;
            }
            finally
            {
                btnTemizle.Enabled = true;
            }
        }

        private void CleanFolder(string folderPath)
        {
            try
            {
                // Dosyaları sil
                foreach (var file in Directory.GetFiles(folderPath))
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                    catch { }
                }

                // Klasörleri sil
                foreach (var dir in Directory.GetDirectories(folderPath))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private bool IsRunningAsAdmin()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private void EmptyRecycleBin()
        {
            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null,
                    RecycleFlag.SHERB_NOCONFIRMATION |
                    RecycleFlag.SHERB_NOPROGRESSUI |
                    RecycleFlag.SHERB_NOSOUND);
            }
            catch { }
        }

        [DllImport("Shell32.dll")]
        private static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        private enum RecycleFlag
        {
            SHERB_NOCONFIRMATION = 0x1,
            SHERB_NOPROGRESSUI = 0x2,
            SHERB_NOSOUND = 0x4
        }
    }
}