using System;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace MusicPlayer
{
    class DownLoader
    {
        private DownLoader() { }
        /// <summary>
        /// 歌曲或专辑图片的下载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool DownloadSongOrImg(string url, string filePath)
        {
            bool flag = true;
            //long startPosition = 0; // 上次下载的文件起始位置
            FileStream writeStream;

            // 判断要下载的文件是否存在
            /*if (File.Exists(filePath))
            {
                writeStream = File.OpenWrite(filePath);                 // 存在则打开要下载的文件
                startPosition = writeStream.Length;                     // 获取已经下载的长度
                writeStream.Seek(startPosition, SeekOrigin.Current);    // 本地文件写入位置定位
            }
            else
            {
                writeStream = new FileStream(filePath, FileMode.Create); // 文件不存在创建一个文件
                startPosition = 0;
            }*/
            if (!File.Exists(filePath))
            {
                writeStream = new FileStream(filePath, FileMode.Create); // 文件不存在创建一个文件
                //startPosition = 0;
                try
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url); // 打开网络连接

                    /*if (startPosition > 0)
                    {
                        myRequest.AddRange((int)startPosition); // 设置Range值, 定义远程文件读取位置
                    }*/

                    Stream readStream = myRequest.GetResponse().GetResponseStream(); // 获得服务器的回应数据流

                    byte[] btArray = new byte[512];
                    int contentSize = readStream.Read(btArray, 0, btArray.Length);

                    while (contentSize > 0) // 如果读取长度大于零则继续读
                    {
                        writeStream.Write(btArray, 0, contentSize);
                        contentSize = readStream.Read(btArray, 0, btArray.Length);
                    }

                    writeStream.Close();
                    readStream.Close();

                    flag = true;        //返回true下载成功
                }
                catch
                {
                    writeStream.Close();
                    flag = false;       //返回false下载失败
                }
            }
            return flag;
        }
        /// <summary>
        /// 歌词的下载及处理
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool DownloadLrc(string url, string filePath)
        {
            bool flag = false;
            //long startPosition = 0; // 上次下载的文件起始位置
            FileStream writeStream;

            // 判断要下载的文件是否存在
            /*if (File.Exists(filePath))
            {
                writeStream = File.OpenWrite(filePath);                 // 存在则打开要下载的文件
                startPosition = writeStream.Length;                     // 获取已经下载的长度
                writeStream.Seek(startPosition, SeekOrigin.Current);    // 本地文件写入位置定位
            }
            else
            {
                writeStream = new FileStream(filePath, FileMode.Create); // 文件不存在创建一个文件
                startPosition = 0;
            }*/

            if (!File.Exists(filePath))
            {
                writeStream = new FileStream(filePath, FileMode.Create); // 文件不存在创建一个文件
                                                                         //startPosition = 0;
                try
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url); // 打开网络连接

                    /*if (startPosition > 0)
                    {
                        myRequest.AddRange((int)startPosition); // 设置Range值, 定义远程文件读取位置
                    }*/

                    Stream readStream = myRequest.GetResponse().GetResponseStream(); // 获得服务器的回应数据流

                    StreamReader reader = new StreamReader(readStream);
                    string preLrc = reader.ReadToEnd();
                    JObject jo = JObject.Parse(preLrc);
                    string lrc = jo.SelectToken("lrc.lyric").ToString();
                    byte[] buffer = Encoding.UTF8.GetBytes(lrc);
                    writeStream.Write(buffer, 0, buffer.Length);

                    writeStream.Close();
                    readStream.Close();
                    reader.Close();

                    flag = true;        //返回true下载成功
                }
                catch
                {
                    writeStream.Close();
                    flag = false;       //返回false下载失败
                }
            }
            return flag;
           
        }
    }
}