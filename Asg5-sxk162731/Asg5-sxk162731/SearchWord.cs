using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* @ author :sxk162731
*/

namespace Asg5_sxk162731
{
    public class SearchWord
    {
       
        public class currentState
        {
            public int lines_processed = 0;
            public int SearchWordsMatched = 0;
            public long work_done = 0;
            public string matchedline = "";
            public int line_index = 0;
            public string match = "0";
        }

        public string source_file;
        public string search_String;
        private int SearchWord_counter = 0;
        private int lines_processed = 0;
        private long file_size = 0;
        private long size = 0;


        public void CountSearchWords(
            System.ComponentModel.BackgroundWorker worker,
            System.ComponentModel.DoWorkEventArgs e)
        {
            // Initialize the variables.  
            currentState state = new currentState();
            string line = "";
            int elapsedTime = 20;
            DateTime lastReportDateTime = DateTime.Now;

            if (search_String == null ||
                search_String == System.String.Empty)
            {
                throw new Exception("Search String not specified.");
            }

            FileInfo fi = new FileInfo(source_file);
            file_size = fi.Length;
            SearchWord_counter = 0;
            lines_processed = 0;  
            using (System.IO.StreamReader myStream = new System.IO.StreamReader(source_file))
            {
                // Process lines while there are lines remaining in the file.  
                while (!myStream.EndOfStream)
                {
                    size = size + System.Text.ASCIIEncoding.ASCII.GetByteCount(line);
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        line = myStream.ReadLine();
                        //SearchWord_counter += CountInString(line, search_String);
                        lines_processed = lines_processed + 1;

                        if (line.IndexOf(search_String, 0, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            state.match = "1";
                            state.matchedline = line;
                            state.line_index = lines_processed;
                            state.work_done = (size * 100) / file_size;
                            worker.ReportProgress(0, state);

                        }
                    }
                    // Uncomment for testing.  
                    System.Threading.Thread.Sleep(5);
                }
                myStream.ReadToEnd();
            }

        }

    }
}
