using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Convert;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        readonly StringBuilder numbers = new StringBuilder("0123456789");

        readonly StringBuilder rusZaglChars = new StringBuilder("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

        readonly StringBuilder rusPropChars = new StringBuilder("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");

        readonly StringBuilder latZaglChars = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

        readonly StringBuilder latPropChars = new StringBuilder("abcdefghijklmnopqrstuvwxyz");

        StringBuilder lastArray = new StringBuilder("");

        private readonly string path = "D:\\Timur\\passwords.txt";

        private Thread thread;
        private Random rnd;
        static AutoResetEvent waitHandler = new AutoResetEvent(true);

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckEqualStr(int passNumb, int symbolNum, ref StringBuilder result, ref int tmp)
        {
            int i, j;
            for (i = 0; i < passNumb * (symbolNum + 2) - 1; i += symbolNum + 2)
            {
                j = i + symbolNum + 2;
                for (; j < passNumb * (symbolNum + 2) - 1; j += symbolNum + 2)
                {
                    int countI = i;
                    int countJ = j;
                    int count = 0;
                    while (result[countI] != '\r')
                    {
                        if (result[countI] == result[countJ])
                        {
                            countI++;
                            countJ++;
                            count++;
                            if (count >= symbolNum)
                            {
                                tmp++;
                                result.Remove(j, symbolNum + 2);
                                j -= (symbolNum + 2);
                                passNumb--;
                            }
                        }
                        else
                            break;
                    }
                }
            }
        }

        private void WritePasswords(StringBuilder result)
        {
            lock (new object())
            {
                waitHandler.WaitOne();
                using (FileStream fileStream = new FileStream($"{path}", FileMode.Append))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(result.ToString());
                    fileStream.Write(array, 0, array.Length);
                }
                waitHandler.Set();
            }
        }

        private StringBuilder ReadPasswords(int symbolNum)
        {
            StringBuilder stringToTB = new StringBuilder("");
            using (FileStream fileStream = File.OpenRead($"{path}"))
            {
                byte[] arr = new byte[(symbolNum + 2) * 10];
                fileStream.Read(arr, 0, (symbolNum + 2) * 10);
                stringToTB.Append(Encoding.Default.GetString(arr));
            }

            return stringToTB;
        }

        private void GeneratePassword(int passNum, int symbolNum, Random random)
        {
            int tmp = 0;
            int count = 4;
            int capacity = passNum / count;
            btngenerate.Enabled = false;
            btnopenfile.Enabled = false;

            while (capacity > 15000000)
            {
                count++;
                capacity = passNum / count;
            }

            StringBuilder result = new StringBuilder("");

            for (int k = 0; k < count; k++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                result.Clear();

                for (int q = 0; q < capacity; q++)
                {
                    for (int i = 0; i < symbolNum; i++)
                        result.Append(lastArray[random.Next(lastArray.Length)]);
                    result.Append("\r\n");
                }

                Thread threadToCheckPasswords = new Thread(() => CheckEqualStr(capacity, symbolNum, ref result, ref tmp));
                threadToCheckPasswords.Start();
                //threadToCheckPasswords.Join();
                Thread threadToWritePasswords = new Thread(() => WritePasswords(result));
                threadToWritePasswords.Start();

                stopwatch.Stop();

                richTextBox1.Text += $"{capacity} passwords for {stopwatch.ElapsedMilliseconds} milliseconds" + Environment.NewLine;
                richTextBox1.Text += $"Equal {tmp} passwords" + Environment.NewLine;
            }
            richTextBox1.Text += Environment.NewLine + ReadPasswords(symbolNum);
            btngenerate.Enabled = true;
            btnopenfile.Enabled = true;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            thread.Start();
        }
        private void BtnGenerate_MouseEnter(object sender, EventArgs e)
        {
            lastArray.Clear();
            int passNum = ToInt32(dUDpassnumb.Text);
            int symbolNum = ToInt32(dUDsymbnumb.Text);
            rnd = new Random(DateTime.Now.Millisecond);

            richTextBox1.Clear();

            if (chbnumb.Checked)//юзать цифры
                lastArray.Append(numbers);

            if (chbsymb.Checked)//юзать спецсимволы
                lastArray.Append(tbsymb.Text);

            if (chblatzagl.Checked)//юзать латинские заглавные
                lastArray.Append(latZaglChars);

            if (chblatprop.Checked)//юзать латинские прописные
                lastArray.Append(latPropChars);

            if (chbruszagl.Checked)//юзать русские заглавные
                lastArray.Append(rusZaglChars);

            if (chbrusprop.Checked)//юзать русские прописные
                lastArray.Append(rusPropChars);

            thread = new Thread(() => GeneratePassword(passNum, symbolNum, rnd));
        }
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\\Timur\\passwords.txt");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
