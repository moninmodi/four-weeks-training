using System.Xml.Linq;

namespace LinqToXmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assume there is an XML document with the following structure:
            // <Books>
            //     <Book>
            //         <Title>Book Title 1</Title>
            //         <Author>Author 1</Author>
            //         <Genre>Genre 1</Genre>
            //     </Book>
            //     ...
            // </Books>
            // Write above book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>Book Title 1</Title>
                                        <Author>Author 1</Author>
                                        <Genre>Genre 1</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 2</Title>
                                        <Author>Author 2</Author>
                                        <Genre>Genre 2</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 3</Title>
                                        <Author>Author 3</Author>
                                        <Genre>Genre 3</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML string

            // Write the title of all books to the console

            // Write the title of all books with genre "Genre 1" to the console
            XDocument doc = XDocument.Parse(xmlString);
            XElement newBook = new XElement("Book", new XElement("Title", "Book Title 4"), new XElement("Author", "Author 4"), new XElement("Genre", "Genre 4"));
            doc.Root.Add(newBook);
            string modifiedString = doc.ToString();
            Console.WriteLine(modifiedString);
            var update = doc.Descendants("Book").Where(e => (string)e.Element("Title") == "Book Title 2").ToList();
            foreach( var e in update )
            {
                e.Element("Title").Value = "Harry Potter";
            }
            String x = doc.ToString();
            Console.WriteLine(x);
        }
    }
}