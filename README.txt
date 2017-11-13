
# MultiThreadedTextSearch

It is an assignment in the subject of Human computer interaction with C# and .Net platform. 
Here we are searching a file for a particular string using multiple threads.

- Here user browses the filePath using browse button.
- After providing file path and text that should be searched, user clicks search button.
- Now search button converts into cancel, so if user wants to stop the search process, 
  he can click on this cancel button.
- Here, we are using 2 threads, 
  1) main thread, which prints the data in the form
  2) child thread, which reads the file and provides the search results to main thread to print details

- at the end, we get following outputs:
  1) line which contains the text, 
  2) its line number in the document
  3) total searched lines
  4) total search results
  5) the number of lines which contains the given text

- at the end the cancel button is converted back into the search button.
  
