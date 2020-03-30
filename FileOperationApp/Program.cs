using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperationApp
{
    public class Program
    {
        public static int i;
        
        static void Main(string[] args)
        {
            Console.WriteLine("========== WelCome To FileOperationApp ==========");
            int choice;
            StreamWriter streamWriter;
            StreamReader streamReader;
            string ConcateData = "";
            string[] fileList = Directory.GetFiles(@"F:\Radixweb\C#\ProjectAnalysis\FileOperationApp\Files");


            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Create File");
                // Console.WriteLine("2.Write File");
                Console.WriteLine("3.Display contents of a file");
                Console.WriteLine("4.Copy File");
                Console.WriteLine("5.Rename File");
                Console.WriteLine("6.concatenate Two File");

                Console.WriteLine("0.Exit");

                Console.Write("\nEnter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("\n====== Create File =====");
                            /*F:\Radixweb\C#\ProjectAnalysis\FileOperationApp\Files*/

                            Console.Write("\nEnter File Name (Always Create Text File Ex : FileName.txt ) : ");
                            string FileName = Convert.ToString(Console.ReadLine());
                            FileInfo file = new FileInfo(FileName);
                            string extn = file.Extension;
                            if (extn == ".txt")
                            {
                                streamWriter = File.CreateText("F:\\Radixweb\\C#\\ProjectAnalysis\\FileOperationApp\\Files\\" + FileName);
                                streamWriter.WriteLine(DateTime.Now);
                                Console.Write("\n Write File Description : ");
                                string FileDescription = Convert.ToString(Console.ReadLine());
                                streamWriter.WriteLine(FileDescription);
                                streamWriter.Close();
                                Console.WriteLine("\n" + FileName + " File was created!!!");

                            }
                            else
                            {
                                Console.WriteLine("\n" + FileName + " File not created because extension was wrong !");

                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:

                        /* try
                         {

                             Console.WriteLine("\n====== Write File =====");

                             Console.WriteLine("\n\n====== List of Files =====");
                             foreach (string Files in fileList)
                             {
                                 Console.WriteLine(Files);
                             }
                             Console.WriteLine("\n\n=========================");

                             Console.Write("\nSelect File Name (write file name with extension) : ");
                             string FileName = Convert.ToString(Console.ReadLine());
                             FileInfo file = new FileInfo(FileName);
                             string extn = file.Extension;
                             if (extn == ".txt")
                             {

                                 Console.Write("\n Write File Description : ");
                                 string FileDescription = Convert.ToString(Console.ReadLine());
                                 *//*streamWriter.WriteLine(FileDescription);*/
                        /*streamWriter.Close();*//*
                        Console.WriteLine("\n" + FileName + " File write sucessfully !!!");

                    }
                    else
                    {
                        Console.WriteLine("\n" + FileName + " Not Write in file !!");

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }*/

                        break;
                    case 3:
                        Console.WriteLine("\n====== Display contents of a file =====");
                        Console.Write("Enter the filename you want to display content : ");
                        string fileName = Convert.ToString(Console.ReadLine());
                        streamReader = new StreamReader("F:\\Radixweb\\C#\\ProjectAnalysis\\FileOperationApp\\Files\\" + fileName + ".txt");
                        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                        string FileDesc = streamReader.ReadLine();
                        while (FileDesc != null)
                        {
                            Console.WriteLine(FileDesc);
                            FileDesc = streamReader.ReadLine();
                        }
                        streamReader.Close();
                        break;

                    case 4:
                        Console.WriteLine("\n====== Copy File =====");
                        Console.Write("Enter the Source  file Name : ");
                        string SourceFile = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter the Destination  file Name : ");
                        string destinationFile = Convert.ToString(Console.ReadLine());
                        File.Delete(destinationFile);
                        File.Copy("F:/Radixweb/C#/ProjectAnalysis/FileOperationApp/Files/" + SourceFile + ".txt", "" +
                            "F:/Radixweb/C#/ProjectAnalysis/FileOperationApp/Files/" + destinationFile + ".txt");

                        Console.WriteLine(SourceFile + "File Copy Successfully");

                        break;
                    case 5:
                        Console.WriteLine("\n====== Rename File =====");

                        Console.Write("Enter the Old  fileName : ");
                        string oldFile = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter the New fileName : ");
                        string NewFile = Convert.ToString(Console.ReadLine());
                        FileInfo files = new FileInfo("F://Radixweb//C#//ProjectAnalysis//FileOperationApp//Files//" + oldFile + ".txt");
                        if (files == null)
                        {
                            Console.WriteLine("\n File not renamed !!!");
                        }
                        else
                        {
                            files.MoveTo("F://Radixweb//C#//ProjectAnalysis//FileOperationApp//Files//" + NewFile + ".txt");
                            Console.WriteLine(NewFile + " File rename Successfully");
                        }

                        break;
                    case 6:
                        Console.WriteLine("\n====== concatenate Two File =====");


                        Console.Write("Enter the First fileName : ");
                        string FirstFile = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter the Second fileName : ");
                        string SecondFile = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter the Conacte fileName : ");
                        string ConcateFile = Convert.ToString(Console.ReadLine());

                        streamReader = new StreamReader("F://Radixweb//C#//ProjectAnalysis//FileOperationApp//Files//" + FirstFile + ".txt");
                        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                        string FirstFileData = streamReader.ReadLine();
                     
                        ConcateData += FirstFileData;
                        streamReader.Close();

                        streamReader = new StreamReader("F://Radixweb//C#//ProjectAnalysis//FileOperationApp//Files//" + SecondFile + ".txt");
                        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                        string SecondFileData = streamReader.ReadLine();

                        ConcateData += SecondFileData;
                        streamReader.Close();

                        streamWriter = new StreamWriter("F://Radixweb//C#//ProjectAnalysis//FileOperationApp//Files//" + ConcateFile + ".txt");
                        streamWriter.WriteLine("" + ConcateData);
                        streamWriter.Flush();
                        streamWriter.Close();
                        if (ConcateFile == null)
                        {
                            streamWriter.WriteLine("not Create Third File and not Concate the data");
                        }
                        else { 
                            streamWriter.Close();
                            //streamWriter.WriteLine("Create Third File and Concate the data");

                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (i > -1);
        }
    }
}
