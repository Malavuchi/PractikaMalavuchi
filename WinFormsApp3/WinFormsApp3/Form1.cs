using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp3
{
    public partial class Antivirus_Form : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //timer.Interval = (1 * 1000); // 10 secs
            //timer.Tick += new EventHandler();
            //timer.Start();
        }
        public object getCPUCounter()
        {

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            // will always start at 0
            dynamic firstValue = cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            // now matches task manager reading
            dynamic secondValue = cpuCounter.NextValue();

            return secondValue;

        }

        int totalHits = 0;


        public Antivirus_Form()
        {
            InitializeComponent();
            button_Remove.Hide();



        }
        private int viruses = 0;
        // База вирусов
        string[] Basevirus = new string[] {"dota 2 beta"  };

        private void button2_Click(object sender, EventArgs e)
        {


            List<string> ListViruses = new List<string>(Basevirus);
            listBox_Diagnostic.Items.Clear();
            //Получение информации о дисках и их сканирование
            foreach (DriveInfo drive in DriveInfo.GetDrives())

            {
                string driveRoot = drive.RootDirectory.FullName;
                if (drive.IsReady)
                {
                    List<string> listDirectas = new List<string>(Directory.GetFileSystemEntries(driveRoot));
                    progressBar1.Maximum = listDirectas.Count +1 ;
                    listDirectas.Remove("Documents and Settings");
                    //проводим поиск в выбранном каталоге и во всех его подкаталогах
                    for (int i = 0; i < listDirectas.Count; i++)
                    {
                        progressBar1.Value += 1;

                        foreach (string vuriss in ListViruses)
                        {
                            try
                            {
                                foreach (string findedFile in Directory.GetFiles(listDirectas[i], vuriss, SearchOption.AllDirectories))
                                {
                                    if (findedFile != null)
                                    {
                                        button_Remove.Show();
                                        viruses += 1;
                                        label2.Text = ("Detected:" + viruses);
                                        for (int l = 0; l < findedFile.Length; l++)
                                        {
                                            string[] words = findedFile.Split(new char[] { '\\' });
                                            // Завершение процессов вируса
                                            // System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
                                            //int LastWords = words.Length-1;
                                            // try
                                            // {
                                            //     System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == words[LastWords] );
                                            //     target_proc.Kill();
                                            // }
                                            // catch (InvalidOperationException)
                                            // {
                                            //     MessageBox.Show("Process " + findedFile + " not found!");

                                            // }

                                        }
                                        listBox_Diagnostic.Items.Add(findedFile);
                                    }
                                }

                            }
                            catch (System.UnauthorizedAccessException ex)
                            {
                                for ( int okj = 0; okj < 1; okj++)
                                {
                                    try
                                    {
                                        string exmessage = ex.Message;


                                        string[] words = exmessage.Split(new char[] { ' ', '\\', });
                                        int wordslenght = words.Length;
                                        List<string> nicewords = new List<string> { };




                                        for (int oki = 4; oki != wordslenght - 3; oki++)
                                        {

                                            nicewords.Add(words[oki]);


                                        }
                                        List<string> nicepath = new List<string> { };
                                        for (int jok = 0; jok < nicewords.Count; jok++)
                                        {

                                            nicepath.Add(nicewords[jok] + '\\');

                                        }



                                        nicepath.Remove(nicepath[nicepath.Count - 1]);
                                        nicepath.Add(nicewords[nicewords.Count - 1]);
                                        char[] nicechar = nicepath[0].ToCharArray();
                                        List<char> nicecharlist = new List<char>(nicechar);
                                        nicecharlist.Remove(nicecharlist[0]);
                                        string nicecharready = string.Join(" ", nicecharlist);
                                        nicepath.Remove(nicepath[0]);
                                        List<string> nicepathjok = new List<string>();
                                        nicepathjok.Add(nicecharready);
                                        foreach (string strok in nicepath)
                                        {
                                            nicepathjok.Add(strok);
                                        }


                                        string nicepathready = string.Join(" ", nicepathjok);
                                        nicepathready = nicepathready.Replace(" ", "");
                                        List<string> listDirectasError = new List<string>(Directory.GetFiles(nicepathready));
                                        for (int pok = 0; pok < listDirectasError.Count; pok++)
                                        {

                                            
                                            
                                            
                                                try
                                                {
                                                    foreach (string findedFile in Directory.GetFiles(listDirectasError[pok], vuriss, SearchOption.AllDirectories))
                                                    {
                                                        if (findedFile != null)
                                                        {
                                                            button_Remove.Show();
                                                            viruses += 1;
                                                            label2.Text = ("Detected:" + viruses);
                                                            listBox_Diagnostic.Items.Add(findedFile);
                                                        }
                                                    }

                                                }
                                                catch
                                                {
                                                    continue;
                                                }
                                            
                                        }
                                    }
                                    catch
                                    {
                                        continue;
                                    }


                                }
                                






                            }



                            catch (System.IO.IOException ex)
                            {
                                for (int okj = 0; okj < 1; okj++)
                                {
                                    try
                                    {
                                        string exmessage = ex.Message;


                                        string[] words = exmessage.Split(new char[] { ' ', '\\', });
                                        int wordslenght = words.Length;
                                        List<string> nicewords = new List<string> { };




                                        for (int oki = 4; oki != wordslenght - 3; oki++)
                                        {

                                            nicewords.Add(words[oki]);


                                        }
                                        List<string> nicepath = new List<string> { };
                                        for (int jok = 0; jok < nicewords.Count; jok++)
                                        {

                                            nicepath.Add(nicewords[jok] + '\\');

                                        }



                                        nicepath.Remove(nicepath[nicepath.Count - 1]);
                                        nicepath.Add(nicewords[nicewords.Count - 1]);
                                        char[] nicechar = nicepath[0].ToCharArray();
                                        List<char> nicecharlist = new List<char>(nicechar);
                                        nicecharlist.Remove(nicecharlist[0]);
                                        string nicecharready = string.Join(" ", nicecharlist);
                                        nicepath.Remove(nicepath[0]);
                                        List<string> nicepathjok = new List<string>();
                                        nicepathjok.Add(nicecharready);
                                        foreach (string strok in nicepath)
                                        {
                                            nicepathjok.Add(strok);
                                        }


                                        string nicepathready = string.Join(" ", nicepathjok);
                                        nicepathready = nicepathready.Replace(" ", "");
                                        List<string> listDirectasError = new List<string>(Directory.GetFiles(nicepathready));
                                        for (int pok = 0; pok < listDirectasError.Count; pok++)
                                        {


                                            
                                            
                                                try
                                                {
                                                    foreach (string findedFile in Directory.GetFiles(listDirectasError[pok], vuriss, SearchOption.AllDirectories))
                                                    {
                                                        if (findedFile != null)
                                                        {
                                                            button_Remove.Show();
                                                            viruses += 1;
                                                            label2.Text = ("Detected:" + viruses);
                                                            listBox_Diagnostic.Items.Add(findedFile);
                                                        }
                                                    }

                                                }
                                                catch
                                                {
                                                    continue;
                                                }
                                            
                                        }
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                               
                            }





                        }
                        for (int kok = 0; kok < listDirectas.Count; kok++)
                        {
                            

                            foreach (string vuriss in ListViruses)
                            {
                                try
                                {
                                    foreach (string findedFile in Directory.GetDirectories(listDirectas[kok], vuriss, SearchOption.AllDirectories))
                                    {
                                        if (findedFile != null)
                                        {
                                            button_Remove.Show();
                                            viruses += 1;
                                            label2.Text = ("Detected:" + viruses);
                                            listBox_Diagnostic.Items.Add(findedFile);

                                        }
                                    }

                                }
                                catch (System.UnauthorizedAccessException ex)
                                {
                                    for ( int okj = 0; okj < 1; okj++)
                                    {
                                        try
                                        {
                                            string exmessage = ex.Message;


                                            string[] words = exmessage.Split(new char[] { ' ', '\\', });
                                            int wordslenght = words.Length;
                                            List<string> nicewords = new List<string> { };




                                            for (int oki = 4; oki != wordslenght - 3; oki++)
                                            {

                                                nicewords.Add(words[oki]);


                                            }
                                            List<string> nicepath = new List<string> { };
                                            for (int jok = 0; jok < nicewords.Count; jok++)
                                            {

                                                nicepath.Add(nicewords[jok] + '\\');

                                            }



                                            nicepath.Remove(nicepath[nicepath.Count - 1]);
                                            nicepath.Add(nicewords[nicewords.Count - 1]);
                                            char[] nicechar = nicepath[0].ToCharArray();
                                            List<char> nicecharlist = new List<char>(nicechar);
                                            nicecharlist.Remove(nicecharlist[0]);
                                            string nicecharready = string.Join(" ", nicecharlist);
                                            nicepath.Remove(nicepath[0]);
                                            List<string> nicepathjok = new List<string>();
                                            nicepathjok.Add(nicecharready);
                                            foreach (string strok in nicepath)
                                            {
                                                nicepathjok.Add(strok);
                                            }


                                            string nicepathready = string.Join(" ", nicepathjok);
                                            nicepathready = nicepathready.Replace(" ", "");
                                            List<string> listDirectasError = new List<string>(Directory.GetDirectories(nicepathready));
                                            for (int pok = 0; pok < listDirectasError.Count; pok++)
                                            {


                                                
                                                    try
                                                    {
                                                        foreach (string findedFile in Directory.GetDirectories(listDirectasError[pok], vuriss, SearchOption.AllDirectories))
                                                        {
                                                            if (findedFile != null)
                                                            {
                                                                button_Remove.Show();
                                                                viruses += 1;
                                                                label2.Text = ("Detected:" + viruses);
                                                                listBox_Diagnostic.Items.Add(findedFile);
                                                            }
                                                        }

                                                    }
                                                    catch
                                                    {
                                                        continue;
                                                    }
                                                
                                            }
                                        }
                                        catch
                                        {
                                            continue;
                                        }

                                    }
                                   
                                   
                                }
                                catch (System.IO.IOException ex)
                                {
                                    for (int okj = 1; okj < 1; okj++)
                                    {

                                        try
                                        {
                                            string exmessage = ex.Message;


                                            string[] words = exmessage.Split(new char[] { ' ', '\\', });
                                            int wordslenght = words.Length;
                                            List<string> nicewords = new List<string> { };




                                            for (int oki = 4; oki != wordslenght - 3; oki++)
                                            {

                                                nicewords.Add(words[oki]);


                                            }
                                            List<string> nicepath = new List<string> { };
                                            for (int jok = 0; jok < nicewords.Count; jok++)
                                            {

                                                nicepath.Add(nicewords[jok] + '\\');

                                            }



                                            nicepath.Remove(nicepath[nicepath.Count - 1]);
                                            nicepath.Add(nicewords[nicewords.Count - 1]);
                                            char[] nicechar = nicepath[0].ToCharArray();
                                            List<char> nicecharlist = new List<char>(nicechar);
                                            nicecharlist.Remove(nicecharlist[0]);
                                            string nicecharready = string.Join(" ", nicecharlist);
                                            nicepath.Remove(nicepath[0]);
                                            List<string> nicepathjok = new List<string>();
                                            nicepathjok.Add(nicecharready);
                                            foreach (string strok in nicepath)
                                            {
                                                nicepathjok.Add(strok);
                                            }


                                            string nicepathready = string.Join(" ", nicepathjok);
                                            nicepathready = nicepathready.Replace(" ", "");
                                            List<string> listDirectasError = new List<string>(Directory.GetDirectories(nicepathready));
                                            for (int pok = 0; pok < listDirectasError.Count; pok++)
                                            {


                                                
                                                    try
                                                    {
                                                        foreach (string findedFile in Directory.GetDirectories(listDirectasError[pok], vuriss, SearchOption.AllDirectories))
                                                        {
                                                            if (findedFile != null)
                                                            {
                                                                button_Remove.Show();
                                                                viruses += 1;
                                                                label2.Text = ("Detected:" + viruses);
                                                                listBox_Diagnostic.Items.Add(findedFile);
                                                            }
                                                        }

                                                    }
                                                    catch
                                                    {
                                                        continue;
                                                    }
                                                
                                            }
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                   
                                }

                            }



                        }
                    }
                }
                else
                {
                    continue;
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            viruses = 0;
            progressBar1.Value = 0;
            listBox_Diagnostic.Items.Clear();
            button_Scan.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // Удаление вирусов
            DialogResult result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)

            {
                object[] ar = new object[listBox_Diagnostic.Items.Count];
                listBox_Diagnostic.Items.CopyTo(ar, 0);


                foreach (string s in ar)
                {

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(s);

                }
                listBox_Diagnostic.Items.Clear();
                MessageBox.Show("Вирусы удалены!");

            }
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_ProcessList_Click(object sender, EventArgs e)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            // will always start at 0
            dynamic firstValue = cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            // now matches task manager reading
            dynamic secondValue = cpuCounter.NextValue();

            int cpuPercent = (int)secondValue;
            if (cpuPercent >= 90)
            {
                totalHits = totalHits + 1;
                if (totalHits == 60)
                {
                    MessageBox.Show("ALERT 90% usage for 1 minute");
                    totalHits = 0;
                }
            }
            else
            {
                totalHits = 0;
            }
            label_Proverka.Text = cpuPercent + " % CPU";
            //Label2.Text = getRAMCounter() + " RAM Free";
            Label_Proverka2.Text = totalHits + " seconds over 20% usage";

            Process[] procList = Process.GetProcesses();
            string[] STRprocList = new string[procList.Count()];
            for (int i = 0; i < procList.Count(); i++)
            {

                STRprocList[i] = procList[i].ToString();

            }

            string[] processSTR = new string[procList.Count()];

            for (int i = 0; i < processSTR.Length; i++)
            {
                string[] words = STRprocList[i].Split(new char[] { ' ', '(', ')' });
                processSTR[i] = words[2];


            }
            List<string> listprocessstr = new List<string>(processSTR);

            listprocessstr.Remove("System"); listprocessstr.Remove("svchost"); listprocessstr.Remove("Memory"); listprocessstr.Remove("Idle");
            progressBar1.Refresh();
            progressBar1.Maximum = listprocessstr.Count();


            for (int io = 0; io < 100; io++)
            {
                try
                {
                    listprocessstr.Remove("svchost");

                }

                catch
                {
                    continue;
                }
            }
            for (int io = 0; io < 100; io++)
            {
                try
                {
                    listprocessstr.Remove("browser");

                }

                catch
                {
                    continue;
                }
            }
            // This will return the process usage as a percent of total processor utilisation.
            for (int n = 0; n < listprocessstr.Count(); n++)
            {
                progressBar1.Value += 1;
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", listprocessstr[n]);
                double cpu = 0;
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cpu = cpuCounter.NextValue();
                        if (cpu != 0) break;
                    }

                    catch (System.InvalidOperationException)
                    {
                        continue;
                    }
                }
                if (cpu > 20)
                {
                    foreach (DriveInfo drive in DriveInfo.GetDrives())

                    {
                        string driveRoot = drive.RootDirectory.FullName;
                        if (drive.IsReady)
                        {
                            List<string> listDirectas = new List<string>(Directory.GetFileSystemEntries(driveRoot));
                            progressBar1.Maximum = listDirectas.Count;
                            //проводим поиск в выбранном каталоге и во всех его подкаталогах
                            for (int i = 0; i < listDirectas.Count; i++)
                            {

                                try
                                {
                                    foreach (string findedFile in Directory.GetFileSystemEntries(listDirectas[i], listprocessstr[n] + ".exe", SearchOption.AllDirectories))
                                    {
                                        if (findedFile != null)
                                        {
                                            button_Remove.Show();
                                            viruses += 1;
                                            label2.Text = ("Detected:" + viruses);
                                            for (int l = 0; l < findedFile.Length; l++)
                                            {
                                                string[] words = findedFile.Split(new char[] { '\\' });
                                                // Завершение процессов вируса
                                                // System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
                                                //int LastWords = words.Length-1;
                                                // try
                                                // {
                                                //     System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == words[LastWords] );
                                                //     target_proc.Kill();
                                                // }
                                                // catch (InvalidOperationException)
                                                // {
                                                //     MessageBox.Show("Process " + findedFile + " not found!");

                                                // }

                                            }
                                            listBox_Diagnostic.Items.Add(findedFile);
                                        }
                                    }

                                }
                                catch (System.UnauthorizedAccessException)
                                {
                                    continue;
                                }
                                catch (System.IO.IOException)
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

               

            }
        }
    }
}