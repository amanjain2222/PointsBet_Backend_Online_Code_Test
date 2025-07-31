using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{


    public class StringFormatter
    {

        //improved code
        public static string ToCommaSeparatedList(string[] items, string quote) // fixed typo
        {
            if (items == null || items.Length < 1) // error handling - checking for nulls and empty items
            {
                return string.Empty;
            }

            StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0])); // initialising qry 

            for (int i = 1; i < items.Length; i++)
            {
                qry.Append(string.Format(", {0}{1}{0}", quote, items[i])); // appending subsiquent items to the string
            }

            return qry.ToString(); 

        }
    }
}
