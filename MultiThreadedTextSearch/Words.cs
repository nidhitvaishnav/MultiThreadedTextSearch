using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Author: Nidhi Vaishnav
 * Course: Human Computer Interaction : CS 6326 Fall 2017
 * netid: 170030
 * */

namespace MultiThreadedTextSearch
{
    class Words
    {
        // Object to store the current state, for passing to the caller. 
        public class CurrentState
        {
            public int linesCounted;
            public int wordsMatched;
            public int lineNo;
            public string lineData;
        }

        public string SourceFile;
        public string CompareString;
        private int WordCount;
        private int matchedLineNo;
        private string matchedLineData;
        private int LinesCounted;

        public void CountWords(System.ComponentModel.BackgroundWorker worker,
                                System.ComponentModel.DoWorkEventArgs e)
        {
            //Initialize the variables
            CurrentState state = new CurrentState();
            String line = "";
            int elapsedTime = 20;
            DateTime lastReportDataTime = DateTime.Now;

            if (CompareString == null || CompareString == System.String.Empty)
            {
                throw new Exception("Compare string is not found");
            }

            //open a new stream
            using (System.IO.StreamReader myStream = new System.IO.StreamReader(SourceFile))
            {
                //process lines while there are lines remaining in file
                while (!myStream.EndOfStream)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        line = myStream.ReadLine();
                        int prevWordCount = WordCount;
                        WordCount += CountInString(line, CompareString);
                        LinesCounted += 1;
                        if (WordCount > prevWordCount) {
                            matchedLineData = line;
                            matchedLineNo = LinesCounted;
                            //raise an event so the form can monitor the progress
                            state.linesCounted = LinesCounted;
                            state.wordsMatched = WordCount;
                            state.lineData = matchedLineData;
                            state.lineNo = matchedLineNo;
                            worker.ReportProgress(0, state);

                        }

                        int compare = DateTime.Compare(DateTime.Now, lastReportDataTime.AddMilliseconds(elapsedTime));
                        if (compare > 0)
                        {
                            state.linesCounted = LinesCounted;
                            state.wordsMatched = WordCount;
                            state.lineData = matchedLineData;
                            state.lineNo = matchedLineNo;
                            worker.ReportProgress(0, state);
                            lastReportDataTime = DateTime.Now;
                        }
                    }
                    //uncomment for testing
                    System.Threading.Thread.Sleep(1);
                }
                //Report the final count value
                state.linesCounted = LinesCounted;
                state.wordsMatched = WordCount;
                state.lineData = matchedLineData;
                state.lineNo = matchedLineNo;
                worker.ReportProgress(0, state);
            }
        }
        private int CountInString(string SourceString, string CompareString)
        {
            //This function counts the number of times  a word is found in the line
            if (SourceString == null)
            {
                return 0;
            }
            string EscapedCompareString = System.Text.RegularExpressions.Regex.Escape(CompareString);
            System.Text.RegularExpressions.Regex regex;
            regex = new System.Text.RegularExpressions.Regex(
                    // To count all occurrences of the string, even within words, remove 
                    // both instances of @"\b" from the following line.
                    @"\b" + EscapedCompareString + @"\b",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            System.Text.RegularExpressions.MatchCollection matches;
            matches = regex.Matches(SourceString);
            return matches.Count;

        }
    }
}
