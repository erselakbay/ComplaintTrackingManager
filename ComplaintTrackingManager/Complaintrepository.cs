using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework2
{
    class Complaintrepository
    {
        public Complaint getdata(string filename)
        {
            Complaint complaint = null;
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line = reader.ReadLine();
                    var lineArray = line.Split('\t');
   
                    complaint = new Complaint(Convert.ToString(lineArray[0]), Convert.ToInt32(lineArray[1]), Convert.ToInt32(lineArray[2]), Convert.ToInt32(lineArray[3]), Convert.ToInt32(lineArray[4]), Convert.ToInt32(lineArray[5]));
                
                }

                return complaint;

            }
            catch (Exception)
            {
                return new Complaint(filename, 0, 0, 0, 0, 0);

            }
        }

        public bool savedata(string filename, Complaint complaint)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(string.Join("\t", complaint.monthname, complaint.c1.ToString(), complaint.c2.ToString(), complaint.c3.ToString(), complaint.c4.ToString(), complaint.c5.ToString()));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
