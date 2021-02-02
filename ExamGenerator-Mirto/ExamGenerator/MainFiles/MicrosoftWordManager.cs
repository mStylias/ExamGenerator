using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.MainFiles
{
    public static class MicrosoftWordManager
    {
        /* Create document method. Returns true if successful and false otherwise */
        public static bool CreateExamDocument(string subjectName, List<Question> questions, string folderPath, string fileName, int layoutsNum)
        {
            try
            {
                //Create an instance for word app  
                Application winword = new Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                for (int i = 1; i <= layoutsNum; i++)
                {
                    //Create a new document  
                    Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                    //Add header into the document  
                    foreach (Section section in document.Sections)
                    {
                        //Get the header range and add the header details.  
                        Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
                        headerRange.Font.Size = 26;
                        headerRange.Text = subjectName;
                    }

                    //Add the footers into the document
                    foreach (Section wordSection in document.Sections)
                    {
                        //Get the footer range and add the footer details.  
                        Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                        footerRange.Font.Size = 10;
                        footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        footerRange.Text = "This exam was generated using ExamGenerator";
                    }

                    // Add the questions
                
                    Paragraph paragraphVariations = document.Content.Paragraphs.Add(ref missing);
                    paragraphVariations.Range.Text = "Variation " + i;
                    object styleHeading1 = WdBuiltinStyle.wdStyleHeading1;
                    paragraphVariations.Range.set_Style(ref styleHeading1);
                    paragraphVariations.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    paragraphVariations.Range.InsertParagraphAfter();


                    foreach (Question question in questions)
                    {
                        //Add Question Body
                        Paragraph paragraphTitle = document.Content.Paragraphs.Add(ref missing);
                        paragraphTitle.Range.Text = question.Body;
                        object styleHeading2 = WdBuiltinStyle.wdStyleHeading1;
                        paragraphTitle.Range.set_Style(ref styleHeading2);
                        paragraphTitle.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                        paragraphTitle.Range.InsertParagraphAfter();

                        // Add the answers
                        foreach (string answer in question.PossibleAnswers)
                        {
                            Paragraph paragraphContent = document.Content.Paragraphs.Add(ref missing);
                            paragraphContent.Range.Text = answer;
                            object styleHeading3 = WdBuiltinStyle.wdStyleNormal;
                            paragraphContent.Range.set_Style(ref styleHeading3);
                            paragraphContent.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                            paragraphContent.Range.InsertParagraphAfter();
                        }
                    }

                    questions.Shuffle();

                    //Save the document  
                    //object kati = Path.Combine()
                    //document.SaveAs2(ref kati);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    
                }
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }

}
