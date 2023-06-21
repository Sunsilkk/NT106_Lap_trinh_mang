using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FtpWebRequest request = null;
        FtpWebResponse response = null;
        Stream ftpStream = null;
        int length = 1024;

        private List<string> ListFiles()
        {
           try
            {
                request = (FtpWebRequest)WebRequest.Create(txt_host.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();
                request = null;

                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }
            catch 
            {
                throw;
            }
        }


        private void btn_View_Click(object sender, EventArgs e)
        {
            List<string> listFile = ListFiles();
            for(int i=0;  i<listFile.Count; i++)
            {
                lv.Items.Add(listFile[i]);
            }
        }

        private void lv_ItemActivate(object sender, EventArgs e)
        {
            Download();
        }

        private void btn_Pickfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.ShowDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txt_url.Text = openFile.FileName;
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void Download()
        {
            try
            {
                string str = lv.SelectedItems[0].Text;
                request = (FtpWebRequest)WebRequest.Create(txt_host.Text + "/" + str);
                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);

                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = str;

                DialogResult result = saveFileDialog.ShowDialog();
                byte[] byteBuffer = new byte[length];
                int bytesRead = ftpStream.Read(byteBuffer, 0, length);
                if(result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    try
                    {
                        while (bytesRead > 0)
                        {
                            fs.Write(byteBuffer, 0, bytesRead);
                            bytesRead = ftpStream.Read(byteBuffer, 0, length);
                        }
                        MessageBox.Show("Downloaded file successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                ftpStream.Close();
                response.Close();
                request = null;
            }
            catch
            {
                MessageBox.Show("Select a file before downloading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if(txt_url.Text != string.Empty)
            {
                lbl_Wrong.Text = "";
                FileInfo info = new FileInfo(txt_url.Text);

                request = (FtpWebRequest)WebRequest.Create("ftp://" + txt_host.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);

                ftpStream = request.GetRequestStream();
                FileStream file = File.OpenRead(txt_url.Text);

                byte[] buffer = new byte[length];
                int byteRead = 0;

                do
                {
                    byteRead = file.Read(buffer, 0, length);
                    ftpStream.Write(buffer, 0, byteRead);
                } while(byteRead != 0);

                file.Close();
                ftpStream.Close();
                request = null;

                MessageBox.Show("Upload Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Wrong.Text = "Pick a file before uploading!";
            }              

        }
    }
}
